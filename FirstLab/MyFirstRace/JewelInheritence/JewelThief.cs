using System;

namespace JewelInheritence
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;

        new public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("Im stealing the contents! " +stolenJewels.Sparkle());
        }

    }
}