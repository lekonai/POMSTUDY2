using System.Diagnostics.Eventing.Reader;

namespace POM_STUDY_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int seconds;
        public int min = 45;
        private void Form1_Load(object sender, EventArgs e)
        {
            studyLabelSeconds.Text = tickInTheWorks.ToString() + "s"; // make sure to change this to seconds when you can
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
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
        public int minInTheWorks = 1; // minutes tester
        public int tickInTheWorks = 10; // second tester
        private void timer1_Tick(object sender, EventArgs e)
        {
            tickInTheWorks--;
            if (tickInTheWorks == 0 && minInTheWorks > 0)
            {
                minInTheWorks--;
            }
            studyLabelSeconds.Text = tickInTheWorks.ToString() + "s"; // remember to change to seconds
            if (minInTheWorks <= 0)
            {
                timer1.Stop();
                timerButton.BackColor = Color.Lime;
                timerButton.Text = "START";
            }
        }
    }
}
