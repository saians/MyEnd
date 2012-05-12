using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SubProjForFirstRace
    {
    public partial class GuyForm : Form
        {
        private GuysTransaction atif;
        private GuysTransaction saif;
        private int bank = 10000;

        public void UpdateForm()
            {
            atifCashLabel.Text = atif._Name + " has SEK :" + atif._Cash;
            molanaCashLabel.Text = saif._Name + " has SEK :" + saif._Cash;
            bankCashLabel.Text = " Bank has :" + bank;
            }
        public GuyForm()
            {
            InitializeComponent();
            atif = new GuysTransaction() {_Cash = 60, _Name = "ATID Qureshi"};

            saif = new GuysTransaction() {_Cash = 10, _Name = "SAIFUllah"};
            

            UpdateForm();

            }

        private void button1_Click(object sender, EventArgs e)
            {
            if (bank >= 0)
                {
                bank -= atif.GiveCash(60);
                UpdateForm();
                }
            else
                {
                MessageBox.Show("Bank is out of money");
                }
            }

        private void button2_Click(object sender, EventArgs e)
            {
            bank += saif.RecieveCash(10);
            UpdateForm();
            }



        }
    }
