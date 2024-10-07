using BeeCore;
using BeeUi.Commons;
using BeeUi.Tool;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace BeeUi.Common
{
    [Serializable()]
    public partial class Header : UserControl
    {
      
        public Header()
        {
            InitializeComponent();
           
        }
        bool IsLoaded;
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (File.Exists("Program\\"+cbProgram.Text.Trim()))
                File.Delete("Program\\" + cbProgram.Text.Trim());
            Access.SaveProg("Program\\" + cbProgram.Text.Trim(), G.PropetyTools);
            if (File.Exists("Default.config"))
                File.Delete("Default.config");
            Access.SaveConfig("Default.config", G.Config);
            MessageBox.Show("Save Program Success");
        }

        public dynamic LoadEidtGuiTool(TypeTool typeTool)
        {
            dynamic control = null;
            switch (typeTool)
            {
                case TypeTool.OutLine:

                    control = new ToolOutLine();

                    break;
                case TypeTool.Color_Area:
                    control = new ToolColorArea();
                    break;
                case TypeTool.Pattern:
                    control = new ToolPattern();
                    break;
                case TypeTool.Position_Adjustment:
                    control = new ToolPosition_Adjustment();
                    break;
                case TypeTool.Edge_Pixels:
                    control = new ToolEdgePixels();
                    break;
                default:
                    control = new ToolOutLine();
                    break;
            }
            return control;
        }
        public void CreateItemTool(PropetyTool propety)
        {
            TypeTool TypeTool = propety.TypeTool;
            dynamic control = LoadEidtGuiTool(TypeTool);
            int with = 50, height = 50;
            control.Propety = propety.Propety;
            RectRotate rotCrop = control.Propety.rotCrop;
            if (rotCrop != null)
            {
                if (rotCrop._PosCenter.X + rotCrop._rect.X + rotCrop._rect.Width > BeeCore.Common.SizeCCD().Width ||
                    rotCrop._PosCenter.Y + rotCrop._rect.Y + rotCrop._rect.Height > BeeCore.Common.SizeCCD().Height)
                    control.Propety.rotCrop = new RectRotate(new RectangleF(-with / 2, -height / 2, with, height), new PointF(BeeCore.Common.matRaw.Width / 2, BeeCore.Common.matRaw.Height / 2), 0, AnchorPoint.None);

            }
            RectRotate rotArea = control.Propety.rotArea;
            if (rotArea._PosCenter.X + rotArea._rect.X + rotArea._rect.Width > BeeCore.Common.SizeCCD().Width ||
                rotArea._PosCenter.Y + rotArea._rect.Y + rotArea._rect.Height > BeeCore.Common.SizeCCD().Height)
                control.Propety.rotArea = new RectRotate(new RectangleF(-BeeCore.Common.SizeCCD().Width / 2 + BeeCore.Common.SizeCCD().Width / 10, -BeeCore.Common.SizeCCD().Height / 2 + BeeCore.Common.SizeCCD().Width / 10, BeeCore.Common.SizeCCD().Width - BeeCore.Common.SizeCCD().Width / 5, BeeCore.Common.SizeCCD().Height - BeeCore.Common.SizeCCD().Width / 5), new PointF(BeeCore.Common.SizeCCD().Width / 2, BeeCore.Common.SizeCCD().Height / 2), 0, AnchorPoint.None);
           
       
            ItemTool item = new ItemTool(TypeTool, TypeTool.ToString() + Convert.ToString(G.listAlltool.Count - 1));
            item.Location = new Point(G.ToolSettings.X, G.ToolSettings.Y);
            item.lbCycle.Text = "---";
            item.lbScore.Text = "---";
            item.lbStatus.Text = "---";
            item.Score.Value = Convert.ToInt32((double)control.Propety.Score);
            item.lbScore.ForeColor = Color.Gray;
            item.lbStatus.BackColor = Color.Gray;
            G.ToolSettings.Y += item.Height + 10;
            item.Parent = G.ToolSettings.pAllTool;

            G.listAlltool.Add(new Tools(item, control, TypeTool));
            control.indexTool = G.listAlltool.Count - 1;
            BeeCore.Common.CreateTemp(TypeTool);
            control.LoadPara(propety.Propety);

            item.lbNumber.Text = G.listAlltool.Count() + "";
            if (propety.Name == null) propety.Name = "";
            if (propety.Name.Trim() == "")
                item.name.Text = TypeTool.ToString() + " " + G.listAlltool.Count();
            else
                item.name.Text = propety.Name.Trim();
            item.icon.Image = (Image)Properties.Resources.ResourceManager.GetObject(TypeTool.ToString());
           
           
        }
        String pathOld = "";
        public void LoadProg(String PathProg)
        {
            
              if (G.EditTool.View == null)
            {
              
                G.EditTool.View = new View();
                G.EditTool.View.Dock = DockStyle.Fill;
                G.EditTool.View.Parent = G.EditTool.pView;
            }
            
               
            
            if (G.ToolSettings == null)
            {
                G.ToolSettings = new ToolSettings();

            }
           
                BeeCore.Common.ReadCCD(G.Config.IsHist, G.Config.TypeCamera);
                BeeCore.Common.matRaw = BeeCore.Common.GetImageRaw(G.Config.TypeCamera);
          
            if(BeeCore.Common.matRaw!=null)
            G.EditTool.View.bmMask = new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1);
            G.ToolSettings.Parent = G.EditTool.pEditTool;
            G.ToolSettings.Visible = true;
            G.ToolSettings.Dock = DockStyle.Fill;
            if (G.StepEdit.SettingStep2!=null&& G.StepEdit.SettingStep2.Parent!=null)
            G.StepEdit.SettingStep2.Parent.Controls.Remove(G.StepEdit.SettingStep2);
            if (G.StepEdit.SettingStep1 != null && G.StepEdit.SettingStep1.Parent != null)
                G.StepEdit.SettingStep1.Parent.Controls.Remove(G.StepEdit.SettingStep1);
            if (G.StepEdit.SettingStep4 != null && G.StepEdit.SettingStep4.Parent != null)
                G.StepEdit.SettingStep4.Parent.Controls.Remove(G.StepEdit.SettingStep4);
            if (pathOld== PathProg)
            {
                return;

            }
            pathOld = PathProg;
            G.listAlltool = new List<Tools>();
            G.PropetyTools = new List<PropetyTool>();
            if (File.Exists(PathProg))
                G.PropetyTools = Access.LoadProg(PathProg);
            else
                G.PropetyTools = new List<PropetyTool>();
        
            G.ToolSettings.pAllTool.Controls.Clear();
            G.ToolSettings.Y = 10; G.ToolSettings.X = 5;
            foreach (PropetyTool propety in G.PropetyTools)
            {

                CreateItemTool(propety);

            }
            G.IsLoad = true;
            IsLoaded = true;
          
         listPorts = SerialPort.GetPortNames();
            ConnectCom();
        }
        string[] listPorts;
       bool IsWaitPort = false;
        public String IdPort = "";
        public int indexScan = 0;
        Timer tmScanPort = new Timer();
       
        public async void ConnectCom()
        {
            
       
          
                try
            {
                if (G.Config.namePort != null)
                {
                    if (G.Config.namePort.Trim() != "")
                    {
                       
                        SerialPort.PortName = G.Config.namePort.Trim();
                        SerialPort.BaudRate = 115200;
                        SerialPort.Open();
                        if (SerialPort.IsOpen)
                        {
                            SerialPort.WriteLine("Connect");
                        }
                    }
                   
                }
                

            }
            catch(Exception ex)
            {

            }
        }

        private async void TmScanPort_Tick(object sender, EventArgs e)
        {
         
        }

        public void Acccess(bool IsRun)
        {
            if(IsRun)
            {
                G.EditTool.pName.Visible = false;
               
            }
            else
            {
                G.EditTool.pName.Visible = true;
             
            }
           
            btnUser.Text = G.Config.nameUser;
            if (G.Config.nameUser == "Admin")
            {
                G.EditTool.View.btnResetQty.Enabled = true;
                G.EditTool.View.btnRecord.Enabled = true;
                G.EditTool.View.btnLive.Enabled = true;
                G.EditTool.View.btnTest.Enabled = true;
                G.EditTool.View.btnCalib.Enabled = true;
                cbProgram.Enabled = IsRun;
                btnMode.Enabled = true;
                btnReport.Enabled = true;
                btnSave.Enabled = true;
               
                btnAdd.Enabled = IsRun;
               
                   btnSaveAs.Enabled = IsRun;
              
                    btnDelect.Enabled = IsRun;
                btnIO.Enabled = true;
            }
            else if (G.Config.nameUser == "Leader")
            {
                G.EditTool.View.btnRecord.Enabled = false;
                G.EditTool.View.btnLive.Enabled = false;
                G.EditTool.View.btnTest.Enabled = true;
                G.EditTool.View.btnCalib.Enabled = true;
               cbProgram.Enabled = IsRun;
                G.EditTool.View.btnResetQty.Enabled = true;
                btnMode.Enabled = false;
                btnReport.Enabled = true;

                btnSave.Enabled = true;
                btnAdd.Enabled = false;
                btnSaveAs.Enabled = false;
                btnDelect.Enabled = false;
                btnIO.Enabled = false;
            }
            else 
            {
                G.EditTool.View.btnRecord.Enabled = false;
                G.EditTool.View.btnLive.Enabled = false;
                G.EditTool.View.btnTest.Enabled = false;
                G.EditTool.View.btnCalib.Enabled = false;
                cbProgram.Enabled = IsRun;
                btnReport.Enabled = false;
                btnMode.Enabled = false;
                G.EditTool.View.btnResetQty.Enabled = false;
                btnSave.Enabled = true;
                btnAdd.Enabled = false;
                btnSaveAs.Enabled = false;
                btnDelect.Enabled = false;
                btnIO.Enabled = false;
                
            }
        }
        private void btnMode_Click(object sender, EventArgs e)
        {
            if (G.Config.nameUser != "Admin")
                return;
            if (G.IsCap)
            {
                MessageBox.Show("Please Stop Mode Continuous");
                return;
            }
            foreach (Tools tool in  G.listAlltool)
            {
                tool.ItemTool.IsCLick = false;
            }    
            G.IsRun = !G.IsRun;
          
            if(G.IsRun)
            {
              
                G.StepEdit.Dock = DockStyle.None;
                G.EditTool.View.pStatus.Visible = true;
                G.StepEdit.Visible = false ;
              
                G.ToolSettings.btnAdd.Enabled = false;
                G.ToolSettings.btnCopy.Enabled = false;
                G.ToolSettings.btnDelect.Enabled = false;
                G.ToolSettings.btnEnEdit.Enabled = true;
                btnMode.Text = "RUN";
                btnMode.BackColor = Color.DarkSlateGray;
            } 
            else
            {
                if (G.ToolSettings.btnEnEdit.IsCLick)
                    G.ToolSettings.btnEnEdit.PerformClick();
                G.EditTool.View.pStatus.Visible = false;
                G.StepEdit.Parent = G.EditTool.View;
                G.StepEdit.Visible = true;
                G.StepEdit.Dock = DockStyle.Top;
                G.EditTool.View.imgView.BringToFront();
                //G.StepEdit.BringToFront();
              
                G.ToolSettings.btnAdd.Enabled = true;
                G.ToolSettings.btnCopy.Enabled = true;
                G.ToolSettings.btnDelect.Enabled = true;
                G.ToolSettings.btnEnEdit.Enabled = false;
                btnMode.Text = "EDIT";
                btnMode.BackColor = Color.FromArgb(101, 173, 245);
            }
            if (btnMode.Text=="RUN")
            {
                if (G.Header.SerialPort.IsOpen)
                    G.Header.SerialPort.WriteLine("Runn");
            }
            else
            {
                if (G.Header.SerialPort.IsOpen)
                    G.Header.SerialPort.WriteLine("Edit");
            }
                   
            Acccess(G.IsRun);
        }
        String[] PathFile;
        bool IsLoad = false;
        private void Header_Load(object sender, EventArgs e)
        {
            if (G.IsLoad) return;
            this.myDelegate = new AddDataDelegate(AddDataMethod);

            if (!Directory.Exists("Program"))
            {
                Directory.CreateDirectory("Program");
            }    
            else
            {
               // Access.SaveProg("Program\\Default.prog", new List<PropetyTool>());
                string[] files = Directory.GetFiles("Program", "*.prog", SearchOption.TopDirectoryOnly);
                
                PathFile = files.Select(a => Path.GetFileName(a)).ToArray();
                cbProgram.DataSource = PathFile;
                if(cbProgram.FindStringExact(Properties.Settings.Default.programCurrent)==0)
                {
                    this.LoadProg("Program\\" + cbProgram.Text.Trim());
                }    
                    }
            Acccess(G.IsRun);
            G.Main.Location = new Point(0,0);

        }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if(!IsLoad)
            {
                IsLoad = true;
                cbProgram.SelectedIndex = cbProgram.FindStringExact(Properties.Settings.Default.programCurrent);
                return;
            }
            if (IsSaveAs)
            {
                IsSaveAs = false;
                return;
            }
            if (G.IsCCD)
            {

                this.LoadProg("Program\\"+cbProgram.Text.Trim());
                Properties.Settings.Default.programCurrent = cbProgram.Text.Trim();
                Properties.Settings.Default.Save();

            }
        }
        bool IsSaveAs = false;
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveFile.InitialDirectory = System.IO.Directory.GetCurrentDirectory()+ "\\Program";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Access.SaveProg(saveFile.FileName, G.PropetyTools);
                string[] files = Directory.GetFiles("Program", "*.prog", SearchOption.TopDirectoryOnly);

                PathFile = files.Select(a => Path.GetFileName(a)).ToArray();
                cbProgram.DataSource = PathFile; IsSaveAs = true;
                cbProgram.SelectedIndex = cbProgram.Items.Count - 1;

                // File.Copy("Program\\" + cbProgram.Text.Trim(), saveFile.FileName,true);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            G.PropetyTools = new List<PropetyTool>();
            saveFile.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\Program";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Access.SaveProg(saveFile.FileName, G.PropetyTools);
                string[] files = Directory.GetFiles("Program", "*.prog", SearchOption.TopDirectoryOnly);

                PathFile = files.Select(a => Path.GetFileName(a)).ToArray();
                cbProgram.DataSource = PathFile; IsSaveAs = true;
                cbProgram.SelectedIndex = cbProgram.Items.Count - 1;

               
            }
        }

        private void btnDelect_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn Xóa  Model này ?", " Xóa  Model", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indexCur = cbProgram.SelectedIndex;

                cbProgram.SelectedIndex = indexCur - 1;
                File.Delete("Program\\" + cbProgram.Items[indexCur].ToString());
                string[] files = Directory.GetFiles("Program", "*.prog", SearchOption.TopDirectoryOnly);
                PathFile = files.Select(a => Path.GetFileName(a)).ToArray();
                cbProgram.DataSource = PathFile; IsSaveAs = true;
                cbProgram.SelectedIndex = indexCur - 1;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        String sRecept = "";
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;
      
    public void AddDataMethod(String myString)
    {
        G.EditTool.txtRecept.Text=myString;
            
            if (sRecept.Contains("IO-DWC-1.0")&& !IsWaitPort)
            {
                IsWaitPort = true;
                tmScanPort.Tick -= TmScanPort_Tick;
                tmScanPort.Enabled = false;
             
                G.EditTool.toolStripPort.Image = Properties.Resources.PortConnected;
                G.EditTool.toolStripPort.Text = "Port Connected";
                if (File.Exists("Default.config"))
                    File.Delete("Default.config");
                Access.SaveConfig("Default.config", G.Config);
                G.EditTool.View.tmCheckPort.Enabled = true;
            }
           else if  (sRecept.Contains("Trig"))
                {
                //SerialPort.WriteLine("Done");
                G.EditTool.View.btnCap.PerformClick();
                }
            else if (sRecept.Contains("Mod"))
            {
                //SerialPort.WriteLine("Done");
                btnMode.PerformClick();
                if (btnMode.Text=="RUN")
                    SerialPort.WriteLine("Run");
                else
                    SerialPort.WriteLine("Edit");
            }
            else if (sRecept.Contains("Rec"))
            {
              G.EditTool.View.btnLive.PerformClick();
                if (G.EditTool.View.btnLive.IsCLick)
                    SerialPort.WriteLine("Live");
                else
                    SerialPort.WriteLine("Cap");
            }
            else if (sRecept.Contains("Done"))
            {
               // G.IsDone = false;
            }
        }
    private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            sRecept =SerialPort.ReadExisting();
            textBox1.Invoke(this.myDelegate, new Object[] { sRecept });

          
        }

        private void btnIO_Click(object sender, EventArgs e)
        {
            IOSetting IOSetting = new IOSetting();
            IOSetting.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport FormReport = new FormReport();
            FormReport.Show();
           
        }
       
        private void workConnect_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void workConnect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            G.account = new Account();
            G.account.cbUser.SelectedIndex= G.account.cbUser.FindStringExact(G.Config.nameUser);


           G.account.Location = new Point(G.Main.Location.X + G.Main.Width / 2 - G.account.Width / 2, G.Main.Location.Y + G.Main.Height / 2 - G.account.Height / 2);
            G.account.Show();
        }
    }
}
