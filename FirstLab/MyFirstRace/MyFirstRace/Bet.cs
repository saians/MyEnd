using System;

namespace MyFirstRace
    {
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public  string GetDescription()
        {
            if (Amount==0 || Bettor.MyBet.Amount > Bettor.Cash)
            {
                return Bettor.Name + "hasn't placed a bet";
            }
            else
            {
                return Bettor.Name + " betting " + Bettor.MyBet.Amount + "on dog no. " + Bettor.MyBet.Dog;
            }
        }

        public  int PayOut(int Winner)
        {
            if (Bettor.MyBet.Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
    }
