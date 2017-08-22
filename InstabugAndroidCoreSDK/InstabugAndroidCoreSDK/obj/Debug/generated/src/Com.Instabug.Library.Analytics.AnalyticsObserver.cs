using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Analytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']"
	[global::Android.Runtime.Register ("com/instabug/library/analytics/AnalyticsObserver", DoNotGenerateAcw=true)]
	public partial class AnalyticsObserver : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/analytics/AnalyticsObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnalyticsObserver); }
		}

		protected AnalyticsObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Library.Analytics.AnalyticsObserver Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/library/analytics/AnalyticsObserver;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/library/analytics/AnalyticsObserver;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_catchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
#pragma warning disable 0169
		static Delegate GetCatchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_Handler ()
		{
			if (cb_catchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ == null)
				cb_catchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CatchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_);
			return cb_catchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
		}

		static void n_CatchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Analytics.AnalyticsObserver __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Analytics.Model.Api.Parameter[] p0 = (global::Com.Instabug.Library.Analytics.Model.Api.Parameter[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Instabug.Library.Analytics.Model.Api.Parameter));
			__this.CatchApiUsage (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_catchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='catchApiUsage' and count(parameter)=1 and parameter[1][@type='com.instabug.library.analytics.model.Api.Parameter...']]"
		[Register ("catchApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V", "GetCatchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_Handler")]
		public virtual unsafe void CatchApiUsage (params global:: Com.Instabug.Library.Analytics.Model.Api.Parameter[] p0)
		{
			if (id_catchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ == IntPtr.Zero)
				id_catchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ = JNIEnv.GetMethodID (class_ref, "catchApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_catchApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "catchApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_catchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
#pragma warning disable 0169
		static Delegate GetCatchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_Handler ()
		{
			if (cb_catchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ == null)
				cb_catchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CatchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_);
			return cb_catchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
		}

		static void n_CatchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Analytics.AnalyticsObserver __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Analytics.Model.Api.Parameter[] p0 = (global::Com.Instabug.Library.Analytics.Model.Api.Parameter[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Instabug.Library.Analytics.Model.Api.Parameter));
			__this.CatchDeprecatedApiUsage (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_catchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='catchDeprecatedApiUsage' and count(parameter)=1 and parameter[1][@type='com.instabug.library.analytics.model.Api.Parameter...']]"
		[Register ("catchDeprecatedApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V", "GetCatchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_Handler")]
		public virtual unsafe void CatchDeprecatedApiUsage (params global:: Com.Instabug.Library.Analytics.Model.Api.Parameter[] p0)
		{
			if (id_catchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ == IntPtr.Zero)
				id_catchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ = JNIEnv.GetMethodID (class_ref, "catchDeprecatedApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_catchDeprecatedApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "catchDeprecatedApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_catchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
#pragma warning disable 0169
		static Delegate GetCatchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_Handler ()
		{
			if (cb_catchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ == null)
				cb_catchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CatchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_);
			return cb_catchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
		}

		static void n_CatchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Analytics.AnalyticsObserver __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Analytics.Model.Api.Parameter[] p0 = (global::Com.Instabug.Library.Analytics.Model.Api.Parameter[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Instabug.Library.Analytics.Model.Api.Parameter));
			__this.CatchDeprecatedLoggingApiUsage (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_catchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='catchDeprecatedLoggingApiUsage' and count(parameter)=1 and parameter[1][@type='com.instabug.library.analytics.model.Api.Parameter...']]"
		[Register ("catchDeprecatedLoggingApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V", "GetCatchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_Handler")]
		public virtual unsafe void CatchDeprecatedLoggingApiUsage (params global:: Com.Instabug.Library.Analytics.Model.Api.Parameter[] p0)
		{
			if (id_catchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ == IntPtr.Zero)
				id_catchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ = JNIEnv.GetMethodID (class_ref, "catchDeprecatedLoggingApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_catchDeprecatedLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "catchDeprecatedLoggingApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_catchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
#pragma warning disable 0169
		static Delegate GetCatchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_Handler ()
		{
			if (cb_catchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ == null)
				cb_catchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CatchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_);
			return cb_catchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
		}

		static void n_CatchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Analytics.AnalyticsObserver __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Analytics.Model.Api.Parameter[] p0 = (global::Com.Instabug.Library.Analytics.Model.Api.Parameter[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Instabug.Library.Analytics.Model.Api.Parameter));
			__this.CatchLoggingApiUsage (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_catchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='catchLoggingApiUsage' and count(parameter)=1 and parameter[1][@type='com.instabug.library.analytics.model.Api.Parameter...']]"
		[Register ("catchLoggingApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V", "GetCatchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_Handler")]
		public virtual unsafe void CatchLoggingApiUsage (params global:: Com.Instabug.Library.Analytics.Model.Api.Parameter[] p0)
		{
			if (id_catchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ == IntPtr.Zero)
				id_catchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_ = JNIEnv.GetMethodID (class_ref, "catchLoggingApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_catchLoggingApiUsage_arrayLcom_instabug_library_analytics_model_Api_Parameter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "catchLoggingApiUsage", "([Lcom/instabug/library/analytics/model/Api$Parameter;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_catchNotificationClicking;
#pragma warning disable 0169
		static Delegate GetCatchNotificationClickingHandler ()
		{
			if (cb_catchNotificationClicking == null)
				cb_catchNotificationClicking = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CatchNotificationClicking);
			return cb_catchNotificationClicking;
		}

		static void n_CatchNotificationClicking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Analytics.AnalyticsObserver __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CatchNotificationClicking ();
		}
#pragma warning restore 0169

		static IntPtr id_catchNotificationClicking;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='catchNotificationClicking' and count(parameter)=0]"
		[Register ("catchNotificationClicking", "()V", "GetCatchNotificationClickingHandler")]
		public virtual unsafe void CatchNotificationClicking ()
		{
			if (id_catchNotificationClicking == IntPtr.Zero)
				id_catchNotificationClicking = JNIEnv.GetMethodID (class_ref, "catchNotificationClicking", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_catchNotificationClicking);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "catchNotificationClicking", "()V"));
			} finally {
			}
		}

		static Delegate cb_catchNotificationDismissing_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetCatchNotificationDismissing_Ljava_lang_Boolean_Handler ()
		{
			if (cb_catchNotificationDismissing_Ljava_lang_Boolean_ == null)
				cb_catchNotificationDismissing_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CatchNotificationDismissing_Ljava_lang_Boolean_);
			return cb_catchNotificationDismissing_Ljava_lang_Boolean_;
		}

		static void n_CatchNotificationDismissing_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Analytics.AnalyticsObserver __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CatchNotificationDismissing (p0);
		}
#pragma warning restore 0169

		static IntPtr id_catchNotificationDismissing_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='catchNotificationDismissing' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("catchNotificationDismissing", "(Ljava/lang/Boolean;)V", "GetCatchNotificationDismissing_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void CatchNotificationDismissing (global::Java.Lang.Boolean p0)
		{
			if (id_catchNotificationDismissing_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_catchNotificationDismissing_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "catchNotificationDismissing", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_catchNotificationDismissing_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "catchNotificationDismissing", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_catchNotificationShowing_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCatchNotificationShowing_Ljava_lang_String_Handler ()
		{
			if (cb_catchNotificationShowing_Ljava_lang_String_ == null)
				cb_catchNotificationShowing_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CatchNotificationShowing_Ljava_lang_String_);
			return cb_catchNotificationShowing_Ljava_lang_String_;
		}

		static void n_CatchNotificationShowing_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Analytics.AnalyticsObserver __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CatchNotificationShowing (p0);
		}
#pragma warning restore 0169

		static IntPtr id_catchNotificationShowing_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='catchNotificationShowing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("catchNotificationShowing", "(Ljava/lang/String;)V", "GetCatchNotificationShowing_Ljava_lang_String_Handler")]
		public virtual unsafe void CatchNotificationShowing (string p0)
		{
			if (id_catchNotificationShowing_Ljava_lang_String_ == IntPtr.Zero)
				id_catchNotificationShowing_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "catchNotificationShowing", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_catchNotificationShowing_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "catchNotificationShowing", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_catchSDKDismissing_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCatchSDKDismissing_Ljava_lang_String_Handler ()
		{
			if (cb_catchSDKDismissing_Ljava_lang_String_ == null)
				cb_catchSDKDismissing_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CatchSDKDismissing_Ljava_lang_String_);
			return cb_catchSDKDismissing_Ljava_lang_String_;
		}

		static void n_CatchSDKDismissing_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Analytics.AnalyticsObserver __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CatchSDKDismissing (p0);
		}
#pragma warning restore 0169

		static IntPtr id_catchSDKDismissing_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='catchSDKDismissing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("catchSDKDismissing", "(Ljava/lang/String;)V", "GetCatchSDKDismissing_Ljava_lang_String_Handler")]
		public virtual unsafe void CatchSDKDismissing (string p0)
		{
			if (id_catchSDKDismissing_Ljava_lang_String_ == IntPtr.Zero)
				id_catchSDKDismissing_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "catchSDKDismissing", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_catchSDKDismissing_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "catchSDKDismissing", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_catchSessionEnd;
#pragma warning disable 0169
		static Delegate GetCatchSessionEndHandler ()
		{
			if (cb_catchSessionEnd == null)
				cb_catchSessionEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CatchSessionEnd);
			return cb_catchSessionEnd;
		}

		static void n_CatchSessionEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Analytics.AnalyticsObserver __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CatchSessionEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_catchSessionEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='catchSessionEnd' and count(parameter)=0]"
		[Register ("catchSessionEnd", "()V", "GetCatchSessionEndHandler")]
		public virtual unsafe void CatchSessionEnd ()
		{
			if (id_catchSessionEnd == IntPtr.Zero)
				id_catchSessionEnd = JNIEnv.GetMethodID (class_ref, "catchSessionEnd", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_catchSessionEnd);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "catchSessionEnd", "()V"));
			} finally {
			}
		}

		static Delegate cb_catchSessionStart;
#pragma warning disable 0169
		static Delegate GetCatchSessionStartHandler ()
		{
			if (cb_catchSessionStart == null)
				cb_catchSessionStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CatchSessionStart);
			return cb_catchSessionStart;
		}

		static void n_CatchSessionStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Analytics.AnalyticsObserver __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CatchSessionStart ();
		}
#pragma warning restore 0169

		static IntPtr id_catchSessionStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='catchSessionStart' and count(parameter)=0]"
		[Register ("catchSessionStart", "()V", "GetCatchSessionStartHandler")]
		public virtual unsafe void CatchSessionStart ()
		{
			if (id_catchSessionStart == IntPtr.Zero)
				id_catchSessionStart = JNIEnv.GetMethodID (class_ref, "catchSessionStart", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_catchSessionStart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "catchSessionStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_catchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCatchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_catchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_catchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CatchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_);
			return cb_catchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CatchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Instabug.Library.Analytics.AnalyticsObserver __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.AnalyticsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CatchUIClickingEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_catchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics']/class[@name='AnalyticsObserver']/method[@name='catchUIClickingEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("catchUIClickingEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "GetCatchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void CatchUIClickingEvent (string p0, string p1)
		{
			if (id_catchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_catchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "catchUIClickingEvent", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_catchUIClickingEvent_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "catchUIClickingEvent", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
