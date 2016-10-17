using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugFeedbackActivityLauncher", DoNotGenerateAcw=true)]
	public partial class InstabugFeedbackActivityLauncher : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='EXTRA_CHAT_NUMBER']"
		[Register ("EXTRA_CHAT_NUMBER")]
		public const string ExtraChatNumber = (string) "com.instabug.library.number";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='EXTRA_CHAT_SENDER_NAME']"
		[Register ("EXTRA_CHAT_SENDER_NAME")]
		public const string ExtraChatSenderName = (string) "com.instabug.library.chat.sender.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='EXTRA_HANGING_BUG']"
		[Register ("EXTRA_HANGING_BUG")]
		public const string ExtraHangingBug = (string) "com.instabug.library.hanging.bug";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='EXTRA_IMAGE']"
		[Register ("EXTRA_IMAGE")]
		public const string ExtraImage = (string) "com.instabug.library.image";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='EXTRA_PROCESS']"
		[Register ("EXTRA_PROCESS")]
		public const string ExtraProcess = (string) "com.instabug.library.process";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='EXTRA_TYPE']"
		[Register ("EXTRA_TYPE")]
		public const string ExtraType = (string) "com.instabug.library.model.Attachment.Type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='PROCESS_BUG']"
		[Register ("PROCESS_BUG")]
		public const int ProcessBug = (int) 162;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='PROCESS_CHAT']"
		[Register ("PROCESS_CHAT")]
		public const int ProcessChat = (int) 163;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='PROCESS_CHATS_LIST']"
		[Register ("PROCESS_CHATS_LIST")]
		public const int ProcessChatsList = (int) 164;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='PROCESS_FEEDBACK']"
		[Register ("PROCESS_FEEDBACK")]
		public const int ProcessFeedback = (int) 161;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='PROCESS_GENERAL']"
		[Register ("PROCESS_GENERAL")]
		public const int ProcessGeneral = (int) 160;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='PROCESS_HANGING_BUG']"
		[Register ("PROCESS_HANGING_BUG")]
		public const int ProcessHangingBug = (int) 167;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='PROCESS_HANGING_CHAT']"
		[Register ("PROCESS_HANGING_CHAT")]
		public const int ProcessHangingChat = (int) 165;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='PROCESS_KILL']"
		[Register ("PROCESS_KILL")]
		public const int ProcessKill = (int) 168;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/field[@name='PROCESS_TRIGGERING_CHAT']"
		[Register ("PROCESS_TRIGGERING_CHAT")]
		public const int ProcessTriggeringChat = (int) 166;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugFeedbackActivityLauncher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugFeedbackActivityLauncher); }
		}

		protected InstabugFeedbackActivityLauncher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/constructor[@name='InstabugFeedbackActivityLauncher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugFeedbackActivityLauncher ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InstabugFeedbackActivityLauncher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		static IntPtr id_killActivity_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/method[@name='killActivity' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("killActivity", "(Landroid/content/Context;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent KillActivity (global::Android.Content.Context p0)
		{
			if (id_killActivity_Landroid_content_Context_ == IntPtr.Zero)
				id_killActivity_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "killActivity", "(Landroid/content/Context;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_killActivity_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newBugProcessIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/method[@name='newBugProcessIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("newBugProcessIntent", "(Landroid/content/Context;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent NewBugProcessIntent (global::Android.Content.Context p0)
		{
			if (id_newBugProcessIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_newBugProcessIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "newBugProcessIntent", "(Landroid/content/Context;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBugProcessIntent_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newBugProcessIntent_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/method[@name='newBugProcessIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("newBugProcessIntent", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent NewBugProcessIntent (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_newBugProcessIntent_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_newBugProcessIntent_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "newBugProcessIntent", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newBugProcessIntent_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newChatListProcessIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/method[@name='newChatListProcessIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("newChatListProcessIntent", "(Landroid/content/Context;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent NewChatListProcessIntent (global::Android.Content.Context p0)
		{
			if (id_newChatListProcessIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_newChatListProcessIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "newChatListProcessIntent", "(Landroid/content/Context;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newChatListProcessIntent_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newChatProcessIntent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/method[@name='newChatProcessIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("newChatProcessIntent", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent NewChatProcessIntent (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_newChatProcessIntent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_newChatProcessIntent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newChatProcessIntent", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newChatProcessIntent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_newFeedbackProcessIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/method[@name='newFeedbackProcessIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("newFeedbackProcessIntent", "(Landroid/content/Context;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent NewFeedbackProcessIntent (global::Android.Content.Context p0)
		{
			if (id_newFeedbackProcessIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_newFeedbackProcessIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "newFeedbackProcessIntent", "(Landroid/content/Context;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newFeedbackProcessIntent_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newFeedbackProcessIntent_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/method[@name='newFeedbackProcessIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("newFeedbackProcessIntent", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent NewFeedbackProcessIntent (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_newFeedbackProcessIntent_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_newFeedbackProcessIntent_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "newFeedbackProcessIntent", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newFeedbackProcessIntent_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newGeneralProcessIntent_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/method[@name='newGeneralProcessIntent' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("newGeneralProcessIntent", "(Landroid/app/Activity;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent NewGeneralProcessIntent (global::Android.App.Activity p0)
		{
			if (id_newGeneralProcessIntent_Landroid_app_Activity_ == IntPtr.Zero)
				id_newGeneralProcessIntent_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "newGeneralProcessIntent", "(Landroid/app/Activity;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newGeneralProcessIntent_Landroid_app_Activity_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newGeneralProcessIntent_Landroid_app_Activity_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/method[@name='newGeneralProcessIntent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.net.Uri']]"
		[Register ("newGeneralProcessIntent", "(Landroid/app/Activity;Landroid/net/Uri;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent NewGeneralProcessIntent (global::Android.App.Activity p0, global::Android.Net.Uri p1)
		{
			if (id_newGeneralProcessIntent_Landroid_app_Activity_Landroid_net_Uri_ == IntPtr.Zero)
				id_newGeneralProcessIntent_Landroid_app_Activity_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "newGeneralProcessIntent", "(Landroid/app/Activity;Landroid/net/Uri;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newGeneralProcessIntent_Landroid_app_Activity_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newTrigerringChatProcessIntent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackActivityLauncher']/method[@name='newTrigerringChatProcessIntent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("newTrigerringChatProcessIntent", "(Landroid/content/Context;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent NewTrigerringChatProcessIntent (global::Android.Content.Context p0)
		{
			if (id_newTrigerringChatProcessIntent_Landroid_content_Context_ == IntPtr.Zero)
				id_newTrigerringChatProcessIntent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "newTrigerringChatProcessIntent", "(Landroid/content/Context;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newTrigerringChatProcessIntent_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
