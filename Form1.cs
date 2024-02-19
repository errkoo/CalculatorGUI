using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class Form1 : Form
    {
        string Euro;
        string BGN;
        public Form1()
        {
            InitializeComponent();
        }
        public double EuroToBGN()
        {
            string given = this.Euro;
            if(given == string.Empty)
                given = "0";
            double amount = Convert.ToDouble(given);
            Calculate calculate = new Calculate(amount, 1);
            return calculate.returnAmount();

        }
        public double BGNToEuro()
        {
            string given = this.BGN;
            if (given == string.Empty)
                given = "0";
            double amount = Convert.ToDouble(given);
            Calculate calculate = new Calculate(amount, 2);
            return calculate.returnAmount();
        }

        private void Convert_Click_Click(object sender, EventArgs e)
        {
            
            this.Euro = EuroText.Text;
            this.BGN = BGNText.Text;

            try
            {
                newAmountBGN.Text = EuroToBGN().ToString();
                newAmountEuro.Text = BGNToEuro().ToString();
            }
            catch (Exception ex)
            {
                newAmountBGN.Text = "Invalid entry";
                newAmountEuro.Text = "Invalid entry";
            }
        }
    }
}
