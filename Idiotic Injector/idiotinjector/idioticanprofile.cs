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
    public class idioticanprofile : Form
    {
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1")]
        private Label _Label1;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label _Label2;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("LinkLabel1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private LinkLabel _LinkLabel1;
        [AccessedThroughProperty("LinkLabel2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LinkLabel _LinkLabel2;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PictureBox1")]
        private PictureBox _PictureBox1;
        private IContainer icontainer_0;

        public idioticanprofile()
        {
            Class8.Wc1jetPzTbITr();
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

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.PictureBox1 = new PictureBox();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.LinkLabel1 = new LinkLabel();
            this.LinkLabel2 = new LinkLabel();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            base.SuspendLayout();
            this.PictureBox1.BackgroundImage = Class6.akmvJsVwx();
            this.PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            this.PictureBox1.Location = new Point(0x10, 0x10);
            this.PictureBox1.Margin = new Padding(7);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x120, 0xf3);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = Color.Transparent;
            this.Label1.Font = new Font("Comic Sans MS", 24f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0x13a, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x19f, 0x2d);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "george \"idiotican\" browne";
            this.Label2.AutoSize = true;
            this.Label2.BackColor = Color.Transparent;
            this.Label2.Font = new Font("Comic Sans MS", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(0x13a, 0x36);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x17f, 0x26);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "(whore \"dick licker\" downie)";
            this.Label3.AutoSize = true;
            this.Label3.BackColor = Color.Transparent;
            this.Label3.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label3.Location = new Point(0x13a, 0x5c);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x1e5, 120);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "george was born in 1964 and raised by wolves\r\nonly to run away to a mongolian village to\r\npersue a journey to gather the knowledge to\r\ncreate the greatest injector in the universe";
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.BackColor = Color.Transparent;
            this.LinkLabel1.Location = new Point(0x13d, 0xe5);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new Size(0x5c, 30);
            this.LinkLabel1.TabIndex = 4;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "youtube";
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.BackColor = Color.Transparent;
            this.LinkLabel2.Location = new Point(0x2ec, 0xe5);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new Size(0x33, 30);
            this.LinkLabel2.TabIndex = 5;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "site";
            base.AutoScaleDimensions = new SizeF(13f, 30f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Class6.smethod_1();
            base.ClientSize = new Size(0x32e, 0x10c);
            base.Controls.Add(this.LinkLabel2);
            base.Controls.Add(this.LinkLabel1);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.PictureBox1);
            this.Font = new Font("Comic Sans MS", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Yellow;
            base.Margin = new Padding(7);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "idioticanprofile";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            ((ISupportInitialize) this.PictureBox1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Class2.Class3_0.youtubebrowser.Show();
            Class2.Class3_0.youtubebrowser.WebBrowser1.Navigate("http://youtube.com/idiotican");
        }

        private void method_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Class2.Class3_0.youtubebrowser.Show();
            Class2.Class3_0.youtubebrowser.WebBrowser1.Navigate("http://idiotican.tk");
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
                this._Label2 = value;
            }
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._Label3 = value;
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
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.method_1);
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
    }
}

