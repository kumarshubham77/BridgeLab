using BusinessManager.Interfaces;
using Common.Models.UserModels;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Manager
{
    public class AccountManager:IAccountManager
    {
        private readonly IAccountRepository _repository;
        public AccountManager(IAccountRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Registration(UserModel user)
        {
            await _repository.Create(user);
            return "Account Created Succesfully";
        }
        public async Task<string> LogIn(LoginModel login)
        {
            await _repository.LogIn(login);
            return "Login Successfull";
        }

        public async Task<string> ResetPassword(ResetPasswordModel reset)
        {
            await _repository.ResetPassword(reset);
            return "Successfully Reset the Password";
        }
        public async Task<string> ForgotP(ForgotPassword forgot)
        {
            await _repository.Forgot(forgot);
            return "You sucessfully recieved Email for changing Password";
        }
        public async Task<UserModel> FindByEmailAsync(string email)
        {
            var result = await _repository.FindByEmailAsync(email);
            return result;
        }
    }
}
