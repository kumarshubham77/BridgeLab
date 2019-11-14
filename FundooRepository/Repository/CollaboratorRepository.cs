using Common.Models.Collaborator;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class CollaboratorRepository : ICollaboratorInterface
    {
        public Task AddCollabrator(CollaboratorModel model, string Email)
        {
            
        }

        public Task RemoveCollabrator(CollaboratorModel model, string Email)
        {
            throw new NotImplementedException();
        }
    }
}
