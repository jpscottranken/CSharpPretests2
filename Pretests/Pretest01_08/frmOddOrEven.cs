using System;
using System.Windows.Forms;

/*
 *      Write a GUI-based program
 *      that asks the user for a 
 *      number and determines whether 
 *      the number is 0, odd, or even 
 *      (use the modulo operator). 
 */

namespace Pretest01_08
{
    public partial class frmOddOrEven : Form
    {
        public frmOddOrEven()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            OddOrEven();
        }

        private void OddOrEven()
        {
            if (txtEnterAnInteger.Text.Trim() == "")
            {
                return;
            }

            int number = Int32.Parse(txtEnterAnInteger.Text);

            if (number % 2 == 0)
            {
                lblResult.Text = "The number " + number.ToString()
                          + " is an even number.";
            }
            else
            {
                lblResult.Text = "The number " + number.ToString()
                          + " is an odd number.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtEnterAnInteger.Text = "";
            lblResult.Text = "";
            txtEnterAnInteger.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                                "Do You Really Want To Exit The Program?",
                                "EXIT NOW?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
