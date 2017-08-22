using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Prores2VP8Track']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/Prores2VP8Track", DoNotGenerateAcw=true)]
	public partial class Prores2VP8Track : global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/Prores2VP8Track", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Prores2VP8Track); }
		}

		protected Prores2VP8Track (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_;
#pragma warning disable 0169
		static Delegate GetGetCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_Handler ()
		{
			if (cb_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_ == null)
				cb_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_);
			return cb_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_;
		}

		static void n_GetCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, IntPtr native_dim)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.Prores2VP8Track __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.Prores2VP8Track> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buf = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Size dim = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (native_dim, JniHandleOwnership.DoNotTransfer);
			__this.GetCodecPrivate (buf, dim);
		}
#pragma warning restore 0169

		static IntPtr id_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Prores2VP8Track']/method[@name='getCodecPrivate' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='org.jcodec.common.model.Size']]"
		[Register ("getCodecPrivate", "(Ljava/nio/ByteBuffer;Lorg/jcodec/common/model/Size;)V", "GetGetCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_Handler")]
		protected override unsafe void GetCodecPrivate (global::Java.Nio.ByteBuffer buf, global::Org.Jcodec.Common.Model.Size dim)
		{
			if (id_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_ == IntPtr.Zero)
				id_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_ = JNIEnv.GetMethodID (class_ref, "getCodecPrivate", "(Ljava/nio/ByteBuffer;Lorg/jcodec/common/model/Size;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (buf);
				__args [1] = new JValue (dim);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodecPrivate", "(Ljava/nio/ByteBuffer;Lorg/jcodec/common/model/Size;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getFrameSize_II;
#pragma warning disable 0169
		static Delegate GetGetFrameSize_IIHandler ()
		{
			if (cb_getFrameSize_II == null)
				cb_getFrameSize_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetFrameSize_II);
			return cb_getFrameSize_II;
		}

		static int n_GetFrameSize_II (IntPtr jnienv, IntPtr native__this, int mbCount, int rate)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.Prores2VP8Track __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.Prores2VP8Track> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetFrameSize (mbCount, rate);
		}
#pragma warning restore 0169

		static IntPtr id_getFrameSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Prores2VP8Track']/method[@name='getFrameSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getFrameSize", "(II)I", "GetGetFrameSize_IIHandler")]
		protected override unsafe int GetFrameSize (int mbCount, int rate)
		{
			if (id_getFrameSize_II == IntPtr.Zero)
				id_getFrameSize_II = JNIEnv.GetMethodID (class_ref, "getFrameSize", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mbCount);
				__args [1] = new JValue (rate);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFrameSize_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameSize", "(II)I"), __args);
			} finally {
			}
		}

	}
}
