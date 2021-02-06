﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
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
    }
}
