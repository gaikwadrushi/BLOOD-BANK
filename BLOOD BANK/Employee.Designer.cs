namespace BLOOD_BANK
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.EPassword_Tb = new System.Windows.Forms.TextBox();
            this.Employee_Label = new System.Windows.Forms.Label();
            this.Login_lbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ENameTb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.Employee_DGV = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // EPassword_Tb
            // 
            this.EPassword_Tb.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.EPassword_Tb.Location = new System.Drawing.Point(751, 618);
            this.EPassword_Tb.Name = "EPassword_Tb";
            this.EPassword_Tb.Size = new System.Drawing.Size(189, 34);
            this.EPassword_Tb.TabIndex = 53;
            // 
            // Employee_Label
            // 
            this.Employee_Label.AutoSize = true;
            this.Employee_Label.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Label.ForeColor = System.Drawing.Color.White;
            this.Employee_Label.Location = new System.Drawing.Point(38, 90);
            this.Employee_Label.Name = "Employee_Label";
            this.Employee_Label.Size = new System.Drawing.Size(105, 27);
            this.Employee_Label.TabIndex = 18;
            this.Employee_Label.Text = "Employee";
            // 
            // Login_lbl
            // 
            this.Login_lbl.AutoSize = true;
            this.Login_lbl.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lbl.ForeColor = System.Drawing.Color.White;
            this.Login_lbl.Location = new System.Drawing.Point(52, 596);
            this.Login_lbl.Name = "Login_lbl";
            this.Login_lbl.Size = new System.Drawing.Size(81, 27);
            this.Login_lbl.TabIndex = 17;
            this.Login_lbl.Text = "Logout";
            this.Login_lbl.Click += new System.EventHandler(this.Login_lbl_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(581, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 46);
            this.panel4.TabIndex = 50;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Pink;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Location = new System.Drawing.Point(340, 693);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(152, 52);
            this.btn_Save.TabIndex = 49;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Crimson;
            this.label16.Location = new System.Drawing.Point(746, 578);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 27);
            this.label16.TabIndex = 48;
            this.label16.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(298, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 27);
            this.label11.TabIndex = 47;
            this.label11.Text = "Name";
            // 
            // ENameTb
            // 
            this.ENameTb.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.ENameTb.Location = new System.Drawing.Point(303, 618);
            this.ENameTb.Name = "ENameTb";
            this.ENameTb.Size = new System.Drawing.Size(189, 34);
            this.ENameTb.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel3.Location = new System.Drawing.Point(22, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 31);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepPink;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 66);
            this.panel2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blood Bank Management System";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Californian FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(533, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 38);
            this.label10.TabIndex = 45;
            this.label10.Text = "Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.Employee_Label);
            this.panel1.Controls.Add(this.Login_lbl);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 773);
            this.panel1.TabIndex = 43;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Location = new System.Drawing.Point(776, 693);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(152, 52);
            this.btn_Delete.TabIndex = 54;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Green;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.Location = new System.Drawing.Point(569, 693);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(152, 52);
            this.btn_Edit.TabIndex = 55;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Employee_DGV
            // 
            this.Employee_DGV.BackgroundColor = System.Drawing.Color.Silver;
            this.Employee_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_DGV.Location = new System.Drawing.Point(206, 209);
            this.Employee_DGV.Name = "Employee_DGV";
            this.Employee_DGV.RowHeadersWidth = 51;
            this.Employee_DGV.RowTemplate.Height = 28;
            this.Employee_DGV.Size = new System.Drawing.Size(826, 305);
            this.Employee_DGV.TabIndex = 56;
            this.Employee_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employee_DGV_CellContentClick);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 773);
            this.Controls.Add(this.Employee_DGV);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.EPassword_Tb);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ENameTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EPassword_Tb;
        private System.Windows.Forms.Label Employee_Label;
        private System.Windows.Forms.Label Login_lbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ENameTb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridView Employee_DGV;
    }
}