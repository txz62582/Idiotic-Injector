﻿namespace idiotinjector.My
{
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated]
    internal sealed class MySettings : ApplicationSettingsBase
    {
        private static bool addedHandler;
        private static object addedHandlerLockObject;
        private static MySettings defaultInstance;

        static MySettings()
        {
            Class8.Wc1jetPzTbITr();
            defaultInstance = (MySettings) SettingsBase.Synchronized(new MySettings());
            addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
        }

        public MySettings()
        {
            Class8.Wc1jetPzTbITr();
        }

        [DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Advanced)]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (Class2.Form0_0.SaveMySettingsOnExit)
            {
                MySettingsProperty.Settings.Save();
            }
        }

        public static MySettings Default
        {
            get
            {
                if (!addedHandler)
                {
                    object addedHandlerLockObject = MySettings.addedHandlerLockObject;
                    ObjectFlowControl.CheckForSyncLockOnValueType(addedHandlerLockObject);
                    lock (addedHandlerLockObject)
                    {
                        if (!addedHandler)
                        {
                            Class2.Form0_0.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
                            addedHandler = true;
                        }
                    }
                }
                return defaultInstance;
            }
        }
    }
}
