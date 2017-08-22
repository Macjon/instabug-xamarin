using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugCustomTextPlaceHolder", DoNotGenerateAcw=true)]
	public partial class InstabugCustomTextPlaceHolder : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']"
		[global::Android.Runtime.Register ("com/instabug/library/InstabugCustomTextPlaceHolder$Key", DoNotGenerateAcw=true)]
		public sealed partial class Key : global::Java.Lang.Enum {


			static IntPtr ADD_EXTRA_SCREENSHOT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='ADD_EXTRA_SCREENSHOT']"
			[Register ("ADD_EXTRA_SCREENSHOT")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key AddExtraScreenshot {
				get {
					if (ADD_EXTRA_SCREENSHOT_jfieldId == IntPtr.Zero)
						ADD_EXTRA_SCREENSHOT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADD_EXTRA_SCREENSHOT", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADD_EXTRA_SCREENSHOT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ADD_IMAGE_FROM_GALLERY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='ADD_IMAGE_FROM_GALLERY']"
			[Register ("ADD_IMAGE_FROM_GALLERY")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key AddImageFromGallery {
				get {
					if (ADD_IMAGE_FROM_GALLERY_jfieldId == IntPtr.Zero)
						ADD_IMAGE_FROM_GALLERY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADD_IMAGE_FROM_GALLERY", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADD_IMAGE_FROM_GALLERY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ADD_VIDEO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='ADD_VIDEO']"
			[Register ("ADD_VIDEO")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key AddVideo {
				get {
					if (ADD_VIDEO_jfieldId == IntPtr.Zero)
						ADD_VIDEO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADD_VIDEO", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADD_VIDEO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ADD_VOICE_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='ADD_VOICE_MESSAGE']"
			[Register ("ADD_VOICE_MESSAGE")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key AddVoiceMessage {
				get {
					if (ADD_VOICE_MESSAGE_jfieldId == IntPtr.Zero)
						ADD_VOICE_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADD_VOICE_MESSAGE", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADD_VOICE_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUDIO_RECORDING_PERMISSION_DENIED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='AUDIO_RECORDING_PERMISSION_DENIED']"
			[Register ("AUDIO_RECORDING_PERMISSION_DENIED")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key AudioRecordingPermissionDenied {
				get {
					if (AUDIO_RECORDING_PERMISSION_DENIED_jfieldId == IntPtr.Zero)
						AUDIO_RECORDING_PERMISSION_DENIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_RECORDING_PERMISSION_DENIED", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_RECORDING_PERMISSION_DENIED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BUG_REPORT_HEADER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='BUG_REPORT_HEADER']"
			[Register ("BUG_REPORT_HEADER")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key BugReportHeader {
				get {
					if (BUG_REPORT_HEADER_jfieldId == IntPtr.Zero)
						BUG_REPORT_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUG_REPORT_HEADER", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUG_REPORT_HEADER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMMENT_FIELD_HINT_FOR_BUG_REPORT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='COMMENT_FIELD_HINT_FOR_BUG_REPORT']"
			[Register ("COMMENT_FIELD_HINT_FOR_BUG_REPORT")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key CommentFieldHintForBugReport {
				get {
					if (COMMENT_FIELD_HINT_FOR_BUG_REPORT_jfieldId == IntPtr.Zero)
						COMMENT_FIELD_HINT_FOR_BUG_REPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMMENT_FIELD_HINT_FOR_BUG_REPORT", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMMENT_FIELD_HINT_FOR_BUG_REPORT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMMENT_FIELD_HINT_FOR_FEEDBACK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='COMMENT_FIELD_HINT_FOR_FEEDBACK']"
			[Register ("COMMENT_FIELD_HINT_FOR_FEEDBACK")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key CommentFieldHintForFeedback {
				get {
					if (COMMENT_FIELD_HINT_FOR_FEEDBACK_jfieldId == IntPtr.Zero)
						COMMENT_FIELD_HINT_FOR_FEEDBACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMMENT_FIELD_HINT_FOR_FEEDBACK", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMMENT_FIELD_HINT_FOR_FEEDBACK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONVERSATIONS_LIST_TITLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='CONVERSATIONS_LIST_TITLE']"
			[Register ("CONVERSATIONS_LIST_TITLE")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key ConversationsListTitle {
				get {
					if (CONVERSATIONS_LIST_TITLE_jfieldId == IntPtr.Zero)
						CONVERSATIONS_LIST_TITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATIONS_LIST_TITLE", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATIONS_LIST_TITLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONVERSATION_TEXT_FIELD_HINT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='CONVERSATION_TEXT_FIELD_HINT']"
			[Register ("CONVERSATION_TEXT_FIELD_HINT")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key ConversationTextFieldHint {
				get {
					if (CONVERSATION_TEXT_FIELD_HINT_jfieldId == IntPtr.Zero)
						CONVERSATION_TEXT_FIELD_HINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION_TEXT_FIELD_HINT", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATION_TEXT_FIELD_HINT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EMAIL_FIELD_HINT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='EMAIL_FIELD_HINT']"
			[Register ("EMAIL_FIELD_HINT")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key EmailFieldHint {
				get {
					if (EMAIL_FIELD_HINT_jfieldId == IntPtr.Zero)
						EMAIL_FIELD_HINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMAIL_FIELD_HINT", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMAIL_FIELD_HINT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FEEDBACK_REPORT_HEADER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='FEEDBACK_REPORT_HEADER']"
			[Register ("FEEDBACK_REPORT_HEADER")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key FeedbackReportHeader {
				get {
					if (FEEDBACK_REPORT_HEADER_jfieldId == IntPtr.Zero)
						FEEDBACK_REPORT_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FEEDBACK_REPORT_HEADER", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FEEDBACK_REPORT_HEADER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INVALID_COMMENT_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='INVALID_COMMENT_MESSAGE']"
			[Register ("INVALID_COMMENT_MESSAGE")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key InvalidCommentMessage {
				get {
					if (INVALID_COMMENT_MESSAGE_jfieldId == IntPtr.Zero)
						INVALID_COMMENT_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_COMMENT_MESSAGE", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_COMMENT_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INVALID_EMAIL_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='INVALID_EMAIL_MESSAGE']"
			[Register ("INVALID_EMAIL_MESSAGE")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key InvalidEmailMessage {
				get {
					if (INVALID_EMAIL_MESSAGE_jfieldId == IntPtr.Zero)
						INVALID_EMAIL_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_EMAIL_MESSAGE", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_EMAIL_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INVOCATION_HEADER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='INVOCATION_HEADER']"
			[Register ("INVOCATION_HEADER")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key InvocationHeader {
				get {
					if (INVOCATION_HEADER_jfieldId == IntPtr.Zero)
						INVOCATION_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVOCATION_HEADER", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVOCATION_HEADER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REPORT_BUG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='REPORT_BUG']"
			[Register ("REPORT_BUG")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key ReportBug {
				get {
					if (REPORT_BUG_jfieldId == IntPtr.Zero)
						REPORT_BUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPORT_BUG", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPORT_BUG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REPORT_FEEDBACK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='REPORT_FEEDBACK']"
			[Register ("REPORT_FEEDBACK")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key ReportFeedback {
				get {
					if (REPORT_FEEDBACK_jfieldId == IntPtr.Zero)
						REPORT_FEEDBACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPORT_FEEDBACK", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPORT_FEEDBACK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REPORT_SUCCESSFULLY_SENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='REPORT_SUCCESSFULLY_SENT']"
			[Register ("REPORT_SUCCESSFULLY_SENT")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key ReportSuccessfullySent {
				get {
					if (REPORT_SUCCESSFULLY_SENT_jfieldId == IntPtr.Zero)
						REPORT_SUCCESSFULLY_SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPORT_SUCCESSFULLY_SENT", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPORT_SUCCESSFULLY_SENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SHAKE_HINT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='SHAKE_HINT']"
			[Register ("SHAKE_HINT")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key ShakeHint {
				get {
					if (SHAKE_HINT_jfieldId == IntPtr.Zero)
						SHAKE_HINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHAKE_HINT", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHAKE_HINT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr START_CHATS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='START_CHATS']"
			[Register ("START_CHATS")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key StartChats {
				get {
					if (START_CHATS_jfieldId == IntPtr.Zero)
						START_CHATS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "START_CHATS", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, START_CHATS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUCCESS_DIALOG_HEADER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='SUCCESS_DIALOG_HEADER']"
			[Register ("SUCCESS_DIALOG_HEADER")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key SuccessDialogHeader {
				get {
					if (SUCCESS_DIALOG_HEADER_jfieldId == IntPtr.Zero)
						SUCCESS_DIALOG_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS_DIALOG_HEADER", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_DIALOG_HEADER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SWIPE_HINT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='SWIPE_HINT']"
			[Register ("SWIPE_HINT")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key SwipeHint {
				get {
					if (SWIPE_HINT_jfieldId == IntPtr.Zero)
						SWIPE_HINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SWIPE_HINT", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SWIPE_HINT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_PLAYER_TITLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='VIDEO_PLAYER_TITLE']"
			[Register ("VIDEO_PLAYER_TITLE")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key VideoPlayerTitle {
				get {
					if (VIDEO_PLAYER_TITLE_jfieldId == IntPtr.Zero)
						VIDEO_PLAYER_TITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_PLAYER_TITLE", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_PLAYER_TITLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD']"
			[Register ("VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key VoiceMessagePressAndHoldToRecord {
				get {
					if (VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD_jfieldId == IntPtr.Zero)
						VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOICE_MESSAGE_PRESS_AND_HOLD_TO_RECORD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VOICE_MESSAGE_RELEASE_TO_ATTACH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/field[@name='VOICE_MESSAGE_RELEASE_TO_ATTACH']"
			[Register ("VOICE_MESSAGE_RELEASE_TO_ATTACH")]
			public static global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key VoiceMessageReleaseToAttach {
				get {
					if (VOICE_MESSAGE_RELEASE_TO_ATTACH_jfieldId == IntPtr.Zero)
						VOICE_MESSAGE_RELEASE_TO_ATTACH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOICE_MESSAGE_RELEASE_TO_ATTACH", "Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOICE_MESSAGE_RELEASE_TO_ATTACH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/instabug/library/InstabugCustomTextPlaceHolder$Key", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;", "")]
			public static unsafe global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder.Key']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;", "")]
			public static unsafe global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;");
				try {
					return (global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugCustomTextPlaceHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugCustomTextPlaceHolder); }
		}

		protected InstabugCustomTextPlaceHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder']/constructor[@name='InstabugCustomTextPlaceHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugCustomTextPlaceHolder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InstabugCustomTextPlaceHolder)) {
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

		static Delegate cb_get_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_;
#pragma warning disable 0169
		static Delegate GetGet_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Handler ()
		{
			if (cb_get_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_ == null)
				cb_get_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_);
			return cb_get_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_;
		}

		static IntPtr n_Get_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugCustomTextPlaceHolder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.instabug.library.InstabugCustomTextPlaceHolder.Key']]"
		[Register ("get", "(Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;)Ljava/lang/String;", "GetGet_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Handler")]
		public virtual unsafe string Get (global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key p0)
		{
			if (id_get_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_ == IntPtr.Zero)
				id_get_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_ = JNIEnv.GetMethodID (class_ref, "get", "(Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_set_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_Handler ()
		{
			if (cb_set_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_ == null)
				cb_set_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_);
			return cb_set_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_;
		}

		static void n_Set_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Instabug.Library.InstabugCustomTextPlaceHolder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder']/method[@name='set' and count(parameter)=2 and parameter[1][@type='com.instabug.library.InstabugCustomTextPlaceHolder.Key'] and parameter[2][@type='java.lang.String']]"
		[Register ("set", "(Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;Ljava/lang/String;)V", "GetSet_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_Handler")]
		public virtual unsafe void Set (global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key p0, string p1)
		{
			if (id_set_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_ == IntPtr.Zero)
				id_set_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Lcom_instabug_library_InstabugCustomTextPlaceHolder_Key_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Lcom/instabug/library/InstabugCustomTextPlaceHolder$Key;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setPlaceHoldersMap_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetSetPlaceHoldersMap_Ljava_util_HashMap_Handler ()
		{
			if (cb_setPlaceHoldersMap_Ljava_util_HashMap_ == null)
				cb_setPlaceHoldersMap_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaceHoldersMap_Ljava_util_HashMap_);
			return cb_setPlaceHoldersMap_Ljava_util_HashMap_;
		}

		static void n_SetPlaceHoldersMap_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugCustomTextPlaceHolder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaceHoldersMap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPlaceHoldersMap_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugCustomTextPlaceHolder']/method[@name='setPlaceHoldersMap' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;com.instabug.library.InstabugCustomTextPlaceHolder.Key, java.lang.String&gt;']]"
		[Register ("setPlaceHoldersMap", "(Ljava/util/HashMap;)V", "GetSetPlaceHoldersMap_Ljava_util_HashMap_Handler")]
		public virtual unsafe void SetPlaceHoldersMap (global::System.Collections.Generic.IDictionary<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key, string> p0)
		{
			if (id_setPlaceHoldersMap_Ljava_util_HashMap_ == IntPtr.Zero)
				id_setPlaceHoldersMap_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "setPlaceHoldersMap", "(Ljava/util/HashMap;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Com.Instabug.Library.InstabugCustomTextPlaceHolder.Key, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlaceHoldersMap_Ljava_util_HashMap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlaceHoldersMap", "(Ljava/util/HashMap;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
