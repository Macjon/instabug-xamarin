using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Pcmdvd {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.pcmdvd']/class[@name='PCMDVDDecoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/pcmdvd/PCMDVDDecoder", DoNotGenerateAcw=true)]
	public partial class PCMDVDDecoder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/pcmdvd/PCMDVDDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PCMDVDDecoder); }
		}

		protected PCMDVDDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.pcmdvd']/class[@name='PCMDVDDecoder']/constructor[@name='PCMDVDDecoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PCMDVDDecoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PCMDVDDecoder)) {
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

		static Delegate cb_decodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetDecodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_decodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == null)
				cb_decodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_);
			return cb_decodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_DecodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native__frame, IntPtr native__dst)
		{
			global::Org.Jcodec.Codecs.Pcmdvd.PCMDVDDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Pcmdvd.PCMDVDDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer _frame = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native__frame, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer _dst = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native__dst, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeFrame (_frame, _dst));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.pcmdvd']/class[@name='PCMDVDDecoder']/method[@name='decodeFrame' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("decodeFrame", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Lorg/jcodec/common/model/AudioBuffer;", "GetDecodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.AudioBuffer DecodeFrame (global::Java.Nio.ByteBuffer _frame, global::Java.Nio.ByteBuffer _dst)
		{
			if (id_decodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_decodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "decodeFrame", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Lorg/jcodec/common/model/AudioBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (_frame);
				__args [1] = new JValue (_dst);

				global::Org.Jcodec.Common.Model.AudioBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.AudioBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.AudioBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeFrame", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Lorg/jcodec/common/model/AudioBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
