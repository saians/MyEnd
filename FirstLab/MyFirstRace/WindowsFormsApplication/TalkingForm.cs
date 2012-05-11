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
    public partial class TalkingForm : Form
        {
        public TalkingForm()
            {
            InitializeComponent();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            var length  =Talking.BlahBlah(textBox1.Text, (int) numericUpDown1.Value);

            MessageBox.Show("This is im getting from talking for :" + length);
            }



        }
    }
