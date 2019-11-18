// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ICollaboratorInterface.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.Collaborator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    /// <summary>
    /// Creating an Interface of ICollaboratorInterface
    /// </summary>
    public interface ICollaboratorInterface
    {
        /// <summary>
        /// Adds the collabrator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task AddCollabrator(CollaboratorModels model, string Email);
        /// <summary>
        /// Removes the collabrator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task RemoveCollabrator(CollaboratorModels model, string Email);
    }
}
