using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode.Aso {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='MapManager']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/aso/MapManager", DoNotGenerateAcw=true)]
	public partial class MapManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/aso/MapManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapManager); }
		}

		protected MapManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
