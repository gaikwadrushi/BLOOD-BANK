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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=Rushikesh1999;Initial Catalog=""Blood Bank Management System"";Integrated Security=True");

        private void Reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PPhoneTb.Text = "";
            PGenderCb.SelectedIndex = -1;
            PBlood_GroupCb.SelectedIndex = -1;
            PAddressTb.Text = "";
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PNameTb.Text) || string.IsNullOrEmpty(PAgeTb.Text) || PGenderCb.SelectedIndex == -1 || PBlood_GroupCb.SelectedIndex == -1 || string.IsNullOrEmpty(PAddressTb.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    using (var db = new Blood_Bank_Management_SystemEntities()) // Replace YourDbContext with your actual DbContext class
                    {
                        Patient_Table_1 patient = new Patient_Table_1
                        {
                            P_Name = PNameTb.Text,
                            P_Age = Convert.ToInt32(PAgeTb.Text),
                            P_Phone = PPhoneTb.Text,
                            P_Gender = PGenderCb.SelectedItem.ToString(),
                            P_Blood_Group = PBlood_GroupCb.SelectedItem.ToString(),
                            P_Address = PAddressTb.Text
                        };

                        db.Patient_Table_1.Add(patient);
                        db.SaveChanges();

                        MessageBox.Show("Patient information saved successfully");
                        Reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {
            View_Patient_Form2 vp=new View_Patient_Form2();
            vp.Show();
            this.Hide();
            
        }

        private void Blood_Transfer_lbl_Click(object sender, EventArgs e)
        {
            Blood_Transfert Bt=new Blood_Transfert();
            Bt.Show();
            this.Hide();

        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Donate_Blood donate_Blood = new Donate_Blood();
            donate_Blood.Show();
            this.Hide();
        }

        private void Donor_lbl_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void View_Donors_lbl_Click(object sender, EventArgs e)
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

        private void Blood_Stock_lbl_Click(object sender, EventArgs e)
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
