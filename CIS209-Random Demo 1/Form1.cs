using System;
using System.Windows.Forms;

namespace CIS209_Random_Demo_1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandInt_Click(object sender, EventArgs e)
        {
            int flip = rand.Next(2);
            lblRandInt.Text = flip.ToString();

            if (flip == 0)
            {
                pbxHead.Visible = true;
                pbxTails.Visible = false;
            }
            else
            {
                pbxHead.Visible = false;
                pbxTails.Visible = true;
            }
        }
    }
}
