using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Common.Biari {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQDecoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/MQDecoder", DoNotGenerateAcw=true)]
	public partial class MQDecoder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/MQDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MQDecoder); }
		}

		protected MQDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQDecoder']/constructor[@name='MQDecoder' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe MQDecoder (global::System.IO.Stream @is)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__is);
				if (((object) this).GetType () != typeof (MQDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
			}
		}

		static Delegate cb_decode_Lorg_jcodec_codecs_common_biari_Context_;
#pragma warning disable 0169
		static Delegate GetDecode_Lorg_jcodec_codecs_common_biari_Context_Handler ()
		{
			if (cb_decode_Lorg_jcodec_codecs_common_biari_Context_ == null)
				cb_decode_Lorg_jcodec_codecs_common_biari_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Decode_Lorg_jcodec_codecs_common_biari_Context_);
			return cb_decode_Lorg_jcodec_codecs_common_biari_Context_;
		}

		static int n_Decode_Lorg_jcodec_codecs_common_biari_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cm)
		{
			global::Org.Jcodec.Codecs.Common.Biari.MQDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MQDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.Context cm = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.Context> (native_cm, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Decode (cm);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Lorg_jcodec_codecs_common_biari_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQDecoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.common.biari.Context']]"
		[Register ("decode", "(Lorg/jcodec/codecs/common/biari/Context;)I", "GetDecode_Lorg_jcodec_codecs_common_biari_Context_Handler")]
		public virtual unsafe int Decode (global::Org.Jcodec.Codecs.Common.Biari.Context cm)
		{
			if (id_decode_Lorg_jcodec_codecs_common_biari_Context_ == IntPtr.Zero)
				id_decode_Lorg_jcodec_codecs_common_biari_Context_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lorg/jcodec/codecs/common/biari/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cm);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_decode_Lorg_jcodec_codecs_common_biari_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Lorg/jcodec/codecs/common/biari/Context;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
