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
    public partial class Employees1 : Form
    {
        public Employees1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2713M6I\\MSSQLSERVER04;Initial Catalog=EmployeeProjectWindow;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        int EmpId { get; set; }

        
        private void btn_Add_Emp_Click(object sender, EventArgs e)
        {
            SqlParameter p1 = new SqlParameter("@Empname", SqlDbType.VarChar);
            p1.Value = TextBox_E_Name.Text.ToUpper().Trim();

            SqlParameter p2 = new SqlParameter("@Empgen", SqlDbType.VarChar);
            p2.Value = cmb_E_Gender.SelectedItem.ToString();

            SqlParameter p3 = new SqlParameter("@Empdept",SqlDbType.VarChar);
            p3.Value = cmb_E_Dept.SelectedItem.ToString();

            SqlParameter p4 = new SqlParameter("@Empdob", SqlDbType.VarChar);
            p4.Value = dtp_E_DOB.Value.ToShortDateString();

            SqlParameter p5 = new SqlParameter("@Eage", SqlDbType.VarChar);
            p5.Value = textBox_Age.Text.ToUpper().Trim();

            SqlParameter p6 = new SqlParameter("@EmpJdate", SqlDbType.VarChar);
            p6.Value = dtp_E_JDate.Value.ToShortDateString();

            SqlParameter p7 = new SqlParameter("@Empsal", SqlDbType.VarChar);
            p7.Value = TextBox_E_Daily_Salary.Text.ToUpper().Trim();

           


            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);

           

            cmd.Connection = con;

            cmd.CommandText = "Insert into EmployeeTbl(EmpName,EmpGen,EmpDept,EmpDOB,EmpAge,EmpJDate,EmpSal) values (@Empname,@Empgen,@Empdept,@Empdob,@Eage,@EmpJdate,@Empsal)";


            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Add Data Successfully....");
            TextBox_E_Name.Clear();
            cmb_E_Gender.Items.Clear();
            
            TextBox_E_Name.Clear();

            EmpLoadData();

        }
        SqlDataAdapter sda;
        SqlDataReader sdr;

        private void Employees1_Load(object sender, EventArgs e)
        {
            EmpLoadData();

            // FillCategory();
            loadCategory();
        }

        //private void FillCategory()
        //{
            
        //        string query = "select * from  DepartmentTb";
        //        SqlCommand cmd = new SqlCommand(query, con);
                
                
                
        //    con.Open();
        //            DataTable dt = new DataTable();
        //            dt.Columns.Add("DeptName", typeof(string));
        //            sdr = cmd.ExecuteReader();
        //            dt.Load(sdr);
        //            cmb_E_Dept.ValueMember = "DeptName";
        //            cmb_E_Dept.DataSource = dt;


        //    con.Close();

                
            
        //}

        //Load data in employee table from department table..like deptName
        public void loadCategory()
        {
            cmd.CommandText = "select * from DepartmentTb";
            cmd.Connection = con;
            con.Open();
            sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                cmb_E_Dept.Items.Add(sdr[1].ToString());
            }
            con.Close();
        }

        private void EmpLoadData()
        {
            sda = new SqlDataAdapter("Select * from EmployeeTbl", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv_Employee.DataSource = ds.Tables[0];

            

        }
        int Empid { get; set; }
        private void btn_UPdate_Emp_Click(object sender, EventArgs e)
        {

            SqlParameter p1 = new SqlParameter("@Empname", SqlDbType.VarChar);
            p1.Value = TextBox_E_Name.Text.ToUpper().Trim();

            SqlParameter p2 = new SqlParameter("@Empgen", SqlDbType.VarChar);
            p2.Value = cmb_E_Gender.SelectedItem.ToString();

            SqlParameter p3 = new SqlParameter("@Empdept", SqlDbType.VarChar);
            p3.Value = cmb_E_Dept.SelectedItem.ToString();

            SqlParameter p4 = new SqlParameter("@Empdob", SqlDbType.VarChar);
            p4.Value = dtp_E_DOB.Value.ToShortDateString();

            SqlParameter p5 = new SqlParameter("@Eage", SqlDbType.VarChar);
            p5.Value = textBox_Age.Text.ToUpper().Trim();

            SqlParameter p6 = new SqlParameter("@EmpJdate", SqlDbType.VarChar);
            p6.Value = dtp_E_JDate.Value.ToShortDateString();

            SqlParameter p7 = new SqlParameter("@Empsal", SqlDbType.VarChar);
            p7.Value = TextBox_E_Daily_Salary.Text.ToUpper().Trim();

            

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);


            cmd.Connection = con;

            cmd.CommandText = "Update EmployeeTbl set EmpName=@Empname,EmpGen=@Empgen,EmpDept=@Empdept,EmpDOB=@Empdob,EmpAge=@Eage,EmpJDate=@EmpJdate,EmpSal=@Empsal where EmpId=" + EmpId;       
           
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show(" Update Data Successfully.....");
            TextBox_E_Name.Clear();
            cmb_E_Gender.Items.Clear();
            cmb_E_Dept.Items.Clear();
            TextBox_E_Name.Clear();

            EmpLoadData();

        }

        private void dgv_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             EmpId = Convert.ToInt32(dgv_Employee.Rows[e.RowIndex].Cells[0].Value);
             TextBox_E_Name.Text =dgv_Employee.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_E_Gender.Text = dgv_Employee.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_E_Dept.Text = dgv_Employee.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtp_E_DOB.Text = dgv_Employee.Rows[e.RowIndex].Cells[4].Value.ToString();
            //dtp_E_JDate.Text = dgv_Employee.Rows[e.RowIndex].Cells[5].Value.ToString();
            TextBox_E_Daily_Salary.Text = dgv_Employee.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox_Age.Text = dgv_Employee.Rows[e.RowIndex].Cells[7].Value.ToString();

            EmpLoadData();

        }

        private void btn_Del_Emp_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Delete from EmployeeTbl where EmpId=" + EmpId;
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Delete Data Successfully....");

            EmpLoadData();

            Department d2 = new Department();
            d2.Show();
            this.Hide();

        }

        private void Emp_Lbl_Click(object sender, EventArgs e)
        {
            Employees1 e1 = new Employees1();
            e1.Show();
           this.Hide();
               
        }

        private void Dept_Lbl_Click(object sender, EventArgs e)
        {
            Department d1 = new Department();
            d1.Show();
            this.Hide();
        }

        private void Sal_Lbl_Click(object sender, EventArgs e)
        {
            Salary s1 = new Salary();
            s1.Show();
            this.Hide();

        }

        private void Logout_lbl_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void dtp_E_DOB_ValueChanged(object sender, EventArgs e)
        {
            DateTime time_Start = Convert.ToDateTime(dtp_E_DOB.Value);
            DateTime time_end = DateTime.Today;
            TimeSpan span = time_end.Subtract(time_Start);
            var daysTotal = span.TotalDays;
            var yearsTotal = Math.Truncate(daysTotal / 365);

            textBox_Age.Text = Convert.ToString(yearsTotal);

            EmpLoadData();
        }

        
            
        private void label10_Click(object sender, EventArgs e)
        {

        }
        
        
    }
}
