using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Surveys.Network.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.surveys.network.service']/class[@name='SurveysService']"
	[global::Android.Runtime.Register ("com/instabug/library/surveys/network/service/SurveysService", DoNotGenerateAcw=true)]
	public partial class SurveysService : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/surveys/network/service/SurveysService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SurveysService); }
		}

		protected SurveysService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Library.Surveys.Network.Service.SurveysService Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.surveys.network.service']/class[@name='SurveysService']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/library/surveys/network/service/SurveysService;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/library/surveys/network/service/SurveysService;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Surveys.Network.Service.SurveysService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
