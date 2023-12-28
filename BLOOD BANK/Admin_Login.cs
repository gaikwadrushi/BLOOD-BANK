using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLOOD_BANK
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
           if(Admin_Pass_Tb.Text=="")
            {
                MessageBox.Show("Enter the Admin Password");
            }
           else if(Admin_Pass_Tb.Text=="Password")
            {
                Employee Emp = new Employee();
                Emp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password contact the system Admin");
                Admin_Pass_Tb.Text = "";
            }
        }

        private void Cancel_lbl_Click(object sender, EventArgs e)
        {
            Login log=new Login();
            log.Show(); 
            this.Hide();
            
        }

        private void Exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
