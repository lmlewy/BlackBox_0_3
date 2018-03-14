﻿namespace SPA5BlackBoxReader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelReadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelChngLangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAboutProgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageDecEventTable = new System.Windows.Forms.TabPage();
            this.dataGridViewEventsAndAlarms = new System.Windows.Forms.DataGridView();
            this.tabPageBin = new System.Windows.Forms.TabPage();
            this.richTextBoxBin = new System.Windows.Forms.RichTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPageDecEventTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsAndAlarms)).BeginInit();
            this.tabPageBin.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Margin = new System.Windows.Forms.Padding(12, 3, 1, 3);
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(400, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelFileToolStripMenuItem,
            this.labelInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelFileToolStripMenuItem
            // 
            this.labelFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelReadToolStripMenuItem,
            this.labelDecodeToolStripMenuItem,
            this.labelChngLangToolStripMenuItem,
            this.labelStopToolStripMenuItem,
            this.labelCloseToolStripMenuItem});
            this.labelFileToolStripMenuItem.Name = "labelFileToolStripMenuItem";
            this.labelFileToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.labelFileToolStripMenuItem.Text = "labelFile";
            // 
            // labelReadToolStripMenuItem
            // 
            this.labelReadToolStripMenuItem.Name = "labelReadToolStripMenuItem";
            this.labelReadToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.labelReadToolStripMenuItem.Text = "labelRead";
            this.labelReadToolStripMenuItem.Click += new System.EventHandler(this.labelReadToolStripMenuItem_Click);
            // 
            // labelDecodeToolStripMenuItem
            // 
            this.labelDecodeToolStripMenuItem.Name = "labelDecodeToolStripMenuItem";
            this.labelDecodeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.labelDecodeToolStripMenuItem.Text = "labelDecode";
            this.labelDecodeToolStripMenuItem.Click += new System.EventHandler(this.labelDecodeToolStripMenuItem_Click);
            // 
            // labelChngLangToolStripMenuItem
            // 
            this.labelChngLangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polskiToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.labelChngLangToolStripMenuItem.Name = "labelChngLangToolStripMenuItem";
            this.labelChngLangToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.labelChngLangToolStripMenuItem.Text = "labelChngLang";
            // 
            // polskiToolStripMenuItem
            // 
            this.polskiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("polskiToolStripMenuItem.Image")));
            this.polskiToolStripMenuItem.Name = "polskiToolStripMenuItem";
            this.polskiToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.polskiToolStripMenuItem.Text = "Polski";
            this.polskiToolStripMenuItem.Click += new System.EventHandler(this.polskiToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("englishToolStripMenuItem.Image")));
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // labelStopToolStripMenuItem
            // 
            this.labelStopToolStripMenuItem.Name = "labelStopToolStripMenuItem";
            this.labelStopToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.labelStopToolStripMenuItem.Text = "labelStop";
            this.labelStopToolStripMenuItem.Click += new System.EventHandler(this.labelStopToolStripMenuItem_Click);
            // 
            // labelCloseToolStripMenuItem
            // 
            this.labelCloseToolStripMenuItem.Name = "labelCloseToolStripMenuItem";
            this.labelCloseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.labelCloseToolStripMenuItem.Text = "LabelClose";
            this.labelCloseToolStripMenuItem.Click += new System.EventHandler(this.labelCloseToolStripMenuItem_Click);
            // 
            // labelInfoToolStripMenuItem
            // 
            this.labelInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelAboutProgToolStripMenuItem});
            this.labelInfoToolStripMenuItem.Name = "labelInfoToolStripMenuItem";
            this.labelInfoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.labelInfoToolStripMenuItem.Text = "labelInfo";
            // 
            // labelAboutProgToolStripMenuItem
            // 
            this.labelAboutProgToolStripMenuItem.Name = "labelAboutProgToolStripMenuItem";
            this.labelAboutProgToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.labelAboutProgToolStripMenuItem.Text = "labelAboutProg";
            // 
            // tabPageDecEventTable
            // 
            this.tabPageDecEventTable.Controls.Add(this.comboBox1);
            this.tabPageDecEventTable.Controls.Add(this.dataGridViewEventsAndAlarms);
            this.tabPageDecEventTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageDecEventTable.Name = "tabPageDecEventTable";
            this.tabPageDecEventTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDecEventTable.Size = new System.Drawing.Size(895, 387);
            this.tabPageDecEventTable.TabIndex = 2;
            this.tabPageDecEventTable.Text = "tabPageDecEventTable";
            this.tabPageDecEventTable.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEventsAndAlarms
            // 
            this.dataGridViewEventsAndAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEventsAndAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventsAndAlarms.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewEventsAndAlarms.Name = "dataGridViewEventsAndAlarms";
            this.dataGridViewEventsAndAlarms.Size = new System.Drawing.Size(883, 316);
            this.dataGridViewEventsAndAlarms.TabIndex = 0;
            this.dataGridViewEventsAndAlarms.BindingContextChanged += new System.EventHandler(this.dataGridViewEventsAndAlarms_BindingContextChanged);
            // 
            // tabPageBin
            // 
            this.tabPageBin.Controls.Add(this.richTextBoxBin);
            this.tabPageBin.Location = new System.Drawing.Point(4, 22);
            this.tabPageBin.Name = "tabPageBin";
            this.tabPageBin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBin.Size = new System.Drawing.Size(895, 387);
            this.tabPageBin.TabIndex = 0;
            this.tabPageBin.Text = "labelBin";
            this.tabPageBin.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBin
            // 
            this.richTextBoxBin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxBin.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxBin.Name = "richTextBoxBin";
            this.richTextBoxBin.Size = new System.Drawing.Size(883, 316);
            this.richTextBoxBin.TabIndex = 1;
            this.richTextBoxBin.Text = "";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageDecEventTable);
            this.tabControl.Controls.Add(this.tabPageBin);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(903, 413);
            this.tabControl.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 347);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 465);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SPA-5 Black Box Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageDecEventTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsAndAlarms)).EndInit();
            this.tabPageBin.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem labelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelReadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelChngLangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelAboutProgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem labelStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelDecodeToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageDecEventTable;
        private System.Windows.Forms.DataGridView dataGridViewEventsAndAlarms;
        private System.Windows.Forms.TabPage tabPageBin;
        private System.Windows.Forms.RichTextBox richTextBoxBin;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

