// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LoginWithFacebookModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Common.Models.UserModels
{
    public class LoginWithFacebookModel
    {
        private string email;
        private string password;
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
