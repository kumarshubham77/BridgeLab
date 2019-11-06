// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BusinessManager.Interfaces;
using Castle.DynamicProxy.Generators;
using Common.Models.UserModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using StackExchange.Redis;

namespace FundooApi.Controllers
{
    /// <summary>
    /// Calling IAccountManager & ApplicationSetting and making them as a Private.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager _manager;
        private readonly ApplicationSetting _appsetting;
        public AccountController(IAccountManager manager,IOptions<ApplicationSetting> appsetting)
        {
            _manager = manager;
            _appsetting = appsetting.Value;
        }
        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Register(UserModel user)
        {
            var result = await _manager.Registration(user);
            return Ok(new { result });
        }
        [HttpPost]
        [Route("LogIn")]
        public async Task<IActionResult> LogIn(LoginModel login)
        {
            var result = await _manager.LogIn(login);
            return Ok(new { result });
        }
        [HttpPost]
        [Route("Reset")]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel reset)
        {
            var result = await _manager.ResetPassword(reset);
            return Ok(new { result });
        }
        [HttpPost]
        [Route("Forgot")]
        public async Task<IActionResult> Forgot(ForgotPassword forgot)
        {
            var result = await _manager.ForgotP(forgot);
            return Ok(new { result });
        }
        [HttpPost]
        [Route("log")]
        public async Task<IActionResult> Log(LoginModel login)
        {
            try
            {
                var result = await _manager.FindByEmailAsync(login.Email);
                if (result != null)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                           new Claim("Email", result.Email)
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567890123456")), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var cacheKey = login.Email;
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    //Introduction to Redis Cache.
                    ConnectionMultiplexer connectionMulitplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase database = connectionMulitplexer.GetDatabase();
                    database.StringSet(cacheKey, token.ToString());
                    database.StringGet(cacheKey);
                    return Ok(new { token });
                }
                else
                {
                    return BadRequest(new { message = "Not valid" });
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet,Authorize]
        
        [Route("reg")]
        public async Task<object> GetDetails()
        {
            string Email = User.Claims.First(c => c.Type == "Email").Value;
            var result =await _manager.FindByEmailAsync(Email);
            return new
            {
                result.Email,
                result.FirstName,
                result.LastName
            };
        }


        //public async Task<string> LOG(LoginModel login)
        //{
        //    var result = await _manager.FindByEmailAsync(login.Email);
        //    if (result != null && await this.CheckPasswordAsync(loginModel.EmailID, loginModel.PasswordM))
        //    {
        //        var SigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
        //        var credentials = new SigningCredentials(SigningKey, SecurityAlgorithms.HmacSha256);
        //        var token = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Issuer"],
        //            expires: DateTime.Now.AddDays(1),
        //            signingCredentials: credentials);
        //        var cacheKey = loginModel.EmailID;
        //        ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
        //        IDatabase database = connectionMultiplexer.GetDatabase();
        //        var data = (new
        //        {
        //            token = new JwtSecurityTokenHandler().WriteToken(token),
        //            experation = token.ValidTo
        //        });
        //        database.StringSet(cacheKey, data.ToString());
        //        database.StringGet(cacheKey);
        //        return data.ToString();
        //    }
        //    return null;
        //}



    }
}