//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelRezervasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Konaklayan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Konaklayan()
        {
            this.RezervasyonKonaklayanDetays = new HashSet<RezervasyonKonaklayanDetay>();
        }
    
        public int KonaklayanID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public int OdaID { get; set; }
        public byte CinsiyetEnum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RezervasyonKonaklayanDetay> RezervasyonKonaklayanDetays { get; set; }
    }
}
