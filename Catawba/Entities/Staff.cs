﻿using System.ComponentModel;
using System.Collections.Generic;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Security;

namespace Catawba
{
    public class Staff
    {

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Admin { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Creates an instance of a Staff account object. Holds relevant information
        /// such as username (created by an administrator), employee's first and last name,
        /// whether or not the employee is an administrator, and the account password
        /// (randomly generated by using createUniqueKey in the Security class)
        /// </summary>
        public Staff()
        {
            UserName = null;
            FirstName = null;
            LastName = null;
            Admin = null;
            Password = null;
        }

    }
}
