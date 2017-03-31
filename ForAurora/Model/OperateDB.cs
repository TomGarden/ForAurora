using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/// <summary>
/// 操作Database的专用类
/// </summary>
namespace ForAurora.Model
{
    class OperateDB
    {
        public void connectDB()
        {

            //string str = @"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=for_aurora";//设置Connection属性,使用MySql DSN
            string str = @"server=localhost;user id=root;password=root;database=for_aurora";//设置Connection属性,使用MySql DSN
            MySqlConnection con = new MySqlConnection(str);
            con.Open();//打开连接
                       //执行sql
            string d = DateTime.Now.ToString();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into test_tbl  values (@id) ";
            cmd.Parameters.AddWithValue("@id", "visual Studio--" + d);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }


}
