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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BLOOD_BANK
{
    public partial class Blood_Transfert : Form
    {
        public Blood_Transfert()
        {
            InitializeComponent();
            fillPatientCb();
        }

        SqlConnection con = new SqlConnection(@"Data Source=Rushikesh1999;Initial Catalog=""Blood Bank Management System"";Integrated Security=True");


        private void fillPatientCb()
        {
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select P_num from Patient_Table_1", con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("P_Num", typeof(int));
                dt.Load(rdr);
                PatientID_Cb.ValueMember = "P_Num";
                PatientID_Cb.DataSource = dt;
                con.Close();
            }
        }


        private void Getdata()
        {
            //helps to get the blood group and name of the patient

            con.Open();
            string query = "select * from Patient_Table_1 where P_Num=" + PatientID_Cb.SelectedValue.ToString() + "";

            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                PName_Tb.Text = dr["P_Name"].ToString();
                Blood_Group_Tb.Text = dr["P_Blood_Group"].ToString();
            }

            con.Close();
        }

        int stock=0;
        private void GetStock(string BGroup)
        {
            //helps to get the actual stock of blood based on particular blood group

            con.Open();
            string query = "select * from Blood_Table_1 where Blood_Group='"+ BGroup+"'";

            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["B_Stock"].ToString());
            }

            con.Close();
        }


        private void Blood_Transfert_Load(object sender, EventArgs e)
        {

        }

        private void PatientID_Cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Getdata();
            GetStock(Blood_Group_Tb.Text);
            if (stock > 0)
            {
                btn_Transfert.Visible = true;
                Availabel_lbl.Text = "Available stock";
                Availabel_lbl.Visible = true;

                
            }
            else
            {
                Availabel_lbl.Text = "Available Stock";
                btn_Transfert.Visible = true;
            }
            
        }

        private void Patient_lbl_Click(object sender, EventArgs e)
        {
            Patients pat = new Patients();
            pat.Show();
            this.Hide();

        }

        private void Reset()
        {
            PName_Tb.Text = "";
            Blood_Group_Tb.Text = "";
            Availabel_lbl.Visible = false;
            btn_Transfert.Visible=false;
        }

        private void UpdateStock()
        {
            int newstock = stock - 1;

            try
            {
                string query = "Update Blood_Table_1 set B_Stock=" + newstock + "where Blood_Group='"+Blood_Group_Tb.Text+"';";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Patient information updated successfully");
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Transfert_Click(object sender, EventArgs e)
        {
            if (PName_Tb.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into Transfer_Table values('" + PName_Tb.Text + "','" + Blood_Group_Tb.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Transfer");
                    con.Close();
                    GetStock(Blood_Group_Tb.Text);
                    UpdateStock();
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Blood_Stock_lbl_Click(object sender, EventArgs e)
        {
            Blood_Stock Bstock=new Blood_Stock();
            Bstock.Show();
            this.Hide();

        }

        private void donate_lbl_Click(object sender, EventArgs e)
        {
            Donate_Blood donate_Blood = new Donate_Blood();
            donate_Blood.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor donor=new Donor();
            donor.Show();
            this.Hide();
        }

        private void ViewDonor_lbl_Click(object sender, EventArgs e)
        {
            View_Donors donor=new View_Donors();
            donor.Show();
            this.Hide();
        }

        private void viewPatient_lbl_Click(object sender, EventArgs e)
        {
            View_Patient_Form2 vp=new View_Patient_Form2();
            vp.Show();
            this.Hide();
        }

        private void BloodTransfer_lbl_Click(object sender, EventArgs e)
        {
            Blood_Transfert bt=new Blood_Transfert();
            bt.Show();
            this.Hide();
        }

        private void Dashboard_lbl_Click(object sender, EventArgs e)
        {
            Dashboard dashboard=new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Logout_lbl_Click(object sender, EventArgs e)
        {
            Login log=new Login();
            log.Show();
            this.Hide();
        }
    }
}
