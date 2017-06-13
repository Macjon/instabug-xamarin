using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugNetworkLog']"
	[global::Android.Runtime.Register ("com/instabug/library/logging/InstabugNetworkLog", DoNotGenerateAcw=true)]
	public partial class InstabugNetworkLog : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/logging/InstabugNetworkLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugNetworkLog); }
		}

		protected InstabugNetworkLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugNetworkLog']/constructor[@name='InstabugNetworkLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugNetworkLog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InstabugNetworkLog)) {
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

		static Delegate cb_Log_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_Log_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_Log_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Log_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_);
			return cb_Log_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Log_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Instabug.Library.Logging.InstabugNetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Logging.InstabugNetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.HttpURLConnection p0 = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_Log_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.logging']/class[@name='InstabugNetworkLog']/method[@name='Log' and count(parameter)=3 and parameter[1][@type='java.net.HttpURLConnection'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("Log", "(Ljava/net/HttpURLConnection;Ljava/lang/String;Ljava/lang/String;)V", "GetLog_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Log (global::Java.Net.HttpURLConnection p0, string p1, string p2)
		{
			if (id_Log_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Log_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Log", "(Ljava/net/HttpURLConnection;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Log_Ljava_net_HttpURLConnection_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Log", "(Ljava/net/HttpURLConnection;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
