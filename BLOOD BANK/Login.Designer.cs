namespace BLOOD_BANK
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Emp_Id_Tb = new System.Windows.Forms.TextBox();
            this.Emp_Pass_Tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.ContinueasAdmin_lbl = new System.Windows.Forms.Label();
            this.Exit_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(153, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blood Bank Management System";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(363, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 75);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(44, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Emp_Id_Tb
            // 
            this.Emp_Id_Tb.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.Emp_Id_Tb.Location = new System.Drawing.Point(199, 196);
            this.Emp_Id_Tb.Name = "Emp_Id_Tb";
            this.Emp_Id_Tb.Size = new System.Drawing.Size(426, 34);
            this.Emp_Id_Tb.TabIndex = 4;
            this.Emp_Id_Tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Emp_Pass_Tb
            // 
            this.Emp_Pass_Tb.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.Emp_Pass_Tb.Location = new System.Drawing.Point(199, 273);
            this.Emp_Pass_Tb.Name = "Emp_Pass_Tb";
            this.Emp_Pass_Tb.Size = new System.Drawing.Size(426, 34);
            this.Emp_Pass_Tb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(44, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Red;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Login.Location = new System.Drawing.Point(312, 350);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(152, 48);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // ContinueasAdmin_lbl
            // 
            this.ContinueasAdmin_lbl.AutoSize = true;
            this.ContinueasAdmin_lbl.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueasAdmin_lbl.ForeColor = System.Drawing.Color.Red;
            this.ContinueasAdmin_lbl.Location = new System.Drawing.Point(294, 427);
            this.ContinueasAdmin_lbl.Name = "ContinueasAdmin_lbl";
            this.ContinueasAdmin_lbl.Size = new System.Drawing.Size(196, 27);
            this.ContinueasAdmin_lbl.TabIndex = 8;
            this.ContinueasAdmin_lbl.Text = "Continue As Admin";
            this.ContinueasAdmin_lbl.Click += new System.EventHandler(this.ContinueasAdmin_lbl_Click);
            // 
            // Exit_lbl
            // 
            this.Exit_lbl.AutoSize = true;
            this.Exit_lbl.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_lbl.ForeColor = System.Drawing.Color.Red;
            this.Exit_lbl.Location = new System.Drawing.Point(760, 35);
            this.Exit_lbl.Name = "Exit_lbl";
            this.Exit_lbl.Size = new System.Drawing.Size(28, 27);
            this.Exit_lbl.TabIndex = 9;
            this.Exit_lbl.Text = "X";
            this.Exit_lbl.Click += new System.EventHandler(this.Exit_lbl_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.Exit_lbl);
            this.Controls.Add(this.ContinueasAdmin_lbl);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.Emp_Pass_Tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Emp_Id_Tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Emp_Id_Tb;
        private System.Windows.Forms.TextBox Emp_Pass_Tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label ContinueasAdmin_lbl;
        private System.Windows.Forms.Label Exit_lbl;
    }
}