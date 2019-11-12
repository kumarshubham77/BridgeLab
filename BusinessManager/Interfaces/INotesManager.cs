// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INotesManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.NotesModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessManager.Interfaces
{
    public interface INotesManager
    {
        Task<string> Add(NotesModel notes, string Email);
        Task<string> Del(int ID, string Email);
        Task<string> Update(NotesModel note, string Email);
        Task<List<NotesModel>> Show(string Email);
        Task<string> Archive(int ID, string Email);
        Task<string> UnArchive(int ID, string Email);
        Task<string> Trash(int ID, string Email);
    }
}
