// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IAccountManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Interfaces
{
    /// <summary>
    /// Declaring an public Interface class IAccountManager.
    /// Defining some methods into it.
    /// </summary>
    public interface IAccountManager
    {
        Task<string> Registration(UserModel user);
        Task<string> LogIn(LoginModel login);
        Task<string> ResetPassword(ResetPasswordModel reset);
        Task<string> ForgotP(ForgotPassword forgot);
        Task<UserModel> FindByEmailAsync(string email);
    }
}
