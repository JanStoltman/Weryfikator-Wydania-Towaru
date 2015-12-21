using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donat_Etykiety
{
    public class Dokument
    {
        public List<string> dane = new List<string>();
        public string id = string.Empty;
        public string numerDokWew = string.Empty;

        public Dokument(List<string> _dane)
        {
            dane.AddRange(_dane);
        }

        public Dokument()
        {
        }

        public void addValue(string value)
        {
            if (value == null)
                value = "";

            dane.Add(value);
        }
    }
}
