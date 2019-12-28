// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Common.Models.NotesModels;
using Common.Models.NotesViewModel;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using FundooRepository.Interfaces.RedisCache;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    /// <summary>
    /// Creating a class NotesRepository implements INotesInterface
    /// </summary>
    /// <seealso cref="FundooRepository.Interfaces.INotesInterface" />
    public class NotesRepository : INotesInterface
    {
        /// <summary>
        /// Making UserContext Readonly.
        /// </summary>
        private readonly UserContexts _context;
        /// <summary>
        /// Making ICacheProvider Private Readonly.
        /// </summary>
        private readonly ICacheProvider _cacheProvider;
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="cacheProvider">The cache provider.</param>
        public NotesRepository(UserContexts context , ICacheProvider cacheProvider)
        {
            _context = context;
            _cacheProvider = cacheProvider;
        }
        /// <summary>
        /// Creates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task Create(NotesModel model, string Email)
        {
            var result = _context.user.Where(i=>i.Email==Email).FirstOrDefault();
            model.Email = Email;
            var note = new NotesModel()
            {
                Email = model.Email,
                Title = model.Title,
                Description = model.Description,
                CreatedDate = DateTime.Now,
                IndexValue=AddIndexValue(Email)


            };
            _context.notes.Add(note);
            result.TotalNotes++;
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
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task Delete(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if (result.Email.Equals(Email))
            {

                if (result != null)
                {
                    _context.notes.Remove(result);
                }
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Updates the specified notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task Update(NotesModel notes, string Email)
        {
            var result = _context.notes.Where(j => j.ID == notes.ID).FirstOrDefault();
            if (result.Email.Equals(Email))
            {
                if (result != null)
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
        /// <summary>
        /// Shows the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public List<NotesViewModel> Show(string email)
        
        {
            //bool note = _context.notes.Any(p => p.Email == email);
            //if (note)
            //{
            //    // return Task.Run(() => _context.Notes.Where(p => (p.Email == Email) && (p.IsArchive==false) &&(p.IsTrash==false)).ToList());
            //    return Task.Run(() => _context.notes.Where(c => (c.Email == email) && (c.IsArchive == false) && (c.IsTrash == false)).OrderBy(s => s.IndexValue).ToList());
            //}
            //else
            //{
            //    return null;
            //}
            var result = (from notes in _context.notes
                          where notes.Email == email

                          select new NotesViewModel

                          {
                              ID = notes.ID,
                              Email = notes.Email,
                              Title = notes.Title,
                              Description = notes.Description,
                              CreatedDate = notes.CreatedDate,
                              ModifiedDate = notes.ModifiedDate,
                              Reminder = notes.Reminder,
                              Images = notes.Images,
                              IsArchive = notes.IsArchive,
                              IsTrash = notes.IsTrash,
                              IsPin = notes.IsPin,
                              Color = notes.Color,
                              IndexValue = notes.IndexValue,
                              Labels = _context.labels.Where(i => i.ID == notes.ID).ToList(),
                              Collaborators = (_context.collaborator.Where(i => i.Noteid == notes.ID.ToString() && i.SenderEmail == email).ToList())
                          }
                          ).OrderBy(notes => notes.IndexValue).ToList();
                      

            return result;



            //SetValue(email);
            //var result = GetValue(email);
            //return Task.Run(()=>result);
        }
        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="email">The email.</param>
        public void SetValue(string email)
        {
            var result = _context.notes.Where(i => i.Email == email).ToList();
            _cacheProvider.Set(email, result);
        }
        public List<NotesModel> GetValue(string email)
        {
            var contacts = _cacheProvider.Get<List<NotesModel>>(email);
            return contacts;

        }
        /// <summary>
        /// Displays the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <param name="Search">The search.</param>
        /// <returns></returns>
        public Task<List<NotesModel>> Display(string Email, string Search)
        {
            return Task.Run(() => _context.notes.Where(i => (i.Email == Email) && (i.Title.Contains(Search)) && (i.IsArchive == false) && (i.IsTrash == false)).ToList());

        }
        /// <summary>
        /// Archives the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task Archive(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if (result.Email.Equals(Email))
            {
                if (result != null)
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
        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Trashes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task Trash(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if (result != null)
            {
                if (result.Email.Equals(Email))
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
        /// <summary>
        /// Uns the trash.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task UnTrash(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if (result != null)
            {
                if (result.Email.Equals(Email))
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
        /// <summary>
        /// Pins the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
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
       
        public List<NotesModel> GetAllPins(string Email)
        {
            bool note = _context.user.Any(p => p.Email == Email);
            if (note)
            {
                return _context.notes.Where(p => (p.Email == Email) && (p.IsPin == true)).ToList();
            }
            return null;
        }
        public List<NotesModel> GetAllUNPins(string Email)
        {
            bool note = _context.user.Any(p => p.Email == Email);
            if (note)
            {
                return _context.notes.Where(p => (p.Email == Email) && (p.IsPin == false)).ToList();
            }
            return null;
        }
        /// <summary>
        /// Images the upload.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task<NotesModel> ImageUpload(int Id,IFormFile file, string email)
        {
            var path = file.OpenReadStream();
            var File = file.FileName;
            CloudinaryDotNet.Account account = new CloudinaryDotNet.Account("dalm6prqr", "742568932831953", "x9gQyQphOCQ0Tfp0ScFOYrj0DWM");
            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);
            var image = new ImageUploadParams()
            {
                File = new FileDescription(File, path)
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
                    _context.SaveChanges();
                    return Task.Run(() => result);

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
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
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
        public Task DeleteElementByID(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if(result != null)
            {
                if(result.Email.Equals(Email))
                {
                    _context.notes.Remove(result);
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
        /// <summary>
        /// Reminds the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task Remind(string Email, int ID,string Reminder)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if (result != null)
            {
                if (result.Email.Equals(Email))
                {
                    result.Reminder = Reminder;
                    _context.notes.Update(result);
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

        /// <summary>
        /// Removes the reminder.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task RemoveReminder(int ID, string Email)
        {
            var result = _context.notes.Where(j => j.ID == ID).FirstOrDefault();
            if (result != null)
            {
                if (result.Email.Equals(Email))
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
        /// <summary>
        /// Colors the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task Color(NotesModel model, string Email)
        {
            var result = _context.notes.Where(j => j.ID == model.ID).FirstOrDefault();
            if (result != null)
            {
                if (result.Email.Equals(Email))
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
        /// <summary>
        /// Puts the index value.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task PutIndexValue(NotesModel model, string Email)
        {
            var result = _context.notes.Where(j => j.ID == model.ID).FirstOrDefault();
            if(result != null)
            {
                if(result.Email.Equals(Email))
                {
                    result.IndexValue = model.IndexValue;
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
        /// <summary>
        /// Dragands the drop.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <param name="IndexValue">The index value.</param>
        /// <returns></returns>
        public Task DragandDrop(NotesModel model, string Email, int IndexValue)
        {
            //var result = _context.notes.Where(j => j.ID == model.ID).FirstOrDefault();
            //if(result != null)
            //{
            //    if(result.Email.Equals(Email))
            //    {

            //    }
            //}
            return null;
        }
        /// <summary>
        /// Adds the index value.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public int AddIndexValue(string email)
        {
            var result = _context.notes.Where(i => i.Email == email).ToArray();
            if (result.Length!=0)
            {
                int max = result[0].IndexValue;
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i].IndexValue > max)
                        max = result[i].IndexValue;
                }
                return max + 1;
            }
            else
            {
                return 1;
            }
        }
        /// <summary>
        /// Drags the and drop.
        /// </summary>
        /// <param name="drag">The drag.</param>
        /// <param name="drop">The drop.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public Task DragAndDrop(int drag, int drop, string email)
        {
            var result = _context.notes.Where(i => (i.Email == email) && (i.IndexValue >= drag) && (i.IndexValue <= drop)).ToArray();

            if (result != null)
            {
                if (drag < drop)
                {
                    for (int i = 0; i < result.Length - 1; i++)
                    {
                        if (result[i].IndexValue >= drag && result[i].IndexValue <= drop)
                        {
                            var temp = result[i].IndexValue;
                            result[i].IndexValue = result[i + 1].IndexValue;
                            result[i + 1].IndexValue = temp;
                        }
                    }
                    return Task.Run(() => _context.SaveChanges());
                }
                else
                {
                    var result1 = _context.notes.Where(i => (i.Email == email) && (i.IndexValue <= drag) && (i.IndexValue >= drop)).ToArray();
                    for (int i = result1.Length - 1; i > 0; i--)
                    {
                        if (result1[i].IndexValue <= drag && result1[i].IndexValue >= drop)
                        {
                            var temp = result1[i].IndexValue;
                            result1[i].IndexValue = result1[i - 1].IndexValue;
                            result1[i - 1].IndexValue = temp;
                        }
                    }
                    return Task.Run(() => _context.SaveChanges());
                }
            }
            else
            {
                return null;
            }
        }

        public Task DeleteAll(string Email)
        {
            var result = _context.notes.Where(j => j.Email == Email && j.IsTrash == true).ToList();
            if(result.Count != 0)
            {
                _context.notes.RemoveRange(result);
                return Task.Run(() => _context.SaveChanges());
            }
            return null;
        }

        public Task RecoverAll(string Email, NotesModel[] ID)
        {
            var result = _context.notes.Where(i => i.Email == Email && i.IsTrash == true).ToList();
            if(result != null)
            {
                foreach(var list in result)
                {
                    for (int i = 0; i < ID.Length; i++)
                    {
                        if (list.ID == ID[i].ID)
                        {
                            list.IsTrash = false;
                            _context.notes.Update(list);
                        }
                    }
                }
                return Task.Run(() => _context.SaveChanges());
            }
            return null;
        }





        //public Task DragandDrop(NotesModel model, string Email)
        //{

        //}
    }
}
