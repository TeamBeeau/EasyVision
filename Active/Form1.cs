
using BeeUi.Commons;
using LibSharp;
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

namespace Active
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMac.Text = Decompile.GetMacAddress();
        }
        String addMac = "";
        // KeyAcitve KeyAcitve;
        Crypto Crypto = new Crypto();
        private void btnAcitve_Click(object sender, EventArgs e)
        {
            String[] content = txtMac.Text.Split('*');
            addMac = content[0] ;
            addMac += "*" + content[1] ;
            addMac += "*" + date.Value.ToString("yyyy/MM/dd");
            addMac += "*" + cbType.Text;
           addMac += "*" + (int) numDay.Value;
             txtKey.Text = Crypto.EncryptString128Bit(addMac, "b@@");


            //Decompile.Compile(skey);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile.FileName = "Key" + cbType.Text + ".bee";
            if (saveFile.ShowDialog()==DialogResult.OK)
            {
             
                Access.SaveKeys(txtKey.Text, saveFile.FileName);
                //Access access = new Access();
                // access.SaveKeys(txtKey.Text, saveFile.FileName);
                //  File.WriteAllText(saveFile.FileName, txtKey.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                txtMac.Text=Crypto.DecryptString128Bit( Access.LoadKeys(openFile.FileName),"b@@");
            }    
        }
    }
}
