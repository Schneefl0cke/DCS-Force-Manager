using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Force_Manager
{
    public partial class AddPlayerForm : Form
    {
        private Form1 menu;
        public AddPlayerForm(Form1 menu)
        {
            this.menu = menu;
            InitializeComponent();
        }

        private void button_addPlayer_Click(object sender, EventArgs e)
        {
            if (textBox_playerName.Text == null || textBox_playerName.Text == string.Empty)
            {
                MessageBox.Show("Please provide a player name");
            }
            else
            {
                menu.Button_AddPlayer_Pressed(textBox_playerName.Text);
                this.Close();
            }
        }
    }
}
