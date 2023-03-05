using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiniProject
{
    class Program
    {
        public static SqlConnection con;

        public static SqlCommand cmd;

        public static SqlDataReader dr;

        static void Main(string[] args)

        {
            Console.WriteLine("---------------Employee Details----------");
            Console.WriteLine("\nType Role: Admin = 1 ,User = 2 ");
            int choose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose Operation");
            if (choose == 1)
                Console.WriteLine("Admin \n  1:Display\n 2:Insert \n 3:Update \n  4:Delete");
            else
                Console.WriteLine("User \n 1:Display \n 2:Update Profiles ");
            int operation = Convert.ToInt32(Console.ReadLine());


            switch (choose)

            {

                case 1:

                    switch (operation)

                    {

                        case 1:
                            SelectData();


                            break;

                        case 2:

                            InsertData();

                            break;


                        case 3:

                            UpdateData();

                            break;

                        case 4:
                            DeleteData();

                            break;

                    }

                    break;



                case 2:

                    switch (operation)

                    {

                        case 1:

                            SelectData();
                            break;

                        case 2:

                            UpdateData();

                            break;

                    }

                    break;



                default:

                    Console.WriteLine("Invalid ");

                    break;
            }

            Console.ReadLine();

        }
        public static SqlConnection getConnection()

        {

            con = new SqlConnection("data source=LAPTOP-LAPTOP-5UTI6Q8I; Initial Catalog =master;" + "integrated security = true");

            con.Open();

            return con;

        }
        public static void SelectData()

        {

            try

            {

                con = getConnection(); // gets the connection details after executing the getConnection method

                cmd = new SqlCommand("select * from Employee", con);

                dr = cmd.ExecuteReader();

                while (dr.Read())

                {

                    //Console.WriteLine(dr[0] + " |" + dr[1] + "| " + dr[2]);

                    Console.WriteLine("--------------------");

                    Console.WriteLine("Employee Id : {0}", dr[0]);

                    Console.WriteLine("Employee Name : {0}", dr[1]);

                    Console.WriteLine("Employee Gender : {0}", dr[2]);

                    Console.WriteLine("Employee Salary : {0}", dr[3]);

                    Console.WriteLine("Employee Department Name : {0}", dr[4]);


                }

            }

            catch (SqlException se)

            {

                Console.WriteLine("Some Error Occured.. Try after sometime");

                Console.WriteLine(se.Message);

            }

        }
        public static void InsertData()

        {

            con = getConnection();


            Console.WriteLine("Enter Employee id:");
            int emp_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            string ename = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender:");
            string egen = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            float esalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee DEpartment Name:");
            string edname =Console.ReadLine();
            
            cmd = new SqlCommand("insert into emp3 values(@Employee_ID,@Emloyee_Name,@Gender,@Salry, @Department)", con);
            cmd.Parameters.AddWithValue("@Emloyee_ID", emp_id);
            cmd.Parameters.AddWithValue("@Employee_Name", ename);
            cmd.Parameters.AddWithValue("@Gender", egen);
            cmd.Parameters.AddWithValue("@Salary", esalary);
            cmd.Parameters.AddWithValue("@Department", edname);
           
            int res = cmd.ExecuteNonQuery();

            if (res > 0)

            {

                Console.WriteLine("Record Inserted Successfully.");

            }

            else

                Console.WriteLine("Not Inserted..");

        }




        public static void DeleteData()

        {

            con = getConnection();

            Console.WriteLine("Enter Employee id :");

            int eid = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd1 = new SqlCommand("Select * from Employee where Employee_ID=@ecode");

            cmd1.Parameters.AddWithValue("@ecode", eid);

            cmd1.Connection = con; SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())

            {

                for (int i = 0; i < dr1.FieldCount; i++)

                {

                    Console.WriteLine(dr1[i]);

                }

            }

            con.Close();

            Console.WriteLine("Are you sure to delete this employee ? Y/N");

            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")

            {

                cmd = new SqlCommand("delete from Employee where Employee_ID=@ecode", con);

                cmd.Parameters.AddWithValue("@ecode", eid);

                con.Open(); int rw = cmd.ExecuteNonQuery();

                if (rw > 0)

                    Console.WriteLine("Record Deleted..");

                else

                    Console.WriteLine("Not deleted");

            }
        }

        public static void UpdateData()

        {

            con = getConnection();

            Console.WriteLine("Enter Employee id :");
            int emp_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            string ename = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender:");
            int egen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee new salary :");
            int esalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee new Department:");
            int edname= Convert.ToInt32(Console.ReadLine());

            Console.Write("\n___________orignal data____________\n");

            SqlCommand cmd1 = new SqlCommand("Select * from Employee where Employee_ID=@ecode");

            cmd1.Parameters.AddWithValue("@ecode", emp_id);

            cmd1.Connection = con; SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())

            {

                for (int i = 0; i < dr1.FieldCount; i++)

                {

                    Console.WriteLine(dr1[i]);

                }

            }

            con.Close();

            Console.WriteLine("Are you sure to update this employees data ? Y/N");

            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")

            {

                cmd = new SqlCommand("update Employee set  Gender= @egen, Salary=@esalary, Department = @edname where Employee_ID=@ecode", con);

                cmd.Parameters.AddWithValue("@ecode", emp_id);

                cmd.Parameters.AddWithValue("@Employee_Name", ename);
                cmd.Parameters.AddWithValue("@Gender", egen);
                cmd.Parameters.AddWithValue("@Salary", esalary);
                cmd.Parameters.AddWithValue("@Department", edname);

                con.Open();
                int rw = cmd.ExecuteNonQuery();

                if (rw > 0)

                    Console.WriteLine("Record updated..");

                else

                    Console.WriteLine("Not updated");

            }
        }

    }
}
