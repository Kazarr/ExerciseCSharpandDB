using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class EmployeeRepository
    {
        private const string CONNECTION_STRING = @"Server = KARDOS\SQLEXPRESSKARDY; Database=AdventureWorks;Trusted_Connection=True";

        public BindingList<Employee> LoadEmployes()
        {
            BindingList<Employee> ret = new BindingList<Employee>();
            using(SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT * FROM HumanResources.Employee";

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employee employee = new Employee();
                                employee.BusinessEntityID = reader.GetInt32(0);
                                employee.NationallDNumber = reader.GetString(1);
                                employee.LoginId = reader.GetString(2);
                                employee.OrganizationLevel = reader.IsDBNull(4) ? 0 : reader.GetInt16(4);
                                employee.JobTitle = reader.GetString(5);
                                employee.BirthDate = reader.GetDateTime(6);
                                employee.MartialStatus = reader.GetString(7)[0];
                                employee.Gender = reader.GetString(8)[0];
                                employee.HireDate = reader.GetDateTime(9);
                                employee.SalariedFlag = reader.GetBoolean(10);
                                employee.VacationHours = reader.GetInt16(11);
                                employee.SickLeaveHours = reader.GetInt16(12);
                                employee.CurrentFlag = reader.GetBoolean(13);
                                employee.RowGuid = reader.GetGuid(14);
                                employee.ModifiedDate = reader.GetDateTime(15);
                                ret.Add(employee);
                            }
                        }
                    }
                }catch(Exception e)
                {

                }
            }
            return ret;
        }
        public DataSet LoadPersons()
        {
            using(SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT * FROM Person.Person as p
                                                join Person.EmailAddress  as ea on p.BusinessEntityID = ea.BusinessEntityID
                                                join Person.PersonPhone as pp on p.BusinessEntityID = pp.BusinessEntityID";
                        using(SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds, "Person");
                            DataTable dt = ds.Tables["Person"];
                            return ds;
                        }
                    }
                }catch(Exception e)
                {

                }
            }
            return null;
        }
        public DataSet Filtername(string pattern)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT * FROM Person.Person WHERE FirstName LIKE @pattern";
                        command.Parameters.Add("@pattern", SqlDbType.NVarChar).Value = $"%{pattern}%";
                        using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds, "Person");
                            DataTable dt = ds.Tables["Person"];
                            return ds;
                        }
                    }
                }catch(Exception e)
                {

                }
            }
            return null;
        }
    }
}
