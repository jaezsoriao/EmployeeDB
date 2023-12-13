using Microsoft.Data.Sqlite;
using EmployeeNamespace;
using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        DataTable dataTable = new DataTable();
        int currentRow;

        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        //Codes executed upon loading app
        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            dataGridViewFormat();

            dgvEmployeeList.DataSource = dataTable;
            dgvEmployeeList.ReadOnly = true;

            dataTable.Columns.Add("ID", typeof(long));
            dataTable.Columns.Add("Last Name", typeof(string));
            dataTable.Columns.Add("First Name", typeof(string));
            dataTable.Columns.Add("Department", typeof(string));
            dataTable.Columns.Add("Position", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));

            panel1.SendToBack();
        }


        //Formatting DataGridView
        private void dataGridViewFormat()
        {
            dgvEmployeeList.DefaultCellStyle.Font = new Font("Yu Gothic UI", 10);
        }


        //Submit input box values
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbEmployeeID.Text))
                {
                    throw new ArgumentNullException();
                }
                else if (string.IsNullOrWhiteSpace(txtbFirstName.Text))
                {
                    throw new ArgumentNullException();
                }
                else if (string.IsNullOrWhiteSpace(txtbLastName.Text))
                {
                    throw new ArgumentNullException();
                }
                else if (string.IsNullOrWhiteSpace(txtbPosition.Text))
                {
                    throw new ArgumentNullException();
                }
                else if (string.IsNullOrEmpty(cbxDepartment.Text))
                {
                    throw new ArgumentNullException();
                }


                if (string.IsNullOrEmpty(txtbEmail.Text))
                {
                    Employee employee = new Employee(Convert.ToInt32(txtbEmployeeID.Text), txtbLastName.Text, txtbFirstName.Text, cbxDepartment.Text, txtbPosition.Text);
                    employee.Email = "None";
                    dataTable.Rows.Add(employee.ID, employee.LastName, employee.FirstName, employee.Department, employee.Position, employee.Email);
                }
                else
                {
                    Employee employee = new Employee(Convert.ToInt32(txtbEmployeeID.Text), txtbLastName.Text, txtbFirstName.Text, cbxDepartment.Text, txtbPosition.Text, txtbEmail.Text);
                    dataTable.Rows.Add(employee.ID, employee.LastName, employee.FirstName, employee.Department, employee.Position, employee.Email);
                }

                lblErrorMessage.Text = "";
                btnEditCheck();

            }
            catch (System.FormatException)
            {
                SystemSounds.Beep.Play();
                lblErrorMessage.Text = "Please enter ID number in the correct format";
            }
            catch (System.ArgumentNullException)
            {
                SystemSounds.Beep.Play();
                lblErrorMessage.Text = "Please fill up the required fields";
            }

        }


        //Clear input boxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbEmployeeID.Text = null;
            txtbFirstName.Text = null;
            txtbLastName.Text = null;
            txtbPosition.Text = null;
            cbxDepartment.Text = null;
            txtbEmail.Text = null;
        }


        //Edit data of existing employee
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbEmployeeID.Text))
                {
                    throw new ArgumentNullException();
                }
                else if (string.IsNullOrWhiteSpace(txtbFirstName.Text))
                {
                    throw new ArgumentNullException();
                }
                else if (string.IsNullOrWhiteSpace(txtbLastName.Text))
                {
                    throw new ArgumentNullException();
                }
                else if (string.IsNullOrWhiteSpace(txtbPosition.Text))
                {
                    throw new ArgumentNullException();
                }
                else if (string.IsNullOrEmpty(cbxDepartment.Text))
                {
                    throw new ArgumentNullException();
                }

                dgvEmployeeList.Rows[currentRow].Cells[0].Value = txtbEmployeeID.Text;
                dgvEmployeeList.Rows[currentRow].Cells[1].Value = txtbLastName.Text;
                dgvEmployeeList.Rows[currentRow].Cells[2].Value = txtbFirstName.Text;
                dgvEmployeeList.Rows[currentRow].Cells[3].Value = cbxDepartment.Text;
                dgvEmployeeList.Rows[currentRow].Cells[4].Value = txtbPosition.Text;

                if (string.IsNullOrEmpty(txtbEmail.Text))
                {
                    dgvEmployeeList.Rows[currentRow].Cells[5].Value = "None";
                }
                else
                {
                    dgvEmployeeList.Rows[currentRow].Cells[5].Value = txtbEmail.Text;
                }

                lblErrorMessage.Text = "";
            }

            catch (System.ArgumentNullException)
            {
                SystemSounds.Beep.Play();
                lblErrorMessage.Text = "Please enter ID number in the correct format";
            }
            catch (System.FormatException)
            {
                SystemSounds.Beep.Play();
                lblErrorMessage.Text = "Please enter ID number in the correct format";
            }           
        }


        //Copy employee data to input boxes (for editing)
        private void dgvEmployeeList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentRow = e.RowIndex;
            btnEditCheck();

            if (dgvEmployeeList.SelectedRows.Count == 1)
            {
                txtbEmployeeID.Text = Convert.ToString(dgvEmployeeList.SelectedRows[0].Cells[0].Value);
                txtbLastName.Text = Convert.ToString(dgvEmployeeList.SelectedRows[0].Cells[1].Value);
                txtbFirstName.Text = Convert.ToString(dgvEmployeeList.SelectedRows[0].Cells[2].Value);
                cbxDepartment.Text = Convert.ToString(dgvEmployeeList.SelectedRows[0].Cells[3].Value);
                txtbPosition.Text = Convert.ToString(dgvEmployeeList.SelectedRows[0].Cells[4].Value);
                txtbEmail.Text = Convert.ToString(dgvEmployeeList.SelectedRows[0].Cells[5].Value);
            }
        }


        //Toggles edit button on/off
        private void btnEditCheck()
        {
            if (dgvEmployeeList.Rows.Count <= 1)
            {
                btnEdit.Enabled = false;
            }
            else if (dgvEmployeeList.CurrentRow.Index == dgvEmployeeList.RowCount - 1)
            {
                btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
            }
        }


        //Exit app
        private void frmEmployeeDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}



//SQLllllllll
//using (var connection = new SqliteConnection("Data Source=employee.db"))
//{
//    connection.Open();

//    var command = connection.CreateCommand();
//    command.CommandText =
//        @"
//                        CREATE TABLE IF NOT EXISTS employee (
//                        Id INTEGER PRIMARY KEY,
//                        last_name TEXT,
//                        first_name TEXT,
//                        position TEXT)
//                    ";
//    command.ExecuteNonQuery();

//}