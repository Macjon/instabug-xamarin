using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegDecoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mjpeg/JpegDecoder", DoNotGenerateAcw=true)]
	public partial class JpegDecoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mjpeg/JpegDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JpegDecoder); }
		}

		protected JpegDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegDecoder']/constructor[@name='JpegDecoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JpegDecoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JpegDecoder)) {
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

		static IntPtr id_ctor_ZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegDecoder']/constructor[@name='JpegDecoder' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(ZZ)V", "")]
		public unsafe JpegDecoder (bool p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (JpegDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZZ)V", __args),
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

		static Delegate cb_decodeField_Ljava_nio_ByteBuffer_arrayarrayIII;
#pragma warning disable 0169
		static Delegate GetDecodeField_Ljava_nio_ByteBuffer_arrayarrayIIIHandler ()
		{
			if (cb_decodeField_Ljava_nio_ByteBuffer_arrayarrayIII == null)
				cb_decodeField_Ljava_nio_ByteBuffer_arrayarrayIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_DecodeField_Ljava_nio_ByteBuffer_arrayarrayIII);
			return cb_decodeField_Ljava_nio_ByteBuffer_arrayarrayIII;
		}

		static IntPtr n_DecodeField_Ljava_nio_ByteBuffer_arrayarrayIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Org.Jcodec.Codecs.Mjpeg.JpegDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mjpeg.JpegDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[][] p1 = (int[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeField (p0, p1, p2, p3));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeField_Ljava_nio_ByteBuffer_arrayarrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegDecoder']/method[@name='decodeField' and count(parameter)=4 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[][]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("decodeField", "(Ljava/nio/ByteBuffer;[[III)Lorg/jcodec/common/model/Picture;", "GetDecodeField_Ljava_nio_ByteBuffer_arrayarrayIIIHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture DecodeField (global::Java.Nio.ByteBuffer p0, int[][] p1, int p2, int p3)
		{
			if (id_decodeField_Ljava_nio_ByteBuffer_arrayarrayIII == IntPtr.Zero)
				id_decodeField_Ljava_nio_ByteBuffer_arrayarrayIII = JNIEnv.GetMethodID (class_ref, "decodeField", "(Ljava/nio/ByteBuffer;[[III)Lorg/jcodec/common/model/Picture;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Org.Jcodec.Common.Model.Picture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeField_Ljava_nio_ByteBuffer_arrayarrayIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeField", "(Ljava/nio/ByteBuffer;[[III)Lorg/jcodec/common/model/Picture;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI;
#pragma warning disable 0169
		static Delegate GetDecodeFrame_Ljava_nio_ByteBuffer_arrayarrayIHandler ()
		{
			if (cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI == null)
				cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeFrame_Ljava_nio_ByteBuffer_arrayarrayI);
			return cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI;
		}

		static IntPtr n_DecodeFrame_Ljava_nio_ByteBuffer_arrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Mjpeg.JpegDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mjpeg.JpegDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[][] p1 = (int[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeFrame (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegDecoder']/method[@name='decodeFrame' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[][]']]"
		[Register ("decodeFrame", "(Ljava/nio/ByteBuffer;[[I)Lorg/jcodec/common/model/Picture;", "GetDecodeFrame_Ljava_nio_ByteBuffer_arrayarrayIHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture DecodeFrame (global::Java.Nio.ByteBuffer p0, int[][] p1)
		{
			if (id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI == IntPtr.Zero)
				id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI = JNIEnv.GetMethodID (class_ref, "decodeFrame", "(Ljava/nio/ByteBuffer;[[I)Lorg/jcodec/common/model/Picture;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Org.Jcodec.Common.Model.Picture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeFrame", "(Ljava/nio/ByteBuffer;[[I)Lorg/jcodec/common/model/Picture;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_probe_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetProbe_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_probe_Ljava_nio_ByteBuffer_ == null)
				cb_probe_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Probe_Ljava_nio_ByteBuffer_);
			return cb_probe_Ljava_nio_ByteBuffer_;
		}

		static int n_Probe_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Mjpeg.JpegDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mjpeg.JpegDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Probe (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_probe_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegDecoder']/method[@name='probe' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("probe", "(Ljava/nio/ByteBuffer;)I", "GetProbe_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe int Probe (global::Java.Nio.ByteBuffer p0)
		{
			if (id_probe_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_probe_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "probe", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_probe_Ljava_nio_ByteBuffer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "probe", "(Ljava/nio/ByteBuffer;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toValue_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegDecoder']/method[@name='toValue' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("toValue", "(II)I", "")]
		public static unsafe int ToValue (int p0, int p1)
		{
			if (id_toValue_II == IntPtr.Zero)
				id_toValue_II = JNIEnv.GetStaticMethodID (class_ref, "toValue", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_toValue_II, __args);
			} finally {
			}
		}

	}
}
