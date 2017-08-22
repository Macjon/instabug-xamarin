using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Survey.Settings {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']"
	[global::Android.Runtime.Register ("com/instabug/survey/settings/SurveysSettings", DoNotGenerateAcw=true)]
	public partial class SurveysSettings : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/field[@name='CURRENT_VERSION']"
		[Register ("CURRENT_VERSION")]
		public const string CurrentVersion = (string) "2";

		static IntPtr DELAY_BEFORE_SHOWING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/field[@name='DELAY_BEFORE_SHOWING']"
		[Register ("DELAY_BEFORE_SHOWING")]
		public static long DelayBeforeShowing {
			get {
				if (DELAY_BEFORE_SHOWING_jfieldId == IntPtr.Zero)
					DELAY_BEFORE_SHOWING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELAY_BEFORE_SHOWING", "J");
				return JNIEnv.GetStaticLongField (class_ref, DELAY_BEFORE_SHOWING_jfieldId);
			}
			set {
				if (DELAY_BEFORE_SHOWING_jfieldId == IntPtr.Zero)
					DELAY_BEFORE_SHOWING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELAY_BEFORE_SHOWING", "J");
				try {
					JNIEnv.SetStaticField (class_ref, DELAY_BEFORE_SHOWING_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/survey/settings/SurveysSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SurveysSettings); }
		}

		protected SurveysSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/constructor[@name='SurveysSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SurveysSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SurveysSettings)) {
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

		static IntPtr id_getAfterShowingSurveyRunnable;
		static IntPtr id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_;
		public static unsafe global::Java.Lang.IRunnable AfterShowingSurveyRunnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/method[@name='getAfterShowingSurveyRunnable' and count(parameter)=0]"
			[Register ("getAfterShowingSurveyRunnable", "()Ljava/lang/Runnable;", "GetGetAfterShowingSurveyRunnableHandler")]
			get {
				if (id_getAfterShowingSurveyRunnable == IntPtr.Zero)
					id_getAfterShowingSurveyRunnable = JNIEnv.GetStaticMethodID (class_ref, "getAfterShowingSurveyRunnable", "()Ljava/lang/Runnable;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAfterShowingSurveyRunnable), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/method[@name='setAfterShowingSurveyRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("setAfterShowingSurveyRunnable", "(Ljava/lang/Runnable;)V", "GetSetAfterShowingSurveyRunnable_Ljava_lang_Runnable_Handler")]
			set {
				if (id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "setAfterShowingSurveyRunnable", "(Ljava/lang/Runnable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getLastFetchedAt;
		static IntPtr id_setLastFetchedAt_J;
		public static unsafe long LastFetchedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/method[@name='getLastFetchedAt' and count(parameter)=0]"
			[Register ("getLastFetchedAt", "()J", "GetGetLastFetchedAtHandler")]
			get {
				if (id_getLastFetchedAt == IntPtr.Zero)
					id_getLastFetchedAt = JNIEnv.GetStaticMethodID (class_ref, "getLastFetchedAt", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getLastFetchedAt);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/method[@name='setLastFetchedAt' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLastFetchedAt", "(J)V", "GetSetLastFetchedAt_JHandler")]
			set {
				if (id_setLastFetchedAt_J == IntPtr.Zero)
					id_setLastFetchedAt_J = JNIEnv.GetStaticMethodID (class_ref, "setLastFetchedAt", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setLastFetchedAt_J, __args);
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
			global::Com.Instabug.Survey.Settings.SurveysSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.SurveysSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Instabug.Survey.Settings.SurveysSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.SurveysSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastSurveyTime = time;
		}
#pragma warning restore 0169

		static IntPtr id_getLastSurveyTime;
		static IntPtr id_setLastSurveyTime_J;
		public virtual unsafe long LastSurveyTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/method[@name='getLastSurveyTime' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/method[@name='setLastSurveyTime' and count(parameter)=1 and parameter[1][@type='long']]"
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

		static IntPtr id_getPreShowingSurveyRunnable;
		static IntPtr id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_;
		public static unsafe global::Java.Lang.IRunnable PreShowingSurveyRunnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/method[@name='getPreShowingSurveyRunnable' and count(parameter)=0]"
			[Register ("getPreShowingSurveyRunnable", "()Ljava/lang/Runnable;", "GetGetPreShowingSurveyRunnableHandler")]
			get {
				if (id_getPreShowingSurveyRunnable == IntPtr.Zero)
					id_getPreShowingSurveyRunnable = JNIEnv.GetStaticMethodID (class_ref, "getPreShowingSurveyRunnable", "()Ljava/lang/Runnable;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPreShowingSurveyRunnable), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/method[@name='setPreShowingSurveyRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("setPreShowingSurveyRunnable", "(Ljava/lang/Runnable;)V", "GetSetPreShowingSurveyRunnable_Ljava_lang_Runnable_Handler")]
			set {
				if (id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "setPreShowingSurveyRunnable", "(Ljava/lang/Runnable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isSurveysAutoShowing;
		static IntPtr id_setSurveysAutoShowing_Z;
		public static unsafe bool SurveysAutoShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/method[@name='isSurveysAutoShowing' and count(parameter)=0]"
			[Register ("isSurveysAutoShowing", "()Z", "GetIsSurveysAutoShowingHandler")]
			get {
				if (id_isSurveysAutoShowing == IntPtr.Zero)
					id_isSurveysAutoShowing = JNIEnv.GetStaticMethodID (class_ref, "isSurveysAutoShowing", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSurveysAutoShowing);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='SurveysSettings']/method[@name='setSurveysAutoShowing' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSurveysAutoShowing", "(Z)V", "GetSetSurveysAutoShowing_ZHandler")]
			set {
				if (id_setSurveysAutoShowing_Z == IntPtr.Zero)
					id_setSurveysAutoShowing_Z = JNIEnv.GetStaticMethodID (class_ref, "setSurveysAutoShowing", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setSurveysAutoShowing_Z, __args);
				} finally {
				}
			}
		}

	}
}
