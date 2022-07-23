namespace Force_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "My Application", MessageBoxButtons.YesNo) == DialogResult.No)
            {

                // SET TO TRUE, SO CLOSING OF THE MAIN FORM, 
                // SO THE APP ITSELF IS BLOCKED
                e.Cancel = true;
            }

        }
    }
}