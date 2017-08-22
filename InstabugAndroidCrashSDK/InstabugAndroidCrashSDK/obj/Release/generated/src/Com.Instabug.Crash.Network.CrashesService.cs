using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Crash.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.crash.network']/class[@name='CrashesService']"
	[global::Android.Runtime.Register ("com/instabug/crash/network/CrashesService", DoNotGenerateAcw=true)]
	public partial class CrashesService : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/crash/network/CrashesService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CrashesService); }
		}

		protected CrashesService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Crash.Network.CrashesService Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.crash.network']/class[@name='CrashesService']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/crash/network/CrashesService;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/crash/network/CrashesService;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Crash.Network.CrashesService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
