using System;
using Android.App;
using Android.Runtime;
using Com.Instabug.Library;
using Com.Instabug.Library.Invocation;
namespace Xamarinsampleandroidapp

{
	[Application]
	public class App :Application
	{
		protected App(IntPtr javaReference,JniHandleOwnership transfer)
        : base(javaReference, transfer){
		}
		public override void OnCreate()
		{
			base.OnCreate();
			new Instabug.Builder(this, "f69de38a7ef1b772101fbedf86801d79")
			            .SetInvocationEvent(InstabugInvocationEvent.Shake)
			            .SetTheme(InstabugColorTheme.InstabugColorThemeLight)
				.Build();
		}
	}
}
