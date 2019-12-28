using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.Interfaces;
using Common.Models.AdminModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminManager admin;

        public AdminController(IAdminManager iadmin)
        {
            admin = iadmin;
        }
        [HttpPost]
        [Route("AddAdmin")]
        public async Task<IActionResult> AddAdmin (AdminModel model)
        {
            var result = await admin.Add(model);
            return Ok(new { result });
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(string Email, string Password)
        {
            bool result = admin.Logging(Email,Password);
            return Ok(new { result }); 
        }
        [HttpGet]
        [Route("userstatistic")]
        public async Task<IActionResult> UserStatistic()
        {
            try
            {
                var result = await admin.DisplayUserStats();
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// UserDetails controller
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("userdetails")]
        public async Task<IActionResult> UserDetails()
        {
            try
            {
                var result = await admin.DisplayUserDetails();
                return Ok(new { result });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}