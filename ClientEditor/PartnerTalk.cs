﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientEditor
{
    public class PartnerTalk : AkEditor
    {
        public string Unknown1 { get; set; }
        public string Unknown2 { get; set; }
        public string Unknown3 { get; set; }
        public string Unknown4 { get; set; }
        public string Unknown5 { get; set; }
        public string Unknown6 { get; set; }
        public string Unknown7 { get; set; }

        public PartnerTalk(string u1,string u2,string u3, string u4, string u5, string u6, string u7)
        {
            this.Unknown1 = u1;
            this.Unknown2 = u2;
            this.Unknown3 = u3;
            this.Unknown4 = u4;
            this.Unknown5 = u5;
            this.Unknown6 = u6;
            this.Unknown7 = u7;
        }
    }
}
