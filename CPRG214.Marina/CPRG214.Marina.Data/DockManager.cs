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
        //Code written by Julie Tran
        //Last Modified Febuary 7 2021

        /// <summary>
        /// retrieves all Dock Name and Dock ID
        /// </summary>
        /// <returns></returns>
        public IList GetAllAsListItem()
        {
            var db = new MarinaEntities();
            var dockName = db.Docks.Select(d => new { ID = d.ID, Name = d.Name }).ToList();
            return dockName;

        }
        /// <summary>
        /// retrieves dock by ID
        /// </summary>
        /// <param name="dockID">dock ID</param>
        /// <returns></returns>
        public static Dock Find(int dockID)
        {
            var db = new MarinaEntities();
            var dock = db.Docks.SingleOrDefault(d => d.ID == dockID);
            return dock;
        }


    }
}
