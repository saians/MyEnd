namespace BirthdayParty
{
    class DinnerParty
    {
        private int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostofDecorations = 0;
        public decimal CostOFBeveragesPerPerson;


        public const int FoodChargePerPerson = 25;


        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostofDecorations = (NumberOfPeople * 15M) + 50M;
            }
            else
            {
                CostofDecorations = (NumberOfPeople * 7.50M) + 50M;
            }
        }

        public decimal CalculateCost(bool isHealthy)
        {
            decimal totalCost = CostofDecorations + ((CostOFBeveragesPerPerson + FoodChargePerPerson) * NumberOfPeople);

            if (isHealthy)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }

        }

    }
}
