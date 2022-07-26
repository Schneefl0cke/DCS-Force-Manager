using Facade;
using Layer;

namespace Force_Manager
{
    public partial class Form1 : Form
    {
        private KillStatisticSingleMission killStatisticSingleMission;
        private string path_singleMission;

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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK && dialog.CheckFileExists)
            {
                path_singleMission = dialog.FileName;
                FillListBoxes_SingleMission();
            }
        }

        private void FillListBoxes_SingleMission()
        {
            try
            {
                killStatisticSingleMission = SingleMissionHandler.AnalzyeSingleMission(path_singleMission);
                FillListBoxes_SingleMission_Red();
                FillListBoxes_SingleMission_Blue();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                    "Error while reading mission file",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FillListBoxes_SingleMission_Blue()
        {
            var killedAircraft = killStatisticSingleMission.BlueStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "aircraft");
            if (killedAircraft != null)
            {
                listBox_aircraft_blue.DataSource = killedAircraft;
                listBox_aircraft_blue.DisplayMember = "Display";
            }

            var killedhelicopter = killStatisticSingleMission.BlueStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "helicopter");
            if (killedhelicopter != null)
            {
                listBox_helicopter_blue.DataSource = killedhelicopter;
                listBox_helicopter_blue.DisplayMember = "Display";
            }

            var killedtanks = killStatisticSingleMission.BlueStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "tank");
            if (killedtanks != null)
            {
                listBox_tank_blue.DataSource = killedtanks;
                listBox_tank_blue.DisplayMember = "Display";
            }

            var killedships = killStatisticSingleMission.BlueStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "ship");
            if (killedships != null)
            {
                listBox_ship_blue.DataSource = killedships;
                listBox_ship_blue.DisplayMember = "Display";
            }
        }

        private void FillListBoxes_SingleMission_Red()
        {
            var killedAircraft = killStatisticSingleMission.RedStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "aircraft");
            if (killedAircraft != null)
            {
                listBox_aircraft_red.DataSource = killedAircraft;
                listBox_aircraft_red.DisplayMember = "Display";
            }

            var killedhelicopter = killStatisticSingleMission.RedStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "helicopter");
            if (killedhelicopter != null)
            {
                listBox_helicopter_red.DataSource = killedhelicopter;
                listBox_helicopter_red.DisplayMember = "Display";
            }

            var killedtanks = killStatisticSingleMission.RedStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "tank");
            if (killedtanks != null)
            {
                listBox_tank_red.DataSource = killedtanks;
                listBox_tank_red.DisplayMember = "Display";
            }

            var killedships = killStatisticSingleMission.RedStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "ship");
            if (killedships != null)
            {
                listBox_ship_red.DataSource = killedships;
                listBox_ship_red.DisplayMember = "Display";
            }
        }

        //private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void tabPage2_Click(object sender, EventArgs e)
        //{

        //}

        private void button_sm_reanalyze_Click(object sender, EventArgs e)
        {
            if (path_singleMission != null)
            {
                FillListBoxes_SingleMission();
            }
            else
            {
                MessageBox.Show("No Mission has been provided yet! Please 'Load Single Mission' first!",
                   "User Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
    }
}