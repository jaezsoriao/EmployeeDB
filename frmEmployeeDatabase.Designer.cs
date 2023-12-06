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
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
            SuspendLayout();
            // 
            // lblAddEmployee
            // 
            lblAddEmployee.AutoSize = true;
            lblAddEmployee.BackColor = Color.FromArgb(246, 244, 235);
            lblAddEmployee.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEmployee.ForeColor = Color.FromArgb(64, 24, 182);
            lblAddEmployee.Location = new Point(26, 27);
            lblAddEmployee.Name = "lblAddEmployee";
            lblAddEmployee.Size = new Size(194, 28);
            lblAddEmployee.TabIndex = 0;
            lblAddEmployee.Text = "ADD EMPLOYEE";
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployeeID.ForeColor = Color.FromArgb(73, 102, 169);
            lblEmployeeID.Location = new Point(29, 67);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(107, 21);
            lblEmployeeID.TabIndex = 1;
            lblEmployeeID.Text = "Employee ID*:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(116, 155, 194);
            btnSubmit.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = SystemColors.ActiveCaptionText;
            btnSubmit.Location = new Point(39, 332);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(97, 35);
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
            txtbEmployeeID.Location = new Point(29, 91);
            txtbEmployeeID.Name = "txtbEmployeeID";
            txtbEmployeeID.Size = new Size(229, 25);
            txtbEmployeeID.TabIndex = 3;
            // 
            // dgvEmployeeList
            // 
            dgvEmployeeList.AllowUserToOrderColumns = true;
            dgvEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployeeList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvEmployeeList.BackgroundColor = Color.FromArgb(191, 220, 255);
            dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeList.Cursor = Cursors.Cross;
            dgvEmployeeList.Location = new Point(282, 67);
            dgvEmployeeList.Name = "dgvEmployeeList";
            dgvEmployeeList.RowHeadersWidth = 50;
            dgvEmployeeList.RowTemplate.Height = 25;
            dgvEmployeeList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvEmployeeList.Size = new Size(646, 358);
            dgvEmployeeList.TabIndex = 4;
            // 
            // lblEmployeeList
            // 
            lblEmployeeList.AutoSize = true;
            lblEmployeeList.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployeeList.ForeColor = Color.FromArgb(64, 24, 182);
            lblEmployeeList.Location = new Point(282, 27);
            lblEmployeeList.Name = "lblEmployeeList";
            lblEmployeeList.Size = new Size(188, 28);
            lblEmployeeList.TabIndex = 5;
            lblEmployeeList.Text = "EMPLOYEE LIST";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.ForeColor = Color.FromArgb(73, 102, 169);
            lblLastName.Location = new Point(29, 128);
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
            txtbLastName.Location = new Point(29, 152);
            txtbLastName.Name = "txtbLastName";
            txtbLastName.Size = new Size(229, 25);
            txtbLastName.TabIndex = 7;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.ForeColor = Color.FromArgb(73, 102, 169);
            lblFirstName.Location = new Point(27, 195);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 21);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name*:";
            // 
            // txtbFirstName
            // 
            txtbFirstName.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbFirstName.ForeColor = Color.Black;
            txtbFirstName.Location = new Point(27, 219);
            txtbFirstName.Name = "txtbFirstName";
            txtbFirstName.Size = new Size(231, 25);
            txtbFirstName.TabIndex = 9;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPosition.ForeColor = Color.FromArgb(73, 102, 169);
            lblPosition.Location = new Point(27, 262);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(76, 21);
            lblPosition.TabIndex = 10;
            lblPosition.Text = "Position*:";
            // 
            // txtbPosition
            // 
            txtbPosition.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtbPosition.ForeColor = Color.Black;
            txtbPosition.Location = new Point(27, 286);
            txtbPosition.Name = "txtbPosition";
            txtbPosition.Size = new Size(231, 25);
            txtbPosition.TabIndex = 11;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Yu Gothic UI", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(26, 314);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(43, 15);
            lblErrorMessage.TabIndex = 12;
            lblErrorMessage.Text = "hfudas";
            lblErrorMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(116, 155, 194);
            btnClear.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(152, 332);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 35);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 244, 235);
            ClientSize = new Size(950, 509);
            Controls.Add(btnClear);
            Controls.Add(lblErrorMessage);
            Controls.Add(txtbPosition);
            Controls.Add(lblPosition);
            Controls.Add(txtbFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtbLastName);
            Controls.Add(lblLastName);
            Controls.Add(lblEmployeeList);
            Controls.Add(dgvEmployeeList);
            Controls.Add(txtbEmployeeID);
            Controls.Add(btnSubmit);
            Controls.Add(lblEmployeeID);
            Controls.Add(lblAddEmployee);
            Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEmployeeDatabase";
            Text = "Employee Database";
            Load += frmEmployeeDatabase_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
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
    }
}