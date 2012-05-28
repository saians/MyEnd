using System.Windows.Forms;

namespace LittInterfacePrac
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private readonly int numberOfScaryThings;

        public ScaryScary(int numberofScaryThings, string FunnyThingIHave)
            : base(FunnyThingIHave)
        {
            this.numberOfScaryThings = numberofScaryThings;
        }

        public string ScaryThingIHave { get { return numberOfScaryThings + " spiders. "; } }
        public void ScaryLittleChildern()
        {
            MessageBox.Show("you cant have my " + base.funnythingIhave);
        }


        public void Honk()
        {
            MessageBox.Show("samjh nahi aya ");
        }

        public string FunnyThingIHave
        {
            get { return FunnyThingIHave; }
        }
    }
}
