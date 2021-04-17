using System;
using Microsoft.Data.SqlClient;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class UserRepository
    {
        //string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
       // SqlConnection connection = new SqlConnection(conStr);

        public static List<User> users = new List<User>();

        static UserRepository()
        {
            users.Add(new User { Id = 1, Name = "Ali", Age = 22});
            users.Add(new User { Id = 2, Name = "Shuja", Age = 23});
            users.Add(new User { Id = 3, Name = "Alishba", Age = 24});
            users.Add(new User { Id = 4, Name = "Ibrahim", Age = 25});
        }
        public static void AddStudent(User s)
        {
            users.Add(s);
        }
    }


}