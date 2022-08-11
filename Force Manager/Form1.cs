using AssetsManager;
using Facade;
using Layer;

namespace Force_Manager
{
    public partial class Form1 : Form
    {
        private KillStatisticSingleMission killStatisticSingleMission;
        private string path_singleMission;
        private const string folderName = "ForceManager";
        private const string playerFile = "Players.xml";
        private const string campaignFile = "Campaign.xml";
        private string playerFilePath;
        private string campaignFilePath;
        private string squadronFilePath;

        public Form1()
        {
            InitializeComponent();
            LoadPlayerList();
            LoadCampaign();
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

        private void LoadCampaign()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(Path.Combine(appDataPath, folderName)))
                Directory.CreateDirectory(Path.Combine(appDataPath, folderName));

            campaignFilePath = Path.Combine(appDataPath, folderName, campaignFile);
            if (File.Exists(campaignFilePath))
            {
                CampaignHandler.LoadCampaign(campaignFilePath);
            }
            UpdateCampaign();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Do you really want to exit?", "Force Manager", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                PlayerHandler.SavePlayerList(playerFilePath);
                CampaignHandler.SaveCampaign(campaignFilePath);
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
                killStatisticSingleMission = SingleMissionHandler.AnalzyeSingleMission(path_singleMission, radioButton_includePlayerStatistic.Checked);
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
                    //TODO: not nice
                    if (radioButton_includePlayerStatistic.Checked == false)
                    {
                        CXmlWriter.WriteCxml.WriteKillStatistics_SingleMission(safePath, killStatisticSingleMission, radioButton_includePlayerStatistic.Checked, new List<Player>());
                    }
                    else
                    {
                        CXmlWriter.WriteCxml.WriteKillStatistics_SingleMission(safePath, killStatisticSingleMission, radioButton_includePlayerStatistic.Checked, PlayerHandler.Players);
                    }
                   
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

        private void button_loadPlayers_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK && dialog.CheckFileExists)
            {
                var savePath = dialog.FileName;
                PlayerHandler.LoadPlayerFile(savePath);
                ShowPlayers();
            }
        }

        private void button_savePlayers_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = "xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var savePath = saveFileDialog.FileName;
                PlayerHandler.SavePlayerList(savePath);
            }
        }

        private void button_newPlayerList_Click(object sender, EventArgs e)
        {
            PlayerHandler.Players = new List<Player>();
            ShowPlayers();
        }

        private void UpdateCampaign()
        {
            label_missionCountCampaign.Text = "Mission count: " + CampaignHandler.Campaign.CampaignMissions.Count.ToString();
        }

        private void button_Campaign_New_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to create a new campaign (this will overwrite the old safe!)", "New Campaign", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CampaignHandler.Campaign = new Campaign();
                UpdateCampaign();
            }
        }
        private void button_Campaign_Safe_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = "xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var savePath = saveFileDialog.FileName;
                CampaignHandler.SaveCampaign(savePath);
                UpdateCampaign();
            }
        }

        private void button_Campaign_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK && dialog.CheckFileExists)
            {
                var savePath = dialog.FileName;
                CampaignHandler.LoadCampaign(savePath);
                UpdateCampaign();
            }
        }

        private void button_Campaign_Add_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK && dialog.CheckFileExists)
            {
                var path = dialog.FileName;
                CampaignHandler.AnalzyeSingleMission(path, radioButton_campaign_includePlayer.Checked);
                UpdateCampaign();
            }
        }

        private void button_Campaign_ExportCurrentMission_Click(object sender, EventArgs e)
        {
            if (CampaignHandler.Campaign.CampaignMissions.Count != 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var safePath = saveFileDialog.FileName;
                    //TODO: not nice
                    if (radioButton_includePlayerStatistic.Checked == false)
                    {
                        CXmlWriter.WriteCxml.WriteKillStatistics_SingleMission(safePath, CampaignHandler.Campaign.CampaignMissions.Last(), radioButton_includePlayerStatistic.Checked, new List<Player>());
                    }
                    else
                    {
                        CXmlWriter.WriteCxml.WriteKillStatistics_SingleMission(safePath, CampaignHandler.Campaign.CampaignMissions.Last(), radioButton_includePlayerStatistic.Checked, PlayerHandler.Players);
                    }
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

        private void button_Campaign_exportCampaignStatistic_Click(object sender, EventArgs e)
        {
            if (CampaignHandler.Campaign.CampaignMissions.Count != 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var safePath = saveFileDialog.FileName;
                    //TODO: not nice
                    if (radioButton_includePlayerStatistic.Checked == false)
                    {
                        CXmlWriter.WriteCxml.WriteKillStatistics_SingleMission(safePath, CampaignHandler.Campaign.CampaignStatistic, radioButton_includePlayerStatistic.Checked, new List<Player>());
                    }
                    else
                    {
                        CXmlWriter.WriteCxml.WriteKillStatistics_SingleMission(safePath, CampaignHandler.Campaign.CampaignStatistic, radioButton_includePlayerStatistic.Checked, PlayerHandler.Players);
                    }
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
    }
}