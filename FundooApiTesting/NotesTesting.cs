//// --------------------------------------------------------------------------------------------------------------------
//// <copyright file=NotesTesting.cs" company="Bridgelabz">
////   Copyright © 2019 Company="BridgeLabz"
//// </copyright>
//// <creator name="Kumar Shubham"/>
//// --------------------------------------------------------------------------------------------------------------------
//using BusinessManager.Interfaces;
//using Common.Models.NotesModels;
//using FundooApi.Controllers;
//using Moq;
//using NUnit.Framework;


//namespace FundooApiTesting
//{
//    class NotesTesting
//    {
//        /// <summary>
//        /// Registers this instance that will be Tested.
//        /// </summary>
//        [Test]
//        public void Register()
//        {
//            var service = new Mock<INotesManager>();
//            var Controller = new NotesController(service.Object);
//            var add = new NotesModel()
//            {
//                Email = "shubham870940@gmail.com",
//                Title = "nothing",
//                Description = "Something",
                
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
//            var service = new Mock<INotesManager>();
//            var Controller = new NotesController(service.Object);
//            Assert.Pass();
//        }
//        /// <summary>
//        /// Deletes this instance that will be Tested.
//        /// </summary>
//        [Test]
//        public void Delete()
//        {
//            var service = new Mock<INotesManager>();
//            var Controller = new NotesController(service.Object);
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
//            var service = new Mock<INotesManager>();
//            var Controller = new NotesController(service.Object);
//            var add = new NotesModel()
//            {
//                Title = "College",
//                Description = "Meeting"
//            };
//            var data = Controller.Update(add);
//            Assert.NotNull(data);
//            Assert.Pass();
//        }
//    }
//}
