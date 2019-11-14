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
