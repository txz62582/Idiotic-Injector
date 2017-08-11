using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[EditorBrowsable(EditorBrowsableState.Never), GeneratedCode("MyTemplate", "11.0.0.0")]
internal class Form0 : WindowsFormsApplicationBase
{
    [DebuggerStepThrough]
    public Form0() : base(AuthenticationMode.Windows)
    {
        base.IsSingleInstance = false;
        base.EnableVisualStyles = true;
        base.SaveMySettingsOnExit = true;
        base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
    }

    [MethodImpl(MethodImplOptions.NoOptimization), DebuggerHidden, EditorBrowsable(EditorBrowsableState.Advanced), STAThread]
    internal static void Main(string[] args)
    {
        try
        {
            Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
            Class8.Wc1jetPzTbITr();
        }
        finally
        {
        }
        Class2.Form0_0.Run(args);
    }

    [DebuggerStepThrough]
    protected override void OnCreateMainForm()
    {
        base.MainForm = Class2.Class3_0.Form1;
    }
}

