using System.Windows.Forms;

namespace LittInterfacePrac
{
    class TallGuy : IClown
    {
        public string Name;
        public string Height;

        public void TalkAboutYourself()
        {
            MessageBox.Show("My name is " + Name + " and Im " + Height);
        }

        public void Honk()
        {
            MessageBox.Show("salam");
        }

        public string FunnyThingIHave
        {
            get { return "Jokes"; }
        }
    }
}
