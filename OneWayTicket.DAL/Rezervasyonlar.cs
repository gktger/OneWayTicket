//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneWayTicket.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezervasyonlar
    {
        public int RezervasyonID { get; set; }
        public string MusteriAdiSoyadi { get; set; }
        public string MusteriTCKN { get; set; }
        public int SeferID { get; set; }
        public int BinisDurakID { get; set; }
        public int InisDurakID { get; set; }
        public string Aciklama { get; set; }
    
        public virtual Duraklar Duraklar { get; set; }
        public virtual Duraklar Duraklar1 { get; set; }
        public virtual Seferler Seferler { get; set; }
    }
}
