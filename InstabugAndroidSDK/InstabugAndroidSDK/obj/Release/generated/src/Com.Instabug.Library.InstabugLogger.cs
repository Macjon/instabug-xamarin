using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugLogger']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugLogger", DoNotGenerateAcw=true)]
	public partial class InstabugLogger : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugLogger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugLogger); }
		}

		protected InstabugLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstabugLog;
		public static unsafe string InstabugLog {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugLogger']/method[@name='getInstabugLog' and count(parameter)=0]"
			[Register ("getInstabugLog", "()Ljava/lang/String;", "GetGetInstabugLogHandler")]
			get {
				if (id_getInstabugLog == IntPtr.Zero)
					id_getInstabugLog = JNIEnv.GetStaticMethodID (class_ref, "getInstabugLog", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstabugLog), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLog;
#pragma warning disable 0169
		static Delegate GetGetLogHandler ()
		{
			if (cb_getLog == null)
				cb_getLog = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLog);
			return cb_getLog;
		}

		static IntPtr n_GetLog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugLogger __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Log);
		}
#pragma warning restore 0169

		static IntPtr id_getLog;
		public virtual unsafe string Log {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugLogger']/method[@name='getLog' and count(parameter)=0]"
			[Register ("getLog", "()Ljava/lang/String;", "GetGetLogHandler")]
			get {
				if (id_getLog == IntPtr.Zero)
					id_getLog = JNIEnv.GetMethodID (class_ref, "getLog", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLog), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLog", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugLogger']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public static unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetStaticMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clear);
			} finally {
			}
		}

		static IntPtr id_log_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugLogger']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("log", "(Ljava/lang/String;)V", "")]
		public static unsafe void InvokeLog (string p0)
		{
			if (id_log_Ljava_lang_String_ == IntPtr.Zero)
				id_log_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
