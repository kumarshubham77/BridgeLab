// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using EmployeeManagementMain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMain.Repository
{
    /// <summary>
    /// Creating a public Interface IRepository
    /// Containing some methods can be inherit in other class.
    /// </summary>
    public interface IRepository
    {
        //Creata a particualr user taking some input from the user such as EmpName etc.,
        bool Create(string EmpName, string EmpPassword, string Gender);
        //Deleting a Particular user taking whole model of the EmployeeModel as a Parameter.
        bool Delete(EmployeeModel employee);
        //Upadting the particular user.
        bool Update(EmployeeModel employee);
        List<EmployeeModel> Show();
        //Login For the Particular User.
        bool Login(EmployeeModel employee);
    }
}
