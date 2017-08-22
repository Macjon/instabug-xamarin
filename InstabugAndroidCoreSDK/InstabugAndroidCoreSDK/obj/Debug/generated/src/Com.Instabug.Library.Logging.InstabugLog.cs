using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']"
	[global::Android.Runtime.Register ("com/instabug/library/logging/InstabugLog", DoNotGenerateAcw=true)]
	public partial class InstabugLog : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/field[@name='LOG_MESSAGE_DATE_FORMAT']"
		[Register ("LOG_MESSAGE_DATE_FORMAT")]
		public const string LogMessageDateFormat = (string) "MM-dd HH:mm:ss.SSS";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/logging/InstabugLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugLog); }
		}

		protected InstabugLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/constructor[@name='InstabugLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugLog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InstabugLog)) {
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

		static IntPtr id_getLogs;
		public static unsafe string Logs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/method[@name='getLogs' and count(parameter)=0]"
			[Register ("getLogs", "()Ljava/lang/String;", "GetGetLogsHandler")]
			get {
				if (id_getLogs == IntPtr.Zero)
					id_getLogs = JNIEnv.GetStaticMethodID (class_ref, "getLogs", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLogs), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_clearLogs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/method[@name='clearLogs' and count(parameter)=0]"
		[Register ("clearLogs", "()V", "")]
		public static unsafe void ClearLogs ()
		{
			if (id_clearLogs == IntPtr.Zero)
				id_clearLogs = JNIEnv.GetStaticMethodID (class_ref, "clearLogs", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearLogs);
			} finally {
			}
		}

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)V", "")]
		public static unsafe void D (string p0)
		{
			if (id_d_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_e_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "")]
		public static unsafe void E (string p0)
		{
			if (id_e_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getLogs_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/method[@name='getLogs' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("getLogs", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetLogs (global::Android.Content.Context p0)
		{
			if (id_getLogs_Landroid_content_Context_ == IntPtr.Zero)
				id_getLogs_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLogs", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLogs_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_i_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;)V", "")]
		public static unsafe void I (string p0)
		{
			if (id_i_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_trimLogs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/method[@name='trimLogs' and count(parameter)=0]"
		[Register ("trimLogs", "()V", "")]
		public static unsafe void TrimLogs ()
		{
			if (id_trimLogs == IntPtr.Zero)
				id_trimLogs = JNIEnv.GetStaticMethodID (class_ref, "trimLogs", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_trimLogs);
			} finally {
			}
		}

		static IntPtr id_v_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;)V", "")]
		public static unsafe void V (string p0)
		{
			if (id_v_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_w_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;)V", "")]
		public static unsafe void W (string p0)
		{
			if (id_w_Ljava_lang_String_ == IntPtr.Zero)
				id_w_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_wtf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugLog']/method[@name='wtf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("wtf", "(Ljava/lang/String;)V", "")]
		public static unsafe void Wtf (string p0)
		{
			if (id_wtf_Ljava_lang_String_ == IntPtr.Zero)
				id_wtf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
