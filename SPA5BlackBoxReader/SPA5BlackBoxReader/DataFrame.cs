using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace SPA5BlackBoxReader
{
    class DataFrame
    {   
        
        private int CRC32;

        public DataFrame()
        {
            CRC32 = 0;
        }

        public List<string[]> DecodeDataFrameToList(byte[] frame)
        {
            List<string[]> listOfMessages = new List<string[]>();

            int blkLenght = (frame[0] << 8) + frame[1];
            int lxNumber = ((frame[2] << 8) + frame[3]) >> 1;
            string lxChannel = ((0x01 & frame[3]) == 0) ? "A": "B";
            int blkType = frame[4];

            DateTime timeStamp = new DateTime(((frame[8] << 8) + frame[9]), frame[10], frame[11], frame[12], frame[13], frame[14]);
            int timeStampTick = frame[15];

            CRC32 = (frame[blkLenght - 4]<<24) + (frame[blkLenght - 3]<<16) + (frame[blkLenght - 2]<<8) + frame[blkLenght - 1];

            if (checkCRC(CRC32) == true)
            {
                if (blkType == 1)
                {
                    int numberOfFrames = (blkLenght - 20) / 8;
                    byte[] byteMessage = new byte[8];

                    for (int i = 0; i < numberOfFrames; i++)
                    {
                        for (int b = 0; b < 8; b++)
                            byteMessage[b] = frame[16+(8*i)+b];
                        
                        Message mess = new Message();
                        List<string> tempList = new List<string>();

                        tempList.Add(timeStamp.ToString());
                        tempList.Add(lxNumber.ToString());
                        tempList.Add(lxChannel.ToString());
                        tempList.AddRange(mess.DecodeMessageToList(byteMessage));

                        string[] temp = new string[tempList.Count];

                        for (int j = 0; j < tempList.Count; j++)
                            temp[j] = tempList[j];

                        listOfMessages.Add(temp);
                    }
                }
            }
            return listOfMessages;
        }

        private bool checkCRC(int crc)
        {
            bool OK = true;

            return OK;
        }


    }
}
