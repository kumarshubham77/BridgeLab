﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        private string profilePicture;
        private int id;
        private int totalnotes;
        private string status;
        //Making get set of each of the following declared top items
        //Just to get access.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public int TotalNotes
        {
            get
            {
                return this.totalnotes;
            }
            set
            {
                this.totalnotes = value;
            }
        }
        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }
        public string ProfilePicture
        {
            get
            {
                return this.profilePicture;
            }
            set
            {
                this.profilePicture = value;
            }
        }
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