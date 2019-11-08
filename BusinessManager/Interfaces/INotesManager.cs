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
    }
}
