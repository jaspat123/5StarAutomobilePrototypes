using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CustomerInformation
{
    public partial class Form1 : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        int results;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (txtCusName.Text == "" || txtEmail.Text == "" || txtAddSt.Text == "" || txtCity.Text == "" || txtProv.Text == "" || txtPostCode.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please enter missing fields");
                return;
            }

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\temp\Jasmine\CustomerEntry\CustomerInformation\Data.mdf;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Customerdb (CustomerName,EmailAddress,AddressStreet,City,Province,PostalCode,PhoneNumber) VALUES (@CustomerName,@EmailAddress,@AddressStreet,@City,@Province,@PostalCode,@PhoneNumber)", con);
            cmd.Parameters.AddWithValue("@CustomerName", txtCusName.Text);
            cmd.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
            cmd.Parameters.AddWithValue("@AddressStreet", txtAddSt.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@Province", txtProv.Text);
            cmd.Parameters.AddWithValue("@PostalCode", txtPostCode.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
            results = cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been inputed.");
           
       }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
