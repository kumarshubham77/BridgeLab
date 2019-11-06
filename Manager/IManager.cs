// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using EmployeeManagementMain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMain.Manager
{
    /// <summary>
    /// Creating an Interface IManager and defining methods that can be inherit to Other class.
    /// </summary>
    public interface IManager
    {
        string Add(string EmpName, string EmpPassword, string EmpGender);
        string Delete(EmployeeModel employee);
        string Update(EmployeeModel employee);
        List<EmployeeModel> Show();
        string Login(EmployeeModel employee);
    }
}
