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
        Task Create(LabelModel model, string Email);
        Task Update(LabelModel model, string Email);
        Task Delete(int ID, string Email);
        Task<List<LabelModel>> Show(string Email);
    }
}
