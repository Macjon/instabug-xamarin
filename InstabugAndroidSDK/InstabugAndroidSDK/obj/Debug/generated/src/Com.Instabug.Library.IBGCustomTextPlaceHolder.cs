using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/instabug/library/IBGCustomTextPlaceHolder", DoNotGenerateAcw=true)]
	public partial class IBGCustomTextPlaceHolder : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[global::Android.Runtime.Register ("com/instabug/library/IBGCustomTextPlaceHolder$Key", DoNotGenerateAcw=true)]
		public sealed partial class Key : global::Java.Lang.Enum {


			static IntPtr ADD_EXTRA_SCREENSHOT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='ADD_EXTRA_SCREENSHOT']"
			[Register ("ADD_EXTRA_SCREENSHOT")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key AddExtraScreenshot {
				get {
					if (ADD_EXTRA_SCREENSHOT_jfieldId == IntPtr.Zero)
						ADD_EXTRA_SCREENSHOT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADD_EXTRA_SCREENSHOT", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADD_EXTRA_SCREENSHOT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ADD_IMAGE_FROM_GALLERY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='ADD_IMAGE_FROM_GALLERY']"
			[Register ("ADD_IMAGE_FROM_GALLERY")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key AddImageFromGallery {
				get {
					if (ADD_IMAGE_FROM_GALLERY_jfieldId == IntPtr.Zero)
						ADD_IMAGE_FROM_GALLERY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADD_IMAGE_FROM_GALLERY", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADD_IMAGE_FROM_GALLERY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ADD_VIDEO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='ADD_VIDEO']"
			[Register ("ADD_VIDEO")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key AddVideo {
				get {
					if (ADD_VIDEO_jfieldId == IntPtr.Zero)
						ADD_VIDEO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADD_VIDEO", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADD_VIDEO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ADD_VOICE_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='ADD_VOICE_MESSAGE']"
			[Register ("ADD_VOICE_MESSAGE")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key AddVoiceMessage {
				get {
					if (ADD_VOICE_MESSAGE_jfieldId == IntPtr.Zero)
						ADD_VOICE_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADD_VOICE_MESSAGE", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADD_VOICE_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUDIO_RECORDING_PERMISSION_DENIED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='AUDIO_RECORDING_PERMISSION_DENIED']"
			[Register ("AUDIO_RECORDING_PERMISSION_DENIED")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key AudioRecordingPermissionDenied {
				get {
					if (AUDIO_RECORDING_PERMISSION_DENIED_jfieldId == IntPtr.Zero)
						AUDIO_RECORDING_PERMISSION_DENIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_RECORDING_PERMISSION_DENIED", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_RECORDING_PERMISSION_DENIED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BUG_REPORT_HEADER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='BUG_REPORT_HEADER']"
			[Register ("BUG_REPORT_HEADER")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key BugReportHeader {
				get {
					if (BUG_REPORT_HEADER_jfieldId == IntPtr.Zero)
						BUG_REPORT_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUG_REPORT_HEADER", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUG_REPORT_HEADER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMMENT_FIELD_HINT_FOR_BUG_REPORT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='COMMENT_FIELD_HINT_FOR_BUG_REPORT']"
			[Register ("COMMENT_FIELD_HINT_FOR_BUG_REPORT")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key CommentFieldHintForBugReport {
				get {
					if (COMMENT_FIELD_HINT_FOR_BUG_REPORT_jfieldId == IntPtr.Zero)
						COMMENT_FIELD_HINT_FOR_BUG_REPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMMENT_FIELD_HINT_FOR_BUG_REPORT", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMMENT_FIELD_HINT_FOR_BUG_REPORT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMMENT_FIELD_HINT_FOR_FEEDBACK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='COMMENT_FIELD_HINT_FOR_FEEDBACK']"
			[Register ("COMMENT_FIELD_HINT_FOR_FEEDBACK")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key CommentFieldHintForFeedback {
				get {
					if (COMMENT_FIELD_HINT_FOR_FEEDBACK_jfieldId == IntPtr.Zero)
						COMMENT_FIELD_HINT_FOR_FEEDBACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMMENT_FIELD_HINT_FOR_FEEDBACK", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMMENT_FIELD_HINT_FOR_FEEDBACK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONVERSATIONS_LIST_TITLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='CONVERSATIONS_LIST_TITLE']"
			[Register ("CONVERSATIONS_LIST_TITLE")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key ConversationsListTitle {
				get {
					if (CONVERSATIONS_LIST_TITLE_jfieldId == IntPtr.Zero)
						CONVERSATIONS_LIST_TITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATIONS_LIST_TITLE", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATIONS_LIST_TITLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONVERSATION_TEXT_FIELD_HINT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='CONVERSATION_TEXT_FIELD_HINT']"
			[Register ("CONVERSATION_TEXT_FIELD_HINT")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key ConversationTextFieldHint {
				get {
					if (CONVERSATION_TEXT_FIELD_HINT_jfieldId == IntPtr.Zero)
						CONVERSATION_TEXT_FIELD_HINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION_TEXT_FIELD_HINT", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATION_TEXT_FIELD_HINT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EMAIL_FIELD_HINT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='EMAIL_FIELD_HINT']"
			[Register ("EMAIL_FIELD_HINT")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key EmailFieldHint {
				get {
					if (EMAIL_FIELD_HINT_jfieldId == IntPtr.Zero)
						EMAIL_FIELD_HINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMAIL_FIELD_HINT", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMAIL_FIELD_HINT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FEEDBACK_REPORT_HEADER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='FEEDBACK_REPORT_HEADER']"
			[Register ("FEEDBACK_REPORT_HEADER")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key FeedbackReportHeader {
				get {
					if (FEEDBACK_REPORT_HEADER_jfieldId == IntPtr.Zero)
						FEEDBACK_REPORT_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FEEDBACK_REPORT_HEADER", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FEEDBACK_REPORT_HEADER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INVALID_COMMENT_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='INVALID_COMMENT_MESSAGE']"
			[Register ("INVALID_COMMENT_MESSAGE")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key InvalidCommentMessage {
				get {
					if (INVALID_COMMENT_MESSAGE_jfieldId == IntPtr.Zero)
						INVALID_COMMENT_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_COMMENT_MESSAGE", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_COMMENT_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INVALID_EMAIL_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='INVALID_EMAIL_MESSAGE']"
			[Register ("INVALID_EMAIL_MESSAGE")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key InvalidEmailMessage {
				get {
					if (INVALID_EMAIL_MESSAGE_jfieldId == IntPtr.Zero)
						INVALID_EMAIL_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_EMAIL_MESSAGE", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_EMAIL_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INVOCATION_HEADER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='INVOCATION_HEADER']"
			[Register ("INVOCATION_HEADER")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key InvocationHeader {
				get {
					if (INVOCATION_HEADER_jfieldId == IntPtr.Zero)
						INVOCATION_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVOCATION_HEADER", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVOCATION_HEADER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REPORT_BUG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='REPORT_BUG']"
			[Register ("REPORT_BUG")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key ReportBug {
				get {
					if (REPORT_BUG_jfieldId == IntPtr.Zero)
						REPORT_BUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPORT_BUG", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPORT_BUG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REPORT_FEEDBACK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='REPORT_FEEDBACK']"
			[Register ("REPORT_FEEDBACK")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key ReportFeedback {
				get {
					if (REPORT_FEEDBACK_jfieldId == IntPtr.Zero)
						REPORT_FEEDBACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPORT_FEEDBACK", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPORT_FEEDBACK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REPORT_SUCCESSFULLY_SENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='REPORT_SUCCESSFULLY_SENT']"
			[Register ("REPORT_SUCCESSFULLY_SENT")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key ReportSuccessfullySent {
				get {
					if (REPORT_SUCCESSFULLY_SENT_jfieldId == IntPtr.Zero)
						REPORT_SUCCESSFULLY_SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPORT_SUCCESSFULLY_SENT", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPORT_SUCCESSFULLY_SENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SHAKE_HINT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='SHAKE_HINT']"
			[Register ("SHAKE_HINT")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key ShakeHint {
				get {
					if (SHAKE_HINT_jfieldId == IntPtr.Zero)
						SHAKE_HINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHAKE_HINT", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHAKE_HINT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr START_CHATS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='START_CHATS']"
			[Register ("START_CHATS")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key StartChats {
				get {
					if (START_CHATS_jfieldId == IntPtr.Zero)
						START_CHATS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "START_CHATS", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, START_CHATS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUCCESS_DIALOG_HEADER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='SUCCESS_DIALOG_HEADER']"
			[Register ("SUCCESS_DIALOG_HEADER")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key SuccessDialogHeader {
				get {
					if (SUCCESS_DIALOG_HEADER_jfieldId == IntPtr.Zero)
						SUCCESS_DIALOG_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS_DIALOG_HEADER", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_DIALOG_HEADER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SWIPE_HINT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='SWIPE_HINT']"
			[Register ("SWIPE_HINT")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key SwipeHint {
				get {
					if (SWIPE_HINT_jfieldId == IntPtr.Zero)
						SWIPE_HINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SWIPE_HINT", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SWIPE_HINT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_PLAYER_TITLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='VIDEO_PLAYER_TITLE']"
			[Register ("VIDEO_PLAYER_TITLE")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key VideoPlayerTitle {
				get {
					if (VIDEO_PLAYER_TITLE_jfieldId == IntPtr.Zero)
						VIDEO_PLAYER_TITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_PLAYER_TITLE", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_PLAYER_TITLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD']"
			[Register ("VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key VoiceMessagePressAndHoldToRecord {
				get {
					if (VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD_jfieldId == IntPtr.Zero)
						VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VOICE_MESSAGE_RELEASE_TO_ATTACH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/field[@name='VOICE_MESSAGE_RELEASE_TO_ATTACH']"
			[Register ("VOICE_MESSAGE_RELEASE_TO_ATTACH")]
			public static global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key VoiceMessageReleaseToAttach {
				get {
					if (VOICE_MESSAGE_RELEASE_TO_ATTACH_jfieldId == IntPtr.Zero)
						VOICE_MESSAGE_RELEASE_TO_ATTACH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOICE_MESSAGE_RELEASE_TO_ATTACH", "Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOICE_MESSAGE_RELEASE_TO_ATTACH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/instabug/library/IBGCustomTextPlaceHolder$Key", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Key); }
			}

			internal Key (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;", "")]
			public static unsafe global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder.Key']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;", "")]
			public static unsafe global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;");
				try {
					return (global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/IBGCustomTextPlaceHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBGCustomTextPlaceHolder); }
		}

		protected IBGCustomTextPlaceHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder']/constructor[@name='IBGCustomTextPlaceHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IBGCustomTextPlaceHolder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IBGCustomTextPlaceHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getConvertedHashMap;
#pragma warning disable 0169
		static Delegate GetGetConvertedHashMapHandler ()
		{
			if (cb_getConvertedHashMap == null)
				cb_getConvertedHashMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConvertedHashMap);
			return cb_getConvertedHashMap;
		}

		static IntPtr n_GetConvertedHashMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.IBGCustomTextPlaceHolder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key, string>.ToLocalJniHandle (__this.ConvertedHashMap);
		}
#pragma warning restore 0169

		static IntPtr id_getConvertedHashMap;
		protected virtual unsafe global::System.Collections.Generic.IDictionary<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key, string> ConvertedHashMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder']/method[@name='getConvertedHashMap' and count(parameter)=0]"
			[Register ("getConvertedHashMap", "()Ljava/util/HashMap;", "GetGetConvertedHashMapHandler")]
			get {
				if (id_getConvertedHashMap == IntPtr.Zero)
					id_getConvertedHashMap = JNIEnv.GetMethodID (class_ref, "getConvertedHashMap", "()Ljava/util/HashMap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConvertedHashMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConvertedHashMap", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_get_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_;
#pragma warning disable 0169
		static Delegate GetGet_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Handler ()
		{
			if (cb_get_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_ == null)
				cb_get_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_);
			return cb_get_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_;
		}

		static IntPtr n_Get_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.IBGCustomTextPlaceHolder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.instabug.library.IBGCustomTextPlaceHolder.Key']]"
		[Register ("get", "(Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;)Ljava/lang/String;", "GetGet_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Handler")]
		public virtual unsafe string Get (global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key p0)
		{
			if (id_get_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_ == IntPtr.Zero)
				id_get_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_ = JNIEnv.GetMethodID (class_ref, "get", "(Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_set_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_Handler ()
		{
			if (cb_set_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_ == null)
				cb_set_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_);
			return cb_set_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_;
		}

		static void n_Set_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Instabug.Library.IBGCustomTextPlaceHolder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGCustomTextPlaceHolder']/method[@name='set' and count(parameter)=2 and parameter[1][@type='com.instabug.library.IBGCustomTextPlaceHolder.Key'] and parameter[2][@type='java.lang.String']]"
		[Register ("set", "(Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;Ljava/lang/String;)V", "GetSet_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_Handler")]
		public virtual unsafe void Set (global::Com.Instabug.Library.IBGCustomTextPlaceHolder.Key p0, string p1)
		{
			if (id_set_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_ == IntPtr.Zero)
				id_set_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Lcom_instabug_library_IBGCustomTextPlaceHolder_Key_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Lcom/instabug/library/IBGCustomTextPlaceHolder$Key;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
