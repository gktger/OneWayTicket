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
        static SeferiEntities dataContext = new SeferiEntities(); 
        public static List<Duraklar> GetDuraklar()
        {
            return dataContext.Duraklars.ToList();
        }
    }
}
