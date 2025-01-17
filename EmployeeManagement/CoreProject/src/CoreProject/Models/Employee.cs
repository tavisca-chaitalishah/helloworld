﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class Employee
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public DateTime JoiningDate { get; set; }

        public List<string> Roles { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(this.FirstName))
                throw new Exception("FirstName cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(this.Email))
                throw new Exception("Email cannot be null or empty.");

            if (this.JoiningDate == DateTime.MinValue || this.JoiningDate == DateTime.MinValue)
                throw new Exception("Invalid joining date provided.");
        }
    }
}
