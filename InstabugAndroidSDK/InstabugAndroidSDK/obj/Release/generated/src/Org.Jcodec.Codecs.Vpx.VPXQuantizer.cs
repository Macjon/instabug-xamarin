using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vpx {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXQuantizer']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vpx/VPXQuantizer", DoNotGenerateAcw=true)]
	public partial class VPXQuantizer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vpx/VPXQuantizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VPXQuantizer); }
		}

		protected VPXQuantizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXQuantizer']/constructor[@name='VPXQuantizer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VPXQuantizer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VPXQuantizer)) {
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

		static IntPtr id_dequantizeUV_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXQuantizer']/method[@name='dequantizeUV' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("dequantizeUV", "([II)V", "")]
		public unsafe void DequantizeUV (int[] p0, int p1)
		{
			if (id_dequantizeUV_arrayII == IntPtr.Zero)
				id_dequantizeUV_arrayII = JNIEnv.GetMethodID (class_ref, "dequantizeUV", "([II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dequantizeUV_arrayII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_dequantizeY2_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXQuantizer']/method[@name='dequantizeY2' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("dequantizeY2", "([II)V", "")]
		public unsafe void DequantizeY2 (int[] p0, int p1)
		{
			if (id_dequantizeY2_arrayII == IntPtr.Zero)
				id_dequantizeY2_arrayII = JNIEnv.GetMethodID (class_ref, "dequantizeY2", "([II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dequantizeY2_arrayII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_dequantizeY_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXQuantizer']/method[@name='dequantizeY' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("dequantizeY", "([II)V", "")]
		public unsafe void DequantizeY (int[] p0, int p1)
		{
			if (id_dequantizeY_arrayII == IntPtr.Zero)
				id_dequantizeY_arrayII = JNIEnv.GetMethodID (class_ref, "dequantizeY", "([II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dequantizeY_arrayII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_quantizeUV_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXQuantizer']/method[@name='quantizeUV' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("quantizeUV", "([II)V", "")]
		public unsafe void QuantizeUV (int[] p0, int p1)
		{
			if (id_quantizeUV_arrayII == IntPtr.Zero)
				id_quantizeUV_arrayII = JNIEnv.GetMethodID (class_ref, "quantizeUV", "([II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_quantizeUV_arrayII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_quantizeY2_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXQuantizer']/method[@name='quantizeY2' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("quantizeY2", "([II)V", "")]
		public unsafe void QuantizeY2 (int[] p0, int p1)
		{
			if (id_quantizeY2_arrayII == IntPtr.Zero)
				id_quantizeY2_arrayII = JNIEnv.GetMethodID (class_ref, "quantizeY2", "([II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_quantizeY2_arrayII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_quantizeY_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXQuantizer']/method[@name='quantizeY' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("quantizeY", "([II)V", "")]
		public unsafe void QuantizeY (int[] p0, int p1)
		{
			if (id_quantizeY_arrayII == IntPtr.Zero)
				id_quantizeY_arrayII = JNIEnv.GetMethodID (class_ref, "quantizeY", "([II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_quantizeY_arrayII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
