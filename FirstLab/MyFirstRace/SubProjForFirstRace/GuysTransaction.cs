using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SubProjForFirstRace
    {
    class GuysTransaction
        {
        public int _Cash;
        public string _Name;

        public int GiveCash(int amount)
            {
            if (amount <= _Cash && amount >= 0)
                {
                _Cash -= amount;
                return amount;
                }
            else
                {
                MessageBox.Show("DO NOT HAVE ENOUGH CASH TO GIVE YOU " + amount, _Name + "SAYS THAT..");

                }

            return 0;
            }

        public int RecieveCash(int amount)
        {
            if (amount > 0)
                {
                _Cash += amount;
                return amount;
                }
            else
                {
                MessageBox.Show("I am not accepting this amout " + amount);
                return 0;
                }
            
        }
        }


    class StartingPointForGuy
        {
        public static void Main()
      
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GuyForm());
            }
        }

    }
