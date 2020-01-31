using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VLSM;

namespace GUI
{
    public partial class fCalculate : MetroFramework.Forms.MetroForm
    {
        private System.Windows.Forms.Timer tmr;
        private List<VLSM.VLSM__RESULT> listResults;
        private VLSM.IPv4 ip;



        public fCalculate(VLSM.IPv4 rootIP, List<VLSM__RESULT> listResults)    //  Giải nhanh
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            
            this.listResults = listResults;
            this.ip = rootIP;

            FadeIn();
        }
        


        #region SOME DESIGNS
        private void FadeIn()
        {
            this.Opacity = 0;
            this.tmr = new System.Windows.Forms.Timer();
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
        


        private void fQuickCalculate_Load(object sender, EventArgs e)
        {
            this.lb_IP.Text = $"{this.ip.ToDecimalString()}/{this.ip.Suffix}";
            this.lb_subnet.Text = this.ip.SubnetMask.ToDecimalString();
            this.lb_netAddress.Text = $"{this.ip.NetAddress.ToDecimalString()}/{this.ip.Suffix}";
            this.lb_netClass.Text = this.ip.NetworkClass.ToString();


            this.chb_showGuide.Checked = false;
            ShowQuickResult();
            txt_reasoningResult.Text = VLSM__RESULT.Guides;
        }




        public void ShowQuickResult()
        {
            int numberCounter = 1;


            //Hiển thị kết quả ra DataGridView
            foreach (VLSM__RESULT item in this.listResults)
            {
                this.dgv_result.Rows.Add(numberCounter++,
                    item.Branch.Name,
                    item.Branch.HostsAmount,
                    item.NetAddress.ToDecimalString(),
                    item.FirstIP.ToDecimalString(),
                    item.LastIP.ToDecimalString(),
                    item.BroadCastIP.ToDecimalString(),
                    item.SubnetMask.ToDecimalString() + $" ({item.NetAddress.Suffix})");
            }


            this.dgv_result.AutoResizeColumns();
            this.Refresh();
        }

        private void chb_showGuide_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_showGuide.Checked == true)
            {
                this.pn_reasoningResult.Show();
                this.Refresh();
            }
            else
            {
                this.pn_reasoningResult.Hide();
                this.Refresh();
            }
        }
        

    }
}
