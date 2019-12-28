﻿ //--------------------------------------------------------------------------------------------------------------------
// <copyright file = AccountManager.cs" company="Bridgelabz">
  // Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name = "Kumar Shubham" />
 //--------------------------------------------------------------------------------------------------------------------
using BusinessManager.Interfaces;
using Common.Models.UserModels;
using FundooRepository.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BusinessManager.Manager
{
   /// <summary>
    /// Creating a class AccountManager that will inherit the interface class IAccountManager
    /// </summary>
    /// <seealso cref = "BusinessManager.Interfaces.IAccountManager" />
    public class AccountManager : IAccountManager
    {
        ///calling Interface IAccountRepository but making it private.
        private readonly IAccountRepository _repository;
        ///<summary>
        /// Initializes a new instance of the<see cref="AccountManager"/> class.
        ///Creating a parametrized constructor and passing the IAccountRepository as a parameter.
        ///</summary>
        /// <param name = "repository" > The repository.</param>
        public AccountManager(IAccountRepository repository)
        {
            _repository = repository;
        }
        //// <summary>
        //// Registrations the specified user.
        //// </summary>
        //// <param name = "user" > The user.</param>
        //// <returns></returns>
        public async Task<string> Registration(UserModel user)
        {
            await _repository.Create(user);
            return "Account Created Succesfully";
        }
        /// <summary>
        /// Logs the in.
        /// </summary>
        /// <param name = "login" > The login.</param>
        /// <returns></returns>
        public async Task<string> LogIn(LoginModel login)
        {
            var Token = await _repository.LogIn(login);
            return Token;
        }
        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="reset">The reset.</param>
        /// <returns></returns>
        public async Task<string> ResetPassword(string Email,ResetPasswordModel reset)
        {
            await _repository.ResetPassword(Email,reset);
            return "Successfully Reset the Password";
        }
        /// <summary>
        /// Forgots the password.
        /// </summary>
        /// <param name = "forgot" > The forgot.</param>
        /// <returns></returns>
        public async Task<string> ForgotP(ForgotPassword forgot)
        {
            string result=await _repository.Forgot(forgot);
            return result;
        }
        /// <summary>
        /// Finds the by email asynchronous.
        /// </summary>
        /// <param name = "email" > The email.</param>
        /// <returns></returns>
        public async Task<UserModel> FindByEmailAsync(string email)
        {
            var result = await _repository.FindByEmailAsync(email);
            return result;
        }
        // / <summary>
        /// Logins the with facebook.
        // / </summary>
        /// <param name = "login" > The login.</param>
        /// <returns></returns>
        public async Task<string> LoginWithFacebook(LoginWithFacebookModel login)
        {
            await _repository.LoginWithFacebook(login);
            return "Login Successfull";
        }
        /// <summary>
        /// Logins the with google.
        /// </summary>
        /// <param name = "login" > The login.</param>
        /// <returns></returns>
        public async Task<string> LoginWithGoogle(LoginWithGoogleModel login)
        {
            await _repository.LoginWithGoogle(login);
            return "Login Successfull";
        }
        public async Task<UserModel> ProfileUpload(IFormFile file, string email)
        {
            var result =  await _repository.ProfilePicture(file,email);
            return result;
        }
    }
}
