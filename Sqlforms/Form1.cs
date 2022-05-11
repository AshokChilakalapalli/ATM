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

namespace Sqlforms
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=LAPTOP-NGQ1FVG1;Initial Catalog=cyient;Integrated Security=True");
            cn.Open();
            getAllEmployees();
            //btnupddate.Enabled = false;
           // btndelete.Enabled = false;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            insetEmployees();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            deleteEmployees();
        }
        public void getAllEmployees()
        {
            cmd = new SqlCommand("getemployees",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmployees.DataSource = dt;

        }
        public void insetEmployees()
        {
            if (txtfirstname.Text =="")
                MessageBox.Show("Firstname Required");
            else if (txtlastname.Text == "")
                MessageBox.Show("Lastname Required");
            else if (txtempaddress.Text == "")
                MessageBox.Show("Address Required");
            else if (txtmobilenumber.Text == "")
                MessageBox.Show("MobileNo. Required");
            else if (txtsalary.Text == "")
                MessageBox.Show("Salary Required");
            else if (txtjoiningddate.Text == "")
                MessageBox.Show("Joiningdate Required");
            else 

            cmd = new SqlCommand("insertemployees", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
            cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
            cmd.Parameters.AddWithValue("@EmpAddress", txtempaddress.Text);
            cmd.Parameters.AddWithValue("@MobileNumber", txtmobilenumber.Text);
            cmd.Parameters.AddWithValue("@Salary", txtsalary.Text);
            cmd.Parameters.AddWithValue("@joiningdate", txtjoiningddate.Text);
            
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Successfully Inserted");
            getAllEmployees();
            //btnupddate.Enabled = true;
           // btndelete.Enabled = true;
            


        }

        public void deleteEmployees()
        {
            cmd = new SqlCommand("deleteemployees", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeId", int.Parse(txtemployeeid.Text));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Successfully Deleted");
            getAllEmployees();
        }

        private void btnupddate_Click(object sender, EventArgs e)
        {

        }
    }
}
