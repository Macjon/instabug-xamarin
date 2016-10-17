using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Dct {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IntDCT']"
	[global::Android.Runtime.Register ("org/jcodec/common/dct/IntDCT", DoNotGenerateAcw=true)]
	public partial class IntDCT : global::Org.Jcodec.Common.Dct.DCT {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IntDCT']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Org.Jcodec.Common.Dct.IntDCT Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lorg/jcodec/common/dct/IntDCT;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Dct.IntDCT> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/dct/IntDCT", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IntDCT); }
		}

		protected IntDCT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IntDCT']/constructor[@name='IntDCT' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IntDCT ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (IntDCT)) {
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

		static Delegate cb_decode_arrayI;
#pragma warning disable 0169
		static Delegate GetDecode_arrayIHandler ()
		{
			if (cb_decode_arrayI == null)
				cb_decode_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_arrayI);
			return cb_decode_arrayI;
		}

		static IntPtr n_Decode_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Dct.IntDCT __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Dct.IntDCT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IntDCT']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("decode", "([I)[I", "GetDecode_arrayIHandler")]
		public override unsafe int[] Decode (int[] p0)
		{
			if (id_decode_arrayI == IntPtr.Zero)
				id_decode_arrayI = JNIEnv.GetMethodID (class_ref, "decode", "([I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int[] __ret;
				if (GetType () == ThresholdType)
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "([I)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Handler ()
		{
			if (cb_decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_ == null)
				cb_decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_);
			return cb_decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_;
		}

		static IntPtr n_Decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Jcodec.Common.Dct.IntDCT __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Dct.IntDCT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.IntBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.IntBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.IntBuffer p2 = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IntDCT']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='java.nio.IntBuffer'] and parameter[2][@type='java.nio.IntBuffer'] and parameter[3][@type='java.nio.IntBuffer']]"
		[Register ("decode", "(Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;", "GetDecode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Handler")]
		protected virtual unsafe global::Java.Nio.IntBuffer Decode (global::Java.Nio.IntBuffer p0, global::Java.Nio.IntBuffer p1, global::Java.Nio.IntBuffer p2)
		{
			if (id_decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_ == IntPtr.Zero)
				id_decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Java.Nio.IntBuffer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_range_limit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IntDCT']/method[@name='range_limit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("range_limit", "(I)I", "")]
		public static unsafe int Range_limit (int p0)
		{
			if (id_range_limit_I == IntPtr.Zero)
				id_range_limit_I = JNIEnv.GetStaticMethodID (class_ref, "range_limit", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_range_limit_I, __args);
			} finally {
			}
		}

	}
}
