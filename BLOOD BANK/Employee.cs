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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();

            Populate();
        }

        SqlConnection con = new SqlConnection(@"Data Source=Rushikesh1999;Initial Catalog=""Blood Bank Management System"";Integrated Security=True");
        

        private void Login_lbl_Click(object sender, EventArgs e)
        {
            Login log=new Login();
            log.Show();
            this.Hide();
        }

        private void Reset()
        {
            ENameTb.Text = "";
            EPassword_Tb.Text = "";
            key = 0;

        }


        private void Populate()
        {
            con.Open();
            string Query = "select * from Employee_Table";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            Employee_DGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ENameTb.Text == "" || EPassword_Tb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into Employee_Table values('" + ENameTb.Text + "','" + EPassword_Tb.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee information saved successfully");
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

        int key = 0;
        private void Employee_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = Employee_DGV.CurrentRow;

            if (selectedRow != null)
            {
                ENameTb.Text = selectedRow.Cells[1].Value.ToString();
                EPassword_Tb.Text = selectedRow.Cells[2].Value.ToString();
                
                key = ENameTb.Text == "" ? 0 : Convert.ToInt32(selectedRow.Cells[0].Value);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Employee to delete");
            }
            else
            {
                try
                {
                    string query = "Delete from Employee_Table where Emp_Num=" + key + ";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee information deleted successfully");
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (ENameTb.Text == "" || EPassword_Tb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "Update Employee_Table set Emp_Id='" + ENameTb.Text + "',Emp_Pass='" + EPassword_Tb.Text + "' where Emp_Num="+key+";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee information updated successfully");
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
    }
}
