namespace idiotinjector
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class weebskin : Form
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Button3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button _Button3;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Button4"), CompilerGenerated]
        private Button _Button4;
        [AccessedThroughProperty("DLLs"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ListBox _DLLs_1;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label _Label1;
        [AccessedThroughProperty("TextBox1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox _TextBox1;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("OpenFileDialog")]
        private System.Windows.Forms.OpenFileDialog cCexcoalra;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("FontDialog1"), CompilerGenerated]
        private FontDialog fontDialog_0;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private int int_2;
        public const int MEM_COMMIT = 0x1000;
        [AccessedThroughProperty("OpenFileDialog2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private System.Windows.Forms.OpenFileDialog openFileDialog_0;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("OpenFileDialog1")]
        private System.Windows.Forms.OpenFileDialog openFileDialog_1;
        public const int PAGE_READWRITE = 4;
        public const int PROCESS_CREATE_THREAD = 2;
        public const int PROCESS_VM_OPERATION = 8;
        public const int PROCESS_VM_READ = 0x10;
        public const int PROCESS_VM_WRITE = 0x20;
        private string string_0;
        private string string_1;
        private string string_2;
        public const int TH32CS_SNAPPROCESS = 2;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Timer1")]
        private Timer timer_0;

        public weebskin()
        {
            Class8.Wc1jetPzTbITr();
            base.Load += new EventHandler(this.weebskin_Load);
            this.string_2 = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            this.InitializeComponent();
        }

        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int CloseHandleA(int int_3);
        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int CreateRemoteThread(int hProcess, int lpThreadAttributes, int dwStackSize, int lpStartAddress, int lpParameter, int dwCreationFlags, ref int lpThreadId);
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

        [DllImport("user32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_4);
        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3);
        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int GetProcAddress(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpProcName);
        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.icontainer_0 = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(weebskin));
            this.Button4 = new Button();
            this.Button3 = new Button();
            this.Button1 = new Button();
            this.OpenFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TextBox1 = new TextBox();
            this.DLLs = new ListBox();
            this.vmethod_1(new Timer(this.icontainer_0));
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Label1 = new Label();
            this.vmethod_3(new FontDialog());
            base.SuspendLayout();
            this.Button4.BackgroundImage = Class6.ixgtqEhRN();
            this.Button4.Font = new Font("Courier New", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Button4.Location = new Point(0x19c, 0xff);
            this.Button4.Name = "Button4";
            this.Button4.Size = new Size(0x93, 0x30);
            this.Button4.TabIndex = 0x1a;
            this.Button4.Text = "not there senpai!";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button3.BackgroundImage = Class6.ixgtqEhRN();
            this.Button3.Location = new Point(0x1e8, 210);
            this.Button3.Name = "Button3";
            this.Button3.Size = new Size(0x47, 0x27);
            this.Button3.TabIndex = 0x19;
            this.Button3.Text = "ワイプ";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button1.BackgroundImage = Class6.ixgtqEhRN();
            this.Button1.Location = new Point(0x19c, 210);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x51, 0x27);
            this.Button1.TabIndex = 0x18;
            this.Button1.Text = "b-browse?";
            this.Button1.UseVisualStyleBackColor = true;
            this.OpenFileDialog2.FileName = "OpenFileDialog2";
            this.OpenFileDialog.FileName = "OpenFileDialog";
            this.TextBox1.BackColor = Color.Black;
            this.TextBox1.ForeColor = Color.Green;
            this.TextBox1.Location = new Point(0x1c4, 160);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new Size(0x47, 20);
            this.TextBox1.TabIndex = 0x1d;
            this.TextBox1.Text = "process";
            this.DLLs.BackColor = Color.Black;
            this.DLLs.ForeColor = Color.Green;
            this.DLLs.FormattingEnabled = true;
            this.DLLs.ItemHeight = 14;
            this.DLLs.Location = new Point(0x19c, 0xba);
            this.DLLs.Name = "DLLs";
            this.DLLs.Size = new Size(0x93, 0x12);
            this.DLLs.TabIndex = 0x1c;
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.Label1.AutoSize = true;
            this.Label1.BackColor = SystemColors.ActiveCaptionText;
            this.Label1.Location = new Point(0x1c1, 0x8f);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x38, 14);
            this.Label1.TabIndex = 0x1b;
            this.Label1.Text = "status:";
            base.AutoScaleDimensions = new SizeF(7f, 14f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Class6.weeb;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(0x23b, 0x13b);
            base.Controls.Add(this.Button4);
            base.Controls.Add(this.Button3);
            base.Controls.Add(this.Button1);
            base.Controls.Add(this.TextBox1);
            base.Controls.Add(this.DLLs);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Courier New", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Green;
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "weebskin";
            this.Text = "oneechan my o-chinchin!!!";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpLibFileName);
        private void method_0()
        {
            int num5;
            try
            {
                int num4;
                ProjectData.ClearProjectError();
                int num = 2;
                this.vmethod_0().Stop();
                Process[] processesByName = Process.GetProcessesByName(this.TextBox1.Text);
                this.int_0 = OpenProcess(0x2a, 0, processesByName[0].Id);
                this.string_0 = this.OpenFileDialog1.FileName;
                string str = "Kernel32";
                string lpProcName = "LoadLibraryA";
                this.int_1 = GetProcAddress(GetModuleHandleA(ref str), ref lpProcName);
                this.int_2 = 1 + Strings.Len(this.string_0);
                int lpBaseAddress = VirtualAllocEx(this.int_0, 0, this.int_2, 0x1000, 4);
                int lpNumberOfBytesWritten = 0;
                WriteProcessMemory(this.int_0, lpBaseAddress, ref this.string_0, this.int_2, ref lpNumberOfBytesWritten);
                lpNumberOfBytesWritten = 0;
                CreateRemoteThread(this.int_0, 0, 0, this.int_1, lpBaseAddress, 0, ref lpNumberOfBytesWritten);
                CloseHandleA(this.int_0);
            Label_00DF:
                num5 = 1;
                base.Show();
                if (num4 != 0)
                {
                    ProjectData.ClearProjectError();
                }
                return;
            Label_00EA:
                num4 = -1;
                switch (num)
                {
                    case 0:
                    case 1:
                        goto Label_0124;

                    case 2:
                        goto Label_00DF;
                }
            }
            catch (Exception exception1) when (?)
            {
                ProjectData.SetProjectError(exception1, num5);
                goto Label_00EA;
            }
        Label_0124:
            throw ProjectData.CreateProjectError(-2146828237);
        }

        private void method_1(object sender, EventArgs e)
        {
            this.OpenFileDialog1.Filter = "DLL (*.dll) |*.dll";
            this.OpenFileDialog1.ShowDialog();
        }

        private void method_2(object sender, EventArgs e)
        {
            this.DLLs.Items.Clear();
        }

        private void method_3(object sender, EventArgs e)
        {
            if (File.Exists(this.OpenFileDialog1.FileName))
            {
                if (Process.GetProcessesByName(this.TextBox1.Text).Length == 0)
                {
                    this.Label1.Text = "w-waiting";
                }
                else
                {
                    this.vmethod_0().Stop();
                    this.Label1.Text = "injecting.";
                    this.Label1.Text = "injecting..";
                    this.Label1.Text = "injecting...";
                    this.Label1.Text = "injecting....";
                    this.Label1.Text = "injecting.....";
                    this.Label1.Text = "injecting......";
                    this.method_0();
                    this.Label1.Text = "injectioned!!";
                }
            }
        }

        private void method_4(object sender, EventArgs e)
        {
            if (File.Exists(this.OpenFileDialog1.FileName))
            {
                if (Process.GetProcessesByName(this.TextBox1.Text).Length == 0)
                {
                    this.Label1.Text = "w-waiting";
                }
                else
                {
                    this.vmethod_0().Stop();
                    this.Label1.Text = "injected";
                    this.method_0();
                }
            }
        }

        private void method_5(object sender, CancelEventArgs e)
        {
            string item = this.OpenFileDialog1.FileName.Substring(this.OpenFileDialog1.FileName.LastIndexOf(@"\")).Replace(@"\", "");
            this.DLLs.Items.Add(item);
        }

        private void method_6(object sender, EventArgs e)
        {
            this.TextBox1.Clear();
        }

        private void method_7(object sender, EventArgs e)
        {
            this.vmethod_2().ShowDialog();
            this.Font = this.vmethod_2().Font;
        }

        private void method_8(object sender, EventArgs e)
        {
            this.OpenFileDialog2.Filter = "wav (*.wav) |*.wav";
            this.OpenFileDialog2.ShowDialog();
            Class2.Class1_0.Audio.Play(this.OpenFileDialog2.FileName);
        }

        private void method_9(object sender, EventArgs e)
        {
        }

        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);
        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int ReadProcessMemory(int hProcess, int lpBaseAddress, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);
        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int VirtualAllocEx(int hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);
        [CompilerGenerated]
        internal virtual Timer vmethod_0() => 
            this.timer_0;

        [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
        internal virtual void vmethod_1(Timer WithEventsValue)
        {
            EventHandler handler = new EventHandler(this.method_4);
            Timer timer = this.timer_0;
            if (timer != null)
            {
                timer.Tick -= handler;
            }
            this.timer_0 = WithEventsValue;
            timer = this.timer_0;
            if (timer != null)
            {
                timer.Tick += handler;
            }
        }

        [CompilerGenerated]
        internal virtual FontDialog vmethod_2() => 
            this.fontDialog_0;

        [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
        internal virtual void vmethod_3(FontDialog WithEventsValue)
        {
            this.fontDialog_0 = WithEventsValue;
        }

        private void weebskin_Load(object sender, EventArgs e)
        {
            this.DLLs.Name = "DLLs";
            this.Button1.Text = "browse";
            this.Label1.Text = "w-waiting";
            this.vmethod_0().Interval = 50;
            this.vmethod_0().Start();
            this.Button4.Enabled = true;
            this.vmethod_0().Enabled = false;
        }

        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int WriteProcessMemory(int hProcess, int lpBaseAddress, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

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

        internal virtual Button Button3
        {
            [CompilerGenerated]
            get => 
                this._Button3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_2);
                Button button = this._Button3;
                if (button != null)
                {
                    button.Click -= handler;
                }
                this._Button3 = value;
                button = this._Button3;
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
                EventHandler handler = new EventHandler(this.method_3);
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

        internal virtual ListBox DLLs
        {
            [CompilerGenerated]
            get => 
                this._DLLs_1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this._DLLs_1 = value;
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
                EventHandler handler = new EventHandler(this.method_9);
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

        internal virtual System.Windows.Forms.OpenFileDialog OpenFileDialog
        {
            [CompilerGenerated]
            get => 
                this.cCexcoalra;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this.cCexcoalra = value;
            }
        }

        internal virtual System.Windows.Forms.OpenFileDialog OpenFileDialog1
        {
            [CompilerGenerated]
            get => 
                this.openFileDialog_1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                CancelEventHandler handler = new CancelEventHandler(this.method_5);
                System.Windows.Forms.OpenFileDialog dialog = this.openFileDialog_1;
                if (dialog != null)
                {
                    dialog.FileOk -= handler;
                }
                this.openFileDialog_1 = value;
                dialog = this.openFileDialog_1;
                if (dialog != null)
                {
                    dialog.FileOk += handler;
                }
            }
        }

        internal virtual System.Windows.Forms.OpenFileDialog OpenFileDialog2
        {
            [CompilerGenerated]
            get => 
                this.openFileDialog_0;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this.openFileDialog_0 = value;
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
                EventHandler handler = new EventHandler(this.method_6);
                TextBox box = this._TextBox1;
                if (box != null)
                {
                    box.Click -= handler;
                }
                this._TextBox1 = value;
                box = this._TextBox1;
                if (box != null)
                {
                    box.Click += handler;
                }
            }
        }
    }
}

