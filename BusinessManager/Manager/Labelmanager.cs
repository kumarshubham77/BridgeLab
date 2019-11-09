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
    public class Labelmanager : ILabelManager
    {
        private readonly ILabelInterface label;
        public Labelmanager(ILabelInterface Ilabel)
        {
            label = Ilabel;
        }

        public async Task<string> Add(LabelModel model, string Email)
        {
            await label.Create(model, Email);
            return "Added Successfully";
        }

        public async Task<string> Del(int ID, string Email)
        {
            await label.Delete(ID, Email);
            return "Deleted Successfully";
        }

        public async Task<List<LabelModel>> Show(string Email)
        {
            var result = await label.Show(Email);
            return result;
        }

        public async Task<string> Update(LabelModel model, string Email)
        {
            await label.Update(model, Email);
            return "Update Successfull";
        }

        
    }
}
