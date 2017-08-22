using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Survey.Analytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.survey.analytics']/class[@name='SurveyEventLogger']"
	[global::Android.Runtime.Register ("com/instabug/survey/analytics/SurveyEventLogger", DoNotGenerateAcw=true)]
	public partial class SurveyEventLogger : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/survey/analytics/SurveyEventLogger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SurveyEventLogger); }
		}

		protected SurveyEventLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.survey.analytics']/class[@name='SurveyEventLogger']/constructor[@name='SurveyEventLogger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SurveyEventLogger ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SurveyEventLogger)) {
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

		static IntPtr id_logSurveyDismissing;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.analytics']/class[@name='SurveyEventLogger']/method[@name='logSurveyDismissing' and count(parameter)=0]"
		[Register ("logSurveyDismissing", "()V", "")]
		public static unsafe void LogSurveyDismissing ()
		{
			if (id_logSurveyDismissing == IntPtr.Zero)
				id_logSurveyDismissing = JNIEnv.GetStaticMethodID (class_ref, "logSurveyDismissing", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_logSurveyDismissing);
			} finally {
			}
		}

		static IntPtr id_logSurveyShowing;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.analytics']/class[@name='SurveyEventLogger']/method[@name='logSurveyShowing' and count(parameter)=0]"
		[Register ("logSurveyShowing", "()V", "")]
		public static unsafe void LogSurveyShowing ()
		{
			if (id_logSurveyShowing == IntPtr.Zero)
				id_logSurveyShowing = JNIEnv.GetStaticMethodID (class_ref, "logSurveyShowing", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_logSurveyShowing);
			} finally {
			}
		}

		static IntPtr id_logUIClickingEvent_Landroid_content_Context_Landroid_view_View_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.analytics']/class[@name='SurveyEventLogger']/method[@name='logUIClickingEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.View'] and parameter[3][@type='java.lang.String']]"
		[Register ("logUIClickingEvent", "(Landroid/content/Context;Landroid/view/View;Ljava/lang/String;)V", "")]
		public static unsafe void LogUIClickingEvent (global::Android.Content.Context context, global::Android.Views.View view, string parentTag)
		{
			if (id_logUIClickingEvent_Landroid_content_Context_Landroid_view_View_Ljava_lang_String_ == IntPtr.Zero)
				id_logUIClickingEvent_Landroid_content_Context_Landroid_view_View_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "logUIClickingEvent", "(Landroid/content/Context;Landroid/view/View;Ljava/lang/String;)V");
			IntPtr native_parentTag = JNIEnv.NewString (parentTag);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (view);
				__args [2] = new JValue (native_parentTag);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_logUIClickingEvent_Landroid_content_Context_Landroid_view_View_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_parentTag);
			}
		}

	}
}
