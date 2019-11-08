// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

namespace Common.Models.UserModels
{
    /// <summary>
    /// Creating a class UserModel that will have
    /// private string such as firstname,lastname etc.,
    /// </summary>
    public class UserModel
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string cardType;
        //Making get set of each of the following declared top items
        //Just to get access.
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        [Key]
        [Required]
        //Making it primary.
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
        public string CardType
        {
            get
            {
                return this.cardType;
            }
            set
            {
                this.cardType = value;
            }
        }


    }
}