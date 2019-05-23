using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyon.Enums;

namespace OtelRezervasyon.Helpers
{
    public class Odalar
    {
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public YatakTipiEnum YatakTipi { get; set; }
        public OdaTipiEnum OdaTipi { get; set; }
        public int KisiSayisi { get; set; }
    }
}
