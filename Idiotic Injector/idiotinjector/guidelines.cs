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
    public class guidelines : Form
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label1")]
        private Label _Label1;
        private IContainer icontainer_0;

        public guidelines()
        {
            Class8.Wc1jetPzTbITr();
            base.Click += new EventHandler(this.guidelines_Click);
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

        private void guidelines_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.Label1 = new Label();
            base.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(280, 70);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "if you attempt to reverse engineer,\r\ndump or sell the injector, i am allowed\r\nto permenantly ban you from the\r\ninjector and anything idiotic america\r\nrelated";
            base.AutoScaleDimensions = new SizeF(7f, 14f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            base.ClientSize = new Size(0x12b, 0x5d);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Courier New", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Green;
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "guidelines";
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

