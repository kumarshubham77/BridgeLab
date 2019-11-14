//// --------------------------------------------------------------------------------------------------------------------
//// <copyright file=LabelTesting.cs" company="Bridgelabz">
////   Copyright © 2019 Company="BridgeLabz"
//// </copyright>
//// <creator name="Kumar Shubham"/>
//// --------------------------------------------------------------------------------------------------------------------
//using BusinessManager.Interfaces;
//using Common.Models.LabelModels;
//using FundooApi.Controllers;
//using Moq;
//using NUnit.Framework;


//namespace FundooApiTesting
//{
//    /// <summary>
//    /// Class LabelTesting
//    /// </summary>
//    class LabelTesting
//    {
//        /// <summary>
//        /// Registers this instance that will be Tested.
//        /// </summary>
//        [Test]
//        public void Register()
//        {
//            var service = new Mock<ILabelManager>();
//            var Controller = new LabelController(service.Object);
//            var add = new LabelModel()
//            {
//                Email = "shubham870940@gmail.com",
//                Label = "Advaned",

//            };
//            var data = Controller.Create(add);
//            Assert.NotNull(data);
//            Assert.Pass();
//        }
//        /// <summary>
//        /// Shows this instance that will be Tested.
//        /// </summary>
//        [Test]
//        public void Show()
//        {
//            var service = new Mock<ILabelManager>();
//            var Controller = new LabelController(service.Object);
//            Assert.Pass();
//        }
//        /// <summary>
//        /// Deletes this instance that will be Tested.
//        /// </summary>
//        [Test]
//        public void Delete()
//        {
//            var service = new Mock<ILabelManager>();
//            var Controller = new LabelController(service.Object);
//            var data = Controller.Delete(2);
//            Assert.NotNull(data);
//            Assert.Pass();
//        }
//        /// <summary>
//        /// Updates this instance that will be Tested.
//        /// </summary>
//        [Test]
//        public void Update()
//        {
//            var service = new Mock<ILabelManager>();
//            var Controller = new LabelController(service.Object);
//            var add = new LabelModel()
//            {
//                Label = "Normal",
//            };
//            var data = Controller.Update(add);
//            Assert.NotNull(data);
//            Assert.Pass();
//        }
//    }
//}

