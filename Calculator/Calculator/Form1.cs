using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CALCULATOR : Form
    {
        string operation = "";
        Double firstnum, secondnum;

        double iKilometres, iMiles;
        double iPounds, iKilograms;
        char iOperation;


        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";

            if (b.Text == "")
            {
                if (!txtDisplay.Text.Contains(""))
                    txtDisplay.Text = txtDisplay.Text = b.Text;
            }

            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

        }

        private void Operation_Funtion(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstnum = Double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

           if (txtDisplay.Text =="")
            {
                txtDisplay.Text = "0";
            }

            
        }

        private void btnPositiveNegative_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            }

            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void rbMilestoKilometres_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'M';
        }

        private void rbKilometrestoMiles_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void rbPoundstoKilograms_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'P';
        }

        private void rbKilogramstoPounds_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'G';
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'M':
                    //Miles to Kilometres
                    iMiles = double.Parse(txtConvert.Text);
                    lblResult.Text = ((iMiles * 1.609344).ToString());
                    break;

                case 'K':
                    //Kilometres to miles
                    iKilometres = double.Parse(txtConvert.Text);
                    lblResult.Text = ((iKilometres * 0.621371192).ToString());
                    break;

                case 'P':
                    //Pounds to Kilograms
                    iPounds = double.Parse(txtConvert.Text);
                    lblResult.Text = ((iPounds * 0.45359237).ToString());
                    break;

                case 'G':
                    //Kilograms to Pounds
                    iKilograms = double.Parse(txtConvert.Text);
                    lblResult.Text = ((iKilograms * 2.20462262185).ToString());
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblResult.Text = "";
            rbMilestoKilometres.Checked = false;
            rbKilometrestoMiles.Checked = false;
            rbPoundstoKilograms.Checked = false;
            rbKilogramstoPounds.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondnum = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstnum + secondnum);
                    break;

                case "-":
                    txtDisplay.Text = Convert.ToString(firstnum - secondnum);
                    break;

                case "*":
                    txtDisplay.Text = Convert.ToString(firstnum * secondnum);
                    break;

                case "/":
                    txtDisplay.Text = Convert.ToString(firstnum / secondnum);
                    break;

                default:
                    break;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            string f, s;

            s = Convert.ToString(secondnum);
            f = Convert.ToString(firstnum);

            s = "";
            f = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
