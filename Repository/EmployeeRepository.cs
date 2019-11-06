// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
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
    /// <summary>
    /// Creating a class EmployeeRepository which will inherit the interface of the 
    /// another interface class i.e., IRepository
    /// </summary>
    /// <seealso cref="EmployeeManagementMain.Repository.IRepository" />
    public class EmployeeRepository: IRepository
    {
        //Making IConfiguration as private, just to get restriction from the outer world.
        //as IConfiguration contains the actual logic of retrieve, store and access the configration at the time.
        private readonly IConfiguration configration;
        //Making SqlConnection equals null so that it does'nt coantains any Garbage value.
        private SqlConnection con = null;
        string constr = "Server=(localdb)\\MSSQLLocaldb;Database=EmployeeDatabase;Integrated Security=True;";
        //Creating a Parametrized Constructor and passing the Iconfigrtration that is declared private above already.
        public EmployeeRepository(IConfiguration config)
        {
            configration = config;
        }
        public void Conncetion()
        {
            //constr = configration.GetSection("Data").GetSection("ConnectionString").Value;
            con = new SqlConnection(constr);
        }
        /// <summary>
        /// Create method will create the new user and store it in the database,
        /// Taking name,password,gender as the parameter from the user.
        /// </summary>
        /// <param name="EmpName">Name of the emp.</param>
        /// <param name="EmpPassword">The emp password.</param>
        /// <param name="EmpGender">The emp gender.</param>
        /// <returns>Boolean</returns>
        public bool Create(string EmpName, string EmpPassword, string EmpGender)
        {
            //Generating a Connection here.
            Conncetion();
            //Creating a new object of the SqlCommand that will take up the two parameter 
            // "cmdText" and "SqlConncetion Connection".
            SqlCommand command = new SqlCommand("AddEmpDetails", con);
            //Creating a new object of an EmployeeModel class and assigning it values.
            Model.EmployeeModel emp = new Model.EmployeeModel();
            emp.EmpName = EmpName;
            emp.EmpPassword = EmpPassword;
            emp.EmpGender = EmpGender;
            //setting command property to Stored Procedure,
            //This command executes this stored Procedure when ou call one of the Execute method.
            command.CommandType = CommandType.StoredProcedure;
            //Using AddWithValue to add a Parameter by specifying it's name and value.
            command.Parameters.AddWithValue("@EmpName", emp.EmpName);
            command.Parameters.AddWithValue("@EmpPassword", emp.EmpPassword);
            command.Parameters.AddWithValue("@EmpGender", emp.EmpGender);
            //Opens a Database Conncection.
            con.Open();
            // Using ExecuteNonQuery it will return 1 for Insert,Delete and Update else it will return -1. 
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
        /// <summary>
        /// Deletes the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>Boolean</returns>
        public bool Delete(EmployeeModel employee)
        {
            //Calling Connection
            Conncetion();
            //Creating a new object of the SqlCommand that will take up the two parameter 
            // "cmdText" and "SqlConncetion Connection".
            SqlCommand command = new SqlCommand("DeleteById",con);
            //setting command property to Stored Procedure,
            //This command executes this stored Procedure when ou call one of the Execute method.
            command.CommandType = CommandType.StoredProcedure;
            //Using AddWithValue to add a Parameter by specifying it's name and value.
            command.Parameters.AddWithValue("@EmpID", employee.EmpID);
            //Making Connection Open
            con.Open();
            // Using ExecuteNonQuery it will return 1 for Insert,Delete and Update else it will return -1.
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
        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public bool Update(EmployeeModel employee)
        {
            Conncetion();
            //Creating a new object of the SqlCommand that will take up the two parameter 
            // "cmdText" and "SqlConncetion Connection".
            SqlCommand command = new SqlCommand("UpdateById", con);
            //setting command property to Stored Procedure,
            //This command executes this stored Procedure when ou call one of the Execute method.
            command.CommandType = CommandType.StoredProcedure;
            //Using AddWithValue to add Parameters by specifying it's name and value.
            command.Parameters.AddWithValue("@EmpId", employee.EmpID);
            command.Parameters.AddWithValue("@EmpName", employee.EmpName);
            command.Parameters.AddWithValue("@EmpPassword", employee.EmpPassword);
            command.Parameters.AddWithValue("@EmpGender", employee.EmpGender);
            con.Open();
            // Using ExecuteNonQuery it will return 1 for Insert,Delete and Update else it will return -1.
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
        /// <summary>
        /// Shows this instance.
        /// </summary>
        /// <returns>List</returns>
        public List<EmployeeModel> Show()
        {
            Conncetion();
            List<EmployeeModel> list = new List<EmployeeModel>();
            //Creating a new object of the SqlCommand that will take up the two parameter 
            // "cmdText" and "SqlConncetion Connection".
            SqlCommand command = new SqlCommand("ShowById", con);
            //setting command property to Stored Procedure,
            //This command executes this stored Procedure when ou call one of the Execute method.
            command.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter class are used to fill the DataSet and update a SQL Server database. This class cannot be inherited.
            //Creating an Object of the SqlDataAdapter as Similar as creating an Object fpr tha DataTable further.
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            con.Close();
            //Filling the Data into the object of the SqlDataAdapter,ie., Upadting the data into the database.
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
        /// <summary>
        /// Logins the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>Boolean</returns>
        public bool Login(EmployeeModel employee)
        {
            Conncetion();
            //Creating a new object of the SqlCommand that will take up the two parameter 
            // "cmdText" and "SqlConncetion Connection".
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
