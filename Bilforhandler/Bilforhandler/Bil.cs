using System;

namespace Bilforhandler
{
    public class Bil
    {
        public string Merke { get; set; }
        public string RegNo { get; set; }
        public int År { get; set; }
        public int Kilometer { get; set; }


        public Bil(string merke, string regNo, int år, int kilometer)
        {
            Merke = merke;
            RegNo = regNo;
            År = år;
            Kilometer = kilometer;
        }
    }
}