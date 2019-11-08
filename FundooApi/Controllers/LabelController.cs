using BusinessManager.Interfaces;
using Common.Models.LabelModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FundooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController][Authorize]
    public class LabelController : ControllerBase
    {
        private readonly ILabelManager manager;

        public LabelController(ILabelManager emanager)
        {
            manager = emanager;
        }
        [HttpPost]
        [Route("AddLabel")]
        public async Task<IActionResult> Create(LabelModel label)
        {
            try
            {
                string Email = User.Claims.First(c => c.Type == "Email").Value;
                var result = await manager.Add(label, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("LabelUpdate")]
        public async Task<IActionResult> Update(LabelModel label)
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            try
            {
                var result = await manager.Update(label, Email);
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("LabelDelete")]

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
        [HttpGet]
        [Route("LabelShow")]
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