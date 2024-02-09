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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UDIOKIM;Initial Catalog=EmployeeDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();


        int StartPosition = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {

            StartPosition += 1;
            MyProgressBar.Value = StartPosition;
            lbl.Text = StartPosition + "%";

            if (MyProgressBar.Value == 100)
            {
                MyProgressBar.Value = 0;
                timer1.Stop();

                //    if (MyProgressBar.Value < MyProgressBar.Maximum)
                //{
                //    lbl.Text = MyProgressBar.Value.ToString();
                //    MyProgressBar.Value++;

                //}
                //else
                //{
                //    lbl.Text = MyProgressBar.Value.ToString();
                //    timer1.Enabled = false;
                //}

                Login l = new Login();
                l.Show();
                this.Hide();

            }
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void MyProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
    }

