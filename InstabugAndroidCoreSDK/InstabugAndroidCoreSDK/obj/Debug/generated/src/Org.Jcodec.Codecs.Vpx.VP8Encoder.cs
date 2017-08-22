using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vpx {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VP8Encoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vpx/VP8Encoder", DoNotGenerateAcw=true)]
	public partial class VP8Encoder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vpx/VP8Encoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VP8Encoder); }
		}

		protected VP8Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VP8Encoder']/constructor[@name='VP8Encoder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe VP8Encoder (int qp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (qp);
				if (((object) this).GetType () != typeof (VP8Encoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_jcodec_codecs_vpx_RateControl_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VP8Encoder']/constructor[@name='VP8Encoder' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.vpx.RateControl']]"
		[Register (".ctor", "(Lorg/jcodec/codecs/vpx/RateControl;)V", "")]
		public unsafe VP8Encoder (global::Org.Jcodec.Codecs.Vpx.IRateControl rc)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (rc);
				if (((object) this).GetType () != typeof (VP8Encoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/codecs/vpx/RateControl;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/codecs/vpx/RateControl;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_codecs_vpx_RateControl_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_codecs_vpx_RateControl_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/vpx/RateControl;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_vpx_RateControl_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_vpx_RateControl_, __args);
			} finally {
			}
		}

		static Delegate cb_encodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetEncodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_encodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_ == null)
				cb_encodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_);
			return cb_encodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_EncodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pic, IntPtr native__buf)
		{
			global::Org.Jcodec.Codecs.Vpx.VP8Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.VP8Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture pic = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_pic, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer _buf = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native__buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EncodeFrame (pic, _buf));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VP8Encoder']/method[@name='encodeFrame' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("encodeFrame", "(Lorg/jcodec/common/model/Picture;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "GetEncodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe global::Java.Nio.ByteBuffer EncodeFrame (global::Org.Jcodec.Common.Model.Picture pic, global::Java.Nio.ByteBuffer _buf)
		{
			if (id_encodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_encodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "encodeFrame", "(Lorg/jcodec/common/model/Picture;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (pic);
				__args [1] = new JValue (_buf);

				global::Java.Nio.ByteBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeFrame_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeFrame", "(Lorg/jcodec/common/model/Picture;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSupportedColorSpaces;
#pragma warning disable 0169
		static Delegate GetGetSupportedColorSpacesHandler ()
		{
			if (cb_getSupportedColorSpaces == null)
				cb_getSupportedColorSpaces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportedColorSpaces);
			return cb_getSupportedColorSpaces;
		}

		static IntPtr n_GetSupportedColorSpaces (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Vpx.VP8Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.VP8Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSupportedColorSpaces ());
		}
#pragma warning restore 0169

		static IntPtr id_getSupportedColorSpaces;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VP8Encoder']/method[@name='getSupportedColorSpaces' and count(parameter)=0]"
		[Register ("getSupportedColorSpaces", "()[Lorg/jcodec/common/model/ColorSpace;", "GetGetSupportedColorSpacesHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.ColorSpace[] GetSupportedColorSpaces ()
		{
			if (id_getSupportedColorSpaces == IntPtr.Zero)
				id_getSupportedColorSpaces = JNIEnv.GetMethodID (class_ref, "getSupportedColorSpaces", "()[Lorg/jcodec/common/model/ColorSpace;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Jcodec.Common.Model.ColorSpace[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportedColorSpaces), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ColorSpace));
				else
					return (global::Org.Jcodec.Common.Model.ColorSpace[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportedColorSpaces", "()[Lorg/jcodec/common/model/ColorSpace;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ColorSpace));
			} finally {
			}
		}

	}
}
