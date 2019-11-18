// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Models.NotesModels
{
    public class NotesModel
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        /// <summary>
        /// The title
        /// </summary>
        private string title;
        /// <summary>
        /// The description
        /// </summary>
        private string description;
        /// <summary>
        /// The created date
        /// </summary>
        private DateTime? createdDate;
        /// <summary>
        /// The modified date
        /// </summary>
        private DateTime? modifiedDate;
        /// <summary>
        /// The images
        /// </summary>
        private string images;
        /// <summary>
        /// The reminder
        /// </summary>
        private string reminder;
        /// <summary>
        /// The is archive
        /// </summary>
        private bool isArchive;
        /// <summary>
        /// </summary>
        private bool isTrash;
        /// <summary>
        /// The is pin
        /// </summary>
        private bool isPin;
        /// <summary>
        /// The color
        /// </summary>
        private string color;
        /// <summary>
        /// The add image
        /// </summary>
        //private string addImage;
        /// <summary>
        /// The indexvalue
        /// </summary>
        private int indexvalue;


        public int IndexValue
        {
            get
            {
                return this.indexvalue;
            }
            set
            {
                this.indexvalue = value;
            }
        }

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
        //Declaring Email as Foreign Key.
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
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }
        public DateTime? CreatedDate
        {
            get
            {
                return this.createdDate;
            }
            set
            {
                this.createdDate = value;
            }
        }
        public DateTime? ModifiedDate
        {
            get
            {
                return this.modifiedDate;
            }
            set
            {
                this.modifiedDate = value;
            }
        }
        public string Images
        {
            get
            {
                return this.images;
            }
            set
            {
                this.images = value;
            }
        }
        public string Reminder
        {
            get
            {
                return this.reminder;
            }
            set
            {
                this.reminder = value;
            }
        }
        public bool IsArchive
        {
            get
            {
                return this.isArchive;
            }
            set
            {
                this.isArchive = value;
            }
        }
        public bool IsTrash
        {
            get
            {
                return this.isTrash;
            }
            set
            {
                this.isTrash = value;
            }
        }
        public bool IsPin
        {
            get
            {
                return this.isPin;
            }
            set
            {
                this.isPin = value;
            }
        }
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        //public string AddImage
        //{
        //    get
        //    {
        //        return this.addImage;
        //    }
        //    set
        //    {
        //        this.addImage = value;
        //    }
        //}
    }
}
