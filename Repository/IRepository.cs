using EmployeeManagementMain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMain.Repository
{
    public interface IRepository
    {
        bool Create(string EmpName, string EmpPassword, string Gender);
        bool Delete(EmployeeModel employee);
        bool Update(EmployeeModel employee);
        List<EmployeeModel> Show();
        bool Login(EmployeeModel employee);
    }
}
