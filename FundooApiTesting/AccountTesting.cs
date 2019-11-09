// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountTesting.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooApiTesting
{
    using BusinessManager.Interfaces;
    using Common.Models.UserModels;
    using FundooApi.Controllers;
    using Microsoft.Extensions.Options;
    using Moq;
    using NUnit.Framework;
    /// <summary>
    /// AccountTesting is a class for test the AccountController
    /// </summary>
    public class AccountTesting
    {
        /// <summary>
        /// Registers this instance will be tested.
        /// </summary>
        [Test]
        public void Register()
        {
            var service = new Mock<IAccountManager>();
            var services1 = new Mock<IOptions<ApplicationSetting>>();
            var Controller = new AccountController(service.Object,services1.Object);
            var add = new UserModel()
            {
                FirstName = "Kumar",
                LastName = "Shubham",
                Email = "shubham870940@gmail.com",
                Password = "1234567890",
                CardType = "advance"
            };
            var data = Controller.Register(add);
            Assert.NotNull(data);
            Assert.Pass();
        }
        /// <summary>
        /// Logins this instance will be tested.
        /// </summary>
        [Test]
        public void Login()
        {
            var service = new Mock<IAccountManager>();
            var services1 = new Mock<IOptions<ApplicationSetting>>();
            var Controller = new AccountController(service.Object,services1.Object);
            var add = new LoginModel()
            {
                Email = "shubham870940@gmail.com"
            };
            var data = Controller.LogIn(add);
            Assert.NotNull(data);
            Assert.Pass();
        }
        /// <summary>
        /// Resets the password will be tested.
        /// </summary>
        [Test]
        public void ResetPassword()
        {
            var service = new Mock<IAccountManager>();
            var services1 = new Mock<IOptions<ApplicationSetting>>();
            var Controller = new AccountController(service.Object,services1.Object);
            var add = new ResetPasswordModel()
            {
                Email = "shubham870940@gmail.com",
                OldPassword = "12345678"

            };
            var data = Controller.ResetPassword(add);
            Assert.NotNull(data);
            Assert.Pass();
        }
        /// <summary>
        /// Forgets the password will be tested.
        /// </summary>
        [Test]
        public void ForgetPassword()
        {
            var service = new Mock<IAccountManager>();
            var services1 = new Mock<IOptions<ApplicationSetting>>();
            var Controller = new AccountController(service.Object,services1.Object);
            var add = new ForgotPassword()
            {
                Email = "shubham870940@gmail.com"

            };
            var data = Controller.Forgot(add);
            Assert.NotNull(data);
            Assert.Pass();
        }
    }
}