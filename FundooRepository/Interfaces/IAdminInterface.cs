using Common.Models.AdminModels;
using Common.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    public interface IAdminInterface
    {
        Task Create(AdminModel model);
        Task Update(AdminModel model);
        Task Delete(int AdminID, string Email);
        //Task<List<AdminModel>> Show(string Email);
        Task AddUserDetails(UserModel user, string logintime);
        bool LogIn(string Email, string Password);
    }
}
