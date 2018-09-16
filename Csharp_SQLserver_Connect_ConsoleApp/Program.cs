using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_SQLserver_Connect_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connetionString = null;
            SqlConnection cnn;
         
            //conn string with Widows Authentication
           //connetionString = "Data Source=DESKTOP-SHJRQ9O\\SQLEXPRESS;Initial Catalog=DbEmployee; Integrated Security=SSPI;";
         
            //Connection with sql server user admin and admin after user creation
            connetionString = "Data Source=DESKTOP-SHJRQ9O\\SQLEXPRESS;Initial Catalog=DbEmployee; User ID=sa;Password=sa";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connected to local db");
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    
    }
}
