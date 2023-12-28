using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.ComponentModel.Design;

namespace BLOOD_BANK
{
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }
        SqlConnection con= new SqlConnection(@"Data Source=Rushikesh1999;Initial Catalog=""Blood Bank Management System"";Integrated Security=True");
        private void Reset()
        {
            DNameTb.Text = "";
            DAgeTb.Text = "";
            DGenderCb.SelectedIndex = -1;
            DPhoneTb.Text = "";
            DAddressTb.Text = "";
            DBloodGroupCb.SelectedIndex = -1;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DNameTb.Text) || string.IsNullOrEmpty(DAgeTb.Text) || DGenderCb.SelectedIndex == -1 || DBloodGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    using (var db = new Blood_Bank_Management_SystemEntities()) // Replace YourDbContext with your actual DbContext class
                    {
                        Donor_Table_1 donor = new Donor_Table_1
                        {
                            D_Name = DNameTb.Text,
                            D_Age = Convert.ToInt32(DAgeTb.Text),
                            D_Gender = DGenderCb.SelectedItem.ToString(),
                            D_Phone = DPhoneTb.Text,
                            D_Address = DAddressTb.Text,
                            D_Blood_Group = DBloodGroupCb.SelectedItem.ToString()
                        };

                        db.Donor_Table_1.Add(donor);
                        db.SaveChanges();

                        MessageBox.Show("Donor information saved successfully");
                        Reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }




        }

        private void Donor_Load(object sender, EventArgs e)
        {

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

        private void Blood_Tranfer_lbl_Click(object sender, EventArgs e)
        {
            Blood_Transfert blood_Transfert = new Blood_Transfert();
            blood_Transfert.Show();
            this.Hide();
        }

        private void Dashboard_lbl_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void loglout_lbl_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
