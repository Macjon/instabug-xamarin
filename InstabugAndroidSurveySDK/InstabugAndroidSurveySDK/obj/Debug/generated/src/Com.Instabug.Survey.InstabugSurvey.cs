using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Survey {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.survey']/class[@name='InstabugSurvey']"
	[global::Android.Runtime.Register ("com/instabug/survey/InstabugSurvey", DoNotGenerateAcw=true)]
	public partial class InstabugSurvey : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/survey/InstabugSurvey", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugSurvey); }
		}

		protected InstabugSurvey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.survey']/class[@name='InstabugSurvey']/constructor[@name='InstabugSurvey' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugSurvey ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InstabugSurvey)) {
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

		static IntPtr id_hasValidSurveys;
		public static unsafe bool HasValidSurveys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey']/class[@name='InstabugSurvey']/method[@name='hasValidSurveys' and count(parameter)=0]"
			[Register ("hasValidSurveys", "()Z", "GetHasValidSurveysHandler")]
			get {
				if (id_hasValidSurveys == IntPtr.Zero)
					id_hasValidSurveys = JNIEnv.GetStaticMethodID (class_ref, "hasValidSurveys", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasValidSurveys);
				} finally {
				}
			}
		}

		static IntPtr id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey']/class[@name='InstabugSurvey']/method[@name='setAfterShowingSurveyRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setAfterShowingSurveyRunnable", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void SetAfterShowingSurveyRunnable (global::Java.Lang.IRunnable afterShowingSurveyRunnable)
		{
			if (id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "setAfterShowingSurveyRunnable", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (afterShowingSurveyRunnable);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAfterShowingSurveyRunnable_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey']/class[@name='InstabugSurvey']/method[@name='setPreShowingSurveyRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setPreShowingSurveyRunnable", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void SetPreShowingSurveyRunnable (global::Java.Lang.IRunnable preShowingSurveyRunnable)
		{
			if (id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "setPreShowingSurveyRunnable", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (preShowingSurveyRunnable);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPreShowingSurveyRunnable_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_setSurveysAutoShowing_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey']/class[@name='InstabugSurvey']/method[@name='setSurveysAutoShowing' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSurveysAutoShowing", "(Z)V", "")]
		public static unsafe void SetSurveysAutoShowing (bool isSurveysAutoShowing)
		{
			if (id_setSurveysAutoShowing_Z == IntPtr.Zero)
				id_setSurveysAutoShowing_Z = JNIEnv.GetStaticMethodID (class_ref, "setSurveysAutoShowing", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (isSurveysAutoShowing);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSurveysAutoShowing_Z, __args);
			} finally {
			}
		}

		static IntPtr id_showValidSurvey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey']/class[@name='InstabugSurvey']/method[@name='showValidSurvey' and count(parameter)=0]"
		[Register ("showValidSurvey", "()Z", "")]
		public static unsafe bool ShowValidSurvey ()
		{
			if (id_showValidSurvey == IntPtr.Zero)
				id_showValidSurvey = JNIEnv.GetStaticMethodID (class_ref, "showValidSurvey", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_showValidSurvey);
			} finally {
			}
		}

	}
}
