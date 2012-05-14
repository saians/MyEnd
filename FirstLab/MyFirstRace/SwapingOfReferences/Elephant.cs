using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SwapingOfReferences
    {
    class Elephant
        {
        public int EarSize;
        public string Name;

        public void WhoAmI()
            {
            MessageBox.Show("The ear size of " + Name + " is :" + EarSize);
            }

        public void TellMe(string message, Elephant whoSaidIt)
            {
            MessageBox.Show(whoSaidIt.Name + " says: " + message);
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="whoToTalkTo">With whom this elephant is talking with</param>
        /// <param name="message">the message to be conveyed</param>
        public void SpeakTo(Elephant whoToTalkTo, string message)
            {
                whoToTalkTo.TellMe(message,this);
            }
        }
    }
