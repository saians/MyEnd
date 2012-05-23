namespace JewelInheritence
{
    public class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "12345";

        public Jewels Open(string combination)
        {
            if (combination == safeCombination)
            {
                return contents;
            }
            else
            {
                return null;
            }
        }

        public void PickLocker(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
}
