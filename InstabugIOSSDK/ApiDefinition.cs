using System;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace Instabug
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
		[Export("setPreSendingBlock:")]
		void SetPreSendingBlock(Action preSendingBlock);

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

		// +(void)setScreenshotCapturingBlock:(CGImageRef (^)())screenshotCapturingBlock;
		[Static]
		[Export("setScreenshotCapturingBlock:")]
		unsafe void SetScreenshotCapturingBlock(Func<CGImage> screenshotCapturingBlock);

		// +(void)reportException:(NSException *)exception;
		[Static]
		[Export("reportException:")]
		void ReportException(NSException exception);

		// +(void)invokeConversations;
		[Static]
		[Export("invokeConversations")]
		void InvokeConversations();
	}
}


