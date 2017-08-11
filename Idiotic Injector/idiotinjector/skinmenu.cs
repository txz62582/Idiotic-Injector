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
    public class skinmenu : Form
    {
        [AccessedThroughProperty("Button1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button _Button1;
        [AccessedThroughProperty("Button4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button _Button4;
        private IContainer icontainer_0;

        public skinmenu()
        {
            Class8.Wc1jetPzTbITr();
            base.Click += new EventHandler(this.skinmenu_Click);
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
            this.Button4 = new Button();
            this.Button1 = new Button();
            base.SuspendLayout();
            this.Button4.BackgroundImage = Class6.ixgtqEhRN();
            this.Button4.Location = new Point(0x69, 12);
            this.Button4.Name = "Button4";
            this.Button4.Size = new Size(0x57, 0x19);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "hacker";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button1.BackgroundImage = Class6.ixgtqEhRN();
            this.Button1.Location = new Point(12, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x57, 0x19);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "weeb";
            this.Button1.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 14f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            base.ClientSize = new Size(0xcc, 0x33);
            base.Controls.Add(this.Button4);
            base.Controls.Add(this.Button1);
            this.Font = new Font("Courier New", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Green;
            base.FormBorderStyle = FormBorderStyle.None;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "skinmenu";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            base.ResumeLayout(false);
        }

        private void method_0(object sender, EventArgs e)
        {
            base.Close();
            Class2.Class3_0.hackerskin.Show();
        }

        private void method_1(object sender, EventArgs e)
        {
            base.Close();
            Class2.Class3_0.weebskin.Show();
        }

        private void skinmenu_Click(object sender, EventArgs e)
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
                EventHandler handler = new EventHandler(this.method_1);
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

        internal virtual Button Button4
        {
            [CompilerGenerated]
            get => 
                this._Button4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_0);
                Button button = this._Button4;
                if (button != null)
                {
                    button.Click -= handler;
                }
                this._Button4 = value;
                button = this._Button4;
                if (button != null)
                {
                    button.Click += handler;
                }
            }
        }
    }
}

