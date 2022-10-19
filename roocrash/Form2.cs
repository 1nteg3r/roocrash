using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roocrash
{
    public partial class Form2 : Form
    {
        bool mouseDown;
        private Point offset;
        public Form2()
        {
            InitializeComponent();
            string[] array = new string[102]
            {
                "ProcessHacker","CCleaner", "procmon64", "codecracker", "x96dbg",
                "pizza", "pepper", "reverse", "reversal", "de4dot", "pc-ret", "crack", "ILSpy", "x32dbg", "sharpod",
                "x64dbg", "x32_dbg", "x64_dbg", "debug", "dbg", "strongod", "PhantOm", "titanHide", "scyllaHide", "ilspy",
                "graywolf", "simpleassemblyexplorer", "MegaDumper", "megadumper", "X64NetDumper", "x64netdumper", "HxD", "hxd", "PETools", "petools",
                "Protection_ID", "protection_id", "die", "process hacker 2", "process", "hacker", "ollydbg", "x32dbg", "x64dbg", "ida -",
                "charles", "dnspy", "simpleassembly", "peek", "httpanalyzer", "httpdebug", "proxifier", "mitmproxy",
                "process hacker", "process monitor", "process hacker 2", "system explorer", "systemexplorer", "systemexplorerservice", "WPE PRO", "ghidra", "folderchangesview", "pc-ret",
                "folder", "dump", "proxy", "de4dotmodded", "StringDecryptor", "Centos", "SAE", "monitor", "brute", "checker",
                "zed", "sniffer", "http", "debugger", "james", "exeinfope", "codecracker", "x32dbg", "x64dbg", "ollydbg",
                "ida", "charles", "dnspy", "simpleassembly", "peek", "httpanalyzer", "httpdebug",  "dbx", "Cheat Engine",
                "mdbg", "gdb", "windbg", "dbgclr", "kdb", "kgdb", "mdb", "pd.exe", "pd64.exe", "pd32.exe"
            };
            for (int i = 0; i < array.Length; i++)
            {
                Process[] processesByName = Process.GetProcessesByName(array[i]);
                for (int j = 0; j < processesByName.Length; j++)
                {
                    processesByName[j].Kill();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Value = 0;
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Maximum = 100;

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process[] procs = Process.GetProcessesByName("Chrome");
            for (int i = 0; i < procs.Length; i++)
            {
                procs[i].Kill();
            }
            if (procs.Length == 0 || procs.Length > 0)
            {
                MessageBox.Show("Opening chrome and roobet.");
                Process.Start("chrome.exe", "https://roobet.com/crash");
            }




            for (int i = 0; i <= 100; i++)
            {
                
                InjectButton.Enabled = false;
                Thread.Sleep(5);
                guna2CircleProgressBar1.Value = i;
                guna2CircleProgressBar1.Update();
                if (i == 100)
                {

                    InjectButton.Text = "Injected.";
                    HashButton.Enabled = true;
           
                }
                


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HashButton_Click(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[32];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            HashBox.Text = finalString;

            predlabel.Enabled = true;


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mouseDown_Event(object sender, MouseEventArgs e) // za da moze da se dvizi prozorot posho sme u borderless
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e) //dopolnitelni stvari za da moze da se dvizi prozorot posho sme u borderless
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - -offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)  //ushe malce dopolnitelni stvari za da moze da se dvizi prozorot posho sme u borderless
        {
            mouseDown = false;
        }
    }
}
