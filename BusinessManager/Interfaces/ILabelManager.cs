// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ILabelManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.LabelModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessManager.Interfaces
{
    /// <summary>
    /// creating Interface ILabelManager
    /// </summary>
    public interface ILabelManager
    {
        /// <summary>
        /// Adds the specified notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> Add(LabelModel notes, string Email);
        /// <summary>
        /// Updates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> Update(LabelModel model, string Email);
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<string> Del(int ID, string Email);
        /// <summary>
        /// Shows the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<List<LabelModel>> Show(string Email);
    }
}
