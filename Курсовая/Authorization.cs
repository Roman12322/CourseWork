using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Authorization : Form
    {
        private SqlConnection connection = null;
        public Authorization()
        {
            InitializeComponent();
        }
        private void Authorization_Load(object sender, EventArgs e)
        { 
        }
        private void SelectSQL()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Datas"].ConnectionString);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM DATA WHERE Login = @login AND Password = @password", connection);
            sqlCommand.Parameters.AddWithValue("Login", AuthLogBox.Text);
            sqlCommand.Parameters.AddWithValue("Password", AuthPassBox.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                AuthLogBox.BackColor = Color.LightGreen;
                AuthPassBox.BackColor = Color.LightGreen;
                
                var calc = new Calculator();
                calc.Show();
            }
            else
            {
                AuthLogBox.BackColor = Color.LightPink;
                AuthPassBox.BackColor = Color.LightPink;
                MessageBox.Show("Incorrect input");
            }
        }


        private void CreateAcc_Click(object sender, EventArgs e)
        {
            
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            SelectSQL();
        }
    }
}
