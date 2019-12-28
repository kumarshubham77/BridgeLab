// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IAccountManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.UserModels;
using Microsoft.AspNetCore.Http;
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
        Task<string> ResetPassword(string Email,ResetPasswordModel reset);
        Task<string> ForgotP(ForgotPassword forgot);
        Task<UserModel> FindByEmailAsync(string email);
        Task<string> LoginWithFacebook(LoginWithFacebookModel login);
        Task<string> LoginWithGoogle(LoginWithGoogleModel login);
        Task<UserModel> ProfileUpload(IFormFile file, string email);
    }
}
