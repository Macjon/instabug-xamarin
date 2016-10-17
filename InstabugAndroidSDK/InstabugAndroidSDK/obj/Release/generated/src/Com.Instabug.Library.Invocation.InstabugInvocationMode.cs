using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Invocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationMode']"
	[global::Android.Runtime.Register ("com/instabug/library/invocation/InstabugInvocationMode", DoNotGenerateAcw=true)]
	public sealed partial class InstabugInvocationMode : global::Java.Lang.Enum {


		static IntPtr CHATS_LIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationMode']/field[@name='CHATS_LIST']"
		[Register ("CHATS_LIST")]
		public static global::Com.Instabug.Library.Invocation.InstabugInvocationMode ChatsList {
			get {
				if (CHATS_LIST_jfieldId == IntPtr.Zero)
					CHATS_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHATS_LIST", "Lcom/instabug/library/invocation/InstabugInvocationMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHATS_LIST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NEW_BUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationMode']/field[@name='NEW_BUG']"
		[Register ("NEW_BUG")]
		public static global::Com.Instabug.Library.Invocation.InstabugInvocationMode NewBug {
			get {
				if (NEW_BUG_jfieldId == IntPtr.Zero)
					NEW_BUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEW_BUG", "Lcom/instabug/library/invocation/InstabugInvocationMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEW_BUG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NEW_CHAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationMode']/field[@name='NEW_CHAT']"
		[Register ("NEW_CHAT")]
		public static global::Com.Instabug.Library.Invocation.InstabugInvocationMode NewChat {
			get {
				if (NEW_CHAT_jfieldId == IntPtr.Zero)
					NEW_CHAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEW_CHAT", "Lcom/instabug/library/invocation/InstabugInvocationMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEW_CHAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NEW_FEEDBACK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationMode']/field[@name='NEW_FEEDBACK']"
		[Register ("NEW_FEEDBACK")]
		public static global::Com.Instabug.Library.Invocation.InstabugInvocationMode NewFeedback {
			get {
				if (NEW_FEEDBACK_jfieldId == IntPtr.Zero)
					NEW_FEEDBACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEW_FEEDBACK", "Lcom/instabug/library/invocation/InstabugInvocationMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEW_FEEDBACK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PROMPT_OPTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationMode']/field[@name='PROMPT_OPTION']"
		[Register ("PROMPT_OPTION")]
		public static global::Com.Instabug.Library.Invocation.InstabugInvocationMode PromptOption {
			get {
				if (PROMPT_OPTION_jfieldId == IntPtr.Zero)
					PROMPT_OPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROMPT_OPTION", "Lcom/instabug/library/invocation/InstabugInvocationMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROMPT_OPTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/invocation/InstabugInvocationMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugInvocationMode); }
		}

		internal InstabugInvocationMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/invocation/InstabugInvocationMode;", "")]
		public static unsafe global::Com.Instabug.Library.Invocation.InstabugInvocationMode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/invocation/InstabugInvocationMode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.Invocation.InstabugInvocationMode __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/invocation/InstabugInvocationMode;", "")]
		public static unsafe global::Com.Instabug.Library.Invocation.InstabugInvocationMode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/invocation/InstabugInvocationMode;");
			try {
				return (global::Com.Instabug.Library.Invocation.InstabugInvocationMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.Invocation.InstabugInvocationMode));
			} finally {
			}
		}

	}
}
