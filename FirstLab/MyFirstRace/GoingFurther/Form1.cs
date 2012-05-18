using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoingFurther
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();

            farmer = new Farmer() {NumberOfCows = 15,feedMultiplier= 1};
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            farmer.NumberOfCows = (int) numericUpDown1.Value;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("I need {0} of bags for {1} number of cows ",farmer.BagofFeeds,farmer.NumberOfCows));
        }

        
    }
}
