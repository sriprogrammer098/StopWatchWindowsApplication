namespace WinFormsApp1
{
    public partial class StopWatch : Form
    {
        private DateTime StartTime;
        public StopWatch()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (watchLabel.Text == "00:00.00")
            {
                this.StartTime = DateTime.Now;                

            }            
            formTimer.Start();


        }

        private void StopButton_Click(object sender, EventArgs e)
        {            
            formTimer.Stop();
            
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
            watchLabel.Text = "00:00.00";

        }

        private void formTimer_Tick(object sender, EventArgs e)
        {            
            //Calculate the ellapsed time
            TimeSpan ts = DateTime.Now - StartTime;
            watchLabel.Text = ts.ToString(@"mm\:ss\.ff");
            
        }
    }
}
