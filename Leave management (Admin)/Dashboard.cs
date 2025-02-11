using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_management__Admin_
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Employee update_Employee = new Update_Employee();
            update_Employee.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Requested_Leaves  requested_Leaves = new Requested_Leaves();
            requested_Leaves.Show();
            this .Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leave_Report leave_Report = new Leave_Report();
            leave_Report.Show();            
            this .Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
