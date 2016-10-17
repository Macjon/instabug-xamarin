using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vp8 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8DCT']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vp8/VP8DCT", DoNotGenerateAcw=true)]
	public partial class VP8DCT : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vp8/VP8DCT", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VP8DCT); }
		}

		protected VP8DCT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8DCT']/constructor[@name='VP8DCT' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VP8DCT ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VP8DCT)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		static IntPtr id_decodeDCT_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8DCT']/method[@name='decodeDCT' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("decodeDCT", "([I)[I", "")]
		public static unsafe int[] DecodeDCT (int[] p0)
		{
			if (id_decodeDCT_arrayI == IntPtr.Zero)
				id_decodeDCT_arrayI = JNIEnv.GetStaticMethodID (class_ref, "decodeDCT", "([I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeDCT_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_decodeWHT_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8DCT']/method[@name='decodeWHT' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("decodeWHT", "([I)[I", "")]
		public static unsafe int[] DecodeWHT (int[] p0)
		{
			if (id_decodeWHT_arrayI == IntPtr.Zero)
				id_decodeWHT_arrayI = JNIEnv.GetStaticMethodID (class_ref, "decodeWHT", "([I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeWHT_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeDCT_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8DCT']/method[@name='encodeDCT' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("encodeDCT", "([I)[I", "")]
		public static unsafe int[] EncodeDCT (int[] p0)
		{
			if (id_encodeDCT_arrayI == IntPtr.Zero)
				id_encodeDCT_arrayI = JNIEnv.GetStaticMethodID (class_ref, "encodeDCT", "([I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeDCT_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeWHT_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8DCT']/method[@name='encodeWHT' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("encodeWHT", "([I)[I", "")]
		public static unsafe int[] EncodeWHT (int[] p0)
		{
			if (id_encodeWHT_arrayI == IntPtr.Zero)
				id_encodeWHT_arrayI = JNIEnv.GetStaticMethodID (class_ref, "encodeWHT", "([I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeWHT_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
