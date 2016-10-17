using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.IO.Write {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='NALUnitWriter']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/io/write/NALUnitWriter", DoNotGenerateAcw=true)]
	public partial class NALUnitWriter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/io/write/NALUnitWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NALUnitWriter); }
		}

		protected NALUnitWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_channels_WritableByteChannel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='NALUnitWriter']/constructor[@name='NALUnitWriter' and count(parameter)=1 and parameter[1][@type='java.nio.channels.WritableByteChannel']]"
		[Register (".ctor", "(Ljava/nio/channels/WritableByteChannel;)V", "")]
		public unsafe NALUnitWriter (global::Java.Nio.Channels.IWritableByteChannel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (NALUnitWriter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/channels/WritableByteChannel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/channels/WritableByteChannel;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_channels_WritableByteChannel_ == IntPtr.Zero)
					id_ctor_Ljava_nio_channels_WritableByteChannel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/channels/WritableByteChannel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_channels_WritableByteChannel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_channels_WritableByteChannel_, __args);
			} finally {
			}
		}

	}
}
