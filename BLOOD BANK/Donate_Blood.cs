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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BLOOD_BANK
{
    public partial class Donate_Blood : Form
    {
        public Donate_Blood()
        {
            InitializeComponent();
            Populate();
            BloodStock();
        }

        SqlConnection con = new SqlConnection(@"Data Source=Rushikesh1999;Initial Catalog=""Blood Bank Management System"";Integrated Security=True");
        private void Populate()
        {
            con.Open();
            string Query = "select * from Donor_Table_1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Donate_List_DGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void BloodStock()
        {
            con.Open();
            string Query = "select * from Blood_Table_1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BloodStock_DGV.DataSource = ds.Tables[0];
            con.Close();

        }

        

        private void Donate_Blood_Load(object sender, EventArgs e)
        {
            
            
            
        }

        int oldstock;
        private void GetStock(string Bgroup)
        {
            //Helps to get actual stock of blood based on particular blood group

            con.Open();
            string query = "select * from Blood_Table_1 where Blood_Group='" + Bgroup + "'";
            SqlCommand cmd= new SqlCommand(query,con);
            DataTable dt=new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                oldstock = Convert.ToInt32(dt.Rows[0]["B_Stock"]);
            }

            con.Close();
        }
        private void Donor_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
        private void Reset()
        {
            DNameTb.Text = "";
            DBlood_GroupTb.Text = "";
        }
        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(DNameTb.Text==" ")
            {
                MessageBox.Show("Select a Donor");
            }
            else
            {
                try
                {
                    int stock=oldstock + 1 ;
                    string query = "update Blood_Table_1 set B_Stock =" + stock + " where Blood_Group='" + DBlood_GroupTb.Text + "';";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation successfully");
                    con.Close();
                    Reset();
                    BloodStock();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Donor_Label_Click(object sender, EventArgs e)
        {
            Donor donor=new Donor();
            donor.Show();
            this.Hide();
        }

        private void View_Donors_Label_Click(object sender, EventArgs e)
        {
            View_Donors view_Donors = new View_Donors();
            view_Donors.Show();
            this.Hide();
        }

        private void Donate_Label_Click(object sender, EventArgs e)
        {
            Donate_Blood donate_Blood = new Donate_Blood();
            donate_Blood.Show();
            this.Hide();
        }

        private void Patient_Label_Click(object sender, EventArgs e)
        {
            Patients Patients = new Patients();
            Patients.Show();
            this.Hide();
        }

        private void View_Patient_Label_Click(object sender, EventArgs e)
        {
            View_Patient_Form2 view_Patient_Form2 = new View_Patient_Form2();
            view_Patient_Form2.Show();
            this.Hide();
        }

        private void Blood_Stock_Label_Click(object sender, EventArgs e)
        {
            Blood_Stock blood_Stock = new Blood_Stock();
            blood_Stock.Show();
            this.Hide();
        }

        private void Blood_Transfert_Label_Click(object sender, EventArgs e)
        {
            Blood_Transfert blood_Transfert = new Blood_Transfert();
            blood_Transfert.Show();
            this.Hide();
        }

        private void Dashboard_Label_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Donate_List_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = Donate_List_DGV.CurrentRow;

            if (selectedRow != null)
            {
                DNameTb.Text = selectedRow.Cells[1].Value.ToString();
                DBlood_GroupTb.Text = selectedRow.Cells[6].Value.ToString();

            }

            GetStock(DBlood_GroupTb.Text);
        }
    }
}
