﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using BLL;
using DAL;
using System.Xml.Linq;

namespace PersonelTracking
{
    public partial class FrmSalaryList : Form
    {
        public FrmSalaryList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmSalary frm = new FrmSalary();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            FillAllData();
            CleanFilters();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmSalary frm = new FrmSalary();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        SalaryDTO dto = new SalaryDTO();
        bool combofull = false;

        void FillAllData()
        {
            dto = SalaryBLL.GetAll();
            dataGridView1.DataSource = dto.Salaries;
            combofull = false;
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            if (dto.Departments.Count > 0)
                combofull = true;
            cmbMonth.DataSource = dto.Months;
            cmbMonth.DisplayMember = "MonthName";
            cmbMonth.ValueMember = "ID";
            cmbMonth.SelectedIndex = -1;
        }

        private void FrmSalaryList_Load(object sender, EventArgs e)
        {
            FillAllData();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "First Name";
            dataGridView1.Columns[3].HeaderText = "Last Name";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Month";
            dataGridView1.Columns[9].HeaderText = "Year";
            dataGridView1.Columns[11].HeaderText = "Salary";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
       

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
                cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<SalaryDetailDTO> list = dto.Salaries;
            if (!string.IsNullOrEmpty(txtUserNo.Text.Trim()))
                list = list.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text)).ToList();
            if (!string.IsNullOrEmpty(txtFName.Text.Trim()))
                list = list.Where(x => x.FirstName.Contains(txtFName.Text)).ToList();
            if (!string.IsNullOrEmpty(txtLName.Text.Trim()))
                list = list.Where(x => x.LastName.Contains(txtLName.Text)).ToList();
            if (cmbDepartment.SelectedIndex != -1)
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
            if (cmbPosition.SelectedIndex != -1)
                list = list.Where(x => x.PositionId == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();
            if (!string.IsNullOrEmpty(txtYear.Text.Trim()))
                list = list.Where(x => x.SalaryYear == Convert.ToInt32(txtSalary.Text)).ToList();
            if (cmbMonth.SelectedIndex != -1)
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonth.SelectedValue)).ToList();
            if (txtSalary.Text.Trim() != "")
                if (radioButtonMore.Checked)
                    list = list.Where(x => x.SalaryAmount > Convert.ToInt32(txtSalary.Text)).ToList();
                else if (radioButtonLess.Checked)
                    list = list.Where(x => x.SalaryAmount < Convert.ToInt32(txtSalary.Text)).ToList();
                else
                    list = list.Where(x => x.SalaryAmount == Convert.ToInt32(txtSalary.Text)).ToList();


            dataGridView1.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanFilters();
        }



        private void CleanFilters()
        {
            txtUserNo.Clear();
            txtFName.Clear();
            txtLName.Clear();
            combofull = false;
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            cmbMonth.SelectedIndex = -1;
            radioButtonMore.Checked = false;
            radioButtonLess.Checked = false;
            radioButtonEquals.Checked = false;
            txtYear.Clear();
            txtSalary.Clear();
            dataGridView1.DataSource = dto.Salaries;
        }
    }
}
