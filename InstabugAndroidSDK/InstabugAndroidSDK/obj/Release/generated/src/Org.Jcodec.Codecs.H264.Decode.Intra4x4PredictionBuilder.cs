using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/Intra4x4PredictionBuilder", DoNotGenerateAcw=true)]
	public partial class Intra4x4PredictionBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/Intra4x4PredictionBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Intra4x4PredictionBuilder); }
		}

		protected Intra4x4PredictionBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']/constructor[@name='Intra4x4PredictionBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Intra4x4PredictionBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Intra4x4PredictionBuilder)) {
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

		static IntPtr id_predictDC_arrayIZZarrayIarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']/method[@name='predictDC' and count(parameter)=8 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int[]'] and parameter[5][@type='int[]'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("predictDC", "([IZZ[I[IIII)V", "")]
		public static unsafe void PredictDC (int[] p0, bool p1, bool p2, int[] p3, int[] p4, int p5, int p6, int p7)
		{
			if (id_predictDC_arrayIZZarrayIarrayIIII == IntPtr.Zero)
				id_predictDC_arrayIZZarrayIarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictDC", "([IZZ[I[IIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictDC_arrayIZZarrayIarrayIIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static IntPtr id_predictDiagonalDownLeft_arrayIZZarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']/method[@name='predictDiagonalDownLeft' and count(parameter)=7 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("predictDiagonalDownLeft", "([IZZ[IIII)V", "")]
		public static unsafe void PredictDiagonalDownLeft (int[] p0, bool p1, bool p2, int[] p3, int p4, int p5, int p6)
		{
			if (id_predictDiagonalDownLeft_arrayIZZarrayIIII == IntPtr.Zero)
				id_predictDiagonalDownLeft_arrayIZZarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictDiagonalDownLeft", "([IZZ[IIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictDiagonalDownLeft_arrayIZZarrayIIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_predictDiagonalDownRight_arrayIZZarrayIarrayIarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']/method[@name='predictDiagonalDownRight' and count(parameter)=9 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int[]'] and parameter[5][@type='int[]'] and parameter[6][@type='int[]'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("predictDiagonalDownRight", "([IZZ[I[I[IIII)V", "")]
		public static unsafe void PredictDiagonalDownRight (int[] p0, bool p1, bool p2, int[] p3, int[] p4, int[] p5, int p6, int p7, int p8)
		{
			if (id_predictDiagonalDownRight_arrayIZZarrayIarrayIarrayIIII == IntPtr.Zero)
				id_predictDiagonalDownRight_arrayIZZarrayIarrayIarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictDiagonalDownRight", "([IZZ[I[I[IIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictDiagonalDownRight_arrayIZZarrayIarrayIarrayIIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		static IntPtr id_predictHorizontal_arrayIZarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']/method[@name='predictHorizontal' and count(parameter)=6 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='int[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("predictHorizontal", "([IZ[IIII)V", "")]
		public static unsafe void PredictHorizontal (int[] p0, bool p1, int[] p2, int p3, int p4, int p5)
		{
			if (id_predictHorizontal_arrayIZarrayIIII == IntPtr.Zero)
				id_predictHorizontal_arrayIZarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictHorizontal", "([IZ[IIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictHorizontal_arrayIZarrayIIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_predictHorizontalDown_arrayIZZarrayIarrayIarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']/method[@name='predictHorizontalDown' and count(parameter)=9 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int[]'] and parameter[5][@type='int[]'] and parameter[6][@type='int[]'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("predictHorizontalDown", "([IZZ[I[I[IIII)V", "")]
		public static unsafe void PredictHorizontalDown (int[] p0, bool p1, bool p2, int[] p3, int[] p4, int[] p5, int p6, int p7, int p8)
		{
			if (id_predictHorizontalDown_arrayIZZarrayIarrayIarrayIIII == IntPtr.Zero)
				id_predictHorizontalDown_arrayIZZarrayIarrayIarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictHorizontalDown", "([IZZ[I[I[IIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictHorizontalDown_arrayIZZarrayIarrayIarrayIIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		static IntPtr id_predictHorizontalUp_arrayIZarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']/method[@name='predictHorizontalUp' and count(parameter)=6 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='int[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("predictHorizontalUp", "([IZ[IIII)V", "")]
		public static unsafe void PredictHorizontalUp (int[] p0, bool p1, int[] p2, int p3, int p4, int p5)
		{
			if (id_predictHorizontalUp_arrayIZarrayIIII == IntPtr.Zero)
				id_predictHorizontalUp_arrayIZarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictHorizontalUp", "([IZ[IIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictHorizontalUp_arrayIZarrayIIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_predictVertical_arrayIZarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']/method[@name='predictVertical' and count(parameter)=6 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='int[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("predictVertical", "([IZ[IIII)V", "")]
		public static unsafe void PredictVertical (int[] p0, bool p1, int[] p2, int p3, int p4, int p5)
		{
			if (id_predictVertical_arrayIZarrayIIII == IntPtr.Zero)
				id_predictVertical_arrayIZarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictVertical", "([IZ[IIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictVertical_arrayIZarrayIIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_predictVerticalLeft_arrayIZZarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']/method[@name='predictVerticalLeft' and count(parameter)=7 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("predictVerticalLeft", "([IZZ[IIII)V", "")]
		public static unsafe void PredictVerticalLeft (int[] p0, bool p1, bool p2, int[] p3, int p4, int p5, int p6)
		{
			if (id_predictVerticalLeft_arrayIZZarrayIIII == IntPtr.Zero)
				id_predictVerticalLeft_arrayIZZarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictVerticalLeft", "([IZZ[IIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictVerticalLeft_arrayIZZarrayIIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_predictVerticalRight_arrayIZZarrayIarrayIarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']/method[@name='predictVerticalRight' and count(parameter)=9 and parameter[1][@type='int[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int[]'] and parameter[5][@type='int[]'] and parameter[6][@type='int[]'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("predictVerticalRight", "([IZZ[I[I[IIII)V", "")]
		public static unsafe void PredictVerticalRight (int[] p0, bool p1, bool p2, int[] p3, int[] p4, int[] p5, int p6, int p7, int p8)
		{
			if (id_predictVerticalRight_arrayIZZarrayIarrayIarrayIIII == IntPtr.Zero)
				id_predictVerticalRight_arrayIZZarrayIarrayIarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictVerticalRight", "([IZZ[I[I[IIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictVerticalRight_arrayIZZarrayIarrayIarrayIIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		static IntPtr id_predictWithMode_IarrayIZZZarrayIarrayIarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra4x4PredictionBuilder']/method[@name='predictWithMode' and count(parameter)=11 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='int[]'] and parameter[7][@type='int[]'] and parameter[8][@type='int[]'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int']]"
		[Register ("predictWithMode", "(I[IZZZ[I[I[IIII)V", "")]
		public static unsafe void PredictWithMode (int p0, int[] p1, bool p2, bool p3, bool p4, int[] p5, int[] p6, int[] p7, int p8, int p9, int p10)
		{
			if (id_predictWithMode_IarrayIZZZarrayIarrayIarrayIIII == IntPtr.Zero)
				id_predictWithMode_IarrayIZZZarrayIarrayIarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictWithMode", "(I[IZZZ[I[I[IIII)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			try {
				JValue* __args = stackalloc JValue [11];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictWithMode_IarrayIZZZarrayIarrayIarrayIIII, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
			}
		}

	}
}
