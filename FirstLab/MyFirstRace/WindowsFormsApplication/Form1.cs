using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            string name = "Saif";
            int x = 33;

            double d = Math.PI / 2;

            MessageBox.Show("name is " + name + "\n number is " + x + "\n d is " + d);

            }

        private void button2_Click(object sender, EventArgs e)
            {
            int x = 5;
            if (x == 100)
                {
                MessageBox.Show("x must be 10");
                }
            else
                {
                MessageBox.Show("x isnt is 10");
                }
            }

        private void button3_Click(object sender, EventArgs e)
            {
            int someValue = 4;
            string name = "Jag faller";

            if ((someValue == 3) && (name == "noka"))
                {
                MessageBox.Show("x is 3 and name is noka");
                }
            MessageBox.Show("Runs this everythime");
            }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
        }
        }
    }
