using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace roocrash
{
    public partial class Form1 : Form

    {
        bool eb = false;
        bool mouseDown;
        private Point offset;
        public Form1()
        {
            InitializeComponent();
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
            string paste = new System.Net.WebClient() { Proxy = null }.DownloadString("https://pastebin.com/raw/5bEc5awz");
            if (paste.Contains(guna2TextBox1.Text) && guna2TextBox1.Text != "")
            {
                eb = true;
                MessageBox.Show("Correct key!");
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                eb = false;
                MessageBox.Show("Invalid key, please contact tefan#7872 on discord!");
            }
        }
    }
}
