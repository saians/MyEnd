using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LittInterfacePrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScaryScary fingertheclown = new ScaryScary(15, "mera L");
            FunnyFunny someFunnyClown = fingertheclown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
        }

    }
}
