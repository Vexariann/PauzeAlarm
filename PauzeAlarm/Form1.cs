using System.Media;
using System.Timers;

namespace PauzeAlarm
{
    public partial class Form1 : Form
    {
        List<Pauze> _pauze = new();
        bool played = false;
        int time = 60;
        public Form1()
        {
            InitializeComponent();
            TimeSelector.Value = DateTime.Now;
            PauzeList.DisplayMember = "FullName";
            Timer();
        }

        public string GetCurrentDirectory()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            return projectDirectory;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Pauze pauze = new();
            pauze.Name = NameTextBox.Text;
            pauze.Time = TimeSelector.Value.ToString("HH:mm");
            pauze.FirstTime = TimeSelector.Value.AddMinutes(-5).ToString("HH:mm");
            _pauze.Add(pauze);
            PauzeList.Items.Add(pauze);
            PauzeList.SelectedIndex = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && PauzeList.Items.Count > 0)
            {
                Pauze item = PauzeList.SelectedItem as Pauze;
                DialogResult result = MessageBox.Show($"Weet u zeker dat u {item.FullName} wilt verwijderen?",
                "Verwijder Pauze", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    PauzeList.Items.Remove(item);
                    _pauze.Remove(item);
                    if (PauzeList.Items.Count > 0)
                    {
                        PauzeList.SelectedIndex = 0;
                    }
                }
            }
        }

        public void Timer()
        {
            System.Timers.Timer myTimer = new();
            myTimer.Elapsed += new ElapsedEventHandler(TimedEvent);
            myTimer.Interval = 60000;
            myTimer.Start();

            System.Timers.Timer myTimer2 = new();
            myTimer2.Elapsed += new ElapsedEventHandler(countdown);
            myTimer2.Interval = 1000;
            myTimer2.Start();
            CountdownText.Text = time.ToString();
        }

        private void countdown(object sender, EventArgs e)
        {
            time--;
            if (time == 0)
                time = 60;
            CountdownText.Text = time.ToString();
        }

        public void TimedEvent(object source, ElapsedEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm");
            if (_pauze.Count > 0)
            {
                foreach (Pauze pauze in _pauze)
                {
                    if (currentTime == pauze.FirstTime)
                    {
                        string path = Path.Combine(GetCurrentDirectory(), @"Sounds\firsttime.wav");
                        SoundPlayer Sound = new SoundPlayer(path);
                        Sound.Play();
                    }
                    else if (currentTime == pauze.Time)
                    {
                        string path = Path.Combine(GetCurrentDirectory(), @"Sounds\time.wav");
                        SoundPlayer Sound = new SoundPlayer(path);
                        Sound.Play();
                    }
                    else
                    {
                        // Do nothing
                    }
                }
            }
            else
            {
                // Do nothing
            }
        }
    }
}