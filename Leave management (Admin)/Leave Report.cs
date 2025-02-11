using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_management__Admin_
{
    public partial class Leave_Report : Form
    {
        public Leave_Report()
        {
            InitializeComponent();
        }

        private void dtpfrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngfa_Click(object sender, EventArgs e)
        {
            DateTime dtpFrom = dtpfrom.Value;
            DateTime dtpTo = dtpto.Value;

            string connectionString = "Data Source=HASIRASAHAN;Initial Catalog=Emp_Leave_Management_sys;Integrated Security=True;TrustServerCertificate=True";
            string query = @"SELECT * FROM applied_leaves
                     WHERE status = 'Approved'
                     AND (
                         (leavetype <> 'short' AND startdateortime BETWEEN @dtpfrom AND @dtpto)
                         OR
                         (leavetype = 'short' AND Applieddate BETWEEN @dtpfrom AND @dtpto)
                     )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dtpfrom", dtpFrom);
                    command.Parameters.AddWithValue("@dtpto", dtpTo);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btngfm_Click(object sender, EventArgs e)
        {

            DateTime dtpFrom = dtpfrom.Value;
            DateTime dtpTo = dtpto.Value;

            if (dtpFrom > dtpTo)
            {
                MessageBox.Show("The 'From' date cannot be later than the 'To' date.");
                return;
            }

            if (!int.TryParse(txtempno.Text.Trim(), out int empno))
            {
                MessageBox.Show("Invalid Employee Number. Please enter a valid number.");
                return;
            }

            FilterLeavesforemployee(dtpFrom, dtpTo, empno);
        }

        private void FilterLeavesforemployee(DateTime dtpFrom, DateTime dtpTo, int empno)
        {
            string connectionString = "Data Source=HASIRASAHAN;Initial Catalog=Emp_Leave_Management_sys;Integrated Security=True;TrustServerCertificate=True";
            string query = @"SELECT * FROM applied_leaves
                     WHERE status = 'Approved'
                     AND empno = @empno
                     AND (
                         (leavetype <> 'short' AND startdateortime BETWEEN @dtpfrom AND @dtpto)
                         OR
                         (leavetype = 'short' AND Applieddate BETWEEN @dtpfrom AND @dtpto)
                     )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@empno", empno);
                    command.Parameters.AddWithValue("@dtpfrom", dtpFrom);
                    command.Parameters.AddWithValue("@dtpto", dtpTo);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Leave_Report_Load(object sender, EventArgs e)
        {
            DateTime dtpFrom = dtpfrom.Value;
            DateTime dtpTo = dtpto.Value;

            string connectionString = "Data Source=HASIRASAHAN;Initial Catalog=Emp_Leave_Management_sys;Integrated Security=True;TrustServerCertificate=True";
            string query = @"SELECT * FROM applied_leaves
                     WHERE status = 'Approved'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dtpfrom", dtpFrom);
                    command.Parameters.AddWithValue("@dtpto", dtpTo);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
    }


