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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Leave_management__Admin_
{
    public partial class Register : Form
    {
        private string connectionString = "Data Source=HASIRASAHAN;Initial Catalog=Emp_Leave_Management_sys;Integrated Security=True;TrustServerCertificate=True";

        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(empid.Text) ||
            string.IsNullOrWhiteSpace(pswd.Text) ||
            string.IsNullOrWhiteSpace(txtannual.Text) ||
            string.IsNullOrWhiteSpace(txtcassual.Text) ||
            string.IsNullOrWhiteSpace(txtshort.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int empno;
            if (!int.TryParse(empid.Text, out empno))
            {
                MessageBox.Show("Invalid Empno.");
                return;
            }

            string queryPassword = "INSERT INTO Passwords (empno, password) VALUES (@empno, @password)";
            string queryLeave = "INSERT INTO Remaining_leaves (empno, Annual_leaves, Cassual_leaves, short_leaves) VALUES (@empno, @annualLeaves, @casualLeaves, @shortLeaves)";

            using (SqlConnection connection = new SqlConnection(connectionString))
                try
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand(queryPassword, connection))
                    {
                        command.Parameters.AddWithValue("@empno", empno);
                        command.Parameters.AddWithValue("@password", pswd.Text);
                        command.ExecuteNonQuery();
                    }


                    using (SqlCommand command = new SqlCommand(queryLeave, connection))
                    {
                        command.Parameters.AddWithValue("@empno", empno);
                        command.Parameters.AddWithValue("@annualLeaves", int.Parse(txtannual.Text));
                        command.Parameters.AddWithValue("@casualLeaves", int.Parse(txtcassual.Text));
                        command.Parameters.AddWithValue("@shortLeaves", int.Parse(txtshort.Text));
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data inserted successfully.");
                    LoadData();
                    ClearAllControls(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
        }

        private void ClearAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                }
                else if (control.HasChildren)
                {
                    ClearAllControls(control);
                }
            }
        }

        private void LoadData()
        {

            string connectionString = "Data Source=HASIRASAHAN;Initial Catalog=Emp_Leave_Management_sys;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM Employee_details";

            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }

                dataGridView1.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            DateTime dateOfBirth = dtbirth.Value.Date;
            int contactNo = int.Parse(contnum.Text);
            TimeSpan roasterStartTime = roststart.Value.TimeOfDay;
            TimeSpan roasterEndTime = rostend.Value.TimeOfDay;
            DateTime joiningDate = joindate.Value.Date;

            string connectionString = "Data Source=HASIRASAHAN;Initial Catalog=Emp_Leave_Management_sys;Integrated Security=True;TrustServerCertificate=True";

            string query = "INSERT INTO Employee_details (name, dateofbirth, contactno, Roaster_st_time, Roaster_en_time, Joining_date) " +
                     "VALUES (@name, @dateOfBirth, @contactNo, @roasterStartTime, @roasterEndTime, @joiningDate)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@contactNo", contactNo);
                    command.Parameters.AddWithValue("@roasterStartTime", roasterStartTime);
                    command.Parameters.AddWithValue("@roasterEndTime", roasterEndTime);
                    command.Parameters.AddWithValue("@joiningDate", joiningDate);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Record inserted successfully.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                LoadData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sname = txtsearch.Text;

            string connectionString = "Data Source=HASIRASAHAN;Initial Catalog=Emp_Leave_Management_sys;Integrated Security=True;TrustServerCertificate=True";
            string query = "select * from Employee_details where name ='" + sname + "'";
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }

                dataGridView1.DataSource = dataTable;
                ClearAllControls(this);
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }


}
