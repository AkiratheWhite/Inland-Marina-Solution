using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
    public class SlipManager
    {
 
        /// <summary>
        /// Find all slips that has not been leased
        /// </summary>
        /// <returns>a list of slips</returns>
        public static List<Slip> FindAvailableSlip()
        {
            var db = new MarinaEntities();
            var availSlip = db.Slips.Where(s => s.Leases.Count == 0).ToList();
            return availSlip;
        }
        /// <summary>
        /// find all slips that is associated to dockID
        /// </summary>
        /// <param name="dockID"> dock ID</param>
        /// <returns>a list of slips</returns>
        public static List<Slip> FindAvailableSlipByDock(int dockID)
        {
            var db = new MarinaEntities(); //any data retrieval in .Data
            var availableSlips = db.Slips.Where(s => s.Leases.Count == 0 && s.DockID == dockID).ToList();
            return availableSlips;
        }

  
    }
}
