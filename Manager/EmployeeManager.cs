// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using EmployeeManagementMain.Model;
using EmployeeManagementMain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMain.Manager
{
    /// <summary>
    /// Class EmployeeManager inherit the interface class of the IManager.
    /// </summary>
    /// <seealso cref="EmployeeManagementMain.Manager.IManager" />
    public class EmployeeManager : IManager
    {
        Model.EmployeeModel emp = new Model.EmployeeModel();
        //calling IRepository but making it Private.
        private IRepository repository;
        
        public EmployeeManager()
        {

        }
        //Parameterized Constructor Implemented taking whole IRepository as a parameter.
        public EmployeeManager(IRepository erepository)
        {
            repository = erepository;
        }
        /// <summary>
        /// Add the user taking input from the user as a Parameter.
        /// </summary>
        /// <param name="EmpName">Name of the emp.</param>
        /// <param name="EmpPassword">The emp password.</param>
        /// <param name="EmpGender">The emp gender.</param>
        /// <returns></returns>
        public string Add(string EmpName, string EmpPassword, string EmpGender)
        {
            emp.EmpName = EmpName;
            emp.EmpPassword = EmpPassword;
            emp.EmpGender = EmpGender;
            repository.Create(emp.EmpName, emp.EmpPassword, emp.EmpGender);
            return "Account Added Successfully";
        }
        /// <summary>
        /// Deletes the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public string Delete(EmployeeModel employee)
        {
            var result = repository.Delete(employee);
            if(result==true)
            {
                return "Data Deleted Successfully";
            }
            else
            {
                return "Id did Not Match";
            }
        }
        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public string Update(EmployeeModel employee)
        {
            var result = repository.Update(employee);
            if(result == true)
            {
                return "Updation Done Successfully";
            }
            else
            {
                return "Updatation Can't be Done. Please Retry";
            }
        }
        /// <summary>
        /// Shows this instance.
        /// </summary>
        /// <returns>result</returns>
        public List<EmployeeModel> Show()
        {
            var result = repository.Show();
            return result;

        }
        /// <summary>
        /// Logins the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public string Login(EmployeeModel employee)
        {
            var result = repository.Login(employee);
            if (result == true)
            {
                return "Login Successful";
            }
            else
            {
                return "Login Unsuccessful";
            }
        }


    }
}
