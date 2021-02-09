using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
    public class SlipManager
    {
        //not used
        public static Slip Find(int dockID)
        {
            var db = new MarinaEntities();
            var slip = db.Slips.SingleOrDefault(d => d.ID == dockID);
            return slip;
        }

        public static List<Slip> FindAvailableSlip()
        {
            var db = new MarinaEntities();
            var availSlip = db.Slips.Where(s => s.Leases.Count == 0).ToList();
            return availSlip;
        }

        public static List<Slip> FindAvailableSlipByDock(int dockID)
        {
            var db = new MarinaEntities(); //any data retrieval in .Data
            var availableSlips = db.Slips.Where(s => s.Leases.Count == 0 && s.DockID == dockID).ToList();
            return availableSlips;
        }

  
    }
}
