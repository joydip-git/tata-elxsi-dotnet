using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeeApp.UserInterface.Models
{
    public class EmployeeDao
    {
        public List<Employee> GetEmployees()
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            List<Employee> employees = null;
            try
            {
                connection = new SqlConnection("server=.;database=tataelxsidb;user id=sa;password=sqlserver2017");
                //command = new SqlCommand("select employeeid as ID, employeename as NAME, employeesalary as SALARY, location as LOCATION from employees", connection);
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "FetchEmployees";
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    employees = new List<Employee>();
                    while (reader.Read())
                    {
                        employees.Add(
                            new Employee
                            {
                                EmployeeId = (int)reader["ID"],
                                EmployeeName = (string)reader["NAME"],
                                EmployeeSalary = (decimal)reader["SALARY"],
                                Location = (string)reader["LOCATION"]
                            }
                            );

                    }
                    reader.Close();
                }
                return employees;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
