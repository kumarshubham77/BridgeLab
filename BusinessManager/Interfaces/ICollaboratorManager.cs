using Common.Models.Collaborator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Interfaces
{
    public interface ICollaboratorManager
    {
        Task<string> Collaborator(CollaboratorModels model, string Email);
    }
}
