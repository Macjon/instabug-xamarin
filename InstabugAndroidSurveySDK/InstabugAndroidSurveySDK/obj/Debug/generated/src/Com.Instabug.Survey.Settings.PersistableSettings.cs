using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Survey.Settings {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PersistableSettings']"
	[global::Android.Runtime.Register ("com/instabug/survey/settings/PersistableSettings", DoNotGenerateAcw=true)]
	public partial class PersistableSettings : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/survey/settings/PersistableSettings", ref java_class_handle);
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
		public static unsafe global::Com.Instabug.Survey.Settings.PersistableSettings Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PersistableSettings']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/survey/settings/PersistableSettings;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/survey/settings/PersistableSettings;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PersistableSettings> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLastFetchedAt;
#pragma warning disable 0169
		static Delegate GetGetLastFetchedAtHandler ()
		{
			if (cb_getLastFetchedAt == null)
				cb_getLastFetchedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastFetchedAt);
			return cb_getLastFetchedAt;
		}

		static long n_GetLastFetchedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Survey.Settings.PersistableSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PersistableSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastFetchedAt;
		}
#pragma warning restore 0169

		static Delegate cb_setLastFetchedAt_J;
#pragma warning disable 0169
		static Delegate GetSetLastFetchedAt_JHandler ()
		{
			if (cb_setLastFetchedAt_J == null)
				cb_setLastFetchedAt_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLastFetchedAt_J);
			return cb_setLastFetchedAt_J;
		}

		static void n_SetLastFetchedAt_J (IntPtr jnienv, IntPtr native__this, long time)
		{
			global::Com.Instabug.Survey.Settings.PersistableSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PersistableSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastFetchedAt = time;
		}
#pragma warning restore 0169

		static IntPtr id_getLastFetchedAt;
		static IntPtr id_setLastFetchedAt_J;
		public virtual unsafe long LastFetchedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PersistableSettings']/method[@name='getLastFetchedAt' and count(parameter)=0]"
			[Register ("getLastFetchedAt", "()J", "GetGetLastFetchedAtHandler")]
			get {
				if (id_getLastFetchedAt == IntPtr.Zero)
					id_getLastFetchedAt = JNIEnv.GetMethodID (class_ref, "getLastFetchedAt", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastFetchedAt);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastFetchedAt", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PersistableSettings']/method[@name='setLastFetchedAt' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLastFetchedAt", "(J)V", "GetSetLastFetchedAt_JHandler")]
			set {
				if (id_setLastFetchedAt_J == IntPtr.Zero)
					id_setLastFetchedAt_J = JNIEnv.GetMethodID (class_ref, "setLastFetchedAt", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastFetchedAt_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastFetchedAt", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastSurveyTime;
#pragma warning disable 0169
		static Delegate GetGetLastSurveyTimeHandler ()
		{
			if (cb_getLastSurveyTime == null)
				cb_getLastSurveyTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastSurveyTime);
			return cb_getLastSurveyTime;
		}

		static long n_GetLastSurveyTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Survey.Settings.PersistableSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PersistableSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastSurveyTime;
		}
#pragma warning restore 0169

		static Delegate cb_setLastSurveyTime_J;
#pragma warning disable 0169
		static Delegate GetSetLastSurveyTime_JHandler ()
		{
			if (cb_setLastSurveyTime_J == null)
				cb_setLastSurveyTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLastSurveyTime_J);
			return cb_setLastSurveyTime_J;
		}

		static void n_SetLastSurveyTime_J (IntPtr jnienv, IntPtr native__this, long time)
		{
			global::Com.Instabug.Survey.Settings.PersistableSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PersistableSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastSurveyTime = time;
		}
#pragma warning restore 0169

		static IntPtr id_getLastSurveyTime;
		static IntPtr id_setLastSurveyTime_J;
		public virtual unsafe long LastSurveyTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PersistableSettings']/method[@name='getLastSurveyTime' and count(parameter)=0]"
			[Register ("getLastSurveyTime", "()J", "GetGetLastSurveyTimeHandler")]
			get {
				if (id_getLastSurveyTime == IntPtr.Zero)
					id_getLastSurveyTime = JNIEnv.GetMethodID (class_ref, "getLastSurveyTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastSurveyTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastSurveyTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PersistableSettings']/method[@name='setLastSurveyTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLastSurveyTime", "(J)V", "GetSetLastSurveyTime_JHandler")]
			set {
				if (id_setLastSurveyTime_J == IntPtr.Zero)
					id_setLastSurveyTime_J = JNIEnv.GetMethodID (class_ref, "setLastSurveyTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastSurveyTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastSurveyTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PersistableSettings']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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
