using EmployeeManagementMain.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementMain.Repository
{
    public class EmployeeRepository: IRepository
    {
        private readonly IConfiguration configration;
        private SqlConnection con = null;
        string constr = "Server=(localdb)\\MSSQLLocaldb;Database=EmployeeDatabase;Integrated Security=True;";
        
        public EmployeeRepository(IConfiguration config)
        {
            configration = config;
        }
        public void Conncetion()
        {
            //constr = configration.GetSection("Data").GetSection("ConnectionString").Value;
            con = new SqlConnection(constr);
        }

        public bool Create(string EmpName, string EmpPassword, string EmpGender)
        {
            Conncetion();
            SqlCommand command = new SqlCommand("AddEmpDetails", con);
            Model.EmployeeModel emp = new Model.EmployeeModel();
            emp.EmpName = EmpName;
            emp.EmpPassword = EmpPassword;
            emp.EmpGender = EmpGender;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@EmpName", emp.EmpName);
            command.Parameters.AddWithValue("@EmpPassword", emp.EmpPassword);
            command.Parameters.AddWithValue("@EmpGender", emp.EmpGender);
            con.Open();
            int i = command.ExecuteNonQuery();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(EmployeeModel employee)
        {
            Conncetion();
            SqlCommand command = new SqlCommand("DeleteById",con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@EmpID", employee.EmpID);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update(EmployeeModel employee)
        {
            Conncetion();
            SqlCommand command = new SqlCommand("UpdateById", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@EmpId", employee.EmpID);
            command.Parameters.AddWithValue("@EmpName", employee.EmpName);
            command.Parameters.AddWithValue("@EmpPassword", employee.EmpPassword);
            command.Parameters.AddWithValue("@EmpGender", employee.EmpGender);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<EmployeeModel> Show()
        {
            Conncetion();
            List<EmployeeModel> list = new List<EmployeeModel>();
            SqlCommand command = new SqlCommand("ShowById", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            con.Close();

            list = (from DataRow dr in dt.Rows

                       select new EmployeeModel()
                       {
                           EmpID = Convert.ToInt32(dr["EmpID"]),
                           EmpName = Convert.ToString(dr["EmpName"]),
                           EmpPassword = Convert.ToString(dr["EmpPassword"]),
                           EmpGender = Convert.ToString(dr["EmpGender"])
                       }).ToList();
            return list;

        }
        public bool Login(EmployeeModel employee)
        {
            Conncetion();
            SqlCommand command = new SqlCommand("LoginUser",con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@EmpName",employee.EmpName);
            command.Parameters.AddWithValue("@EmpPassword", employee.EmpPassword);
            con.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataSet);
            con.Close();
            bool loginSuccessful = ((dataSet.Tables.Count > 0) && (dataSet.Tables[0].Rows.Count > 0));
            if (loginSuccessful && employee.EmpName != "" && employee.EmpPassword != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
