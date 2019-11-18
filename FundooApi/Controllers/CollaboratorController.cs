// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.Interfaces;
using Common.Models.Collaborator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    
    public class CollaboratorController : ControllerBase
    {
        /// <summary>
        /// Making interface of ICollaboratorManager private readonly.
        /// </summary>
        private readonly ICollaboratorManager manager;
        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorController"/> class.
        /// </summary>
        /// <param name="emanager">The emanager.</param>
        public CollaboratorController(ICollaboratorManager emanager)
        {
            manager = emanager;
        }
        /// <summary>
        /// Adds the collaborator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddCollaborator")]
        public async Task<IActionResult> AddCollaborator(CollaboratorModels model)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                var result = await manager.Collaborator(model, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Removes the collaborator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("RemoveCollaborator")]
        public async Task<IActionResult> RemoveCollaborator(CollaboratorModels model)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                var result = await manager.RCollaborator(model, Email);
                return Ok(new { result });
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}