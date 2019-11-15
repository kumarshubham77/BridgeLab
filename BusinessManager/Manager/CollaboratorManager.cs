using BusinessManager.Interfaces;
using Common.Models.Collaborator;
using FundooRepository.Interfaces;
using System.Threading.Tasks;

namespace BusinessManager.Manager
{
    public class CollaboratorManager : ICollaboratorManager
    {
        private readonly ICollaboratorInterface collab;
        public CollaboratorManager(ICollaboratorInterface ecollaborator)
        {
            collab = ecollaborator;
        }
        public async Task<string> Collaborator(CollaboratorModels model, string Email)
        {
            await collab.AddCollabrator(model, Email);
            return "Added Collaborator";
        }

        public async Task<string> RCollaborator(CollaboratorModels model, string Email)
        {
            await collab.RemoveCollabrator(model, Email);
            return "Removed Collaborator";
        }
    }
}
