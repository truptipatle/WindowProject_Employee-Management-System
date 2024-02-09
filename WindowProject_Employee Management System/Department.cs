using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; //step 1

namespace WindowProject_Employee_Management_System
{
    public partial class Department : Form
    {
        
        public Department()
        {
            InitializeComponent();
           
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2713M6I\\MSSQLSERVER04;Initial Catalog=EmployeeProjectWindow;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

       int DeptID { get; set; }



        private void AddBtnD_Click(object sender, EventArgs e)
        {
            

                SqlParameter p1 = new SqlParameter("@Name", SqlDbType.VarChar);
                p1.Value = DepartmentNameTextBox.Text.ToUpper().Trim();

            cmd.Parameters.Clear();
            cmd.Parameters.Add(p1);

           
                cmd.Connection = con;


                cmd.CommandText = "Insert into DepartmentTb(DeptName) values (@Name)";

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
           
            

            MessageBox.Show("Add Data Successfully...");
            

           DeptLoadData();
        }

        SqlDataAdapter sda;
        SqlDataReader sdr;
        
        private void Department_Load(object sender, EventArgs e)
        {
           DeptLoadData();
        }

        private void DeptLoadData()
        {
            sda = new SqlDataAdapter("select * from DepartmentTb", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            Dept_D_G_V.DataSource = ds.Tables[0];


        }

        private void Dept_D_G_V_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DeptID = Convert.ToInt32(Dept_D_G_V.Rows[e.RowIndex].Cells[0].Value);
            DepartmentNameTextBox.Text = Dept_D_G_V.Rows[e.RowIndex].Cells[1].Value.ToString();

            DeptLoadData();
        }
        

        private void UpdateBtnD_Click(object sender, EventArgs e)
        {
            SqlParameter p1 = new SqlParameter("@Deptname", SqlDbType.VarChar);
            p1.Value = DepartmentNameTextBox.Text.ToUpper().Trim();


            cmd.Parameters.Add(p1);


            cmd.Connection = con;

            cmd.CommandText = "UPdate DepartmentTb set DeptName=@Deptname where DeptID=" + DeptID;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Update Data Successfully...");

            DeptLoadData();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "Delete from DepartmentTb where DeptID=" + DeptID;

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Delete Data Successfully...");

            DeptLoadData();

            Salary s1 = new Salary();
            s1.Show();
            this.Hide();
        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employees1 e1 = new Employees1();
            e1.Show();
            this.Hide();


        }

        private void SalaryLbl_Click(object sender, EventArgs e)
        {
            Salary s1 = new Salary();
            s1.Show();
            this.Hide();

        }
    }
}
