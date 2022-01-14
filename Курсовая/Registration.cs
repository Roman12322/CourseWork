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
using System.Configuration;


namespace Курсовая
{
    public partial class Registration : Form
    {
        private SqlConnection sqlConnection = null;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Datas"].ConnectionString);
            sqlConnection.Open();
        }
        private void InsertData()
        {
            SqlCommand insert = new SqlCommand($"INSERT INTO [DATA] (Login, Password) VALUES (@Login, @Password)",sqlConnection);
            insert.Parameters.AddWithValue("Login", RegLogBox.Text);
            insert.Parameters.AddWithValue("Password", RegPassBox.Text);
            insert.ExecuteNonQuery();
        }
        private bool CheckAlreadyRegUsers()
        {
            bool nextStep;
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM DATA WHERE Login = @login AND Password = @password", sqlConnection);
            sqlCommand.Parameters.AddWithValue("Login", RegLogBox.Text);
            sqlCommand.Parameters.AddWithValue("Password", RegPassBox.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                RegLogBox.BackColor = Color.LightCoral;
                RegPassBox.BackColor = Color.LightCoral;
                MessageBox.Show("User already exist");
                nextStep = false;
                reader.Close();
                return nextStep;
            }
            else
            {
                reader.Close();
                nextStep = true;
                return nextStep;
            }
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            bool Check= CheckAlreadyRegUsers();
            if(RegLogBox.Text.Length>8 && RegPassBox.Text.Length>8 && RegPassBox.Text==RegRepBox.Text && Check==true)
            {
                InsertData();
                RegLogBox.BackColor = Color.LightGreen;
                RegPassBox.BackColor = Color.LightGreen;
                RegRepBox.BackColor = Color.LightGreen;
                MessageBox.Show("User signed up successfully");
                Authorization authorization = new Authorization();
                authorization.Show();
                this.Close();
            }
            else
            {
                RegLogBox.BackColor = Color.LightPink;
                RegPassBox.BackColor = Color.LightPink;
                RegRepBox.BackColor = Color.LightPink;
                MessageBox.Show("Incorrect input, please try again");
            }
        }
    }
}
