﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace SPA5BlackBoxReader
{
    class MessageELS95 : IMessageStrategy
    {
        ResourceManager resmgr = new ResourceManager("SPA5BlackBoxReader.Lang", typeof(Message).Assembly);
        CultureInfo internalCI = null;

        public MessageELS95()
        {
            internalCI = CultureInfo.DefaultThreadCurrentCulture;
        }

        public List<string> Decode(byte[] decEvent)
        {
            List<string> decodedEvent = new List<string>();


            return decodedEvent;
        }




    }
}