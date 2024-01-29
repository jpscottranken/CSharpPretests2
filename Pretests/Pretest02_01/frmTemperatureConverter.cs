using System;
using System.Windows.Forms;

/*
 *  1.	Write a C# GUI app that converts either a temperature inputted in Fahrenheit to Celsius or a temperature       inputted in Celsius to Fahrenheit.:

Verify that either input is: 
a) Not empty. 
b) Not non-numeric.  
c) Within range.

Create constants MINFAHR (-212), MAXFAHR (212), MINCELSIUS (-100), MAXCELSIUS (100).  Please try to modularize your program.  See program run examples.  Here are the conversion formulas:

celsius = (fahrenheit - 32) / 1.8
fahrenheit = (celsius * 1.8) + 32

 */

namespace Pretest02_01
{
    public partial class frmTemperatureConverter : Form
    {
        //  Declare and initialize program constants
        const decimal MINFAHR    = -212m;
        const decimal MAXFAHR    =  212m;
        const decimal MINCELSIUS = -100m;
        const decimal MAXCELSIUS =  100m;

        //  Declare and initialize class variables
        decimal temp;
        decimal celsius;
        decimal fahrenheit;

        public frmTemperatureConverter()
        {
            InitializeComponent();
        }

        private void btnConvertFToC_Click(object sender, EventArgs e)
        {
            ConvertFahrenheitToCelsius();
        }

        //  "Driver" for F to C conversion
        private void ConvertFahrenheitToCelsius()
        {
            bool keepGoing = true;

            //  Call routine to valid F to C textbox not empty
            keepGoing = ValidateFahrTempNotEmpty();

            if (keepGoing)
            {
                keepGoing = ValidateFahrTempIsNumeric();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateFahrTempInRange();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                CalculateCelsiusTemperature();
            }
        }

        //  Verify that F to C textbox is not empty
        private bool ValidateFahrTempNotEmpty()
        {
            bool retVal = true;
            string fahrTemp = txtFahrTemp.Text.Trim();

            if (fahrTemp == "")
            {
                retVal = false;
                ShowErrorMessage("TextBox Cannot Be Empty",
                                 "EMPTY FAHRENHEIT TEXTBOX");
                txtFahrTemp.Focus();
            }

            return retVal;
        }

        //  Verify that F to C textbox holds a number
        private bool ValidateFahrTempIsNumeric()
        {
            string fahrTemp = txtFahrTemp.Text.Trim();
            bool retVal = true;
            bool result;

            result = decimal.TryParse(fahrTemp, out temp);
            if (!result)
            {
                ShowErrorMessage("TextBox Value Must Be Numeric",
                                 "NON-NUMERIC FAHRENHEIT TEXTBOX");
                txtFahrTemp.Text = "";
                txtFahrTemp.Focus();
                retVal = false;
            }

            return retVal;
        }

        //  Verify that F to C textbox holds a number
        //  between MINFAHR (-212) and MAXFAHR (+212)
        private bool ValidateFahrTempInRange()
        {
            bool retVal = true;

            if ((temp < MINFAHR) || (temp > MAXFAHR))
            {
                ShowErrorMessage("TextBox Value Must Be Within Range " +
                                 MINFAHR + " and " + MAXFAHR,
                                 "OUT-OF-RANGE FAHRENHEIT TEXTBOX");
                txtFahrTemp.Text = "";
                txtFahrTemp.Focus();
                retVal = false;
            }

            return retVal;
        }

        // Calculate Celsius temperature
        private void CalculateCelsiusTemperature()
        {
            celsius = (temp - 32m) / 1.8m;
            txtCelTemp.Text = celsius.ToString("n2");
            //txtCelTemp.Text = ($"{celsius:n2}");
        }

        private void btnConvertCToF_Click(object sender, EventArgs e)
        {
            ConvertCelsiusToFahrenheit();
        }

        //  "Driver" for F to C conversion
        private void ConvertCelsiusToFahrenheit()
        {
            bool keepGoing = true;

            //  Call routine to valid C to F textbox not empty
            keepGoing = ValidateCelTempNotEmpty();

            if (keepGoing)
            {
                keepGoing = ValidateCelTempIsNumeric();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateCelTempInRange();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                CalculateFahrenheitTemperature();
            }
        }

        private bool ValidateCelTempNotEmpty()
        {
            bool retVal = true;
            string celTemp = txtCelTemp.Text.Trim();

            if (celTemp == "")
            {
                retVal = false;
                ShowErrorMessage("TextBox Cannot Be Empty",
                                 "EMPTY CELSIUS TEXTBOX");
                txtCelTemp.Focus();
            }

            return retVal;
        }

        private bool ValidateCelTempIsNumeric()
        {
            string celTemp = txtCelTemp.Text.Trim();
            bool retVal = true;
            bool result;

            //  Attempt to parse textbox value into a decimal
            result = decimal.TryParse(celTemp, out temp);
            if (!result)
            {
                ShowErrorMessage("TextBox Value Must Be Numeric",
                                 "NON-NUMERIC CELSIUS TEXTBOX");
                txtCelTemp.Text = "";
                txtCelTemp.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateCelTempInRange()
        {
            bool retVal = true;
            string celTemp = txtCelTemp.Text.Trim();

            if ((temp < MINCELSIUS) || (temp > MAXCELSIUS))
            {
                ShowErrorMessage("TextBox Value Must Be Within Range " +
                                 MINCELSIUS + " and " + MAXCELSIUS,
                                 "OUT-OF-RANGE CELSIUS TEXTBOX");
                txtCelTemp.Text = "";
                txtCelTemp.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void CalculateFahrenheitTemperature()
        {
            fahrenheit = (celsius * 1.8m) + 32m;
            txtFahrTemp.Text = fahrenheit.ToString("n2");
            //txtFahrTemp.Text = ($"{fahrenheit:n2}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFahrTemp.Text = "";
            txtCelTemp.Text  = "";
            txtFahrTemp.Focus();
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
