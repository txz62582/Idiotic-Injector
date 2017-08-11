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
    public class credits : Form
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1"), CompilerGenerated]
        private Label _Label1;
        private IContainer pKmIqhByl0;

        public credits()
        {
            Class8.Wc1jetPzTbITr();
            base.Click += new EventHandler(this.credits_Click);
            this.InitializeComponent();
        }

        private void credits_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.pKmIqhByl0 > null))
                {
                    this.pKmIqhByl0.Dispose();
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(credits));
            this.Label1 = new Label();
            base.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(13, 9);
            this.Label1.Margin = new Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0xa8, 0x1b0);
            this.Label1.TabIndex = 0;
            this.Label1.Text = manager.GetString("Label1.Text");
            base.AutoScaleDimensions = new SizeF(10f, 18f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            base.ClientSize = new Size(0xbd, 0x1c7);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Courier New", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Green;
            base.FormBorderStyle = FormBorderStyle.None;
            base.Margin = new Padding(4);
            base.Name = "credits";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0(object sender, EventArgs e)
        {
            base.Close();
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_0);
                Label label = this._Label1;
                if (label != null)
                {
                    label.Click -= handler;
                }
                this._Label1 = value;
                label = this._Label1;
                if (label != null)
                {
                    label.Click += handler;
                }
            }
        }
    }
}

