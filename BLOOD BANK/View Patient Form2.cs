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
    public partial class View_Patient_Form2 : Form
    {
        
        public View_Patient_Form2()
        {
            InitializeComponent();
            Populate();
        }

        SqlConnection con = new SqlConnection(@"Data Source=Rushikesh1999;Initial Catalog=""Blood Bank Management System"";Integrated Security=True");


        private void Populate()
        {
            con.Open();
            string Query = "select * from Patient_Table_1";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            View_Patients_DGV2.DataSource = ds.Tables[0];
            con.Close();

        }

        int key = 0;

        private void View_Patient_Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PAgeTb.Text == "" || PGenderCb.SelectedIndex == -1 || PBlood_GroupCb.SelectedIndex == -1 || PAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "Update Patient_Table_1 set P_Name='" + PNameTb.Text + "',P_Age='" + PAgeTb.Text + "',P_Phone='" + PPhoneTb.Text + "',P_Gender='" + PGenderCb.SelectedItem.ToString() + "',P_Blood_Group='" + PBlood_GroupCb.SelectedItem.ToString() + "',P_Address='" + PAddressTb.Text + "' where P_Num="+key+";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient information updated successfully");
                    con.Close();
                    Reset();
                    Populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PPhoneTb.Text = "";
            PGenderCb.SelectedIndex = -1;
            PBlood_GroupCb.SelectedIndex = -1;
            PAddressTb.Text = "";
            key = 0;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(key==0)
            {
                MessageBox.Show("Select the patient to delete");
            }
            else
            {
                try
                {
                    string query = "Delete from Patient_Table_1 where P_Num=" + key + ";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient information deleted successfully");
                    con.Close();
                    Reset();
                    Populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void View_Patients_DGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = View_Patients_DGV2.CurrentRow;

            if (selectedRow != null)
            {
                PNameTb.Text = selectedRow.Cells[1].Value.ToString();
                PAgeTb.Text = selectedRow.Cells[2].Value.ToString();
                PPhoneTb.Text = selectedRow.Cells[3].Value.ToString();
                PGenderCb.SelectedItem = selectedRow.Cells[4].Value.ToString();
                PBlood_GroupCb.SelectedItem = selectedRow.Cells[5].Value.ToString();
                PAddressTb.Text = selectedRow.Cells[6].Value.ToString();

                key = PNameTb.Text == "" ? 0 : Convert.ToInt32(selectedRow.Cells[0].Value);
            }

        }

        private void Patient_Label_Click(object sender, EventArgs e)
        {
            Patients pt = new Patients();
            pt.Show();
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

        private void View_Donor_lbl_Click(object sender, EventArgs e)
        {
            View_Donors vd=new View_Donors();
            vd.Show();
            this.Hide();
        }

        private void View_Patient_lbl_Click(object sender, EventArgs e)
        {
            View_Patient_Form2 vp=new View_Patient_Form2();
            vp.Show();
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
            Blood_Transfert bt=new Blood_Transfert();
            bt.Show();
            this.Hide();
        }

        private void dashboard_lbl_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
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
