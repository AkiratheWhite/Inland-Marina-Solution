using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPRG214.Marina.Data;
using System.Security.Authentication;


namespace CPRG214.Marina.Data
{
    /***
     * Code written by: Tony Li
     * Last Modified (MM/DD/YY): 02/09/21 
     ***/
    public class AuthManager
    {
        /// <summary>
        /// This method takes user inputted login informatio and compares it against values stored in the database.
        /// If a match is found, the user is authenticated.
        /// </summary>
        /// <param name="FirstName">User inputted first name.</param>
        /// <param name="LastName">User inputted last name.</param>
        /// <param name="Phone">User inputted phone number.</param>
        /// <param name="City">User inputted city.</param>
        /// <returns>Authentication userDTO with the user's unique ID and full name.</returns>
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

        /// <summary>
        /// This method takes a Customer object (as defined by Entity Framework) and adds it to the DataContext.
        /// The changes are then saved to update the database with a new customer.
        /// </summary>
        /// <param name="newCust">Customer object. Can be user defined or generated from a registration control.</param>
        public static void Add(Customer newCust)
        {
            var dbContext = new MarinaEntities(); //Gets a reference to the database entity.
            dbContext.Customers.Add(newCust); //Adds the new record to the DataContext.
            dbContext.SaveChanges(); //Saves all changes made in the DataContext to the database it is modelling.
        }

        /// <summary>
        /// Method to check if a user already exists in the database. Prevents duplicate entries of customers.
        /// </summary>
        /// <param name="FirstName">User inputted first name.</param>
        /// <param name="LastName">User inputted last name.</param>
        /// <param name="Phone">User inputted phone number.</param>
        /// <param name="City">User inputted city.</param>
        /// <returns></returns>
        public static bool Exists(string FirstName, string LastName, string Phone, string City)
        {
            //Assume that on a registration attempt, the user is entering new information
            bool RecordExists = false;

            //Gets a reference to the database entity.
            var dbContext = new MarinaEntities();

            //Gets a reference to the object within the Customers table that matches the user specified input fields.
            var authObj = (from cust in dbContext.Customers
                           where cust.FirstName == FirstName && cust.LastName == LastName && cust.Phone == Phone && cust.City == City
                           select cust).SingleOrDefault();

            //If the LINQ query returns an object, the user must already exist within the database.
            if (authObj != null)
            {
                RecordExists = true; //Set the boolean to true, so that the user control denies the registration attempt.
            }

            return RecordExists;
        }

      
    }
}
