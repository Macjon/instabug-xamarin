using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Instabug
{
	[Native]
	public enum IBGInvocationEvent : System.Int64
	{
		None,
		Shake,
		Screenshot,
		TwoFingersSwipeLeft,
		RightEdgePan,
		FloatingButton
	}

	[Native]
	public enum IBGColorTheme : System.Int64
	{
		Light,
		Dark
	}

	[Native]
	public enum IBGInvocationMode : System.Int64
	{
		Na,
		BugReporter,
		FeedbackSender
	}

	[Native]
	public enum IBGLocale : System.Int64
	{
		Arabic,
		ChineseSimplified,
		ChineseTraditional,
		English,
		French,
		German,
		Italian,
		Japanese,
		Korean,
		Polish,
		PortugueseBrazil,
		Russian,
		Spanish,
		Swedish,
		Turkish
	}

	static class CFunctions
	{
		// extern void IBGLog (NSString *format, ...) __attribute__((format(NSString, 1, 2)));
		//[DllImport("__Internal")]
		//[Verify(PlatformInvoke)]
		//static extern void IBGLog(NSString format, System.IntPtr varArgs);
	}
}
