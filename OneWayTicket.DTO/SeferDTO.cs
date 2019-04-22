using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWayTicket.DTO
{
    public class SeferDTO
    {
        public int SeferID { get; set; }
        public int GuzergahID { get; set; }
        public System.DateTime TarihSaat { get; set; }
        public byte[] Aciklama { get; set; }
        public string Guzergah { get; set; }
    }
}
