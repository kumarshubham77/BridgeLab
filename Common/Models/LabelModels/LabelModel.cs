// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Models.LabelModels
{
    /// <summary>
    /// Creating class LabelModel.
    /// </summary>
    public class LabelModel
    {
        private int id;
        private string email;
        private string label;
        private int noteid;
        //Declaring ID as a Primary Key.
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
        //Declaring Email as Foreign Key of the UserModel Type.
        [ForeignKey("UserModel")]
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
        //Declaring Label for the Users to avail Advance Service or primary Service.
        public string Label
        {
            get
            {
                return this.label;
            }
            set
            {
                this.label = value;
            }
        }
        public int NoteID
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
    }
}
