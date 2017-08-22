using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Common.Biari {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQEncoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/MQEncoder", DoNotGenerateAcw=true)]
	public partial class MQEncoder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQEncoder']/field[@name='CARRY_MASK']"
		[Register ("CARRY_MASK")]
		public const int CarryMask = (int) 134217728;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/MQEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MQEncoder); }
		}

		protected MQEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_OutputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQEncoder']/constructor[@name='MQEncoder' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
		public unsafe MQEncoder (global::System.IO.Stream @out)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__out);
				if (((object) this).GetType () != typeof (MQEncoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/OutputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/OutputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		static Delegate cb_encode_ILorg_jcodec_codecs_common_biari_Context_;
#pragma warning disable 0169
		static Delegate GetEncode_ILorg_jcodec_codecs_common_biari_Context_Handler ()
		{
			if (cb_encode_ILorg_jcodec_codecs_common_biari_Context_ == null)
				cb_encode_ILorg_jcodec_codecs_common_biari_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Encode_ILorg_jcodec_codecs_common_biari_Context_);
			return cb_encode_ILorg_jcodec_codecs_common_biari_Context_;
		}

		static void n_Encode_ILorg_jcodec_codecs_common_biari_Context_ (IntPtr jnienv, IntPtr native__this, int symbol, IntPtr native_cm)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MQEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MQEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.Context cm = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.Context> (native_cm, JniHandleOwnership.DoNotTransfer);
			__this.Encode (symbol, cm);
		}
#pragma warning restore 0169

		static IntPtr id_encode_ILorg_jcodec_codecs_common_biari_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.jcodec.codecs.common.biari.Context']]"
		[Register ("encode", "(ILorg/jcodec/codecs/common/biari/Context;)V", "GetEncode_ILorg_jcodec_codecs_common_biari_Context_Handler")]
		public virtual unsafe void Encode (int symbol, global::Org.Jcodec.Codecs.Common.Biari.Context cm)
		{
			if (id_encode_ILorg_jcodec_codecs_common_biari_Context_ == IntPtr.Zero)
				id_encode_ILorg_jcodec_codecs_common_biari_Context_ = JNIEnv.GetMethodID (class_ref, "encode", "(ILorg/jcodec/codecs/common/biari/Context;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (symbol);
				__args [1] = new JValue (cm);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_ILorg_jcodec_codecs_common_biari_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(ILorg/jcodec/codecs/common/biari/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MQEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MQEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		static IntPtr id_finish;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQEncoder']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			if (id_finish == IntPtr.Zero)
				id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finish);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finish", "()V"));
			} finally {
			}
		}

	}
}
