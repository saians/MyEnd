using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuMaker
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();

            MenuMaker menu = new MenuMaker() {Randomizer = new Random()};

            label1.Text = menu.GetMenu();
            label2.Text = menu.GetMenu();
            label3.Text = menu.GetMenu();
            label4.Text = menu.GetMenu();
            label5.Text = menu.GetMenu();

            }

        private void Form1_Load(object sender, EventArgs e)
            {

            }

        }
    }
