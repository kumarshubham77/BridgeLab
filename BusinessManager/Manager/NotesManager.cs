// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using BusinessManager.Interfaces;
using Common.Models.NotesModels;
using FundooRepository.Interfaces;
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

        public async Task<string> Del(int ID , string Email)
        {
            await notes.Delete(ID, Email);
            return "Deleted Successfully";
        }

        public async Task<List<NotesModel>> Show(string Email)
        {
            
            var result= await notes.Show(Email);
            return result;
             
        }

        public async Task<string> Update(NotesModel note, string Email)
        {
            await notes.Update(note, Email);
            return "Updated Successfully";
        }
    }
}
