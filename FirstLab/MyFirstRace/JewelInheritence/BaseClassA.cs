using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JewelInheritence
{
    class BaseClassA
    {
        public BaseClassA(string thisisbasesconstructor)
        {
            MessageBox.Show("This is the base class: " + thisisbasesconstructor);
        }
    }

    class SubClassB : BaseClassA
    {
        public SubClassB(string thisisbaseconstructor, int myNum):base(thisisbaseconstructor)
        {
            MessageBox.Show("This is subclass:" +thisisbaseconstructor + " and " +myNum);
        }
    }
}
