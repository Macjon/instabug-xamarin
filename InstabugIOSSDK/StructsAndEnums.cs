using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace iOSBinding
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
		NA,
		BugReporter,
		FeedbackSender,
		NewBug,
		NewFeedback,
		NewChat,
		ChatsList
	}

	[Native]
	public enum IBGReportType : System.Int64 {
		Bug,
		Feedback
	}

	[Native]
	public enum IBGDismissType : System.Int64 {
		Submit,
		Cancel,
		AddAttachment
	}

	[Native]
	public enum IBGLocale : System.Int64
	{
		Arabic,
		ChineseSimplified,
		ChineseTaiwan,
		ChineseTraditional,
		Czech,
		Danish,
		English,
		French,
		German,
		Italian,
		Japanese,
		Korean,
		Polish,
		Portugese,
		PortugueseBrazil,
		Russian,
		Slovak,
		Spanish,
		Swedish,
		Turkish
	}

	[Native]
	public enum IBGString :System.Int64 {
		//"<Shake> your device to talk to us"
		ShakeHint,
		//"<Swipe with 2 fingers> to talk to us"
		SwipeHint,
		//"<Swipe from the edge> to talk to us"
		EdgeSwipeStartHint,
		//"We love to hear your feedback"
		StartAlertText,
		//"Please enter a valid email"
		InvalidEmailMessage,
		//"Invalid Email"
		InvalidEmailTitle,
		//"Please enter a valid comment"
		InvalidCommentMessage,
		//"Invalid Comment"
		InvalidCommentTitle,
		//"Help & Feedback"
		InvocationHeader,
		//"Talk to us"
		TalkToUs,
		//"Report bug"
		ReportBug,
		//"Suggest an Improvement"
		ReportFeedback,
		//"Enter your Email"
		EmailFieldHint,
		//"What went wrong?"
		CommentFieldHintForBugReport,
		//"How can we improve?"
		CommentFieldHintForFeedback,
		//"Take a screen recording Note"
		AddScreenRecordingMessage,
		//"Record a Voice Note"
		AddVoiceMessage,
		//"Select Image from Gallery"
		AddImageFromGallery,
		//"Take a Screenshot"
		AddExtraScreenshot,
		//"Microphone Access Denied"
		AudioRecordingPermissionDeniedTitle,
		//"You can enable access in Privacy Settings"
		AudioRecordingPermissionDeniedMessage,
		//"Settings"
		MicrophonePermissionAlertSettingsButtonTitle,
		//"Conversations"
		ChatsHeaderTitle,
		//"%@ Team"
		Team,
		//"Press and Hold to Record"
		RecordingMessageToHoldText,
		//"Release to Attach"
		RecordingMessageToReleaseText,
		//"%@ new messages from %@"
		MessagesNotification,
		//%@ new messages from %@ and others
		MessagesNotificationAndOthers,
		//"Draw on screenshot"
		ScreenshotHeaderTitle,
		//"OK"
		OkButtonTitle,
		//"Cancel"
		CancelButtonTitle,
		//"Thank you"
		ThankYouText,
		//"Audio"
		Audio,
		//"Screen Recording"
		ScreenRecording,
		//"Image"
		Image
	} ;


	static class CFunctions
	{
		// extern void IBGLog (NSString *format, ...) __attribute__((format(NSString, 1, 2)));
		//[DllImport("__Internal")]
		//[Verify(PlatformInvoke)]
		//static extern void IBGLog(NSString format, System.IntPtr varArgs);
	}

}

