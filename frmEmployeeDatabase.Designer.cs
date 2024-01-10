using System.Windows.Forms;

namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeDatabase));
            lblAddEmployee = new Label();
            lblEmployeeID = new Label();
            btnSubmit = new Button();
            txtbEmployeeID = new TextBox();
            dgvEmployeeList = new DataGridView();
            lblEmployeeList = new Label();
            lblLastName = new Label();
            txtbLastName = new TextBox();
            lblFirstName = new Label();
            txtbFirstName = new TextBox();
            lblPosition = new Label();
            txtbPosition = new TextBox();
            lblErrorMessage = new Label();
            btnClear = new Button();
            lblDepartment = new Label();
            panel1 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            txtbEmail = new TextBox();
            lblEmail = new Label();
            cbxDepartment = new ComboBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddEmployee
            // 
            lblAddEmployee.AutoSize = true;
            lblAddEmployee.BackColor = Color.FromArgb(191, 220, 255);
            lblAddEmployee.Font = new Font("Gadugi", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEmployee.ForeColor = Color.MidnightBlue;
            lblAddEmployee.Location = new Point(28, 37);
            lblAddEmployee.Name = "lblAddEmployee";
            lblAddEmployee.Size = new Size(215, 32);
            lblAddEmployee.TabIndex = 0;
            lblAddEmployee.Text = "ADD EMPLOYEE";
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployeeID.ForeColor = Color.FromArgb(73, 102, 169);
            lblEmployeeID.Location = new Point(24, 79);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(107, 21);
            lblEmployeeID.TabIndex = 1;
            lblEmployeeID.Text = "Employee ID*:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(116, 155, 194);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = SystemColors.ActiveCaptionText;
            btnSubmit.Location = new Point(35, 460);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(95, 30);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtbEmployeeID
            // 
            txtbEmployeeID.BackColor = Color.White;
            txtbEmployeeID.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbEmployeeID.ForeColor = Color.Black;
            txtbEmployeeID.Location = new Point(26, 103);
            txtbEmployeeID.Name = "txtbEmployeeID";
            txtbEmployeeID.Size = new Size(229, 25);
            txtbEmployeeID.TabIndex = 3;
            // 
            // dgvEmployeeList
            // 
            dgvEmployeeList.AllowUserToOrderColumns = true;
            dgvEmployeeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployeeList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvEmployeeList.BackgroundColor = Color.FromArgb(191, 220, 255);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeList.Cursor = Cursors.Cross;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmployeeList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployeeList.Location = new Point(314, 79);
            dgvEmployeeList.Name = "dgvEmployeeList";
            dgvEmployeeList.RowHeadersWidth = 50;
            dgvEmployeeList.RowTemplate.Height = 25;
            dgvEmployeeList.Size = new Size(829, 525);
            dgvEmployeeList.TabIndex = 4;
            dgvEmployeeList.RowHeaderMouseClick += dgvEmployeeList_RowHeaderMouseClick;
            // 
            // lblEmployeeList
            // 
            lblEmployeeList.AutoSize = true;
            lblEmployeeList.Font = new Font("Gadugi", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployeeList.ForeColor = Color.MidnightBlue;
            lblEmployeeList.Location = new Point(314, 37);
            lblEmployeeList.Name = "lblEmployeeList";
            lblEmployeeList.Size = new Size(210, 32);
            lblEmployeeList.TabIndex = 5;
            lblEmployeeList.Text = "EMPLOYEE LIST";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.ForeColor = Color.FromArgb(73, 102, 169);
            lblLastName.Location = new Point(24, 141);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(94, 21);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name*:";
            // 
            // txtbLastName
            // 
            txtbLastName.BackColor = Color.White;
            txtbLastName.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbLastName.ForeColor = Color.Black;
            txtbLastName.Location = new Point(26, 165);
            txtbLastName.Name = "txtbLastName";
            txtbLastName.Size = new Size(229, 25);
            txtbLastName.TabIndex = 7;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.FromArgb(191, 220, 255);
            lblFirstName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.ForeColor = Color.FromArgb(73, 102, 169);
            lblFirstName.Location = new Point(24, 204);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 21);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name*:";
            // 
            // txtbFirstName
            // 
            txtbFirstName.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbFirstName.ForeColor = Color.Black;
            txtbFirstName.Location = new Point(24, 228);
            txtbFirstName.Name = "txtbFirstName";
            txtbFirstName.Size = new Size(231, 25);
            txtbFirstName.TabIndex = 9;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPosition.ForeColor = Color.FromArgb(73, 102, 169);
            lblPosition.Location = new Point(24, 326);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(76, 21);
            lblPosition.TabIndex = 10;
            lblPosition.Text = "Position*:";
            // 
            // txtbPosition
            // 
            txtbPosition.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbPosition.ForeColor = Color.Black;
            txtbPosition.Location = new Point(24, 350);
            txtbPosition.Name = "txtbPosition";
            txtbPosition.Size = new Size(231, 25);
            txtbPosition.TabIndex = 11;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(24, 442);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 15);
            lblErrorMessage.TabIndex = 12;
            lblErrorMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(116, 155, 194);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(148, 460);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 30);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepartment.ForeColor = Color.FromArgb(73, 102, 169);
            lblDepartment.Location = new Point(24, 265);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(103, 21);
            lblDepartment.TabIndex = 15;
            lblDepartment.Text = "Department*:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(191, 220, 255);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(txtbEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(cbxDepartment);
            panel1.Controls.Add(lblErrorMessage);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblAddEmployee);
            panel1.Controls.Add(txtbEmployeeID);
            panel1.Controls.Add(lblEmployeeID);
            panel1.Controls.Add(lblDepartment);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(txtbLastName);
            panel1.Controls.Add(lblPosition);
            panel1.Controls.Add(txtbFirstName);
            panel1.Controls.Add(txtbPosition);
            panel1.Controls.Add(lblFirstName);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 635);
            panel1.TabIndex = 16;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(116, 155, 194);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(148, 506);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(116, 155, 194);
            btnEdit.Enabled = false;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ActiveCaptionText;
            btnEdit.Location = new Point(35, 506);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 30);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtbEmail
            // 
            txtbEmail.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbEmail.ForeColor = Color.Black;
            txtbEmail.Location = new Point(24, 414);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(231, 25);
            txtbEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(73, 102, 169);
            lblEmail.Location = new Point(24, 390);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(111, 21);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email Address:";
            // 
            // cbxDepartment
            // 
            cbxDepartment.BackColor = SystemColors.Window;
            cbxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDepartment.ForeColor = SystemColors.ActiveCaptionText;
            cbxDepartment.FormattingEnabled = true;
            cbxDepartment.Items.AddRange(new object[] { "Development", "Design", "Marketing", "Human Resources" });
            cbxDepartment.Location = new Point(24, 289);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Size = new Size(231, 25);
            cbxDepartment.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(-2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1177, 18);
            panel2.TabIndex = 17;
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 235);
            ClientSize = new Size(1175, 634);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblEmployeeList);
            Controls.Add(dgvEmployeeList);
            Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEmployeeDatabase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Database";
            FormClosing += frmEmployeeDatabase_FormClosing;
            Load += frmEmployeeDatabase_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddEmployee;
        private Label lblEmployeeID;
        private Button btnSubmit;
        private TextBox txtbEmployeeID;
        private DataGridView dgvEmployeeList;
        private Label lblEmployeeList;
        private Label lblLastName;
        private TextBox txtbLastName;
        private Label lblFirstName;
        private TextBox txtbFirstName;
        private Label lblPosition;
        private TextBox txtbPosition;
        private Label lblErrorMessage;
        private Button btnClear;
        private Label lblDepartment;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cbxDepartment;
        private Label lblEmail;
        private TextBox txtbEmail;
        private Button btnEdit;
        private Button btnDelete;
    }
}