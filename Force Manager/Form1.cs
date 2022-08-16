using AssetsManager;
using Facade;
using Layer;

namespace Force_Manager
{
    public partial class Form1 : Form
    {
        private LosStatistic_WholeMission killStatisticSingleMission;
        private string path_singleMission;
        private const string folderName = "ForceManager";
        private const string playerFile = "Players.xml";
        private string playerFilePath;

        public Form1()
        {
            InitializeComponent();
            LoadPlayerList();
            ShowPlayers();
        }

        private void ShowPlayers()
        {
            listBox_players.DataSource = null;
            listBox_players.DataSource = PlayerHandler.Players;
            listBox_players.DisplayMember = "Name";
            listBox_players.Refresh();
        }

        private void LoadPlayerList()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(Path.Combine(appDataPath, folderName)))
                Directory.CreateDirectory(Path.Combine(appDataPath, folderName));

            playerFilePath = Path.Combine(appDataPath, folderName, playerFile);
            if (File.Exists(playerFilePath))
            {
                PlayerHandler.LoadPlayerFile(playerFilePath);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlayerHandler.SavePlayerList(playerFilePath);

            if (MessageBox.Show("Do you really want to exit?", "Force Manager", MessageBoxButtons.YesNo) == DialogResult.No)
            {
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
            
            var killedSam = killStatisticSingleMission.BlueStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "sam/aaa");
            if (killedSam != null)
            {
                listBox_sam_blue.DataSource = killedSam;
                listBox_sam_blue.DisplayMember = "Display";
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

            var killedOther = killStatisticSingleMission.BlueStatistic.FirstOrDefault(x => x.Count > 0
            && x[0].Type.ToLower() != "aircraft"
            && x[0].Type.ToLower() != "helicopter"
            && x[0].Type.ToLower() != "sam/aaa"
            && x[0].Type.ToLower() != "missile"
            && x[0].Type.ToLower() != "tank"
            && x[0].Type.ToLower() != "ship");
            if (killedOther != null)
            {
                listBox_other_blue.DataSource = killedOther;
                listBox_other_blue.DisplayMember = "Display";
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

            var killedSam = killStatisticSingleMission.RedStatistic.FirstOrDefault(x => x.Count > 0 && x[0].Type.ToLower() == "sam/aaa");
            if (killedSam != null)
            {
                listBox_sam_red.DataSource = killedSam;
                listBox_sam_red.DisplayMember = "Display";
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

            var killedOther = killStatisticSingleMission.RedStatistic.FirstOrDefault(x => x.Count > 0
            && x[0].Type.ToLower() != "aircraft"
            && x[0].Type.ToLower() != "sam/aaa"
            && x[0].Type.ToLower() != "helicopter"
            && x[0].Type.ToLower() != "tank"
            && x[0].Type.ToLower() != "missile"
            && x[0].Type.ToLower() != "ship");
            if (killedOther != null)
            {
                listBox_other_red.DataSource = killedOther;
                listBox_other_red.DisplayMember = "Display";
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
            if (killStatisticSingleMission != null)
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

        private void button_exportSingleMission_Click(object sender, EventArgs e)
        {
            if (killStatisticSingleMission != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var safePath = saveFileDialog.FileName;
                    CXmlWriter.WriteCxml.WriteKillStatistics_SingleMission(safePath, killStatisticSingleMission);
                }
            }
            else
            {
                MessageBox.Show("No Mission has been provided yet! Please 'Load Single Mission' first!",
                   "User Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void button_addPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm(this);
            addPlayerForm.Show();
        }

        public void Button_AddPlayer_Pressed(string playerName)
        {
            if (playerName.Trim() != null && playerName.Trim() != string.Empty)
            {
                var player = new Player() { Name = playerName};
                PlayerHandler.Players.Add(player);
                ShowPlayers();
            }
        }

        private void button_removeSelectedPlayer_Click(object sender, EventArgs e)
        {
            var selectedPlayer = (Player) listBox_players.SelectedItem;
            PlayerHandler.Players.Remove(selectedPlayer);
            ShowPlayers();
        }
    }
}