using Common.Models.Collaborator;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class CollaboratorRepository : ICollaboratorInterface
    {
        private readonly UserContexts _context;
        public CollaboratorRepository(UserContexts context)
        {
            _context = context;
        }
        public Task AddCollabrator(CollaboratorModels model, string Email)
        {
            var result = _context.user.Where(c => c.Email == model.ReceiverEmail).FirstOrDefault();
            if (result != null)
            {
                var check = _context.collaborator.Where(i => i.Noteid == model.Noteid).ToList();
                if (check.Count != 0)
                {
                    foreach (var list in check)
                    {
                        if (list.ReceiverEmail.Equals(model.ReceiverEmail))
                        {
                            return null;
                        }
                    }
                    Add(model, Email);
                    return Task.Run(() => _context.SaveChanges());
                }
                else
                {
                    Add(model, Email);
                    return Task.Run(() => _context.SaveChanges());

                }
            }
            else
            {
                return null;
            }
        }
        public Task RemoveCollabrator(CollaboratorModels model, string Email)
        {
            var result = _context.collaborator.Where(i => i.Noteid == model.Noteid && i.ReceiverEmail == model.ReceiverEmail).FirstOrDefault();
            if(result != null)
            {
                _context.collaborator.Remove(result);
            }
            return Task.Run(() => _context.SaveChanges());
        }
        public Task<bool> Add(CollaboratorModels model, string email)
        {
            var data = new CollaboratorModels()
            {
                Noteid = model.Noteid,
                SenderEmail = email,
                ReceiverEmail = model.ReceiverEmail
            };
            _context.collaborator.Add(data);
            return Task.Run(() => true);
        }

        
    }
}
