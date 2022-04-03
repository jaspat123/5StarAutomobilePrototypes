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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\temp\Jasmine\CustomerInformation\Data.mdf;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Customerdb (CustomerName,EmailAddress,AddressStreet,City,Province,PostalCode,PhoneNumber) VALUES (@CustomerName,@EmailAddress,@AddressStreet,@City,@Province,@PostalCode,@PhoneNumber)",con);
            cmd.Parameters.Add("@CustomerName", txtCusName.Text);
            cmd.Parameters.Add("@EmailAddress", txtEmail.Text);
            cmd.Parameters.Add("@AddressStreet", txtAddSt.Text);
            cmd.Parameters.Add("@City", txtCity.Text);
            cmd.Parameters.Add("@Province", txtProv.Text);
            cmd.Parameters.Add("@PostalCode", txtPostCode.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
            cmd.ExecuteNonQuery();

            if (true)
            {
                MessageBox.Show("Your data has been inputed.");
            }
            else
            {
                MessageBox.Show("Please check your information and try again.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
