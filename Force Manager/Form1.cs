using Facade;
using Layer;

namespace Force_Manager
{
    public partial class Form1 : Form
    {
        private KillStatisticSingleMission killStatisticSingleMission;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Force Manager", MessageBoxButtons.YesNo) == DialogResult.No)
            {

                // SET TO TRUE, SO CLOSING OF THE MAIN FORM, 
                // SO THE APP ITSELF IS BLOCKED
                e.Cancel = true;
            }
        }

        private void button_loadSingleMission_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK && dialog.CheckFileExists)
            {
                path = dialog.FileName;
                try
                {
                    killStatisticSingleMission = SingleMissionHandler.AnalzyeSingleMission(path);
                    FillListBoxes_SingleMission();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,
                        "Error while reading mission file",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void FillListBoxes_SingleMission()
        {
            //TODO: check for null
            var killedAircraft_red = killStatisticSingleMission.RedStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "aircraft");
            listBox_aircraft_red.DataSource = killedAircraft_red;
            listBox_aircraft_red.DisplayMember = "Display";

            var killedAircraft_blue = killStatisticSingleMission.BlueStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "aircraft");
            listBox_aircraft_blue.DataSource = killedAircraft_blue;
            listBox_aircraft_blue.DisplayMember = "Display";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}