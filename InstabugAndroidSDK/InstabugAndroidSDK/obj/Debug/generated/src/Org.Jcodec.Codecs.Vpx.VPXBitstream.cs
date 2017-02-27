using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vpx {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXBitstream']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vpx/VPXBitstream", DoNotGenerateAcw=true)]
	public partial class VPXBitstream : global::Java.Lang.Object {


		static IntPtr coeffBandMapping_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXBitstream']/field[@name='coeffBandMapping']"
		[Register ("coeffBandMapping")]
		public static IList<int> CoeffBandMapping {
			get {
				if (coeffBandMapping_jfieldId == IntPtr.Zero)
					coeffBandMapping_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "coeffBandMapping", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, coeffBandMapping_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vpx/VPXBitstream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VPXBitstream); }
		}

		protected VPXBitstream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayarrayarrayarrayII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXBitstream']/constructor[@name='VPXBitstream' and count(parameter)=2 and parameter[1][@type='int[][][][]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([[[[II)V", "")]
		public unsafe VPXBitstream (int[][][][] p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (VPXBitstream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([[[[II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([[[[II)V", __args);
					return;
				}

				if (id_ctor_arrayarrayarrayarrayII == IntPtr.Zero)
					id_ctor_arrayarrayarrayarrayII = JNIEnv.GetMethodID (class_ref, "<init>", "([[[[II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayarrayarrayarrayII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayarrayarrayarrayII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_encodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII;
#pragma warning disable 0169
		static Delegate GetEncodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIIIHandler ()
		{
			if (cb_encodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII == null)
				cb_encodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int>) n_EncodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII);
			return cb_encodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII;
		}

		static void n_EncodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, int p5)
		{
			global::Org.Jcodec.Codecs.Vpx.VPXBitstream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.VPXBitstream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.EncodeCoeffs (p0, p1, p2, p3, p4, p5);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXBitstream']/method[@name='encodeCoeffs' and count(parameter)=6 and parameter[1][@type='org.jcodec.codecs.common.biari.VPxBooleanEncoder'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("encodeCoeffs", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIIII)V", "GetEncodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIIIHandler")]
		public virtual unsafe void EncodeCoeffs (global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder p0, int[] p1, int p2, int p3, int p4, int p5)
		{
			if (id_encodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII == IntPtr.Zero)
				id_encodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII = JNIEnv.GetMethodID (class_ref, "encodeCoeffs", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIIII)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeCoeffs_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeCoeffs", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIIII)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_encodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII;
#pragma warning disable 0169
		static Delegate GetEncodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIIHandler ()
		{
			if (cb_encodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII == null)
				cb_encodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int>) n_EncodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII);
			return cb_encodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII;
		}

		static void n_EncodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4)
		{
			global::Org.Jcodec.Codecs.Vpx.VPXBitstream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.VPXBitstream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.EncodeCoeffsDCT15 (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXBitstream']/method[@name='encodeCoeffsDCT15' and count(parameter)=5 and parameter[1][@type='org.jcodec.codecs.common.biari.VPxBooleanEncoder'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("encodeCoeffsDCT15", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIII)V", "GetEncodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIIHandler")]
		public virtual unsafe void EncodeCoeffsDCT15 (global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder p0, int[] p1, int p2, int p3, int p4)
		{
			if (id_encodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII == IntPtr.Zero)
				id_encodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII = JNIEnv.GetMethodID (class_ref, "encodeCoeffsDCT15", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIII)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeCoeffsDCT15_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeCoeffsDCT15", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIII)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_encodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII;
#pragma warning disable 0169
		static Delegate GetEncodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIIHandler ()
		{
			if (cb_encodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII == null)
				cb_encodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int>) n_EncodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII);
			return cb_encodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII;
		}

		static void n_EncodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4)
		{
			global::Org.Jcodec.Codecs.Vpx.VPXBitstream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.VPXBitstream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.EncodeCoeffsDCT16 (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXBitstream']/method[@name='encodeCoeffsDCT16' and count(parameter)=5 and parameter[1][@type='org.jcodec.codecs.common.biari.VPxBooleanEncoder'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("encodeCoeffsDCT16", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIII)V", "GetEncodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIIHandler")]
		public virtual unsafe void EncodeCoeffsDCT16 (global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder p0, int[] p1, int p2, int p3, int p4)
		{
			if (id_encodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII == IntPtr.Zero)
				id_encodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII = JNIEnv.GetMethodID (class_ref, "encodeCoeffsDCT16", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIII)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeCoeffsDCT16_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeCoeffsDCT16", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIII)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_encodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII;
#pragma warning disable 0169
		static Delegate GetEncodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIIIHandler ()
		{
			if (cb_encodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII == null)
				cb_encodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int>) n_EncodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII);
			return cb_encodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII;
		}

		static void n_EncodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, int p5)
		{
			global::Org.Jcodec.Codecs.Vpx.VPXBitstream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.VPXBitstream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.EncodeCoeffsDCTUV (p0, p1, p2, p3, p4, p5);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXBitstream']/method[@name='encodeCoeffsDCTUV' and count(parameter)=6 and parameter[1][@type='org.jcodec.codecs.common.biari.VPxBooleanEncoder'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("encodeCoeffsDCTUV", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIIII)V", "GetEncodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIIIHandler")]
		public virtual unsafe void EncodeCoeffsDCTUV (global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder p0, int[] p1, int p2, int p3, int p4, int p5)
		{
			if (id_encodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII == IntPtr.Zero)
				id_encodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII = JNIEnv.GetMethodID (class_ref, "encodeCoeffsDCTUV", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIIII)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeCoeffsDCTUV_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeCoeffsDCTUV", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[IIIII)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_encodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayII;
#pragma warning disable 0169
		static Delegate GetEncodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIHandler ()
		{
			if (cb_encodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayII == null)
				cb_encodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_EncodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayII);
			return cb_encodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayII;
		}

		static void n_EncodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Org.Jcodec.Codecs.Vpx.VPXBitstream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.VPXBitstream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.EncodeCoeffsWHT (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXBitstream']/method[@name='encodeCoeffsWHT' and count(parameter)=3 and parameter[1][@type='org.jcodec.codecs.common.biari.VPxBooleanEncoder'] and parameter[2][@type='int[]'] and parameter[3][@type='int']]"
		[Register ("encodeCoeffsWHT", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[II)V", "GetEncodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayIIHandler")]
		public virtual unsafe void EncodeCoeffsWHT (global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder p0, int[] p1, int p2)
		{
			if (id_encodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayII == IntPtr.Zero)
				id_encodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayII = JNIEnv.GetMethodID (class_ref, "encodeCoeffsWHT", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[II)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeCoeffsWHT_Lorg_jcodec_codecs_common_biari_VPxBooleanEncoder_arrayII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeCoeffsWHT", "(Lorg/jcodec/codecs/common/biari/VPxBooleanEncoder;[II)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
