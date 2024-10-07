
using BeeCore;
using BeeUi.Commons;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;

using System.Net;

using System.Windows.Forms;

namespace BeeUi
{
    public partial class FormLoad : Form
    {
        public String addMac;
        public String decompile;
        public bool IsLockTrial = false;
        public String[] sKeys;
        public String sKey="";
        public List<String> drivers;
        public Timer tmActive = new Timer();
        public Timer tmLoad = new Timer();
        public BackgroundWorker wLoad = new BackgroundWorker();
        Access access=new Access();
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // progressBar.Value = e.ProgressPercentage;
        }
        bool Is64bit = false;
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {

        }
      
        public Timer tmScanCCD = new Timer();
        public FormLoad()
        {
            InitializeComponent();
           // RsDirPermissions rsDirPermissions = new RsDirPermissions();
           // rsDirPermissions.SetEveryoneAccess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)+"\\Bee Eyes Automation\\EasyVision");
            G.Load = this;
            tmScanCCD.Interval = 200;
            tmScanCCD.Tick += TmScanCCD_Tick;
            tmActive.Interval = 1000;
            tmLoad.Interval = 5000;
            tmActive.Tick += TmActive_Tick;
            tmLoad.Tick += TmLoad_Tick;
            wLoad.DoWork += WLoad_DoWork;
            wLoad.RunWorkerCompleted += WLoad_RunWorkerCompleted;

            try
            {
                Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
              
                lbVersion.Text = version.ToString();
              
            }
            catch (Exception ex)  //just for demonstration...it's always best to handle specific exceptions
            {
                //react appropriately
            }


        }

        private void TmScanCCD_Tick(object sender, EventArgs e)
        {
            //if(File.Exists("cameras.bee"))
            //  {
            //    G.listCCD = File.ReadAllLines("cameras.bee").ToList();
            //G.listCCD = G.listCCD.Distinct().ToList();
            //tmScanCCD.Enabled = false;
            //}
        }
        public FormActive FormActive=new FormActive();
        Crypto Crypto=new Crypto();
        
        private void WLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ScanCCD.cbCCD.SelectedIndex == -1)

            {
                String NameCamera = G.Config.IDCamera.Split('$')[0];
                MessageBox.Show("Connect Failed Camera" + NameCamera + "!");
                ScanCCD.ConnectCCD();
                return;
            }    
                if (G.Load.IsLockTrial)
            {
                lbActive.Text = sActive;
                
            }    
                if (G.Load.sKey == null) 
                G.Load.sKey = "";
                if (G.Load.sKey != "")
            {
                if (File.Exists("Keys.bee"))
                    File.Delete("Keys.bee");
                access.SaveKeys(Crypto.EncryptString128Bit(G.Load.sKey, ""), "Keys.bee");
            }
            FormActive.KeyActive= addMac;
           
            if (G.IsActive)
            {

                ScanCCD.ConnectCCD();
             

            }
            else
            {
                tmActive.Enabled = true;

            }
            lbActive.Text = sActive;
        }
        public String sActive = "";

        private void WLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                if (Properties.Settings.Default.macAdd == "")
                {

                    addMac = Decompile.GetMacAddress();
                }
                else
                {
                    addMac = Properties.Settings.Default.macAdd;

                }



                FormActive.CheckActive(addMac);

                if (G.Config.IDCamera != null)
                    if (G.Config.IDCamera != "")
                {if (ScanCCD == null) ScanCCD = new ScanCCD();
                        if (G.Config.Resolution == null) G.Config.Resolution = "1280x720 (1.3 MP)";
                        int indexCCD = listCCD.FindIndex(a => a.Contains(G.Config.IDCamera));
                        ScanCCD.cbReSolution.SelectedIndex = ScanCCD.cbReSolution.FindStringExact(G.Config.Resolution);
                       
                        if (indexCCD != -1&& G.Config.Resolution.Trim() != "")
                            ScanCCD.cbCCD.SelectedIndex = indexCCD;
                        else
                        {
                            ScanCCD.cbCCD.SelectedIndex = -1;
                        }    
                          



                    }
              

            }
            catch (Exception)
            {

            }
        }
        List<String> listCCD;
        ScanCCD ScanCCD = new ScanCCD();
        private void TmLoad_Tick(object sender, EventArgs e)
        {
            if (File.Exists("Default.config"))
                G.Config = Access.LoadConfig("Default.config");
            else
                G.Config = new Config();
            tmLoad.Enabled = false;
            listCCD = ScanCCD.ScanIDCCD();
            wLoad.RunWorkerAsync();

        }

        private void TmActive_Tick(object sender, EventArgs e)
        {
            this.Hide();
         
          
           if(ScanCCD==null)
                ScanCCD  = new ScanCCD();
            ScanCCD.Show();
         //   FormActive.Show();
            tmActive.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormLoad_Load(object sender, EventArgs e)
        {

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);


            tmLoad.Interval = 1000;
            tmLoad.Enabled = true;


        }

      
    }
}
