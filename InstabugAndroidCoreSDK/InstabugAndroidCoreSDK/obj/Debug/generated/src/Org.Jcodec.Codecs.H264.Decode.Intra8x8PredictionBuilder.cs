using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra8x8PredictionBuilder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/Intra8x8PredictionBuilder", DoNotGenerateAcw=true)]
	public partial class Intra8x8PredictionBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/Intra8x8PredictionBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Intra8x8PredictionBuilder); }
		}

		protected Intra8x8PredictionBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra8x8PredictionBuilder']/constructor[@name='Intra8x8PredictionBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Intra8x8PredictionBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Intra8x8PredictionBuilder)) {
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

		static IntPtr id_copyAdd_arrayIIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra8x8PredictionBuilder']/method[@name='copyAdd' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='int']]"
		[Register ("copyAdd", "([II[II)V", "")]
		public static unsafe void CopyAdd (int[] src, int srcOff, int[] dst, int dstOff)
		{
			if (id_copyAdd_arrayIIarrayII == IntPtr.Zero)
				id_copyAdd_arrayIIarrayII = JNIEnv.GetStaticMethodID (class_ref, "copyAdd", "([II[II)V");
			IntPtr native_src = JNIEnv.NewArray (src);
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_src);
				__args [1] = new JValue (srcOff);
				__args [2] = new JValue (native_dst);
				__args [3] = new JValue (dstOff);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copyAdd_arrayIIarrayII, __args);
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_fillAdd_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra8x8PredictionBuilder']/method[@name='fillAdd' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("fillAdd", "([III)V", "")]
		public static unsafe void FillAdd (int[] dst, int off, int val)
		{
			if (id_fillAdd_arrayIII == IntPtr.Zero)
				id_fillAdd_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "fillAdd", "([III)V");
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_dst);
				__args [1] = new JValue (off);
				__args [2] = new JValue (val);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fillAdd_arrayIII, __args);
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
			}
		}

		static IntPtr id_predictWithMode_IarrayIZZZZarrayIarrayIarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra8x8PredictionBuilder']/method[@name='predictWithMode' and count(parameter)=12 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='int[]'] and parameter[8][@type='int[]'] and parameter[9][@type='int[]'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictWithMode", "(I[IZZZZ[I[I[IIII)V", "")]
		public static unsafe void PredictWithMode (int mode, int[] residual, bool leftAvailable, bool topAvailable, bool topLeftAvailable, bool topRightAvailable, int[] leftRow, int[] topLine, int[] topLeft, int mbOffX, int blkX, int blkY)
		{
			if (id_predictWithMode_IarrayIZZZZarrayIarrayIarrayIIII == IntPtr.Zero)
				id_predictWithMode_IarrayIZZZZarrayIarrayIarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictWithMode", "(I[IZZZZ[I[I[IIII)V");
			IntPtr native_residual = JNIEnv.NewArray (residual);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			IntPtr native_topLeft = JNIEnv.NewArray (topLeft);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (mode);
				__args [1] = new JValue (native_residual);
				__args [2] = new JValue (leftAvailable);
				__args [3] = new JValue (topAvailable);
				__args [4] = new JValue (topLeftAvailable);
				__args [5] = new JValue (topRightAvailable);
				__args [6] = new JValue (native_leftRow);
				__args [7] = new JValue (native_topLine);
				__args [8] = new JValue (native_topLeft);
				__args [9] = new JValue (mbOffX);
				__args [10] = new JValue (blkX);
				__args [11] = new JValue (blkY);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictWithMode_IarrayIZZZZarrayIarrayIarrayIIII, __args);
			} finally {
				if (residual != null) {
					JNIEnv.CopyArray (native_residual, residual);
					JNIEnv.DeleteLocalRef (native_residual);
				}
				if (leftRow != null) {
					JNIEnv.CopyArray (native_leftRow, leftRow);
					JNIEnv.DeleteLocalRef (native_leftRow);
				}
				if (topLine != null) {
					JNIEnv.CopyArray (native_topLine, topLine);
					JNIEnv.DeleteLocalRef (native_topLine);
				}
				if (topLeft != null) {
					JNIEnv.CopyArray (native_topLeft, topLeft);
					JNIEnv.DeleteLocalRef (native_topLeft);
				}
			}
		}

	}
}
