using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoingFurther
{
    class Farmer
    {
        public int BagofFeeds;
        public const int FeedMultiplier = 10;

        private int numberOfcows;

        public int NumberOfCows
        {
            get { return numberOfcows; }

            set { numberOfcows = value;
                BagofFeeds = FeedMultiplier*numberOfcows;
            }
        }
    }
}
