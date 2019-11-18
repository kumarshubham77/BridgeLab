// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ICollaboratorManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.Collaborator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Interfaces
{
    /// <summary>
    /// Creating an Interface for ICollaboratorManager.
    /// </summary>
    public interface ICollaboratorManager
    {
        /// <summary>
        /// Collaborators the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> Collaborator(CollaboratorModels model, string Email);
        /// <summary>
        /// rs the collaborator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> RCollaborator(CollaboratorModels model, string Email);
    }
}
