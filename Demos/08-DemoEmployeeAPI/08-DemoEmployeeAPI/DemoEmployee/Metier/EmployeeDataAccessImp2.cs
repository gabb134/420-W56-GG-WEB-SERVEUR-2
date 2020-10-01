using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DemoEmployee.Models;

namespace DemoEmployee.Metier
{
   public class EmployeeDataAccessImp2 : IEmployeeDataAccess
   {
      string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DemoEmployeeDB;Integrated Security=True;";
      public Employee AddEmployee(Employee emp)
      {
         using (SqlConnection con = new SqlConnection(connectionString))
         {
            SqlCommand cmd = new SqlCommand("spAddEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@Gender", emp.Gender);
            cmd.Parameters.AddWithValue("@Department", emp.Department);
            cmd.Parameters.AddWithValue("@City", emp.City);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
         }
         return emp;
      }

      public void DeleteEmployee(int Id)
      {
         using (SqlConnection con = new SqlConnection(connectionString))
         {
            SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
         }
      }

     

      public IEnumerable<Employee> GetAllEmployees()
      {
         List<Employee> lstemployee = new List<Employee>();
         using (SqlConnection con = new SqlConnection(connectionString))
         {
            SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
               Employee employee = new Employee();
               employee.Id = Convert.ToInt32(rdr["EmployeeID"]);
               employee.FirstName = rdr["FirstName"].ToString();
               employee.LastName = rdr["LastName"].ToString();
               employee.Gender = rdr["Gender"].ToString();
               employee.Department = rdr["Department"].ToString();
               employee.City = rdr["City"].ToString();
               lstemployee.Add(employee);
            }
            con.Close();
         }
         return lstemployee;

      }

      public Employee GetEmployeeData(int Id)
      {
         Employee employee = new Employee();
         using (SqlConnection con = new SqlConnection(connectionString))
         {
            string sqlQuery = "SELECT * FROM tbEmployee WHERE EmployeeID= " + Id;
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
               employee.Id = Convert.ToInt32(rdr["EmployeeID"]);
               employee.FirstName = rdr["FirstName"].ToString();
               employee.LastName = rdr["LastName"].ToString();
               employee.Gender = rdr["Gender"].ToString();
               employee.Department = rdr["Department"].ToString();
               employee.City = rdr["City"].ToString();
            }
         }
         return employee;
      }

      public void UpdateEmployee(Employee emp)
      {
         using (SqlConnection con = new SqlConnection(connectionString))
         {
            SqlCommand cmd = new SqlCommand("spUpdateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", emp.Id);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@Gender", emp.Gender);
            cmd.Parameters.AddWithValue("@Department", emp.Department);
            cmd.Parameters.AddWithValue("@City", emp.City);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
         }
      }
   }
}