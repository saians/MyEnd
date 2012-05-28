namespace LittInterfacePrac
{
    class FunnyFunny
    {
        protected string funnythingIhave;

        public FunnyFunny(string funnythingIhave)
        {
            this.funnythingIhave = funnythingIhave;
        }

        public string FunnyThingsIHave { get { return funnythingIhave; } }

        public string Honk()
        {
            return "Honk Honk I have " + funnythingIhave;
        }
    }

    internal class protecreadonly
    {
    }
}
