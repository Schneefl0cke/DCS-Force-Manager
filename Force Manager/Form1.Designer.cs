namespace Force_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton_includePlayerStatistic = new System.Windows.Forms.RadioButton();
            this.button_sm_reanalyze = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl_sm_redSide = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listBox_aircraft_blue = new System.Windows.Forms.ListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.listBox_helicopter_blue = new System.Windows.Forms.ListBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.listBox_sam_blue = new System.Windows.Forms.ListBox();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.listBox_tank_blue = new System.Windows.Forms.ListBox();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.listBox_ship_blue = new System.Windows.Forms.ListBox();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.listBox_other_blue = new System.Windows.Forms.ListBox();
            this.tabControl_sm_blueSide = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox_aircraft_red = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox_helicopter_red = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.listBox_sam_red = new System.Windows.Forms.ListBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.listBox_tank_red = new System.Windows.Forms.ListBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.listBox_ship_red = new System.Windows.Forms.ListBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.listBox_other_red = new System.Windows.Forms.ListBox();
            this.button_exportSingleMission = new System.Windows.Forms.Button();
            this.button_loadSingleMission = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.button_newPlayerList = new System.Windows.Forms.Button();
            this.button_savePlayers = new System.Windows.Forms.Button();
            this.button_loadPlayers = new System.Windows.Forms.Button();
            this.button_removeSelectedPlayer = new System.Windows.Forms.Button();
            this.button_addPlayer = new System.Windows.Forms.Button();
            this.listBox_players = new System.Windows.Forms.ListBox();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl_sm_redSide.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabControl_sm_blueSide.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(421, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1623, 1160);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1615, 1122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Campaign";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "In Development";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButton_includePlayerStatistic);
            this.tabPage2.Controls.Add(this.button_sm_reanalyze);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tabControl_sm_redSide);
            this.tabPage2.Controls.Add(this.tabControl_sm_blueSide);
            this.tabPage2.Controls.Add(this.button_exportSingleMission);
            this.tabPage2.Controls.Add(this.button_loadSingleMission);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1615, 1122);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Single Mission";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton_includePlayerStatistic
            // 
            this.radioButton_includePlayerStatistic.AutoSize = true;
            this.radioButton_includePlayerStatistic.Location = new System.Drawing.Point(11, 199);
            this.radioButton_includePlayerStatistic.Name = "radioButton_includePlayerStatistic";
            this.radioButton_includePlayerStatistic.Size = new System.Drawing.Size(155, 29);
            this.radioButton_includePlayerStatistic.TabIndex = 7;
            this.radioButton_includePlayerStatistic.TabStop = true;
            this.radioButton_includePlayerStatistic.Text = "Include players";
            this.radioButton_includePlayerStatistic.UseVisualStyleBackColor = true;
            // 
            // button_sm_reanalyze
            // 
            this.button_sm_reanalyze.Location = new System.Drawing.Point(11, 68);
            this.button_sm_reanalyze.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_sm_reanalyze.Name = "button_sm_reanalyze";
            this.button_sm_reanalyze.Size = new System.Drawing.Size(194, 53);
            this.button_sm_reanalyze.TabIndex = 6;
            this.button_sm_reanalyze.Text = "Re-Analyze Mission";
            this.button_sm_reanalyze.UseVisualStyleBackColor = true;
            this.button_sm_reanalyze.Click += new System.EventHandler(this.button_sm_reanalyze_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(870, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue Side";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(220, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Red Side";
            // 
            // tabControl_sm_redSide
            // 
            this.tabControl_sm_redSide.Controls.Add(this.tabPage5);
            this.tabControl_sm_redSide.Controls.Add(this.tabPage6);
            this.tabControl_sm_redSide.Controls.Add(this.tabPage11);
            this.tabControl_sm_redSide.Controls.Add(this.tabPage12);
            this.tabControl_sm_redSide.Controls.Add(this.tabPage13);
            this.tabControl_sm_redSide.Controls.Add(this.tabPage14);
            this.tabControl_sm_redSide.Location = new System.Drawing.Point(870, 52);
            this.tabControl_sm_redSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl_sm_redSide.Name = "tabControl_sm_redSide";
            this.tabControl_sm_redSide.SelectedIndex = 0;
            this.tabControl_sm_redSide.Size = new System.Drawing.Size(684, 966);
            this.tabControl_sm_redSide.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listBox_aircraft_blue);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Size = new System.Drawing.Size(676, 928);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Aircraft";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listBox_aircraft_blue
            // 
            this.listBox_aircraft_blue.FormattingEnabled = true;
            this.listBox_aircraft_blue.HorizontalScrollbar = true;
            this.listBox_aircraft_blue.ItemHeight = 25;
            this.listBox_aircraft_blue.Location = new System.Drawing.Point(4, 10);
            this.listBox_aircraft_blue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_aircraft_blue.Name = "listBox_aircraft_blue";
            this.listBox_aircraft_blue.Size = new System.Drawing.Size(658, 904);
            this.listBox_aircraft_blue.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.listBox_helicopter_blue);
            this.tabPage6.Location = new System.Drawing.Point(4, 34);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage6.Size = new System.Drawing.Size(676, 928);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Helicopter";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // listBox_helicopter_blue
            // 
            this.listBox_helicopter_blue.FormattingEnabled = true;
            this.listBox_helicopter_blue.HorizontalScrollbar = true;
            this.listBox_helicopter_blue.ItemHeight = 25;
            this.listBox_helicopter_blue.Location = new System.Drawing.Point(4, 7);
            this.listBox_helicopter_blue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_helicopter_blue.Name = "listBox_helicopter_blue";
            this.listBox_helicopter_blue.Size = new System.Drawing.Size(658, 879);
            this.listBox_helicopter_blue.TabIndex = 0;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.listBox_sam_blue);
            this.tabPage11.Location = new System.Drawing.Point(4, 34);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(676, 928);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "AAA/SAM";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // listBox_sam_blue
            // 
            this.listBox_sam_blue.FormattingEnabled = true;
            this.listBox_sam_blue.HorizontalScrollbar = true;
            this.listBox_sam_blue.ItemHeight = 25;
            this.listBox_sam_blue.Location = new System.Drawing.Point(0, 3);
            this.listBox_sam_blue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_sam_blue.Name = "listBox_sam_blue";
            this.listBox_sam_blue.Size = new System.Drawing.Size(667, 879);
            this.listBox_sam_blue.TabIndex = 0;
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.listBox_tank_blue);
            this.tabPage12.Location = new System.Drawing.Point(4, 34);
            this.tabPage12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(676, 928);
            this.tabPage12.TabIndex = 3;
            this.tabPage12.Text = "Armored";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // listBox_tank_blue
            // 
            this.listBox_tank_blue.FormattingEnabled = true;
            this.listBox_tank_blue.HorizontalScrollbar = true;
            this.listBox_tank_blue.ItemHeight = 25;
            this.listBox_tank_blue.Location = new System.Drawing.Point(10, 12);
            this.listBox_tank_blue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_tank_blue.Name = "listBox_tank_blue";
            this.listBox_tank_blue.Size = new System.Drawing.Size(657, 879);
            this.listBox_tank_blue.TabIndex = 0;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.listBox_ship_blue);
            this.tabPage13.Location = new System.Drawing.Point(4, 34);
            this.tabPage13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(676, 928);
            this.tabPage13.TabIndex = 4;
            this.tabPage13.Text = "Ship";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // listBox_ship_blue
            // 
            this.listBox_ship_blue.FormattingEnabled = true;
            this.listBox_ship_blue.HorizontalScrollbar = true;
            this.listBox_ship_blue.ItemHeight = 25;
            this.listBox_ship_blue.Location = new System.Drawing.Point(7, 7);
            this.listBox_ship_blue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_ship_blue.Name = "listBox_ship_blue";
            this.listBox_ship_blue.Size = new System.Drawing.Size(660, 879);
            this.listBox_ship_blue.TabIndex = 0;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.listBox_other_blue);
            this.tabPage14.Location = new System.Drawing.Point(4, 34);
            this.tabPage14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Size = new System.Drawing.Size(676, 928);
            this.tabPage14.TabIndex = 5;
            this.tabPage14.Text = "Other";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // listBox_other_blue
            // 
            this.listBox_other_blue.FormattingEnabled = true;
            this.listBox_other_blue.HorizontalScrollbar = true;
            this.listBox_other_blue.ItemHeight = 25;
            this.listBox_other_blue.Location = new System.Drawing.Point(4, 10);
            this.listBox_other_blue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_other_blue.Name = "listBox_other_blue";
            this.listBox_other_blue.Size = new System.Drawing.Size(663, 879);
            this.listBox_other_blue.TabIndex = 0;
            // 
            // tabControl_sm_blueSide
            // 
            this.tabControl_sm_blueSide.Controls.Add(this.tabPage3);
            this.tabControl_sm_blueSide.Controls.Add(this.tabPage4);
            this.tabControl_sm_blueSide.Controls.Add(this.tabPage7);
            this.tabControl_sm_blueSide.Controls.Add(this.tabPage8);
            this.tabControl_sm_blueSide.Controls.Add(this.tabPage9);
            this.tabControl_sm_blueSide.Controls.Add(this.tabPage10);
            this.tabControl_sm_blueSide.Location = new System.Drawing.Point(214, 52);
            this.tabControl_sm_blueSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl_sm_blueSide.Name = "tabControl_sm_blueSide";
            this.tabControl_sm_blueSide.SelectedIndex = 0;
            this.tabControl_sm_blueSide.Size = new System.Drawing.Size(647, 970);
            this.tabControl_sm_blueSide.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox_aircraft_red);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(639, 932);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Aircraft";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox_aircraft_red
            // 
            this.listBox_aircraft_red.FormattingEnabled = true;
            this.listBox_aircraft_red.HorizontalScrollbar = true;
            this.listBox_aircraft_red.ItemHeight = 25;
            this.listBox_aircraft_red.Location = new System.Drawing.Point(11, 10);
            this.listBox_aircraft_red.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_aircraft_red.Name = "listBox_aircraft_red";
            this.listBox_aircraft_red.Size = new System.Drawing.Size(614, 904);
            this.listBox_aircraft_red.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBox_helicopter_red);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(639, 932);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Helicopter";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBox_helicopter_red
            // 
            this.listBox_helicopter_red.FormattingEnabled = true;
            this.listBox_helicopter_red.HorizontalScrollbar = true;
            this.listBox_helicopter_red.ItemHeight = 25;
            this.listBox_helicopter_red.Location = new System.Drawing.Point(7, 13);
            this.listBox_helicopter_red.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_helicopter_red.Name = "listBox_helicopter_red";
            this.listBox_helicopter_red.Size = new System.Drawing.Size(623, 879);
            this.listBox_helicopter_red.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.listBox_sam_red);
            this.tabPage7.Location = new System.Drawing.Point(4, 34);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(639, 932);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "AAA/SAM";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // listBox_sam_red
            // 
            this.listBox_sam_red.FormattingEnabled = true;
            this.listBox_sam_red.HorizontalScrollbar = true;
            this.listBox_sam_red.ItemHeight = 25;
            this.listBox_sam_red.Location = new System.Drawing.Point(4, 8);
            this.listBox_sam_red.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_sam_red.Name = "listBox_sam_red";
            this.listBox_sam_red.Size = new System.Drawing.Size(625, 904);
            this.listBox_sam_red.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.listBox_tank_red);
            this.tabPage8.Location = new System.Drawing.Point(4, 34);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(639, 932);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Armored";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // listBox_tank_red
            // 
            this.listBox_tank_red.FormattingEnabled = true;
            this.listBox_tank_red.HorizontalScrollbar = true;
            this.listBox_tank_red.ItemHeight = 25;
            this.listBox_tank_red.Location = new System.Drawing.Point(11, 15);
            this.listBox_tank_red.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_tank_red.Name = "listBox_tank_red";
            this.listBox_tank_red.Size = new System.Drawing.Size(618, 879);
            this.listBox_tank_red.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.listBox_ship_red);
            this.tabPage9.Location = new System.Drawing.Point(4, 34);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(639, 932);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Ship";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // listBox_ship_red
            // 
            this.listBox_ship_red.FormattingEnabled = true;
            this.listBox_ship_red.HorizontalScrollbar = true;
            this.listBox_ship_red.ItemHeight = 25;
            this.listBox_ship_red.Location = new System.Drawing.Point(14, 15);
            this.listBox_ship_red.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_ship_red.Name = "listBox_ship_red";
            this.listBox_ship_red.Size = new System.Drawing.Size(615, 879);
            this.listBox_ship_red.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.listBox_other_red);
            this.tabPage10.Location = new System.Drawing.Point(4, 34);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(639, 932);
            this.tabPage10.TabIndex = 5;
            this.tabPage10.Text = "Other";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // listBox_other_red
            // 
            this.listBox_other_red.FormattingEnabled = true;
            this.listBox_other_red.HorizontalScrollbar = true;
            this.listBox_other_red.ItemHeight = 25;
            this.listBox_other_red.Location = new System.Drawing.Point(16, 12);
            this.listBox_other_red.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_other_red.Name = "listBox_other_red";
            this.listBox_other_red.Size = new System.Drawing.Size(600, 879);
            this.listBox_other_red.TabIndex = 0;
            // 
            // button_exportSingleMission
            // 
            this.button_exportSingleMission.Location = new System.Drawing.Point(9, 132);
            this.button_exportSingleMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_exportSingleMission.Name = "button_exportSingleMission";
            this.button_exportSingleMission.Size = new System.Drawing.Size(197, 45);
            this.button_exportSingleMission.TabIndex = 1;
            this.button_exportSingleMission.Text = "Export Statistic as xss";
            this.button_exportSingleMission.UseVisualStyleBackColor = true;
            this.button_exportSingleMission.Click += new System.EventHandler(this.button_exportSingleMission_Click);
            // 
            // button_loadSingleMission
            // 
            this.button_loadSingleMission.Location = new System.Drawing.Point(9, 10);
            this.button_loadSingleMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_loadSingleMission.Name = "button_loadSingleMission";
            this.button_loadSingleMission.Size = new System.Drawing.Size(197, 50);
            this.button_loadSingleMission.TabIndex = 0;
            this.button_loadSingleMission.Text = "Load Single Mission";
            this.button_loadSingleMission.UseVisualStyleBackColor = true;
            this.button_loadSingleMission.Click += new System.EventHandler(this.button_loadSingleMission_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage15);
            this.tabControl2.Controls.Add(this.tabPage16);
            this.tabControl2.Location = new System.Drawing.Point(21, 20);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(381, 1164);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.button_newPlayerList);
            this.tabPage15.Controls.Add(this.button_savePlayers);
            this.tabPage15.Controls.Add(this.button_loadPlayers);
            this.tabPage15.Controls.Add(this.button_removeSelectedPlayer);
            this.tabPage15.Controls.Add(this.button_addPlayer);
            this.tabPage15.Controls.Add(this.listBox_players);
            this.tabPage15.Location = new System.Drawing.Point(4, 34);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(373, 1126);
            this.tabPage15.TabIndex = 0;
            this.tabPage15.Text = "Players";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // button_newPlayerList
            // 
            this.button_newPlayerList.Location = new System.Drawing.Point(113, 1016);
            this.button_newPlayerList.Name = "button_newPlayerList";
            this.button_newPlayerList.Size = new System.Drawing.Size(99, 35);
            this.button_newPlayerList.TabIndex = 5;
            this.button_newPlayerList.Text = "New List";
            this.button_newPlayerList.UseVisualStyleBackColor = true;
            this.button_newPlayerList.Click += new System.EventHandler(this.button_newPlayerList_Click);
            // 
            // button_savePlayers
            // 
            this.button_savePlayers.Location = new System.Drawing.Point(268, 1058);
            this.button_savePlayers.Name = "button_savePlayers";
            this.button_savePlayers.Size = new System.Drawing.Size(99, 35);
            this.button_savePlayers.TabIndex = 4;
            this.button_savePlayers.Text = "Save";
            this.button_savePlayers.UseVisualStyleBackColor = true;
            this.button_savePlayers.Click += new System.EventHandler(this.button_savePlayers_Click);
            // 
            // button_loadPlayers
            // 
            this.button_loadPlayers.Location = new System.Drawing.Point(268, 1017);
            this.button_loadPlayers.Name = "button_loadPlayers";
            this.button_loadPlayers.Size = new System.Drawing.Size(99, 35);
            this.button_loadPlayers.TabIndex = 3;
            this.button_loadPlayers.Text = "Load";
            this.button_loadPlayers.UseVisualStyleBackColor = true;
            this.button_loadPlayers.Click += new System.EventHandler(this.button_loadPlayers_Click);
            // 
            // button_removeSelectedPlayer
            // 
            this.button_removeSelectedPlayer.Location = new System.Drawing.Point(6, 1057);
            this.button_removeSelectedPlayer.Name = "button_removeSelectedPlayer";
            this.button_removeSelectedPlayer.Size = new System.Drawing.Size(89, 34);
            this.button_removeSelectedPlayer.TabIndex = 2;
            this.button_removeSelectedPlayer.Text = "Remove";
            this.button_removeSelectedPlayer.UseVisualStyleBackColor = true;
            this.button_removeSelectedPlayer.Click += new System.EventHandler(this.button_removeSelectedPlayer_Click);
            // 
            // button_addPlayer
            // 
            this.button_addPlayer.Location = new System.Drawing.Point(6, 1017);
            this.button_addPlayer.Name = "button_addPlayer";
            this.button_addPlayer.Size = new System.Drawing.Size(89, 34);
            this.button_addPlayer.TabIndex = 1;
            this.button_addPlayer.Text = "Add";
            this.button_addPlayer.UseVisualStyleBackColor = true;
            this.button_addPlayer.Click += new System.EventHandler(this.button_addPlayer_Click);
            // 
            // listBox_players
            // 
            this.listBox_players.FormattingEnabled = true;
            this.listBox_players.ItemHeight = 25;
            this.listBox_players.Location = new System.Drawing.Point(5, 7);
            this.listBox_players.Name = "listBox_players";
            this.listBox_players.Size = new System.Drawing.Size(362, 1004);
            this.listBox_players.TabIndex = 0;
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.label4);
            this.tabPage16.Location = new System.Drawing.Point(4, 34);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(373, 1126);
            this.tabPage16.TabIndex = 1;
            this.tabPage16.Text = "Squadrons";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "In Development";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2822, 1192);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Force Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl_sm_redSide.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabPage12.ResumeLayout(false);
            this.tabPage13.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.tabControl_sm_blueSide.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage15.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.tabPage16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private Button button_exportSingleMission;
        private Button button_loadSingleMission;
        private Label label3;
        private Label label2;
        private TabControl tabControl_sm_redSide;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabControl tabControl_sm_blueSide;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private TabPage tabPage13;
        private TabPage tabPage14;
        private TabPage tabPage10;
        private ListBox listBox_aircraft_red;
        private ListBox listBox_aircraft_blue;
        private ListBox listBox_helicopter_blue;
        private ListBox listBox_sam_blue;
        private ListBox listBox_tank_blue;
        private ListBox listBox_ship_blue;
        private ListBox listBox_helicopter_red;
        private ListBox listBox_sam_red;
        private ListBox listBox_tank_red;
        private ListBox listBox_ship_red;
        private Button button_sm_reanalyze;
        private ListBox listBox_other_blue;
        private ListBox listBox_other_red;
        private TabControl tabControl2;
        private TabPage tabPage15;
        private TabPage tabPage16;
        private ListBox listBox_players;
        private Button button_addPlayer;
        private Button button_removeSelectedPlayer;
        private Button button_loadPlayers;
        private Button button_savePlayers;
        private Button button_newPlayerList;
        private RadioButton radioButton_includePlayerStatistic;
        private Label label4;
    }
}