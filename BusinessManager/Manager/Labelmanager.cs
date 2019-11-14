// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Labelmanager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using BusinessManager.Interfaces;
using Common.Models.LabelModels;
using FundooRepository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessManager.Manager
{
    /// <summary>
    /// Creating Interaface LabelManager and calling ILabelInterface and making it Private.
    /// </summary>
    /// <seealso cref="BusinessManager.Interfaces.ILabelManager" />
    public class Labelmanager : ILabelManager
    {
        private readonly ILabelInterface label;
        public Labelmanager(ILabelInterface Ilabel)
        {
            label = Ilabel;
        }
        /// <summary>
        /// Adds the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Add(LabelModel model, string Email)
        {
            await label.Create(model, Email);
            return "Added Successfully";
        }
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Del(int ID, string Email)
        {
            await label.Delete(ID, Email);
            return "Deleted Successfully";
        }
        /// <summary>
        /// Shows the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<List<LabelModel>> Show(string Email)
        {
            var result = await label.Show(Email);
            return result;
        }
        /// <summary>
        /// Updates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public async Task<string> Update(LabelModel model, string Email)
        {
            await label.Update(model, Email);
            return "Update Successfull";
        }


    }
}
