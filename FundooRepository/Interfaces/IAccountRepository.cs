// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IAccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.UserModels;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    /// <summary>
    /// Creating an Interface IAccountRepository
    /// contains methods such as Create,Login etc.,
    /// </summary>
    public interface IAccountRepository
    {
        //Creating class of Task type that represents a single operation that
        //does not return a value and usually executes Asynchronously(Occuring at the same time).
        //Passing the Models according the Task performed.
        Task Create(UserModel user);
        Task<string> LogIn(LoginModel login);
        Task ResetPassword(ResetPasswordModel reset);
        Task Forgot(ForgotPassword forgot);
        Task<UserModel> FindByEmailAsync(string email);
        Task LoginWithFacebook(LoginWithFacebookModel login);
        Task LoginWithGoogle(LoginWithGoogleModel login);
    }
}
