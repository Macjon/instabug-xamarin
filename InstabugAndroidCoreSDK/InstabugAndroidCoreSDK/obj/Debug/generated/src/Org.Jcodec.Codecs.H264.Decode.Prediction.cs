using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Prediction']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/Prediction", DoNotGenerateAcw=true)]
	public partial class Prediction : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/Prediction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Prediction); }
		}

		protected Prediction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
