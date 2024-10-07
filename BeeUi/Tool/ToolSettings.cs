using BeeCore;
using BeeUi.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeUi.Tool
{
    public partial class ToolSettings : UserControl
    {
        public ToolSettings()
        {
            InitializeComponent();
            G.ToolSettings = this;
        }
        public int X = 10, Y = 10;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (G.AddTool == null)
                G.AddTool = new AddTool();
            G.AddTool.Show();
        }

        private void btnDelect_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xóa","Bạn chắc chứ",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if (G.indexToolSelected>-1)
                {
                    G.ToolSettings.pAllTool.Controls.RemoveAt(G.indexToolSelected);
                    G.PropetyTools.RemoveAt(G.indexToolSelected);
                    G.listAlltool.RemoveAt(G.indexToolSelected);
                }    
            }    
        }

        private void btnEnEdit_Click(object sender, EventArgs e)
        {
            if(btnEnEdit.IsCLick)
            {
            foreach(Commons.Tools tool in G.listAlltool)
                {
                    tool.ItemTool.Score.Enabled = true;
                }    
            } 
            else
            {
                foreach (Commons.Tools tool in G.listAlltool)
                {
                    tool.ItemTool.Score.Enabled = false;
                }
            }    
        }
     
        private void btnCopy_Click(object sender, EventArgs e)
        {

       
          PropetyTool propety = (PropetyTool)G.PropetyTools[G.indexToolSelected].Clone();
       
            propety.Name = propety.TypeTool.ToString() + " " + (int)(G.PropetyTools.Count + 1);
            G.PropetyTools.Add(propety);
            G.Header.CreateItemTool(propety);
          

         

        }

        private void itemTool1_Load(object sender, EventArgs e)
        {

        }
    }

}
