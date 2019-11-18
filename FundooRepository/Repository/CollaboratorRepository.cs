// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.Collaborator;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    /// <summary>
    /// Making an class CollaboratorRepository implements ICollaboratorInterface.
    /// </summary>
    /// <seealso cref="FundooRepository.Interfaces.ICollaboratorInterface" />
    public class CollaboratorRepository : ICollaboratorInterface
    {
        /// <summary>
        /// making UserContext readonly.
        /// </summary>
        private readonly UserContexts _context;
        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public CollaboratorRepository(UserContexts context)
        {
            _context = context;
        }
        /// <summary>
        /// Adds the collabrator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task AddCollabrator(CollaboratorModels model, string Email)
        {
            var result = _context.user.Where(c => c.Email == model.ReceiverEmail).FirstOrDefault();
            if (result != null)
            {
                var check = _context.collaborator.Where(i => i.Noteid == model.Noteid).ToList();
                if (check.Count != 0)
                {
                    foreach (var list in check)
                    {
                        if (list.ReceiverEmail.Equals(model.ReceiverEmail))
                        {
                            return null;
                        }
                    }
                    Add(model, Email);
                    return Task.Run(() => _context.SaveChanges());
                }
                else
                {
                    Add(model, Email);
                    return Task.Run(() => _context.SaveChanges());

                }
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Removes the collabrator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task RemoveCollabrator(CollaboratorModels model, string Email)
        {
            var result = _context.collaborator.Where(i => i.Noteid == model.Noteid && i.ReceiverEmail == model.ReceiverEmail).FirstOrDefault();
            if(result != null)
            {
                _context.collaborator.Remove(result);
            }
            return Task.Run(() => _context.SaveChanges());
        }
        /// <summary>
        /// Adds the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public Task<bool> Add(CollaboratorModels model, string email)
        {
            var data = new CollaboratorModels()
            {
                Noteid = model.Noteid,
                SenderEmail = email,
                ReceiverEmail = model.ReceiverEmail 
            };
            _context.collaborator.Add(data);
            return Task.Run(() => true);
        }

        
    }
}
