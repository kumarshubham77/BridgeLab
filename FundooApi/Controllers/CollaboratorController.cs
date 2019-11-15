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
        private readonly ICollaboratorManager manager;
        public CollaboratorController(ICollaboratorManager emanager)
        {
            manager = emanager;
        }
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