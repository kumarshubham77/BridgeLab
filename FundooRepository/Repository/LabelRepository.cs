// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
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
        private readonly UserContexts _context;
        public LabelRepository(UserContexts context)
        {
            _context = context;
        }
        /// <summary>
        /// Creates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task Create(LabelModel model, string Email)
        {
            model.Email = Email;
            var note = new LabelModel()
            {
                Email = model.Email,
                Label = model.Label
            };
            _context.labels.Add(note);
            return Task.Run(() => _context.SaveChanges());
        }
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task Delete(int ID, string Email)
        {
            var result = _context.labels.Where(j => j.ID == ID).FirstOrDefault();
            if (result.Email.Equals(Email))
            {

                if (result != null)
                {
                    _context.labels.Remove(result);
                }
                return Task.Run(() => _context.SaveChanges());
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Shows the specified email.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task<List<LabelModel>> Show(string Email)
        {
            var result = _context.labels.Where(i => i.Email == Email).GroupBy(o => new { o.Label }).Select(o => o.FirstOrDefault());
            var result1 = result.ToList();
            return Task.Run(() => result1);
        }
        /// <summary>
        /// Updates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public Task Update(LabelModel model, string Email)
        {
            var result = _context.labels.Where(j => j.ID == model.ID).FirstOrDefault();
            if (result.Email.Equals(Email))
            {
                if (result != null)
                {
                    result.Label = model.Label;
                    _context.labels.Update(result);
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
