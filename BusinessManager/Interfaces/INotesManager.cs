// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INotesManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.NotesModels;
using Common.Models.NotesViewModel;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessManager.Interfaces
{
    /// <summary>
    /// Creating an Interface of INotesManager
    /// </summary>
    public interface INotesManager
    {
        /// <summary>
        /// Adds the specified notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> Add(NotesModel notes, string Email);
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> Del(int ID, string Email);
        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="note">The note.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> Update(NotesModel note, string Email);
        /// <summary>
        /// Shows the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        List<NotesViewModel> Show(string Email);
        /// <summary>
        /// Archives the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> Archive(int ID, string Email);
        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> UnArchive(int ID, string Email);
        /// <summary>
        /// Trashes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> Trash(int ID, string Email);
        /// <summary>
        /// Uns the trash.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> UnTrash(int ID, string Email);
        Task<string> Deleteall(string Email);
        Task<string> Recoverall(string Email, NotesModel[] ID);

        //Task<string> Reminder(NotesModel notes, string Email);        
        /// <summary>
        /// Pins the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        List<NotesModel> GetAllPin(string Email);
        List<NotesModel> GetAllUnPin(string Email);
        Task<string> Pin(int ID, string Email);
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> UnPin(int ID, string Email);
        /// <summary>
        /// Images the upload.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<NotesModel> ImageUpload(int Id,IFormFile file, string email);
        /// <summary>
        /// Remindrs the specified notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> Remindr(string Email, int ID, string Reminder);
        /// <summary>
        /// Colours the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> Colour(NotesModel model, string Email);
        //Task<string> ProfilePictureUP(int Id, IFormFile file, string email);        
        /// <summary>
        /// Rems the reminder.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> RemReminder(int ID, string Email);
        /// <summary>
        /// Puttings the index value.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> PuttingIndexValue(NotesModel model, string Email);
        /// <summary>
        /// Drags the and drop.
        /// </summary>
        /// <param name="drag">The drag.</param>
        /// <param name="drop">The drop.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<string> DragAndDrop(int drag, int drop, string email);
        /// <summary>
        /// Displays the m.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <param name="Search">The search.</param>
        /// <returns></returns>
        Task<List<NotesModel>> DisplayM( string Email, string Search);

        Task<string> DeleteElementbyId(int ID, string Email);

    }
}
