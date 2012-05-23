using System;

namespace JewelInheritence
{
    public class Owner
    {
        private Jewels returnedContents;
        public void RecievedContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Thankyou for returning my jewellery "+ safeContents.Sparkle());
        }
    }
}