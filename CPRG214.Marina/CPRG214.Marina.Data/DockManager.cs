using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CPRG214.Marina.Data
{
    public class DockManager
    {
        public IList GetAllAsListItem()
        {
            var db = new MarinaEntities();
            var dockName = db.Docks.Select(d => new { ID = d.ID, Name = d.Name }).ToList();
            return dockName;

        }
        public static Dock Find(int dockID)
        {
            var db = new MarinaEntities();
            var dock = db.Docks.SingleOrDefault(d => d.ID == dockID);
            return dock;
        }


    }
}
