using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimatorNS;
using VLSM;
using System.IO;

namespace GUI
{
    public partial class fMain : MetroFramework.Forms.MetroForm
    {
        private System.Windows.Forms.Timer tmr;
        private AnimatorNS.Animator anm;
        private int oldNumericValue = 0;
        private bool isUp = true;

        

        public fMain()
        {
            InitializeComponent();

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            this.anm = new Animator();
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

                anm.Interval = 1;
                anm.Show(lb_title, false, Animation.Transparent);
            }
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Opacity != 0)
            {
                DialogResult choice = MessageBox.Show("Confirm exit ?", "Alert",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                e.Cancel = true;
                if (choice == DialogResult.Yes)
                {
                    this.tmr.Tick += Tmr_TickClose;
                    this.tmr.Start();
                }
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

        

        private void fMain_Load(object sender, EventArgs e)
        {
            num_firstOctet.Value = 1;
        }
        

        private void btn_resetIP_Click(object sender, EventArgs e)
        {
            //  Xoá hết nội dung trong các NumericUpDown

            this.num_firstOctet.Value = 2;
            this.num_firstOctet.Value = 1;
            this.num_secondOctet.Value = 0;
            this.num_thirdOctet.Value = 0;
            this.num_fourthOctet.Value = 0;

            this.num_firstOctet.Focus();
        }

        private void btn_resetBranch_Click(object sender, EventArgs e)
        {
            //  Xoá hết dòng trong DataGridView
            while (this.dgv_branches.Rows.Count > 1)
            {
                if (this.dgv_branches.Rows[0].IsNewRow == false)
                    this.dgv_branches.Rows.RemoveAt(0);
            }
        }

        private void btn_quickCalculate_Click(object sender, EventArgs e)
        {
            if (CheckBeforeCalculate() == true)
            {
                //  Lấy IP đã nhập trên Form
                IPv4 enteredIP = GetEnteredIP();


                //  Lấy listBranches đã nhập trên DataGridView
                List<Branch> enteredBranches = GetEnteredBranches();



                if (enteredBranches != null)
                {
                    //  Lấy kết quả chia mạng nhanh theo VLSM
                    List<VLSM.VLSM__RESULT> listResult = VLSM__RESULT.GetQuickResult(enteredBranches, enteredIP);



                    if (listResult != null)
                    {
                        //  Gọi form tính toán
                        fCalculate fQuick = new fCalculate(enteredIP, listResult);
                        fQuick.Show();
                    }
                }
            }
        }
        

        private bool CheckBeforeCalculate()
        {
            if (this.dgv_branches.Rows.Count == 1)
            {
                MessageBox.Show("You must enter at least 1 branch !", "Alert", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.dgv_branches.CurrentCell = this.dgv_branches.Rows[0].Cells[0];
                this.dgv_branches.BeginEdit(true);
                return false;
            }

            return true;
        }

        private IPv4 GetEnteredIP()
        {
            //  Lấy các Octet đã nhập trên Form
            Octet firstOctet = new Octet((int)this.num_firstOctet.Value);
            Octet secondOctet = new Octet((int)this.num_secondOctet.Value);
            Octet thirdOctet = new Octet((int)this.num_thirdOctet.Value);
            Octet fourthOctet = new Octet((int)this.num_fourthOctet.Value);
            int suffix = (int)this.num_suffix.Value;

            return new IPv4(firstOctet, secondOctet, thirdOctet, fourthOctet, suffix);
        }

        private List<Branch> GetEnteredBranches()
        {
            List<Branch> listBranches = new List<Branch>();


            //  Duyệt các dòng trong DataGridView
            foreach (DataGridViewRow drv in this.dgv_branches.Rows)
            {
                if (drv.IsNewRow == false)
                {
                    object cellValue = drv.Cells["branch"].Value;
                    int rowIndex = this.dgv_branches.Rows.IndexOf(drv);
                    int columnIndex = drv.Cells["branch"].ColumnIndex;


                    if (cellValue == null)
                    {
                        MessageBox.Show($"You must enter a branch name at DataGridView[{rowIndex}][{columnIndex}]");
                        this.dgv_branches.CurrentCell = drv.Cells[0];
                        this.dgv_branches.BeginEdit(true);
                        return null;
                    }



                    string branchName = cellValue.ToString();
                    if (String.IsNullOrWhiteSpace(branchName) == true)
                    {
                        MessageBox.Show($"You must enter a meaningful branch name at DataGridView[{rowIndex}][{columnIndex}]", "Alert",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.dgv_branches.CurrentCell = drv.Cells[0];
                        this.dgv_branches.BeginEdit(true);
                        return null;
                    }




                    int hostsAmount = 0;
                    object hostsValue = drv.Cells["host"].Value;

                    if (hostsValue != null && int.TryParse(hostsValue.ToString(), out hostsAmount) == true)
                    {
                        if (hostsAmount >= 2)
                        {
                            Branch brch = new Branch(branchName, hostsAmount);
                            listBranches.Add(brch);
                        }
                        else
                        {
                            MessageBox.Show($"The hosts amount of \"{branchName}\" must at least 2 hosts", "Alert",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            this.dgv_branches.CurrentCell = drv.Cells[1];
                            this.dgv_branches.BeginEdit(true);
                            return null;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"You must enter a number of hosts for \"{branchName}\"", "Alert",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.dgv_branches.CurrentCell = drv.Cells[1];
                        this.dgv_branches.BeginEdit(true);
                        return null;
                    }

                }
            }


            return listBranches;
        }


        //  Điều chỉnh phạm vi của các Octet
        private void num_firstOctet_ValueChanged(object sender, EventArgs e)
        {
            //  Get the value of First octet NumericUpdown
            int firstOctetValue = (int)(num_firstOctet.Value);


            //  Determines which key was pressed (Increament or Decreament)
            if (firstOctetValue > this.oldNumericValue)
            {
                isUp = true;
            }
            else
            {
                isUp = false;
            }


            //  Re-assign to old value
            oldNumericValue = firstOctetValue;


            //  Ignore the LoopBack
            if (firstOctetValue == 127)
                if (isUp == true)
                    num_firstOctet.Value += 1;
                else
                    num_firstOctet.Value -= 1;


            

            if (firstOctetValue >= 1 && firstOctetValue <= 126)     //  Lớp A
            {
                num_suffix.Minimum = 8;
                num_suffix.Value = 8;
                lb_ipClass.Text = "A";
            }
            else
            {
                if (firstOctetValue >= 128 && firstOctetValue <= 191)   //  Lớp B
                {
                    num_suffix.Minimum = 16;
                    num_suffix.Value = 16;
                    lb_ipClass.Text = "B";
                }
                else
                {
                    if (firstOctetValue >= 192 && firstOctetValue <= 223)   //  Lớp C
                    {
                        num_suffix.Minimum = 24;
                        num_suffix.Value = 24;
                        lb_ipClass.Text = "C";
                    }
                }
            }
        }

        private void btn_importFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                ImportDataFromFile();
            }
            catch
            {
                MessageBox.Show("The format of the file is invalid to read, please review the file \"Demo.txt\".", 
                    "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImportDataFromFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Path.GetFullPath(Application.StartupPath + $"/Data/");
            ofd.RestoreDirectory = true;
            ofd.Multiselect = false;
            ofd.Filter = "Text|*.txt";
            ofd.CheckFileExists = true;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SetDataFromText(File.ReadAllText(ofd.FileName));
            }
        }

        private void SetDataFromText(string content)
        {
            string[] segments = content.Split('\n');
            string ipContent = content.Split('\n').First();


            IPv4 ip = new IPv4(ipContent);
            this.num_firstOctet.Value = ip.FirstOctet.ToDecimal();
            this.num_secondOctet.Value = ip.SecondOctet.ToDecimal();
            this.num_thirdOctet.Value = ip.ThirdOctet.ToDecimal();
            this.num_fourthOctet.Value = ip.FourthOctet.ToDecimal();
            this.num_suffix.Value = ip.Suffix;


            this.dgv_branches.Rows.Clear();
            for (int i = 1; i < segments.Count(); ++i)
            {
                string[] branchContent = segments[i].TrimEnd().Split(':');
                this.dgv_branches.Rows.Add(branchContent.First(), branchContent.Last());
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            fAbout formAbout = new fAbout();
            formAbout.ShowDialog();
        }

        private void btn_saveToFile_Click(object sender, EventArgs e)
        {
            IPv4 ip = GetEnteredIP();
            List<Branch> branches = GetEnteredBranches();


            if (CheckBeforeCalculate() == true)
            {
                if (branches != null)
                {

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    sfd.InitialDirectory = Path.GetFullPath(Application.StartupPath + $"/Data/");
                    DialogResult rs = sfd.ShowDialog();


                    if (rs == DialogResult.OK)
                    {
                        MessageBox.Show($"Saved {Path.GetFileName(sfd.FileName)} successfully !");
                        SaveToFile(sfd.FileName, ip, branches);
                    }
                }
            }
        }

        private void SaveToFile(string path, IPv4 ip, List<Branch> branches)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);


            sw.WriteLine($"{ip.ToDecimalString()}/{ip.Suffix}");
            for (int i = 0; i < branches.Count; ++i)
            {
                sw.Write($"{branches[i].Name}:{branches[i].HostsAmount}");
                if (i != branches.Count - 1)
                    sw.WriteLine();
            }


            sw.Close();
            fs.Close();
        }

    }
}
