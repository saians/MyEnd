using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoingFurther
{
    class Farmer
    {
        public int BagofFeeds { get; private set; }
        private int numberOfCows;
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier;  } }

        public int NumberOfCows
        {
            get { return numberOfCows; }
            set
            {
                numberOfCows = value;
                BagofFeeds = numberOfCows * FeedMultiplier;
            }
        }
    }
}
