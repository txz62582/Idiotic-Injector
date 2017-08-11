namespace idiotinjector
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class info : Form
    {
        [CompilerGenerated, AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label _Label1;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label2")]
        private Label _Label2;
        [CompilerGenerated, AccessedThroughProperty("LinkLabel1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LinkLabel _LinkLabel1;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("LinkLabel2"), CompilerGenerated]
        private LinkLabel _LinkLabel2;
        [AccessedThroughProperty("LinkLabel3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private LinkLabel _LinkLabel3;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("LinkLabel4")]
        private LinkLabel _LinkLabel4;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("LinkLabel5")]
        private LinkLabel _LinkLabel5;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("LinkLabel6")]
        private LinkLabel _LinkLabel6;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("LinkLabel7")]
        private LinkLabel _LinkLabel7;
        [AccessedThroughProperty("PictureBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private PictureBox _PictureBox1;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("username")]
        private Label _username;
        private IContainer icontainer_0;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label3"), CompilerGenerated]
        private Label wJfxuetnb6;

        public info()
        {
            Class8.Wc1jetPzTbITr();
            base.Load += new EventHandler(this.info_Load);
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.icontainer_0 > null))
                {
                    this.icontainer_0.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void info_Load(object sender, EventArgs e)
        {
            this.username.Text = Environment.UserName;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.LinkLabel1 = new LinkLabel();
            this.LinkLabel2 = new LinkLabel();
            this.LinkLabel3 = new LinkLabel();
            this.LinkLabel4 = new LinkLabel();
            this.LinkLabel5 = new LinkLabel();
            this.LinkLabel6 = new LinkLabel();
            this.Label3 = new Label();
            this.username = new Label();
            this.PictureBox1 = new PictureBox();
            this.LinkLabel7 = new LinkLabel();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            base.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Courier New", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0, 0x16);
            this.Label1.TabIndex = 1;
            this.Label2.AutoSize = true;
            this.Label2.Cursor = Cursors.Hand;
            this.Label2.Font = new Font("Courier New", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(0x12, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0xc5, 0x16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "made by idiotican";
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel1.LinkColor = Color.Green;
            this.LinkLabel1.Location = new Point(5, 0x1f);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new Size(0xe8, 0x10);
            this.LinkLabel1.TabIndex = 3;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "join the discord for updates";
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel2.LinkColor = Color.Green;
            this.LinkLabel2.Location = new Point(0x13, 0x2f);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new Size(0x60, 0x10);
            this.LinkLabel2.TabIndex = 4;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "change logs";
            this.LinkLabel3.AutoSize = true;
            this.LinkLabel3.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel3.LinkColor = Color.Green;
            this.LinkLabel3.Location = new Point(0x79, 0x2f);
            this.LinkLabel3.Name = "LinkLabel3";
            this.LinkLabel3.Size = new Size(0x58, 0x10);
            this.LinkLabel3.TabIndex = 5;
            this.LinkLabel3.TabStop = true;
            this.LinkLabel3.Text = "guidelines";
            this.LinkLabel4.AutoSize = true;
            this.LinkLabel4.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel4.LinkColor = Color.Green;
            this.LinkLabel4.Location = new Point(0x1d, 0x3f);
            this.LinkLabel4.Name = "LinkLabel4";
            this.LinkLabel4.Size = new Size(0x30, 0x10);
            this.LinkLabel4.TabIndex = 6;
            this.LinkLabel4.TabStop = true;
            this.LinkLabel4.Text = "music";
            this.LinkLabel5.AutoSize = true;
            this.LinkLabel5.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel5.LinkColor = Color.Green;
            this.LinkLabel5.Location = new Point(0x99, 0x40);
            this.LinkLabel5.Name = "LinkLabel5";
            this.LinkLabel5.Size = new Size(0x38, 0x10);
            this.LinkLabel5.TabIndex = 7;
            this.LinkLabel5.TabStop = true;
            this.LinkLabel5.Text = "status";
            this.LinkLabel6.AutoSize = true;
            this.LinkLabel6.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel6.LinkColor = Color.Green;
            this.LinkLabel6.Location = new Point(0x53, 0x40);
            this.LinkLabel6.Name = "LinkLabel6";
            this.LinkLabel6.Size = new Size(0x40, 0x10);
            this.LinkLabel6.TabIndex = 8;
            this.LinkLabel6.TabStop = true;
            this.LinkLabel6.Text = "credits";
            this.Label3.AutoSize = true;
            this.Label3.Cursor = Cursors.Arrow;
            this.Label3.Font = new Font("Courier New", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label3.Location = new Point(0x13, 80);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x62, 14);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "registered to";
            this.username.AutoSize = true;
            this.username.Cursor = Cursors.Arrow;
            this.username.Font = new Font("Courier New", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.username.Location = new Point(0x27, 0x5e);
            this.username.Name = "username";
            this.username.Size = new Size(0x3f, 14);
            this.username.TabIndex = 11;
            this.username.Text = "username";
            this.PictureBox1.Image = Class6.smethod_6();
            this.PictureBox1.Location = new Point(-3, -7);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0xf9, 0x83);
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            this.LinkLabel7.AutoSize = true;
            this.LinkLabel7.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabel7.LinkColor = Color.Green;
            this.LinkLabel7.Location = new Point(0x8f, 80);
            this.LinkLabel7.Name = "LinkLabel7";
            this.LinkLabel7.Size = new Size(0x48, 0x10);
            this.LinkLabel7.TabIndex = 12;
            this.LinkLabel7.TabStop = true;
            this.LinkLabel7.Text = "feedback";
            base.AutoScaleDimensions = new SizeF(7f, 14f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            base.ClientSize = new Size(0xf2, 0x72);
            base.Controls.Add(this.LinkLabel7);
            base.Controls.Add(this.username);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.LinkLabel6);
            base.Controls.Add(this.LinkLabel5);
            base.Controls.Add(this.LinkLabel4);
            base.Controls.Add(this.LinkLabel3);
            base.Controls.Add(this.LinkLabel2);
            base.Controls.Add(this.LinkLabel1);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.PictureBox1);
            this.Font = new Font("Courier New", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Green;
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "info";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            ((ISupportInitialize) this.PictureBox1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://discord.gg/PShzX6E");
        }

        private void method_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Class2.Class3_0.guidelines.Show();
        }

        private void method_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Class2.Class3_0.changelog.Show();
        }

        private void method_3(object sender, EventArgs e)
        {
            Class2.Class3_0.idioticanprofile.Show();
        }

        private void method_4(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/playlist?list=PLX0C5d4HydZdyRjv4SB-fTwWhIewgV3BS");
        }

        private void method_5(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Class2.Class3_0.status.Show();
        }

        private void method_6(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Class2.Class3_0.credits.Show();
        }

        private void method_7(object sender, EventArgs e)
        {
        }

        private void method_8(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Class2.Class3_0.feedback.Show();
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label1 = value;
            }
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_3);
                Label label = this._Label2;
                if (label != null)
                {
                    label.Click -= handler;
                }
                this._Label2 = value;
                label = this._Label2;
                if (label != null)
                {
                    label.Click += handler;
                }
            }
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.wJfxuetnb6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this.wJfxuetnb6 = value;
            }
        }

        internal virtual LinkLabel LinkLabel1
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.method_0);
                LinkLabel label = this._LinkLabel1;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel1 = value;
                label = this._LinkLabel1;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel2
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.method_2);
                LinkLabel label = this._LinkLabel2;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel2 = value;
                label = this._LinkLabel2;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel3
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.method_1);
                LinkLabel label = this._LinkLabel3;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel3 = value;
                label = this._LinkLabel3;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel4
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.method_4);
                LinkLabel label = this._LinkLabel4;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel4 = value;
                label = this._LinkLabel4;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel5
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel5;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.method_5);
                LinkLabel label = this._LinkLabel5;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel5 = value;
                label = this._LinkLabel5;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel6
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.method_6);
                LinkLabel label = this._LinkLabel6;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel6 = value;
                label = this._LinkLabel6;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel7
        {
            [CompilerGenerated]
            get => 
                this._LinkLabel7;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.method_8);
                LinkLabel label = this._LinkLabel7;
                if (label != null)
                {
                    label.LinkClicked -= handler;
                }
                this._LinkLabel7 = value;
                label = this._LinkLabel7;
                if (label != null)
                {
                    label.LinkClicked += handler;
                }
            }
        }

        internal virtual PictureBox PictureBox1
        {
            [CompilerGenerated]
            get => 
                this._PictureBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._PictureBox1 = value;
            }
        }

        internal virtual Label username
        {
            [CompilerGenerated]
            get => 
                this._username;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_7);
                Label label = this._username;
                if (label != null)
                {
                    label.Click -= handler;
                }
                this._username = value;
                label = this._username;
                if (label != null)
                {
                    label.Click += handler;
                }
            }
        }
    }
}

