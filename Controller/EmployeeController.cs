// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using EmployeeManagementMain.Manager;
using EmployeeManagementMain.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMain.Controller
{
    /// <summary>
    /// This [Route("api/[controller]")] used when POSTMAN is in work.
    /// else it should be disabled.
    /// This class will inherit the interface i.e., ControllerBase.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    //[Route("api/[controller]")]
    //[ApiController]    
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// Inheriting the interface class of the IManager here.
        /// </summary>
        private IManager manager;

        /// <summary>
        /// Creating a Parametrized Constructor of the IManager Interface as an Parameter.
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="Emanager">The emanager.</param>
        public EmployeeController(IManager Emanager)
        {
            //Assigning Emanager to manager.
            manager = Emanager;
        }
        /// <summary>
        ///Through the Post method it will add the user to the Database.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Add")] //Url Add that is to provided into the Postman URL.
        public IActionResult Create(EmployeeModel employee)
        {
            try
            {
                var result = manager.Add(employee.EmpName, employee.EmpPassword, employee.EmpGender);
                return Ok(new { result });
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Delete method will delete the user from the database. 
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete")]//Delete will be passed as the POSTMAN URL.
        public IActionResult Delete(EmployeeModel employee)
        {
            try
            {
                var result = manager.Delete(employee);
                return Ok(new { result });
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("Update")]//Update will be passed to the POSTMAN URL.
        public IActionResult Update(EmployeeModel employee)
        {
            try
            {
                var result = manager.Update(employee);
                return Ok(new { result } );
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Shows this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Show")]
        public IActionResult Show()
        {
            try
            {
                var result = manager.Show();
                return Ok( result );
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Logins the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(EmployeeModel employee)
        {
            try
            {
                var result = manager.Login(employee);
                return Ok(new { result });
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
