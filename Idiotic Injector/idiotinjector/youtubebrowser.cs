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
    public class youtubebrowser : Form
    {
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Button1")]
        private Button _Button1;
        [CompilerGenerated, AccessedThroughProperty("WebBrowser1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private WebBrowser _WebBrowser1;
        private IContainer icontainer_0;

        public youtubebrowser()
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
            this.WebBrowser1 = new WebBrowser();
            this.Button1 = new Button();
            base.SuspendLayout();
            this.WebBrowser1.Location = new Point(14, 13);
            this.WebBrowser1.MinimumSize = new Size(0x17, 0x16);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new Size(0x2b9, 0x216);
            this.WebBrowser1.TabIndex = 0;
            this.WebBrowser1.Url = new Uri("http://youtube.com/idiotican", UriKind.Absolute);
            this.Button1.BackColor = Color.Black;
            this.Button1.FlatStyle = FlatStyle.Flat;
            this.Button1.Location = new Point(0x14f, 0x22a);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x3e, 0x19);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "close";
            this.Button1.UseVisualStyleBackColor = false;
            base.AutoScaleDimensions = new SizeF(7f, 14f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            base.ClientSize = new Size(0x2d8, 0x24f);
            base.Controls.Add(this.Button1);
            base.Controls.Add(this.WebBrowser1);
            this.Font = new Font("Courier New", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Green;
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "youtubebrowser";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            this.Text = "youtubebrowser";
            base.ResumeLayout(false);
        }

        private void method_0(object sender, EventArgs e)
        {
            base.Close();
        }

        internal virtual Button Button1
        {
            [CompilerGenerated]
            get => 
                this._Button1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_0);
                Button button = this._Button1;
                if (button != null)
                {
                    button.Click -= handler;
                }
                this._Button1 = value;
                button = this._Button1;
                if (button != null)
                {
                    button.Click += handler;
                }
            }
        }

        internal virtual WebBrowser WebBrowser1
        {
            [CompilerGenerated]
            get => 
                this._WebBrowser1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._WebBrowser1 = value;
            }
        }
    }
}

