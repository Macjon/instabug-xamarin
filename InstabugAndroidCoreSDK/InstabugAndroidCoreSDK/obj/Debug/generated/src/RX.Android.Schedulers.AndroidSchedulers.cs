using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RX.Android.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='rx.android.schedulers']/class[@name='AndroidSchedulers']"
	[global::Android.Runtime.Register ("rx/android/schedulers/AndroidSchedulers", DoNotGenerateAcw=true)]
	public sealed partial class AndroidSchedulers : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("rx/android/schedulers/AndroidSchedulers", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidSchedulers); }
		}

		internal AndroidSchedulers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
