using MySql.Data.MySqlClient;
using System;
//using System.Data.SqlClient;
using System.Dynamic;


namespace ConsoleApp_Sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetSqlConnection();
            //GetMySQlConnection();
            //GetAllSqlProducts();
            GetAllMysqlProduct();
        }
      


        static void GetAllMysqlProduct()
        {
            using (var connection = GetMySqlConnection()) {
                try
                {
                    connection.Open();
                    string sql = "Select * from Products";
                    MySqlCommand command=new MySqlCommand(sql,connection);

                    MySqlDataReader reader= command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"\nname:{reader[1]}\n \nPrice{reader[2]}\n");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally { 

                    connection.Close();
                }
            }
        }
        static MySqlConnection GetMySqlConnection()
        {
            string ConnectionString = @"server=localhost;port=3306;database=shopapp;user=root;password=vahid123;";
            return new MySqlConnection(ConnectionString);
        }




        #region MSSQL Connection
        //static void GetAllSqlProducts()
        //{
        //    using (var connection = GetSqlConnection())
        //    {
        //        try
        //        {
        //            connection.Open();
        //            string sql = "select * from products";
        //            SqlCommand sqlCommand = new SqlCommand(sql, connection);
        //            SqlDataReader reader = sqlCommand.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                //Console.WriteLine(reader.GetString(1));
        //                Console.WriteLine($"\n name:{reader[1]}\n \n products:{reader[2]}");
        //            }
        //            reader.Close();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        finally { connection.Close(); }
        //    }

        //}
        //static SqlConnection GetSqlConnection()
        //{
        //    string ConnectionString = @"Data Source=LAPTOP-EE9JAA4Q\SQLEXPRESS;Initial Catalog=SqlConnection;Integrated Security=SSPI;";

        //    //Driver

        //   return new SqlConnection(ConnectionString);
        //}



        //        static void GetAllMySqlProducts()
        //        {
        //            using (var connection = GetMySQlConnection())
        //            {
        //                try
        //                {
        //                    connection.Open();
        //                    string sql = "select * from products";
        //                    MySqlCommand command=new MySqlCommand(sql,connection);
        //                     MySqlDataReader reader= command.ExecuteReader();
        //                    while (reader.Read())
        //                    {
        //                        //bu 1ci yol

        //                        //Console.WriteLine(reader.GetString(2));


        //                        Console.WriteLine($"name:{reader[1]}\n Products{reader[2]}");

        //                    }
        //                    reader.Close();
        //                }
        //                catch (Exception e)
        //                {
        //                    Console.WriteLine(e.Message);
        //                }
        //                finally { connection.Close(); }
        //            }
        //        }
        //        static MySqlConnection GetMySQlConnection()
        //        {
        //            string ConnectionString = @"server=localhost;port=3306;database=shopapp;user=root;password=vahid123;";

        //return new MySqlConnection(ConnectionString);



        //        }
        #endregion


    }
}



