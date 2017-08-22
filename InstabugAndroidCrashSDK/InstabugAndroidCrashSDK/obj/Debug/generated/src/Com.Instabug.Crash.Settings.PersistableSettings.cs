using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Crash.Settings {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.crash.settings']/class[@name='PersistableSettings']"
	[global::Android.Runtime.Register ("com/instabug/crash/settings/PersistableSettings", DoNotGenerateAcw=true)]
	public partial class PersistableSettings : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/crash/settings/PersistableSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersistableSettings); }
		}

		protected PersistableSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Crash.Settings.PersistableSettings Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.crash.settings']/class[@name='PersistableSettings']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/crash/settings/PersistableSettings;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/crash/settings/PersistableSettings;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Crash.Settings.PersistableSettings> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLastCrashTime;
#pragma warning disable 0169
		static Delegate GetGetLastCrashTimeHandler ()
		{
			if (cb_getLastCrashTime == null)
				cb_getLastCrashTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastCrashTime);
			return cb_getLastCrashTime;
		}

		static long n_GetLastCrashTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Crash.Settings.PersistableSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Crash.Settings.PersistableSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastCrashTime;
		}
#pragma warning restore 0169

		static Delegate cb_setLastCrashTime_J;
#pragma warning disable 0169
		static Delegate GetSetLastCrashTime_JHandler ()
		{
			if (cb_setLastCrashTime_J == null)
				cb_setLastCrashTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLastCrashTime_J);
			return cb_setLastCrashTime_J;
		}

		static void n_SetLastCrashTime_J (IntPtr jnienv, IntPtr native__this, long time)
		{
			global::Com.Instabug.Crash.Settings.PersistableSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Crash.Settings.PersistableSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastCrashTime = time;
		}
#pragma warning restore 0169

		static IntPtr id_getLastCrashTime;
		static IntPtr id_setLastCrashTime_J;
		public virtual unsafe long LastCrashTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.crash.settings']/class[@name='PersistableSettings']/method[@name='getLastCrashTime' and count(parameter)=0]"
			[Register ("getLastCrashTime", "()J", "GetGetLastCrashTimeHandler")]
			get {
				if (id_getLastCrashTime == IntPtr.Zero)
					id_getLastCrashTime = JNIEnv.GetMethodID (class_ref, "getLastCrashTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastCrashTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastCrashTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.crash.settings']/class[@name='PersistableSettings']/method[@name='setLastCrashTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLastCrashTime", "(J)V", "GetSetLastCrashTime_JHandler")]
			set {
				if (id_setLastCrashTime_J == IntPtr.Zero)
					id_setLastCrashTime_J = JNIEnv.GetMethodID (class_ref, "setLastCrashTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastCrashTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastCrashTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.crash.settings']/class[@name='PersistableSettings']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context context)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
