namespace Leave_management__Admin_
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtname = new System.Windows.Forms.TextBox();
            this.contnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.joindate = new System.Windows.Forms.DateTimePicker();
            this.empid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pswd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcassual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtannual = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtshort = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtbirth = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.roststart = new System.Windows.Forms.DateTimePicker();
            this.rostend = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Leave Management System ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Roaster Start Time ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Employee ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(607, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(412, 440);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(285, 97);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(286, 34);
            this.txtname.TabIndex = 10;
            // 
            // contnum
            // 
            this.contnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contnum.Location = new System.Drawing.Point(285, 209);
            this.contnum.Name = "contnum";
            this.contnum.Size = new System.Drawing.Size(286, 34);
            this.contnum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Roaster End Time ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Joining Date ";
            // 
            // joindate
            // 
            this.joindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joindate.Location = new System.Drawing.Point(270, 386);
            this.joindate.Name = "joindate";
            this.joindate.Size = new System.Drawing.Size(301, 27);
            this.joindate.TabIndex = 17;
            // 
            // empid
            // 
            this.empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empid.Location = new System.Drawing.Point(285, 443);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(286, 34);
            this.empid.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Password";
            // 
            // pswd
            // 
            this.pswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswd.Location = new System.Drawing.Point(285, 509);
            this.pswd.Name = "pswd";
            this.pswd.Size = new System.Drawing.Size(286, 34);
            this.pswd.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cassual Leaves";
            // 
            // txtcassual
            // 
            this.txtcassual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcassual.Location = new System.Drawing.Point(285, 569);
            this.txtcassual.Name = "txtcassual";
            this.txtcassual.Size = new System.Drawing.Size(286, 34);
            this.txtcassual.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 635);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "Annual Leaves";
            // 
            // txtannual
            // 
            this.txtannual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtannual.Location = new System.Drawing.Point(285, 632);
            this.txtannual.Name = "txtannual";
            this.txtannual.Size = new System.Drawing.Size(286, 34);
            this.txtannual.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 694);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 29);
            this.label12.TabIndex = 25;
            this.label12.Text = "Short Leaves";
            // 
            // txtshort
            // 
            this.txtshort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshort.Location = new System.Drawing.Point(285, 691);
            this.txtshort.Name = "txtshort";
            this.txtshort.Size = new System.Drawing.Size(286, 34);
            this.txtshort.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(934, 679);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 44);
            this.button1.TabIndex = 27;
            this.button1.Text = "Save ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(917, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(607, 177);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(304, 34);
            this.txtsearch.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 743);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 44);
            this.button3.TabIndex = 30;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(607, 679);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 44);
            this.button4.TabIndex = 31;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtbirth
            // 
            this.dtbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbirth.Location = new System.Drawing.Point(270, 157);
            this.dtbirth.Name = "dtbirth";
            this.dtbirth.Size = new System.Drawing.Size(301, 27);
            this.dtbirth.TabIndex = 32;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(965, 743);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 44);
            this.button5.TabIndex = 33;
            this.button5.Text = "Exit ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // roststart
            // 
            this.roststart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roststart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.roststart.Location = new System.Drawing.Point(327, 277);
            this.roststart.Name = "roststart";
            this.roststart.Size = new System.Drawing.Size(207, 22);
            this.roststart.TabIndex = 35;
            // 
            // rostend
            // 
            this.rostend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rostend.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.rostend.Location = new System.Drawing.Point(327, 335);
            this.rostend.Name = "rostend";
            this.rostend.Size = new System.Drawing.Size(207, 22);
            this.rostend.TabIndex = 36;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Leave_management__Admin_.Properties.Resources.business_activities_illustration_concept_flat_illustration_isolated_on_white_background_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 799);
            this.Controls.Add(this.rostend);
            this.Controls.Add(this.roststart);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dtbirth);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtshort);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtannual);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcassual);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pswd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.joindate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contnum);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox contnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker joindate;
        private System.Windows.Forms.TextBox empid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pswd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcassual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtannual;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtshort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtbirth;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker roststart;
        private System.Windows.Forms.DateTimePicker rostend;
    }
}