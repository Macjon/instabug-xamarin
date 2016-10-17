using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Common.Biari {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MEncoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/MEncoder", DoNotGenerateAcw=true)]
	public partial class MEncoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/MEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MEncoder); }
		}

		protected MEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_arrayarrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MEncoder']/constructor[@name='MEncoder' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[][]']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;[[I)V", "")]
		public unsafe MEncoder (global::Java.Nio.ByteBuffer p0, int[][] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (MEncoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/ByteBuffer;[[I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;[[I)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_arrayarrayI == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_arrayarrayI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;[[I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_arrayarrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_arrayarrayI, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_encodeBin_II;
#pragma warning disable 0169
		static Delegate GetEncodeBin_IIHandler ()
		{
			if (cb_encodeBin_II == null)
				cb_encodeBin_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_EncodeBin_II);
			return cb_encodeBin_II;
		}

		static void n_EncodeBin_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EncodeBin (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeBin_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MEncoder']/method[@name='encodeBin' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("encodeBin", "(II)V", "GetEncodeBin_IIHandler")]
		public virtual unsafe void EncodeBin (int p0, int p1)
		{
			if (id_encodeBin_II == IntPtr.Zero)
				id_encodeBin_II = JNIEnv.GetMethodID (class_ref, "encodeBin", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeBin_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeBin", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_encodeBinBypass_I;
#pragma warning disable 0169
		static Delegate GetEncodeBinBypass_IHandler ()
		{
			if (cb_encodeBinBypass_I == null)
				cb_encodeBinBypass_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_EncodeBinBypass_I);
			return cb_encodeBinBypass_I;
		}

		static void n_EncodeBinBypass_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EncodeBinBypass (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encodeBinBypass_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MEncoder']/method[@name='encodeBinBypass' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("encodeBinBypass", "(I)V", "GetEncodeBinBypass_IHandler")]
		public virtual unsafe void EncodeBinBypass (int p0)
		{
			if (id_encodeBinBypass_I == IntPtr.Zero)
				id_encodeBinBypass_I = JNIEnv.GetMethodID (class_ref, "encodeBinBypass", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeBinBypass_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeBinBypass", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_encodeBinFinal_I;
#pragma warning disable 0169
		static Delegate GetEncodeBinFinal_IHandler ()
		{
			if (cb_encodeBinFinal_I == null)
				cb_encodeBinFinal_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_EncodeBinFinal_I);
			return cb_encodeBinFinal_I;
		}

		static void n_EncodeBinFinal_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EncodeBinFinal (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encodeBinFinal_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MEncoder']/method[@name='encodeBinFinal' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("encodeBinFinal", "(I)V", "GetEncodeBinFinal_IHandler")]
		public virtual unsafe void EncodeBinFinal (int p0)
		{
			if (id_encodeBinFinal_I == IntPtr.Zero)
				id_encodeBinFinal_I = JNIEnv.GetMethodID (class_ref, "encodeBinFinal", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeBinFinal_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeBinFinal", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_finishEncoding;
#pragma warning disable 0169
		static Delegate GetFinishEncodingHandler ()
		{
			if (cb_finishEncoding == null)
				cb_finishEncoding = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinishEncoding);
			return cb_finishEncoding;
		}

		static void n_FinishEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishEncoding ();
		}
#pragma warning restore 0169

		static IntPtr id_finishEncoding;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MEncoder']/method[@name='finishEncoding' and count(parameter)=0]"
		[Register ("finishEncoding", "()V", "GetFinishEncodingHandler")]
		public virtual unsafe void FinishEncoding ()
		{
			if (id_finishEncoding == IntPtr.Zero)
				id_finishEncoding = JNIEnv.GetMethodID (class_ref, "finishEncoding", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishEncoding);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finishEncoding", "()V"));
			} finally {
			}
		}

	}
}
