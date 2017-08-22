using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/CoeffTransformer", DoNotGenerateAcw=true)]
	public partial class CoeffTransformer : global::Java.Lang.Object {


		static IntPtr zigzag4x4_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/field[@name='zigzag4x4']"
		[Register ("zigzag4x4")]
		public static IList<int> Zigzag4x4 {
			get {
				if (zigzag4x4_jfieldId == IntPtr.Zero)
					zigzag4x4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "zigzag4x4", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, zigzag4x4_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (zigzag4x4_jfieldId == IntPtr.Zero)
					zigzag4x4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "zigzag4x4", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, zigzag4x4_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr zigzag8x8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/field[@name='zigzag8x8']"
		[Register ("zigzag8x8")]
		public static IList<int> Zigzag8x8 {
			get {
				if (zigzag8x8_jfieldId == IntPtr.Zero)
					zigzag8x8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "zigzag8x8", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, zigzag8x8_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (zigzag8x8_jfieldId == IntPtr.Zero)
					zigzag8x8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "zigzag8x8", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, zigzag8x8_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/CoeffTransformer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CoeffTransformer); }
		}

		protected CoeffTransformer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayarrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/constructor[@name='CoeffTransformer' and count(parameter)=1 and parameter[1][@type='int[][]']]"
		[Register (".ctor", "([[I)V", "")]
		public unsafe CoeffTransformer (int[][] scalingListMatrix)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_scalingListMatrix = JNIEnv.NewArray (scalingListMatrix);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_scalingListMatrix);
				if (((object) this).GetType () != typeof (CoeffTransformer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([[I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([[I)V", __args);
					return;
				}

				if (id_ctor_arrayarrayI == IntPtr.Zero)
					id_ctor_arrayarrayI = JNIEnv.GetMethodID (class_ref, "<init>", "([[I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayarrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayarrayI, __args);
			} finally {
				if (scalingListMatrix != null) {
					JNIEnv.CopyArray (native_scalingListMatrix, scalingListMatrix);
					JNIEnv.DeleteLocalRef (native_scalingListMatrix);
				}
			}
		}

		static IntPtr id_dequantizeAC_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='dequantizeAC' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("dequantizeAC", "([II)V", "")]
		public static unsafe void DequantizeAC (int[] coeffs, int qp)
		{
			if (id_dequantizeAC_arrayII == IntPtr.Zero)
				id_dequantizeAC_arrayII = JNIEnv.GetStaticMethodID (class_ref, "dequantizeAC", "([II)V");
			IntPtr native_coeffs = JNIEnv.NewArray (coeffs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_coeffs);
				__args [1] = new JValue (qp);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dequantizeAC_arrayII, __args);
			} finally {
				if (coeffs != null) {
					JNIEnv.CopyArray (native_coeffs, coeffs);
					JNIEnv.DeleteLocalRef (native_coeffs);
				}
			}
		}

		static IntPtr id_dequantizeAC8x8_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='dequantizeAC8x8' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("dequantizeAC8x8", "([II)V", "")]
		public static unsafe void DequantizeAC8x8 (int[] coeffs, int qp)
		{
			if (id_dequantizeAC8x8_arrayII == IntPtr.Zero)
				id_dequantizeAC8x8_arrayII = JNIEnv.GetStaticMethodID (class_ref, "dequantizeAC8x8", "([II)V");
			IntPtr native_coeffs = JNIEnv.NewArray (coeffs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_coeffs);
				__args [1] = new JValue (qp);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dequantizeAC8x8_arrayII, __args);
			} finally {
				if (coeffs != null) {
					JNIEnv.CopyArray (native_coeffs, coeffs);
					JNIEnv.DeleteLocalRef (native_coeffs);
				}
			}
		}

		static IntPtr id_dequantizeDC2x2_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='dequantizeDC2x2' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("dequantizeDC2x2", "([II)V", "")]
		public static unsafe void DequantizeDC2x2 (int[] transformed, int qp)
		{
			if (id_dequantizeDC2x2_arrayII == IntPtr.Zero)
				id_dequantizeDC2x2_arrayII = JNIEnv.GetStaticMethodID (class_ref, "dequantizeDC2x2", "([II)V");
			IntPtr native_transformed = JNIEnv.NewArray (transformed);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_transformed);
				__args [1] = new JValue (qp);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dequantizeDC2x2_arrayII, __args);
			} finally {
				if (transformed != null) {
					JNIEnv.CopyArray (native_transformed, transformed);
					JNIEnv.DeleteLocalRef (native_transformed);
				}
			}
		}

		static IntPtr id_dequantizeDC4x2_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='dequantizeDC4x2' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("dequantizeDC4x2", "([II)V", "")]
		public static unsafe void DequantizeDC4x2 (int[] dc, int qp)
		{
			if (id_dequantizeDC4x2_arrayII == IntPtr.Zero)
				id_dequantizeDC4x2_arrayII = JNIEnv.GetStaticMethodID (class_ref, "dequantizeDC4x2", "([II)V");
			IntPtr native_dc = JNIEnv.NewArray (dc);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_dc);
				__args [1] = new JValue (qp);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dequantizeDC4x2_arrayII, __args);
			} finally {
				if (dc != null) {
					JNIEnv.CopyArray (native_dc, dc);
					JNIEnv.DeleteLocalRef (native_dc);
				}
			}
		}

		static IntPtr id_dequantizeDC4x4_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='dequantizeDC4x4' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("dequantizeDC4x4", "([II)V", "")]
		public static unsafe void DequantizeDC4x4 (int[] coeffs, int qp)
		{
			if (id_dequantizeDC4x4_arrayII == IntPtr.Zero)
				id_dequantizeDC4x4_arrayII = JNIEnv.GetStaticMethodID (class_ref, "dequantizeDC4x4", "([II)V");
			IntPtr native_coeffs = JNIEnv.NewArray (coeffs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_coeffs);
				__args [1] = new JValue (qp);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dequantizeDC4x4_arrayII, __args);
			} finally {
				if (coeffs != null) {
					JNIEnv.CopyArray (native_coeffs, coeffs);
					JNIEnv.DeleteLocalRef (native_coeffs);
				}
			}
		}

		static IntPtr id_fdct4x4_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='fdct4x4' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("fdct4x4", "([I)V", "")]
		public static unsafe void Fdct4x4 (int[] block)
		{
			if (id_fdct4x4_arrayI == IntPtr.Zero)
				id_fdct4x4_arrayI = JNIEnv.GetStaticMethodID (class_ref, "fdct4x4", "([I)V");
			IntPtr native_block = JNIEnv.NewArray (block);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_block);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fdct4x4_arrayI, __args);
			} finally {
				if (block != null) {
					JNIEnv.CopyArray (native_block, block);
					JNIEnv.DeleteLocalRef (native_block);
				}
			}
		}

		static IntPtr id_fvdDC2x2_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='fvdDC2x2' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("fvdDC2x2", "([I)V", "")]
		public static unsafe void FvdDC2x2 (int[] block)
		{
			if (id_fvdDC2x2_arrayI == IntPtr.Zero)
				id_fvdDC2x2_arrayI = JNIEnv.GetStaticMethodID (class_ref, "fvdDC2x2", "([I)V");
			IntPtr native_block = JNIEnv.NewArray (block);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_block);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fvdDC2x2_arrayI, __args);
			} finally {
				if (block != null) {
					JNIEnv.CopyArray (native_block, block);
					JNIEnv.DeleteLocalRef (native_block);
				}
			}
		}

		static IntPtr id_fvdDC4x2_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='fvdDC4x2' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("fvdDC4x2", "([I)V", "")]
		public static unsafe void FvdDC4x2 (int[] dc)
		{
			if (id_fvdDC4x2_arrayI == IntPtr.Zero)
				id_fvdDC4x2_arrayI = JNIEnv.GetStaticMethodID (class_ref, "fvdDC4x2", "([I)V");
			IntPtr native_dc = JNIEnv.NewArray (dc);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_dc);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fvdDC4x2_arrayI, __args);
			} finally {
				if (dc != null) {
					JNIEnv.CopyArray (native_dc, dc);
					JNIEnv.DeleteLocalRef (native_dc);
				}
			}
		}

		static IntPtr id_fvdDC4x4_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='fvdDC4x4' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("fvdDC4x4", "([I)V", "")]
		public static unsafe void FvdDC4x4 (int[] scaled)
		{
			if (id_fvdDC4x4_arrayI == IntPtr.Zero)
				id_fvdDC4x4_arrayI = JNIEnv.GetStaticMethodID (class_ref, "fvdDC4x4", "([I)V");
			IntPtr native_scaled = JNIEnv.NewArray (scaled);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_scaled);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fvdDC4x4_arrayI, __args);
			} finally {
				if (scaled != null) {
					JNIEnv.CopyArray (native_scaled, scaled);
					JNIEnv.DeleteLocalRef (native_scaled);
				}
			}
		}

		static IntPtr id_idct4x4_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='idct4x4' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("idct4x4", "([I)V", "")]
		public static unsafe void Idct4x4 (int[] block)
		{
			if (id_idct4x4_arrayI == IntPtr.Zero)
				id_idct4x4_arrayI = JNIEnv.GetStaticMethodID (class_ref, "idct4x4", "([I)V");
			IntPtr native_block = JNIEnv.NewArray (block);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_block);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idct4x4_arrayI, __args);
			} finally {
				if (block != null) {
					JNIEnv.CopyArray (native_block, block);
					JNIEnv.DeleteLocalRef (native_block);
				}
			}
		}

		static IntPtr id_idct4x4_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='idct4x4' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("idct4x4", "([I[I)V", "")]
		public static unsafe void Idct4x4 (int[] block, int[] @out)
		{
			if (id_idct4x4_arrayIarrayI == IntPtr.Zero)
				id_idct4x4_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "idct4x4", "([I[I)V");
			IntPtr native_block = JNIEnv.NewArray (block);
			IntPtr native__out = JNIEnv.NewArray (@out);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_block);
				__args [1] = new JValue (native__out);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idct4x4_arrayIarrayI, __args);
			} finally {
				if (block != null) {
					JNIEnv.CopyArray (native_block, block);
					JNIEnv.DeleteLocalRef (native_block);
				}
				if (@out != null) {
					JNIEnv.CopyArray (native__out, @out);
					JNIEnv.DeleteLocalRef (native__out);
				}
			}
		}

		static IntPtr id_idct8x8_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='idct8x8' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("idct8x8", "([I)V", "")]
		public static unsafe void Idct8x8 (int[] ac)
		{
			if (id_idct8x8_arrayI == IntPtr.Zero)
				id_idct8x8_arrayI = JNIEnv.GetStaticMethodID (class_ref, "idct8x8", "([I)V");
			IntPtr native_ac = JNIEnv.NewArray (ac);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_ac);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idct8x8_arrayI, __args);
			} finally {
				if (ac != null) {
					JNIEnv.CopyArray (native_ac, ac);
					JNIEnv.DeleteLocalRef (native_ac);
				}
			}
		}

		static IntPtr id_invDC2x2_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='invDC2x2' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("invDC2x2", "([I)V", "")]
		public static unsafe void InvDC2x2 (int[] block)
		{
			if (id_invDC2x2_arrayI == IntPtr.Zero)
				id_invDC2x2_arrayI = JNIEnv.GetStaticMethodID (class_ref, "invDC2x2", "([I)V");
			IntPtr native_block = JNIEnv.NewArray (block);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_block);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_invDC2x2_arrayI, __args);
			} finally {
				if (block != null) {
					JNIEnv.CopyArray (native_block, block);
					JNIEnv.DeleteLocalRef (native_block);
				}
			}
		}

		static IntPtr id_invDC4x2_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='invDC4x2' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("invDC4x2", "([I)V", "")]
		public static unsafe void InvDC4x2 (int[] dc)
		{
			if (id_invDC4x2_arrayI == IntPtr.Zero)
				id_invDC4x2_arrayI = JNIEnv.GetStaticMethodID (class_ref, "invDC4x2", "([I)V");
			IntPtr native_dc = JNIEnv.NewArray (dc);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_dc);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_invDC4x2_arrayI, __args);
			} finally {
				if (dc != null) {
					JNIEnv.CopyArray (native_dc, dc);
					JNIEnv.DeleteLocalRef (native_dc);
				}
			}
		}

		static IntPtr id_invDC4x4_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='invDC4x4' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("invDC4x4", "([I)V", "")]
		public static unsafe void InvDC4x4 (int[] scaled)
		{
			if (id_invDC4x4_arrayI == IntPtr.Zero)
				id_invDC4x4_arrayI = JNIEnv.GetStaticMethodID (class_ref, "invDC4x4", "([I)V");
			IntPtr native_scaled = JNIEnv.NewArray (scaled);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_scaled);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_invDC4x4_arrayI, __args);
			} finally {
				if (scaled != null) {
					JNIEnv.CopyArray (native_scaled, scaled);
					JNIEnv.DeleteLocalRef (native_scaled);
				}
			}
		}

		static IntPtr id_quantizeAC_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='quantizeAC' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("quantizeAC", "([II)V", "")]
		public static unsafe void QuantizeAC (int[] coeffs, int qp)
		{
			if (id_quantizeAC_arrayII == IntPtr.Zero)
				id_quantizeAC_arrayII = JNIEnv.GetStaticMethodID (class_ref, "quantizeAC", "([II)V");
			IntPtr native_coeffs = JNIEnv.NewArray (coeffs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_coeffs);
				__args [1] = new JValue (qp);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_quantizeAC_arrayII, __args);
			} finally {
				if (coeffs != null) {
					JNIEnv.CopyArray (native_coeffs, coeffs);
					JNIEnv.DeleteLocalRef (native_coeffs);
				}
			}
		}

		static IntPtr id_quantizeDC2x2_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='quantizeDC2x2' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("quantizeDC2x2", "([II)V", "")]
		public static unsafe void QuantizeDC2x2 (int[] coeffs, int qp)
		{
			if (id_quantizeDC2x2_arrayII == IntPtr.Zero)
				id_quantizeDC2x2_arrayII = JNIEnv.GetStaticMethodID (class_ref, "quantizeDC2x2", "([II)V");
			IntPtr native_coeffs = JNIEnv.NewArray (coeffs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_coeffs);
				__args [1] = new JValue (qp);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_quantizeDC2x2_arrayII, __args);
			} finally {
				if (coeffs != null) {
					JNIEnv.CopyArray (native_coeffs, coeffs);
					JNIEnv.DeleteLocalRef (native_coeffs);
				}
			}
		}

		static IntPtr id_quantizeDC4x2_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='quantizeDC4x2' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("quantizeDC4x2", "([II)V", "")]
		public static unsafe void QuantizeDC4x2 (int[] dc, int qp)
		{
			if (id_quantizeDC4x2_arrayII == IntPtr.Zero)
				id_quantizeDC4x2_arrayII = JNIEnv.GetStaticMethodID (class_ref, "quantizeDC4x2", "([II)V");
			IntPtr native_dc = JNIEnv.NewArray (dc);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_dc);
				__args [1] = new JValue (qp);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_quantizeDC4x2_arrayII, __args);
			} finally {
				if (dc != null) {
					JNIEnv.CopyArray (native_dc, dc);
					JNIEnv.DeleteLocalRef (native_dc);
				}
			}
		}

		static IntPtr id_quantizeDC4x4_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='quantizeDC4x4' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("quantizeDC4x4", "([II)V", "")]
		public static unsafe void QuantizeDC4x4 (int[] coeffs, int qp)
		{
			if (id_quantizeDC4x4_arrayII == IntPtr.Zero)
				id_quantizeDC4x4_arrayII = JNIEnv.GetStaticMethodID (class_ref, "quantizeDC4x4", "([II)V");
			IntPtr native_coeffs = JNIEnv.NewArray (coeffs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_coeffs);
				__args [1] = new JValue (qp);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_quantizeDC4x4_arrayII, __args);
			} finally {
				if (coeffs != null) {
					JNIEnv.CopyArray (native_coeffs, coeffs);
					JNIEnv.DeleteLocalRef (native_coeffs);
				}
			}
		}

		static IntPtr id_reorderDC4x4_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='reorderDC4x4' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("reorderDC4x4", "([I)V", "")]
		public static unsafe void ReorderDC4x4 (int[] dc)
		{
			if (id_reorderDC4x4_arrayI == IntPtr.Zero)
				id_reorderDC4x4_arrayI = JNIEnv.GetStaticMethodID (class_ref, "reorderDC4x4", "([I)V");
			IntPtr native_dc = JNIEnv.NewArray (dc);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_dc);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reorderDC4x4_arrayI, __args);
			} finally {
				if (dc != null) {
					JNIEnv.CopyArray (native_dc, dc);
					JNIEnv.DeleteLocalRef (native_dc);
				}
			}
		}

		static IntPtr id_unzigzagAC_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CoeffTransformer']/method[@name='unzigzagAC' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("unzigzagAC", "([I)[I", "")]
		public static unsafe int[] UnzigzagAC (int[] coeffs)
		{
			if (id_unzigzagAC_arrayI == IntPtr.Zero)
				id_unzigzagAC_arrayI = JNIEnv.GetStaticMethodID (class_ref, "unzigzagAC", "([I)[I");
			IntPtr native_coeffs = JNIEnv.NewArray (coeffs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_coeffs);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_unzigzagAC_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (coeffs != null) {
					JNIEnv.CopyArray (native_coeffs, coeffs);
					JNIEnv.DeleteLocalRef (native_coeffs);
				}
			}
		}

	}
}
