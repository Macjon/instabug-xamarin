using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Survey {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.survey']/class[@name='SurveysManager']"
	[global::Android.Runtime.Register ("com/instabug/survey/SurveysManager", DoNotGenerateAcw=true)]
	public partial class SurveysManager : global::Java.Lang.Object, global::Com.Instabug.Survey.Network.SurveysFetcher.ICallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/survey/SurveysManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SurveysManager); }
		}

		protected SurveysManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasValidSurveys;
#pragma warning disable 0169
		static Delegate GetHasValidSurveysHandler ()
		{
			if (cb_hasValidSurveys == null)
				cb_hasValidSurveys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasValidSurveys);
			return cb_hasValidSurveys;
		}

		static bool n_HasValidSurveys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Survey.SurveysManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.SurveysManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasValidSurveys;
		}
#pragma warning restore 0169

		static IntPtr id_hasValidSurveys;
		public virtual unsafe bool HasValidSurveys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey']/class[@name='SurveysManager']/method[@name='hasValidSurveys' and count(parameter)=0]"
			[Register ("hasValidSurveys", "()Z", "GetHasValidSurveysHandler")]
			get {
				if (id_hasValidSurveys == IntPtr.Zero)
					id_hasValidSurveys = JNIEnv.GetMethodID (class_ref, "hasValidSurveys", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasValidSurveys);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasValidSurveys", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey']/class[@name='SurveysManager']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/instabug/survey/SurveysManager;", "")]
		public static unsafe global::Com.Instabug.Survey.SurveysManager GetInstance (global::Android.Content.Context context)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/instabug/survey/SurveysManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				global::Com.Instabug.Survey.SurveysManager __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.SurveysManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onFetchingFailed_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnFetchingFailed_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onFetchingFailed_Ljava_lang_Throwable_ == null)
				cb_onFetchingFailed_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFetchingFailed_Ljava_lang_Throwable_);
			return cb_onFetchingFailed_Ljava_lang_Throwable_;
		}

		static void n_OnFetchingFailed_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			global::Com.Instabug.Survey.SurveysManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.SurveysManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable error = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnFetchingFailed (error);
		}
#pragma warning restore 0169

		static IntPtr id_onFetchingFailed_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey']/class[@name='SurveysManager']/method[@name='onFetchingFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onFetchingFailed", "(Ljava/lang/Throwable;)V", "GetOnFetchingFailed_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void OnFetchingFailed (global::Java.Lang.Throwable error)
		{
			if (id_onFetchingFailed_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onFetchingFailed_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFetchingFailed", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (error);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFetchingFailed_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFetchingFailed", "(Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSurveyDialogShowing_Z;
#pragma warning disable 0169
		static Delegate GetSetSurveyDialogShowing_ZHandler ()
		{
			if (cb_setSurveyDialogShowing_Z == null)
				cb_setSurveyDialogShowing_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSurveyDialogShowing_Z);
			return cb_setSurveyDialogShowing_Z;
		}

		static void n_SetSurveyDialogShowing_Z (IntPtr jnienv, IntPtr native__this, bool surveyDialogShowing)
		{
			global::Com.Instabug.Survey.SurveysManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.SurveysManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSurveyDialogShowing (surveyDialogShowing);
		}
#pragma warning restore 0169

		static IntPtr id_setSurveyDialogShowing_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey']/class[@name='SurveysManager']/method[@name='setSurveyDialogShowing' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSurveyDialogShowing", "(Z)V", "GetSetSurveyDialogShowing_ZHandler")]
		public virtual unsafe void SetSurveyDialogShowing (bool surveyDialogShowing)
		{
			if (id_setSurveyDialogShowing_Z == IntPtr.Zero)
				id_setSurveyDialogShowing_Z = JNIEnv.GetMethodID (class_ref, "setSurveyDialogShowing", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (surveyDialogShowing);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurveyDialogShowing_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurveyDialogShowing", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showValidSurvey;
#pragma warning disable 0169
		static Delegate GetShowValidSurveyHandler ()
		{
			if (cb_showValidSurvey == null)
				cb_showValidSurvey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShowValidSurvey);
			return cb_showValidSurvey;
		}

		static bool n_ShowValidSurvey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Survey.SurveysManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.SurveysManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowValidSurvey ();
		}
#pragma warning restore 0169

		static IntPtr id_showValidSurvey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey']/class[@name='SurveysManager']/method[@name='showValidSurvey' and count(parameter)=0]"
		[Register ("showValidSurvey", "()Z", "GetShowValidSurveyHandler")]
		public virtual unsafe bool ShowValidSurvey ()
		{
			if (id_showValidSurvey == IntPtr.Zero)
				id_showValidSurvey = JNIEnv.GetMethodID (class_ref, "showValidSurvey", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_showValidSurvey);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showValidSurvey", "()Z"));
			} finally {
			}
		}

		static Delegate cb_startFetching;
#pragma warning disable 0169
		static Delegate GetStartFetchingHandler ()
		{
			if (cb_startFetching == null)
				cb_startFetching = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartFetching);
			return cb_startFetching;
		}

		static void n_StartFetching (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Survey.SurveysManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.SurveysManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartFetching ();
		}
#pragma warning restore 0169

		static IntPtr id_startFetching;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey']/class[@name='SurveysManager']/method[@name='startFetching' and count(parameter)=0]"
		[Register ("startFetching", "()V", "GetStartFetchingHandler")]
		public virtual unsafe void StartFetching ()
		{
			if (id_startFetching == IntPtr.Zero)
				id_startFetching = JNIEnv.GetMethodID (class_ref, "startFetching", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startFetching);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startFetching", "()V"));
			} finally {
			}
		}

	}
}
