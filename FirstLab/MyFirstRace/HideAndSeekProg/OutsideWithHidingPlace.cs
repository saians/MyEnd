using LongExer;

namespace HideAndSeekProg
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        private string hidingPlaceName;

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName)
            : base(name, hot)
        {
            this.hidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName
        {
            get { return hidingPlaceName; }
        }
    }
}
