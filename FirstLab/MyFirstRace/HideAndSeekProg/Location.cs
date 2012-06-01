namespace LongExer
{
    public abstract class Location
    {
        protected Location(string name)
        {
            this.name = name;
        }
        public string name;
        public Location[] Exists;

        public string Name
        {
            get { return name; }

        }

        public virtual string Description
        {
            get
            {
                string description = "You are standing in the " + name + ". You can exit to the following places:";
                for (int i = 0; i < Exists.Length; i++)
                {
                    description += "" + Exists[i].Name;
                    if (i != Exists.Length - 1)
                    {
                        description += ",";
                    }
                }
                description += ".";


                return description;
            }
        }
    }
}
