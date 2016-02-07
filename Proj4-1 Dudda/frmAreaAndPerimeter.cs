using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj4_1_Dudda
{
    public partial class frmAreaAndPerimeter : Form
    {
        public frmAreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try  // Data validation should mean nothing breaks, but Just In Case...
            {
                // if the user has input valid data, run the calculations.
                if (IsValidInput()) { Calculate(); }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Oops, something went wrong:\n" + exc.ToString());
            }
        }

        private void Calculate()
        {
            // intialize variables with info from form
            double len = Double.Parse(txtLength.Text);
            double wid = Double.Parse(txtWidth.Text);

            // calculate our area and perimeter
            double area = len * wid;
            double perim = (len + wid) * 2;

            // and update our form
            txtArea.Text = Convert.ToString(area);
            txtPerimeter.Text = Convert.ToString(perim);
        }

        // do we have valid data?
        private bool IsValidInput()
        {
            return (IsPositiveInteger(txtLength) && IsPositiveInteger(txtWidth));
        }

        // is the string a positive integer?
        private bool IsPositiveInteger(TextBox myTextBox)
        {
            double fakevar;
            if (double.TryParse(myTextBox.Text, out fakevar) && fakevar > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a positive number greater than zero.");
                myTextBox.Focus();
                return false;
            }
        }

    } // end partial class frmAreaAndPerimeter 
}  // end Proj 4-1