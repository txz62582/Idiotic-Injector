namespace idiotinjector
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Net;
    using System.Net.Mail;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class feedback : Form
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label _Label1;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label2")]
        private Label _Label2;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TextBox2")]
        private TextBox _TextBox2;
        private IContainer icontainer_0;

        public feedback()
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
            this.Button1 = new Button();
            this.Label1 = new Label();
            this.TextBox1 = new TextBox();
            this.TextBox2 = new TextBox();
            this.Label2 = new Label();
            base.SuspendLayout();
            this.Button1.BackgroundImage = Class6.ixgtqEhRN();
            this.Button1.FlatStyle = FlatStyle.Flat;
            this.Button1.Location = new Point(12, 0x101);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x3b, 0x17);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "send";
            this.Button1.UseVisualStyleBackColor = true;
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(9, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(40, 0x10);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "name";
            this.TextBox1.BackColor = Color.Black;
            this.TextBox1.BorderStyle = BorderStyle.FixedSingle;
            this.TextBox1.ForeColor = Color.Green;
            this.TextBox1.Location = new Point(12, 0x1c);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new Size(100, 0x16);
            this.TextBox1.TabIndex = 2;
            this.TextBox2.BackColor = Color.Black;
            this.TextBox2.BorderStyle = BorderStyle.FixedSingle;
            this.TextBox2.ForeColor = Color.Green;
            this.TextBox2.Location = new Point(12, 0x48);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new Size(240, 0xb3);
            this.TextBox2.TabIndex = 3;
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(9, 0x35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x48, 0x10);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "feedback";
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            base.ClientSize = new Size(0x10c, 0x123);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.TextBox2);
            base.Controls.Add(this.TextBox1);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.Button1);
            this.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Green;
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Margin = new Padding(4, 4, 4, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "feedback";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "feedback";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            IPHostEntry hostByName = Dns.GetHostByName(Dns.GetHostName());
            try
            {
               // IP logging source deleted :) No skids here
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                ProjectData.ClearProjectError();
            }
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

        internal virtual TextBox TextBox1
        {
            [CompilerGenerated]
            get => 
                this._TextBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox1 = value;
            }
        }

        internal virtual TextBox TextBox2
        {
            [CompilerGenerated]
            get => 
                this._TextBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._TextBox2 = value;
            }
        }
    }
}

