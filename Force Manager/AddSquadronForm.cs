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
    public partial class AddSquadronForm : Form
    {
        private Form1 menu;
        public AddSquadronForm(Form1 menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void button_addSquadron_Click(object sender, EventArgs e)
        {
            if (textBox_squadronName.Text == null || textBox_squadronName.Text == string.Empty)
            {
                MessageBox.Show("Please provide a player name");
            }
            else
            {
                menu.Button_AddSquadron_Pressed(textBox_squadronName.Text);
                this.Close();
            }
        }
    }
}
