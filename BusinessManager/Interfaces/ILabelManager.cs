﻿// --------------------------------------------------------------------------------------------------------------------
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
    /// </summary>s
    public interface ILabelManager
    {
        Task<string> Add(LabelModel notes, string Email);
        Task<string> Update(LabelModel model, string Email);
        Task<string> Del(int ID, string Email);
        Task<List<LabelModel>> Show(string Email);
    }
}
