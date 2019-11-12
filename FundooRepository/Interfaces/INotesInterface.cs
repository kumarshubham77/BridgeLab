﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INotesInterface.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.NotesModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    public interface INotesInterface
    {
        Task Create(NotesModel model, string Email);
        Task Update(NotesModel notes,string Email);
        
        Task<List<NotesModel>> Show(string Email);
        //bool Login(NotesModel notes);
        Task Delete(int ID, string Email);
        Task Archive(int ID, string Email);
        Task UnArchive(int ID, string Email);
        Task Trash(int ID, string Email);

    }
}
