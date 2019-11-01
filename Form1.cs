using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;

namespace Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            refreshForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Program Files (x86)\Steam\Steam.exe";

            using (Process proc = Process.Start(start))
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Program Files (x86)\Battle.net\Battle.net.exe";

            using (Process proc = Process.Start(start))
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Riot Games\League of Legends\LeagueClient.exe";

            using (Process proc = Process.Start(start))
            {
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Program Files (x86)\Ubisoft\Ubisoft Game Launcher\Uplay.exe";

            using (Process proc = Process.Start(start))
            {
               
            }
        }

        private void refreshForm()
        {
            checkSteam();

            checkBlizz();

            checkLoL();

            checkUplay();
        }

        private void checkSteam()
        {
            if (Process.GetProcessesByName("steam").Length > 0)
            {
                button1.BackColor = Color.LightGreen;
                button1.Text = "Running...";
                button1.Click -= button1_Click;
            }

            else
            {
                button1.BackColor = Color.WhiteSmoke;
                button1.Text = "Steam";
                
            }
        }

        private void checkBlizz()
        {
            if (Process.GetProcessesByName("Battle.net").Length > 0)
            {
                button2.BackColor = Color.LightGreen;
                button2.Text = "Running...";
                button2.Click -= button2_Click;
            }

            else
            {
                button2.BackColor = Color.WhiteSmoke;
                button2.Text = "Battle.net";
            }
        }

        private void checkLoL()
        {
            if (Process.GetProcessesByName("LeagueClient").Length > 0)
            {
                button3.BackColor = Color.LightGreen;
                button3.Text = "Running...";
                button3.Click -= button3_Click;
            }

            else
            {
                button3.BackColor = Color.WhiteSmoke;
                button3.Text = "LoL";
            }
        }

        private void checkUplay()
        {
            if (Process.GetProcessesByName("Uplay").Length > 0)
            {
                button4.BackColor = Color.LightGreen;
                button4.Text = "Running...";
                button4.Click -= button4_Click;
            }

            else
            {
                button4.BackColor = Color.WhiteSmoke;
                button4.Text = "Uplay";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshForm();
        }
    }
}
