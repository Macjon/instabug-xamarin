using System;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace iOSBinding
{
	// @interface Instabug : NSObject
	[BaseType(typeof(NSObject))]
	interface Instabug
	{
		// +(void)startWithToken:(NSString *)token invocationEvent:(IBGInvocationEvent)invocationEvent;
		[Static]
		[Export("startWithToken:invocationEvent:")]
		void StartWithToken(string token, IBGInvocationEvent invocationEvent);

		// +(void)invoke;
		[Static]
		[Export("invoke")]
		void Invoke();

		// +(void)invokeWithInvocationMode:(IBGInvocationMode)invocationMode;
		[Static]
		[Export("invokeWithInvocationMode:")]
		void InvokeWithInvocationMode(IBGInvocationMode invocationMode);

		// +(void)dismiss;
		[Static]
		[Export("dismiss")]
		void Dismiss();

		// +(void)setFileAttachment:(NSString *)fileLocation;
		[Static]
		[Export("setFileAttachment:")]
		void SetFileAttachment(string fileLocation);

		// +(void)setUserData:(NSString *)userData;
		[Static]
		[Export("setUserData:")]
		void SetUserData(string userData);

		// +(void)IBGLog:(NSString *)format withArguments:(va_list)arguments;
		[Static]
		[Export("IBGLog:withArguments:")]
		unsafe void IBGLog(string format, IntPtr arguments);

		// +(void)setUserStepsEnabled:(BOOL)isUserStepsEnabled;
		[Static]
		[Export("setUserStepsEnabled:")]
		void SetUserStepsEnabled(bool isUserStepsEnabled);

		// +(void)setCrashReportingEnabled:(BOOL)isReportingCrashes;
		[Static]
		[Export("setCrashReportingEnabled:")]
		void SetCrashReportingEnabled(bool isReportingCrashes);

		// +(void)setInAppConversationsEnabled:(BOOL)isInAppConversationsEnabled;
		[Static]
		[Export("setInAppConversationsEnabled:")]
		void SetInAppConversationsEnabled(bool isInAppConversationsEnabled);

		// +(void)setPreSendingBlock:(void (^)())preSendingBlock;
		[Static]
		[Export("setPreSendingHandler:")]
		void SetPreSendingHandler(Action preSendingHandler);

		// +(void)setPreInvocationHandler:(void (^)())preInvocationHandler;
		[Static]
		[Export("setPreInvocationHandler:")]
		void setPreInvocationHandler(Action setPreInvocationHandler);

		// +(void)setPostInvocationHandler:(void (^)())postInvocationHandler;
		[Static]
		[Export("setPostInvocationHandler:")]
		void setPostInvocationHandler(Action setPostInvocationHandler);

		// +(void)showIntroMessage;
		[Static]
		[Export("showIntroMessage")]
		void ShowIntroMessage();

		// +(void)setWillTakeScreenshot:(BOOL)willTakeScreenshot;
		[Static]
		[Export("setWillTakeScreenshot:")]
		void SetWillTakeScreenshot(bool willTakeScreenshot);

		// +(void)setUserEmail:(NSString *)userEmail;
		[Static]
		[Export("setUserEmail:")]
		void SetUserEmail(string userEmail);

		// +(void)setUserName:(NSString *)userName;
		[Static]
		[Export("setUserName:")]
		void SetUserName(string userName);

		// +(void)setWillShowScreenshotView:(BOOL)willShowScreenshotView
		[Static]
		[Export("setsetWillShowScreenshotView:")]
		void SetWillShowScreenshotView(bool willShowScreenshotView);

		// +(void)setWillShowScreenshotView:(BOOL)willShowScreenshotView
		[Static]
		[Export("setWillSkipScreenshotAnnotation:")]
		void SetWillSkipScreenshotAnnotation(bool willSkipScreenshotAnnotation);

		// +(NSInteger)getUnreadMessagesCount;
		[Static]
		[Export("getUnreadMessagesCount")]
		Int16 GetUnreadMessagesCount();

		// +(void)setInvocationEvent:(IBGInvocationEvent)invocationEvent;
		[Static]
		[Export("setInvocationEvent:")]
		void SetInvocationEvent(IBGInvocationEvent invocationEvent);

		// +(void)setDefaultInvocationMode:(IBGInvocationMode)invocationMode;
		[Static]
		[Export("setDefaultInvocationMode:")]
		void SetDefaultInvocationMode(IBGInvocationMode invocationMode);

		// +(void)setPushNotificationsEnabled:(BOOL)isPushNotificationsEnabled;
		[Static]
		[Export("setPushNotificationsEnabled:")]
		void SetPushNotificationsEnabled(bool isPushNotificationsEnabled);

		// +(void)setEmailFieldRequired:(BOOL)isEmailFieldRequired;
		[Static]
		[Export("setEmailFieldRequired:")]
		void SetEmailFieldRequired(bool isEmailFieldRequired);

		// +(void)setCommentFieldRequired:(BOOL)isCommentFieldRequired;
		[Static]
		[Export("setCommentFieldRequired:")]
		void SetCommentFieldRequired(bool isCommentFieldRequired);

		// +(void)setShakingThresholdForiPhone:(double)iPhoneShakingThreshold foriPad:(double)iPadShakingThreshold;
		[Static]
		[Export("setShakingThresholdForiPhone:foriPad:")]
		void SetShakingThresholdForiPhone(double iPhoneShakingThreshold, double iPadShakingThreshold);

		// +(void)setFloatingButtonEdge:(CGRectEdge)floatingButtonEdge withTopOffset:(double)floatingButtonOffsetFromTop;
		[Static]
		[Export("setFloatingButtonEdge:withTopOffset:")]
		void SetFloatingButtonEdge(CGRectEdge floatingButtonEdge, double floatingButtonOffsetFromTop);

		// +(void)setLocale:(IBGLocale)locale;
		[Static]
		[Export("setLocale:")]
		void SetLocale(IBGLocale locale);

		// +(void)setIntroMessageEnabled:(BOOL)isIntroMessageEnabled;
		[Static]
		[Export("setIntroMessageEnabled:")]
		void SetIntroMessageEnabled(bool isIntroMessageEnabled);

		// +(void)setColorTheme:(IBGColorTheme)colorTheme;
		[Static]
		[Export("setColorTheme:")]
		void SetColorTheme(IBGColorTheme colorTheme);

		// +(void)setPrimaryColor:(UIColor *)color;
		[Static]
		[Export("setPrimaryColor:")]
		void SetPrimaryColor(UIColor color);

		// +(void)setScreenshotCapturingHandler:(CGImageRef (^)())screenshotCapturingBlock;
		[Static]
		[Export("setScreenshotCapturingHandler:")]
		unsafe void SetScreenshotCapturingHandler(Func<CGImage> screenshotCapturingHandler);

		// +(void)setOnNewMessageHandler:(void (^)())onNewMessageHandler;
		[Static]
		[Export("setOnNewMessageHandler:")]
		void SetOnNewMessageHandler(Action onNewMessageHandler);

		// +(void)setPromptOptionsEnabledWithBug:(BOOL)bugReportEnabled feedback:(BOOL)feedbackEnabled chat:(BOOL)chatEnabled;
		[Static]
		[Export("setPromptOptionsEnabledWithBug:::")]
		void SetPromptOptionsEnabledWithBug(bool bugReportEnabled, bool feedbackEnabled, bool chatEnabled);

		// +(void)appendTags:(NSArray<NSString *> *)tags
		[Static]
		[Export("appendTags:")]
		void AppendTags(String[] tags);

		// +(void)resetTags;
		[Static]
		[Export("resetTags")]
		void ResetTags();

		// +(NSArray *)getTags;
		[Static]
		[Export("getTags")]
		NSArray GetTags();

		// +(void)setString:(NSString*)value toKey:(IBGString)key
		[Static]
		[Export("setString::")]
		void SetString(String value ,String key);

		// + (void)setAttachmentTypesEnabledScreenShot:(BOOL)screenShot
		//		extraScreenShot:(BOOL)extraScreenShot
		//		galleryImage:(BOOL)galleryImage
		//		voiceNote:(BOOL)voiceNote
		//		screenRecording:(BOOL)screenRecording;
		[Static]
		[Export("setAttachmentTypesEnabled:extraScreenShot:galleryImage:voiceNote:screenRecording:")]
		void SetAttachmentTypesEnabled(bool screenShot, bool extraScreenShot, bool galleryImage, bool voiceNote, bool screenRecording);

		// +(void)setChatNotificationEnabled:(BOOL)chatNotificationEnabled;
		[Static]
		[Export("setChatNotificationEnabled:")]
		void SetChatNotificationEnabled(bool enabled);

		// +(void)reportException:(NSException *)exception;
		[Static]
		[Export("reportException:")]
		void ReportException(NSException exception);

		// +(void)invokeConversations;
		[Static]
		[Export("invokeConversations")]
		void InvokeConversations();

		// +(BOOL)isInstabugNotification:(NSDictionary *)notification;
		[Static]
		[Export("isInstabugNotification:")]
		bool IsInstabugNotification(NSDictionary notification);

		// +(void)didRegisterForRemoteNotificationsWithDeviceToken:(NSData *)deviceToken;
		[Static]
		[Export("didRegisterForRemoteNotificationsWithDeviceToken:")]
		void DidRegisterForRemoteNotificationsWithDeviceToken(Byte deviceToken);

		// +(void)didReceiveRemoteNotification:(NSDictionary *)userInfo;
		[Static]
		[Export("didReceiveRemoteNotification:")]
		void DidReceiveRemoteNotification(NSDictionary userInfo);
	}

}

