using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Surveys.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.surveys.network']/class[@name='SurveysFetcher']"
	[global::Android.Runtime.Register ("com/instabug/library/surveys/network/SurveysFetcher", DoNotGenerateAcw=true)]
	public partial class SurveysFetcher : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/surveys/network/SurveysFetcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SurveysFetcher); }
		}

		protected SurveysFetcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_fetch_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetFetch_Landroid_content_Context_Handler ()
		{
			if (cb_fetch_Landroid_content_Context_ == null)
				cb_fetch_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Fetch_Landroid_content_Context_);
			return cb_fetch_Landroid_content_Context_;
		}

		static void n_Fetch_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Surveys.Network.SurveysFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Surveys.Network.SurveysFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Fetch (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fetch_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.surveys.network']/class[@name='SurveysFetcher']/method[@name='fetch' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("fetch", "(Landroid/content/Context;)V", "GetFetch_Landroid_content_Context_Handler")]
		public virtual unsafe void Fetch (global::Android.Content.Context p0)
		{
			if (id_fetch_Landroid_content_Context_ == IntPtr.Zero)
				id_fetch_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "fetch", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetch_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fetch", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

	}
}
