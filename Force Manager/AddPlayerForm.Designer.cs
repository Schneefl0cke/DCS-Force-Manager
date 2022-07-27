namespace Force_Manager
{
    partial class AddPlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_playerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_addPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_playerName
            // 
            this.textBox_playerName.Location = new System.Drawing.Point(126, 9);
            this.textBox_playerName.Name = "textBox_playerName";
            this.textBox_playerName.Size = new System.Drawing.Size(150, 31);
            this.textBox_playerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player name";
            // 
            // button_addPlayer
            // 
            this.button_addPlayer.Location = new System.Drawing.Point(295, 7);
            this.button_addPlayer.Name = "button_addPlayer";
            this.button_addPlayer.Size = new System.Drawing.Size(112, 34);
            this.button_addPlayer.TabIndex = 3;
            this.button_addPlayer.Text = "Add Player";
            this.button_addPlayer.UseVisualStyleBackColor = true;
            this.button_addPlayer.Click += new System.EventHandler(this.button_addPlayer_Click);
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 69);
            this.Controls.Add(this.button_addPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_playerName);
            this.Name = "AddPlayerForm";
            this.Text = "Add Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox textBox_playerName;
        private Label label1;
        private Button button_addPlayer;
    }
}