using HideAndSeekProg;

namespace LongExer
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        private Location doorLocation;
        private string doorDescription;

        public RoomWithDoor(string name, string decoration, string hidingPlaceName,string doorDescription)
            : base(name, decoration, hidingPlaceName)
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
