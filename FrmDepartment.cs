using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonelTracking
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepartment.Text.Trim()))
                MessageBox.Show("Please fill the name field");
            else
            {
                DEPARTMENT department = new DEPARTMENT();
                department.DepartmentName = txtDepartment.Text;
                BLL.DepartmentBLL.AddDepartment(department);
                MessageBox.Show("Depatment was added");
                txtDepartment.Clear();
            }
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
