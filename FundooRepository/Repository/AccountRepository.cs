// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Common.Models.AdminModels;
using Common.Models.UserModels;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using FundooRepository.Interfaces.RedisCache;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
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
        private readonly IAdminInterface _admin;
        private readonly ICacheProvider cacheProvider;
        /// <summary>
        /// To make it accessible Creating a public Constructor passing UserContext as a Parameter
        /// now assigning _context to newly created context.
        /// Initializes a new instance of the <see cref="AccountRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AccountRepository(UserContexts context,IAdminInterface admin, ICacheProvider cache)
        {
            _context = context;
            _admin = admin;
            cacheProvider = cache;
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
        public async Task<string> LogIn(LoginModel login)
        {
            // Comparing the Email and Database Login similar as the Password and storing it in a variable.
            var result = _context.user.Where(i => i.Email == login.Email && i.Password == login.Password).FirstOrDefault();
            if (result != null)
            {
               
               
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                           new Claim("Email", result.Email)
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567890123456")), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var cacheKey = login.Email;
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);

                    AdminUserDetails add = new AdminUserDetails()
                     {
                    UserEmailId = result.Email,
                    LogInTime = DateTime.Now.ToString(),
                    Services = result.CardType



                     };
                _context.adminuserdetails.Add(add);
                _context.SaveChanges();
                var key = result.ID.ToString() + "-" + result.Email;
                SetValuess(login.Email, key);
                return await Task.Run(() => token);

                
            }
            else
            {
                return null;
            }
        }
        public void SetValuess(string Email, string key)
        {
            var result = _context.notes.Where(i => i.Email == Email).ToList();
            if (result.Count != 0)
            {
                cacheProvider.Set(key, result);
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
        public Task ResetPassword(string Email,ResetPasswordModel reset)
        {
            var result = _context.user.Where(i => i.Email == Email).FirstOrDefault();
            if (result != null)
            {
                result.Password = reset.NewPassword;
                _context.user.Update(result).Property(x => x.ID).IsModified = false;
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
            sbEmailBody.Append("http://localhost:4200/reset");
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
                Password = "mostwanted123"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);

        }
        /// <summary>
        /// Forget Password.
        /// </summary>
        /// <param name="forgot">The forgot.</param>
        /// <returns></returns>
        public Task<string> Forgot(ForgotPassword forgot)
        {
            var result = _context.user.Where(i => i.Email == forgot.Email).FirstOrDefault();
            if (result != null)
            {
                SendPasswordResetEmail(forgot.Email, result.FirstName);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                          {
                           new Claim("Email", result.Email)
                          }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567890123456")), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
               return Task.Run(() => token);
            }
            else
            {
                return null;
            }
        }
        public Task<UserModel> ProfilePicture(IFormFile file, string email)
        {
            var path = file.OpenReadStream();
            var File = file.FileName;
            CloudinaryDotNet.Account account = new CloudinaryDotNet.Account("dalm6prqr", "742568932831953", "x9gQyQphOCQ0Tfp0ScFOYrj0DWM");
            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);
            var image = new ImageUploadParams()
            {
                File = new FileDescription(File, path)
            };
            var uploadResult = cloudinary.Upload(image);
            if (uploadResult.Error != null)
                throw new Exception(uploadResult.Error.Message);
            var result = _context.user.Where(i => i.Email == email).FirstOrDefault();
            if (result != null)
            {
                if (result.Email.Equals(email))
                {
                    result.ProfilePicture = uploadResult.Uri.ToString();
                    _context.SaveChanges();
                    return Task.Run(() => result);

                }
                else
                {
                    return null;
                }
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
