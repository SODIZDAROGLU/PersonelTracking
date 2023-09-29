
namespace PersonelTracking
{
    partial class FrmTaskList
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
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.labelTaskState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnDeliveryDate = new System.Windows.Forms.RadioButton();
            this.radiobtnStartDate = new System.Windows.Forms.RadioButton();
            this.dtpFinishDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.labelFinish = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelTaskDate = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelUserNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnApproved = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlAdmin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnClear);
            this.pnlAdmin.Controls.Add(this.btnSearch);
            this.pnlAdmin.Controls.Add(this.cmbTaskState);
            this.pnlAdmin.Controls.Add(this.labelTaskState);
            this.pnlAdmin.Controls.Add(this.groupBox1);
            this.pnlAdmin.Controls.Add(this.dtpFinishDatePicker);
            this.pnlAdmin.Controls.Add(this.dtpStartDatePicker);
            this.pnlAdmin.Controls.Add(this.labelFinish);
            this.pnlAdmin.Controls.Add(this.labelStart);
            this.pnlAdmin.Controls.Add(this.labelTaskDate);
            this.pnlAdmin.Controls.Add(this.panelAdmin);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(800, 155);
            this.pnlAdmin.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(713, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(622, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Location = new System.Drawing.Point(407, 86);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(170, 21);
            this.cmbTaskState.TabIndex = 11;
            // 
            // labelTaskState
            // 
            this.labelTaskState.AutoSize = true;
            this.labelTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskState.Location = new System.Drawing.Point(297, 87);
            this.labelTaskState.Name = "labelTaskState";
            this.labelTaskState.Size = new System.Drawing.Size(96, 20);
            this.labelTaskState.TabIndex = 10;
            this.labelTaskState.Text = "Task State";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnDeliveryDate);
            this.groupBox1.Controls.Add(this.radiobtnStartDate);
            this.groupBox1.Location = new System.Drawing.Point(636, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 72);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // radioBtnDeliveryDate
            // 
            this.radioBtnDeliveryDate.AutoSize = true;
            this.radioBtnDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnDeliveryDate.Location = new System.Drawing.Point(17, 43);
            this.radioBtnDeliveryDate.Name = "radioBtnDeliveryDate";
            this.radioBtnDeliveryDate.Size = new System.Drawing.Size(102, 17);
            this.radioBtnDeliveryDate.TabIndex = 1;
            this.radioBtnDeliveryDate.TabStop = true;
            this.radioBtnDeliveryDate.Text = "Delivery Date";
            this.radioBtnDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // radiobtnStartDate
            // 
            this.radiobtnStartDate.AutoSize = true;
            this.radiobtnStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnStartDate.Location = new System.Drawing.Point(17, 16);
            this.radiobtnStartDate.Name = "radiobtnStartDate";
            this.radiobtnStartDate.Size = new System.Drawing.Size(83, 17);
            this.radiobtnStartDate.TabIndex = 0;
            this.radiobtnStartDate.TabStop = true;
            this.radiobtnStartDate.Text = "Start Date";
            this.radiobtnStartDate.UseVisualStyleBackColor = true;
            // 
            // dtpFinishDatePicker
            // 
            this.dtpFinishDatePicker.Location = new System.Drawing.Point(377, 52);
            this.dtpFinishDatePicker.Name = "dtpFinishDatePicker";
            this.dtpFinishDatePicker.Size = new System.Drawing.Size(200, 20);
            this.dtpFinishDatePicker.TabIndex = 8;
            // 
            // dtpStartDatePicker
            // 
            this.dtpStartDatePicker.Location = new System.Drawing.Point(377, 26);
            this.dtpStartDatePicker.Name = "dtpStartDatePicker";
            this.dtpStartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDatePicker.TabIndex = 7;
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinish.Location = new System.Drawing.Point(301, 53);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(57, 20);
            this.labelFinish.TabIndex = 6;
            this.labelFinish.Text = "Finish";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(301, 26);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(49, 20);
            this.labelStart.TabIndex = 5;
            this.labelStart.Text = "Start";
            // 
            // labelTaskDate
            // 
            this.labelTaskDate.AutoSize = true;
            this.labelTaskDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskDate.Location = new System.Drawing.Point(297, 3);
            this.labelTaskDate.Name = "labelTaskDate";
            this.labelTaskDate.Size = new System.Drawing.Size(91, 20);
            this.labelTaskDate.TabIndex = 4;
            this.labelTaskDate.Text = "Task Date";
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.cmbPosition);
            this.panelAdmin.Controls.Add(this.cmbDepartment);
            this.panelAdmin.Controls.Add(this.label5);
            this.panelAdmin.Controls.Add(this.labelDepartment);
            this.panelAdmin.Controls.Add(this.txtLName);
            this.panelAdmin.Controls.Add(this.txtFName);
            this.panelAdmin.Controls.Add(this.txtUserNo);
            this.panelAdmin.Controls.Add(this.labelLName);
            this.panelAdmin.Controls.Add(this.labelFName);
            this.panelAdmin.Controls.Add(this.labelUserNo);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(290, 155);
            this.panelAdmin.TabIndex = 3;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(111, 119);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(121, 21);
            this.cmbPosition.TabIndex = 23;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(111, 90);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartment.TabIndex = 22;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Position";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.Location = new System.Drawing.Point(1, 91);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(104, 20);
            this.labelDepartment.TabIndex = 20;
            this.labelDepartment.Text = "Department";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(101, 64);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 11;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(101, 35);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 10;
            // 
            // txtUserNo
            // 
            this.txtUserNo.Location = new System.Drawing.Point(101, 3);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(100, 20);
            this.txtUserNo.TabIndex = 9;
            this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNo_KeyPress);
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(1, 64);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(90, 20);
            this.labelLName.TabIndex = 8;
            this.labelLName.Text = "LastName";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(0, 35);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(91, 20);
            this.labelFName.TabIndex = 7;
            this.labelFName.Text = "FirstName";
            // 
            // labelUserNo
            // 
            this.labelUserNo.AutoSize = true;
            this.labelUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNo.Location = new System.Drawing.Point(1, 4);
            this.labelUserNo.Name = "labelUserNo";
            this.labelUserNo.Size = new System.Drawing.Size(69, 20);
            this.labelUserNo.TabIndex = 6;
            this.labelUserNo.Text = "UserNo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnApproved);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnApproved
            // 
            this.btnApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproved.Location = new System.Drawing.Point(141, 33);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(91, 35);
            this.btnApproved.TabIndex = 16;
            this.btnApproved.Text = "Approved";
            this.btnApproved.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(533, 33);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 35);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(437, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(344, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 35);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(251, 33);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(79, 35);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 195);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAdmin);
            this.Name = "FrmTaskList";
            this.Text = "Task List";
            this.Load += new System.EventHandler(this.FrmTaskList_Load);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelUserNo;
        private System.Windows.Forms.ComboBox cmbTaskState;
        private System.Windows.Forms.Label labelTaskState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnDeliveryDate;
        private System.Windows.Forms.RadioButton radiobtnStartDate;
        private System.Windows.Forms.DateTimePicker dtpFinishDatePicker;
        private System.Windows.Forms.DateTimePicker dtpStartDatePicker;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelTaskDate;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
    }
}