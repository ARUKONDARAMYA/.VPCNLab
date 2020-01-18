using System;
using System.Windows.Forms;

namespace MathGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddClicked(object sender, EventArgs e)
        {
            var nos = getNumbers();
            ans.Text = $"{nos.Item1} + {nos.Item2} = {nos.Item1 + nos.Item2}";
        }

        private void SubClicked(object sender, EventArgs e)
        {
            var nos = getNumbers();
            ans.Text = $"{nos.Item1} - {nos.Item2} = {nos.Item1 - nos.Item2}";
        }

        private void MulClicked(object sender, EventArgs e)
        {
            var nos = getNumbers();
            ans.Text = $"{nos.Item1} x {nos.Item2} = {nos.Item1 * nos.Item2}";
        }

        private void DivClicked(object sender, EventArgs e)
        {
            var nos = getNumbers();

            if (nos.Item2 == 0)
                ans.Text = "Cannot divide by zero";
            else
                ans.Text = $"{nos.Item1} \u00F7 {nos.Item2} = {nos.Item1 / nos.Item2}";
        }

        private Tuple<double, double> getNumbers()
        {
            try
            {
                return Tuple.Create(Double.Parse(boxA.Text), Double.Parse(boxB.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Tuple.Create(0.0, 0.0);
            
        }
    }
}
