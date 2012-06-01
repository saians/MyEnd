namespace LongExer
{
    public class Room :Location
    {
        private string decoration;

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        protected string Decoration
        {
            set { value = decoration; }
        }

        public override string Description
        {
            get
            {
                string description = "You see the " + decoration + " here.";
                return description;
            }
        }
    }
}
