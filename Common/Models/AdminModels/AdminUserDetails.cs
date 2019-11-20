using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models.AdminModels
{
    public class AdminUserDetails
    {
        private int sno;
        private string useremailid;
        private string logintime;
        private string services;
        [Key]
        [Required]
        public int Sno
        {
            get
            {
                return this.sno;
            }
            set
            {
                this.sno = value;
            }
        }
        [Required]
        public string UserEmailId
        {
            get
            {
                return this.useremailid;
            }
            set
            {
                this.useremailid = value;
            }
        }
        [Required]
        public string LogInTime
        {
            get
            {
                return this.logintime;
            }
            set
            {
                this.logintime = value;
            }
        }
        [Required]
        public string Services
        {
            get
            {
                return this.services;
            }
            set
            {
                this.services = value;
            }
        }
    }
}
