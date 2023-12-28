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
    public partial class Blood_Stock : Form
    {
        public Blood_Stock()
        {
            InitializeComponent();
            BloodStock();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Rushikesh1999;Initial Catalog=""Blood Bank Management System"";Integrated Security=True");
       

        private void BloodStock()
        {
            con.Open();
            string Query = "select * from Blood_Table_1";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            Blood_Stock_DGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void Blood_Stock_Load(object sender, EventArgs e)
        {

        }

        private void Blood_Stock_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Blood_Transfert_lbl_Click(object sender, EventArgs e)
        {
            Blood_Transfert Bt= new Blood_Transfert();
            Bt.Show();
            this.Hide();
        }

        private void Donor_lbl_Click(object sender, EventArgs e)
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

        private void View_Patients_lbl_Click(object sender, EventArgs e)
        {
            View_Donors donor = new View_Donors();
            donor.Show();
            this.Hide();
        }

        private void Patients_lbl_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            this.Hide();
        }

        private void View_Patient_lbl_Click(object sender, EventArgs e)
        {
            View_Patient_Form2 donor = new View_Patient_Form2();
            donor.Show();
            this.Hide();
        }

        private void Blood_stock_lbl_Click(object sender, EventArgs e)
        {
            Blood_Stock blood_Stock = new Blood_Stock();
            blood_Stock.Show();
            this.Hide();
        }

        private void Dashboard_lbl_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Logout_lbl_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
