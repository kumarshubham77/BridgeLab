// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.UserModels;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    /// <summary>
    /// Creating a class AccountRepository that will implement the interface class i.e., IAccountRepository.
    /// </summary>
    /// <seealso cref="FundooRepository.Interfaces.IAccountRepository" />
    public class AccountRepository : IAccountRepository
    {
        //Making the UserContext private and passing a name along with the readonly.
        private readonly UserContexts _context;
        /// <summary>
        /// To make it accessible Creating a public Constructor passing UserContext as a Parameter
        /// now assigning _context to newly created context.
        /// Initializes a new instance of the <see cref="AccountRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AccountRepository(UserContexts context)
        {
            _context = context;
        }
        /// <summary>
        /// Creates the specified user.
        /// Passing the UserModel as an Parameter.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public Task Create(UserModel user)
        {
            //Creating an object of the UserModel class.
            UserModel userm = new UserModel()
            {
                //Initializing every property declared in the UserModel class.
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                CardType = user.CardType
            };
            //Adding each values with all the properties to the database.
            _context.user.Add(userm);
            //Run the following qwery and return as an Task type.
            return Task.Run(() => _context.SaveChanges());
        }
        /// <summary>
        /// Creating a method of Task type i.e., LogIn and passing
        /// LoginModel as an Parameter.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <returns></returns>
        public Task LogIn(LoginModel login)
        {
            // Comparing the Email and Database Login similar as the Password and storing it in a variable.
            var result = _context.user.Where(i => i.Email == login.Email && i.Password == login.Password).FirstOrDefault();
            if (result != null)
            {

                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }

        //public Task Loginto(LoginModel login)
        //{
        //    var result = _context.users.Where(i => i.Email == login.Email).FirstOrDefault();
        //}


        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="reset">The reset.</param>
        /// <returns></returns>
        public Task ResetPassword(ResetPasswordModel reset)
        {
            var result = _context.user.Where(i => i.Email == reset.Email && i.Password == reset.OldPassword).FirstOrDefault();
            if (result != null)
            {
                result.Password = reset.NewPassword;
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Sending the users to reset their Password
        /// </summary>
        /// <param name="ToEmail">To email.</param>
        /// <param name="UserName">Name of the user.</param>
        private void SendPasswordResetEmail(string ToEmail, string UserName)
        {
            // MailMessage class is present is System.Net.Mail namespace
            MailMessage mailMessage = new MailMessage("shubham870940@gmail.com", ToEmail);
            // StringBuilder class is present in System.Text namespace
            StringBuilder sbEmailBody = new StringBuilder();
            sbEmailBody.Append("Dear " + UserName + ",<br/><br/>");
            sbEmailBody.Append("Please click on the following link to reset your password");
            sbEmailBody.Append("<br/>");
            sbEmailBody.Append("http://localhost/WebApplication1/Registration/ChangePassword.aspx?uid=");
            sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("<b>BRIDGELABZ</b>");
            mailMessage.IsBodyHtml = true;
            //Mentioning the Subject.
            mailMessage.Body = sbEmailBody.ToString();
            mailMessage.Subject = "Reset Your Password";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "shubham870940@gmail.com",
                Password = "Your Password"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);

        }
        /// <summary>
        /// Forget Password.
        /// </summary>
        /// <param name="forgot">The forgot.</param>
        /// <returns></returns>
        public Task Forgot(ForgotPassword forgot)
        {
            var result = _context.user.Where(i => i.Email == forgot.Email).FirstOrDefault();
            if (result != null)
            {
                SendPasswordResetEmail(forgot.Email, result.FirstName);
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Finds the by email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public Task<UserModel> FindByEmailAsync(string email)
        {
            var result = _context.user.Find(email);
            return Task.Run(() => result);
        }
        /// <summary>
        /// Logins the with facebook.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <returns></returns>
        public Task LoginWithFacebook(LoginWithFacebookModel login)
        {
            // Comparing the Email and Database Login similar as the Password and storing it in a variable.
            var result = _context.user.Where(i => i.Email == login.Email && i.Password == login.Password).FirstOrDefault();
            if (result != null)
            {

                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Logins the with google.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <returns></returns>
        public Task LoginWithGoogle(LoginWithGoogleModel login)
        {
            var result = _context.user.Where(i => i.Email == login.Email && i.Password == login.Password).FirstOrDefault();
            if (result != null)
            {

                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }
    }
}
