using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Common.Biari {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MDecoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/MDecoder", DoNotGenerateAcw=true)]
	public partial class MDecoder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/MDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MDecoder); }
		}

		protected MDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_arrayarrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MDecoder']/constructor[@name='MDecoder' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[][]']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;[[I)V", "")]
		public unsafe MDecoder (global::Java.Nio.ByteBuffer @in, int[][] cm)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_cm = JNIEnv.NewArray (cm);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@in);
				__args [1] = new JValue (native_cm);
				if (((object) this).GetType () != typeof (MDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;[[I)V", __args),
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
				if (cm != null) {
					JNIEnv.CopyArray (native_cm, cm);
					JNIEnv.DeleteLocalRef (native_cm);
				}
			}
		}

		static Delegate cb_decodeBin_I;
#pragma warning disable 0169
		static Delegate GetDecodeBin_IHandler ()
		{
			if (cb_decodeBin_I == null)
				cb_decodeBin_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_DecodeBin_I);
			return cb_decodeBin_I;
		}

		static int n_DecodeBin_I (IntPtr jnienv, IntPtr native__this, int m)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecodeBin (m);
		}
#pragma warning restore 0169

		static IntPtr id_decodeBin_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MDecoder']/method[@name='decodeBin' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("decodeBin", "(I)I", "GetDecodeBin_IHandler")]
		public virtual unsafe int DecodeBin (int m)
		{
			if (id_decodeBin_I == IntPtr.Zero)
				id_decodeBin_I = JNIEnv.GetMethodID (class_ref, "decodeBin", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (m);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_decodeBin_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBin", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_decodeBinBypass;
#pragma warning disable 0169
		static Delegate GetDecodeBinBypassHandler ()
		{
			if (cb_decodeBinBypass == null)
				cb_decodeBinBypass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DecodeBinBypass);
			return cb_decodeBinBypass;
		}

		static int n_DecodeBinBypass (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecodeBinBypass ();
		}
#pragma warning restore 0169

		static IntPtr id_decodeBinBypass;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MDecoder']/method[@name='decodeBinBypass' and count(parameter)=0]"
		[Register ("decodeBinBypass", "()I", "GetDecodeBinBypassHandler")]
		public virtual unsafe int DecodeBinBypass ()
		{
			if (id_decodeBinBypass == IntPtr.Zero)
				id_decodeBinBypass = JNIEnv.GetMethodID (class_ref, "decodeBinBypass", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_decodeBinBypass);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBinBypass", "()I"));
			} finally {
			}
		}

		static Delegate cb_decodeFinalBin;
#pragma warning disable 0169
		static Delegate GetDecodeFinalBinHandler ()
		{
			if (cb_decodeFinalBin == null)
				cb_decodeFinalBin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DecodeFinalBin);
			return cb_decodeFinalBin;
		}

		static int n_DecodeFinalBin (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecodeFinalBin ();
		}
#pragma warning restore 0169

		static IntPtr id_decodeFinalBin;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MDecoder']/method[@name='decodeFinalBin' and count(parameter)=0]"
		[Register ("decodeFinalBin", "()I", "GetDecodeFinalBinHandler")]
		public virtual unsafe int DecodeFinalBin ()
		{
			if (id_decodeFinalBin == IntPtr.Zero)
				id_decodeFinalBin = JNIEnv.GetMethodID (class_ref, "decodeFinalBin", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_decodeFinalBin);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeFinalBin", "()I"));
			} finally {
			}
		}

		static Delegate cb_initCodeRegister;
#pragma warning disable 0169
		static Delegate GetInitCodeRegisterHandler ()
		{
			if (cb_initCodeRegister == null)
				cb_initCodeRegister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitCodeRegister);
			return cb_initCodeRegister;
		}

		static void n_InitCodeRegister (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitCodeRegister ();
		}
#pragma warning restore 0169

		static IntPtr id_initCodeRegister;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MDecoder']/method[@name='initCodeRegister' and count(parameter)=0]"
		[Register ("initCodeRegister", "()V", "GetInitCodeRegisterHandler")]
		protected virtual unsafe void InitCodeRegister ()
		{
			if (id_initCodeRegister == IntPtr.Zero)
				id_initCodeRegister = JNIEnv.GetMethodID (class_ref, "initCodeRegister", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initCodeRegister);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initCodeRegister", "()V"));
			} finally {
			}
		}

		static Delegate cb_readOneByte;
#pragma warning disable 0169
		static Delegate GetReadOneByteHandler ()
		{
			if (cb_readOneByte == null)
				cb_readOneByte = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadOneByte);
			return cb_readOneByte;
		}

		static void n_ReadOneByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadOneByte ();
		}
#pragma warning restore 0169

		static IntPtr id_readOneByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MDecoder']/method[@name='readOneByte' and count(parameter)=0]"
		[Register ("readOneByte", "()V", "GetReadOneByteHandler")]
		protected virtual unsafe void ReadOneByte ()
		{
			if (id_readOneByte == IntPtr.Zero)
				id_readOneByte = JNIEnv.GetMethodID (class_ref, "readOneByte", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readOneByte);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readOneByte", "()V"));
			} finally {
			}
		}

	}
}
