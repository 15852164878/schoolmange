using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using CenterControl;

using System.Collections;

using System.Configuration;

using System.Text;
using System.Threading.Tasks;

namespace school.Models
{
    public class Dbs
    {
        string conString = System.Configuration.ConfigurationManager.AppSettings["LGLYBConnectionString"];
        //public static string SqlCon = Convert.ToString(System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnStr"]);
        protected static string SqlCon = @ConfigurationManager.AppSettings["ConnectionString"];


        public List<User> UserList()
        {
            using (SqlConnection conn = new SqlConnection(SqlCon))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"SELECT  [title] FROM [School-zs].[dbo].[Release]";

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                List<User> u1 = new List<User>();

                while (dr.Read())
                {
                    User u0 = new User();
                    u0.titl = dr["title"].ToString();
                    u1.Add(u0);
                }

                return u1;



            }


        }
    }
}
     
