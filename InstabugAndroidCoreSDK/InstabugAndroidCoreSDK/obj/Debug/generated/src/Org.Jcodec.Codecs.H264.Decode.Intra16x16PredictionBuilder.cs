using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra16x16PredictionBuilder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/Intra16x16PredictionBuilder", DoNotGenerateAcw=true)]
	public partial class Intra16x16PredictionBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/Intra16x16PredictionBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Intra16x16PredictionBuilder); }
		}

		protected Intra16x16PredictionBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra16x16PredictionBuilder']/constructor[@name='Intra16x16PredictionBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Intra16x16PredictionBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Intra16x16PredictionBuilder)) {
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

		static IntPtr id_predictDC_arrayIZZarrayIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra16x16PredictionBuilder']/method[@name='predictDC' and count(parameter)=6 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int[]'] and parameter[5][@type='int[]'] and parameter[6][@type='int']]"
		[Register ("predictDC", "([IZZ[I[II)V", "")]
		public static unsafe void PredictDC (int[] residual, bool leftAvailable, bool topAvailable, int[] leftRow, int[] topLine, int x)
		{
			if (id_predictDC_arrayIZZarrayIarrayII == IntPtr.Zero)
				id_predictDC_arrayIZZarrayIarrayII = JNIEnv.GetStaticMethodID (class_ref, "predictDC", "([IZZ[I[II)V");
			IntPtr native_residual = JNIEnv.NewArray (residual);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_residual);
				__args [1] = new JValue (leftAvailable);
				__args [2] = new JValue (topAvailable);
				__args [3] = new JValue (native_leftRow);
				__args [4] = new JValue (native_topLine);
				__args [5] = new JValue (x);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictDC_arrayIZZarrayIarrayII, __args);
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
			}
		}

		static IntPtr id_predictHorizontal_arrayIZarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra16x16PredictionBuilder']/method[@name='predictHorizontal' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='int[]'] and parameter[4][@type='int']]"
		[Register ("predictHorizontal", "([IZ[II)V", "")]
		public static unsafe void PredictHorizontal (int[] residual, bool leftAvailable, int[] leftRow, int x)
		{
			if (id_predictHorizontal_arrayIZarrayII == IntPtr.Zero)
				id_predictHorizontal_arrayIZarrayII = JNIEnv.GetStaticMethodID (class_ref, "predictHorizontal", "([IZ[II)V");
			IntPtr native_residual = JNIEnv.NewArray (residual);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_residual);
				__args [1] = new JValue (leftAvailable);
				__args [2] = new JValue (native_leftRow);
				__args [3] = new JValue (x);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictHorizontal_arrayIZarrayII, __args);
			} finally {
				if (residual != null) {
					JNIEnv.CopyArray (native_residual, residual);
					JNIEnv.DeleteLocalRef (native_residual);
				}
				if (leftRow != null) {
					JNIEnv.CopyArray (native_leftRow, leftRow);
					JNIEnv.DeleteLocalRef (native_leftRow);
				}
			}
		}

		static IntPtr id_predictPlane_arrayIZZarrayIarrayIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra16x16PredictionBuilder']/method[@name='predictPlane' and count(parameter)=7 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int[]'] and parameter[5][@type='int[]'] and parameter[6][@type='int[]'] and parameter[7][@type='int']]"
		[Register ("predictPlane", "([IZZ[I[I[II)V", "")]
		public static unsafe void PredictPlane (int[] residual, bool leftAvailable, bool topAvailable, int[] leftRow, int[] topLine, int[] topLeft, int x)
		{
			if (id_predictPlane_arrayIZZarrayIarrayIarrayII == IntPtr.Zero)
				id_predictPlane_arrayIZZarrayIarrayIarrayII = JNIEnv.GetStaticMethodID (class_ref, "predictPlane", "([IZZ[I[I[II)V");
			IntPtr native_residual = JNIEnv.NewArray (residual);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			IntPtr native_topLeft = JNIEnv.NewArray (topLeft);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_residual);
				__args [1] = new JValue (leftAvailable);
				__args [2] = new JValue (topAvailable);
				__args [3] = new JValue (native_leftRow);
				__args [4] = new JValue (native_topLine);
				__args [5] = new JValue (native_topLeft);
				__args [6] = new JValue (x);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictPlane_arrayIZZarrayIarrayIarrayII, __args);
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

		static IntPtr id_predictVertical_arrayIZarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra16x16PredictionBuilder']/method[@name='predictVertical' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='int[]'] and parameter[4][@type='int']]"
		[Register ("predictVertical", "([IZ[II)V", "")]
		public static unsafe void PredictVertical (int[] residual, bool topAvailable, int[] topLine, int x)
		{
			if (id_predictVertical_arrayIZarrayII == IntPtr.Zero)
				id_predictVertical_arrayIZarrayII = JNIEnv.GetStaticMethodID (class_ref, "predictVertical", "([IZ[II)V");
			IntPtr native_residual = JNIEnv.NewArray (residual);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_residual);
				__args [1] = new JValue (topAvailable);
				__args [2] = new JValue (native_topLine);
				__args [3] = new JValue (x);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictVertical_arrayIZarrayII, __args);
			} finally {
				if (residual != null) {
					JNIEnv.CopyArray (native_residual, residual);
					JNIEnv.DeleteLocalRef (native_residual);
				}
				if (topLine != null) {
					JNIEnv.CopyArray (native_topLine, topLine);
					JNIEnv.DeleteLocalRef (native_topLine);
				}
			}
		}

		static IntPtr id_predictWithMode_IarrayIZZarrayIarrayIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra16x16PredictionBuilder']/method[@name='predictWithMode' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='int[]'] and parameter[6][@type='int[]'] and parameter[7][@type='int[]'] and parameter[8][@type='int']]"
		[Register ("predictWithMode", "(I[IZZ[I[I[II)V", "")]
		public static unsafe void PredictWithMode (int predMode, int[] residual, bool leftAvailable, bool topAvailable, int[] leftRow, int[] topLine, int[] topLeft, int x)
		{
			if (id_predictWithMode_IarrayIZZarrayIarrayIarrayII == IntPtr.Zero)
				id_predictWithMode_IarrayIZZarrayIarrayIarrayII = JNIEnv.GetStaticMethodID (class_ref, "predictWithMode", "(I[IZZ[I[I[II)V");
			IntPtr native_residual = JNIEnv.NewArray (residual);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			IntPtr native_topLeft = JNIEnv.NewArray (topLeft);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (predMode);
				__args [1] = new JValue (native_residual);
				__args [2] = new JValue (leftAvailable);
				__args [3] = new JValue (topAvailable);
				__args [4] = new JValue (native_leftRow);
				__args [5] = new JValue (native_topLine);
				__args [6] = new JValue (native_topLeft);
				__args [7] = new JValue (x);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictWithMode_IarrayIZZarrayIarrayIarrayII, __args);
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
