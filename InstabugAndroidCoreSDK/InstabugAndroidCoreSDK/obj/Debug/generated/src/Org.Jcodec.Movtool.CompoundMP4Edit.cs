using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='CompoundMP4Edit']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/CompoundMP4Edit", DoNotGenerateAcw=true)]
	public partial class CompoundMP4Edit : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/CompoundMP4Edit", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompoundMP4Edit); }
		}

		protected CompoundMP4Edit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
