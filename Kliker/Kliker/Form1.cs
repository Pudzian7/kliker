using Microsoft.VisualBasic.Devices;

namespace Kliker
{
    public partial class Form1 : Form
    {
        public int click = 0;
        public int clickT = 1;
        public int pkt = 0;
        public int max = 0;
        public int Time1 = 7;
        public int Time2 = 7;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void najLbl_Click(object sender, EventArgs e)
        {

        }

        private void clickerBtn_Click(object sender, EventArgs e)
        {
            if (click == 0) TimerStart();
            click += clickT;
            kliki.Text = "Iloœæ klikniêæ : " + click;
        }
        private void TimerStart()
        {
            Time1 = Time2;
            WaitSec();

        }

        public async void WaitSec()
        {
            for (int i = 0; i < Time2; i++)
            {

                timer.Text = "Czas : " + Time1;
                await Task.Delay(1000);
                Time1--;
            }
            timer.Text = "Czas : " + Time1;
            if (click > max) max = click;
            bestscore.Text = "Najlepszy Wynik : " + max;
            pkt += click;
            pktmax.Text = "Suma punktów : " + pkt;
            click = 0;
           
        }

        private void timerLbl_Click(object sender, EventArgs e)
        {

        }

        private void clicksLbl_Click(object sender, EventArgs e)
        {

        }

        private void pktmax_Click(object sender, EventArgs e)
        {

        }
    }
}