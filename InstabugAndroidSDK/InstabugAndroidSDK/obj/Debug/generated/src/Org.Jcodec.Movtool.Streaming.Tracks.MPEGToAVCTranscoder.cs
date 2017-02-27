using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPEGToAVCTranscoder']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/MPEGToAVCTranscoder", DoNotGenerateAcw=true)]
	public partial class MPEGToAVCTranscoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/MPEGToAVCTranscoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPEGToAVCTranscoder); }
		}

		protected MPEGToAVCTranscoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPEGToAVCTranscoder']/constructor[@name='MPEGToAVCTranscoder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe MPEGToAVCTranscoder (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MPEGToAVCTranscoder)) {
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

		static Delegate cb_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZI;
#pragma warning disable 0169
		static Delegate GetTranscodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZIHandler ()
		{
			if (cb_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZI == null)
				cb_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, int, IntPtr>) n_TranscodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZI);
			return cb_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZI;
		}

		static IntPtr n_TranscodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, int p3)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.MPEGToAVCTranscoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPEGToAVCTranscoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TranscodeFrame (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPEGToAVCTranscoder']/method[@name='transcodeFrame' and count(parameter)=4 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("transcodeFrame", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;ZI)Ljava/nio/ByteBuffer;", "GetTranscodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZIHandler")]
		public virtual unsafe global::Java.Nio.ByteBuffer TranscodeFrame (global::Java.Nio.ByteBuffer p0, global::Java.Nio.ByteBuffer p1, bool p2, int p3)
		{
			if (id_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZI == IntPtr.Zero)
				id_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZI = JNIEnv.GetMethodID (class_ref, "transcodeFrame", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;ZI)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Java.Nio.ByteBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transcodeFrame_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ZI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transcodeFrame", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;ZI)Ljava/nio/ByteBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
