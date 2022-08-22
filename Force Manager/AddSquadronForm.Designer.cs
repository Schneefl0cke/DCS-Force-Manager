namespace Force_Manager
{
    partial class AddSquadronForm
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
            this.button_addSquadron = new System.Windows.Forms.Button();
            this.textBox_squadronName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_addSquadron
            // 
            this.button_addSquadron.Location = new System.Drawing.Point(205, 18);
            this.button_addSquadron.Name = "button_addSquadron";
            this.button_addSquadron.Size = new System.Drawing.Size(75, 23);
            this.button_addSquadron.TabIndex = 0;
            this.button_addSquadron.Text = "Add Squadron";
            this.button_addSquadron.UseVisualStyleBackColor = true;
            this.button_addSquadron.Click += new System.EventHandler(this.button_addSquadron_Click);
            // 
            // textBox_squadronName
            // 
            this.textBox_squadronName.Location = new System.Drawing.Point(99, 19);
            this.textBox_squadronName.Name = "textBox_squadronName";
            this.textBox_squadronName.Size = new System.Drawing.Size(100, 23);
            this.textBox_squadronName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Squadron Name";
            // 
            // AddSquadronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 56);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_squadronName);
            this.Controls.Add(this.button_addSquadron);
            this.Name = "AddSquadronForm";
            this.Text = "AddSquadronForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_addSquadron;
        private TextBox textBox_squadronName;
        private Label label1;
    }
}