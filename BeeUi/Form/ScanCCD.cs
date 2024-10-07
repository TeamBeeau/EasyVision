using BeeUi.Commons;
using Heroje_Debug_Tool.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeUi
{
    public partial class ScanCCD : Form
    {
        public ScanCCD()
        {
            InitializeComponent();
            G.ScanCCD = this;
        }
        string[] listStringCCD;
        public List<string> ScanIDCCD()
        {
            String IDCCD = G.Config.IDCamera;
            String sRead = BeeCore.Common.ScanCCD();
            String[] listStringCCD = sRead.Split('\n');
            cbCCD.DataSource = listStringCCD;
           return listStringCCD.ToList();
        }
        private void ScanCCD_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);

          
            cbCCD.DataSource = ScanIDCCD();
            if (G.Config.Resolution == null) G.Config.Resolution = "1280x720 (1.3 MP)";
            cbReSolution.SelectedIndex = cbReSolution.FindStringExact(G.Config.Resolution);
        }
     public   int indexCCD;
        
        public void ConnectCCD()
        {
            indexCCD = cbCCD.SelectedIndex;
            
            if (!work.IsBusy)
                work.RunWorkerAsync();
        }
        private void btnAreaBlack_Click(object sender, EventArgs e)
        {
            if(G.EditTool!=null)
            G.EditTool.View.tmCheckCCD.Enabled = false;
            G.Config.TypeCamera = BeeCore.TypeCamera.USB;
            if (G.Config.TypeCamera == BeeCore.TypeCamera.TinyIV)
                BeeCore.Common.PropertyChanged -=G.EditTool.View. Common_PropertyChanged;

            btnConnect.Enabled = false;
            
            ConnectCCD();


        }

        private void work_DoWork(object sender, DoWorkEventArgs e)
        {

            if (G.Config.TypeCamera == BeeCore.TypeCamera.USB)
                BeeUi.G.IsCCD = BeeCore.Common.ConnectCCD(indexCCD, G.Config.Resolution);
            else if (G.Config.TypeCamera == BeeCore.TypeCamera.TinyIV)
            {
                BeeUi.G.IsCCD = true;
               
            }
        }
        Crypto Crypto = new Crypto();
        private void work_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
                if (G.Config.TypeCamera == BeeCore.TypeCamera.TinyIV)
            {
                if (BeeUi.G.IsCCD)
                {
                    BeeCore.Common.DestroyAll();
                }
               G.DeviceConnectForm = new BeeDevice.DeviceConnectForm();

                //deviceConnectForm.Show();
                G.DeviceConnectForm.Page_Init();
                G.Config.TypeCamera = BeeCore.TypeCamera.TinyIV;
                G.IsCCD = false;
                if (ToolCfg.CurrentDevice != null)
                    G.IsCCD = ToolCfg.CurrentDevice.IsConnect;
                   
            }    
               //G.MainForm.LoadCamera();
          //  G.MainForm.Show();
            btnConnect.Enabled = true;
            if (BeeUi.G.IsCCD)
            {
                G.Config.IDCamera = cbCCD.Text.Trim();
                if (G.Main == null)
                {
                    G.Load.FormActive.CheckActive(G.Load.addMac);
                    if (G.IsActive)
                    {
                        Main Main = new Main();
                        G.EditTool.lbCam.Image = Properties.Resources.CameraConnected;
                        if (G.Config.TypeCamera == BeeCore.TypeCamera.USB)
                        {
                           
                            G.EditTool.lbCam.Text = G.Config.IDCamera.Split('$')[0] + " Connected";
                        }
                        else
                        {
                            G.EditTool.lbCam.Text ="TinyIV" + " Connected";
                        }    
                        String sProgram = Properties.Settings.Default.programCurrent;
                        G.Load.lb.Text = "Loading program.. (" + sProgram + ")";

                        G.Load.Hide();
                        Main.Show();
                      
                    }
                    else
                    {
                        if (G.Load.IsLockTrial)
                        {
                            G.Load.IsLockTrial = false;
                         
                               
                                G.Load.FormActive.txtLicence.Text = "Locked Trial";

                        }
                        String ID=    G.Load.FormActive.KeyActive + "*"+G.Config.IDCamera;
                        G.Load.FormActive.KeyActive = Crypto.EncryptString128Bit(ID, "b@@");
                        G.Load.FormActive.Show();

                    }    
                }
                else
                {
                   
                        BeeCore.Common.ReadCCD(false, G.Config.TypeCamera);

                        BeeCore.Common.matRaw = BeeCore.Common.GetImageRaw(G.Config.TypeCamera);
                    if (BeeCore.Common.matRaw!=null)
                        if (!BeeCore.Common.matRaw.Empty())
                            G.EditTool.View.imgView.ImageIpl = BeeCore.Common.matRaw;
                   
                }
                if (BeeCore.Common.matRaw!=null)
                    if (!BeeCore.Common.matRaw.Empty())
                G.EditTool.View.imgView.Location = new Point(G.EditTool.View.pView.Width / 2 - BeeCore.Common.matRaw.Width / 2, G.EditTool.View.pView.Height / 2 - BeeCore.Common.matRaw.Height / 2);

                if (File.Exists("Default.config"))
                    File.Delete("Default.config");
                Access.SaveConfig("Default.config", G.Config);
                this.Hide();
                // 

            }
            else
            {
              
                if (G.Load!=null)
                G.Load.Hide();
                this.Show();
            }    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScanCCD_Load_1(object sender, EventArgs e)
        {
      
        }

        private void cbSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
          //G.Config.namePort = cbSerialPort.Text.Trim();
        }

        private void workScan_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void cbReSolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            G.Config.Resolution = cbReSolution.Text.Trim();
        }
  
        private void btnDevice_Click(object sender, EventArgs e)
        {
          
            
            G.Config.TypeCamera = BeeCore.TypeCamera.TinyIV;
         
            btnDevice.Enabled = false;
            ConnectCCD();

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

            BeeDevice.DeviceConnectForm deviceConnectForm = new BeeDevice.DeviceConnectForm();
           
            //deviceConnectForm.Show();
            deviceConnectForm.Page_Init();
            G.Config.TypeCamera = BeeCore.TypeCamera.TinyIV;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
