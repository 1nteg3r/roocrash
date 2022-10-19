namespace roocrash
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.InjectButton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.HashButton = new Guna.UI2.WinForms.Guna2Button();
            this.HashBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.predlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Animated = true;
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            resources.ApplyResources(this.guna2CircleProgressBar1, "guna2CircleProgressBar1");
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Maximum = 101;
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.Khaki;
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.Gold;
            this.guna2CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShowText = true;
            this.guna2CircleProgressBar1.TabStop = false;
            this.guna2CircleProgressBar1.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // InjectButton
            // 
            this.InjectButton.Animated = true;
            this.InjectButton.AutoRoundedCorners = true;
            this.InjectButton.BackColor = System.Drawing.Color.Transparent;
            this.InjectButton.BorderRadius = 12;
            this.InjectButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.InjectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InjectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InjectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InjectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InjectButton.FillColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.InjectButton, "InjectButton");
            this.InjectButton.ForeColor = System.Drawing.Color.White;
            this.InjectButton.Name = "InjectButton";
            this.InjectButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // guna2VSeparator1
            // 
            resources.ApplyResources(this.guna2VSeparator1, "guna2VSeparator1");
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            // 
            // HashButton
            // 
            this.HashButton.Animated = true;
            this.HashButton.AutoRoundedCorners = true;
            this.HashButton.BackColor = System.Drawing.Color.Transparent;
            this.HashButton.BorderRadius = 12;
            this.HashButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HashButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HashButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HashButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.HashButton, "HashButton");
            this.HashButton.FillColor = System.Drawing.Color.Navy;
            this.HashButton.ForeColor = System.Drawing.Color.White;
            this.HashButton.Name = "HashButton";
            this.HashButton.Click += new System.EventHandler(this.HashButton_Click);
            // 
            // HashBox
            // 
            this.HashBox.AutoRoundedCorners = true;
            this.HashBox.BorderRadius = 17;
            this.HashBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HashBox.DefaultText = "";
            this.HashBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HashBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HashBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HashBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.HashBox, "HashBox");
            this.HashBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HashBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HashBox.Name = "HashBox";
            this.HashBox.PasswordChar = '\0';
            this.HashBox.PlaceholderText = "";
            this.HashBox.SelectedText = "";
            this.HashBox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // predlabel
            // 
            resources.ApplyResources(this.predlabel, "predlabel");
            this.predlabel.ForeColor = System.Drawing.Color.Gold;
            this.predlabel.Name = "predlabel";
            this.predlabel.Tag = "d";
            this.predlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.predlabel);
            this.Controls.Add(this.HashBox);
            this.Controls.Add(this.HashButton);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.InjectButton);
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2Button InjectButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button HashButton;
        private Guna.UI2.WinForms.Guna2TextBox HashBox;
        private System.Windows.Forms.Label predlabel;
        private System.Windows.Forms.Panel panel1;
    }
}