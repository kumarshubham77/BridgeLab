// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using BusinessManager.Interfaces;
using Common.Models.NotesModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace FundooApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
                //After decoding the resultant token it will store the email into the string variable Email. 
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
            }
            catch (Exception ex)
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
            }
            catch (Exception ex)
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
        [HttpPost]
        [Route("Archive")]
        public async Task<IActionResult> Archive(int ID)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.Archive(ID, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("UnArchive")]
        public async Task<IActionResult> UnArchive(int ID)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.UnArchive(ID, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("Trash")]
        public async Task<IActionResult> Trash(int ID)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.Trash(ID, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("UnTrash")]
        public async Task<IActionResult> UnTrash(int ID)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.UnTrash(ID, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("IsPin")]
        public async Task<IActionResult> Pin(int ID)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.Pin(ID, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("UnPin")]
        public async Task<IActionResult> UnPin(int ID)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.UnPin(ID, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("Image")]
        public async Task<IActionResult> ImageUpload(int Id, IFormFile file)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.ImageUpload(Id, file, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //[HttpPost]
        //[Route("ProfilePic")]
        //public async Task<IActionResult> ProfilePicUpload(int Id,IFormFile file)
        //{
        //    string Email = User.Claims.First(c => c.Type == "Email").Value;
        //    try
        //    {
        //        var result = await manager.ProfilePictureUP(Id, file, Email);
        //        return Ok(new { result });
        //    }
        //    catch(Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        [HttpPost]
        [Route("Reminder")]
        public async Task<IActionResult> Reminder(NotesModel model)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.Remindr(model, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("RemoveReminder")]
        public async Task<IActionResult> RemoveReminder(NotesModel model)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.RemReminder(model, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("Color")]
        public async Task<IActionResult> Color(NotesModel model)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.Colour(model, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}