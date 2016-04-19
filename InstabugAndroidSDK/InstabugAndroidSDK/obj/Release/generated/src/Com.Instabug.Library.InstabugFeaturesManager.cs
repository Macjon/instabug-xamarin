using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeaturesManager']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugFeaturesManager", DoNotGenerateAcw=true)]
	public partial class InstabugFeaturesManager : global::Java.Lang.Object {


		static IntPtr DEFAULT_FEATURE_STATE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeaturesManager']/field[@name='DEFAULT_FEATURE_STATE']"
		[Register ("DEFAULT_FEATURE_STATE")]
		public static global::Com.Instabug.Library.Feature.State DefaultFeatureState {
			get {
				if (DEFAULT_FEATURE_STATE_jfieldId == IntPtr.Zero)
					DEFAULT_FEATURE_STATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_FEATURE_STATE", "Lcom/instabug/library/Feature$State;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_FEATURE_STATE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugFeaturesManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugFeaturesManager); }
		}

		protected InstabugFeaturesManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Library.InstabugFeaturesManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeaturesManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/library/InstabugFeaturesManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/library/InstabugFeaturesManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeaturesManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFeatureState_Lcom_instabug_library_Feature_;
#pragma warning disable 0169
		static Delegate GetGetFeatureState_Lcom_instabug_library_Feature_Handler ()
		{
			if (cb_getFeatureState_Lcom_instabug_library_Feature_ == null)
				cb_getFeatureState_Lcom_instabug_library_Feature_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFeatureState_Lcom_instabug_library_Feature_);
			return cb_getFeatureState_Lcom_instabug_library_Feature_;
		}

		static IntPtr n_GetFeatureState_Lcom_instabug_library_Feature_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugFeaturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeaturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Feature p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFeatureState (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFeatureState_Lcom_instabug_library_Feature_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeaturesManager']/method[@name='getFeatureState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature']]"
		[Register ("getFeatureState", "(Lcom/instabug/library/Feature;)Lcom/instabug/library/Feature$State;", "GetGetFeatureState_Lcom_instabug_library_Feature_Handler")]
		public virtual unsafe global::Com.Instabug.Library.Feature.State GetFeatureState (global::Com.Instabug.Library.Feature p0)
		{
			if (id_getFeatureState_Lcom_instabug_library_Feature_ == IntPtr.Zero)
				id_getFeatureState_Lcom_instabug_library_Feature_ = JNIEnv.GetMethodID (class_ref, "getFeatureState", "(Lcom/instabug/library/Feature;)Lcom/instabug/library/Feature$State;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Instabug.Library.Feature.State __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (JNIEnv.CallObjectMethod  (Handle, id_getFeatureState_Lcom_instabug_library_Feature_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFeatureState", "(Lcom/instabug/library/Feature;)Lcom/instabug/library/Feature$State;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isFeatureAvailable_Lcom_instabug_library_Feature_;
#pragma warning disable 0169
		static Delegate GetIsFeatureAvailable_Lcom_instabug_library_Feature_Handler ()
		{
			if (cb_isFeatureAvailable_Lcom_instabug_library_Feature_ == null)
				cb_isFeatureAvailable_Lcom_instabug_library_Feature_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsFeatureAvailable_Lcom_instabug_library_Feature_);
			return cb_isFeatureAvailable_Lcom_instabug_library_Feature_;
		}

		static bool n_IsFeatureAvailable_Lcom_instabug_library_Feature_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugFeaturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeaturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Feature p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsFeatureAvailable (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isFeatureAvailable_Lcom_instabug_library_Feature_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeaturesManager']/method[@name='isFeatureAvailable' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature']]"
		[Register ("isFeatureAvailable", "(Lcom/instabug/library/Feature;)Z", "GetIsFeatureAvailable_Lcom_instabug_library_Feature_Handler")]
		public virtual unsafe bool IsFeatureAvailable (global::Com.Instabug.Library.Feature p0)
		{
			if (id_isFeatureAvailable_Lcom_instabug_library_Feature_ == IntPtr.Zero)
				id_isFeatureAvailable_Lcom_instabug_library_Feature_ = JNIEnv.GetMethodID (class_ref, "isFeatureAvailable", "(Lcom/instabug/library/Feature;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_isFeatureAvailable_Lcom_instabug_library_Feature_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFeatureAvailable", "(Lcom/instabug/library/Feature;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
		static Delegate GetSetFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_Handler ()
		{
			if (cb_setFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_ == null)
				cb_setFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_);
			return cb_setFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_;
		}

		static void n_SetFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Instabug.Library.InstabugFeaturesManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeaturesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Feature p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Feature.State p1 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetFeatureState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeaturesManager']/method[@name='setFeatureState' and count(parameter)=2 and parameter[1][@type='com.instabug.library.Feature'] and parameter[2][@type='com.instabug.library.Feature.State']]"
		[Register ("setFeatureState", "(Lcom/instabug/library/Feature;Lcom/instabug/library/Feature$State;)V", "GetSetFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_Handler")]
		public virtual unsafe void SetFeatureState (global::Com.Instabug.Library.Feature p0, global::Com.Instabug.Library.Feature.State p1)
		{
			if (id_setFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
				id_setFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "setFeatureState", "(Lcom/instabug/library/Feature;Lcom/instabug/library/Feature$State;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFeatureState_Lcom_instabug_library_Feature_Lcom_instabug_library_Feature_State_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFeatureState", "(Lcom/instabug/library/Feature;Lcom/instabug/library/Feature$State;)V"), __args);
			} finally {
			}
		}

	}
}
