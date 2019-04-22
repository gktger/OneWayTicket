using OneWayTicket.DAL;
using OneWayTicket.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWayTicket.BLL
{
    public static class SeferlerBLL
    {
        static SeferiEntities db = new SeferiEntities();

        public static List<SeferDTO> GetSeferler(int guzergahId)
        {

            return db.Seferlers.Where(x => x.GuzergahID == guzergahId).Select(a => new SeferDTO()
            {
                SeferID = a.SeferID,
                Aciklama = a.Aciklama,
                GuzergahID = a.GuzergahID,
                TarihSaat = a.TarihSaat,
                Guzergah = a.Guzergahlar.GuzergahAdi
            }).ToList();

        }

        public static Seferler GetSefer(int seferId)
        {
            return db.Seferlers.FirstOrDefault(x => x.SeferID == seferId);
        }

    }
}
