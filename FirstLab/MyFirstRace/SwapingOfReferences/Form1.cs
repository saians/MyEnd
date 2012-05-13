using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SwapingOfReferences
    {
    public partial class Form1 : Form
        {
        private Elephant lucinda;
        private Elephant llyod;

        public Form1()
            {
            InitializeComponent();
             lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
             llyod = new Elephant() { EarSize = 44, Name = "Llyod" };

            }

        private void button1_Click(object sender, EventArgs e)
        {
            llyod.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
            {
            lucinda.WhoAmI();
            }

        private void button3_Click(object sender, EventArgs e)
            {
            Elephant holder;
            holder = llyod;
            llyod = lucinda;
            lucinda = holder;
            MessageBox.Show("Objects swapped..");

            }

        }
    }
