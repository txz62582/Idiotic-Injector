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
    public class changelog : Form
    {
        [CompilerGenerated, AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label _Label2;
        private IContainer icontainer_0;

        public changelog()
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(changelog));
            this.Label2 = new Label();
            base.SuspendLayout();
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(12, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(360, 880);
            this.Label2.TabIndex = 1;
            this.Label2.Text = manager.GetString("Label2.Text");
            base.AutoScaleDimensions = new SizeF(7f, 14f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            base.ClientSize = new Size(370, 0x383);
            base.Controls.Add(this.Label2);
            this.Font = new Font("Courier New", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Green;
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "changelog";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "changes";
            base.ResumeLayout(false);
            base.PerformLayout();
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
    }
}

