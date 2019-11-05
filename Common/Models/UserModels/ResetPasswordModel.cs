// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ResetPasswordModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.UserModels
{
    /// <summary>
    /// Creating a class ResetPasswordModel that will have
    /// private string such as email,oldpassword etc.,
    /// </summary>
    public class ResetPasswordModel
    {

        private string email;
        private string oldpassword;
        private string newpassword;
        private string confirmpassword;
        //Makin get set of each of the following declared top items
        //Just to get access.
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
        public string OldPassword
        {
            get
            {
                return this.oldpassword;
            }
            set
            {
                this.oldpassword = value;
            }
        }
        public string NewPassword
        {
            get
            {
                return this.newpassword;
            }
            set
            {
                this.newpassword = value;
            }
        }
        public string ConfirmPassword
        {
            get
            {
                return this.confirmpassword;
            }
            set
            {
                this.confirmpassword = value;
            }
        }
    }
}
