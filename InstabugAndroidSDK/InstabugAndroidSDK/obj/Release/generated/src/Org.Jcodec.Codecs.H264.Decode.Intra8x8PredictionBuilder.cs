using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra8x8PredictionBuilder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/Intra8x8PredictionBuilder", DoNotGenerateAcw=true)]
	public partial class Intra8x8PredictionBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
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
				if (GetType () != typeof (Intra8x8PredictionBuilder)) {
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

		static IntPtr id_copyAdd_arrayIIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra8x8PredictionBuilder']/method[@name='copyAdd' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='int']]"
		[Register ("copyAdd", "([II[II)V", "")]
		public static unsafe void CopyAdd (int[] p0, int p1, int[] p2, int p3)
		{
			if (id_copyAdd_arrayIIarrayII == IntPtr.Zero)
				id_copyAdd_arrayIIarrayII = JNIEnv.GetStaticMethodID (class_ref, "copyAdd", "([II[II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copyAdd_arrayIIarrayII, __args);
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

		static IntPtr id_fillAdd_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra8x8PredictionBuilder']/method[@name='fillAdd' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("fillAdd", "([III)V", "")]
		public static unsafe void FillAdd (int[] p0, int p1, int p2)
		{
			if (id_fillAdd_arrayIII == IntPtr.Zero)
				id_fillAdd_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "fillAdd", "([III)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fillAdd_arrayIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_predictWithMode_IarrayIZZZZarrayIarrayIarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='Intra8x8PredictionBuilder']/method[@name='predictWithMode' and count(parameter)=12 and parameter[1][@type='int'] and parameter[2][@type='int[]'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='int[]'] and parameter[8][@type='int[]'] and parameter[9][@type='int[]'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictWithMode", "(I[IZZZZ[I[I[IIII)V", "")]
		public static unsafe void PredictWithMode (int p0, int[] p1, bool p2, bool p3, bool p4, bool p5, int[] p6, int[] p7, int[] p8, int p9, int p10, int p11)
		{
			if (id_predictWithMode_IarrayIZZZZarrayIarrayIarrayIIII == IntPtr.Zero)
				id_predictWithMode_IarrayIZZZZarrayIarrayIarrayIIII = JNIEnv.GetStaticMethodID (class_ref, "predictWithMode", "(I[IZZZZ[I[I[IIII)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			IntPtr native_p8 = JNIEnv.NewArray (p8);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (native_p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				__args [11] = new JValue (p11);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_predictWithMode_IarrayIZZZZarrayIarrayIarrayIIII, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
				if (p8 != null) {
					JNIEnv.CopyArray (native_p8, p8);
					JNIEnv.DeleteLocalRef (native_p8);
				}
			}
		}

	}
}
