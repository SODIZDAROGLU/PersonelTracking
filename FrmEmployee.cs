using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;
using DAL;
using DAL.DTO;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PersonelTracking
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

       

        private void txtUserNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        EmployeeDTO dto = new EmployeeDTO();

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
        }

        bool combofull = false;

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == departmentID).ToList();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        string fileName = "";

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtImage.Text = openFileDialog1.FileName;
                string Unique = Guid.NewGuid().ToString();
                fileName += Unique + openFileDialog1.SafeFileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserNo.Text.Trim()))
                MessageBox.Show("UserNo is Empty");
            else if (!EmployeeBLL.IsUnique(Convert.ToInt32(txtUserNo.Text)))
                MessageBox.Show("This User No is used by another employee");
            else if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                MessageBox.Show("Password is Empty");
            else if (string.IsNullOrEmpty(txtFName.Text.Trim()))
                MessageBox.Show("First Name is Empty");
            else if (string.IsNullOrEmpty(txtLName.Text.Trim()))
                MessageBox.Show("Last Name is Empty");
            else if (string.IsNullOrEmpty(txtSalary.Text.Trim()))
                MessageBox.Show("Salary is Empty");
            else if (cmbDepartment.SelectedIndex == -1)
                MessageBox.Show("Select a department");
            else if (cmbPosition.SelectedIndex == -1)
                MessageBox.Show("Select a position");
            else
            {


                EMPLOYEE employee = new EMPLOYEE();
                employee.UserNo = Convert.ToInt32(txtUserNo.Text);
                employee.Password = txtPassword.Text;
                employee.IsAdmin = chkbxIsAdmin.Checked;
                employee.FirstName = txtFName.Text;
                employee.LastName = txtLName.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                employee.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                employee.PositionId = Convert.ToInt32(cmbPosition.SelectedValue);
                employee.Adress = txtAdress.Text;
                employee.BirthDay = dateTimePicker1.Value;
                employee.ImagePath = fileName;
                EmployeeBLL.AddEmployee(employee);
                File.Copy(txtImage.Text, @"images\\" + fileName);
                MessageBox.Show("Employee added");
                txtUserNo.Clear();
                txtPassword.Clear();
                chkbxIsAdmin.Checked = false;
                txtFName.Clear();
                txtLName.Clear();
                txtSalary.Clear();
                txtAdress.Clear();
                txtImage.Clear();
                pictureBox1.Image = null;
                combofull = false;
                cmbDepartment.SelectedIndex = -1;
                cmbPosition.DataSource = dto.Positions;
                cmbPosition.SelectedIndex = -1;
                combofull = true;
                dateTimePicker1.Value = DateTime.Today;
            }



        }
        bool isUnique = false;

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserNo.Text.Trim()))
                MessageBox.Show("UserNo is Empty");
            else
            {
                isUnique = EmployeeBLL.IsUnique(Convert.ToInt32(txtUserNo.Text));
                if (!isUnique)
                    MessageBox.Show("This User is exist..!!!!!!","WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show($"Good news..... User No:{txtUserNo.Text} is available");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
