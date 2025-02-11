namespace Leave_management__Admin_
{
    partial class Leave_Report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.btngfa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btngfm = new System.Windows.Forms.Button();
            this.txtempno = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(412, 455);
            this.dataGridView1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "From ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "To";
            // 
            // dtpfrom
            // 
            this.dtpfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(104, 61);
            this.dtpfrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(265, 30);
            this.dtpfrom.TabIndex = 33;
            this.dtpfrom.ValueChanged += new System.EventHandler(this.dtpfrom_ValueChanged);
            // 
            // dtpto
            // 
            this.dtpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(104, 130);
            this.dtpto.Margin = new System.Windows.Forms.Padding(4);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(265, 30);
            this.dtpto.TabIndex = 34;
            // 
            // btngfa
            // 
            this.btngfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngfa.Location = new System.Drawing.Point(210, 168);
            this.btngfa.Margin = new System.Windows.Forms.Padding(4);
            this.btngfa.Name = "btngfa";
            this.btngfa.Size = new System.Drawing.Size(159, 37);
            this.btngfa.TabIndex = 35;
            this.btngfa.Text = "Generate for All\r\n";
            this.btngfa.UseVisualStyleBackColor = true;
            this.btngfa.Click += new System.EventHandler(this.btngfa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Employee ID";
            // 
            // btngfm
            // 
            this.btngfm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngfm.Location = new System.Drawing.Point(86, 280);
            this.btngfm.Margin = new System.Windows.Forms.Padding(4);
            this.btngfm.Name = "btngfm";
            this.btngfm.Size = new System.Drawing.Size(280, 37);
            this.btngfm.TabIndex = 37;
            this.btngfm.Text = "Generate for Member";
            this.btngfm.UseVisualStyleBackColor = true;
            this.btngfm.Click += new System.EventHandler(this.btngfm_Click);
            // 
            // txtempno
            // 
            this.txtempno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempno.Location = new System.Drawing.Point(154, 239);
            this.txtempno.Name = "txtempno";
            this.txtempno.Size = new System.Drawing.Size(215, 34);
            this.txtempno.TabIndex = 38;
            this.txtempno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(13, 449);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 39);
            this.btnback.TabIndex = 39;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(290, 449);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 40);
            this.button5.TabIndex = 40;
            this.button5.Text = "Exit ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Leave_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Leave_management__Admin_.Properties.Resources.business_activities_illustration_concept_flat_illustration_isolated_on_white_background_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtempno);
            this.Controls.Add(this.btngfm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngfa);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Leave_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave_Report";
            this.Load += new System.EventHandler(this.Leave_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Button btngfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngfm;
        private System.Windows.Forms.TextBox txtempno;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button button5;
    }
}