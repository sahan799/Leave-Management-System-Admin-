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
    public partial class Update_Employee : Form
    {
        public Update_Employee()
        {
            InitializeComponent();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtempno.Text = row.Cells["empno"].Value.ToString();
                textBox1.Text = row.Cells["name"].Value.ToString();
                textBox3.Text = row.Cells["contactno"].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(row.Cells["Roaster_st_time"].Value.ToString());
                dateTimePicker3.Value = DateTime.Parse(row.Cells["Roaster_en_time"].Value.ToString());
            }
        }

        private void Update_Employee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
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

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            int empno = int.Parse(txtempno.Text);
            int annualLeaves = int.Parse(txtannual.Text);
            int casualLeaves = int.Parse(txtcassual.Text);
            int shortLeaves = int.Parse(txtshort.Text);

            UpdateLeaves(empno, annualLeaves, casualLeaves, shortLeaves);


            MessageBox.Show("Leave amounts updated successfully");
        }

        private void UpdateLeaves(int empno, int annualLeaves, int casualLeaves, int shortLeaves)
        {
            string connectionString = "Data Source=HASIRASAHAN;Initial Catalog=Emp_Leave_Management_sys;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Remaining_leaves SET Annual_leaves = @annualLeaves, Cassual_leaves = @casualLeaves, short_leaves = @shortLeaves WHERE emppID = @empID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Ensure you are passing the value of the TextBox control, not the control itself

                }

            }
        }
                private void empID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

