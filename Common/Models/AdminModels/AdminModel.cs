
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models.AdminModels
{
    public class AdminModel
    {
        private int adminid;
        private string firstname;
        private string lastname;
        private string email;
        private string password;

        [Key]
        [Required]
        public int AdminID
        {
            get
            {
                return this.adminid;
            }
            set
            {
                this.adminid = value;
            }
        }
        [Required]
        public string FirstName
        {
            get
            {
                return this.firstname;
            }
            set
            {
                this.firstname = value;
            }
        }

        [Required]
        public string LastName
        {
            get
            {
                return this.lastname;
            }
            set
            {
                this.lastname = value;
            }
        }
        [Required]
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        [Required]
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
    }
}
