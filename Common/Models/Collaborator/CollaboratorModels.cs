// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorModels.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models.Collaborator
{
    public class CollaboratorModels
    {
        private int id;
        private string senderemail;
        private string noteid;
        private string receiveremail;
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        
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
        /// <summary>
        /// Gets or sets the sender email.
        /// </summary>
        /// <value>
        /// The sender email.
        /// </value>
        [ForeignKey("UserModel")]
        public string SenderEmail
        {
            get
            {
                return this.senderemail;
            }
            set
            {
                this.senderemail = value;
            }
        }
        /// <summary>
        /// Gets or sets the noteid.
        /// </summary>
        /// <value>
        /// The noteid.
        /// </value>
        public string Noteid
        {
            get
            {
                return this.noteid;
            }
            set
            {
                this.noteid = value;
            }
        }
        /// <summary>
        /// Gets or sets the receiver email.
        /// </summary>
        /// <value>
        /// The receiver email.
        /// </value>
        [ForeignKey("UserModel")]
        public string ReceiverEmail
        {
            get
            {
                return this.receiveremail;
            }
            set
            {
                this.receiveremail = value;
            }
        }
    }
}
