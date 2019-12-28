using BusinessManager.Interfaces;
using Common.Models.AdminModels;
using Common.Models.UserModels;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Manager
{
    public class AdminManager : IAdminManager
    {
        private readonly IAdminInterface admin;
        public AdminManager(IAdminInterface _admin)
        {
            admin = _admin;
        }
        public async Task<string> Add(AdminModel model)
        {
            await admin.Create(model);
            return "Added";
        }
        public bool Logging(string Email, string Password)
        {
            return admin.LogIn(Email,Password);
        }
        public  async Task<List<AdminUserDetails>> DisplayUserStats()
        {
            return await admin.DisplayUserDetails();
        }
        public async Task<List<UserModel>> DisplayUserDetails()
        {
            return await admin.DisplayUsers();
        }

    }

}
