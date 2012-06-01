namespace LongExer
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        private string doorDescription;
        private Location doorLocation;

        public OutsideWithDoor(string name, bool hot, string doorDescription)
            : base(name, hot)
        {
            this.doorDescription = doorDescription;
        }

        public string DoorDescription
        {
            get { return doorDescription; }
        }

        public Location DoorLocation
        {
            get { return doorLocation; }
            set { doorLocation = value; }
        }
    }
}
