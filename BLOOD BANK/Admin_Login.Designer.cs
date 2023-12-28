namespace BLOOD_BANK
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            this.Exit_lbl = new System.Windows.Forms.Label();
            this.Cancel_lbl = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.Admin_Pass_Tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit_lbl
            // 
            this.Exit_lbl.AutoSize = true;
            this.Exit_lbl.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_lbl.ForeColor = System.Drawing.Color.Red;
            this.Exit_lbl.Location = new System.Drawing.Point(737, 41);
            this.Exit_lbl.Name = "Exit_lbl";
            this.Exit_lbl.Size = new System.Drawing.Size(28, 27);
            this.Exit_lbl.TabIndex = 18;
            this.Exit_lbl.Text = "X";
            this.Exit_lbl.Click += new System.EventHandler(this.Exit_lbl_Click);
            // 
            // Cancel_lbl
            // 
            this.Cancel_lbl.AutoSize = true;
            this.Cancel_lbl.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_lbl.ForeColor = System.Drawing.Color.Red;
            this.Cancel_lbl.Location = new System.Drawing.Point(324, 434);
            this.Cancel_lbl.Name = "Cancel_lbl";
            this.Cancel_lbl.Size = new System.Drawing.Size(75, 27);
            this.Cancel_lbl.TabIndex = 17;
            this.Cancel_lbl.Text = "Cancel";
            this.Cancel_lbl.Click += new System.EventHandler(this.Cancel_lbl_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Red;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Login.Location = new System.Drawing.Point(289, 356);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(152, 48);
            this.btn_Login.TabIndex = 16;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Admin_Pass_Tb
            // 
            this.Admin_Pass_Tb.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.Admin_Pass_Tb.Location = new System.Drawing.Point(184, 248);
            this.Admin_Pass_Tb.Name = "Admin_Pass_Tb";
            this.Admin_Pass_Tb.Size = new System.Drawing.Size(426, 34);
            this.Admin_Pass_Tb.TabIndex = 15;
            this.Admin_Pass_Tb.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(29, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(340, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 75);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(130, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Blood Bank Management System";
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(786, 506);
            this.Controls.Add(this.Exit_lbl);
            this.Controls.Add(this.Cancel_lbl);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.Admin_Pass_Tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Login";
            this.Text = "Admin_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit_lbl;
        private System.Windows.Forms.Label Cancel_lbl;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox Admin_Pass_Tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}