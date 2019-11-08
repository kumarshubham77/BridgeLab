// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ForgotPassword.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Common.Models.UserModels
{
    /// <summary>
    /// Creating a class ForgotPassword that will have
    /// private string such as email.
    /// </summary>
    public class ForgotPassword
    {
        private string email;
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
    }
}
