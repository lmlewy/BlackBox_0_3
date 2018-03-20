using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.IO;
using System.Collections.ObjectModel;
//using System.Windows.Data;
using DataGridViewAutoFilter;
using System.Collections;

namespace SPA5BlackBoxReader
{
    public partial class MainForm : Form
    {
        CultureInfo ci = null;
        ResourceManager resmgr = new ResourceManager("SPA5BlackBoxReader.Lang", typeof(MainForm).Assembly);

        private BackgroundWorker binHexBackgroundWorker = null;
        private BackgroundWorker decodeMessagesBackgroundWorker = null;

        DataTable table = new DataTable();

        string[] filesToRead;
 
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ci = new CultureInfo("en-GB");
            CultureInfo.DefaultThreadCurrentCulture = ci;

            updateLabels();
            richTextBoxBin.Multiline = true;

            comboBoxLxNumber.Items.Add("*");
            comboBoxLxNumber.SelectedText = "*";

            comboBoxLxChannel.Items.Add("*");
            comboBoxLxChannel.SelectedText = "*";

            comboBoxEvAl.Items.Add("*");
            comboBoxEvAl.SelectedText = "*";

            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "dd/MM/yyyy hh:mm:ss";

            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "dd/MM/yyyy hh:mm:ss";  

        }

        private void updateLabels()
        {
            this.labelFileToolStripMenuItem.Text = resmgr.GetString("labelFile", ci);
            this.labelReadToolStripMenuItem.Text = resmgr.GetString("labelRead", ci);
            this.labelDecodeToolStripMenuItem.Text = resmgr.GetString("labelDecode", ci);
            this.labelChngLangToolStripMenuItem.Text = resmgr.GetString("labelChngLang", ci);
            this.labelStopToolStripMenuItem.Text = resmgr.GetString("labelStop", ci);
            this.labelCloseToolStripMenuItem.Text = resmgr.GetString("labelClose", ci);

            this.labelInfoToolStripMenuItem.Text = resmgr.GetString("labelInfo", ci);
            this.labelAboutProgToolStripMenuItem.Text = resmgr.GetString("labelAboutProg", ci);

            this.tabPageBin.Text = resmgr.GetString("labelBin", ci);
            this.tabPageDecEventTable.Text = resmgr.GetString("labelDecEventTable", ci);

        }

        private void polskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ci = new CultureInfo("pl-PL");
            CultureInfo.DefaultThreadCurrentCulture = ci;
            updateLabels();
            if (filesToRead != null) showData(filesToRead);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ci = new CultureInfo("en-GB");
            CultureInfo.DefaultThreadCurrentCulture = ci;
            updateLabels();
            if (filesToRead != null) showData(filesToRead);
        }


        private void labelReadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            var iResult = DialogResult;
            openFileDialog1.Title = "Podaj plik czarnej skrzynki";
            openFileDialog1.Filter = "BIN Files (*.bin) | *.bin";

            openFileDialog1.CheckFileExists = true;
            iResult = openFileDialog1.ShowDialog();

            if ((iResult != System.Windows.Forms.DialogResult.Cancel) && (openFileDialog1.FileName.Length != 0))
            {
                string sConStr;
                sConStr = openFileDialog1.FileName;
                byte[] fileBytes = File.ReadAllBytes(@sConStr);
 
                List<string> itemsList = new List<string>();
                BinToListReader btlr = new BinToListReader();
                itemsList = btlr.ReadFile(fileBytes).ToList();

                string calosc = "";

                for (int i = 0; i < itemsList.Count; i++)
                    calosc = calosc + itemsList[i] + '\n';
                
                tabControl.SelectTab(tabPageBin);
                richTextBoxBin.Clear();
                richTextBoxBin.Text = calosc;
            }

        }


        private void labelStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((null != binHexBackgroundWorker) && binHexBackgroundWorker.IsBusy)
            {
                binHexBackgroundWorker.CancelAsync();
            }

            if ((null != decodeMessagesBackgroundWorker) && decodeMessagesBackgroundWorker.IsBusy)
            {
                decodeMessagesBackgroundWorker.CancelAsync();
            }
        }


        private void labelCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelDecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            var iResult = DialogResult;
            openFileDialog1.Title = "Podaj plik czarnej skrzynki";
            openFileDialog1.Filter = "BIN Files (*.bin) | *.bin";
            openFileDialog1.Multiselect = true;

            openFileDialog1.CheckFileExists = true;
            iResult = openFileDialog1.ShowDialog();

            if ((iResult != System.Windows.Forms.DialogResult.Cancel) && (openFileDialog1.FileName.Length != 0))
            {
                filesToRead = openFileDialog1.FileNames;
                showData(filesToRead);
            }

        }

        private void showData(string[] filesToRead)
        {

            //tabControl.SelectTab(tabPageDecEventTable);
            //List<string[]> decodedFramesList = new List<string[]>();

            ////https://msdn.microsoft.com/en-us/library/system.windows.forms.bindingsource.filter(v=vs.110).aspx
            ////https://msdn.microsoft.com/en-us/library/aa480727.aspx
            ////https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/bind-data-to-the-datagrid-using-the-designer

            //DataTable table = new DataTable();
            //table.Columns.Add(resmgr.GetString("labelTime", ci), typeof(string));
            //table.Columns.Add(resmgr.GetString("labelLxNumber", ci), typeof(string));
            //table.Columns.Add(resmgr.GetString("labelChannel", ci), typeof(string));
            //table.Columns.Add(resmgr.GetString("labelNumber", ci), typeof(string));
            //table.Columns.Add(resmgr.GetString("labelName", ci), typeof(string));
            //table.Columns.Add(resmgr.GetString("labelStatus", ci), typeof(string));
            //table.Columns.Add(resmgr.GetString("labelCategory", ci), typeof(string));
            //table.Columns.Add(resmgr.GetString("labelGroup", ci), typeof(string));
            ////binding1 = new BindingSource(DataTable table);

            //foreach (String FileName in filesToRead)
            //{
            //    byte[] fileBytes = File.ReadAllBytes(@FileName);
            //    ListOfFrames decodedList = new ListOfFrames();
            //    decodedFramesList = decodedList.DecodeFileAsList(fileBytes);

            //    foreach (var row in decodedFramesList)
            //    {
            //        table.Rows.Add(row);
            //    }

            //    dataGridViewEventsAndAlarms.DataSource = table;
            //}

            //DataGridViewColumn column = dataGridViewEventsAndAlarms.Columns[0];
            //column.Width = 130;
            ////column.
            //column = dataGridViewEventsAndAlarms.Columns[1];
            //column.Width = 60;
            ////column.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(column);
            //column = dataGridViewEventsAndAlarms.Columns[2];
            //column.Width = 60;
            //column = dataGridViewEventsAndAlarms.Columns[3];
            //column.Width = 110;
            //column = dataGridViewEventsAndAlarms.Columns[4];
            //column.Width = 200;
            //column = dataGridViewEventsAndAlarms.Columns[7];
            //column.Width = 70;
            ////dataGridViewEventsAndAlarms.Sort(dataGridViewEventsAndAlarms.Columns[1], ListSortDirection.Ascending); to nic nie daje

            //// Do tego miejsca było robione po staremu



            // od tego miejsca po nowemu
            // https://msdn.microsoft.com/en-us/library/Aa480727.aspx

            tabControl.SelectTab(tabPageDecEventTable);
            List<string[]> decodedFramesList = new List<string[]>();

            //DataTable table = new DataTable();
            table.Columns.Add(resmgr.GetString("labelTime", ci), typeof(string)) ;
            table.Columns.Add(resmgr.GetString("labelLxNumber", ci), typeof(string));
            table.Columns.Add(resmgr.GetString("labelChannel", ci), typeof(string));
            table.Columns.Add(resmgr.GetString("labelNumber", ci), typeof(string));
            table.Columns.Add(resmgr.GetString("labelName", ci), typeof(string));
            table.Columns.Add(resmgr.GetString("labelStatus", ci), typeof(string));
            table.Columns.Add(resmgr.GetString("labelCategory", ci), typeof(string));
            table.Columns.Add(resmgr.GetString("labelGroup", ci), typeof(string));

            foreach (String FileName in filesToRead)
            {
                byte[] fileBytes = File.ReadAllBytes(@FileName);
                ListOfFrames decodedList = new ListOfFrames();
                decodedFramesList = decodedList.DecodeFileAsList(fileBytes);

                foreach (var row in decodedFramesList)
                {
                    table.Rows.Add(row);
                }

            }

            //dataGridViewEventsAndAlarms.DataSource = table;
            updateDataGridViewEventsAndAlarms(table);

            //https://stackoverflow.com/questions/199642/how-to-insert-empty-field-in-combobox-bound-to-datatable

            //List<KeyValuePair<string, Guid>> list = new List<KeyValuePair<string, Guid>>(table.Rows.Cast<DataRow>().Select(row => new KeyValuePair<string, Guid>(row["Name"].ToString(), (Guid)row["Guid"])));
            List<string> listLxNum = new List<string>(table.Rows.Cast<DataRow>().Select(row => row[resmgr.GetString("labelLxNumber", ci)].ToString()));
            //list.Insert(0, new KeyValuePair<string, Guid>(string.Empty, Guid.Empty));
            listLxNum.Insert(0, "*");
            listLxNum = listLxNum.Distinct().ToList();
            comboBoxLxNumber.DataSource = listLxNum;
            //comboBoxLxNumber.ValueMember = "Value";
            //comboBoxLxNumber.DisplayMember = "Key";

            List<string> listLxChannel = new List<string>(table.Rows.Cast<DataRow>().Select(row => row[resmgr.GetString("labelChannel", ci)].ToString()));
            listLxChannel.Insert(0, "*");
            listLxChannel = listLxChannel.Distinct().ToList();
            comboBoxLxChannel.DataSource = listLxChannel;
            //comboBoxLxChannel.DisplayMember = "Key";

            List<string> listLxEvAl = new List<string>();
            listLxEvAl.Insert(0, "*");
            listLxEvAl.Insert(1, "Event");
            listLxEvAl.Insert(2, "Alert");
            comboBoxEvAl.DataSource = listLxEvAl;
            //comboBoxEvAl.DisplayMember = "Key";












        }

        private void comboBoxLxNumber_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable filteredDataTable = null;

            if ((comboBoxLxNumber.SelectedItem != "*") && (comboBoxLxChannel.SelectedItem != "*"))
            {

                MessageBox.Show("nie pusty");

                //https://stackoverflow.com/questions/13012585/how-i-can-filter-a-datatable
                //http://www.csharp-examples.net/dataview-rowfilter/
                string _sqlWhere = resmgr.GetString("labelChannel", ci) + " = '" + comboBoxLxChannel.SelectedItem + "'";
                filteredDataTable = table.Select(_sqlWhere).CopyToDataTable();

                updateDataGridViewEventsAndAlarms(filteredDataTable);

            }
            else
            {
                MessageBox.Show("pusty");
                updateDataGridViewEventsAndAlarms(table);
            }


            //updateDataGridViewEventsAndAlarms(filteredDataTable);
        }


        private void updateDataGridViewEventsAndAlarms(DataTable dt)
        {
            dataGridViewEventsAndAlarms.DataSource = dt;

            if (dt != null) //to nie działa
            {
                DataGridViewColumn column = dataGridViewEventsAndAlarms.Columns[0];
                column.Width = 130;
                column = dataGridViewEventsAndAlarms.Columns[1];
                column.Width = 60;
                column = dataGridViewEventsAndAlarms.Columns[2];
                column.Width = 60;
                column = dataGridViewEventsAndAlarms.Columns[3];
                column.Width = 110;
                column = dataGridViewEventsAndAlarms.Columns[4];
                column.Width = 200;
                column = dataGridViewEventsAndAlarms.Columns[5];
                column.Width = 110;
                column = dataGridViewEventsAndAlarms.Columns[6];
                column.Width = 110;
                column = dataGridViewEventsAndAlarms.Columns[7];
                column.Width = 70;
            }
        }



        // iterator dla combobox
        //private IEnumerable GetDisplayTable(DataTable tbl)
        //{
        //    //yield return new { ObjectLogicalName = string.Empty, guid = Guid.Empty };
        //    yield return new { ObjectLogicalName = string.Empty};

        //    foreach (DataRow row in tbl.Rows)
        //        //yield return new { ObjectLogicalName = row["ObjectLogicalName"].ToString(), guid = (Guid)row["guid"] };
        //        yield return new { ObjectLogicalName = row[resmgr.GetString("labelLxNumber", ci)].ToString() };
        //}



        //private void dataGridViewEventsAndAlarms_BindingContextChanged(object sender, EventArgs e)
        //{
        //    if (dataGridViewEventsAndAlarms.DataSource == null) return;

        //    foreach (DataGridViewColumn col in dataGridViewEventsAndAlarms.Columns)
        //    {
        //        col.HeaderCell = new
        //            DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell);
        //    }
        //    dataGridViewEventsAndAlarms.AutoResizeColumns();
        //}

    }
}
