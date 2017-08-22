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
				if (((object) this).GetType () != typeof (IntDCT)) {
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

		static Delegate cb_decode_arrayI;
#pragma warning disable 0169
		static Delegate GetDecode_arrayIHandler ()
		{
			if (cb_decode_arrayI == null)
				cb_decode_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_arrayI);
			return cb_decode_arrayI;
		}

		static IntPtr n_Decode_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_orig)
		{
			global::Org.Jcodec.Common.Dct.IntDCT __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Dct.IntDCT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] orig = (int[]) JNIEnv.GetArray (native_orig, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (orig));
			if (orig != null)
				JNIEnv.CopyArray (orig, native_orig);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IntDCT']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("decode", "([I)[I", "GetDecode_arrayIHandler")]
		public override unsafe int[] Decode (int[] orig)
		{
			if (id_decode_arrayI == IntPtr.Zero)
				id_decode_arrayI = JNIEnv.GetMethodID (class_ref, "decode", "([I)[I");
			IntPtr native_orig = JNIEnv.NewArray (orig);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_orig);

				int[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "([I)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (orig != null) {
					JNIEnv.CopyArray (native_orig, orig);
					JNIEnv.DeleteLocalRef (native_orig);
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

		static IntPtr n_Decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inptr, IntPtr native_workspace, IntPtr native_outptr)
		{
			global::Org.Jcodec.Common.Dct.IntDCT __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Dct.IntDCT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.IntBuffer inptr = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (native_inptr, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.IntBuffer workspace = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (native_workspace, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.IntBuffer outptr = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (native_outptr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (inptr, workspace, outptr));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IntDCT']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='java.nio.IntBuffer'] and parameter[2][@type='java.nio.IntBuffer'] and parameter[3][@type='java.nio.IntBuffer']]"
		[Register ("decode", "(Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;", "GetDecode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Handler")]
		protected virtual unsafe global::Java.Nio.IntBuffer Decode (global::Java.Nio.IntBuffer inptr, global::Java.Nio.IntBuffer workspace, global::Java.Nio.IntBuffer outptr)
		{
			if (id_decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_ == IntPtr.Zero)
				id_decode_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_Ljava_nio_IntBuffer_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (inptr);
				__args [1] = new JValue (workspace);
				__args [2] = new JValue (outptr);

				global::Java.Nio.IntBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
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
		public static unsafe int Range_limit (int i)
		{
			if (id_range_limit_I == IntPtr.Zero)
				id_range_limit_I = JNIEnv.GetStaticMethodID (class_ref, "range_limit", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_range_limit_I, __args);
			} finally {
			}
		}

	}
}
