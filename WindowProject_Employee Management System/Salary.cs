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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2713M6I\\MSSQLSERVER04;Initial Catalog=EmployeeProjectWindow;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();


        SqlDataAdapter sda;
        SqlDataReader sdr;


        private void btn_Add_Salary_Click(object sender, EventArgs e)
        {
            SqlParameter p1 = new SqlParameter("@EmployeeS", SqlDbType.VarChar);
            p1.Value = cmb_S_E.SelectedItem.ToString();

            SqlParameter p2 = new SqlParameter("@AttendanceS", SqlDbType.VarChar);
            p2.Value = textBox_D_attend.Text.ToUpper().Trim();

            SqlParameter p3 = new SqlParameter("@PeriodS", SqlDbType.VarChar);
            p3.Value = dtp_Period.Value.ToShortDateString();


            SqlParameter p4 = new SqlParameter("@AmountS", SqlDbType.VarChar);
            p4.Value = textBox_Salary.Text.Trim();

            SqlParameter p5 = new SqlParameter("@PayDateS", SqlDbType.VarChar);
            p5.Value = dtp_Period.Value.ToShortDateString();


            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);


            cmd.Connection = con;

            cmd.CommandText = "Insert into SalaryTbl(Employee,Attendance,Period,Amount,PayDate) values (@EmployeeS,@AttendanceS,@PeriodS,@AmountS,@PayDateS)";

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Add Data Successfully...");
            textBox_D_attend.Clear();



            SalaryLoadData();
            loadCategory();


        }

        private void btn_UPdate_Salary_Click(object sender, EventArgs e)
        {
            SqlParameter p1 = new SqlParameter("@EmployeeS", SqlDbType.VarChar);
            p1.Value = cmb_S_E.SelectedItem.ToString();

            SqlParameter p2 = new SqlParameter("@AttendanceS", SqlDbType.VarChar);
            p2.Value = textBox_D_attend.Text.ToUpper().Trim();

            SqlParameter p3 = new SqlParameter("@PeriodS", SqlDbType.VarChar);
            p3.Value = dtp_Period.Value.ToShortDateString();


            SqlParameter p4 = new SqlParameter("@AmountS", SqlDbType.VarChar);
            p4.Value = textBox_Salary.Text.Trim();

            SqlParameter p5 = new SqlParameter("@PayDateS", SqlDbType.VarChar);
            p5.Value = dtp_Period.Value.ToShortDateString();

            cmd.Parameters.Clear();

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);


            cmd.Connection = con;

            cmd.CommandText = "Update SalaryTbl set Employee=@EmployeeS,Attendance=@AttendanceS,Period=@PeriodS,Amount=@AmountS,PayDate=@PayDateS where Scode=" + Scode;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Update Data Successfully...");
            cmb_S_E.Items.Clear();
            textBox_D_attend.Clear();



            SalaryLoadData();
            loadCategory();

        }

        int Scode;
        private void btn_Del_Salary_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Delete from SalaryTbl where Scode=" + Scode;
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Delete Data Successfully....");


            SalaryLoadData();
            loadCategory();

        }



        private void Salary_Load(object sender, EventArgs e)
        {
            SalaryLoadData();

            loadCategory();

           

        }


       

       
        //show data in employee table from slaray table like..... employee name();
        public void loadCategory()
        {
            cmd.CommandText = "select * from EmployeeTbl";
            cmd.Connection = con;
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cmb_S_E.Items.Add(sdr[1].ToString());
            }
            con.Close();
        }

        private void SalaryLoadData()
        {
            sda = new SqlDataAdapter("Select * from SalaryTbl", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dgv_Salary.DataSource = ds.Tables[0];

        }

        private void LoginLbl_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        //private void cmb_S_E_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cmd.CommandText = "selcet * from EmployeeTb where EmpName=" + cmb_S_E.SelectedItem;
        //    cmd.Connection = con;
        //    con.Open();
        //    sdr = cmd.ExecuteReader();
        //    while (sdr.Read())
        //    {
        //        textBox_Salary.Text = sdr[4].ToString();
        //    }
        //    con.Close();

        //}

        private void SalaryLbl_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            s.Show();
            this.Hide();
        }

        private void Dept_S_lbl_Click(object sender, EventArgs e)
        {
            Department d = new Department();
            d.Show();
            this.Hide();
        }

        private void Emp_S_lbl_Click(object sender, EventArgs e)
        {
            Employees1 e1 = new Employees1();
            e1.Show();
            this.Hide();
        }
        public int EmpId { get; set; }



       

        private void textBox_Salary_TextChanged(object sender, EventArgs e)
        {
            // int a = (Convert.ToInt64(textBox_D_attend.Text)) * Convert.ToInt64(textBox_Salary.Text).ToString();
            //string a = (textBox_D_attend.Text);
            //string b = (cmb_S_E.Text);
           //. string c = (a * b);
           // textBox_Salary.Text = c.ToString();
        }
       
        int day=950;

        private void textBox_D_attend_TextChanged(object sender, EventArgs e)
        {
            // int b = Convert.ToInt32(textBox_D_attend.Text.ToString());
            int b;

            if (int.TryParse(textBox_D_attend.Text, out b))
            {
                textBox_Salary.Text = (b * day).ToString();
            }
            // a = Convert.ToInt32(textBox_Salary.Text);
            //c = a / 365;
            //textBox_Salary.Text = (b * day).ToString();
            else
            {

            }
        }

        private void dgv_Salary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Scode = Convert.ToInt32(dgv_Salary.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmb_S_E.Text = dgv_Salary.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_D_attend.Text = dgv_Salary.Rows[e.RowIndex].Cells[2].Value.ToString();
          //  dtp_Pay_Date.Text = dgv_Salary.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtp_Period.Text = dgv_Salary.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox_Salary.Text = dgv_Salary.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtp_Pay_Date.Text = dgv_Salary.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        public int days, dsal;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_S_E_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEmpName = cmb_S_E.SelectedItem.ToString();
            

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2713M6I\\MSSQLSERVER04;Initial Catalog=EmployeeProjectWindow;Integrated Security=True"))
            {
                string query = "SELECT * FROM EmployeeTbl WHERE EmpName = @EmpName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmpName", selectedEmpName);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox_Salary.Text = reader["EmpSal"].ToString();
                        }
                        //else if (Convert.ToInt32(textBox_D_attend) > 31)
                        //{
                        //    MessageBox.Show("Days can not be greater than 31");
                        //}
                        //   else
                        //    {
                        //        days = Convert.ToInt32(textBox_D_attend.Text);
                        //        dsal = Convert.ToInt32(textBox_Salary.Text);
                        //    textBox_Salary.Text = (days * dsal).ToString();

                        //        //textBox_Salary.Text = "total salary: $" + totalSalary.ToString("totalSalary");

                        //    }
                            //if (int.TryParse(textBox_D_attend.Text, out int days) &&
                            //    int.TryParse(textBox_Salary.Text, out int dsal))
                            //{
                            //    double totalSalary = days * dsal;
                            //    textBox_Salary.Text = totalSalary.ToString(""); // Display the total salary as currency
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Please enter valid numerical values for Days Attended and Daily Salary.");
                            //}
                        
                        

                    }

                }

            }
        }
    }
}

        

    
