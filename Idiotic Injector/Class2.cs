using idiotinjector;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StandardModule, HideModuleName, GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class2
{
    private static readonly Class5<Class1> class5_0;
    private static readonly Class5<Form0> class5_1;
    private static readonly Class5<User> class5_2;
    private static Class5<Class3> class5_3;
    private static readonly Class5<Class4> class5_4;

    static Class2()
    {
        Class8.Wc1jetPzTbITr();
        class5_0 = new Class5<Class1>();
        class5_1 = new Class5<Form0>();
        class5_2 = new Class5<User>();
        class5_3 = new Class5<Class3>();
        class5_4 = new Class5<Class4>();
    }

    [HelpKeyword("My.Computer")]
    internal static Class1 Class1_0 =>
        class5_0.method_0();

    [HelpKeyword("My.Forms")]
    internal static Class3 Class3_0 =>
        class5_3.method_0();

    [HelpKeyword("My.WebServices")]
    internal static Class4 Class4_0 =>
        class5_4.method_0();

    [HelpKeyword("My.Application")]
    internal static Form0 Form0_0 =>
        class5_1.method_0();

    [HelpKeyword("My.User")]
    internal static User User_0 =>
        class5_2.method_0();

    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class Class3
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.changelog changelog_0;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.credits credits_0;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.feedback feedback_0;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.Form1 form1_0;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.guidelines guidelines_0;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.hackerskin hackerskin_0;
        [ThreadStatic]
        private static Hashtable hashtable_0;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.idioticanprofile idioticanprofile_0;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.info info_0;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.options options_0;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.youtubebrowser PubUtvpfbK;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.skinmenu skinmenu_0;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.status status_0;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public idiotinjector.weebskin weebskin_0;

        [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
        public Class3()
        {
            Class8.Wc1jetPzTbITr();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => 
            base.Equals(RuntimeHelpers.GetObjectValue(obj));

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => 
            base.GetHashCode();

        [DebuggerHidden]
        private void method_0<LNL4RPDqhTlQ0BEylj>(ref LNL4RPDqhTlQ0BEylj gparam_0) where LNL4RPDqhTlQ0BEylj: Form
        {
            gparam_0.Dispose();
            gparam_0 = default(LNL4RPDqhTlQ0BEylj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        internal Type method_1() => 
            typeof(Class2.Class3);

        [DebuggerHidden]
        private static oBnu2Os4y2ytRPkmJs smethod_0<oBnu2Os4y2ytRPkmJs>(oBnu2Os4y2ytRPkmJs pwxsC5AmL0BYrulpWo) where oBnu2Os4y2ytRPkmJs: Form, new()
        {
            if ((pwxsC5AmL0BYrulpWo == null) || pwxsC5AmL0BYrulpWo.IsDisposed)
            {
                TargetInvocationException exception;
                if (hashtable_0 > null)
                {
                    if (hashtable_0.ContainsKey(typeof(oBnu2Os4y2ytRPkmJs)))
                    {
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
                    }
                }
                else
                {
                    hashtable_0 = new Hashtable();
                }
                hashtable_0.Add(typeof(oBnu2Os4y2ytRPkmJs), null);
                try
                {
                    return Activator.CreateInstance<oBnu2Os4y2ytRPkmJs>();
                }
                catch (TargetInvocationException exception1) when ((exception.InnerException > null))
                {
                    ProjectData.SetProjectError(exception1);
                    string[] args = new string[] { exception.InnerException.Message };
                    throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", args), exception.InnerException);
                }
                finally
                {
                    hashtable_0.Remove(typeof(oBnu2Os4y2ytRPkmJs));
                }
            }
            return pwxsC5AmL0BYrulpWo;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => 
            base.ToString();

        public idiotinjector.changelog changelog
        {
            [DebuggerHidden]
            get
            {
                this.changelog_0 = smethod_0<idiotinjector.changelog>(this.changelog_0);
                return this.changelog_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.changelog_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.changelog>(ref this.changelog_0);
                }
            }
        }

        public idiotinjector.credits credits
        {
            [DebuggerHidden]
            get
            {
                this.credits_0 = smethod_0<idiotinjector.credits>(this.credits_0);
                return this.credits_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.credits_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.credits>(ref this.credits_0);
                }
            }
        }

        public idiotinjector.feedback feedback
        {
            [DebuggerHidden]
            get
            {
                this.feedback_0 = smethod_0<idiotinjector.feedback>(this.feedback_0);
                return this.feedback_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.feedback_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.feedback>(ref this.feedback_0);
                }
            }
        }

        public idiotinjector.Form1 Form1
        {
            [DebuggerHidden]
            get
            {
                this.form1_0 = smethod_0<idiotinjector.Form1>(this.form1_0);
                return this.form1_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.form1_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.Form1>(ref this.form1_0);
                }
            }
        }

        public idiotinjector.guidelines guidelines
        {
            [DebuggerHidden]
            get
            {
                this.guidelines_0 = smethod_0<idiotinjector.guidelines>(this.guidelines_0);
                return this.guidelines_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.guidelines_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.guidelines>(ref this.guidelines_0);
                }
            }
        }

        public idiotinjector.hackerskin hackerskin
        {
            [DebuggerHidden]
            get
            {
                this.hackerskin_0 = smethod_0<idiotinjector.hackerskin>(this.hackerskin_0);
                return this.hackerskin_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.hackerskin_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.hackerskin>(ref this.hackerskin_0);
                }
            }
        }

        public idiotinjector.idioticanprofile idioticanprofile
        {
            [DebuggerHidden]
            get
            {
                this.idioticanprofile_0 = smethod_0<idiotinjector.idioticanprofile>(this.idioticanprofile_0);
                return this.idioticanprofile_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.idioticanprofile_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.idioticanprofile>(ref this.idioticanprofile_0);
                }
            }
        }

        public idiotinjector.info info
        {
            [DebuggerHidden]
            get
            {
                this.info_0 = smethod_0<idiotinjector.info>(this.info_0);
                return this.info_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.info_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.info>(ref this.info_0);
                }
            }
        }

        public idiotinjector.options options
        {
            [DebuggerHidden]
            get
            {
                this.options_0 = smethod_0<idiotinjector.options>(this.options_0);
                return this.options_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.options_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.options>(ref this.options_0);
                }
            }
        }

        public idiotinjector.skinmenu skinmenu
        {
            [DebuggerHidden]
            get
            {
                this.skinmenu_0 = smethod_0<idiotinjector.skinmenu>(this.skinmenu_0);
                return this.skinmenu_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.skinmenu_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.skinmenu>(ref this.skinmenu_0);
                }
            }
        }

        public idiotinjector.status status
        {
            [DebuggerHidden]
            get
            {
                this.status_0 = smethod_0<idiotinjector.status>(this.status_0);
                return this.status_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.status_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.status>(ref this.status_0);
                }
            }
        }

        public idiotinjector.weebskin weebskin
        {
            [DebuggerHidden]
            get
            {
                this.weebskin_0 = smethod_0<idiotinjector.weebskin>(this.weebskin_0);
                return this.weebskin_0;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.weebskin_0)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.weebskin>(ref this.weebskin_0);
                }
            }
        }

        public idiotinjector.youtubebrowser youtubebrowser
        {
            [DebuggerHidden]
            get
            {
                this.PubUtvpfbK = smethod_0<idiotinjector.youtubebrowser>(this.PubUtvpfbK);
                return this.PubUtvpfbK;
            }
            [DebuggerHidden]
            set
            {
                if (value != this.PubUtvpfbK)
                {
                    if (value > null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    this.method_0<idiotinjector.youtubebrowser>(ref this.PubUtvpfbK);
                }
            }
        }
    }

    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class Class4
    {
        [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
        public Class4()
        {
            Class8.Wc1jetPzTbITr();
        }

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
        public override bool Equals(object obj) => 
            base.Equals(RuntimeHelpers.GetObjectValue(obj));

        [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => 
            base.GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
        internal Type method_0() => 
            typeof(Class2.Class4);

        [DebuggerHidden]
        private void method_1<XL6xUEuONr5JVHChT4>(ref XL6xUEuONr5JVHChT4 gparam_0)
        {
            gparam_0 = default(XL6xUEuONr5JVHChT4);
        }

        [DebuggerHidden]
        private static KPSdMH6exc3TsBFN35 smethod_0<KPSdMH6exc3TsBFN35>(KPSdMH6exc3TsBFN35 efWrYtVuOfM6ZLBI7e) where KPSdMH6exc3TsBFN35: new()
        {
            if (efWrYtVuOfM6ZLBI7e == null)
            {
                return Activator.CreateInstance<KPSdMH6exc3TsBFN35>();
            }
            return efWrYtVuOfM6ZLBI7e;
        }

        [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => 
            base.ToString();
    }

    [ComVisible(false), EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class Class5<O3R1Z8YhYiMqYDIcM9> where O3R1Z8YhYiMqYDIcM9: new()
    {
        [CompilerGenerated, ThreadStatic]
        private static O3R1Z8YhYiMqYDIcM9 gparam_0;

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
        public Class5()
        {
            Class8.Wc1jetPzTbITr();
        }

        [DebuggerHidden]
        internal O3R1Z8YhYiMqYDIcM9 method_0()
        {
            if (Class2.Class5<O3R1Z8YhYiMqYDIcM9>.gparam_0 == null)
            {
                Class2.Class5<O3R1Z8YhYiMqYDIcM9>.gparam_0 = Activator.CreateInstance<O3R1Z8YhYiMqYDIcM9>();
            }
            return Class2.Class5<O3R1Z8YhYiMqYDIcM9>.gparam_0;
        }
    }
}

