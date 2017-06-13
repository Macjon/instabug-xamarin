using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Surveys.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysUtils']"
	[global::Android.Runtime.Register ("com/instabug/library/surveys/utils/SurveysUtils", DoNotGenerateAcw=true)]
	public partial class SurveysUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/surveys/utils/SurveysUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SurveysUtils); }
		}

		protected SurveysUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysUtils']/constructor[@name='SurveysUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SurveysUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SurveysUtils)) {
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

		static IntPtr id_isSurveysFeatureAvailable;
		public static unsafe bool IsSurveysFeatureAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysUtils']/method[@name='isSurveysFeatureAvailable' and count(parameter)=0]"
			[Register ("isSurveysFeatureAvailable", "()Z", "GetIsSurveysFeatureAvailableHandler")]
			get {
				if (id_isSurveysFeatureAvailable == IntPtr.Zero)
					id_isSurveysFeatureAvailable = JNIEnv.GetStaticMethodID (class_ref, "isSurveysFeatureAvailable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSurveysFeatureAvailable);
				} finally {
				}
			}
		}

		static IntPtr id_isSurveysFeatureEnabled;
		public static unsafe bool IsSurveysFeatureEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysUtils']/method[@name='isSurveysFeatureEnabled' and count(parameter)=0]"
			[Register ("isSurveysFeatureEnabled", "()Z", "GetIsSurveysFeatureEnabledHandler")]
			get {
				if (id_isSurveysFeatureEnabled == IntPtr.Zero)
					id_isSurveysFeatureEnabled = JNIEnv.GetStaticMethodID (class_ref, "isSurveysFeatureEnabled", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSurveysFeatureEnabled);
				} finally {
				}
			}
		}

	}
}
