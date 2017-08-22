using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='SliceDecoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/SliceDecoder", DoNotGenerateAcw=true)]
	public partial class SliceDecoder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/SliceDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SliceDecoder); }
		}

		protected SliceDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_calcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZII;
#pragma warning disable 0169
		static Delegate GetCalcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZIIHandler ()
		{
			if (cb_calcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZII == null)
				cb_calcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, bool, bool, int, int, int>) n_CalcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZII);
			return cb_calcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZII;
		}

		static int n_CalcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZII (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b, IntPtr native_c, IntPtr native_d, bool aAvb, bool bAvb, bool cAvb, bool dAvb, int refIdx, int comp)
		{
			global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] a = (int[]) JNIEnv.GetArray (native_a, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] b = (int[]) JNIEnv.GetArray (native_b, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] c = (int[]) JNIEnv.GetArray (native_c, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] d = (int[]) JNIEnv.GetArray (native_d, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.CalcMVPrediction16x8Bottom (a, b, c, d, aAvb, bAvb, cAvb, dAvb, refIdx, comp);
			if (a != null)
				JNIEnv.CopyArray (a, native_a);
			if (b != null)
				JNIEnv.CopyArray (b, native_b);
			if (c != null)
				JNIEnv.CopyArray (c, native_c);
			if (d != null)
				JNIEnv.CopyArray (d, native_d);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='SliceDecoder']/method[@name='calcMVPrediction16x8Bottom' and count(parameter)=10 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='int[]'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("calcMVPrediction16x8Bottom", "([I[I[I[IZZZZII)I", "GetCalcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZIIHandler")]
		public virtual unsafe int CalcMVPrediction16x8Bottom (int[] a, int[] b, int[] c, int[] d, bool aAvb, bool bAvb, bool cAvb, bool dAvb, int refIdx, int comp)
		{
			if (id_calcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZII == IntPtr.Zero)
				id_calcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZII = JNIEnv.GetMethodID (class_ref, "calcMVPrediction16x8Bottom", "([I[I[I[IZZZZII)I");
			IntPtr native_a = JNIEnv.NewArray (a);
			IntPtr native_b = JNIEnv.NewArray (b);
			IntPtr native_c = JNIEnv.NewArray (c);
			IntPtr native_d = JNIEnv.NewArray (d);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_a);
				__args [1] = new JValue (native_b);
				__args [2] = new JValue (native_c);
				__args [3] = new JValue (native_d);
				__args [4] = new JValue (aAvb);
				__args [5] = new JValue (bAvb);
				__args [6] = new JValue (cAvb);
				__args [7] = new JValue (dAvb);
				__args [8] = new JValue (refIdx);
				__args [9] = new JValue (comp);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcMVPrediction16x8Bottom_arrayIarrayIarrayIarrayIZZZZII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calcMVPrediction16x8Bottom", "([I[I[I[IZZZZII)I"), __args);
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				if (c != null) {
					JNIEnv.CopyArray (native_c, c);
					JNIEnv.DeleteLocalRef (native_c);
				}
				if (d != null) {
					JNIEnv.CopyArray (native_d, d);
					JNIEnv.DeleteLocalRef (native_d);
				}
			}
		}

		static Delegate cb_calcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZII;
#pragma warning disable 0169
		static Delegate GetCalcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZIIHandler ()
		{
			if (cb_calcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZII == null)
				cb_calcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, bool, bool, int, int, int>) n_CalcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZII);
			return cb_calcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZII;
		}

		static int n_CalcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZII (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b, IntPtr native_c, IntPtr native_d, bool aAvb, bool bAvb, bool cAvb, bool dAvb, int refIdx, int comp)
		{
			global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] a = (int[]) JNIEnv.GetArray (native_a, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] b = (int[]) JNIEnv.GetArray (native_b, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] c = (int[]) JNIEnv.GetArray (native_c, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] d = (int[]) JNIEnv.GetArray (native_d, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.CalcMVPrediction16x8Top (a, b, c, d, aAvb, bAvb, cAvb, dAvb, refIdx, comp);
			if (a != null)
				JNIEnv.CopyArray (a, native_a);
			if (b != null)
				JNIEnv.CopyArray (b, native_b);
			if (c != null)
				JNIEnv.CopyArray (c, native_c);
			if (d != null)
				JNIEnv.CopyArray (d, native_d);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='SliceDecoder']/method[@name='calcMVPrediction16x8Top' and count(parameter)=10 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='int[]'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("calcMVPrediction16x8Top", "([I[I[I[IZZZZII)I", "GetCalcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZIIHandler")]
		public virtual unsafe int CalcMVPrediction16x8Top (int[] a, int[] b, int[] c, int[] d, bool aAvb, bool bAvb, bool cAvb, bool dAvb, int refIdx, int comp)
		{
			if (id_calcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZII == IntPtr.Zero)
				id_calcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZII = JNIEnv.GetMethodID (class_ref, "calcMVPrediction16x8Top", "([I[I[I[IZZZZII)I");
			IntPtr native_a = JNIEnv.NewArray (a);
			IntPtr native_b = JNIEnv.NewArray (b);
			IntPtr native_c = JNIEnv.NewArray (c);
			IntPtr native_d = JNIEnv.NewArray (d);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_a);
				__args [1] = new JValue (native_b);
				__args [2] = new JValue (native_c);
				__args [3] = new JValue (native_d);
				__args [4] = new JValue (aAvb);
				__args [5] = new JValue (bAvb);
				__args [6] = new JValue (cAvb);
				__args [7] = new JValue (dAvb);
				__args [8] = new JValue (refIdx);
				__args [9] = new JValue (comp);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcMVPrediction16x8Top_arrayIarrayIarrayIarrayIZZZZII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calcMVPrediction16x8Top", "([I[I[I[IZZZZII)I"), __args);
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				if (c != null) {
					JNIEnv.CopyArray (native_c, c);
					JNIEnv.DeleteLocalRef (native_c);
				}
				if (d != null) {
					JNIEnv.CopyArray (native_d, d);
					JNIEnv.DeleteLocalRef (native_d);
				}
			}
		}

		static Delegate cb_calcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZII;
#pragma warning disable 0169
		static Delegate GetCalcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZIIHandler ()
		{
			if (cb_calcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZII == null)
				cb_calcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, bool, bool, int, int, int>) n_CalcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZII);
			return cb_calcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZII;
		}

		static int n_CalcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZII (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b, IntPtr native_c, IntPtr native_d, bool aAvb, bool bAvb, bool cAvb, bool dAvb, int refIdx, int comp)
		{
			global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] a = (int[]) JNIEnv.GetArray (native_a, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] b = (int[]) JNIEnv.GetArray (native_b, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] c = (int[]) JNIEnv.GetArray (native_c, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] d = (int[]) JNIEnv.GetArray (native_d, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.CalcMVPrediction8x16Left (a, b, c, d, aAvb, bAvb, cAvb, dAvb, refIdx, comp);
			if (a != null)
				JNIEnv.CopyArray (a, native_a);
			if (b != null)
				JNIEnv.CopyArray (b, native_b);
			if (c != null)
				JNIEnv.CopyArray (c, native_c);
			if (d != null)
				JNIEnv.CopyArray (d, native_d);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='SliceDecoder']/method[@name='calcMVPrediction8x16Left' and count(parameter)=10 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='int[]'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("calcMVPrediction8x16Left", "([I[I[I[IZZZZII)I", "GetCalcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZIIHandler")]
		public virtual unsafe int CalcMVPrediction8x16Left (int[] a, int[] b, int[] c, int[] d, bool aAvb, bool bAvb, bool cAvb, bool dAvb, int refIdx, int comp)
		{
			if (id_calcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZII == IntPtr.Zero)
				id_calcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZII = JNIEnv.GetMethodID (class_ref, "calcMVPrediction8x16Left", "([I[I[I[IZZZZII)I");
			IntPtr native_a = JNIEnv.NewArray (a);
			IntPtr native_b = JNIEnv.NewArray (b);
			IntPtr native_c = JNIEnv.NewArray (c);
			IntPtr native_d = JNIEnv.NewArray (d);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_a);
				__args [1] = new JValue (native_b);
				__args [2] = new JValue (native_c);
				__args [3] = new JValue (native_d);
				__args [4] = new JValue (aAvb);
				__args [5] = new JValue (bAvb);
				__args [6] = new JValue (cAvb);
				__args [7] = new JValue (dAvb);
				__args [8] = new JValue (refIdx);
				__args [9] = new JValue (comp);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcMVPrediction8x16Left_arrayIarrayIarrayIarrayIZZZZII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calcMVPrediction8x16Left", "([I[I[I[IZZZZII)I"), __args);
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				if (c != null) {
					JNIEnv.CopyArray (native_c, c);
					JNIEnv.DeleteLocalRef (native_c);
				}
				if (d != null) {
					JNIEnv.CopyArray (native_d, d);
					JNIEnv.DeleteLocalRef (native_d);
				}
			}
		}

		static Delegate cb_calcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZII;
#pragma warning disable 0169
		static Delegate GetCalcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZIIHandler ()
		{
			if (cb_calcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZII == null)
				cb_calcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, bool, bool, int, int, int>) n_CalcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZII);
			return cb_calcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZII;
		}

		static int n_CalcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZII (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b, IntPtr native_c, IntPtr native_d, bool aAvb, bool bAvb, bool cAvb, bool dAvb, int refIdx, int comp)
		{
			global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] a = (int[]) JNIEnv.GetArray (native_a, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] b = (int[]) JNIEnv.GetArray (native_b, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] c = (int[]) JNIEnv.GetArray (native_c, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] d = (int[]) JNIEnv.GetArray (native_d, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.CalcMVPrediction8x16Right (a, b, c, d, aAvb, bAvb, cAvb, dAvb, refIdx, comp);
			if (a != null)
				JNIEnv.CopyArray (a, native_a);
			if (b != null)
				JNIEnv.CopyArray (b, native_b);
			if (c != null)
				JNIEnv.CopyArray (c, native_c);
			if (d != null)
				JNIEnv.CopyArray (d, native_d);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='SliceDecoder']/method[@name='calcMVPrediction8x16Right' and count(parameter)=10 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='int[]'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("calcMVPrediction8x16Right", "([I[I[I[IZZZZII)I", "GetCalcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZIIHandler")]
		public virtual unsafe int CalcMVPrediction8x16Right (int[] a, int[] b, int[] c, int[] d, bool aAvb, bool bAvb, bool cAvb, bool dAvb, int refIdx, int comp)
		{
			if (id_calcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZII == IntPtr.Zero)
				id_calcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZII = JNIEnv.GetMethodID (class_ref, "calcMVPrediction8x16Right", "([I[I[I[IZZZZII)I");
			IntPtr native_a = JNIEnv.NewArray (a);
			IntPtr native_b = JNIEnv.NewArray (b);
			IntPtr native_c = JNIEnv.NewArray (c);
			IntPtr native_d = JNIEnv.NewArray (d);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_a);
				__args [1] = new JValue (native_b);
				__args [2] = new JValue (native_c);
				__args [3] = new JValue (native_d);
				__args [4] = new JValue (aAvb);
				__args [5] = new JValue (bAvb);
				__args [6] = new JValue (cAvb);
				__args [7] = new JValue (dAvb);
				__args [8] = new JValue (refIdx);
				__args [9] = new JValue (comp);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcMVPrediction8x16Right_arrayIarrayIarrayIarrayIZZZZII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calcMVPrediction8x16Right", "([I[I[I[IZZZZII)I"), __args);
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				if (c != null) {
					JNIEnv.CopyArray (native_c, c);
					JNIEnv.DeleteLocalRef (native_c);
				}
				if (d != null) {
					JNIEnv.CopyArray (native_d, d);
					JNIEnv.DeleteLocalRef (native_d);
				}
			}
		}

		static Delegate cb_calcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZII;
#pragma warning disable 0169
		static Delegate GetCalcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZIIHandler ()
		{
			if (cb_calcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZII == null)
				cb_calcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, bool, bool, int, int, int>) n_CalcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZII);
			return cb_calcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZII;
		}

		static int n_CalcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZII (IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b, IntPtr native_c, IntPtr native_d, bool aAvb, bool bAvb, bool cAvb, bool dAvb, int @ref, int comp)
		{
			global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] a = (int[]) JNIEnv.GetArray (native_a, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] b = (int[]) JNIEnv.GetArray (native_b, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] c = (int[]) JNIEnv.GetArray (native_c, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] d = (int[]) JNIEnv.GetArray (native_d, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.CalcMVPredictionMedian (a, b, c, d, aAvb, bAvb, cAvb, dAvb, @ref, comp);
			if (a != null)
				JNIEnv.CopyArray (a, native_a);
			if (b != null)
				JNIEnv.CopyArray (b, native_b);
			if (c != null)
				JNIEnv.CopyArray (c, native_c);
			if (d != null)
				JNIEnv.CopyArray (d, native_d);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='SliceDecoder']/method[@name='calcMVPredictionMedian' and count(parameter)=10 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='int[]'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("calcMVPredictionMedian", "([I[I[I[IZZZZII)I", "GetCalcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZIIHandler")]
		public virtual unsafe int CalcMVPredictionMedian (int[] a, int[] b, int[] c, int[] d, bool aAvb, bool bAvb, bool cAvb, bool dAvb, int @ref, int comp)
		{
			if (id_calcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZII == IntPtr.Zero)
				id_calcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZII = JNIEnv.GetMethodID (class_ref, "calcMVPredictionMedian", "([I[I[I[IZZZZII)I");
			IntPtr native_a = JNIEnv.NewArray (a);
			IntPtr native_b = JNIEnv.NewArray (b);
			IntPtr native_c = JNIEnv.NewArray (c);
			IntPtr native_d = JNIEnv.NewArray (d);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_a);
				__args [1] = new JValue (native_b);
				__args [2] = new JValue (native_c);
				__args [3] = new JValue (native_d);
				__args [4] = new JValue (aAvb);
				__args [5] = new JValue (bAvb);
				__args [6] = new JValue (cAvb);
				__args [7] = new JValue (dAvb);
				__args [8] = new JValue (@ref);
				__args [9] = new JValue (comp);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcMVPredictionMedian_arrayIarrayIarrayIarrayIZZZZII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calcMVPredictionMedian", "([I[I[I[IZZZZII)I"), __args);
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
				if (c != null) {
					JNIEnv.CopyArray (native_c, c);
					JNIEnv.DeleteLocalRef (native_c);
				}
				if (d != null) {
					JNIEnv.CopyArray (native_d, d);
					JNIEnv.DeleteLocalRef (native_d);
				}
			}
		}

		static Delegate cb_decodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_;
#pragma warning disable 0169
		static Delegate GetDecodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_Handler ()
		{
			if (cb_decodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_ == null)
				cb_decodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_DecodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_);
			return cb_decodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_;
		}

		static void n_DecodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reader, int mbIndex, IntPtr native_mb)
		{
			global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader reader = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_reader, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture mb = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_mb, JniHandleOwnership.DoNotTransfer);
			__this.DecodeMBlockIPCM (reader, mbIndex, mb);
		}
#pragma warning restore 0169

		static IntPtr id_decodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='SliceDecoder']/method[@name='decodeMBlockIPCM' and count(parameter)=3 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='int'] and parameter[3][@type='org.jcodec.common.model.Picture']]"
		[Register ("decodeMBlockIPCM", "(Lorg/jcodec/common/io/BitReader;ILorg/jcodec/common/model/Picture;)V", "GetDecodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_Handler")]
		public virtual unsafe void DecodeMBlockIPCM (global::Org.Jcodec.Common.IO.BitReader reader, int mbIndex, global::Org.Jcodec.Common.Model.Picture mb)
		{
			if (id_decodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_decodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "decodeMBlockIPCM", "(Lorg/jcodec/common/io/BitReader;ILorg/jcodec/common/model/Picture;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (reader);
				__args [1] = new JValue (mbIndex);
				__args [2] = new JValue (mb);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeMBlockIPCM_Lorg_jcodec_common_io_BitReader_ILorg_jcodec_common_model_Picture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeMBlockIPCM", "(Lorg/jcodec/common/io/BitReader;ILorg/jcodec/common/model/Picture;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_put_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_II;
#pragma warning disable 0169
		static Delegate GetPut_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_IIHandler ()
		{
			if (cb_put_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_II == null)
				cb_put_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_Put_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_II);
			return cb_put_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_II;
		}

		static void n_Put_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_tgt, IntPtr native_decoded, int mbX, int mbY)
		{
			global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture tgt = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_tgt, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture decoded = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_decoded, JniHandleOwnership.DoNotTransfer);
			__this.Put (tgt, decoded, mbX, mbY);
		}
#pragma warning restore 0169

		static IntPtr id_put_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='SliceDecoder']/method[@name='put' and count(parameter)=4 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='org.jcodec.common.model.Picture'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("put", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;II)V", "GetPut_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_IIHandler")]
		public virtual unsafe void Put (global::Org.Jcodec.Common.Model.Picture tgt, global::Org.Jcodec.Common.Model.Picture decoded, int mbX, int mbY)
		{
			if (id_put_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_II == IntPtr.Zero)
				id_put_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_II = JNIEnv.GetMethodID (class_ref, "put", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (tgt);
				__args [1] = new JValue (decoded);
				__args [2] = new JValue (mbX);
				__args [3] = new JValue (mbY);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDebug_Z;
#pragma warning disable 0169
		static Delegate GetSetDebug_ZHandler ()
		{
			if (cb_setDebug_Z == null)
				cb_setDebug_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDebug_Z);
			return cb_setDebug_Z;
		}

		static void n_SetDebug_Z (IntPtr jnienv, IntPtr native__this, bool debug)
		{
			global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.SliceDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebug (debug);
		}
#pragma warning restore 0169

		static IntPtr id_setDebug_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='SliceDecoder']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebug", "(Z)V", "GetSetDebug_ZHandler")]
		public virtual unsafe void SetDebug (bool debug)
		{
			if (id_setDebug_Z == IntPtr.Zero)
				id_setDebug_Z = JNIEnv.GetMethodID (class_ref, "setDebug", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (debug);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDebug_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDebug", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
