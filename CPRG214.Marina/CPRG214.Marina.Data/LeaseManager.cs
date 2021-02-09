using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
    public class LeaseManager
    {

        public static void Add(int slipID, int custID)
        {
            var db = new MarinaEntities();
            var slipEntity = (from slip in db.Slips
                              where slip.ID == slipID
                              select slip
                              ).SingleOrDefault();

            var customerEntity = (from cust in db.Customers
                                  where cust.ID == custID
                                  select cust).SingleOrDefault();
            var newLease = new Lease
            {
                Slip = slipEntity,
                Customer = customerEntity
            };

            db.Leases.Add(newLease);
            db.SaveChanges();
        }

        public static List<Lease> Find(int custID)
        {
            var db = new MarinaEntities();
          
            List<Lease> leases = db.Leases.ToList();
            var previouslyLeased= (from pl in leases where pl.CustomerID == custID select pl).ToList();
 
            return previouslyLeased;
        }

   
    }

}
