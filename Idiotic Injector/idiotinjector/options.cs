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
    public class options : Form
    {
        [AccessedThroughProperty("CheckBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox _CheckBox1;
        [AccessedThroughProperty("CheckBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox _CheckBox2;
        [CompilerGenerated, AccessedThroughProperty("CheckBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox _CheckBox3;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBox4")]
        private CheckBox _CheckBox4;
        private IContainer icontainer_0;

        public options()
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
            this.CheckBox1 = new CheckBox();
            this.CheckBox2 = new CheckBox();
            this.CheckBox3 = new CheckBox();
            this.CheckBox4 = new CheckBox();
            base.SuspendLayout();
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new Point(12, 12);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new Size(0x63, 20);
            this.CheckBox1.TabIndex = 0;
            this.CheckBox1.Text = "automatic";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new Point(12, 0x40);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new Size(0x73, 20);
            this.CheckBox2.TabIndex = 3;
            this.CheckBox2.Text = "compression";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new Point(12, 0x26);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new Size(0x73, 20);
            this.CheckBox3.TabIndex = 4;
            this.CheckBox3.Text = "obfuscation";
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Location = new Point(12, 90);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new Size(0x6b, 20);
            this.CheckBox4.TabIndex = 5;
            this.CheckBox4.Text = "negativity";
            this.CheckBox4.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            base.ClientSize = new Size(0x8f, 0x7c);
            base.Controls.Add(this.CheckBox4);
            base.Controls.Add(this.CheckBox3);
            base.Controls.Add(this.CheckBox2);
            base.Controls.Add(this.CheckBox1);
            this.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Green;
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Margin = new Padding(4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "options";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            this.Text = "options";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_0(object sender, EventArgs e)
        {
            Class2.Class3_0.Form1.Button4.Enabled = false;
            Class2.Class3_0.Form1.vmethod_0().Enabled = true;
        }

        internal virtual CheckBox CheckBox1
        {
            [CompilerGenerated]
            get => 
                this._CheckBox1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_0);
                CheckBox box = this._CheckBox1;
                if (box != null)
                {
                    box.CheckedChanged -= handler;
                }
                this._CheckBox1 = value;
                box = this._CheckBox1;
                if (box != null)
                {
                    box.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox CheckBox2
        {
            [CompilerGenerated]
            get => 
                this._CheckBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._CheckBox2 = value;
            }
        }

        internal virtual CheckBox CheckBox3
        {
            [CompilerGenerated]
            get => 
                this._CheckBox3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._CheckBox3 = value;
            }
        }

        internal virtual CheckBox CheckBox4
        {
            [CompilerGenerated]
            get => 
                this._CheckBox4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._CheckBox4 = value;
            }
        }
    }
}

