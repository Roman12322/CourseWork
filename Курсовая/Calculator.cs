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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using static System.Net.WebRequestMethods;

namespace Курсовая
{
    public partial class Calculator : Form
    {
        private SqlConnection sqlConnection = null;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Datas"].ConnectionString);
            sqlConnection.Open();
        }
        private void FirstCalcUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45)
            {
                e.Handled = true;
            }
        }
        private void SecondCalcUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45)
            {
                e.Handled = true;
            }
        }
        private void FirstCalcDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45)
            {
                e.Handled = true;
            }
        }
        private void SecondCalcDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45)
            {
                e.Handled = true;
            }
        }
        public void IncorrectInput()
        {
            MessageBox.Show("Incorrect Input");
            FirstCalcUp.BackColor = Color.LightCoral;
            SecondCalcUp.BackColor = Color.LightCoral;
            FirstCalcDown.BackColor = Color.LightCoral;
            SecondCalcDown.BackColor = Color.LightCoral;
            AnsBoxUp.BackColor = Color.LightCoral;
            AnsBoxDwn.BackColor = Color.LightCoral;
        }
        public void correctInput()
        {
            FirstCalcUp.BackColor = Color.LightGreen;
            SecondCalcUp.BackColor = Color.LightGreen;
            FirstCalcDown.BackColor = Color.LightGreen;
            SecondCalcDown.BackColor = Color.LightGreen;
            AnsBoxUp.BackColor = Color.LightGreen;
            AnsBoxDwn.BackColor = Color.LightGreen;
        }
        private void CalcButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Image.FromFile("C:\\Users\\megaf\\OneDrive\\Рабочий стол\\Projects\\Summing.png");
            var calc = new Calculations();
            string checkCorrectData = calc.CalcSum(FirstCalcUp.Text, FirstCalcDown.Text, SecondCalcUp.Text, SecondCalcDown.Text);
            if (checkCorrectData!=" " || FirstCalcUp.Text!="" || SecondCalcUp.Text != "" || FirstCalcDown.Text != "" || FirstCalcDown.Text != "0"
                || SecondCalcDown.Text != "" || SecondCalcDown.Text != "0")
            {
                IncorrectInput();
            }
            else
            {
                AnsBoxUp.Text = calc.CalcSum(FirstCalcUp.Text, FirstCalcDown.Text, SecondCalcUp.Text, SecondCalcDown.Text);
                AnsBoxDwn.Text = calc.CalcAnsDWN(FirstCalcDown.Text, SecondCalcDown.Text);
                correctInput();
                Draw();
                InsertData();
            }
        }
        private void TakingOff_Click(object sender, EventArgs e)
        {
            PictureBox.Image = Image.FromFile("C:\\Users\\megaf\\OneDrive\\Рабочий стол\\Projects\\TakeOff.png");
            var calc = new Calculations();
            string checkCorrectData = calc.CalcTakeOff(FirstCalcUp.Text, FirstCalcDown.Text, SecondCalcUp.Text, SecondCalcDown.Text);
            if (checkCorrectData != " " || FirstCalcUp.Text != "" || SecondCalcUp.Text != "" || FirstCalcDown.Text != "" || FirstCalcDown.Text != "0"
                || SecondCalcDown.Text != "" || SecondCalcDown.Text != "0")
            {
                IncorrectInput();
            }
            else
            {
                AnsBoxUp.Text = calc.CalcTakeOff(FirstCalcUp.Text, FirstCalcDown.Text, SecondCalcUp.Text, SecondCalcDown.Text);
                AnsBoxDwn.Text = calc.CalcAnsDWN(FirstCalcDown.Text, SecondCalcDown.Text);
                correctInput();
                Draw();
                InsertData();
            }
        }
        private void InsertData()
        {
            SqlCommand insert = new SqlCommand($"INSERT INTO [CALCULATIONS] (FirstElementUp, SecondElementUp, FirstElementDown, SecondElementDown, AnsUp, AnsDown)" +
                $" VALUES (@FirstElementUp, @SecondElementUp, @FirstElementDown, @SecondElementDown, @AnsUp, @AnsDown)", sqlConnection);
            insert.Parameters.AddWithValue("FirstElementUp", FirstCalcUp.Text);
            insert.Parameters.AddWithValue("SecondElementUp", SecondCalcUp.Text);
            insert.Parameters.AddWithValue("FirstElementDown", FirstCalcDown.Text);
            insert.Parameters.AddWithValue("SecondElementDown", SecondCalcDown.Text);
            insert.Parameters.AddWithValue("AnsUp", AnsBoxUp.Text);
            insert.Parameters.AddWithValue("AnsDown", AnsBoxDwn.Text);
            insert.ExecuteNonQuery();
        }
        private void Draw()
        {
            Graphics sometext = Graphics.FromImage(PictureBox.Image);
            PictureBox.Invalidate();
            Controls.Add(PictureBox);
            sometext.DrawString(FirstCalcUp.Text, new Font("Arial", 20), Brushes.Red, new PointF(80, 50));
            sometext.DrawString(FirstCalcDown.Text, new Font("Arial", 20), Brushes.Red, new PointF(95, 180));
            sometext.DrawString(SecondCalcUp.Text, new Font("Arial", 20), Brushes.Red, new PointF(270, 50));
            sometext.DrawString(SecondCalcDown.Text, new Font("Arial", 20), Brushes.Red, new PointF(270, 180));
            sometext.DrawString(AnsBoxUp.Text, new Font("Arial", 20), Brushes.Red, new PointF(590, 100));
            sometext.DrawString(AnsBoxDwn.Text, new Font("Arial", 20), Brushes.Red, new PointF(590, 180));
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save picture";
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files(*.*)|*.*";
                if (sfd.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        PictureBox.Image.Save(sfd.FileName);
                    }
                    catch 
                    {
                        MessageBox.Show("Unable to save");
                    }
                }
            }
        }
        

    }
    public class Calculations
    {
        public string CalcSum(string FEP, string FED, string SEP, string SED)
        {
            string ansup= " ";
            try
            {
                int fep = Convert.ToInt32(FEP); int fed = Convert.ToInt32(FED); int sep = Convert.ToInt32(SEP); int sed = Convert.ToInt32(SED);
                if (FEP == "" || SEP == "" || FED == "" || FED == "0" || SED == "" || SED == "0")
                {

                }
                else
                {
                    int AEP = ((fep * sed) + (sep * fed));
                    ansup = AEP.ToString();
                }
            }
            catch (Exception)
            {
                
            }
            return ansup;
        }
        public string CalcTakeOff(string FEP, string FED, string SEP, string SED)
        {
            string ansup = " ";
            try
            {
                int fep = Convert.ToInt32(FEP); int fed = Convert.ToInt32(FED); int sep = Convert.ToInt32(SEP); int sed = Convert.ToInt32(SED);
                if (FEP == "" || SEP == "" || FED == "" || FED == "0" || SED == "" || SED == "0")
                {

                }
                else
                {
                    int AEP = ((fep * sed) - (sep * fed));
                    ansup = AEP.ToString();
                }
            }
            catch (Exception)
            {

            }
            return ansup;
        }
        public string CalcAnsDWN(string FD, string SD)
        {
            string ANS = " ";
            try
            {
                int fd = Convert.ToInt32(FD); int sd = Convert.ToInt32(SD); 
                if (FD == "" || SD == "")
                {

                }
                else
                {
                    ANS = (fd * sd).ToString();
                }
            }
            catch (Exception)
            {
                
            }
            
            return ANS;
        }
    }
}
