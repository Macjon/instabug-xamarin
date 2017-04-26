using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace iOSBindingDynamicLib
{
	interface Types {

	[Export("kIBGStartAlertTextstringName")]
	string StartAlertTextstringName { get; }

	
	[Export("kIBGShakeStartAlertTextstringName")]
	string ShakeStartAlertTextstringName { get; }

	
	[Export("kIBGTwoFingerSwipeStartAlertTextstringName")]
	string TwoFingerSwipeStartAlertTextstringName { get; }

	
	[Export("kIBGEdgeSwipeStartAlertTextstringName")]
	string EdgeSwipeStartAlertTextstringName { get; }
	
	[Export("kIBGScreenshotStartAlertTextstringName")]
	string ScreenshotStartAlertTextstringName { get; }

	
	[Export("kIBGInvalidEmailMessagestringName")]
	string InvalidEmailMessagestringName { get; }

	
	[Export("kIBGInvalidEmailTitlestringName")]
	string InvalidEmailTitlestringName { get; }

	
	[Export("kIBGInvalidCommentMessagestringName")]
	string InvalidCommentMessagestringName { get; }

	
	[Export("kIBGInvalidCommentTitlestringName")]
	string InvalidCommentTitlestringName { get; }

	
	[Export("kIBGInvocationTitlestringName")]
	string InvocationTitlestringName { get; }

	
	[Export("kIBGTalkToUsstringName")]
	string TalkToUsstringName { get; }

	
	[Export("kIBGReportBugstringName")]
	string ReportBugstringName { get; }

	
	[Export("kIBGReportFeedbackstringName")]
	string ReportFeedbackstringName { get; }

	
	[Export("kIBGEmailFieldPlaceholderstringName")]
	string EmailFieldPlaceholderstringName { get; }

	
	[Export("kIBGCommentFieldPlaceholderForBugReportstringName")]
	string CommentFieldPlaceholderForBugReportstringName { get; }

	
	[Export("kIBGCommentFieldPlaceholderForFeedbackstringName")]
	string CommentFieldPlaceholderForFeedbackstringName { get; }

	
	[Export("kIBGChatReplyFieldPlaceholderstringName")]
	string ChatReplyFieldPlaceholderstringName { get; }

	
	[Export("kIBGAddScreenRecordingMessagestringName")]
	string AddScreenRecordingMessagestringName { get; }

	
	[Export("kIBGAddVoiceMessagestringName")]
	string AddVoiceMessagestringName { get; }

	
	[Export("kIBGAddImageFromGallerystringName")]
	string AddImageFromGallerystringName { get; }

	
	[Export("kIBGAddExtraScreenshotstringName")]
	string AddExtraScreenshotstringName { get; }

	
	[Export("kIBGAudioRecordingPermissionDeniedTitlestringName")]
	string AudioRecordingPermissionDeniedTitlestringName { get; }

	
	[Export("kIBGAudioRecordingPermissionDeniedMessagestringName")]
	string AudioRecordingPermissionDeniedMessagestringName { get; }

	
	[Export("kIBGScreenRecordingPermissionDeniedMessagestringName")]
	string ScreenRecordingPermissionDeniedMessagestringName { get; }

	
	[Export("kIBGMicrophonePermissionAlertSettingsButtonTitlestringName")]
	string MicrophonePermissionAlertSettingsButtonTitlestringName { get; }

	
	[Export("kIBGMicrophonePermissionAlertLaterButtonTitlestringName")]
	string MicrophonePermissionAlertLaterButtonTitlestringName { get; }

	
	[Export("kIBGChatsTitlestringName")]
	string ChatsTitlestringName { get; }

	
	[Export("kIBGTeamstringName")]
	string TeamstringName { get; }

	
	[Export("kIBGRecordingMessageToHoldTextstringName")]
	string RecordingMessageToHoldTextstringName { get; }

	
	[Export("kIBGRecordingMessageToReleaseTextstringName")]
	string RecordingMessageToReleaseTextstringName { get; }

	
	[Export("kIBGMessagesNotificationTitleSingleMessagestringName")]
	string MessagesNotificationTitleSingleMessagestringName { get; }

	
	[Export("kIBGMessagesNotificationTitleMultipleMessagesstringName")]
	string MessagesNotificationTitleMultipleMessagesstringName { get; }

	
	[Export("kIBGScreenshotTitlestringName")]
	string ScreenshotTitlestringName { get; }

	
	[Export("kIBGOkButtonTitlestringName")]
	string OkButtonTitlestringName { get; }

	
	[Export("kIBGCancelButtonTitlestringName")]
	string CancelButtonTitlestringName { get; }

	
	[Export("kIBGThankYouAlertTitlestringName")]
	string ThankYouAlertTitlestringName { get; }

	
	[Export("kIBGThankYouAlertMessagestringName")]
	string ThankYouAlertMessagestringName { get; }

	
	[Export("kIBGAudiostringName")]
	string AudiostringName { get; }

	
	[Export("kIBGScreenRecordingstringName")]
	string ScreenRecordingstringName { get; }

	
	[Export("kIBGImagestringName")]
	string ImagestringName { get; }

	
	[Export("kIBGReachedMaximimNumberOfAttachmentsTitlestringName")]
	string ReachedMaximimNumberOfAttachmentsTitlestringName { get; }

	
	[Export("kIBGReachedMaximimNumberOfAttachmentsMessagestringName")]
	string ReachedMaximimNumberOfAttachmentsMessagestringName { get; }

	
	[Export("kIBGSurveyEnterYourAnswerTextPlaceholder")]
	string SurveyEnterYourAnswerTextPlaceholder { get; }

	
	[Export("kIBGSurveyNoAnswerTitle")]
	string SurveyNoAnswerTitle { get; }

	
	[Export("kIBGSurveyNoAnswerMessage")]
	string SurveyNoAnswerMessage { get; }

	
	[Export("kIBGSurveySubmitTitle")]
	string SurveySubmitTitle { get; }

	
	[Export("kIBGVideoPressRecordTitle")]
	string VideoPressRecordTitle { get; }
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
	public enum IBGSDKDebugLogsLevel : System.Int64 {
		Verbose,
		Debug,
		Error,
		None
	}

	[Native]
	public enum IBGPromptOption : System.Int64 {
		Chat,
		Bug,
		Feedback
	}
}
