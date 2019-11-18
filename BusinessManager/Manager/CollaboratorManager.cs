// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using BusinessManager.Interfaces;
using Common.Models.Collaborator;
using FundooRepository.Interfaces;
using System.Threading.Tasks;

namespace BusinessManager.Manager
{
    /// <summary>
    /// Creating a class CollaboratorManager implements ICollaboratorManager.
    /// </summary>
    /// <seealso cref="BusinessManager.Interfaces.ICollaboratorManager" />
    public class CollaboratorManager : ICollaboratorManager
    {
        /// <summary>
        /// Making Interface ICollaboratorInterface private readonly.
        /// </summary>
        private readonly ICollaboratorInterface collab;
        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorManager"/> class.
        /// </summary>
        /// <param name="ecollaborator">The ecollaborator.</param>
        public CollaboratorManager(ICollaboratorInterface ecollaborator)
        {
            collab = ecollaborator;
        }
        /// <summary>
        /// Collaborate the specified User.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Collaborator(CollaboratorModels model, string Email)
        {
            await collab.AddCollabrator(model, Email);
            return "Added Collaborator";
        }
        /// <summary>
        /// rs the collaborator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> RCollaborator(CollaboratorModels model, string Email)
        {
            await collab.RemoveCollabrator(model, Email);
            return "Removed Collaborator";
        }
    }
}
