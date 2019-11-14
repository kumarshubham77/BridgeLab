using Common.Models.Collaborator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    public interface ICollaboratorInterface
    {
        Task AddCollabrator(CollaboratorModel model, string Email);
        Task RemoveCollabrator(CollaboratorModel model, string Email);
    }
}
