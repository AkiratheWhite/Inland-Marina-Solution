using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
    public class LeaseManager
    {
        /// <summary>
        /// Adds new lease to database
        /// </summary>
        /// <param name="slipID"></param>
        /// <param name="custID"></param>
        /// Code written by Julie Tran 
        /// Modifed by Tony Li
        //Last Modified Febuary 9 2021
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

        /// <summary>
        /// Finds all lease associated to customer that is logged in
        /// </summary>
        /// <param name="custID">customer ID</param>
        /// Code written by Julie Tran
        //Last Modified Febuary 8 2021
        public static List<Lease> Find(int custID)
        {
            var db = new MarinaEntities();
          
            List<Lease> leases = db.Leases.ToList();
            var previouslyLeased= (from pl in leases where pl.CustomerID == custID select pl).ToList();
 
            return previouslyLeased;
        }

   
    }

}
