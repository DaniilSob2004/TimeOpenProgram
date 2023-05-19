namespace StartTime
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        DateTime startTime = DateTime.Now;

        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            StartTimer();
        }

        private void StartTimer()
        {
            t.Interval = 1;
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            TimeSpan time = DateTime.Now - startTime;
            Text = (int)time.TotalMilliseconds + "";
        }
    }
}