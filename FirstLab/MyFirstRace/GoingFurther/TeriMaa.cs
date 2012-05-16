using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoingFurther
{
    public class TeriMaa
    {
        private string _name;
        private readonly string _address;
        private readonly int _number;
        private readonly bool _isPresent;
        private readonly string _desc;
        private int totalno;

        public TeriMaa(string name, string address, int number, bool isPresent, string desc)
        {
            _name = name;
            _address = address;
            _number = number;
            _isPresent = isPresent;
            _desc = desc;
        }

        public int myNewNo
        {
            get { return totalno; }
            set { totalno = totalno * 2; }
        }
    }
}
