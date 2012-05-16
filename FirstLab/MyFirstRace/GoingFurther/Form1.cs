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
        private Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer() {NumberOfCows = 15};
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.BagofFeeds = (int) numericUpDown1.Value;
        }

        private void calculateButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feeds for {1} cows ",farmer.BagofFeeds,farmer.NumberOfCows);
        }

    }
}
