using System.Windows.Forms;

namespace LongExer
{
    public partial class Form1 : Form
    {
        public Location currentLocation;

        public Form1()
        {
            InitializeComponent();

        }

        private void CreateObjects()
        {
            RoomWithDoor livingRoom;
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            RoomWithDoor kitchen;
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door");

            OutsideWithDoor frontYard;
            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass");

            Outside backYard;
            backYard = new Outside("Back Yard", true);
            Outside garden;
            garden = new Outside("Garden", false);

            Room diningRoom;
            diningRoom = new Room("Dining Room", "a crystal chandelier");

            frontYard.Exists = new Location[] { backYard, garden };
            livingRoom.Exists = new Location[] { frontYard, diningRoom };
            kitchen.Exists = new Location[] { diningRoom, backYard };
            backYard.Exists = new Location[] { kitchen, garden };
            garden.Exists = new Location[] { frontYard, backYard };
        }

        private void MoveToANewLocation(Location location)
        {
            this.currentLocation = location;
            exits.Items.Clear();
            for (int i = 0; i < location.Exists.Length; i++)
            {
                exits.Items.Add(location.Exists[i].Name);
                exits.SelectedIndex = 0;

                description.Text = location.Description;

                if (location is IHasExteriorDoor) { goThroughTheDoor.Visible = true; }
                else
                {
                    goThroughTheDoor.Visible = false;
                }

            }

        }

        private void goHere_Click(object sender, System.EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exists[(int)exits.SelectedItem]);
        }

        private void goThroughTheDoor_Click(object sender, System.EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
