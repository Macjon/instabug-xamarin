using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vp8 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Decoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vp8/VP8Decoder", DoNotGenerateAcw=true)]
	public partial class VP8Decoder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vp8/VP8Decoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VP8Decoder); }
		}

		protected VP8Decoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Decoder']/constructor[@name='VP8Decoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VP8Decoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VP8Decoder)) {
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

		static Delegate cb_getPicture;
#pragma warning disable 0169
		static Delegate GetGetPictureHandler ()
		{
			if (cb_getPicture == null)
				cb_getPicture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPicture);
			return cb_getPicture;
		}

		static IntPtr n_GetPicture (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Vp8.VP8Decoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Picture);
		}
#pragma warning restore 0169

		static IntPtr id_getPicture;
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture Picture {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Decoder']/method[@name='getPicture' and count(parameter)=0]"
			[Register ("getPicture", "()Lorg/jcodec/common/model/Picture;", "GetGetPictureHandler")]
			get {
				if (id_getPicture == IntPtr.Zero)
					id_getPicture = JNIEnv.GetMethodID (class_ref, "getPicture", "()Lorg/jcodec/common/model/Picture;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPicture), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPicture", "()Lorg/jcodec/common/model/Picture;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_decode_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_decode_Ljava_nio_ByteBuffer_ == null)
				cb_decode_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_nio_ByteBuffer_);
			return cb_decode_Ljava_nio_ByteBuffer_;
		}

		static void n_Decode_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frame)
		{
			global::Org.Jcodec.Codecs.Vp8.VP8Decoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer frame = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_frame, JniHandleOwnership.DoNotTransfer);
			__this.Decode (frame);
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Decoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("decode", "(Ljava/nio/ByteBuffer;)V", "GetDecode_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Decode (global::Java.Nio.ByteBuffer frame)
		{
			if (id_decode_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_decode_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (frame);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_printHexByte_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Decoder']/method[@name='printHexByte' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("printHexByte", "(B)Ljava/lang/String;", "")]
		public static unsafe string PrintHexByte (sbyte b)
		{
			if (id_printHexByte_B == IntPtr.Zero)
				id_printHexByte_B = JNIEnv.GetStaticMethodID (class_ref, "printHexByte", "(B)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (b);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_printHexByte_B, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
