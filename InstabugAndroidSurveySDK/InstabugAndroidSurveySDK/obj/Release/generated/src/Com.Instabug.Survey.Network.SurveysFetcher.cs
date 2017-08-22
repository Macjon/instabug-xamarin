using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Survey.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.survey.network']/class[@name='SurveysFetcher']"
	[global::Android.Runtime.Register ("com/instabug/survey/network/SurveysFetcher", DoNotGenerateAcw=true)]
	public partial class SurveysFetcher : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.survey.network']/interface[@name='SurveysFetcher.Callback']"
		[Register ("com/instabug/survey/network/SurveysFetcher$Callback", "", "Com.Instabug.Survey.Network.SurveysFetcher/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.network']/interface[@name='SurveysFetcher.Callback']/method[@name='onFetchingFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onFetchingFailed", "(Ljava/lang/Throwable;)V", "GetOnFetchingFailed_Ljava_lang_Throwable_Handler:Com.Instabug.Survey.Network.SurveysFetcher/ICallbackInvoker, InstabugAndroidSurveySDK")]
			void OnFetchingFailed (global::Java.Lang.Throwable p0);

		}

		[global::Android.Runtime.Register ("com/instabug/survey/network/SurveysFetcher$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/survey/network/SurveysFetcher$Callback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICallbackInvoker); }
			}

			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.instabug.survey.network.SurveysFetcher.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFetchingFailed_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnFetchingFailed_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onFetchingFailed_Ljava_lang_Throwable_ == null)
					cb_onFetchingFailed_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFetchingFailed_Ljava_lang_Throwable_);
				return cb_onFetchingFailed_Ljava_lang_Throwable_;
			}

			static void n_OnFetchingFailed_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Survey.Network.SurveysFetcher.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Network.SurveysFetcher.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFetchingFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFetchingFailed_Ljava_lang_Throwable_;
			public unsafe void OnFetchingFailed (global::Java.Lang.Throwable p0)
			{
				if (id_onFetchingFailed_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onFetchingFailed_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFetchingFailed", "(Ljava/lang/Throwable;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFetchingFailed_Ljava_lang_Throwable_, __args);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/survey/network/SurveysFetcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SurveysFetcher); }
		}

		protected SurveysFetcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_instabug_survey_network_SurveysFetcher_Callback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.survey.network']/class[@name='SurveysFetcher']/constructor[@name='SurveysFetcher' and count(parameter)=1 and parameter[1][@type='com.instabug.survey.network.SurveysFetcher.Callback']]"
		[Register (".ctor", "(Lcom/instabug/survey/network/SurveysFetcher$Callback;)V", "")]
		public unsafe SurveysFetcher (global::Com.Instabug.Survey.Network.SurveysFetcher.ICallback @callback)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);
				if (((object) this).GetType () != typeof (SurveysFetcher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/instabug/survey/network/SurveysFetcher$Callback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/instabug/survey/network/SurveysFetcher$Callback;)V", __args);
					return;
				}

				if (id_ctor_Lcom_instabug_survey_network_SurveysFetcher_Callback_ == IntPtr.Zero)
					id_ctor_Lcom_instabug_survey_network_SurveysFetcher_Callback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/instabug/survey/network/SurveysFetcher$Callback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_instabug_survey_network_SurveysFetcher_Callback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_instabug_survey_network_SurveysFetcher_Callback_, __args);
			} finally {
			}
		}

		static Delegate cb_fetch_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetFetch_Landroid_content_Context_Handler ()
		{
			if (cb_fetch_Landroid_content_Context_ == null)
				cb_fetch_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Fetch_Landroid_content_Context_);
			return cb_fetch_Landroid_content_Context_;
		}

		static void n_Fetch_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Instabug.Survey.Network.SurveysFetcher __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Network.SurveysFetcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Fetch (context);
		}
#pragma warning restore 0169

		static IntPtr id_fetch_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.network']/class[@name='SurveysFetcher']/method[@name='fetch' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("fetch", "(Landroid/content/Context;)V", "GetFetch_Landroid_content_Context_Handler")]
		public virtual unsafe void Fetch (global::Android.Content.Context context)
		{
			if (id_fetch_Landroid_content_Context_ == IntPtr.Zero)
				id_fetch_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "fetch", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetch_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fetch", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

	}
}
