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
    public partial class Requested_Leaves : Form
    {
        public Requested_Leaves()
        {
            InitializeComponent();
            LoadPendingLeaves();
            dataGridView1.CellClick += yourDataGridView_CellClick;
        }

        private void yourDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming your DataGridView columns are in the order as they appear in the table
                txtempno.Text = row.Cells["leaveid"].Value.ToString();
                empno.Text = row.Cells["empno"].Value.ToString();
                ltype.Text = row.Cells["leavetype"].Value.ToString();
                nofod.Text = row.Cells["Noofdays"].Value.ToString();
                cbstatus.Text = row.Cells["status"].Value.ToString();
            }
        }

        private void Requested_Leaves_Load(object sender, EventArgs e)
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

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtempno.Text.Trim(), out int leaveid))
            {
                MessageBox.Show("Invalid Leave ID. Please enter a valid number.");
                return;
            }

            string newStatus = cbstatus.Text.Trim();
            string leaveType = ltype.Text.Trim();
            int empno = int.Parse(txtempno.Text.Trim());
            int noOfDays = int.Parse(nofod.Text.Trim());

            string connectionString = "Data Source=HASIRASAHAN;Initial Catalog=Emp_Leave_Management_sys;Integrated Security=True;TrustServerCertificate=True";
            string updateQuery = "UPDATE applied_leaves SET status = @status WHERE leaveid = @leaveid";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@status", newStatus);
                    command.Parameters.AddWithValue("@leaveid", leaveid);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Status updated successfully!");

                            if (newStatus == "Rejected")
                            {
                                UpdateLeaveCount(connectionString, empno, leaveType, noOfDays);
                            }

                            LoadPendingLeaves();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please check the leave ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

        }

        private void LoadPendingLeaves()
        {

            string connectionString = "Data Source=HASIRASAHAN;Initial Catalog=Emp_Leave_Management_sys;Integrated Security=True;TrustServerCertificate=True";


            string query = "SELECT * FROM applied_leaves WHERE status = 'Pending'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
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

        private void UpdateLeaveCount(string connectionString, int empno, string leaveType, int noOfDays)
        {

            string updateLeaveQuery = "";

            switch (leaveType)
            {
                case "Annual":
                    updateLeaveQuery = "UPDATE Remaining_leaves SET Annual_leaves = Annual_leaves + @noOfDays WHERE empno = @empno";
                    break;
                case "Cassual":
                    updateLeaveQuery = "UPDATE Remaining_leaves SET Cassual_leaves = Cassual_leaves + @noOfDays WHERE empno = @empno";
                    break;
                case "Short":
                    updateLeaveQuery = "UPDATE Remaining_leaves SET short_leaves = short_leaves + @noOfDays WHERE empno = @empno";
                    break;
                default:
                    MessageBox.Show("Invalid leave type.");
                    return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateLeaveQuery, connection))
                {
                    command.Parameters.AddWithValue("@noOfDays", noOfDays);
                    command.Parameters.AddWithValue("@empno", empno);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the leave count: " + ex.Message);
                    }
                }
            }
        }


        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


