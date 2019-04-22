using OneWayTicket.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWayTicket.BLL
{
    public static class DuraklarBLL
    {
        static SeferiEntities db = new SeferiEntities();

     
        public static List<Duraklar> GetDuraklar()
        {
            return db.Duraklars.ToList();
        }

        public static List<Duraklar> GetDuraklar(int nederenId)
        {
            List<int> guzergahIDs = db.GuzergahDuraklaris.Where(a => a.DurakID == nederenId).Select(a=>a.GuzergahID).ToList();
            List<int> durakIDs = db.GuzergahDuraklaris.Where(a => guzergahIDs.Contains(a.GuzergahID)).Select(a => a.DurakID).ToList();
            List<Duraklar> duraklar = db.Duraklars.Where(a => durakIDs.Contains(a.DurakID)).ToList();
            return duraklar;
        }

        public static List<GuzergahDuraklari> GetGuzergahDuraklari(int durakId)
        {
            return db.GuzergahDuraklaris.Where(a => a.DurakID == durakId).ToList();
        }

        public static Duraklar GetDurak(int durakId)
        {
            return db.Duraklars.FirstOrDefault(x => x.DurakID == durakId);

        }

    }
}
