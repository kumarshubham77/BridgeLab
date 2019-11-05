using EmployeeManagementMain.Model;
using EmployeeManagementMain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMain.Manager
{
    public class EmployeeManager : IManager
    {
        Model.EmployeeModel emp = new Model.EmployeeModel();
        private IRepository repository;
        public EmployeeManager()
        {

        }
        public EmployeeManager(IRepository erepository)
        {
            repository = erepository;
        }
        public string Add(string EmpName, string EmpPassword, string EmpGender)
        {
            emp.EmpName = EmpName;
            emp.EmpPassword = EmpPassword;
            emp.EmpGender = EmpGender;
            repository.Create(emp.EmpName, emp.EmpPassword, emp.EmpGender);
            return "Account Added Successfully";
        }
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
        public List<EmployeeModel> Show()
        {
            var result = repository.Show();
            return result;

        }
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
