using System.Windows.Forms;

namespace BMS
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manu" });
            workers[1] = new Worker(new string[] { "Egg care", "baby bee tuto" });
            workers[2] = new Worker(new string[] { "Hive maintanence", "Sting patrol" });
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manu", "egg care", "baby bee tutor", "hive maintanence", "Sting patrol" });

            queen = new Queen(workers);
        }

        private void assignButton_Click(object sender, System.EventArgs e)
        {
            if (queen.AssignWork(comboBox1.Text, (int)shifts.Value) == false)
                MessageBox.Show("No workers are available to do this job ' " + comboBox1.Text + "'",
                                "The queen bee says..");
        }

        private void nextShiftbutton_Click(object sender, System.EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

    }
}
