using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFragment']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugFragment", DoNotGenerateAcw=true)]
	public partial class InstabugFragment : global::Android.App.Fragment {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugFragment); }
		}

		protected InstabugFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFragment']/constructor[@name='InstabugFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InstabugFragment)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
