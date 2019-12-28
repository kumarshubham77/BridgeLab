using Common.Models.AdminModels;
using Common.Models.UserModels;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class AdminRepository : IAdminInterface
    {
        private readonly UserContexts _context;
        public AdminRepository(UserContexts context)
        {
            _context = context;
        }
        public Task Create(AdminModel model)
        {
            AdminModel admin = new AdminModel()
            {
                
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password

            };
            _context.admin.Add(admin);
            return Task.Run(() => _context.SaveChanges());
        }

        public Task Delete(int AdminID,string Email)
        {
            var result = _context.admin.Where(j => j.AdminID == AdminID).FirstOrDefault();
            if(result != null)
            {
                if(result.Email.Equals(Email))
                {
                    _context.admin.Remove(result);
                }
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }

        //public Task<List<AdminModel>> Show(string Email)
        //{
        //    bool note = _context.admin.Any(j => j.Email == Email);


        //}

        public Task Update(AdminModel model)
        {
            var result = _context.admin.Where(j => j.AdminID == model.AdminID).FirstOrDefault();
            if(result != null)
            {
                if (result.Email.Equals(model.Email))
                {
                    result.FirstName = model.FirstName;
                    result.LastName = model.LastName;
                    result.Password = model.Password;
                    _context.admin.Update(result);
                }
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }
        public Task AddUserDetails(UserModel user,string logintime)
        {
            var add = new AdminUserDetails()
            {
                UserEmailId=user.Email,
                LogInTime=logintime,
                Services=user.CardType
            };
            _context.adminuserdetails.Add(add);
            return Task.Run(() => _context.SaveChanges());

        }

        public bool LogIn(string Email, string Password)
        {
            var result = _context.admin.Where(j => j.Email == Email && j.Password == Password).FirstOrDefault();
            if(result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //public Task LIST()
        //{
        //    var result = from users in _context.user select users.;


        //}


        public Task<List<AdminUserDetails>> DisplayUserDetails()
        {
            return Task.Run(() => _context.adminuserdetails.ToList());
        }

        /// <summary>
        /// DisplayUsers method for displaying the user details
        /// </summary>
        /// <returns></returns>
        public Task<List<UserModel>> DisplayUsers()
        {
            return Task.Run(() => _context.user.ToList());
        }

        
    }
}
