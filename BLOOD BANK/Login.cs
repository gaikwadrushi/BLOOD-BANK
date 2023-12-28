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

namespace BLOOD_BANK
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Rushikesh1999;Initial Catalog=""Blood Bank Management System"";Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ContinueasAdmin_lbl_Click(object sender, EventArgs e)
        {
            Admin_Login Adm = new Admin_Login();
            Adm.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Employee_Table where Emp_Id='" + Emp_Id_Tb.Text + "' and Emp_Pass='" + Emp_Pass_Tb.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Main_Form Main = new Main_Form();
                Main.Show();
                this.Hide();
                con.Close();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password");

            }
            con.Close();
        }

        private void Exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
