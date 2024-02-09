using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;

namespace WindowProject_Employee_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2713M6I\\MSSQLSERVER04;Initial Catalog=EmployeeProjectWindow;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (textBox_Uname.Text == "" || textBox_Password.Text == "")
            {
                MessageBox.Show("Invalid User Name or Password");

            }

            else
            {
                MessageBox.Show("Successfully Login");
                //Do your code here

                textBox_Uname.Clear();
                textBox_Password.Clear();
            }

            Employees1 emp = new Employees1();
            emp.Show();
            this.Hide();



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                textBox_Password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password.UseSystemPasswordChar = true;
            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            textBox_Uname.Text = "";
            textBox_Password.Text = "";

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
