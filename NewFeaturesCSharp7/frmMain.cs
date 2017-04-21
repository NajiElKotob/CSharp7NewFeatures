using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFeaturesCSharp7
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Define a binary literal using the 0b prefix
        /// Binary literals make it easy to work with bits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBinaryLiterals_DigitSeparators_Click(object sender, EventArgs e)
        {
            int[] number = { 0b1 , 0b1000_0000, 0b00_00_10_10};
            MessageBox.Show(string.Join(", ", number).ToString());
        }
    }
}
