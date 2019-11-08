using Common.Models.LabelModels;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class LabelRepository : ILabelInterface
    {
        private readonly UserContext _context;
        public LabelRepository(UserContext context)
        {
            _context = context;
        }
        public Task Create(LabelModel model, string Email)
        {
            model.Email = Email;
            var note = new LabelModel()
            {
                Email = model.Email,
                Label = model.Label
            };
            _context.label.Add(note);
            return Task.Run(() => _context.SaveChanges());
        }

        public Task Delete(int ID, string Email)
        {
            var result = _context.label.Where(j => j.ID == ID).FirstOrDefault();
            if (result.Email.Equals(Email))
            {

                if (result != null)
                {
                    _context.label.Remove(result);
                }
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }

        public Task<List<LabelModel>> Show(string Email)
        {
            bool note = _context.label.Any(p => p.Email == Email);
            if (note)
            {
                return Task.Run(() => _context.label.Where(p => p.Email == Email).ToList());
            }
            else
            {
                return null;
            }
        }

        public Task Update(LabelModel model, string Email)
        {
           var result = _context.label.Where(j => j.ID == model.ID).FirstOrDefault();
            if (result.Email.Equals(Email))
            {
                if (result != null)
                {
                    result.Label = model.Label;
                    _context.label.Update(result);
                }
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }

        }
    }
}
