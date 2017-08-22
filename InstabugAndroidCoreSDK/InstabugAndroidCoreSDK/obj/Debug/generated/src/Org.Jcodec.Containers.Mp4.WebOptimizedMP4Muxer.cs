using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='WebOptimizedMP4Muxer']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/WebOptimizedMP4Muxer", DoNotGenerateAcw=true)]
	public partial class WebOptimizedMP4Muxer : global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/WebOptimizedMP4Muxer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebOptimizedMP4Muxer); }
		}

		protected WebOptimizedMP4Muxer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
