using BeeCore;
using BeeUi.Commons;
using BeeUi.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeUi
{
    [Serializable()]
    public partial class EditTool : UserControl
    {
        public EditTool()
        {
            InitializeComponent();
            

        }
        public void DesTroy()
        {
            BeeCore.Common.DestroyAll();
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            BeeCore.Common.DestroyAll();
        }

        public View View;
     
        private void stepEdit1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stepEdit1_Load_1(object sender, EventArgs e)
        {

        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void outLine11_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

       
        private void EditTool_Load(object sender, EventArgs e)
        {
            G.EditTool.lbLicence.Text = "Licence: " + G.Licence;

        }

        private void outLine_Load(object sender, EventArgs e)
        {

        }
       
       
    
        int indexTool = 0;
        private void btnTool_Click(object sender, EventArgs e)
        {
            //indexTool++;
            //if (indexTool < Enum.GetNames(typeof(TypeTool)).Length)
            //{
            //    LoadTool((TypeTool)indexTool);
            //    lbTool.Text = Convert.ToString((TypeTool)(indexTool));
            //}
            //else
            //{
            //    indexTool = 0;
            //    LoadTool((TypeTool)indexTool);
            //    lbTool.Text = Convert.ToString((TypeTool)(indexTool));
            //}
              
        }

        private void pEditTool_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pEditTool_ControlAdded(object sender, ControlEventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void header1_Load(object sender, EventArgs e)
        {

        }

        private void stepEdit1_Load_2(object sender, EventArgs e)
        {

        }

        private void header1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
