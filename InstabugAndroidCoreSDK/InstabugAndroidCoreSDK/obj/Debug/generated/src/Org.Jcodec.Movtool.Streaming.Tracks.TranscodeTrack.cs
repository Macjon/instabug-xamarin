using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='TranscodeTrack']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/TranscodeTrack", DoNotGenerateAcw=true)]
	public abstract partial class TranscodeTrack : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='TranscodeTrack.Transcoder']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/TranscodeTrack$Transcoder", DoNotGenerateAcw=true)]
		public partial class Transcoder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/TranscodeTrack$Transcoder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Transcoder); }
			}

			protected Transcoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_movtool_streaming_tracks_TranscodeTrack_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='TranscodeTrack.Transcoder']/constructor[@name='TranscodeTrack.Transcoder' and count(parameter)=1 and parameter[1][@type='org.jcodec.movtool.streaming.tracks.TranscodeTrack']]"
			[Register (".ctor", "(Lorg/jcodec/movtool/streaming/tracks/TranscodeTrack;)V", "")]
			public unsafe Transcoder (global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (Transcoder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_movtool_streaming_tracks_TranscodeTrack_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_movtool_streaming_tracks_TranscodeTrack_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/movtool/streaming/tracks/TranscodeTrack;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_TranscodeTrack_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_TranscodeTrack_, __args);
				} finally {
				}
			}

			static Delegate cb_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetTranscodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == null)
					cb_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TranscodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_);
				return cb_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
			}

			static IntPtr n_TranscodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src, IntPtr native_dst)
			{
				global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack.Transcoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack.Transcoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer src = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_src, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer dst = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_dst, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TranscodeFrame (src, dst));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='TranscodeTrack.Transcoder']/method[@name='transcodeFrame' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.nio.ByteBuffer']]"
			[Register ("transcodeFrame", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "GetTranscodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe global::Java.Nio.ByteBuffer TranscodeFrame (global::Java.Nio.ByteBuffer src, global::Java.Nio.ByteBuffer dst)
			{
				if (id_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "transcodeFrame", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (src);
					__args [1] = new JValue (dst);

					global::Java.Nio.ByteBuffer __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transcodeFrame", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/TranscodeTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TranscodeTrack); }
		}

		protected TranscodeTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getPreferredTimescale;
#pragma warning disable 0169
		static Delegate GetGetPreferredTimescaleHandler ()
		{
			if (cb_getPreferredTimescale == null)
				cb_getPreferredTimescale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPreferredTimescale);
			return cb_getPreferredTimescale;
		}

		static int n_GetPreferredTimescale (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreferredTimescale;
		}
#pragma warning restore 0169

		static IntPtr id_getPreferredTimescale;
		public virtual unsafe int PreferredTimescale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='TranscodeTrack']/method[@name='getPreferredTimescale' and count(parameter)=0]"
			[Register ("getPreferredTimescale", "()I", "GetGetPreferredTimescaleHandler")]
			get {
				if (id_getPreferredTimescale == IntPtr.Zero)
					id_getPreferredTimescale = JNIEnv.GetMethodID (class_ref, "getPreferredTimescale", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreferredTimescale);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreferredTimescale", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='TranscodeTrack']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_;
#pragma warning disable 0169
		static Delegate GetGetCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_Handler ()
		{
			if (cb_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_ == null)
				cb_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_);
			return cb_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_;
		}

		static void n_GetCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Size p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetCodecPrivate (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='TranscodeTrack']/method[@name='getCodecPrivate' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='org.jcodec.common.model.Size']]"
		[Register ("getCodecPrivate", "(Ljava/nio/ByteBuffer;Lorg/jcodec/common/model/Size;)V", "GetGetCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_Handler")]
		protected abstract void GetCodecPrivate (global::Java.Nio.ByteBuffer p0, global::Org.Jcodec.Common.Model.Size p1);

		static Delegate cb_getFrameSize_II;
#pragma warning disable 0169
		static Delegate GetGetFrameSize_IIHandler ()
		{
			if (cb_getFrameSize_II == null)
				cb_getFrameSize_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetFrameSize_II);
			return cb_getFrameSize_II;
		}

		static int n_GetFrameSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.TranscodeTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetFrameSize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='TranscodeTrack']/method[@name='getFrameSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getFrameSize", "(II)I", "GetGetFrameSize_IIHandler")]
		protected abstract int GetFrameSize (int p0, int p1);

	}

	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/TranscodeTrack", DoNotGenerateAcw=true)]
	internal partial class TranscodeTrackInvoker : TranscodeTrack {

		public TranscodeTrackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TranscodeTrackInvoker); }
		}

		static IntPtr id_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='TranscodeTrack']/method[@name='getCodecPrivate' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='org.jcodec.common.model.Size']]"
		[Register ("getCodecPrivate", "(Ljava/nio/ByteBuffer;Lorg/jcodec/common/model/Size;)V", "GetGetCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_Handler")]
		protected override unsafe void GetCodecPrivate (global::Java.Nio.ByteBuffer p0, global::Org.Jcodec.Common.Model.Size p1)
		{
			if (id_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_ == IntPtr.Zero)
				id_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_ = JNIEnv.GetMethodID (class_ref, "getCodecPrivate", "(Ljava/nio/ByteBuffer;Lorg/jcodec/common/model/Size;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCodecPrivate_Ljava_nio_ByteBuffer_Lorg_jcodec_common_model_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_getFrameSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='TranscodeTrack']/method[@name='getFrameSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getFrameSize", "(II)I", "GetGetFrameSize_IIHandler")]
		protected override unsafe int GetFrameSize (int p0, int p1)
		{
			if (id_getFrameSize_II == IntPtr.Zero)
				id_getFrameSize_II = JNIEnv.GetMethodID (class_ref, "getFrameSize", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFrameSize_II, __args);
			} finally {
			}
		}

	}

}
