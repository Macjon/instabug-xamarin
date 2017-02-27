using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CAVLC']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/io/CAVLC", DoNotGenerateAcw=true)]
	public partial class CAVLC : global::Java.Lang.Object {


		static IntPtr NO_ZIGZAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CAVLC']/field[@name='NO_ZIGZAG']"
		[Register ("NO_ZIGZAG")]
		public static IList<int> NoZigzag {
			get {
				if (NO_ZIGZAG_jfieldId == IntPtr.Zero)
					NO_ZIGZAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_ZIGZAG", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, NO_ZIGZAG_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NO_ZIGZAG_jfieldId == IntPtr.Zero)
					NO_ZIGZAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_ZIGZAG", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, NO_ZIGZAG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/io/CAVLC", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CAVLC); }
		}

		protected CAVLC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCoeffTokenVLCForChromaDC;
#pragma warning disable 0169
		static Delegate GetGetCoeffTokenVLCForChromaDCHandler ()
		{
			if (cb_getCoeffTokenVLCForChromaDC == null)
				cb_getCoeffTokenVLCForChromaDC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCoeffTokenVLCForChromaDC);
			return cb_getCoeffTokenVLCForChromaDC;
		}

		static IntPtr n_GetCoeffTokenVLCForChromaDC (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.H264.IO.CAVLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CAVLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CoeffTokenVLCForChromaDC);
		}
#pragma warning restore 0169

		static IntPtr id_getCoeffTokenVLCForChromaDC;
		public virtual unsafe global::Org.Jcodec.Common.IO.VLC CoeffTokenVLCForChromaDC {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CAVLC']/method[@name='getCoeffTokenVLCForChromaDC' and count(parameter)=0]"
			[Register ("getCoeffTokenVLCForChromaDC", "()Lorg/jcodec/common/io/VLC;", "GetGetCoeffTokenVLCForChromaDCHandler")]
			get {
				if (id_getCoeffTokenVLCForChromaDC == IntPtr.Zero)
					id_getCoeffTokenVLCForChromaDC = JNIEnv.GetMethodID (class_ref, "getCoeffTokenVLCForChromaDC", "()Lorg/jcodec/common/io/VLC;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCoeffTokenVLCForChromaDC), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCoeffTokenVLCForChromaDC", "()Lorg/jcodec/common/io/VLC;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_codeTableChromaDC;
#pragma warning disable 0169
		static Delegate GetCodeTableChromaDCHandler ()
		{
			if (cb_codeTableChromaDC == null)
				cb_codeTableChromaDC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CodeTableChromaDC);
			return cb_codeTableChromaDC;
		}

		static IntPtr n_CodeTableChromaDC (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.H264.IO.CAVLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CAVLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CodeTableChromaDC ());
		}
#pragma warning restore 0169

		static IntPtr id_codeTableChromaDC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CAVLC']/method[@name='codeTableChromaDC' and count(parameter)=0]"
		[Register ("codeTableChromaDC", "()Lorg/jcodec/common/io/VLC;", "GetCodeTableChromaDCHandler")]
		protected virtual unsafe global::Org.Jcodec.Common.IO.VLC CodeTableChromaDC ()
		{
			if (id_codeTableChromaDC == IntPtr.Zero)
				id_codeTableChromaDC = JNIEnv.GetMethodID (class_ref, "codeTableChromaDC", "()Lorg/jcodec/common/io/VLC;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_codeTableChromaDC), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "codeTableChromaDC", "()Lorg/jcodec/common/io/VLC;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_coeffToken_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CAVLC']/method[@name='coeffToken' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("coeffToken", "(II)I", "")]
		public static unsafe int CoeffToken (int p0, int p1)
		{
			if (id_coeffToken_II == IntPtr.Zero)
				id_coeffToken_II = JNIEnv.GetStaticMethodID (class_ref, "coeffToken", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_coeffToken_II, __args);
			} finally {
			}
		}

		static Delegate cb_readChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZ;
#pragma warning disable 0169
		static Delegate GetReadChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZHandler ()
		{
			if (cb_readChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZ == null)
				cb_readChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_ReadChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZ);
			return cb_readChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZ;
		}

		static void n_ReadChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, bool p3)
		{
			global::Org.Jcodec.Codecs.H264.IO.CAVLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CAVLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReadChromaDCBlock (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_readChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CAVLC']/method[@name='readChromaDCBlock' and count(parameter)=4 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='int[]'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("readChromaDCBlock", "(Lorg/jcodec/common/io/BitReader;[IZZ)V", "GetReadChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZHandler")]
		public virtual unsafe void ReadChromaDCBlock (global::Org.Jcodec.Common.IO.BitReader p0, int[] p1, bool p2, bool p3)
		{
			if (id_readChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZ == IntPtr.Zero)
				id_readChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZ = JNIEnv.GetMethodID (class_ref, "readChromaDCBlock", "(Lorg/jcodec/common/io/BitReader;[IZZ)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readChromaDCBlock_Lorg_jcodec_common_io_BitReader_arrayIZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readChromaDCBlock", "(Lorg/jcodec/common/io/BitReader;[IZZ)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_readCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayI;
#pragma warning disable 0169
		static Delegate GetReadCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayIHandler ()
		{
			if (cb_readCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayI == null)
				cb_readCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, int>) n_ReadCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayI);
			return cb_readCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayI;
		}

		static int n_ReadCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, int p5, IntPtr native_p6)
		{
			global::Org.Jcodec.Codecs.H264.IO.CAVLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CAVLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.VLC p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.VLC[] p2 = (global::Org.Jcodec.Common.IO.VLC[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Common.IO.VLC));
			int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p6 = (int[]) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.ReadCoeffs (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CAVLC']/method[@name='readCoeffs' and count(parameter)=7 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='org.jcodec.common.io.VLC'] and parameter[3][@type='org.jcodec.common.io.VLC[]'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int[]']]"
		[Register ("readCoeffs", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/common/io/VLC;[Lorg/jcodec/common/io/VLC;[III[I)I", "GetReadCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayIHandler")]
		public virtual unsafe int ReadCoeffs (global::Org.Jcodec.Common.IO.BitReader p0, global::Org.Jcodec.Common.IO.VLC p1, global::Org.Jcodec.Common.IO.VLC[] p2, int[] p3, int p4, int p5, int[] p6)
		{
			if (id_readCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayI == IntPtr.Zero)
				id_readCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayI = JNIEnv.GetMethodID (class_ref, "readCoeffs", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/common/io/VLC;[Lorg/jcodec/common/io/VLC;[III[I)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readCoeffs_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayLorg_jcodec_common_io_VLC_arrayIIIarrayI, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readCoeffs", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/common/io/VLC;[Lorg/jcodec/common/io/VLC;[III[I)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}
		}

		static Delegate cb_setZeroCoeff_II;
#pragma warning disable 0169
		static Delegate GetSetZeroCoeff_IIHandler ()
		{
			if (cb_setZeroCoeff_II == null)
				cb_setZeroCoeff_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetZeroCoeff_II);
			return cb_setZeroCoeff_II;
		}

		static void n_SetZeroCoeff_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Jcodec.Codecs.H264.IO.CAVLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CAVLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZeroCoeff (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setZeroCoeff_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CAVLC']/method[@name='setZeroCoeff' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setZeroCoeff", "(II)V", "GetSetZeroCoeff_IIHandler")]
		public virtual unsafe void SetZeroCoeff (int p0, int p1)
		{
			if (id_setZeroCoeff_II == IntPtr.Zero)
				id_setZeroCoeff_II = JNIEnv.GetMethodID (class_ref, "setZeroCoeff", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZeroCoeff_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZeroCoeff", "(II)V"), __args);
			} finally {
			}
		}

		static IntPtr id_totalCoeff_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CAVLC']/method[@name='totalCoeff' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("totalCoeff", "(I)I", "")]
		public static unsafe int TotalCoeff (int p0)
		{
			if (id_totalCoeff_I == IntPtr.Zero)
				id_totalCoeff_I = JNIEnv.GetStaticMethodID (class_ref, "totalCoeff", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_totalCoeff_I, __args);
			} finally {
			}
		}

		static IntPtr id_trailingOnes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CAVLC']/method[@name='trailingOnes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("trailingOnes", "(I)I", "")]
		public static unsafe int TrailingOnes (int p0)
		{
			if (id_trailingOnes_I == IntPtr.Zero)
				id_trailingOnes_I = JNIEnv.GetStaticMethodID (class_ref, "trailingOnes", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_trailingOnes_I, __args);
			} finally {
			}
		}

		static Delegate cb_writeChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayI;
#pragma warning disable 0169
		static Delegate GetWriteChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayIHandler ()
		{
			if (cb_writeChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayI == null)
				cb_writeChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_WriteChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayI);
			return cb_writeChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayI;
		}

		static void n_WriteChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5)
		{
			global::Org.Jcodec.Codecs.H264.IO.CAVLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.IO.CAVLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitWriter p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Jcodec.Common.IO.VLC[] p2 = (global::Org.Jcodec.Common.IO.VLC[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Common.IO.VLC));
			int[] p5 = (int[]) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.WriteChrDCBlock (p0, p1, p2, p3, p4, p5);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
		}
#pragma warning restore 0169

		static IntPtr id_writeChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io']/class[@name='CAVLC']/method[@name='writeChrDCBlock' and count(parameter)=6 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='int[]'] and parameter[3][@type='org.jcodec.common.io.VLC[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int[]']]"
		[Register ("writeChrDCBlock", "(Lorg/jcodec/common/io/BitWriter;[I[Lorg/jcodec/common/io/VLC;II[I)V", "GetWriteChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayIHandler")]
		public virtual unsafe void WriteChrDCBlock (global::Org.Jcodec.Common.IO.BitWriter p0, int[] p1, global::Org.Jcodec.Common.IO.VLC[] p2, int p3, int p4, int[] p5)
		{
			if (id_writeChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayI == IntPtr.Zero)
				id_writeChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayI = JNIEnv.GetMethodID (class_ref, "writeChrDCBlock", "(Lorg/jcodec/common/io/BitWriter;[I[Lorg/jcodec/common/io/VLC;II[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeChrDCBlock_Lorg_jcodec_common_io_BitWriter_arrayIarrayLorg_jcodec_common_io_VLC_IIarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeChrDCBlock", "(Lorg/jcodec/common/io/BitWriter;[I[Lorg/jcodec/common/io/VLC;II[I)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

	}
}
