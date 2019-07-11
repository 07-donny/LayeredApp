using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Donny
{
    class Northwind
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Northwind.mdf;Integrated Security=True";

        public List<Employee> GetAllEmployees()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Employee> employeeList = new List<Employee>();

                    while (reader.Read())
                    {
                        Employee e = new Employee();
                        e.EmployeeID = (int)reader["EmployeeID"];
                        e.FirstName = (string)reader["FirstName"];
                        e.LastName = (string)reader["LastName"];
                        e.HireDate = (DateTime)reader["HireDate"];

                        employeeList.Add(e);
                    }
                    return employeeList;
                }
            }
            catch (SqlException e)
            {
               
                MessageBox.Show("Error: ", Convert.ToString(e));
                throw;
            }

            
        }

        public List<Order> GetAllOrders(int EmployeeID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Orders.EmployeeID, Orders.OrderID, Orders.OrderDate, Orders.ShipName, Orders.CustomerID, Customers.CompanyName, Customers.ContactName" +
                        "                            FROM Orders INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID" +
                        "                               WHERE EmployeeID = @EmployeeID", con);

                    cmd.Parameters.AddWithValue("EmployeeID", EmployeeID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Order> orderList = new List<Order>();

                    while (reader.Read())
                    {
                        Order o = new Order();
                        o.OrderID = (int)reader["OrderID"];
                        o.OrderDate = (DateTime)reader["OrderDate"];
                        o.ShipName = (string)reader["ShipName"];
                        o.CompanyName = (string)reader["CompanyName"];
                        o.ContactName = (string)reader["ContactName"];

                        orderList.Add(o);
                    }
                    return orderList;
                }
            }
            catch (SqlException e)
            {

                MessageBox.Show("Error: ", Convert.ToString(e));
                throw;
            }

        }
    }
}
