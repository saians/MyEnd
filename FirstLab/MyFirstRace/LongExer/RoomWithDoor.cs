namespace LongExer
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        private string doorDescription;
        private Location doorLocation;

        public RoomWithDoor(string name, string decoration, string doorDecription)
            : base(name, decoration)
        {
            this.doorDescription = doorDecription;
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
