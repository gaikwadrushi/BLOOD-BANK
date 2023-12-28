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
    public partial class View_Donors : Form
    {
        public View_Donors()
        {
            InitializeComponent();
            Populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Rushikesh1999;Initial Catalog=""Blood Bank Management System"";Integrated Security=True");
        private void Populate()
        {
            con.Open();
            string Query = "select * from Donor_Table_1";
            SqlDataAdapter adapter = new SqlDataAdapter(Query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            Donor_DGV.DataSource = ds.Tables[0];
            con.Close();
            
        }

        private void View_Donors_Load(object sender, EventArgs e)
        {

        }

        private void Donor_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Donor_lbl_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void Donoe_lbl_Click(object sender, EventArgs e)
        {
            Donate_Blood donate_Blood = new Donate_Blood();
            donate_Blood.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            View_Donors view_Donors = new View_Donors();
            view_Donors.Show();
            this.Hide();
        }

        private void Patient_lbl_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            this.Hide();
        }

        private void View_Patient_lbl_Click(object sender, EventArgs e)
        {
            View_Patient_Form2 view_Patient_Form2 = new View_Patient_Form2();
            view_Patient_Form2.Show();
            this.Hide();
        }

        private void Blood_Stock_lbl_Click(object sender, EventArgs e)
        {
            Blood_Stock blood_Stock = new Blood_Stock();
            blood_Stock.Show();
            this.Hide();
        }

        private void Blood_Transfer_lbl_Click(object sender, EventArgs e)
        {
            Blood_Transfert blood_Transfert = new Blood_Transfert();
            blood_Transfert.Show();
            this.Hide();
        }

        private void Dashboard_lbl_Click(object sender, EventArgs e)
        {
            Dashboard dashboard=new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void logout_lbl_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
