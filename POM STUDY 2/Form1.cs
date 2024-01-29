using System.Diagnostics.Eventing.Reader;

namespace POM_STUDY_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int tick;
        public int min = 45;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            int time = 60 * min * 1000;
            if (timer1.Enabled == false)
            {
                timer1.Start();
                timerButton.BackColor = Color.Red; timerButton.ForeColor = Color.White;
                timerButton.Text = "STOP";
            }
            else
            {
                timer1.Stop();
                timerButton.Text = "START";
                timerButton.BackColor = Color.Lime; timerButton.ForeColor = Color.White;
            }
        }
        public int tickTemplate = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tickTemplate--;

            if (tickTemplate <= 0)
            {
                timer1.Stop();
                timerButton.BackColor = Color.Lime;
                timerButton.Text = "START";
            }
        }
    }
}
