namespace BirthdayParty
{
    class DinnerParty
    {
        public int NumberOfPeople;
        private decimal CostOFBeveragesPerPerson;
        private decimal CostofDecorations;
        private bool IsHealthyOptionSelected;
        private bool IsfancyDeco;
        private decimal TotalCost;


        private const decimal FoodChargePerPerson = 25M;
        private const decimal DrinkChargesForAlcoholPerPerson = 20M;
        private const decimal DrinkChargesForNOnAlcoholPerPerson = 5M;

        private const decimal DecorationCostPerPersonNormal = 7.5M;
        private const decimal DecorationFeeNormal = 30M;

        private const decimal DecorationCostPerPersonFancy = 15M;
        private const decimal DecorationFeeFancy = 50M;

        public decimal SetHealthyOption()
        {
            if (IsHealthyOptionSelected == true)
            {
                return DrinkChargesForNOnAlcoholPerPerson;
            }
            else
            {
                return DrinkChargesForAlcoholPerPerson;
            }
        }

        public decimal CalculateCostOfDecorations()
        {
            if (IsfancyDeco == true)
            {
                return CostofDecorations = (DecorationCostPerPersonFancy + DecorationFeeFancy) * (NumberOfPeople);
            }
            else
            {
                return CostofDecorations = (DecorationCostPerPersonNormal + DecorationFeeNormal) * NumberOfPeople;
            }
        }

        public decimal CalculateCost()
        {
            if (IsHealthyOptionSelected == true)
            {
                 TotalCost =  DrinkChargesForAlcoholPerPerson + CalculateCostOfDecorations();

                 return TotalCost = TotalCost - (TotalCost * (decimal) 0.05);
            }
            else
            {
                TotalCost = DrinkChargesForNOnAlcoholPerPerson + CalculateCostOfDecorations();
                return TotalCost;
            }
        }
    }
}
