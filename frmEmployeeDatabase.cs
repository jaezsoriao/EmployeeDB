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

        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            dataGridViewFormat();

            dgvEmployeeList.DataSource = dataTable;
            dgvEmployeeList.ReadOnly = true;

            dataTable.Columns.Add("ID", typeof(long));
            dataTable.Columns.Add("Last Name", typeof(string));
            dataTable.Columns.Add("First Name", typeof(string));
            dataTable.Columns.Add("Position", typeof(string));
            dataTable.Columns.Add("Department", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));


            panel1.SendToBack();
        }

        //Formatting DataGridView
        private void dataGridViewFormat()
        {
            dgvEmployeeList.DefaultCellStyle.Font = new Font("Yu Gothic UI", 10);
        }

        //Input
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
                    Employee employee = new Employee(Convert.ToInt32(txtbEmployeeID.Text), txtbLastName.Text, txtbFirstName.Text, txtbPosition.Text, cbxDepartment.Text);
                    employee.Email = "None";
                    dataTable.Rows.Add(employee.ID, employee.LastName, employee.FirstName, employee.Position, employee.Department, employee.Email);
                }
                else
                {
                    Employee employee = new Employee(Convert.ToInt32(txtbEmployeeID.Text), txtbLastName.Text, txtbFirstName.Text, txtbPosition.Text, cbxDepartment.Text, txtbEmail.Text);
                    dataTable.Rows.Add(employee.ID, employee.LastName, employee.FirstName, employee.Position, employee.Department, employee.Email);
                }

                lblErrorMessage.Text = "";


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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbEmployeeID.Text = null;
            txtbFirstName.Text = null;
            txtbLastName.Text = null;
            txtbPosition.Text = null;
            cbxDepartment.Text = null;
            txtbEmail.Text = null;
        }

        private void frmEmployeeDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}


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