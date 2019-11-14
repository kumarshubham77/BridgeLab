using Common.Models.Collaborator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    public interface ICollaboratorInterface
    {
        Task AddCollabrator(CollaboratorModels model, string Email);
        Task RemoveCollabrator(CollaboratorModels model, string Email);
    }
}
