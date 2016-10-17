using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='SessionManager']"
	[global::Android.Runtime.Register ("com/instabug/library/SessionManager", DoNotGenerateAcw=true)]
	public partial class SessionManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/SessionManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionManager); }
		}

		protected SessionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCurrentSessionTimeUntilNow;
#pragma warning disable 0169
		static Delegate GetGetCurrentSessionTimeUntilNowHandler ()
		{
			if (cb_getCurrentSessionTimeUntilNow == null)
				cb_getCurrentSessionTimeUntilNow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurrentSessionTimeUntilNow);
			return cb_getCurrentSessionTimeUntilNow;
		}

		static long n_GetCurrentSessionTimeUntilNow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.SessionManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentSessionTimeUntilNow;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentSessionTimeUntilNow;
		public virtual unsafe long CurrentSessionTimeUntilNow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='SessionManager']/method[@name='getCurrentSessionTimeUntilNow' and count(parameter)=0]"
			[Register ("getCurrentSessionTimeUntilNow", "()J", "GetGetCurrentSessionTimeUntilNowHandler")]
			get {
				if (id_getCurrentSessionTimeUntilNow == IntPtr.Zero)
					id_getCurrentSessionTimeUntilNow = JNIEnv.GetMethodID (class_ref, "getCurrentSessionTimeUntilNow", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentSessionTimeUntilNow);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentSessionTimeUntilNow", "()J"));
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Library.SessionManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='SessionManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/library/SessionManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/library/SessionManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.SessionManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
