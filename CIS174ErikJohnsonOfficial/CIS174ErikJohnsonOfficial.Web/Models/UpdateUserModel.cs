﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS174ErikJohnsonOfficial.Web.Models
{
    public class UpdateUserModel
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
    }
}