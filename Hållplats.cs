using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAnalysOODesign
{
    internal class Hållplats
    {

        public static List<Hållplats> hållplatser = new List<Hållplats>();

        public string hållplatsNamn;
        public string hållplatsZon;

        public Hållplats(string hållplatsNamn, string hållplatsZon)
        {
            this.hållplatsNamn = hållplatsNamn;
            this.hållplatsZon = hållplatsZon;

            Hållplats.hållplatser.Add(this);
        }


    }
}
