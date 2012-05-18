using System.Windows.Forms;

namespace BirthdayParty
{
    class BirthdayParty
    {

        public const int CostOffood = 25;
        public decimal CostOfDecorations = 0;
        private bool fancyDecorations;
        public int CakeSize;
        private string cakeWriting = "";
        private int numberOfPeople;
        public const int CostOfFoodPerPerson = 25;

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }


        private void CalculateCakeSize()
        {
            if (numberOfPeople <= 4)
            {
                CakeSize = 8;
            }
            else
            {
                CakeSize = 16;
            }
        }

        protected string CakeWriting
        {
            get { return this.cakeWriting; }
            set
            {
                int maxLength;

                if (CakeSize == 8)
                    maxLength = 16;

                else
                    maxLength = 40;
                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + " inch cake");

                    if (maxLength > this.cakeWriting.Length)
                    {
                        maxLength = this.cakeWriting.Length;
                        this.cakeWriting = cakeWriting.Substring(0, maxLength);
                    }
                    else
                    {
                        this.cakeWriting = value;
                    }
                }

            }
        }

        public decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * numberOfPeople);
            decimal CakeCost;
            if (CakeSize == 8)
            {
                CakeCost = 40M + CakeWriting.Length * .25M;
            }
            else
            {
                CakeCost = 75M + CakeWriting.Length * .25M;
            }

            return TotalCost + CakeCost;
        }

        public int NumberOFPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);

                CalculateCakeSize();

                this.CakeWriting = cakeWriting;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
                CostOfDecorations = (NumberOFPeople * 15.00M) + 50M;
            else
            {
                CostOfDecorations = (NumberOFPeople * 7.50M) + 30M;
            }
        }
    }
}
