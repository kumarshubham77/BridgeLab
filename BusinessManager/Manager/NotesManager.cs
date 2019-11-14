// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using BusinessManager.Interfaces;
using Common.Models.NotesModels;
using FundooRepository.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessManager.Manager
{
    public class NotesManager : INotesManager
    {


        private readonly INotesInterface notes;
        public NotesManager(INotesInterface inotes)
        {
            notes = inotes;
        }

        public async Task<string> Add(NotesModel model, string Email)
        {
            await notes.Create(model, Email);
            return "Added Successfully";
        }

        public async Task<string> Del(int ID, string Email)
        {
            await notes.Delete(ID, Email);
            return "Deleted Successfully";
        }

        public async Task<List<NotesModel>> Show(string Email)
        {

            var result = await notes.Show(Email);
            return result;

        }

        public async Task<string> Update(NotesModel note, string Email)
        {
            await notes.Update(note, Email);
            return "Updated Successfully";
        }


        public async Task<string> Archive(int ID, string Email)
        {
            await notes.Archive(ID, Email);
            return "Archieved Successfully";
        }

        public async Task<string> UnArchive(int ID, string Email)
        {
            await notes.UnArchive(ID, Email);
            return "UnArchieved Successfull";
        }

        public async Task<string> Trash(int ID, string Email)
        {
            await notes.Trash(ID, Email);
            return "Gone To the Garbage Bin";
        }
        public async Task<string> UnTrash(int ID, string Email)
        {
            await notes.UnTrash(ID, Email);
            return "UnTrash Succesfull";
        }

        public async Task<string> Pin(int ID, string Email)
        {
            await notes.Pin(ID, Email);
            return "Pinned Successfully";
        }
        public async Task<string> ImageUpload(int Id, IFormFile file, string email)
        {
            await notes.ImageUpload(Id, file, email);
            return "Uploading Image in Cloudinary Success";
        }

        public async Task<string> UnPin(int ID, string Email)
        {
            await notes.UnPin(ID, Email);
            return "UnPinned Successfull";
        }

        public async Task<string> Remindr(NotesModel model, string Email)
        {
            await notes.Remind(model, Email);
            return "Reminder Sets.";
        }

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

        public async Task<string> RemReminder(NotesModel model, string Email)
        {
            await notes.RemoveReminder(model, Email);
            return "Removed Reminder";
        }



        //public async Task<string> Reminder(NotesModel notes, string Email)
        //{
        //    await notes.Reminder(notes, Email);
        //    return "Reminder";
        //}
    }
}
