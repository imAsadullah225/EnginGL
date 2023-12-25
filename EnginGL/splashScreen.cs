using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnginGL
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        EnginGL EGL = new EnginGL();
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            splashProgressBar.Value += 2;

            if (splashProgressBar.Value >= 100)
            {
                SplashTimer.Stop();
                this.Hide();
                EGL.Closed += (s, args) => this.Close();
                EGL.Show();
            }
        }
    }
}
