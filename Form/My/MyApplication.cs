using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace My
{
	[GeneratedCode("MyTemplate", "10.0.0.0"), EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		[EditorBrowsable(EditorBrowsableState.Advanced), DebuggerHidden, STAThread]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}

		[DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			this.IsSingleInstance = true;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = false;
			this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			this.MainForm = MyProject.Forms.Form1;
		}
	}
}
