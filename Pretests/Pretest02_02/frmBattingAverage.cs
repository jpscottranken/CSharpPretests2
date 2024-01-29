using System;
using System.Windows.Forms;

/*
 *  In baseball, a player's average is calculated by dividing hits by at bats.  For example, a player with 4 hits in 10 at bats has an average of .400, typically stated as a 400 average.

Write a C# GUI windows forms program that lets the user input hits and at bats.  From there, calculate the associated batting average.

Also, keep track of the highest batting average, the lowest batting average, and the total number of averages that have been calculated.  Store these are read-only textboxes.

For both hits and at bats, verify that:

a) The value inputted is not empty.
b) The value inputted is not non-numeric.
c) The value inputted is 0 or more.
d) For hits, the value is <= the value for at bats.

 */

namespace Pretest02_02
{
    public partial class frmBattingAverage : Form
    {
        //  Declare and initialize class variables
        int totalNumberOfAverages     = 0;
        decimal lowestBattingAverage  = 1.000m;
        decimal highestBattingAverage = 0.000m;
        int atBats = 0;
        int hits = 0;
        decimal average = 0.00m;

        public frmBattingAverage()
        {
            InitializeComponent();
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            ValidateInputFields();       
        }

        private void ValidateInputFields()
        {
            bool keepGoing = ValidateAtBatsNotEmpty();

            if (keepGoing)
            {
                keepGoing = ValidateAtBatsIsNumeric();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateHitsNotEmpty();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateHitsIsNumeric();
            }
            else
            { 
                return; 
            } 

            if (keepGoing)
            {
                keepGoing = ValidateHitsLessThanOrEqualToAtBats();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                CalculateBattingAverage();
            }
            else
            {
                return;
            }
        }

        private bool ValidateAtBatsNotEmpty()
        {
            string abs = txtAtBats.Text.Trim();
            bool retVal = true;

            if (abs == "")
            {
                ShowErrorMessage("At Bats Cannot Be Empty",
                                 "AT BATS TEXTBOX EMPTY");
                txtAtBats.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateAtBatsIsNumeric()
        {
            string abs = txtAtBats.Text.Trim();
            bool retVal = true;
            bool result;

            result = int.TryParse(abs, out atBats);
            if (!result || atBats < 0)
            {
                ShowErrorMessage("At Bats TextBox Non-Numeric Or Negative",
                                 "AT BATS MUST BE NUMERIC AND > 0");
                txtAtBats.Text = "";
                txtAtBats.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateHitsNotEmpty()
        {
            string h = txtHits.Text.Trim();
            bool retVal = true;

            if (h == "")
            {
                ShowErrorMessage("Hits Cannot Be Empty",
                                 "HITS TEXTBOX EMPTY");
                txtHits.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateHitsIsNumeric()
        {
            string h = txtHits.Text.Trim();
            bool retVal = true;
            bool result;

            result = int.TryParse(h, out hits);
            if (!result || hits < 0)
            {
                ShowErrorMessage("Hits TextBox Non-Numeric Or Negative",
                                 "HITS MUST BE NUMERIC AND > 0");
                txtHits.Text = "";
                txtHits.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateHitsLessThanOrEqualToAtBats()
        {
            bool retVal = true;

            if (hits > atBats)
            {
                ShowErrorMessage("Hits Cannot Be Greater Than At Bats",
                                 "HIT > AT BATS");
                txtHits.Text = "";
                txtHits.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void CalculateBattingAverage()
        {
            average = (decimal)hits / (decimal)atBats;
            txtAverage.Text = average.ToString("n3");
            //txtAverage.Text = ($"{average:n3}");

            UpdateTotals();
        }

        private void UpdateTotals()
        {
            totalNumberOfAverages++;
            txtTotalNumAverges.Text = totalNumberOfAverages.ToString();

            if (average < lowestBattingAverage)
            {
                lowestBattingAverage = average;
                txtLowestAverage.Text = lowestBattingAverage.ToString("n3");
            }

            if (average > highestBattingAverage)
            {
                highestBattingAverage = average;
                txtHighestAverage.Text = highestBattingAverage.ToString("n3");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtAtBats.Text  = "";
            txtHits.Text    = "";
            txtAverage.Text = "";
            txtAtBats.Focus();
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

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
