using System;
using System.Drawing;
using System.Windows.Forms;

namespace mathquizapplication
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int total;      
        int score = 0;   
        int numA, numB;  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score.ToString();
            GenerateQuestion();
        }

        private void GenerateQuestion()
        {
            numA = rnd.Next(10, 20);
            numB = rnd.Next(1, 9); 

            int setOperator = rnd.Next(1, 5); 

            if (setOperator == 1)
            {
                lblSymbol.Text = "+";
                total = numA + numB;
            }
            else if (setOperator == 2)
            {
                lblSymbol.Text = "-";
                total = numA - numB;
            }
            else if (setOperator == 3)
            {
                lblSymbol.Text = "*";
                total = numA * numB;
            }
            else if (setOperator == 4)
            {
                lblSymbol.Text = "/";
                total = numA / numB;   
                numA = total * numB;  
            }

            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
            txtAnswer.Text = "";
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers!");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1);
                txtAnswer.SelectionStart = txtAnswer.Text.Length;
            }
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                MessageBox.Show("Please enter an answer!");
                return;
            }

            int userAnswer = Convert.ToInt32(txtAnswer.Text);

            if (userAnswer == total)
            {
                lblAnswer.Text = "Correct";
                lblAnswer.ForeColor = Color.Blue;
                score++;
                lblScore.Text = "Score: " + score.ToString();
            }
            else
            {
                lblAnswer.Text = "Incorrect";
                lblAnswer.ForeColor = Color.Red;
            }

            await System.Threading.Tasks.Task.Delay(1000);

            GenerateQuestion();
            lblAnswer.Text = "";
        }
    }
}
