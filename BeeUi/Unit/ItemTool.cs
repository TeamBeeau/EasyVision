using BeeCore;
using BeeUi.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeUi.Commons
{ [Serializable()]
    public partial class ItemTool : UserControl
    {
        public TypeTool TypeTool;
       
        public ItemTool(TypeTool typeTool,string names)
        {
          
            InitializeComponent();
          
            this.Name = names;
            this.TypeTool = typeTool;
            this.MouseMove += ItemTool_MouseMove;
            this.MouseLeave += ItemTool_MouseLeave;
            this.Click += ItemTool_Click;
          
           

            lbNumber.MouseMove += ItemTool_MouseMove;
            lbNumber.MouseLeave += ItemTool_MouseLeave;
            lbNumber.Click += ItemTool_Click;
            name.MouseMove += ItemTool_MouseMove;
            name.MouseLeave += ItemTool_MouseLeave;
            name.Click += ItemTool_Click;
            icon.MouseMove += ItemTool_MouseMove;
            icon.MouseLeave += ItemTool_MouseLeave;
            icon.Click += ItemTool_Click;
            this.DoubleClick += ItemTool_DoubleClick;
          
         


        }

        private void Parent_VisibleChanged1(object sender, EventArgs e)
        {
            if(Parent!=null)
            if(this.Parent.Visible)
                {
                    G.IsEdit = false;
                    if (G.listAlltool.FindIndex(a => a.ItemTool == this) != G.indexToolSelected) return;
                    if (G.PropetyOld != null&&G.IsCancel)
                    {
                        G.IsCancel = false;
                        G.listAlltool[G.indexToolSelected].tool.Propety = G.PropetyOld.Clone();
                        G.PropetyTools[G.indexToolSelected].Propety = G.listAlltool[G.indexToolSelected].tool.Propety;
                        G.EditTool.View.imgView.Invalidate();
                    }
                    Score.Value = G.PropetyTools[G.indexToolSelected].Propety.Score;
            }    
            
        }

        private void Parent_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void ItemTool_Click(object sender, EventArgs e)
        {
            if (G.IsRun) return;
            this.BackgroundImage = imgChoose;
            this.IsCLick = true;
            G.indexToolSelected = G.listAlltool.FindIndex(a => a.ItemTool == this);
            foreach (Control c in this.Parent.Controls)
            {

                if (c is ItemTool && c != this)
                {
                    ItemTool btn = c as ItemTool;
                    btn.IsCLick = false;
                   
                    c.BackgroundImage = imgUnChoose;
                }
            }
        }
        bool isCLick;
        public bool IsCLick
        {
            get { return this.isCLick; }
            set
            {
                this.isCLick = value;
                if (value)
                {
                    this.BackgroundImage = imgChoose;
                }
                else
                    this.BackgroundImage = imgUnChoose;
                this.Invalidate();

            }
        }
        private void ItemTool_MouseLeave(object sender, EventArgs e)
        {

            if (!IsCLick)
                this.BackgroundImage = imgUnChoose;
            else
                this.BackgroundImage = imgChoose;
          
        }

        private void ItemTool_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsCLick)
                this.BackgroundImage = imgSelect;
            else
                this.BackgroundImage = imgChoose;
            
        }

        Image imgChoose = Properties.Resources.btnChoose;
        Image imgSelect = Properties.Resources.btnSelect;
        Image imgUnChoose = Properties.Resources.btnUnChoose;
        private void ItemTool_Load(object sender, EventArgs e)
        {
            this.Parent.VisibleChanged += Parent_VisibleChanged1;
        }
        Control control=new Control();
       private void ItemTool_DoubleClick(object sender, EventArgs e)
        {
            G.indexToolSelected = G.listAlltool.FindIndex(a => a.ItemTool == this);
            G.PropetyOld = G.PropetyTools[G.indexToolSelected].Propety.Clone();
            if (Score.Enabled||G.IsRun) return;
            G.IsEdit = true;
            control = G.listAlltool[G.indexToolSelected].tool;
            control.Dock = DockStyle.Fill;
            G.EditTool.View.toolEdit = control;
            control.BringToFront();
            G.TypeCrop = TypeCrop.Area;
            if (TypeTool == TypeTool.Color_Area)
            {
                ToolColorArea colorArea = (ToolColorArea)control;
                colorArea.Propety.LoadTemp(G.IsCCD, G.Config.IsHist, G.Config.TypeCamera);
            }
            control.Parent = G.EditTool.pEditTool;
            control.MouseMove +=new System.Windows.Forms.MouseEventHandler( G.EditTool.View.tool_MouseMove);
           G.ToolSettings.Visible = false;
            G.EditTool.iconTool.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(TypeTool.ToString());
            G.EditTool.lbTool.Text = TypeTool.ToString();
            if (G.Config.matRegister != null)
            BeeCore.Common.matRaw = OpenCvSharp.Extensions.BitmapConverter.ToMat(G.Config.matRegister);
           else if(G.IsCCD)
                BeeCore.Common.matRaw = BeeCore.Common.GetImageRaw();
            G.EditTool.View.imgView.ImageIpl = BeeCore.Common.matRaw;
            G.listAlltool[G.indexToolSelected].tool.LoadPara(G.PropetyTools[G.indexToolSelected].Propety) ;
            G.EditTool.View.imgView.Invalidate();
            G.EditTool.View.imgView.Update();
        }

        private void Score_ValueChanged(int obj)
        {
            G.indexToolSelected = G.listAlltool.FindIndex(a => a.ItemTool == this);
            G.PropetyTools[G.indexToolSelected].Propety.Score = Score.Value;
            G.listAlltool[G.indexToolSelected].tool.trackScore.Value = Score.Value;
        }
        TextBox txtEdit = new TextBox();
        private void name_DoubleClick(object sender, EventArgs e)
        {
            G.indexToolSelected = G.listAlltool.FindIndex(a => a.ItemTool == this);

            if (G.IsRun) return;
            txtEdit.Visible = true;
            txtEdit.KeyDown -= TxtEdit_KeyDown;
            txtEdit.Parent = this;
            txtEdit.Font = name.Font;
            txtEdit.Location = new Point(name.Location.X, name.Location.Y - 2);
            txtEdit.Size = name.Size;
            txtEdit.BringToFront();
            txtEdit.Text = name.Text;
            txtEdit.Focus();
            txtEdit.KeyDown += TxtEdit_KeyDown;
        }

        private void TxtEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                G.PropetyTools[G.indexToolSelected].Name = txtEdit.Text.Trim();
                name.Text= txtEdit.Text.Trim();
                txtEdit.Visible = false;
            }    
        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
