// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ILabelInterface.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.LabelModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    public interface ILabelInterface
    {
        /// <summary>
        /// Creates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task Create(LabelModel model, string Email);
        /// <summary>
        /// Updates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task Update(LabelModel model, string Email);
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task Delete(int ID, string Email);
        /// <summary>
        /// Shows the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        Task<List<LabelModel>> Show(string Email);
    }
}
