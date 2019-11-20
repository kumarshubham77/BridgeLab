using Common.Models.AdminModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Interfaces
{
    public interface IAdminManager
    {
        Task<string> Add(AdminModel model);
        bool Logging(string Email, string Password);
    }
}
