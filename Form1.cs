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
using System.Data.Common;

namespace Crud_test
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            LoadEmployee();
            bttnrefresh.Enabled = true;
        }
        public void LoadEmployee()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LUTFUL-KABIR\\SQLEXPRESS;database=Crud_test;Integrated Security=True";
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm=new SqlCommand("select * from tblCrud",cn);
            try
            {
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(dr["Employeeid"].ToString(),i, dr["FirstName"].ToString(), dr["MiddleName"].ToString(), dr["LastName"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "failed to retrive data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
            dataGridView1.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtfirstname.Enabled = false;   
            txtlastname.Enabled = false;
            txtmiddlename.Enabled = false;  
            bttnedit.Enabled = false;
            bttndel.Enabled = false;
            bttninsert.Enabled = false;
            bttnupdate.Enabled = false;      
            //dataGridView1.Enabled = false;
            radempid.Checked = true;
        }
        private void bttnaddnew_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            txtfirstname.Enabled = true;
            txtlastname.Enabled = true;
            txtmiddlename.Enabled = true;
            bttninsert.Enabled = true;
            dataGridView1.ClearSelection();

            txtfirstname.Clear();
            txtlastname.Clear();
            txtmiddlename.Clear();
            txtemployeeid.Clear();

            bttnedit.Enabled = false;
            bttnupdate.Enabled = false;
            bttndel.Enabled = false; 
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Clear()
        { 
            txtfirstname.Clear();
            txtlastname.Clear();
            txtmiddlename.Clear();
            txtemployeeid.Clear();

            txtfirstname.Enabled = false;
            txtlastname.Enabled = false;
            txtmiddlename.Enabled = false;
        }
        private void bttninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to save this record? ","System Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    SqlConnection cn=new SqlConnection();
                    cn.ConnectionString= "Data Source=LUTFUL-KABIR\\SQLEXPRESS;database=Crud_test;Integrated Security=True";
                    SqlCommand cm=new SqlCommand();
                    cm.Connection = cn;
                    cn.Open();
                    cm=new SqlCommand("insert into tblCrud (FirstName,MiddleName,LastName) values(@FirstName,@MiddleName,@LastName)",cn);
                    cm.Parameters.AddWithValue("@FirstName",txtfirstname.Text);
                    cm.Parameters.AddWithValue("@MiddleName",txtmiddlename.Text);
                    cm.Parameters.AddWithValue("@LastName",txtlastname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.","System Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Clear();
                    LoadEmployee();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"System Message",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            }
        }
        private void txtsearchname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsearchname_Click(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbllastname_Click(object sender, EventArgs e)
        {

        }

        private void txtmiddlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblmiddlename_Click(object sender, EventArgs e)
        {

        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblfirstname_Click(object sender, EventArgs e)
        {

        }

        private void txtemployeeid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblemployeeid_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bttnedit.Enabled=true;
            bttndel.Enabled=true;
            bttnupdate.Enabled=false;
            bttninsert.Enabled=false;
        }

        private void bttnedit_Click(object sender, EventArgs e)
        {
            txtemployeeid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtfirstname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtmiddlename.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtlastname.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            bttnupdate.Enabled = true;
            bttnedit.Enabled = false;
            bttndel.Enabled = true;

            txtfirstname.Enabled = true;
            txtmiddlename.Enabled = true;
            txtlastname.Enabled = true;
        }

        private void bttnupdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this record?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection();
                    cn.ConnectionString = "Data Source=LUTFUL-KABIR\\SQLEXPRESS;database=Crud_test;Integrated Security=True";
                    SqlCommand cm = new SqlCommand();
                    cm.Connection = cn;

                    cn.Open();
                    cm = new SqlCommand("update tblCrud set FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName where Employeeid = @Employeeid", cn);
                    cm.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                    cm.Parameters.AddWithValue("@MiddleName", txtmiddlename.Text);
                    cm.Parameters.AddWithValue("@LastName", txtlastname.Text);
                    cm.Parameters.AddWithValue("@Employeeid", txtemployeeid.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    LoadEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttndel_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string employeeId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    using (SqlConnection cn = new SqlConnection("Data Source=LUTFUL-KABIR\\SQLEXPRESS;database=Crud_test;Integrated Security=True"))
                    {
                        cn.Open();
                        using (SqlCommand cm = new SqlCommand("DELETE FROM tblCrud WHERE Employeeid = @Employeeid", cn))
                        {
                            cm.Parameters.AddWithValue("@Employeeid", employeeId);
                            cm.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Record has been successfully deleted.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployee(); // Refresh the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttnsearch_Click_1(object sender, EventArgs e)
        {
            string searchName = txtsearchname.Text.Trim();
            string val = "";
                if (!string.IsNullOrEmpty(searchName))
                {
                    if (radempid.Checked)
                    {
                        val = "Employeeid";
                    }
                    else if (radfirstname.Checked)
                    {
                        val = "FirstName";
                    }
                    SqlConnection cn = new SqlConnection();
                    cn.ConnectionString = "Data Source=LUTFUL-KABIR\\SQLEXPRESS;database=Crud_test;Integrated Security=True";
                    SqlCommand cm = new SqlCommand();
                    cm.Connection = cn;

                    int i = 0;
                    dataGridView1.Rows.Clear();
                    cn.Open();
                    cm = new SqlCommand($"SELECT * FROM tblCrud WHERE {val} LIKE {searchName}", cn);
                    try
                    {
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {

                            dataGridView1.Rows.Add(dr["Employeeid"].ToString(), dr["FirstName"].ToString(), dr["MiddleName"].ToString(), dr["LastName"].ToString());
                        }
                        dr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "failed to retrive data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.Close();
                    }
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Please enter a name or ID to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void radempid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radfirstname_CheckedChanged(object sender, EventArgs e)
        {
            if (radfirstname.Checked)
            {
                // Perform any additional actions needed when radfirstname is selected
                MessageBox.Show("First Name radio button selected.");
            }
        }
        private void bttnrefresh_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }
    }
}
