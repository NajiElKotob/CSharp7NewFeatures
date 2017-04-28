using System;
using System.Text.RegularExpressions;
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

        private void btnTuples_Click(object sender, EventArgs e)
        {
            //Tuples: a structure of data that has several parts
            var sentence = "Switch to C# Now!";
            var s = AnalyzeSentense(sentence);
            MessageBox.Show($"{sentence}\r\n# of words: {s.Item1}, # of char: {s.Item2}");
        }

        /// <summary>
        /// Tuple
        /// </summary>
        /// <remarks>
        /// Tuple Class https://msdn.microsoft.com/en-us/library/system.tuple(v=vs.110).aspx
        /// Regular Expression Language - Quick Reference https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx
        /// </remarks>
        /// <param name="sentence"></param>
        /// <returns></returns>
        private (int, int) AnalyzeSentense(string sentence)
        {
            var r = (0, 0); //Number of Words, Number of Characters

            MatchCollection matchCollection = Regex.Matches(sentence, @"[\S]+");
            r.Item1 = matchCollection.Count;
            r.Item2 = sentence.Length;

            return r;

        }
    }
}
