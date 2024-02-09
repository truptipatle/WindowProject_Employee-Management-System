using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using System.Data.SqlClient;

namespace WindowProject_Employee_Management_System
{
    class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string conStr;

        public Functions()
        {
            conStr = "Data Source=DESKTOP-UDIOKIM;Initial Catalog=EmployeeDB;Integrated Security=True";
            con = new SqlConnection(conStr);
            cmd = new SqlCommand();
            cmd.Connection = con;

        }

        public DataTable GetData(string query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(query, conStr);
            sda.Fill(dt);
            return dt;

        }
        public int SetData(string query)
        {
            int cnt = 0;
            if (con.State == ConnectionState.Closed)

            {
                con.Open();

            }
            cmd.CommandText = query;
            cnt = cmd.ExecuteNonQuery();
            return cnt;

        }

    }
}
