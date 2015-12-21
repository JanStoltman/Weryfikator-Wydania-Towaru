using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etykiety_Epl
{
    class Magazyn
    {
        public string p1 { get; set; }
        public string nazwaMagazynu { get; set; }
        public string p3 { get; set; }

        public Magazyn(object _p1, object _nazwaMagazynu, object _p3)
        {
            p1 = (string)_p1;
            nazwaMagazynu = (string)_nazwaMagazynu;
            p3 = (string)_p3;
        }


        public Magazyn(object[] objects)
        {
            try
            {
                p1 = (string)objects[0];
                nazwaMagazynu = (string)objects[1];
                p3 = (string)objects[2];
            }
            catch (Exception ex)
            {
                p1 = "";
                nazwaMagazynu = "";
                p3 = "";
            }
        }

    }
}
