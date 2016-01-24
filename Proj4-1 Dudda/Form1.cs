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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
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
    }
}
// random comment to allow commit of changes so I can then try updating GitHub.