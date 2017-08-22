using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Survey.Settings {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PerSessionSettings']"
	[global::Android.Runtime.Register ("com/instabug/survey/settings/PerSessionSettings", DoNotGenerateAcw=true)]
	public partial class PerSessionSettings : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/survey/settings/PerSessionSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PerSessionSettings); }
		}

		protected PerSessionSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAfterShowingSurveyRunnable;
#pragma warning disable 0169
		static Delegate GetGetAfterShowingSurveyRunnableHandler ()
		{
			if (cb_getAfterShowingSurveyRunnable == null)
				cb_getAfterShowingSurveyRunnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAfterShowingSurveyRunnable);
			return cb_getAfterShowingSurveyRunnable;
		}

		static IntPtr n_GetAfterShowingSurveyRunnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Survey.Settings.PerSessionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PerSessionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AfterShowingSurveyRunnable);
		}
#pragma warning restore 0169

		static Delegate cb_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetAfterShowingSurveyRunnable_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_ == null)
				cb_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAfterShowingSurveyRunnable_Ljava_lang_Runnable_);
			return cb_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_;
		}

		static void n_SetAfterShowingSurveyRunnable_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_afterShowingSurveyRunnable)
		{
			global::Com.Instabug.Survey.Settings.PerSessionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PerSessionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable afterShowingSurveyRunnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_afterShowingSurveyRunnable, JniHandleOwnership.DoNotTransfer);
			__this.AfterShowingSurveyRunnable = afterShowingSurveyRunnable;
		}
#pragma warning restore 0169

		static IntPtr id_getAfterShowingSurveyRunnable;
		static IntPtr id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_;
		public virtual unsafe global::Java.Lang.IRunnable AfterShowingSurveyRunnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PerSessionSettings']/method[@name='getAfterShowingSurveyRunnable' and count(parameter)=0]"
			[Register ("getAfterShowingSurveyRunnable", "()Ljava/lang/Runnable;", "GetGetAfterShowingSurveyRunnableHandler")]
			get {
				if (id_getAfterShowingSurveyRunnable == IntPtr.Zero)
					id_getAfterShowingSurveyRunnable = JNIEnv.GetMethodID (class_ref, "getAfterShowingSurveyRunnable", "()Ljava/lang/Runnable;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAfterShowingSurveyRunnable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAfterShowingSurveyRunnable", "()Ljava/lang/Runnable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PerSessionSettings']/method[@name='setAfterShowingSurveyRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("setAfterShowingSurveyRunnable", "(Ljava/lang/Runnable;)V", "GetSetAfterShowingSurveyRunnable_Ljava_lang_Runnable_Handler")]
			set {
				if (id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setAfterShowingSurveyRunnable", "(Ljava/lang/Runnable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAfterShowingSurveyRunnable", "(Ljava/lang/Runnable;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Survey.Settings.PerSessionSettings Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PerSessionSettings']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/survey/settings/PerSessionSettings;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/survey/settings/PerSessionSettings;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PerSessionSettings> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMethodsLog;
#pragma warning disable 0169
		static Delegate GetGetMethodsLogHandler ()
		{
			if (cb_getMethodsLog == null)
				cb_getMethodsLog = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethodsLog);
			return cb_getMethodsLog;
		}

		static IntPtr n_GetMethodsLog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Survey.Settings.PerSessionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PerSessionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MethodsLog);
		}
#pragma warning restore 0169

		static IntPtr id_getMethodsLog;
		public virtual unsafe global::Java.Lang.StringBuilder MethodsLog {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PerSessionSettings']/method[@name='getMethodsLog' and count(parameter)=0]"
			[Register ("getMethodsLog", "()Ljava/lang/StringBuilder;", "GetGetMethodsLogHandler")]
			get {
				if (id_getMethodsLog == IntPtr.Zero)
					id_getMethodsLog = JNIEnv.GetMethodID (class_ref, "getMethodsLog", "()Ljava/lang/StringBuilder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMethodsLog), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMethodsLog", "()Ljava/lang/StringBuilder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPreShowingSurveyRunnable;
#pragma warning disable 0169
		static Delegate GetGetPreShowingSurveyRunnableHandler ()
		{
			if (cb_getPreShowingSurveyRunnable == null)
				cb_getPreShowingSurveyRunnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreShowingSurveyRunnable);
			return cb_getPreShowingSurveyRunnable;
		}

		static IntPtr n_GetPreShowingSurveyRunnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Survey.Settings.PerSessionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PerSessionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreShowingSurveyRunnable);
		}
#pragma warning restore 0169

		static Delegate cb_setPreShowingSurveyRunnable_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetPreShowingSurveyRunnable_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setPreShowingSurveyRunnable_Ljava_lang_Runnable_ == null)
				cb_setPreShowingSurveyRunnable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPreShowingSurveyRunnable_Ljava_lang_Runnable_);
			return cb_setPreShowingSurveyRunnable_Ljava_lang_Runnable_;
		}

		static void n_SetPreShowingSurveyRunnable_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_preShowingSurveyRunnable)
		{
			global::Com.Instabug.Survey.Settings.PerSessionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PerSessionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable preShowingSurveyRunnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_preShowingSurveyRunnable, JniHandleOwnership.DoNotTransfer);
			__this.PreShowingSurveyRunnable = preShowingSurveyRunnable;
		}
#pragma warning restore 0169

		static IntPtr id_getPreShowingSurveyRunnable;
		static IntPtr id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_;
		public virtual unsafe global::Java.Lang.IRunnable PreShowingSurveyRunnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PerSessionSettings']/method[@name='getPreShowingSurveyRunnable' and count(parameter)=0]"
			[Register ("getPreShowingSurveyRunnable", "()Ljava/lang/Runnable;", "GetGetPreShowingSurveyRunnableHandler")]
			get {
				if (id_getPreShowingSurveyRunnable == IntPtr.Zero)
					id_getPreShowingSurveyRunnable = JNIEnv.GetMethodID (class_ref, "getPreShowingSurveyRunnable", "()Ljava/lang/Runnable;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreShowingSurveyRunnable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreShowingSurveyRunnable", "()Ljava/lang/Runnable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PerSessionSettings']/method[@name='setPreShowingSurveyRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("setPreShowingSurveyRunnable", "(Ljava/lang/Runnable;)V", "GetSetPreShowingSurveyRunnable_Ljava_lang_Runnable_Handler")]
			set {
				if (id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setPreShowingSurveyRunnable", "(Ljava/lang/Runnable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreShowingSurveyRunnable", "(Ljava/lang/Runnable;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSurveysAutoShowing;
#pragma warning disable 0169
		static Delegate GetIsSurveysAutoShowingHandler ()
		{
			if (cb_isSurveysAutoShowing == null)
				cb_isSurveysAutoShowing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSurveysAutoShowing);
			return cb_isSurveysAutoShowing;
		}

		static bool n_IsSurveysAutoShowing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Survey.Settings.PerSessionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PerSessionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SurveysAutoShowing;
		}
#pragma warning restore 0169

		static Delegate cb_setSurveysAutoShowing_Z;
#pragma warning disable 0169
		static Delegate GetSetSurveysAutoShowing_ZHandler ()
		{
			if (cb_setSurveysAutoShowing_Z == null)
				cb_setSurveysAutoShowing_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSurveysAutoShowing_Z);
			return cb_setSurveysAutoShowing_Z;
		}

		static void n_SetSurveysAutoShowing_Z (IntPtr jnienv, IntPtr native__this, bool isSurveysAutoShowing)
		{
			global::Com.Instabug.Survey.Settings.PerSessionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Settings.PerSessionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SurveysAutoShowing = isSurveysAutoShowing;
		}
#pragma warning restore 0169

		static IntPtr id_isSurveysAutoShowing;
		static IntPtr id_setSurveysAutoShowing_Z;
		public virtual unsafe bool SurveysAutoShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PerSessionSettings']/method[@name='isSurveysAutoShowing' and count(parameter)=0]"
			[Register ("isSurveysAutoShowing", "()Z", "GetIsSurveysAutoShowingHandler")]
			get {
				if (id_isSurveysAutoShowing == IntPtr.Zero)
					id_isSurveysAutoShowing = JNIEnv.GetMethodID (class_ref, "isSurveysAutoShowing", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSurveysAutoShowing);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSurveysAutoShowing", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PerSessionSettings']/method[@name='setSurveysAutoShowing' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSurveysAutoShowing", "(Z)V", "GetSetSurveysAutoShowing_ZHandler")]
			set {
				if (id_setSurveysAutoShowing_Z == IntPtr.Zero)
					id_setSurveysAutoShowing_Z = JNIEnv.GetMethodID (class_ref, "setSurveysAutoShowing", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurveysAutoShowing_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurveysAutoShowing", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.settings']/class[@name='PerSessionSettings']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "")]
		public static unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetStaticMethodID (class_ref, "init", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init);
			} finally {
			}
		}

	}
}
