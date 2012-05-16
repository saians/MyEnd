using System.Windows.Forms;

namespace MyFirstRace
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        private Bet[] betholder;


        public void UpdateLabels()
        {
            MyRadioButton.Text = this.Name + " has " + this.Cash + "bucks";
            MyLabel.Text = MyBet.GetDescription();
        }

        public void ClearBet()
        {

        }

        public bool PlaceBet(int Amount, int Dog)
        {
            MyBet = new Bet() { Amount = Amount, Bettor = this, Dog = Dog };

            if (this.Cash >= MyBet.Amount)
            {
                this.UpdateLabels();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
        }
    }
}
