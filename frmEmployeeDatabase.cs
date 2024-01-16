using EmployeeNamespace;
using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
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
        DatabaseManager dbManager = new DatabaseManager();
        DataSet dataSet = new DataSet();
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

            string displayQuery = "SELECT * FROM employee";
            MySqlCommand cmd2 = new MySqlCommand(displayQuery, DatabaseManager.connection);
            MySqlDataReader display = cmd2.ExecuteReader();
            dataTable.Load(display);

            btnEditCheck();
            btnDeleteCheck();
            btnClearCheck();

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

                    string insertQuery = "INSERT INTO employee VALUES('" + employee.ID + "','" + employee.LastName + "','" + employee.FirstName + "','" + employee.Department + "','" + employee.Position + "','" + employee.Email + "')";
                    MySqlDataAdapter cmd1 = new MySqlDataAdapter(insertQuery, DatabaseManager.connection);
                    cmd1.Fill(dataSet);

                }
                else
                {
                    Employee employee = new Employee(Convert.ToInt32(txtbEmployeeID.Text), txtbLastName.Text, txtbFirstName.Text, cbxDepartment.Text, txtbPosition.Text, txtbEmail.Text);

                    string insertQuery = "INSERT INTO employee VALUES('" + employee.ID + "','" + employee.LastName + "','" + employee.FirstName + "','" + employee.Department + "','" + employee.Position + "','" + employee.Email + "')";
                    MySqlDataAdapter cmd1 = new MySqlDataAdapter(insertQuery, DatabaseManager.connection);
                    cmd1.Fill(dataSet);
                }

                string displayQuery = "SELECT * FROM employee";
                MySqlCommand cmd2 = new MySqlCommand(displayQuery, DatabaseManager.connection);
                MySqlDataReader reader = cmd2.ExecuteReader();
                dataTable.Load(reader);

                lblErrorMessage.Text = "";
                btnEditCheck();
                btnDeleteCheck();
                btnClearCheck();

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
            catch (MySqlException r)
            {
                SystemSounds.Beep.Play();
                lblErrorMessage.Text = "Employees cannot share the same ID";
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

            btnClearCheck();
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


                //Update LastName
                string editLastNameQuery = "UPDATE employee " +
                                   "SET LastName = '" + Convert.ToString(txtbLastName.Text) + "' " +
                                   "WHERE EmployeeID = " + Convert.ToString(dgvEmployeeList.Rows[currentRow].Cells[0].Value);
                MySqlCommand editLastNameCmd = new MySqlCommand(editLastNameQuery, DatabaseManager.connection);
                MySqlDataReader editLastName = editLastNameCmd.ExecuteReader();
                dataTable.Load(editLastName);

                //Update FirstName
                string editFirstNameQuery = "UPDATE employee " +
                                   "SET FirstName = '" + Convert.ToString(txtbFirstName.Text) + "' " +
                                   "WHERE EmployeeID = " + Convert.ToString(dgvEmployeeList.Rows[currentRow].Cells[0].Value);
                MySqlCommand editFirstNameCmd = new MySqlCommand(editFirstNameQuery, DatabaseManager.connection);
                MySqlDataReader editFirstName = editFirstNameCmd.ExecuteReader();
                dataTable.Load(editFirstName);

                //Update Department
                string editDepartmentQuery = "UPDATE employee " +
                                   "SET Department = '" + Convert.ToString(cbxDepartment.Text) + "' " +
                                   "WHERE EmployeeID = " + Convert.ToString(dgvEmployeeList.Rows[currentRow].Cells[0].Value);
                MySqlCommand editDepartmentCmd = new MySqlCommand(editDepartmentQuery, DatabaseManager.connection);
                MySqlDataReader editDepartment = editDepartmentCmd.ExecuteReader();
                dataTable.Load(editDepartment);

                //Update Position
                string editPositionQuery = "UPDATE employee " +
                                   "SET Position = '" + Convert.ToString(txtbPosition.Text) + "' " +
                                   "WHERE EmployeeID = " + Convert.ToString(dgvEmployeeList.Rows[currentRow].Cells[0].Value);
                MySqlCommand editPositionCmd = new MySqlCommand(editPositionQuery, DatabaseManager.connection);
                MySqlDataReader editPosition = editPositionCmd.ExecuteReader();
                dataTable.Load(editPosition);

                //Update Email
                if (string.IsNullOrEmpty(txtbEmail.Text))
                {
                    string editEmailQuery = "UPDATE employee " +
                                            "SET Email = 'None'" + " " +
                                            "WHERE EmployeeID = " + Convert.ToString(dgvEmployeeList.Rows[currentRow].Cells[0].Value);
                    MySqlCommand editEmailCmd = new MySqlCommand(editEmailQuery, DatabaseManager.connection);
                    MySqlDataReader editEmail = editEmailCmd.ExecuteReader();
                    dataTable.Load(editEmail);
                    dgvEmployeeList.Rows[currentRow].Cells[5].Value = "None";
                }
                else
                {
                    string editEmailQuery = "UPDATE employee " +
                                            "SET Email = '" + Convert.ToString(txtbEmail.Text) + "' " +
                                            "WHERE EmployeeID = " + Convert.ToString(dgvEmployeeList.Rows[currentRow].Cells[0].Value);
                    MySqlCommand editEmailCmd = new MySqlCommand(editEmailQuery, DatabaseManager.connection);
                    MySqlDataReader editEmail = editEmailCmd.ExecuteReader();
                    dataTable.Load(editEmail);

                    dgvEmployeeList.Rows[currentRow].Cells[5].Value = txtbEmail.Text;
                }

                //Update EmployeeID
                string editEmployeeIDQuery = "UPDATE employee " +
                                   "SET EmployeeID = '" + Convert.ToString(txtbEmployeeID.Text) + "' " +
                                   "WHERE EmployeeID = " + Convert.ToString(dgvEmployeeList.Rows[currentRow].Cells[0].Value);
                MySqlCommand editEmployeeIDCmd = new MySqlCommand(editEmployeeIDQuery, DatabaseManager.connection);
                MySqlDataReader editEmployeeID = editEmployeeIDCmd.ExecuteReader();
                dataTable.Load(editEmployeeID);

                dgvEmployeeList.Rows[currentRow].Cells[0].Value = txtbEmployeeID.Text;
                dgvEmployeeList.Rows[currentRow].Cells[1].Value = txtbLastName.Text;
                dgvEmployeeList.Rows[currentRow].Cells[2].Value = txtbFirstName.Text;
                dgvEmployeeList.Rows[currentRow].Cells[3].Value = cbxDepartment.Text;
                dgvEmployeeList.Rows[currentRow].Cells[4].Value = txtbPosition.Text;

                lblErrorMessage.Text = "";
            }

            catch (System.ArgumentNullException)
            {
                SystemSounds.Beep.Play();
                lblErrorMessage.Text = "Please fill up the required fields";
            }
            catch (System.FormatException)
            {
                SystemSounds.Beep.Play();
                lblErrorMessage.Text = "Please enter ID number in the correct format";
            }
            catch (MySqlException r)
            {
                SystemSounds.Beep.Play();
                lblErrorMessage.Text = "Employees cannot share the same ID";
            }

            btnEditCheck();
            btnDeleteCheck();
            btnClearCheck();

        }

        //Delete selected row
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM employee WHERE EmployeeID = " + Convert.ToString(dgvEmployeeList.Rows[currentRow].Cells[0].Value) + ";";
                MySqlCommand cmd1 = new MySqlCommand(deleteQuery, DatabaseManager.connection);
                MySqlDataReader delete = cmd1.ExecuteReader();
                dataTable.Load(delete);

                foreach (DataGridViewRow row in dgvEmployeeList.SelectedRows)
                {
                    dgvEmployeeList.Rows.RemoveAt(row.Index);
                }

                btnDeleteCheck();
                btnEditCheck();
                btnClearCheck();
            }
            catch (MySqlException r)
            {
                SystemSounds.Beep.Play();
                lblErrorMessage.Text = "Employees cannot share the same ID";
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

        //Toggles clear button on/off
        private void btnClearCheck()
        {
            if (txtbEmployeeID.Text.Equals("") && txtbLastName.Text.Equals("") && txtbFirstName.Text.Equals("") && txtbPosition.Text.Equals("") && txtbEmail.Text.Equals("") && cbxDepartment.Text.Equals(""))
            {
                btnClear.Enabled = false;
            }
            else
            {
                btnClear.Enabled = true;
            }
        }


        //Toggles delete button on/off
        private void btnDeleteCheck()
        {
            if (dgvEmployeeList.Rows.Count <= 1)
            {
                btnDelete.Enabled = false;
            }
            else if (dgvEmployeeList.CurrentRow.Index == dgvEmployeeList.RowCount - 1)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }


        //Exit app
        private void frmEmployeeDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            DatabaseManager.connection.Close();
        }


        //Toggle clear button upon input
        private void txtbEmployeeID_TextChanged(object sender, EventArgs e)
        {
            btnClearCheck();
        }

        private void txtbLastName_TextChanged(object sender, EventArgs e)
        {
            btnClearCheck();
        }

        private void txtbFirstName_TextChanged(object sender, EventArgs e)
        {
            btnClearCheck();
        }

        private void cbxDepartment_TextChanged(object sender, EventArgs e)
        {
            btnClearCheck();
        }

        private void txtbPosition_TextChanged(object sender, EventArgs e)
        {
            btnClearCheck();
        }

        private void txtbEmail_TextChanged(object sender, EventArgs e)
        {
            btnClearCheck();
        }
    }
}
