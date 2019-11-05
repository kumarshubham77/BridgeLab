using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMain.Model
{
    public class EmployeeModel
    {
        [Key]
        public int EmpID { get; set; }

        public string EmpName { get; set; }
        public string EmpPassword { get; set; }
        public string EmpGender { get; set; }
    }
}
