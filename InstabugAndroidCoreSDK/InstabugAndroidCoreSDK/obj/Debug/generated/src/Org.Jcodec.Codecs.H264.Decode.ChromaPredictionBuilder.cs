using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='ChromaPredictionBuilder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/ChromaPredictionBuilder", DoNotGenerateAcw=true)]
	public partial class ChromaPredictionBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/ChromaPredictionBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChromaPredictionBuilder); }
		}

		protected ChromaPredictionBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='ChromaPredictionBuilder']/constructor[@name='ChromaPredictionBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChromaPredictionBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ChromaPredictionBuilder)) {
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

		static IntPtr id_predictDC_arrayIIZZarrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='ChromaPredictionBuilder']/method[@name='predictDC' and count(parameter)=6 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='int[]'] and parameter[6][@type='int[]']]"
		[Register ("predictDC", "([IIZZ[I[I)V", "")]
		public static unsafe void PredictDC (int[] planeData, int mbX, bool leftAvailable, bool topAvailable, int[] leftRow, int[] topLine)
		{
			if (id_predictDC_arrayIIZZarrayIarrayI == IntPtr.Zero)
				id_predictDC_arrayIIZZarrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictDC", "([IIZZ[I[I)V");
			IntPtr native_planeData = JNIEnv.NewArray (planeData);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_planeData);
				__args [1] = new JValue (mbX);
				__args [2] = new JValue (leftAvailable);
				__args [3] = new JValue (topAvailable);
				__args [4] = new JValue (native_leftRow);
				__args [5] = new JValue (native_topLine);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictDC_arrayIIZZarrayIarrayI, __args);
			} finally {
				if (planeData != null) {
					JNIEnv.CopyArray (native_planeData, planeData);
					JNIEnv.DeleteLocalRef (native_planeData);
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

		static IntPtr id_predictDCInside_arrayIIIIZZarrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='ChromaPredictionBuilder']/method[@name='predictDCInside' and count(parameter)=8 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='int[]'] and parameter[8][@type='int[]']]"
		[Register ("predictDCInside", "([IIIIZZ[I[I)V", "")]
		public static unsafe void PredictDCInside (int[] planeData, int blkX, int blkY, int mbX, bool leftAvailable, bool topAvailable, int[] leftRow, int[] topLine)
		{
			if (id_predictDCInside_arrayIIIIZZarrayIarrayI == IntPtr.Zero)
				id_predictDCInside_arrayIIIIZZarrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictDCInside", "([IIIIZZ[I[I)V");
			IntPtr native_planeData = JNIEnv.NewArray (planeData);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_planeData);
				__args [1] = new JValue (blkX);
				__args [2] = new JValue (blkY);
				__args [3] = new JValue (mbX);
				__args [4] = new JValue (leftAvailable);
				__args [5] = new JValue (topAvailable);
				__args [6] = new JValue (native_leftRow);
				__args [7] = new JValue (native_topLine);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictDCInside_arrayIIIIZZarrayIarrayI, __args);
			} finally {
				if (planeData != null) {
					JNIEnv.CopyArray (native_planeData, planeData);
					JNIEnv.DeleteLocalRef (native_planeData);
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

		static IntPtr id_predictDCLeftBorder_arrayIIIIZZarrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='ChromaPredictionBuilder']/method[@name='predictDCLeftBorder' and count(parameter)=8 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='int[]'] and parameter[8][@type='int[]']]"
		[Register ("predictDCLeftBorder", "([IIIIZZ[I[I)V", "")]
		public static unsafe void PredictDCLeftBorder (int[] planeData, int blkX, int blkY, int mbX, bool leftAvailable, bool topAvailable, int[] leftRow, int[] topLine)
		{
			if (id_predictDCLeftBorder_arrayIIIIZZarrayIarrayI == IntPtr.Zero)
				id_predictDCLeftBorder_arrayIIIIZZarrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictDCLeftBorder", "([IIIIZZ[I[I)V");
			IntPtr native_planeData = JNIEnv.NewArray (planeData);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_planeData);
				__args [1] = new JValue (blkX);
				__args [2] = new JValue (blkY);
				__args [3] = new JValue (mbX);
				__args [4] = new JValue (leftAvailable);
				__args [5] = new JValue (topAvailable);
				__args [6] = new JValue (native_leftRow);
				__args [7] = new JValue (native_topLine);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictDCLeftBorder_arrayIIIIZZarrayIarrayI, __args);
			} finally {
				if (planeData != null) {
					JNIEnv.CopyArray (native_planeData, planeData);
					JNIEnv.DeleteLocalRef (native_planeData);
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

		static IntPtr id_predictDCTopBorder_arrayIIIIZZarrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='ChromaPredictionBuilder']/method[@name='predictDCTopBorder' and count(parameter)=8 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='int[]'] and parameter[8][@type='int[]']]"
		[Register ("predictDCTopBorder", "([IIIIZZ[I[I)V", "")]
		public static unsafe void PredictDCTopBorder (int[] planeData, int blkX, int blkY, int mbX, bool leftAvailable, bool topAvailable, int[] leftRow, int[] topLine)
		{
			if (id_predictDCTopBorder_arrayIIIIZZarrayIarrayI == IntPtr.Zero)
				id_predictDCTopBorder_arrayIIIIZZarrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictDCTopBorder", "([IIIIZZ[I[I)V");
			IntPtr native_planeData = JNIEnv.NewArray (planeData);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_planeData);
				__args [1] = new JValue (blkX);
				__args [2] = new JValue (blkY);
				__args [3] = new JValue (mbX);
				__args [4] = new JValue (leftAvailable);
				__args [5] = new JValue (topAvailable);
				__args [6] = new JValue (native_leftRow);
				__args [7] = new JValue (native_topLine);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictDCTopBorder_arrayIIIIZZarrayIarrayI, __args);
			} finally {
				if (planeData != null) {
					JNIEnv.CopyArray (native_planeData, planeData);
					JNIEnv.DeleteLocalRef (native_planeData);
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

		static IntPtr id_predictHorizontal_arrayIIZarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='ChromaPredictionBuilder']/method[@name='predictHorizontal' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int[]']]"
		[Register ("predictHorizontal", "([IIZ[I)V", "")]
		public static unsafe void PredictHorizontal (int[] planeData, int mbX, bool leftAvailable, int[] leftRow)
		{
			if (id_predictHorizontal_arrayIIZarrayI == IntPtr.Zero)
				id_predictHorizontal_arrayIIZarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictHorizontal", "([IIZ[I)V");
			IntPtr native_planeData = JNIEnv.NewArray (planeData);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_planeData);
				__args [1] = new JValue (mbX);
				__args [2] = new JValue (leftAvailable);
				__args [3] = new JValue (native_leftRow);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictHorizontal_arrayIIZarrayI, __args);
			} finally {
				if (planeData != null) {
					JNIEnv.CopyArray (native_planeData, planeData);
					JNIEnv.DeleteLocalRef (native_planeData);
				}
				if (leftRow != null) {
					JNIEnv.CopyArray (native_leftRow, leftRow);
					JNIEnv.DeleteLocalRef (native_leftRow);
				}
			}
		}

		static IntPtr id_predictPlane_arrayIIZZarrayIarrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='ChromaPredictionBuilder']/method[@name='predictPlane' and count(parameter)=7 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='int[]'] and parameter[6][@type='int[]'] and parameter[7][@type='int[]']]"
		[Register ("predictPlane", "([IIZZ[I[I[I)V", "")]
		public static unsafe void PredictPlane (int[] planeData, int mbX, bool leftAvailable, bool topAvailable, int[] leftRow, int[] topLine, int[] topLeft)
		{
			if (id_predictPlane_arrayIIZZarrayIarrayIarrayI == IntPtr.Zero)
				id_predictPlane_arrayIIZZarrayIarrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictPlane", "([IIZZ[I[I[I)V");
			IntPtr native_planeData = JNIEnv.NewArray (planeData);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			IntPtr native_topLeft = JNIEnv.NewArray (topLeft);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_planeData);
				__args [1] = new JValue (mbX);
				__args [2] = new JValue (leftAvailable);
				__args [3] = new JValue (topAvailable);
				__args [4] = new JValue (native_leftRow);
				__args [5] = new JValue (native_topLine);
				__args [6] = new JValue (native_topLeft);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictPlane_arrayIIZZarrayIarrayIarrayI, __args);
			} finally {
				if (planeData != null) {
					JNIEnv.CopyArray (native_planeData, planeData);
					JNIEnv.DeleteLocalRef (native_planeData);
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

		static IntPtr id_predictVertical_arrayIIZarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='ChromaPredictionBuilder']/method[@name='predictVertical' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int[]']]"
		[Register ("predictVertical", "([IIZ[I)V", "")]
		public static unsafe void PredictVertical (int[] planeData, int mbX, bool topAvailable, int[] topLine)
		{
			if (id_predictVertical_arrayIIZarrayI == IntPtr.Zero)
				id_predictVertical_arrayIIZarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictVertical", "([IIZ[I)V");
			IntPtr native_planeData = JNIEnv.NewArray (planeData);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_planeData);
				__args [1] = new JValue (mbX);
				__args [2] = new JValue (topAvailable);
				__args [3] = new JValue (native_topLine);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictVertical_arrayIIZarrayI, __args);
			} finally {
				if (planeData != null) {
					JNIEnv.CopyArray (native_planeData, planeData);
					JNIEnv.DeleteLocalRef (native_planeData);
				}
				if (topLine != null) {
					JNIEnv.CopyArray (native_topLine, topLine);
					JNIEnv.DeleteLocalRef (native_topLine);
				}
			}
		}

		static IntPtr id_predictWithMode_arrayIIIZZarrayIarrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='ChromaPredictionBuilder']/method[@name='predictWithMode' and count(parameter)=8 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='int[]'] and parameter[7][@type='int[]'] and parameter[8][@type='int[]']]"
		[Register ("predictWithMode", "([IIIZZ[I[I[I)V", "")]
		public static unsafe void PredictWithMode (int[] planeData, int chromaMode, int mbX, bool leftAvailable, bool topAvailable, int[] leftRow, int[] topLine, int[] topLeft)
		{
			if (id_predictWithMode_arrayIIIZZarrayIarrayIarrayI == IntPtr.Zero)
				id_predictWithMode_arrayIIIZZarrayIarrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictWithMode", "([IIIZZ[I[I[I)V");
			IntPtr native_planeData = JNIEnv.NewArray (planeData);
			IntPtr native_leftRow = JNIEnv.NewArray (leftRow);
			IntPtr native_topLine = JNIEnv.NewArray (topLine);
			IntPtr native_topLeft = JNIEnv.NewArray (topLeft);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_planeData);
				__args [1] = new JValue (chromaMode);
				__args [2] = new JValue (mbX);
				__args [3] = new JValue (leftAvailable);
				__args [4] = new JValue (topAvailable);
				__args [5] = new JValue (native_leftRow);
				__args [6] = new JValue (native_topLine);
				__args [7] = new JValue (native_topLeft);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictWithMode_arrayIIIZZarrayIarrayIarrayI, __args);
			} finally {
				if (planeData != null) {
					JNIEnv.CopyArray (native_planeData, planeData);
					JNIEnv.DeleteLocalRef (native_planeData);
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
