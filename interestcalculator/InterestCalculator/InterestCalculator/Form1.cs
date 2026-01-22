using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {

        double interest;
        double months;
        double amount;
        double totalInterest;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            interest = Convert.ToDouble(txtInterest.Text);
            months = Convert.ToDouble(txtMonths.Text);
            amount = Convert.ToDouble(txtAmount.Text);
            interest = interest / 100;

            totalInterest = amount * (Math.Pow(1 + interest, months) - 1);
            label1.Text = totalInterest.ToString("#.##");
        }
    }
}
