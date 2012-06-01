using System;
using LongExer;

namespace HideAndSeekProg
{
    class Opponent
    {
        private Location mylocation;
        private Random random;

        public Opponent(Location startingLocation)
        {
            this.mylocation = startingLocation;
            random = new Random();
        }

        void Move()
        {
            if (mylocation is IHasExteriorDoor)
            {
                IHasExteriorDoor LocationWithDoor = mylocation as IHasExteriorDoor;
                if (random.Next(2) == 1)
                {
                    mylocation = LocationWithDoor.DoorLocation;
                }
                bool hidden = false;
                while (!hidden)
                {
                    int rand = random.Next(mylocation.Exists.Length);
                    mylocation = mylocation.Exists[rand];
                    if (mylocation is IHidingPlace)
                    {
                        hidden = true;
                    }
                }
            }
        }

        bool Check(Location enteredLocation)
        {
            if (enteredLocation != mylocation)
            {
                return false;
            }
            return true;
        }
    }
}
