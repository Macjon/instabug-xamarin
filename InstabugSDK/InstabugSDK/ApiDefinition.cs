using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace InstabugLib
{
	delegate void PostInvocationHandler(IBGDismissType dismissType, IBGReportType reportType);
	delegate void PromptOptionHandler(IBGPromptOption promptOption);
	delegate UIImage ScreenshotCapturingHandler();

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
		[Export("addFileAttachmentWithURL:")]
		void AddFileAttachmentWithURL(NSUrl fileURL);

		// +(void)clearFileAttachments;
		[Static]
		[Export("clearFileAttachments")]
		void ClearFileAttachments();

		// + (void)setUserData:(NSString *)userData;
		[Static]
		[Export("setUserData:")]
		void SetUserData(string userData);

		// + (void)setUserStepsEnabled:(BOOL)isUserStepsEnabled;
		[Static]
		[Export("setUserStepsEnabled:")]
		void SetUserStepsEnabled(bool isUserStepsEnabled);

		// + (void)setCrashReportingEnabled:(BOOL)isReportingCrashes;
		[Static]
		[Export("setCrashReportingEnabled:")]
		void SetCrashReportingEnabled(bool isUserStepsEnabled);

		// + (void)setPreSendingHandler:(void (^)())preSendingHandler;
		[Static]
		[Export("setPreSendingHandler:")]
		void SetPreSendingHandler(Action preSendingHandler);

		// + (void)setPreInvocationHandler:(void (^)())preInvocationHandler;
		[Static]
		[Export("setPreInvocationHandler:")]
		void SetPreInvocationHandler(Action preInvocationHandler);

		// + (void)setPostInvocationHandler:(void (^)(IBGDismissType dismissType, IBGReportType reportType))postInvocationHandler;
		[Static]
		[Export("setPostInvocationHandler:")]
		void SetPostInvocationHandler(PostInvocationHandler postInvocationHandler);

		// + (void)setDidSelectPromptOptionHandler:(void (^)(IBGPromptOption promptOption))didSelectPromptOptionHandler;
		[Static]
		[Export("setDidSelectPromptOptionHandler:")]
		void SetDidSelectPromptOptionHandler(PromptOptionHandler didSelectPromptOptionHandler);

		// + (void)showIntroMessage;
		[Static]
		[Export("showIntroMessage")]
		void ShowIntroMessage();

		// + (void)identifyUserWithEmail:(NSString *)email name:(nullable NSString *)name;
		[Static]
		[Export("identifyUserWithEmail:name:")]
		void IdentifyUserWithEmail(string email, string name);

		// + (void)logOut;
		[Static]
		[Export("logOut")]
		void LogOut();

		// + (void)setShowEmailField:(BOOL)isShowingEmailField;
		[Static]
		[Export("setShowEmailField:")]
		void SetShowEmailField(bool isShowingEmailField);

		// + (void)setWillSkipScreenshotAnnotation:(BOOL)willSkipScreenShot;
		[Static]
		[Export("setWillSkipScreenshotAnnotation:")]
		void SetWillSkipScreenshotAnnotation(bool willSkipScreenShot);

		// + (NSInteger)getUnreadMessagesCount;
		[Static]
		[Export("getUnreadMessagesCount")]
		int GetUnreadMessagesCount();

		// + (void)setInvocationEvent:(IBGInvocationEvent)invocationEvent;
		[Static]
		[Export("setInvocationEvent:")]
		void SetInvocationEvent(IBGInvocationEvent invocationEvent);

		// + (void)setPushNotificationsEnabled:(BOOL)isPushNotificationsEnabled;
		[Static]
		[Export("setPushNotificationsEnabled:")]
		void SetPushNotificationsEnabled(bool isPushNotificationsEnabled);

		// + (void)setEmailFieldRequired:(BOOL)isEmailFieldRequired;
		[Static]
		[Export("setEmailFieldRequired:")]
		void SetEmailFieldRequired(bool isEmailFieldRequired);

		// + (void)setCommentFieldRequired:(BOOL)isCommentFieldRequired;
		[Static]
		[Export("setCommentFieldRequired:")]
		void SetCommentFieldRequired(bool isCommentFieldRequired);

		// + (void)setShakingThresholdForiPhone:(double)iPhoneShakingThreshold foriPad:(double)iPadShakingThreshold;
		[Static]
		[Export("setShakingThresholdForiPhone:foriPad:")]
		void SetShakingThresholdForiPhone(double iPhoneShakingThreshold, double iPadShakingThreshold);

		// + (void)setFloatingButtonEdge:(CGRectEdge)floatingButtonEdge withTopOffset:(double)floatingButtonOffsetFromTop;
		[Static]
		[Export("setFloatingButtonEdge:withTopOffset:")]
		void SetFloatingButtonEdge(CGRectEdge floatingButtonEdge, double floatingButtonOffsetFromTop);

		// + (void)setLocale:(IBGLocale)locale;
		[Static]
		[Export("setLocale:")]
		void SetLocale(IBGLocale locale);

		// + (void)setIntroMessageEnabled:(BOOL)isIntroMessageEnabled;
		[Static]
		[Export("setIntroMessageEnabled:")]
		void SetIntroMessageEnabled(bool isIntroMessageEnabled);

		// + (void)setPostSendingDialogEnabled:(BOOL)isPostSendingDialogEnabled;
		[Static]
		[Export("setPostSendingDialogEnabled:")]
		void SetPostSendingDialogEnabled(bool isPostSendingDialogEnabled);

		// + (void)setColorTheme:(IBGColorTheme)colorTheme;
		[Static]
		[Export("setColorTheme:")]
		void SetColorTheme(IBGColorTheme colorTheme);

		// + (void)setPrimaryColor:(UIColor *)color;
		[Static]
		[Export("setPrimaryColor:")]
		void SetPrimaryColor(UIColor color);

		// + (void)setScreenshotCapturingHandler:(UIImage *(^)())screenshotCapturingHandler;
		[Static]
		[Export("setScreenshotCapturingHandler:")]
		void SetScreenshotCapturingHandler(ScreenshotCapturingHandler screenshotCapturingHandler);

		// + (void)appendTags:(NSArray<NSString *> *)tags;
		[Static]
		[Export("appendTags:")]
		void AppendTags(NSArray tags);

		// + (void)resetTags;
		[Static]
		[Export("resetTags")]
		void ResetTags();

		// + (NSArray *)getTags;
		[Static]
		[Export("getTags")]
		NSArray GetTags();

		// + (void)setString:(NSString*)value toKey:(IBGString)key;
		[Static]
		[Export("setString:toKey:")]
		void SetString(string value, IBGString key);

		// + (void)setAttachmentTypesEnabledScreenShot:(BOOL)screenShot
		//                    extraScreenShot:(BOOL)extraScreenShot
		//					   galleryImage:(BOOL)galleryImage
		//						  voiceNote:(BOOL)voiceNote
		//					screenRecording:(BOOL)screenRecording;

		[Static]
		[Export("setAttachmentTypesEnabledScreenShot:extraScreenShot:galleryImage:voiceNote:screenRecording:")]
		void SetAttachmentTypesEnabledScreenShot(bool screenShot, bool extraScreenShot, bool galleryImage, bool voiceNote, bool screenRecording);

		// + (void)setChatNotificationEnabled:(BOOL)chatNotificationEnabled;
		[Static]
		[Export("setChatNotificationEnabled:")]
		void SetChatNotificationEnabled(bool chatNotificationEnabled);

		// + (void)setOnNewMessageHandler:(void (^)())onNewMessageHandler;
		[Static]
		[Export("setOnNewMessageHandler:")]
		void SetOnNewMessageHandler(Action onNewMessageHandler);

		//+ (void)setPromptOptionsEnabledWithBug:(BOOL)bugReportEnabled feedback:(BOOL)feedbackEnabled chat:(BOOL)chatEnabled;
		[Static]
		[Export("setPromptOptionsEnabledWithBug:feedback:chat:")]
		void SetPromptOptionsEnabledWithBug(bool bugReportEnabled, bool feedbackEnabled, bool chatEnabled);

		// + (void)setReportCategoriesWithTitles:(NSArray<NSString *> *)titles iconNames:(nullable NSArray<NSString *> *)names;
		[Static]
		[Export("setReportCategoriesWithTitles:iconNames:")]
		void SetReportCategoriesWithTitles(NSArray titles, NSArray names);

		//+ (void)setUserAttribute:(NSString *)value withKey:(NSString *)key;
		[Static]
		[Export("setUserAttribute:withKey:")]
		void SetUserAttribute(string value, string key);

		// + (nullable NSString *)userAttributeForKey:(NSString *)key;
		[Static]
		[Export("userAttributeForKey:")]
		string UserAttributeForKey(string key);

		//+ (void)removeUserAttributeForKey:(NSString *)key;
		[Static]
		[Export("removeUserAttributeForKey:")]
		void RemoveUserAttributeForKey(string key);

		// + (nullable NSDictionary *)userAttributes;
		[Static]
		[Export("userAttributes")]
		NSDictionary UserAttributes();

		// + (void)setViewHierarchyEnabled:(BOOL)viewHierarchyEnabled;
		[Static]
		[Export("setViewHierarchyEnabled:")]
		void SetViewHierarchyEnabled(bool viewHierarchyEnabled);

		// + (void)reportException:(NSException *)exception;
		[Static]
		[Export("reportException:")]
		void ReportException(NSException exception);

		// + (void)reportError:(NSError *)error;
		[Static]
		[Export("reportError:")]
		void ReportError(NSError error);

		// + (BOOL)isInstabugNotification:(NSDictionary *)notification;
		[Static]
		[Export("isInstabugNotification:")]
		void IsInstabugNotification(NSDictionary notification);

		// + (void)didRegisterForRemoteNotificationsWithDeviceToken:(NSData *)deviceToken;
		[Static]
		[Export("didRegisterForRemoteNotificationsWithDeviceToken:")]
		void DidRegisterForRemoteNotificationsWithDeviceToken(NSData deviceToken);

		// + (void)didReceiveRemoteNotification:(NSDictionary *)userInfo;
		[Static]
		[Export("didReceiveRemoteNotification:")]
		void DidReceiveRemoteNotification(NSDictionary userInfo);

		// + (void)logUserEventWithName:(NSString *)name;
		[Static]
		[Export("logUserEventWithName:")]
		void LogUserEventWithName(string name);

		// + (void)logUserEventWithName:(NSString *)name params:(nullable NSDictionary *)params;
		[Static]
		[Export("logUserEventWithName:params:")]
		void LogUserEventWithName(string name, NSDictionary parameters);

		// + (void)IBGLog:(NSString *)log;
		[Static]
		[Export("IBGLog:")]
		void IBGLog(string log);

		// + (void)logVerbose:(NSString *)log;
		[Static]
		[Export("logVerbose:")]
		void LogVerbose(string log);

		// + (void)logDebug:(NSString *)log;
		[Static]
		[Export("logDebug:")]
		void LogDebug(string log);

		// + (void)logInfo:(NSString *)log;
		[Static]
		[Export("logInfo:")]
		void LogInfo(string log);

		// + (void)logWarn:(NSString *)log;
		[Static]
		[Export("logWarn:")]
		void LogWarn(string log);

		// + (void)logError:(NSString *)log;
		[Static]
		[Export("logError:")]
		void LogError(string log);

		// + (void)setIBGLogPrintsToConsole:(BOOL)enabled;
		[Static]
		[Export("setIBGLogPrintsToConsole:")]
		void SetIBGLogPrintsToConsole(bool enabled);

		// + (void)setNetworkLoggingEnabled:(BOOL)isNetworkLoggingEnabled;
		[Static]
		[Export("setNetworkLoggingEnabled:")]
		void SetNetworkLoggingEnabled(bool isNetworkLoggingEnabled);

		// + (void)setNetworkLoggingRequestFilterPredicate:(nullable NSPredicate *)requestFilterPredicate responseFilterPredicate:(nullable NSPredicate *)responseFilterPredicate;
		[Static]
		[Export("setNetworkLoggingRequestFilterPredicate:responseFilterPredicate:")]
		void SetNetworkLoggingRequestFilterPredicate(NSPredicate requestFilterPredicate, NSPredicate responseFilterPredicate);

		// + (void)setSurveysEnabled:(BOOL)surveysEnabled;
		[Static]
		[Export("setSurveysEnabled:")]
		void SetSurveysEnabled(bool surveysEnabled);

		// + (void)showSurveyIfAvailable;
		[Static]
		[Export("showSurveyIfAvailable")]
		void ShowSurveyIfAvailable();

		// + (BOOL)hasAvailableSurveys;
		[Static]
		[Export("hasAvailableSurveys")]
		bool HasAvailableSurveys();

		// + (void)setWillShowSurveyHandler:(void (^)())willShowSurveyHandler;
		[Static]
		[Export("setWillShowSurveyHandler:")]
		void SetWillShowSurveyHandler(Action willShowSurveyHandler);

		// + (void)setDidDismissSurveyHandler:(void (^)())didShowSurveyHandler;
		[Static]
		[Export("setDidDismissSurveyHandler:")]
		void SetDidDismissSurveyHandler(Action didShowSurveyHandler);

		//+ (void)setSDKDebugLogsLevel:(IBGSDKDebugLogsLevel)level;
		[Static]
		[Export("setSDKDebugLogsLevel:")]
		void SetSDKDebugLogsLevel(IBGSDKDebugLogsLevel level);
	}
}
