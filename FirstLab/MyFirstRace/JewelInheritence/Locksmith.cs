namespace JewelInheritence
{
    public class Locksmith
    {
        private string writtenDownCombination = null;

        public void WriteDownCombination(string safeCombination)
        {
            writtenDownCombination = safeCombination;
        }

        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLocker(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }
         
        public void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.RecievedContents(safeContents);
        }

    }
}