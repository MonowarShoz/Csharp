using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace LibManagement
{
    class libModel
    {
        public void addBook()
        {
            string bookCode, bookName, author;
            Console.Write("Enter Book Code: ");
            bookCode = Console.ReadLine();
            Console.Write("Enter Book Name: ");
            bookName = Console.ReadLine();
            Console.Write("Enter Author Name: ");
            author = Console.ReadLine();
            Console.Write("Enter Initial Stock: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            string connectionStr = "Server=SHOZ-PC;Database=DbBookPrac;Integrated Security=True";
            string sql = "INSERT INTO LibManagement (BookCode,BookName,BookWriter,Stock) VALUES ('" + bookCode + "', '"+bookName+"','"+author+"',"+stock+")";
            using (var con = new SqlConnection(connectionStr))
            {
                con.Open();
                using (var command = new SqlCommand(sql, con))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Borrow()
        {
            
            Console.Write("Enter Book Code: ");
            string borrowCode = Console.ReadLine();
            Console.Write("Enter Book Stock: ");
            int borrowStock = Convert.ToInt32(Console.ReadLine());
            string connectionStr = "Server=SHOZ-PC;Database=DbBookPrac;Integrated Security=True";
            string sql = "UPDATE LibManagement SET Stock= Stock-"+borrowStock+" WHERE BookCode='" +borrowCode+"'";
            
    
            using (var con = new SqlConnection(connectionStr))
            {
                con.Open();
                using(var command = new SqlCommand(sql, con))
                {
                    command.ExecuteNonQuery();
                    
                }
            }

        }
        public void ReturnBook()
        {
            Console.Write("Enter Book Code: ");
            string BookCode = Console.ReadLine();
            Console.Write("Enter Book Stock: ");
            int RetStock = Convert.ToInt32(Console.ReadLine());
            string connectionStr = "Server=SHOZ-PC;Database=DbBookPrac;Integrated Security=True";
            string sql = "UPDATE LibManagement SET Stock= Stock+" + RetStock + " WHERE BookCode='" + BookCode + "'";


            using (var con = new SqlConnection(connectionStr))
            {
                con.Open();
                using (var command = new SqlCommand(sql, con))
                {
                    command.ExecuteNonQuery();

                }
            }
        }
        public void Display()
        {
            string connectionStr = "Server=SHOZ-PC;Database=DbBookPrac;Integrated Security=True";
            string sql = "SELECT * FROM LibManagement";
            
            using (var con = new SqlConnection(connectionStr))
            {
                using (var command = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bcode = reader["BookCode"].ToString();
                            string bname = reader["BookName"].ToString();
                            string Wname = reader["BookWriter"].ToString();
                            int stock = Convert.ToInt32(reader["Stock"].ToString());
                            Console.WriteLine("Book Code: " + bcode);
                            Console.WriteLine("\t BOOk name: " + bname);
                            Console.WriteLine("\t Book writer:" + Wname);
                            Console.WriteLine("\t stock :" + stock);

                            
                        }
                    }
                }
            }
            


        }

    }
}

