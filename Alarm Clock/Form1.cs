using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock
{
    public partial class AlarmClockForm : Form
    {
        public AlarmClockForm()
        {
            InitializeComponent();
        }

        private void AlarmClockForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            currentTimeLbl2.Text = DateTime.Now.ToShortTimeString();
            if (hiddenLbl.Text == currentTimeLbl2.Text)
            {
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/kqUrP2J58Rw?autoplay=1";
            }

        }

        private void alarmSet_Click(object sender, EventArgs e)
        {
            hiddenLbl.Text = wakeUpTime.Text;
            wakeUpTime.Text = "";
            label1.Text = "Alarm Set!";
        }
    }
}
