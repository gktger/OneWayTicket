using OneWayTicket.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWayTicket.BLL
{
    public static class RezervasyonBLL
    {
        static SeferiEntities db = new SeferiEntities();

        public static void AddRezervasyon(Rezervasyonlar rezerve)
        {
            db.Rezervasyonlars.Add(rezerve);
            db.SaveChanges();
        }
    }
}
