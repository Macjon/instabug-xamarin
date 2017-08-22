using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Raw {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.raw']/class[@name='V210Encoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/raw/V210Encoder", DoNotGenerateAcw=true)]
	public partial class V210Encoder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/raw/V210Encoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (V210Encoder); }
		}

		protected V210Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.raw']/class[@name='V210Encoder']/constructor[@name='V210Encoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe V210Encoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (V210Encoder)) {
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

		static Delegate cb_encodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_;
#pragma warning disable 0169
		static Delegate GetEncodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_Handler ()
		{
			if (cb_encodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_ == null)
				cb_encodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_);
			return cb_encodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_;
		}

		static IntPtr n_EncodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out, IntPtr native_frame)
		{
			global::Org.Jcodec.Codecs.Raw.V210Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Raw.V210Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer _out = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native__out, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture frame = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_frame, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EncodeFrame (_out, frame));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.raw']/class[@name='V210Encoder']/method[@name='encodeFrame' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='org.jcodec.common.model.Picture']]"
		[Register ("encodeFrame", "(Ljava/nio/ByteBuffer;Lorg/jcodec/common/model/Picture;)Ljava/nio/ByteBuffer;", "GetEncodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_Handler")]
		public virtual unsafe global::Java.Nio.ByteBuffer EncodeFrame (global::Java.Nio.ByteBuffer _out, global::Org.Jcodec.Common.Model.Picture frame)
		{
			if (id_encodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_encodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "encodeFrame", "(Ljava/nio/ByteBuffer;Lorg/jcodec/common/model/Picture;)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (_out);
				__args [1] = new JValue (frame);

				global::Java.Nio.ByteBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeFrame_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Picture_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeFrame", "(Ljava/nio/ByteBuffer;Lorg/jcodec/common/model/Picture;)Ljava/nio/ByteBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
