﻿using BeeCore;
using BeeUi.Common;
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
{
    public partial class ToolPage : UserControl
    {
        public ToolPage()
        {
            InitializeComponent();
        }
        //23
        public RJButton NewRadioButton(String name,int y)
        {
            RJButton btn = new RJButton();
            btn.Name = "btn" + name;
          btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            if (IsRect)
            {
                btn.IsCLick = true;
                btn.BackgroundImage = global::BeeUi.Properties.Resources.btnChoose;
                IsRect = false;
            }
            else
                btn.BackgroundImage = global::BeeUi.Properties.Resources.btnUnChoose;
            btn.BorderColor = System.Drawing.Color.Silver;
          btn.BorderRadius = 5;
           btn.BorderSize = 1;
           btn.FlatAppearance.BorderSize = 0;
           btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           btn.ForeColor = System.Drawing.Color.White;
          
            btn.Image = (Image)Properties.Resources.ResourceManager.GetObject(name.Trim());
          
                name = name.Replace("_", " ");
            if (name.Length < lenMax)
            {
                int numLen = lenMax - name.Length;
                for ( int i= 0;i<numLen;i++)
                    name += " ";
                name += ".";
            }
           
                btn.Text = name;
          
                btn.Location = new System.Drawing.Point(25, y);
          //  if (!btn.Text.Contains("Color Area"))
            //    btn.Enabled = false;
           btn.Size = new System.Drawing.Size(277, 44);
          btn.TabIndex = 0;
            btn.Click += Btn_Click;
           btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           btn.TextColor = System.Drawing.Color.Black;
          btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         btn.UseVisualStyleBackColor = false;
        
            return btn;
        }
      public  TypeTool TypeTool;

        private void Btn_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            String nameBtn = btn.Name.Replace("btn", "");

            TypeTool = (TypeTool)Enum.Parse(typeof(TypeTool), nameBtn, true);
         int index=   G.listItool.FindIndex(a => a.TypeTool == TypeTool);
            if(index>-1)
            { String name = nameBtn.Replace("_", " ");
                lbName.Text = name;
                lbContent.Text = G.listItool[index].Content;
                img.Image= (Image)Properties.Resources.ResourceManager.GetObject("content"+ nameBtn);
            }
        }

        public List<string> GetListTool()
        {
            return Enum.GetNames(typeof(TypeTool)).ToList();

        }
        //
        public static List<string> listContent = new List<string>
        {

        "Position_Adjustment",
       "Pattern" ,
       "OutLine" ,
       "Edge_Pixels" ,
        "Color_Area",
       "Width" ,
       "Diameter" ,
       "Edge" ,
        " Pitch",
        "OCR"
        };
        public static List<GroupTool> groupTools = new List<GroupTool>
        {
            GroupTool.Basic_Tool,
            GroupTool.Basic_Tool,
            GroupTool.Basic_Tool,
            GroupTool.Basic_Tool,
            GroupTool.Basic_Tool,
            GroupTool.Extra_Tool_1,
            GroupTool.Extra_Tool_1,
            GroupTool.Extra_Tool_1,
            GroupTool.Extra_Tool_1,
            GroupTool.Extra_Tool_2,
            GroupTool.Extra_Tool_2,
        };
        int lenMax = 0;
        public void LoadAllInforTool()
        {
            IsRect = true;
            G.listItool = new List<iTool>();
            int ix = 0;
            Basic_Tool.Controls.Clear();
            Extra_Tool_1.Controls.Clear();
            Extra_Tool_2.Controls.Clear();
            foreach (String nameTool in GetListTool())
            {
                if(lenMax< nameTool.Length)
                lenMax = nameTool.Length;
                TypeTool type = (TypeTool)Enum.Parse(typeof(TypeTool), nameTool, true);
                G.listItool.Add(new iTool(type,null, listContent[ix], groupTools[ix]));
                ix++;
            }
          }
        bool IsRect = true;
        public void LoadGuiAllTool()
        {
            int y= 23; int y2 = 23; int y3 = 23;
             foreach (iTool tool in G.listItool)
            {
               
                 String name = tool.TypeTool.ToString();
                GroupTool groupTool = tool.GroupTool;
                RJButton btn=new RJButton();
                    switch (groupTool)
                    {
                        case GroupTool.Basic_Tool:

                             btn = NewRadioButton(name, y);
                        y += 68;
                        btn.Parent = Basic_Tool;
                           
                            break;
                        case GroupTool.Extra_Tool_1:
                             btn = NewRadioButton(name, y2);
                        btn.Enabled = false;
                        y2 += 68;
                        btn.Parent = Extra_Tool_1;
                         
                            break;
                        case GroupTool.Extra_Tool_2:
                       
                        btn = NewRadioButton(name, y3);
                        btn.Enabled = false;
                        y3 += 68;
                        btn.Parent = Extra_Tool_2;
                           
                            break;

                }
       
                tool.Control = btn;



            }    
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void ToolPage_Load(object sender, EventArgs e)
        {
            LoadAllInforTool();
            LoadGuiAllTool();
        }

        private void tabTool_SelectedIndexChanged(object sender, EventArgs e)
        {

            TabPage tab= tabTool.SelectedTab;
          
                GroupTool group = (GroupTool)Enum.Parse(typeof(GroupTool), tab.Name, true);
            int index = G.listItool.FindIndex(a => a.GroupTool == group);
            if(index>-1)
            {
                RJButton rJButton = G.listItool[index].Control;
                
                rJButton.PerformClick();
                //foreach (Control c in tab.Controls)
                //{
                //    RJButton rJButton = c as RJButton;
                //    if (rJButton.Name.Contains("btn" + G.listItool[index].TypeTool.ToString()))
                //    {
                //        RJButton rJButton= G.listItool[index].Control;
                //    }    
                //    else
                //    {
                //        rJButton.IsCLick = false;
                //    }    
                //}    

            }    
            switch (group)
            {
                case GroupTool.Basic_Tool:
                   
                    break;
                case GroupTool.Extra_Tool_1:
                    break;
                case GroupTool.Extra_Tool_2:
                    break;
            }    
        }
        public dynamic LoadEidtGuiTool(TypeTool typeTool)
        {
            dynamic control= null;
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
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
            dynamic control = LoadEidtGuiTool(TypeTool);
            int with = 50, height = 50;
            if (TypeTool != TypeTool.Edge_Pixels&&
                TypeTool != TypeTool.Color_Area)
                control.Propety.rotCrop = new RectRotate(new RectangleF(-with / 2, -height / 2, with, height), new PointF(BeeCore.Common.matRaw.Width / 2, BeeCore.Common.matRaw.Height / 2), 0, AnchorPoint.None);
        
            control.Propety.rotArea = new RectRotate(new RectangleF(-BeeCore.Common.SizeCCD().Width / 2 + BeeCore.Common.SizeCCD().Width / 10, -BeeCore.Common.SizeCCD().Height / 2 + BeeCore.Common.SizeCCD().Width / 10, BeeCore.Common.SizeCCD().Width - BeeCore.Common.SizeCCD().Width / 5, BeeCore.Common.SizeCCD().Height - BeeCore.Common.SizeCCD().Width / 5), new PointF(BeeCore.Common.SizeCCD().Width / 2, BeeCore.Common.SizeCCD().Height / 2), 0, AnchorPoint.None);
           
            ItemTool item =      new ItemTool(TypeTool, TypeTool.ToString() + Convert.ToString(G.listAlltool.Count - 1));
            item.Location = new Point(G.ToolSettings.X, G.ToolSettings.Y);
            control.Propety.TypeTool = TypeTool;
            G.ToolSettings.Y += item.Height + 10; 
            item.Parent = G.ToolSettings.pAllTool;
            item.lbCycle.Text = "---";
            item.lbScore.Text = "---";
            item.lbStatus.Text = "---";
            G.listAlltool.Add(new Tools(item, control, TypeTool));
            control.indexTool = G.listAlltool.Count - 1;
            item.lbNumber.Text = G.listAlltool.Count()+"";
            item.name.Text = TypeTool.ToString() +" "+ G.listAlltool.Count();
            G.PropetyTools.Add(new PropetyTool(control.Propety, TypeTool, item.name.Text));
            item.icon.Image= (Image)Properties.Resources.ResourceManager.GetObject(TypeTool.ToString());
           
            BeeCore.Common.CreateTemp(TypeTool );
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
        }
    }
}
