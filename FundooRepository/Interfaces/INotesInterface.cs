// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INotesInterface.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.NotesModels;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    public interface INotesInterface
    {
        /// <summary>
        /// Creates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task Create(NotesModel model, string Email);
        /// <summary>
        /// Updates the specified notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task Update(NotesModel notes, string Email);

        /// <summary>
        /// Shows the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<List<NotesModel>> Show(string Email);
        //bool Login(NotesModel notes);        
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task Delete(int ID, string Email);
        /// <summary>
        /// Archives the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task Archive(int ID, string Email);
        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task UnArchive(int ID, string Email);
        /// <summary>
        /// Trashes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task Trash(int ID, string Email);
        /// <summary>
        /// Uns the trash.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task UnTrash(int ID, string Email);
        //Task Reminder(NotesModel notes, string Email);        
        /// <summary>
        /// Pins the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task Pin(int ID, string Email);
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task UnPin(int ID, string Email);
        /// <summary>
        /// Images the upload.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task ImageUpload(int Id, IFormFile file, string email);
        /// <summary>
        /// Reminds the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task Remind(NotesModel model, string Email);
        /// <summary>
        /// Removes the reminder.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task RemoveReminder(NotesModel model, string Email);
        /// <summary>
        /// Colors the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task Color(NotesModel model, string Email);
        //Task ProfilePicture(int Id, IFormFile file, string email);        
        /// <summary>
        /// Puts the index value.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task PutIndexValue(NotesModel model, string Email);
        /// <summary>
        /// Drags the and drop.
        /// </summary>
        /// <param name="drag">The drag.</param>
        /// <param name="drop">The drop.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task DragAndDrop(int drag, int drop, string email);
        /// <summary>
        /// Displays the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <param name="Search">The search.</param>
        /// <returns></returns>
        Task<List<NotesModel>> Display(string Email, string Search);
        //Task DragandDrop(NotesModel model, string Email);
    }
}
