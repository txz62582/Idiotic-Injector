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
    public class status : Form
    {
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1")]
        private Label _Label1;
        private IContainer icontainer_0;

        public status()
        {
            Class8.Wc1jetPzTbITr();
            this.ybuxiVgpot();
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
        private void ybuxiVgpot()
        {
            this.Label1 = new Label();
            base.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x6c, 0x12);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "undetected";
            base.AutoScaleDimensions = new SizeF(10f, 18f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            base.ClientSize = new Size(0x85, 0x29);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Courier New", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Green;
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Margin = new Padding(5, 4, 5, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "status";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            base.ResumeLayout(false);
            base.PerformLayout();
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
    }
}

