
namespace WindowProject_Employee_Management_System
{
    partial class Employees1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_UPdate_Emp = new System.Windows.Forms.Button();
            this.dtp_E_JDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_E_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_E_Dept = new System.Windows.Forms.ComboBox();
            this.cmb_E_Gender = new System.Windows.Forms.ComboBox();
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.TextBox_E_Name = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_E_Daily_Salary = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Add_Emp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Emp_Lbl = new System.Windows.Forms.Label();
            this.Dept_Lbl = new System.Windows.Forms.Label();
            this.Sal_Lbl = new System.Windows.Forms.Label();
            this.Logout_lbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 689);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1340, 22);
            this.panel3.TabIndex = 23;
            // 
            // btn_UPdate_Emp
            // 
            this.btn_UPdate_Emp.ForeColor = System.Drawing.Color.Teal;
            this.btn_UPdate_Emp.Location = new System.Drawing.Point(849, 549);
            this.btn_UPdate_Emp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UPdate_Emp.Name = "btn_UPdate_Emp";
            this.btn_UPdate_Emp.Size = new System.Drawing.Size(114, 30);
            this.btn_UPdate_Emp.TabIndex = 22;
            this.btn_UPdate_Emp.Text = "Update";
            this.btn_UPdate_Emp.UseVisualStyleBackColor = true;
            this.btn_UPdate_Emp.Click += new System.EventHandler(this.btn_UPdate_Emp_Click);
            // 
            // dtp_E_JDate
            // 
            this.dtp_E_JDate.Location = new System.Drawing.Point(147, 534);
            this.dtp_E_JDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_E_JDate.Name = "dtp_E_JDate";
            this.dtp_E_JDate.Size = new System.Drawing.Size(197, 27);
            this.dtp_E_JDate.TabIndex = 21;
            // 
            // dtp_E_DOB
            // 
            this.dtp_E_DOB.Location = new System.Drawing.Point(147, 386);
            this.dtp_E_DOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_E_DOB.Name = "dtp_E_DOB";
            this.dtp_E_DOB.Size = new System.Drawing.Size(194, 27);
            this.dtp_E_DOB.TabIndex = 20;
            this.dtp_E_DOB.ValueChanged += new System.EventHandler(this.dtp_E_DOB_ValueChanged);
            // 
            // cmb_E_Dept
            // 
            this.cmb_E_Dept.FormattingEnabled = true;
            this.cmb_E_Dept.Location = new System.Drawing.Point(147, 309);
            this.cmb_E_Dept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_E_Dept.Name = "cmb_E_Dept";
            this.cmb_E_Dept.Size = new System.Drawing.Size(195, 28);
            this.cmb_E_Dept.TabIndex = 18;
            // 
            // cmb_E_Gender
            // 
            this.cmb_E_Gender.FormattingEnabled = true;
            this.cmb_E_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_E_Gender.Location = new System.Drawing.Point(147, 235);
            this.cmb_E_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_E_Gender.Name = "cmb_E_Gender";
            this.cmb_E_Gender.Size = new System.Drawing.Size(195, 28);
            this.cmb_E_Gender.TabIndex = 19;
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Location = new System.Drawing.Point(526, 201);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.RowHeadersWidth = 51;
            this.dgv_Employee.RowTemplate.Height = 24;
            this.dgv_Employee.Size = new System.Drawing.Size(762, 304);
            this.dgv_Employee.TabIndex = 17;
            this.dgv_Employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employee_CellContentClick);
            // 
            // TextBox_E_Name
            // 
            this.TextBox_E_Name.Location = new System.Drawing.Point(145, 165);
            this.TextBox_E_Name.Name = "TextBox_E_Name";
            this.TextBox_E_Name.Size = new System.Drawing.Size(194, 27);
            this.TextBox_E_Name.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(143, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Employee Daily Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(141, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Employee Department";
            // 
            // TextBox_E_Daily_Salary
            // 
            this.TextBox_E_Daily_Salary.Location = new System.Drawing.Point(147, 625);
            this.TextBox_E_Daily_Salary.Name = "TextBox_E_Daily_Salary";
            this.TextBox_E_Daily_Salary.Size = new System.Drawing.Size(197, 27);
            this.TextBox_E_Daily_Salary.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(526, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(712, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Manage Employee";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1340, 50);
            this.label7.TabIndex = 1;
            this.label7.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(141, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(143, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Employee Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(143, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(141, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Join Date";
            // 
            // btn_Add_Emp
            // 
            this.btn_Add_Emp.ForeColor = System.Drawing.Color.Teal;
            this.btn_Add_Emp.Location = new System.Drawing.Point(670, 549);
            this.btn_Add_Emp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_Emp.Name = "btn_Add_Emp";
            this.btn_Add_Emp.Size = new System.Drawing.Size(126, 30);
            this.btn_Add_Emp.TabIndex = 22;
            this.btn_Add_Emp.Text = "Add";
            this.btn_Add_Emp.UseVisualStyleBackColor = true;
            this.btn_Add_Emp.Click += new System.EventHandler(this.btn_Add_Emp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Emp_Lbl
            // 
            this.Emp_Lbl.AutoSize = true;
            this.Emp_Lbl.ForeColor = System.Drawing.Color.Teal;
            this.Emp_Lbl.Location = new System.Drawing.Point(589, 78);
            this.Emp_Lbl.Name = "Emp_Lbl";
            this.Emp_Lbl.Size = new System.Drawing.Size(90, 20);
            this.Emp_Lbl.TabIndex = 13;
            this.Emp_Lbl.Text = "Employee";
            this.Emp_Lbl.Click += new System.EventHandler(this.Emp_Lbl_Click);
            // 
            // Dept_Lbl
            // 
            this.Dept_Lbl.AutoSize = true;
            this.Dept_Lbl.ForeColor = System.Drawing.Color.Teal;
            this.Dept_Lbl.Location = new System.Drawing.Point(778, 78);
            this.Dept_Lbl.Name = "Dept_Lbl";
            this.Dept_Lbl.Size = new System.Drawing.Size(107, 20);
            this.Dept_Lbl.TabIndex = 13;
            this.Dept_Lbl.Text = "Department";
            this.Dept_Lbl.Click += new System.EventHandler(this.Dept_Lbl_Click);
            // 
            // Sal_Lbl
            // 
            this.Sal_Lbl.AutoSize = true;
            this.Sal_Lbl.ForeColor = System.Drawing.Color.Teal;
            this.Sal_Lbl.Location = new System.Drawing.Point(984, 78);
            this.Sal_Lbl.Name = "Sal_Lbl";
            this.Sal_Lbl.Size = new System.Drawing.Size(62, 20);
            this.Sal_Lbl.TabIndex = 13;
            this.Sal_Lbl.Text = "Salary";
            this.Sal_Lbl.Click += new System.EventHandler(this.Sal_Lbl_Click);
            // 
            // Logout_lbl
            // 
            this.Logout_lbl.AutoSize = true;
            this.Logout_lbl.ForeColor = System.Drawing.Color.Teal;
            this.Logout_lbl.Location = new System.Drawing.Point(1148, 78);
            this.Logout_lbl.Name = "Logout_lbl";
            this.Logout_lbl.Size = new System.Drawing.Size(66, 20);
            this.Logout_lbl.TabIndex = 13;
            this.Logout_lbl.Text = "Logout";
            this.Logout_lbl.Click += new System.EventHandler(this.Logout_lbl_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(526, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(715, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(921, 67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1085, 67);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(1006, 549);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Del_Emp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(145, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Age";
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(145, 460);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(196, 27);
            this.textBox_Age.TabIndex = 27;
            // 
            // Employees1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 711);
            this.Controls.Add(this.textBox_Age);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_Add_Emp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_UPdate_Emp);
            this.Controls.Add(this.dtp_E_JDate);
            this.Controls.Add(this.dtp_E_DOB);
            this.Controls.Add(this.cmb_E_Dept);
            this.Controls.Add(this.cmb_E_Gender);
            this.Controls.Add(this.dgv_Employee);
            this.Controls.Add(this.TextBox_E_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Logout_lbl);
            this.Controls.Add(this.Sal_Lbl);
            this.Controls.Add(this.Dept_Lbl);
            this.Controls.Add(this.Emp_Lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_E_Daily_Salary);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employees1";
            this.Text = "Employees1";
            this.Load += new System.EventHandler(this.Employees1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_UPdate_Emp;
        private System.Windows.Forms.DateTimePicker dtp_E_JDate;
        private System.Windows.Forms.DateTimePicker dtp_E_DOB;
        private System.Windows.Forms.ComboBox cmb_E_Dept;
        private System.Windows.Forms.ComboBox cmb_E_Gender;
        private System.Windows.Forms.DataGridView dgv_Employee;
        private System.Windows.Forms.MaskedTextBox TextBox_E_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TextBox_E_Daily_Salary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Add_Emp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Emp_Lbl;
        private System.Windows.Forms.Label Dept_Lbl;
        private System.Windows.Forms.Label Sal_Lbl;
        private System.Windows.Forms.Label Logout_lbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Age;
    }
}