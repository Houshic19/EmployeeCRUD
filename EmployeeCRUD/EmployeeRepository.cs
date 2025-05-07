using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient;

namespace EmployeeCRUD
{
    public class EmployeeRepository
    {
        private readonly string _connectionString = "server=localhost;user=root;password=Baddie@19;database=EmployeeDB;";

        public void AddEmployee(Employee emp) 
        {
            var query = $"INSERT INTO Employees (Name,Age,RollNumber,Salary) VALUES ('{emp.Name}', {emp.Age}, {emp.RollNumber}, {emp.Salary})";

            using (var conn = new MySqlConnection (_connectionString)) 
            {
                conn.Open();
                var cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Employee added successfully");
        }

        public void ViewAllEmployees() 
        {
            using (var conn = new MySqlConnection (_connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM Employees";
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Roll: {reader["RollNumber"]} | Name: {reader["Name"]} | Age: {reader["Age"]} | Marks: {reader["Salary"]}");
                }
            }
        }
        public void DeleteEmployee(int rollNumber)
        {
            using (var conn = new MySqlConnection (_connectionString))
            {
                conn.Open();
                var query = $"DELETE FROM Employees WHERE RollNumber ={rollNumber}";
                var cmd = new MySqlCommand(query, conn);
                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine(rowsAffected > 0 ? "Employee Deleted." : "No Employee Found.");
            }
        }
        public void UpdateEmployee(Employee emp)
        {
            using (var conn = new MySqlConnection (_connectionString))
            {
                conn.Open();
                var query = $"UPDATE Employees SET Name = '{emp.Name}', Age = {emp.Age}, Salary = {emp.Salary} WHERE RollNumber = {emp.RollNumber}";
                var cmd = new MySqlCommand(query, conn);
                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine(rowsAffected > 0 ? " Employee updated." : " No employee found to update.");
            }
        }
        
        public void Stats() 
        {
            using (var conn = new MySqlConnection (_connectionString)) 
            {
                conn.Open();

                var totalemp = new MySqlCommand("SELECT COUNT(*) FROM Employees", conn);
                var total = Convert.ToInt32(totalemp.ExecuteScalar());

                var avgsalary = new MySqlCommand("SELECT AVG(Salary) FROM Employees", conn);
                var avgResult = avgsalary.ExecuteScalar();
                double avg = avgResult != DBNull.Value ? Convert.ToDouble(avgResult) : 0;

                var topper = new MySqlCommand("SELECT Name, Salary FROM Employees ORDER BY Salary DESC LIMIT 1", conn);
                var reader = topper.ExecuteReader();

                string topName = "N/A";
                double topSalary = 0;

                if (reader.Read())
                {
                    topName = reader["Name"].ToString();
                    topSalary = Convert.ToDouble(reader["Salary"]);
                }
                reader.Close();

                Console.WriteLine($"Total Employees: {total}");
                Console.WriteLine($"Average Salary: {avg}");
                Console.WriteLine($"Top Perfomer:{topName}");
            }
        }
        public bool EmployeeExists(int rollNumber) 
        {
            using (var conn = new MySqlConnection (_connectionString))
            {
                conn.Open();
                var query = $"SELECT COUNT(*) FROM Employees WHERE RollNumber = {rollNumber}";
                var cmd = new MySqlCommand(query, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
