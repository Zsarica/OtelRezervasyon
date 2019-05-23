using OtelRezervasyon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Helpers
{
    class Konaklayanlar
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string  TcNo { get; set; }
        public CinsiyetEnum Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public string ePosta { get; set; }
        public int OdaID { get; set; }
    }
}
