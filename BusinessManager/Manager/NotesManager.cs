// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using BusinessManager.Interfaces;
using Common.Models.NotesModels;
using Common.Models.NotesViewModel;
using FundooRepository.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessManager.Manager
{
    /// <summary>
    /// Creating a class NotesManager implements INotesManager.
    /// </summary>
    /// <seealso cref="BusinessManager.Interfaces.INotesManager" />
    public class NotesManager : INotesManager
    {

        /// <summary>
        /// Making INotesInterface private readonly.
        /// </summary>
        private readonly INotesInterface notes;
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesManager"/> class.
        /// </summary>
        /// <param name="inotes">The inotes.</param>
        public NotesManager(INotesInterface inotes)
        {
            notes = inotes;
        }
        /// <summary>
        /// Adds the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Add(NotesModel model, string Email)
        {
            await notes.Create(model, Email);
            return "Added Successfully";
        }
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Del(int ID, string Email)
        {
            await notes.Delete(ID, Email);
            return "Deleted Successfully";
        }
        /// <summary>
        /// Shows the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public List<NotesViewModel> Show(string Email)
        {

            return notes.Show(Email);

        }
        /// <summary>
        /// Displays the m.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <param name="Search">The search.</param>
        /// <returns></returns>
        public async Task<List<NotesModel>> DisplayM(string Email, string Search)
        {
            var result = await notes.Display(Email,Search);
            return result;
        }
        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="note">The note.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Update(NotesModel note, string Email)
        {
            await notes.Update(note, Email);
            return "Updated Successfully";
        }

        /// <summary>
        /// Archives the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Archive(int ID, string Email)
        {
            await notes.Archive(ID, Email);
            return "Archieved Successfully";
        }
        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> UnArchive(int ID, string Email)
        {
            await notes.UnArchive(ID, Email);
            return "UnArchieved Successfull";
        }
        /// <summary>
        /// Trashes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Trash(int ID, string Email)
        {
            await notes.Trash(ID, Email);
            return "Gone To the Garbage Bin";
        }
        /// <summary>
        /// Uns the trash.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> UnTrash(int ID, string Email)
        {
            await notes.UnTrash(ID, Email);
            return "UnTrash Succesfull";
        }
        public async Task<string> Deleteall(string Email)
        {
            await notes.DeleteAll(Email);
            return "Deleted all Trash";
        }
        public async Task<string> Recoverall (string Email, NotesModel[] ID)
        {
            await notes.RecoverAll(Email,ID);
            return "Recovered";
        }
        /// <summary>
        /// Pins the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Pin(int ID, string Email)
        {
            await notes.Pin(ID, Email);
            return "Pinned Successfully";
        }
        public List<NotesModel> GetAllUnPin(string Email)
        {
            var result = notes.GetAllUNPins(Email);
            return result;
        }

        public List<NotesModel> GetAllPin(string Email)
        {
            var result = notes.GetAllPins(Email);
            return result;
        }
        /// <summary>
        /// Images the upload.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public async Task<NotesModel> ImageUpload(int Id,IFormFile file, string email)
        {
           var result = await notes.ImageUpload(Id, file, email);
            return result;
        }

        public async Task<string> UnPin(int ID, string Email)
        {
            await notes.UnPin(ID, Email);
            return "UnPinned Successfull";
        }
        /// <summary>
        /// Remindrs the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Remindr(string Email, int ID, string Reminder)
        {
            await notes.Remind(Email,ID,Reminder);
            return "Reminder Sets.";
        }
        /// <summary>
        /// Colours the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Colour(NotesModel model, string Email)
        {
            await notes.Color(model, Email);
            return "Colour Sets Now";
        }

        //public async Task<string> ProfilePictureUP(int ID, IFormFile file, string email)
        //{
        //    await notes.ProfilePicture(ID, file, email);
        //    return "Profile photo Added Successfully";
        //}

        public async Task<string> RemReminder(int ID, string Email)
        {
            await notes.RemoveReminder(ID, Email);
            return "Removed Reminder";
        }
        /// <summary>
        /// Puttings the index value.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> PuttingIndexValue(NotesModel model, string Email)
        {
            await notes.PutIndexValue(model, Email);
            return "Index Value Added";
        }
        /// <summary>
        /// Drags the and drop.
        /// </summary>
        /// <param name="drag">The drag.</param>
        /// <param name="drop">The drop.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public async Task<string> DragAndDrop(int drag, int drop, string email)
        {
            await notes.DragAndDrop(drag,drop,email);
            return "Index Value Added";
        }

        public async Task<string> DeleteElementbyId(int ID, string Email)
        {
            await notes.DeleteElementByID(ID, Email);
            return "Successfully Deleted that Particualr ID Database";
        }

        



        //public async Task<string> Reminder(NotesModel notes, string Email)
        //{
        //    await notes.Reminder(notes, Email);
        //    return "Reminder";
        //}
    }
}
