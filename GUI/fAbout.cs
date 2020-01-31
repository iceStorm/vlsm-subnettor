using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fAbout : MetroFramework.Forms.MetroForm
    {
        private System.Windows.Forms.Timer tmr;


        public fAbout()
        {
            InitializeComponent();

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            FadeIn();
        }


        #region SOME DESIGNS
        private void FadeIn()
        {
            this.Opacity = 0;
            this.tmr = new Timer();
            this.tmr.Interval = 1;
            this.tmr.Tick += Tmr_Tick;
            this.tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.075;
            if (this.Opacity >= 0.98)
            {
                this.tmr.Tick -= Tmr_Tick;
                this.Opacity = 0.98;
                this.tmr.Stop();
            }
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Opacity != 0)
            {
                e.Cancel = true;
                this.tmr.Tick += Tmr_TickClose;
                this.tmr.Start();
            }
        }

        private void Tmr_TickClose(object sender, EventArgs e)
        {
            this.Opacity -= 0.075;
            if (this.Opacity <= 0)
            {
                this.tmr.Tick -= Tmr_TickClose;
                this.Opacity = 0;
                this.tmr.Stop();
                this.Close();
            }
        }

        #endregion

        private void lb_facebook_Click(object sender, EventArgs e)
        {
            string url = "https://facebook.com/hauduedaiduong/";
            System.Diagnostics.Process.Start(url);
        }
    }
}
