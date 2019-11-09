// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using BusinessManager.Interfaces;
using Common.Models.NotesModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace FundooApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController][Authorize]
    public class NotesController : ControllerBase
    {
       
        private readonly INotesManager manager;
        public NotesController(INotesManager emanager)
        {
            manager = emanager;
        }
        [HttpPost]
        [Route("AddNote")]
        public async Task<IActionResult> Create(NotesModel notes)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                var result = await manager.Add(notes, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("Delete")]

        public async Task<IActionResult> Delete(int ID)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.Del(ID, Email);
                return Ok(new { result });
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

           
        }
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(NotesModel note)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.Update(note, Email);
                return Ok(new { result });
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("Show")]
        public async Task<IActionResult> Show()
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.Show(Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}