using Common.Models.LabelModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessManager.Interfaces
{
    public interface ILabelManager
    {
        Task<string> Add(LabelModel notes, string Email);
        Task<string> Update(LabelModel model, string Email);
        Task<string> Del(int ID, string Email);
        Task<List<LabelModel>> Show(string Email);
    }
}
