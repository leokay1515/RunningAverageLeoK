using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAverageLeoK
{
    public partial class frmRunningAverageLeoK : Form
    {
        //variables
        int counter = 0;
        double total = 0;
        double userNum;

        public frmRunningAverageLeoK()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //incriment the counter
            counter++;
            userNum = Convert.ToDouble(txtInput.Text);

            //if the user enters a number that is 0-100 add it to the total
            if (userNum >= 0)
            {
                total = total + userNum;
            }
            else if (userNum == -1)
            {
                MessageBox.Show("Running Average Ended", "Running Average");
                this.btnCalculate.Enabled = false;
                this.txtInput.Visible = false;
            }

            //diplay the average
            lblAnswer.Text = Convert.ToString(total / counter);
        }
    }
}
