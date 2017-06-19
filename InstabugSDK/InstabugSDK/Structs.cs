using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace InstabugLib
{
	[Native]
	public enum IBGString : System.Int64
	{
		ShakeHint,
		SwipeHint,
		EdgeSwipeStartHint,
		StartAlertText,
		InvalidEmailMessage,
		InvalidEmailTitle,
		InvalidCommentMessage,
		InvalidCommentTitle,
		InvocationHeader,
		TalkToUs,
		ReportBug,
		ReportFeedback,
		EmailFieldHint,
		CommentFieldHintForBugReport,
		CommentFieldHintForFeedback,
		AddScreenRecordingMessage,
		AddVoiceMessage,
		AddImageFromGallery,
		AddExtraScreenshot,
		AudioRecordingPermissionDeniedTitle,
		AudioRecordingPermissionDeniedMessage,
		ScreenRecordingPermissionDeniedMessage,
		MicrophonePermissionAlertSettingsButtonTitle,
		MicrophonePermissionAlertLaterButtonTitle,
		ChatsHeaderTitle,
		Team,
		RecordingMessageToHoldText,
		RecordingMessageToReleaseText,
		MessagesNotification,
		MessagesNotificationAndOthers,
		ScreenshotHeaderTitle,
		OkButtonTitle,
		CancelButtonTitle,
		ThankYouText,
		ThankYouAlertText,
		Audio,
		ScreenRecording,
		Image,
		SurveyEnterYourAnswerPlaceholder,
		SurveyNoAnswerTitle,
		SurveyNoAnswerMessage,
		SurveySubmitTitle,
		VideoPressRecordTitle,
		LowDiskStorageTitle,
		LowDiskStorageMessage
	}

	[Native]
	public enum IBGInvocationEvent : System.Int64
	{
		// No event will be registered to show the feedback form, you'll need to code your own and call the method showFeedbackForm.
		None,
		// Shaking the device while in any screen to show the feedback form.
		Shake,
		// Taking a screenshot using the Home+Lock buttons while in any screen to show the feedback form.
		Screenshot,
		// Swiping two fingers left while in any screen to show the feedback form
		TwoFingersSwipeLeft,
		// Swiping one finger left from the right edge of the screen to show the feedback form. 
		RightEdgePan,
		// Shows a floating button on top of all views, when pressed it takes a screenshot.
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
		NewBug,
		NewFeedback,
		NewChat,
		ChatsList
	}

	[Native]
	public enum IBGReportType : System.Int64
	{
		Bug,
		Feedback
	}

	[Native]
	public enum IBGDismissType : System.Int64
	{
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
		Norwegian,
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
	public enum IBGSDKDebugLogsLevel : System.Int64
	{
		Verbose,
		Debug,
		Error,
		None
	}

	[Native]
	public enum IBGPromptOption : System.Int64
	{
		Chat,
		Bug,
		Feedback
	}
}
