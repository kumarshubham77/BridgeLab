// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Common.Models.NotesModels;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class NotesRepository : INotesInterface
    {
        
        private readonly  UserContext _context;
        public NotesRepository(UserContext context)
        {
            _context = context;
        }
       public Task Create(NotesModel model, string Email)
       {
            model.Email = Email;
            var note = new NotesModel()
            {
                Email = model.Email,
                Title = model.Title,
                Description = model.Description,
                CreatedDate = DateTime.Now

            };
            _context.notes.Add(note);
            return Task.Run(() => _context.SaveChanges());
           
       }
        //public Task Remind(NotesModel notes, string Email)
        //{
        //    notes.Email = Email;
        //    var note = new NotesModel()
        //    {
        //        Reminder = notes.Reminder
        //    };
        //    _context.notes.Add(note);
        //    return Task.Run(() => _context.SaveChanges());
        //}

        public Task Delete(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if(result.Email.Equals(Email))
            { 
                     
                if (result != null)
                {
                    _context.notes.Remove(result);
                }
                return Task.Run(()=> _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }

        

        public Task Update(NotesModel notes, string Email)
        {
            var result = _context.notes.Where(j => j.ID == notes.ID).FirstOrDefault();
            if(result.Email.Equals(Email))
            {
                if(result!=null)
                {
                    result.Title = notes.Title;
                    result.Description = notes.Description;
                    result.ModifiedDate = DateTime.Now;
                    _context.notes.Update(result);

                }
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }

        public Task<List<NotesModel>> Show(string Email)
        {
            bool note = _context.notes.Any(p => p.Email == Email);
            if(note)
            {
                return Task.Run(()=>_context.notes.Where(p => (p.Email == Email)).ToList());
            }
            else
            {
                return null;
            }
        }

        public Task Archive(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if (result.Email.Equals(Email))
            {
                if(result!= null)
                {
                    result.IsArchive = true;
                    return Task.Run(() => _context.SaveChanges());

                }
                else
                {
                    return null;
                }

                
            }
            else
            {
                return null;
            }
        }
        public Task UnArchive(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if (result.Email.Equals(Email))
            {
                if (result != null)
                {
                    result.IsArchive = false;
                    return Task.Run(() => _context.SaveChanges());

                }
                else
                {
                    return null;
                }


            }
            else
            {
                return null;
            }
        }
        public Task Trash(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if(result != null)
            {
                if(result.Email.Equals(Email))
                {
                    result.IsTrash = true;
                    return Task.Run(() => _context.SaveChanges());
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public Task UnTrash(int ID,string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if(result != null)
            {
                if(result.Email.Equals(Email))
                {
                    result.IsTrash = false;
                    return Task.Run(() => _context.SaveChanges());
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public Task Pin(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if (result != null)
            {
                if (result.Email.Equals(Email))
                {
                    result.IsPin = true;
                    return Task.Run(() => _context.SaveChanges());
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        
        public Task ImageUpload(int Id, IFormFile file, string email)
        {
            var path = file.OpenReadStream();
            var File = file.FileName;
            CloudinaryDotNet.Account account = new CloudinaryDotNet.Account("dalm6prqr", "742568932831953", "x9gQyQphOCQ0Tfp0ScFOYrj0DWM");
            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);
            var image = new ImageUploadParams()
            {
                File = new FileDescription(File,path)
            };
            var uploadResult = cloudinary.Upload(image);
            if (uploadResult.Error != null)
                throw new Exception(uploadResult.Error.Message);
            var result = _context.notes.Where(i => i.ID == Id).FirstOrDefault();
            if (result != null)
            {
                if (result.Email.Equals(email))
                {
                    result.Images = uploadResult.Uri.ToString();
                    return Task.Run(() => _context.SaveChanges());

                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        //public Task ProfilePicture(int Id, IFormFile file, string email)
        //{
        //    var path = file.OpenReadStream();
        //    var File = file.FileName;
        //    CloudinaryDotNet.Account account = new CloudinaryDotNet.Account("dalm6prqr", "742568932831953", "x9gQyQphOCQ0Tfp0ScFOYrj0DWM");
        //    CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);
        //    var image = new ImageUploadParams()
        //    {
        //        File = new FileDescription(File,path) 
        //    };
        //    var uploadResult = cloudinary.Upload(image);
        //    if (uploadResult.Error != null)
        //        throw new Exception(uploadResult.Error.Message);
        //    var result = _context.notes.Where(i => i.ID == Id).FirstOrDefault();
        //    if (result != null)
        //    {
        //        if (result.Email.Equals(email))
        //        {
        //            result.Images = uploadResult.Uri.ToString();
        //            return Task.Run(() => _context.SaveChanges());

        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        public Task UnPin(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if (result != null)
            {
                if (result.Email.Equals(Email))
                {
                    result.IsPin = false;
                    return Task.Run(() => _context.SaveChanges());
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public Task Remind(NotesModel model, string Email)
        {
            var result = _context.notes.Where(j => j.ID == model.ID).FirstOrDefault();
            if(result != null)
            {
                if(result.Email.Equals(Email))
                {
                    result.Reminder = model.Reminder;
                    return Task.Run(() => _context.SaveChanges());
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public Task RemoveReminder(NotesModel model, string Email)
        {
            var result = _context.notes.Where(j => j.ID == model.ID).FirstOrDefault();
            if(result != null)
            {
                if(result.Email.Equals(Email))
                {
                    result.Reminder = null;
                    return Task.Run(() => _context.SaveChanges());
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public Task Color(NotesModel model, string Email)
        {
            var result = _context.notes.Where(j => j.ID == model.ID).FirstOrDefault();
            if(result != null)
            {
                if(result.Email.Equals(Email))
                {
                    result.Color = model.Color;
                    return Task.Run(() => _context.SaveChanges());
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        
    }
}
