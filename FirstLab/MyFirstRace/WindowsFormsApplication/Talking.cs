using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
    {
    class Talking
        {
        public  static int BlahBlah(string thingToSay, int numberOftimes)
        {
            string finalString = "";

            for (int i = 0; i < numberOftimes; i++)
            {
                finalString = finalString + thingToSay;
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
        }
    }
