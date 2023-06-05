using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Smart_Toilet_System
{
    internal class Data
    {
        public string ID { get; set; }
        public string PW { get; set; }
    }

    internal class originalnum
    {
        public string num { get; set; }
    }

    internal class toilet
    {
        public int first { get; set; }
        public int second { get; set; }
        public int third { get; set; }
        public int danger1 { get; set; }
        public int danger2 { get; set; }
        public int danger3 { get; set; }
        public int change1 { get; set; }
        public int change2 { get; set; }
        public int change3 { get; set; }
    }
}
