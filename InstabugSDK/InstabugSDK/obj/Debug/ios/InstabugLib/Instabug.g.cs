//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace InstabugLib {
	[Register("Instabug", true)]
	public unsafe partial class Instabug : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Instabug");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Instabug () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected Instabug (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Instabug (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addFileAttachmentWithURL:")]
		[CompilerGenerated]
		public static void AddFileAttachmentWithURL (NSUrl fileURL)
		{
			if (fileURL == null)
				throw new ArgumentNullException ("fileURL");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("addFileAttachmentWithURL:"), fileURL.Handle);
		}
		
		[Export ("appendTags:")]
		[CompilerGenerated]
		public static void AppendTags (NSArray tags)
		{
			if (tags == null)
				throw new ArgumentNullException ("tags");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("appendTags:"), tags.Handle);
		}
		
		[Export ("clearFileAttachments")]
		[CompilerGenerated]
		public static void ClearFileAttachments ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("clearFileAttachments"));
		}
		
		[Export ("didReceiveRemoteNotification:")]
		[CompilerGenerated]
		public static void DidReceiveRemoteNotification (NSDictionary userInfo)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("didReceiveRemoteNotification:"), userInfo.Handle);
		}
		
		[Export ("didRegisterForRemoteNotificationsWithDeviceToken:")]
		[CompilerGenerated]
		public static void DidRegisterForRemoteNotificationsWithDeviceToken (NSData deviceToken)
		{
			if (deviceToken == null)
				throw new ArgumentNullException ("deviceToken");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("didRegisterForRemoteNotificationsWithDeviceToken:"), deviceToken.Handle);
		}
		
		[Export ("dismiss")]
		[CompilerGenerated]
		public static void Dismiss ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("dismiss"));
		}
		
		[Export ("getTags")]
		[CompilerGenerated]
		public static NSArray GetTags ()
		{
			return  Runtime.GetNSObject<NSArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getTags")));
		}
		
		[Export ("getUnreadMessagesCount")]
		[CompilerGenerated]
		public static int GetUnreadMessagesCount ()
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("getUnreadMessagesCount"));
		}
		
		[Export ("hasAvailableSurveys")]
		[CompilerGenerated]
		public static bool HasAvailableSurveys ()
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("hasAvailableSurveys"));
		}
		
		[Export ("IBGLog:")]
		[CompilerGenerated]
		public static void IBGLog (string log)
		{
			if (log == null)
				throw new ArgumentNullException ("log");
			var nslog = NSString.CreateNative (log);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("IBGLog:"), nslog);
			NSString.ReleaseNative (nslog);
			
		}
		
		[Export ("identifyUserWithEmail:name:")]
		[CompilerGenerated]
		public static void IdentifyUserWithEmail (string email, string name)
		{
			if (email == null)
				throw new ArgumentNullException ("email");
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsemail = NSString.CreateNative (email);
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("identifyUserWithEmail:name:"), nsemail, nsname);
			NSString.ReleaseNative (nsemail);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("invoke")]
		[CompilerGenerated]
		public static void Invoke ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("invoke"));
		}
		
		[Export ("invokeWithInvocationMode:")]
		[CompilerGenerated]
		public static void InvokeWithInvocationMode (IBGInvocationMode invocationMode)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (class_ptr, Selector.GetHandle ("invokeWithInvocationMode:"), (Int64)invocationMode);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("invokeWithInvocationMode:"), (int)invocationMode);
			}
		}
		
		[Export ("isInstabugNotification:")]
		[CompilerGenerated]
		public static void IsInstabugNotification (NSDictionary notification)
		{
			if (notification == null)
				throw new ArgumentNullException ("notification");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isInstabugNotification:"), notification.Handle);
		}
		
		[Export ("logDebug:")]
		[CompilerGenerated]
		public static void LogDebug (string log)
		{
			if (log == null)
				throw new ArgumentNullException ("log");
			var nslog = NSString.CreateNative (log);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("logDebug:"), nslog);
			NSString.ReleaseNative (nslog);
			
		}
		
		[Export ("logError:")]
		[CompilerGenerated]
		public static void LogError (string log)
		{
			if (log == null)
				throw new ArgumentNullException ("log");
			var nslog = NSString.CreateNative (log);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("logError:"), nslog);
			NSString.ReleaseNative (nslog);
			
		}
		
		[Export ("logInfo:")]
		[CompilerGenerated]
		public static void LogInfo (string log)
		{
			if (log == null)
				throw new ArgumentNullException ("log");
			var nslog = NSString.CreateNative (log);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("logInfo:"), nslog);
			NSString.ReleaseNative (nslog);
			
		}
		
		[Export ("logOut")]
		[CompilerGenerated]
		public static void LogOut ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("logOut"));
		}
		
		[Export ("logUserEventWithName:")]
		[CompilerGenerated]
		public static void LogUserEventWithName (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("logUserEventWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("logUserEventWithName:params:")]
		[CompilerGenerated]
		public static void LogUserEventWithName (string name, NSDictionary parameters)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("logUserEventWithName:params:"), nsname, parameters.Handle);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("logVerbose:")]
		[CompilerGenerated]
		public static void LogVerbose (string log)
		{
			if (log == null)
				throw new ArgumentNullException ("log");
			var nslog = NSString.CreateNative (log);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("logVerbose:"), nslog);
			NSString.ReleaseNative (nslog);
			
		}
		
		[Export ("logWarn:")]
		[CompilerGenerated]
		public static void LogWarn (string log)
		{
			if (log == null)
				throw new ArgumentNullException ("log");
			var nslog = NSString.CreateNative (log);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("logWarn:"), nslog);
			NSString.ReleaseNative (nslog);
			
		}
		
		[Export ("removeUserAttributeForKey:")]
		[CompilerGenerated]
		public static void RemoveUserAttributeForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("removeUserAttributeForKey:"), nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("reportError:")]
		[CompilerGenerated]
		public static void ReportError (NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("reportError:"), error.Handle);
		}
		
		[Export ("reportException:")]
		[CompilerGenerated]
		public static void ReportException (NSException exception)
		{
			if (exception == null)
				throw new ArgumentNullException ("exception");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("reportException:"), exception.Handle);
		}
		
		[Export ("resetTags")]
		[CompilerGenerated]
		public static void ResetTags ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("resetTags"));
		}
		
		[Export ("setAttachmentTypesEnabledScreenShot:extraScreenShot:galleryImage:voiceNote:screenRecording:")]
		[CompilerGenerated]
		public static void SetAttachmentTypesEnabledScreenShot (bool screenShot, bool extraScreenShot, bool galleryImage, bool voiceNote, bool screenRecording)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool_bool_bool_bool (class_ptr, Selector.GetHandle ("setAttachmentTypesEnabledScreenShot:extraScreenShot:galleryImage:voiceNote:screenRecording:"), screenShot, extraScreenShot, galleryImage, voiceNote, screenRecording);
		}
		
		[Export ("setChatNotificationEnabled:")]
		[CompilerGenerated]
		public static void SetChatNotificationEnabled (bool chatNotificationEnabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setChatNotificationEnabled:"), chatNotificationEnabled);
		}
		
		[Export ("setColorTheme:")]
		[CompilerGenerated]
		public static void SetColorTheme (IBGColorTheme colorTheme)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (class_ptr, Selector.GetHandle ("setColorTheme:"), (Int64)colorTheme);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setColorTheme:"), (int)colorTheme);
			}
		}
		
		[Export ("setCommentFieldRequired:")]
		[CompilerGenerated]
		public static void SetCommentFieldRequired (bool isCommentFieldRequired)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setCommentFieldRequired:"), isCommentFieldRequired);
		}
		
		[Export ("setCrashReportingEnabled:")]
		[CompilerGenerated]
		public static void SetCrashReportingEnabled (bool isUserStepsEnabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setCrashReportingEnabled:"), isUserStepsEnabled);
		}
		
		[Export ("setDidDismissSurveyHandler:")]
		[CompilerGenerated]
		public unsafe static void SetDidDismissSurveyHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action didShowSurveyHandler)
		{
			if (didShowSurveyHandler == null)
				throw new ArgumentNullException ("didShowSurveyHandler");
			BlockLiteral *block_ptr_didShowSurveyHandler;
			BlockLiteral block_didShowSurveyHandler;
			block_didShowSurveyHandler = new BlockLiteral ();
			block_ptr_didShowSurveyHandler = &block_didShowSurveyHandler;
			block_didShowSurveyHandler.SetupBlock (Trampolines.SDAction.Handler, didShowSurveyHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setDidDismissSurveyHandler:"), (IntPtr) block_ptr_didShowSurveyHandler);
			block_ptr_didShowSurveyHandler->CleanupBlock ();
			
		}
		
		[Export ("setDidSelectPromptOptionHandler:")]
		[CompilerGenerated]
		public unsafe static void SetDidSelectPromptOptionHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPromptOptionHandler))]PromptOptionHandler didSelectPromptOptionHandler)
		{
			if (didSelectPromptOptionHandler == null)
				throw new ArgumentNullException ("didSelectPromptOptionHandler");
			BlockLiteral *block_ptr_didSelectPromptOptionHandler;
			BlockLiteral block_didSelectPromptOptionHandler;
			block_didSelectPromptOptionHandler = new BlockLiteral ();
			block_ptr_didSelectPromptOptionHandler = &block_didSelectPromptOptionHandler;
			block_didSelectPromptOptionHandler.SetupBlock (Trampolines.SDPromptOptionHandler.Handler, didSelectPromptOptionHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setDidSelectPromptOptionHandler:"), (IntPtr) block_ptr_didSelectPromptOptionHandler);
			block_ptr_didSelectPromptOptionHandler->CleanupBlock ();
			
		}
		
		[Export ("setEmailFieldRequired:")]
		[CompilerGenerated]
		public static void SetEmailFieldRequired (bool isEmailFieldRequired)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setEmailFieldRequired:"), isEmailFieldRequired);
		}
		
		[Export ("setFloatingButtonEdge:withTopOffset:")]
		[CompilerGenerated]
		public static void SetFloatingButtonEdge (CGRectEdge floatingButtonEdge, global::System.Double floatingButtonOffsetFromTop)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_Double (class_ptr, Selector.GetHandle ("setFloatingButtonEdge:withTopOffset:"), (UInt32)floatingButtonEdge, floatingButtonOffsetFromTop);
		}
		
		[Export ("setIBGLogPrintsToConsole:")]
		[CompilerGenerated]
		public static void SetIBGLogPrintsToConsole (bool enabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setIBGLogPrintsToConsole:"), enabled);
		}
		
		[Export ("setIntroMessageEnabled:")]
		[CompilerGenerated]
		public static void SetIntroMessageEnabled (bool isIntroMessageEnabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setIntroMessageEnabled:"), isIntroMessageEnabled);
		}
		
		[Export ("setInvocationEvent:")]
		[CompilerGenerated]
		public static void SetInvocationEvent (IBGInvocationEvent invocationEvent)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (class_ptr, Selector.GetHandle ("setInvocationEvent:"), (Int64)invocationEvent);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setInvocationEvent:"), (int)invocationEvent);
			}
		}
		
		[Export ("setLocale:")]
		[CompilerGenerated]
		public static void SetLocale (IBGLocale locale)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (class_ptr, Selector.GetHandle ("setLocale:"), (Int64)locale);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setLocale:"), (int)locale);
			}
		}
		
		[Export ("setNetworkLoggingEnabled:")]
		[CompilerGenerated]
		public static void SetNetworkLoggingEnabled (bool isNetworkLoggingEnabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setNetworkLoggingEnabled:"), isNetworkLoggingEnabled);
		}
		
		[Export ("setNetworkLoggingRequestFilterPredicate:responseFilterPredicate:")]
		[CompilerGenerated]
		public static void SetNetworkLoggingRequestFilterPredicate (NSPredicate requestFilterPredicate, NSPredicate responseFilterPredicate)
		{
			if (requestFilterPredicate == null)
				throw new ArgumentNullException ("requestFilterPredicate");
			if (responseFilterPredicate == null)
				throw new ArgumentNullException ("responseFilterPredicate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setNetworkLoggingRequestFilterPredicate:responseFilterPredicate:"), requestFilterPredicate.Handle, responseFilterPredicate.Handle);
		}
		
		[Export ("setOnNewMessageHandler:")]
		[CompilerGenerated]
		public unsafe static void SetOnNewMessageHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action onNewMessageHandler)
		{
			if (onNewMessageHandler == null)
				throw new ArgumentNullException ("onNewMessageHandler");
			BlockLiteral *block_ptr_onNewMessageHandler;
			BlockLiteral block_onNewMessageHandler;
			block_onNewMessageHandler = new BlockLiteral ();
			block_ptr_onNewMessageHandler = &block_onNewMessageHandler;
			block_onNewMessageHandler.SetupBlock (Trampolines.SDAction.Handler, onNewMessageHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setOnNewMessageHandler:"), (IntPtr) block_ptr_onNewMessageHandler);
			block_ptr_onNewMessageHandler->CleanupBlock ();
			
		}
		
		[Export ("setPostInvocationHandler:")]
		[CompilerGenerated]
		public unsafe static void SetPostInvocationHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPostInvocationHandler))]PostInvocationHandler postInvocationHandler)
		{
			if (postInvocationHandler == null)
				throw new ArgumentNullException ("postInvocationHandler");
			BlockLiteral *block_ptr_postInvocationHandler;
			BlockLiteral block_postInvocationHandler;
			block_postInvocationHandler = new BlockLiteral ();
			block_ptr_postInvocationHandler = &block_postInvocationHandler;
			block_postInvocationHandler.SetupBlock (Trampolines.SDPostInvocationHandler.Handler, postInvocationHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setPostInvocationHandler:"), (IntPtr) block_ptr_postInvocationHandler);
			block_ptr_postInvocationHandler->CleanupBlock ();
			
		}
		
		[Export ("setPostSendingDialogEnabled:")]
		[CompilerGenerated]
		public static void SetPostSendingDialogEnabled (bool isPostSendingDialogEnabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setPostSendingDialogEnabled:"), isPostSendingDialogEnabled);
		}
		
		[Export ("setPreInvocationHandler:")]
		[CompilerGenerated]
		public unsafe static void SetPreInvocationHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action preInvocationHandler)
		{
			if (preInvocationHandler == null)
				throw new ArgumentNullException ("preInvocationHandler");
			BlockLiteral *block_ptr_preInvocationHandler;
			BlockLiteral block_preInvocationHandler;
			block_preInvocationHandler = new BlockLiteral ();
			block_ptr_preInvocationHandler = &block_preInvocationHandler;
			block_preInvocationHandler.SetupBlock (Trampolines.SDAction.Handler, preInvocationHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setPreInvocationHandler:"), (IntPtr) block_ptr_preInvocationHandler);
			block_ptr_preInvocationHandler->CleanupBlock ();
			
		}
		
		[Export ("setPreSendingHandler:")]
		[CompilerGenerated]
		public unsafe static void SetPreSendingHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action preSendingHandler)
		{
			if (preSendingHandler == null)
				throw new ArgumentNullException ("preSendingHandler");
			BlockLiteral *block_ptr_preSendingHandler;
			BlockLiteral block_preSendingHandler;
			block_preSendingHandler = new BlockLiteral ();
			block_ptr_preSendingHandler = &block_preSendingHandler;
			block_preSendingHandler.SetupBlock (Trampolines.SDAction.Handler, preSendingHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setPreSendingHandler:"), (IntPtr) block_ptr_preSendingHandler);
			block_ptr_preSendingHandler->CleanupBlock ();
			
		}
		
		[Export ("setPrimaryColor:")]
		[CompilerGenerated]
		public static void SetPrimaryColor (global::UIKit.UIColor color)
		{
			if (color == null)
				throw new ArgumentNullException ("color");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setPrimaryColor:"), color.Handle);
		}
		
		[Export ("setPromptOptionsEnabledWithBug:feedback:chat:")]
		[CompilerGenerated]
		public static void SetPromptOptionsEnabledWithBug (bool bugReportEnabled, bool feedbackEnabled, bool chatEnabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool_bool (class_ptr, Selector.GetHandle ("setPromptOptionsEnabledWithBug:feedback:chat:"), bugReportEnabled, feedbackEnabled, chatEnabled);
		}
		
		[Export ("setPushNotificationsEnabled:")]
		[CompilerGenerated]
		public static void SetPushNotificationsEnabled (bool isPushNotificationsEnabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setPushNotificationsEnabled:"), isPushNotificationsEnabled);
		}
		
		[Export ("setReportCategoriesWithTitles:iconNames:")]
		[CompilerGenerated]
		public static void SetReportCategoriesWithTitles (NSArray titles, NSArray names)
		{
			if (titles == null)
				throw new ArgumentNullException ("titles");
			if (names == null)
				throw new ArgumentNullException ("names");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setReportCategoriesWithTitles:iconNames:"), titles.Handle, names.Handle);
		}
		
		[Export ("setSDKDebugLogsLevel:")]
		[CompilerGenerated]
		public static void SetSDKDebugLogsLevel (IBGSDKDebugLogsLevel level)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (class_ptr, Selector.GetHandle ("setSDKDebugLogsLevel:"), (Int64)level);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setSDKDebugLogsLevel:"), (int)level);
			}
		}
		
		[Export ("setScreenshotCapturingHandler:")]
		[CompilerGenerated]
		public unsafe static void SetScreenshotCapturingHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDScreenshotCapturingHandler))]ScreenshotCapturingHandler screenshotCapturingHandler)
		{
			if (screenshotCapturingHandler == null)
				throw new ArgumentNullException ("screenshotCapturingHandler");
			BlockLiteral *block_ptr_screenshotCapturingHandler;
			BlockLiteral block_screenshotCapturingHandler;
			block_screenshotCapturingHandler = new BlockLiteral ();
			block_ptr_screenshotCapturingHandler = &block_screenshotCapturingHandler;
			block_screenshotCapturingHandler.SetupBlock (Trampolines.SDScreenshotCapturingHandler.Handler, screenshotCapturingHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setScreenshotCapturingHandler:"), (IntPtr) block_ptr_screenshotCapturingHandler);
			block_ptr_screenshotCapturingHandler->CleanupBlock ();
			
		}
		
		[Export ("setShakingThresholdForiPhone:foriPad:")]
		[CompilerGenerated]
		public static void SetShakingThresholdForiPhone (global::System.Double iPhoneShakingThreshold, global::System.Double iPadShakingThreshold)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_Double (class_ptr, Selector.GetHandle ("setShakingThresholdForiPhone:foriPad:"), iPhoneShakingThreshold, iPadShakingThreshold);
		}
		
		[Export ("setShowEmailField:")]
		[CompilerGenerated]
		public static void SetShowEmailField (bool isShowingEmailField)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setShowEmailField:"), isShowingEmailField);
		}
		
		[Export ("setSurveysEnabled:")]
		[CompilerGenerated]
		public static void SetSurveysEnabled (bool surveysEnabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setSurveysEnabled:"), surveysEnabled);
		}
		
		[Export ("setUserAttribute:withKey:")]
		[CompilerGenerated]
		public static void SetUserAttribute (string value, string key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setUserAttribute:withKey:"), nsvalue, nskey);
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("setUserData:")]
		[CompilerGenerated]
		public static void SetUserData (string userData)
		{
			if (userData == null)
				throw new ArgumentNullException ("userData");
			var nsuserData = NSString.CreateNative (userData);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setUserData:"), nsuserData);
			NSString.ReleaseNative (nsuserData);
			
		}
		
		[Export ("setUserStepsEnabled:")]
		[CompilerGenerated]
		public static void SetUserStepsEnabled (bool isUserStepsEnabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setUserStepsEnabled:"), isUserStepsEnabled);
		}
		
		[Export ("setValue:forStringWithKey:")]
		[CompilerGenerated]
		public static void SetValue (string value, string key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setValue:forStringWithKey:"), nsvalue, nskey);
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("setViewHierarchyEnabled:")]
		[CompilerGenerated]
		public static void SetViewHierarchyEnabled (bool viewHierarchyEnabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setViewHierarchyEnabled:"), viewHierarchyEnabled);
		}
		
		[Export ("setWillShowSurveyHandler:")]
		[CompilerGenerated]
		public unsafe static void SetWillShowSurveyHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action willShowSurveyHandler)
		{
			if (willShowSurveyHandler == null)
				throw new ArgumentNullException ("willShowSurveyHandler");
			BlockLiteral *block_ptr_willShowSurveyHandler;
			BlockLiteral block_willShowSurveyHandler;
			block_willShowSurveyHandler = new BlockLiteral ();
			block_ptr_willShowSurveyHandler = &block_willShowSurveyHandler;
			block_willShowSurveyHandler.SetupBlock (Trampolines.SDAction.Handler, willShowSurveyHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setWillShowSurveyHandler:"), (IntPtr) block_ptr_willShowSurveyHandler);
			block_ptr_willShowSurveyHandler->CleanupBlock ();
			
		}
		
		[Export ("setWillSkipScreenshotAnnotation:")]
		[CompilerGenerated]
		public static void SetWillSkipScreenshotAnnotation (bool willSkipScreenShot)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setWillSkipScreenshotAnnotation:"), willSkipScreenShot);
		}
		
		[Export ("showIntroMessage")]
		[CompilerGenerated]
		public static void ShowIntroMessage ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("showIntroMessage"));
		}
		
		[Export ("showSurveyIfAvailable")]
		[CompilerGenerated]
		public static void ShowSurveyIfAvailable ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("showSurveyIfAvailable"));
		}
		
		[Export ("startWithToken:invocationEvent:")]
		[CompilerGenerated]
		public static void StartWithToken (string token, IBGInvocationEvent invocationEvent)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			var nstoken = NSString.CreateNative (token);
			
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Int64 (class_ptr, Selector.GetHandle ("startWithToken:invocationEvent:"), nstoken, (Int64)invocationEvent);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (class_ptr, Selector.GetHandle ("startWithToken:invocationEvent:"), nstoken, (int)invocationEvent);
			}
			NSString.ReleaseNative (nstoken);
			
		}
		
		[Export ("userAttributeForKey:")]
		[CompilerGenerated]
		public static string UserAttributeForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("userAttributeForKey:"), nskey));
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("userAttributes")]
		[CompilerGenerated]
		public static NSDictionary UserAttributes ()
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("userAttributes")));
		}
		
	} /* class Instabug */
}
