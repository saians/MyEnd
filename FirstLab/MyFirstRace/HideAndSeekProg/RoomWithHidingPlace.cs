using LongExer;

namespace HideAndSeekProg
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        private string hidingplacename;

        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName)
            : base(name, decoration)
        {
            this.hidingplacename = hidingPlaceName;
        }

        public string HidingPlaceName
        {
            get { return hidingplacename; }
        }
    }
}
