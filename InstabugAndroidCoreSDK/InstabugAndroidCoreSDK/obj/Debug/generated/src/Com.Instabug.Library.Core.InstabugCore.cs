using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.core']/class[@name='InstabugCore']"
	[global::Android.Runtime.Register ("com/instabug/library/core/InstabugCore", DoNotGenerateAcw=true)]
	public partial class InstabugCore : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/core/InstabugCore", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugCore); }
		}

		protected InstabugCore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.core']/class[@name='InstabugCore']/constructor[@name='InstabugCore' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugCore ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InstabugCore)) {
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

		static IntPtr id_isFeaturesFetchedBefore;
		public static unsafe bool IsFeaturesFetchedBefore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core']/class[@name='InstabugCore']/method[@name='isFeaturesFetchedBefore' and count(parameter)=0]"
			[Register ("isFeaturesFetchedBefore", "()Z", "GetIsFeaturesFetchedBeforeHandler")]
			get {
				if (id_isFeaturesFetchedBefore == IntPtr.Zero)
					id_isFeaturesFetchedBefore = JNIEnv.GetStaticMethodID (class_ref, "isFeaturesFetchedBefore", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFeaturesFetchedBefore);
				} finally {
				}
			}
		}

		static IntPtr id_getPreReportRunnable;
		public static unsafe global::Java.Lang.IRunnable PreReportRunnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core']/class[@name='InstabugCore']/method[@name='getPreReportRunnable' and count(parameter)=0]"
			[Register ("getPreReportRunnable", "()Ljava/lang/Runnable;", "GetGetPreReportRunnableHandler")]
			get {
				if (id_getPreReportRunnable == IntPtr.Zero)
					id_getPreReportRunnable = JNIEnv.GetStaticMethodID (class_ref, "getPreReportRunnable", "()Ljava/lang/Runnable;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPreReportRunnable), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSDKVersion;
		public static unsafe string SDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core']/class[@name='InstabugCore']/method[@name='getSDKVersion' and count(parameter)=0]"
			[Register ("getSDKVersion", "()Ljava/lang/String;", "GetGetSDKVersionHandler")]
			get {
				if (id_getSDKVersion == IntPtr.Zero)
					id_getSDKVersion = JNIEnv.GetStaticMethodID (class_ref, "getSDKVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSDKVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getStartedActivitiesCount;
		public static unsafe int StartedActivitiesCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core']/class[@name='InstabugCore']/method[@name='getStartedActivitiesCount' and count(parameter)=0]"
			[Register ("getStartedActivitiesCount", "()I", "GetGetStartedActivitiesCountHandler")]
			get {
				if (id_getStartedActivitiesCount == IntPtr.Zero)
					id_getStartedActivitiesCount = JNIEnv.GetStaticMethodID (class_ref, "getStartedActivitiesCount", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getStartedActivitiesCount);
				} finally {
				}
			}
		}

		static IntPtr id_getFeatureState_Lcom_instabug_library_Feature_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core']/class[@name='InstabugCore']/method[@name='getFeatureState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature']]"
		[Register ("getFeatureState", "(Lcom/instabug/library/Feature;)Lcom/instabug/library/Feature$State;", "")]
		public static unsafe global::Com.Instabug.Library.Feature.State GetFeatureState (global::Com.Instabug.Library.Feature p0)
		{
			if (id_getFeatureState_Lcom_instabug_library_Feature_ == IntPtr.Zero)
				id_getFeatureState_Lcom_instabug_library_Feature_ = JNIEnv.GetStaticMethodID (class_ref, "getFeatureState", "(Lcom/instabug/library/Feature;)Lcom/instabug/library/Feature$State;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Instabug.Library.Feature.State __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFeatureState_Lcom_instabug_library_Feature_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isFeatureAvailable_Lcom_instabug_library_Feature_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core']/class[@name='InstabugCore']/method[@name='isFeatureAvailable' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature']]"
		[Register ("isFeatureAvailable", "(Lcom/instabug/library/Feature;)Z", "")]
		public static unsafe bool IsFeatureAvailable (global::Com.Instabug.Library.Feature p0)
		{
			if (id_isFeatureAvailable_Lcom_instabug_library_Feature_ == IntPtr.Zero)
				id_isFeatureAvailable_Lcom_instabug_library_Feature_ = JNIEnv.GetStaticMethodID (class_ref, "isFeatureAvailable", "(Lcom/instabug/library/Feature;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFeatureAvailable_Lcom_instabug_library_Feature_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
