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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            GetData();
        }

        SqlConnection con = new SqlConnection(@"Data Source=Rushikesh1999;Initial Catalog=""Blood Bank Management System"";Integrated Security=True");
         
        private void GetData()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Donor_Table_1 ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Donor_lbl.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1= new SqlDataAdapter("select count(*) from Transfer_Table ", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Transfer_lbl.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from Employee_Table ", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Employee_lbl.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from Blood_Table_1 ", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            int B_Stock = Convert.ToInt32(dt3.Rows[0][0].ToString());
            Total_lbl.Text ="" + B_Stock;

            SqlDataAdapter sda4 = new SqlDataAdapter("select B_Stock from Blood_Table_1 where Blood_Group= 'O+';", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            OPlus_lbl.Text = dt4.Rows[0][0].ToString(); 


            SqlDataAdapter sda5 = new SqlDataAdapter("select B_Stock from Blood_Table_1 where Blood_Group= 'O-';", con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            O_negative_lbl.Text = dt5.Rows[0][0].ToString();

            SqlDataAdapter sda6 = new SqlDataAdapter("select B_Stock from Blood_Table_1 where Blood_Group= 'AB+';", con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            AB_Positive_lbl.Text = dt6.Rows[0][0].ToString();


            SqlDataAdapter sda7 = new SqlDataAdapter("select B_Stock from Blood_Table_1 where Blood_Group= 'AB-';", con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            AB_Negative_lbl.Text = dt7.Rows[0][0].ToString();




            con.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dashboardlbl_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void donorlbl_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void Donate_lbl_Click(object sender, EventArgs e)
        {
            Donate_Blood donate_Blood = new Donate_Blood();
            donate_Blood.Show();
            this.Hide();
        }

        private void view_patients_lbl_Click(object sender, EventArgs e)
        {
            View_Donors vd = new View_Donors();
            vd.Show();
            this.Hide();
        }

        private void patients_lbl_Click(object sender, EventArgs e)
        {
            Patients p = new Patients();
            p.Show();
            this.Hide();
        }

        private void VPlbl_Click(object sender, EventArgs e)
        {
            View_Patient_Form2 view_Patient_Form2 = new View_Patient_Form2();
            view_Patient_Form2.Show();
            this.Hide();
        }

        private void BloodStocklbl_Click(object sender, EventArgs e)
        {
            Blood_Stock blood_Stock = new Blood_Stock();
            blood_Stock.Show();
            this.Hide();
        }

        private void BloodTransfertlbl_Click(object sender, EventArgs e)
        {
            Blood_Transfert bt=new Blood_Transfert();
            bt.Show();
            this.Hide();
        }

        private void logout_lbl_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Donor_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
