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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Logout_lbl_Click(object sender, EventArgs e)
        {
            Login log=new Login();
            log.Show();
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

        private void View_Donors_lbl_Click(object sender, EventArgs e)
        {
            View_Donors vp=new View_Donors();
            vp.Show();
            this.Hide();
        }

        private void Patients_lbl_Click(object sender, EventArgs e)
        {
            Patients pat=new Patients();
            pat.Show();
            this.Hide();
        }

        private void View_Patients_lbl_Click(object sender, EventArgs e)
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
            Blood_Transfert transfer = new Blood_Transfert();
            transfer.Show();
            this.Hide();
        }

        private void Dashboard_lbl_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
    }

