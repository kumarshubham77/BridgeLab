using EmployeeManagementMain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMain.Manager
{
    public interface IManager
    {
        string Add(string EmpName, string EmpPassword, string EmpGender);
        string Delete(EmployeeModel employee);
        string Update(EmployeeModel employee);
        List<EmployeeModel> Show();
        string Login(EmployeeModel employee);
    }
}
