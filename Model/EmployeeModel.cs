// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMain.Model
{
    /// <summary>
    /// Creating a public class i.e., EmployeeModel
    /// Creating some fields with get set value 
    /// and making one of them as a primary key.
    /// </summary>
    public class EmployeeModel
    {
        [Key]
        public int EmpID { get; set; }

        public string EmpName { get; set; }
        public string EmpPassword { get; set; }
        public string EmpGender { get; set; }
    }
}
