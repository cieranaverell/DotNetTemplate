﻿using System;
namespace Template.Core.Models
{
    // Add User roles relevant to your application
    public enum Role { Admin, Manager, Guest }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        // User role within application
        public Role Role { get; set; }
    }
}