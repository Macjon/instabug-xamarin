using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegToThumb2x2']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mjpeg/JpegToThumb2x2", DoNotGenerateAcw=true)]
	public partial class JpegToThumb2x2 : global::Org.Jcodec.Codecs.Mjpeg.JpegDecoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mjpeg/JpegToThumb2x2", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JpegToThumb2x2); }
		}

		protected JpegToThumb2x2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegToThumb2x2']/constructor[@name='JpegToThumb2x2' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JpegToThumb2x2 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JpegToThumb2x2)) {
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

		static IntPtr id_ctor_ZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegToThumb2x2']/constructor[@name='JpegToThumb2x2' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(ZZ)V", "")]
		public unsafe JpegToThumb2x2 (bool interlace, bool topFieldFirst)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (interlace);
				__args [1] = new JValue (topFieldFirst);
				if (((object) this).GetType () != typeof (JpegToThumb2x2)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ZZ)V", __args);
					return;
				}

				if (id_ctor_ZZ == IntPtr.Zero)
					id_ctor_ZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(ZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ZZ, __args);
			} finally {
			}
		}

	}
}