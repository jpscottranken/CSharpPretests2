using System;
using System.Windows.Forms;

/*
 *      EX1	Write a GUI-based program 
 *      that converts distances between 
 *      feet and yards.
 *      
 *      ●	The program must contain a 
 *          constant named FT_PER_YD 
 *          which holds the number of 
 *          feet per yard (3 feet = 1 yard). 
 *          Create the constant like this:  
 *          const int FT_PER_YD = 3;
 *      ●	Prompt the user for a distance 
 *          in feet.
 *      ●	Once the user presses a button, 
 *          display the distance in both feet 
 *          and yards as follows: 
 *          6 feet = 2 yards
 */

namespace Pretest01_06
{
    public partial class frmDistanceConverter : Form
    {
        public frmDistanceConverter()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constant
        const int FT_PER_YD = 3;

        private void btnConvertToYds_Click(object sender, EventArgs e)
        {
            PerformConversion();
        }

        private void PerformConversion()
        {
            decimal feet;
            decimal yards;

            //  If textbox left empty, return
            if (txtDistanceInFeet.Text.Trim() == "")
            {
                txtDistanceInFeet.Focus();
                return;
            }

            feet = Convert.ToDecimal(txtDistanceInFeet.Text);
            yards = feet / FT_PER_YD;

            //lblResult.Text = feet.ToString("n2") + " feet = " +
            //                 yards.ToString("n2") + " yards.";

            lblResult.Text = $"{feet:n2} feet = {yards:n2} yards";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtDistanceInFeet.Text = "";
            lblResult.Text = "";
            txtDistanceInFeet.Focus();
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
