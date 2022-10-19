using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace roocrash
{
    public partial class Form1 : Form

    {


[System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);



        bool mouseDown;
        private Point offset;
        public Form1()
        {
            InitializeComponent();
            string[] array = new string[103]
            {
                "ProcessHacker", "regedit", "CCleaner", "procmon64", "codecracker", "x96dbg",
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e) // link za do roobet demek sme legit hahah
        {
            Process.Start("https://roobet.com/");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)  //linkov e u dosno kjose, ke nosi do stranata kaj sho ke mozat da kupat kljuc
        {
            Process.Start("https://tefan.sellix.io/product/625a46e859aa0");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)  // custom x-ot sho e u kjoshe mesto stock windows grdi kopcinja
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) // panel sho sluzi za da se dvizi prozorot 
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
            if(mouseDown==true)
            {
                Point currentScreenPos = PointToScreen(e.Location); 
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - -offset.Y);   
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)  //ushe malce dopolnitelni stvari za da moze da se dvizi prozorot posho sme u borderless
        {
            mouseDown = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e) //link za do discordot
        {
            Process.Start("https://discord.gg/YYTYt9JB");
        }

        
        private void guna2GradientButton1_Click(object sender, EventArgs e) //-------------------LOGIN SYSTEM------------- //proveruva na databzata sho ni e na pastebin hahahahaha
        {
            string[] array = new string[6]
            {
                "Fiddler Everywhere", "Fiddler", "fiddler", "Fiddler Classic", "WireShark","wireshark"
            };
            for (int i = 0; i < array.Length; i++)
            {
                Process[] processesByName = Process.GetProcessesByName(array[i]);
                for (int j = 0; j < processesByName.Length; j++)
                {
                    MessageBox.Show("App can't run with Fiddler or Wireshark open.");
                    Application.Exit();
                    //processesByName[j].Kill();
                }
            }


                //Process[] pname = Process.GetProcessesByName(array);
                //{
                //    if (pname.Length > 0)
                //    {
                //        MessageBox.Show("App can't run with Fiddler open.");
                //        Application.Exit();
                //    }
                //}

                bool CheckNet()
            {
                int desc;
                return InternetGetConnectedState(out desc, 0);
            }

            if (CheckNet() == false)
            {
                MessageBox.Show("Internet needed for Roocrash to work!");
                Application.Exit();
            }


            string paste = new System.Net.WebClient() { Proxy = null }.DownloadString("https://pastebin.com/raw/5bEc5awz");
            if (paste.Contains(guna2TextBox1.Text) && guna2TextBox1.Text != "")
            {
                MessageBox.Show("Correct key!");
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid key, please contact tefan#7872 on discord!");
            }
        }
    }
}
