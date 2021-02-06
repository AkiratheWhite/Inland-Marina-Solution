using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
    public class AuthManager
    {
        public static object Authenticate(string FirstName, string LastName, string Phone, string City)
        {
            userDTO dto = null;

            //Gets a reference to the database entity.
            var dbContext = new MarinaEntities();

            //Gets a reference to the object within the Customers table that matches the user specified input fields.
            var authObj = (from cust in dbContext.Customers
                          where cust.FirstName == FirstName && cust.LastName == LastName && cust.Phone == Phone && cust.City == City
                          select cust).SingleOrDefault();

            if (authObj is null)
            {
                //User is not authenticated.
            }

            else
            {
                //Sets parameters for the userDTO that will be used for authentication.
                //A direct reference to authObj might pass it by reference, so we'll create a new object.
                dto = new userDTO
                {
                    custID = authObj.ID,
                    FullName = $"{authObj.FirstName} {authObj.LastName}"
                };
            }
            return dto;
        }
    }
}
