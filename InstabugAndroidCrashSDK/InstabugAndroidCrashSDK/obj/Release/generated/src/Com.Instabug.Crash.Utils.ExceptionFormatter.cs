using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Crash.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.crash.utils']/class[@name='ExceptionFormatter']"
	[global::Android.Runtime.Register ("com/instabug/crash/utils/ExceptionFormatter", DoNotGenerateAcw=true)]
	public partial class ExceptionFormatter : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/crash/utils/ExceptionFormatter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExceptionFormatter); }
		}

		protected ExceptionFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.crash.utils']/class[@name='ExceptionFormatter']/constructor[@name='ExceptionFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExceptionFormatter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ExceptionFormatter)) {
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

		static IntPtr id_createExceptionJson_Ljava_lang_Throwable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.crash.utils']/class[@name='ExceptionFormatter']/method[@name='createExceptionJson' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String']]"
		[Register ("createExceptionJson", "(Ljava/lang/Throwable;Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject CreateExceptionJson (global::Java.Lang.Throwable throwable, string identifier)
		{
			if (id_createExceptionJson_Ljava_lang_Throwable_Ljava_lang_String_ == IntPtr.Zero)
				id_createExceptionJson_Ljava_lang_Throwable_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createExceptionJson", "(Ljava/lang/Throwable;Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_identifier = JNIEnv.NewString (identifier);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (throwable);
				__args [1] = new JValue (native_identifier);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createExceptionJson_Ljava_lang_Throwable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
			}
		}

		static IntPtr id_throwableStackTrace_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.crash.utils']/class[@name='ExceptionFormatter']/method[@name='throwableStackTrace' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("throwableStackTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;", "")]
		public static unsafe string ThrowableStackTrace (global::Java.Lang.Throwable throwable)
		{
			if (id_throwableStackTrace_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_throwableStackTrace_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "throwableStackTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_throwableStackTrace_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
