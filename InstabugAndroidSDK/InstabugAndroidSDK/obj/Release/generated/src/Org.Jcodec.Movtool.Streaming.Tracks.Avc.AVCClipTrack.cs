using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks.Avc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks.avc']/class[@name='AVCClipTrack']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/avc/AVCClipTrack", DoNotGenerateAcw=true)]
	public partial class AVCClipTrack : global::Org.Jcodec.Movtool.Streaming.Tracks.ClipTrack {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks.avc']/class[@name='AVCClipTrack.GopTranscoder']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/avc/AVCClipTrack$GopTranscoder", DoNotGenerateAcw=true)]
		public partial class GopTranscoder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/avc/AVCClipTrack$GopTranscoder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GopTranscoder); }
			}

			protected GopTranscoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getResult;
#pragma warning disable 0169
			static Delegate GetGetResultHandler ()
			{
				if (cb_getResult == null)
					cb_getResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResult);
				return cb_getResult;
			}

			static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Movtool.Streaming.Tracks.Avc.AVCClipTrack.GopTranscoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.Avc.AVCClipTrack.GopTranscoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (__this.Result);
			}
#pragma warning restore 0169

			static IntPtr id_getResult;
			public virtual unsafe global::System.Collections.Generic.IList<global::Java.Nio.ByteBuffer> Result {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks.avc']/class[@name='AVCClipTrack.GopTranscoder']/method[@name='getResult' and count(parameter)=0]"
				[Register ("getResult", "()Ljava/util/List;", "GetGetResultHandler")]
				get {
					if (id_getResult == IntPtr.Zero)
						id_getResult = JNIEnv.GetMethodID (class_ref, "getResult", "()Ljava/util/List;");
					try {

						if (GetType () == ThresholdType)
							return global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResult), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResult", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_transcode;
#pragma warning disable 0169
			static Delegate GetTranscodeHandler ()
			{
				if (cb_transcode == null)
					cb_transcode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Transcode);
				return cb_transcode;
			}

			static IntPtr n_Transcode (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Movtool.Streaming.Tracks.Avc.AVCClipTrack.GopTranscoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.Avc.AVCClipTrack.GopTranscoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (__this.Transcode ());
			}
#pragma warning restore 0169

			static IntPtr id_transcode;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks.avc']/class[@name='AVCClipTrack.GopTranscoder']/method[@name='transcode' and count(parameter)=0]"
			[Register ("transcode", "()Ljava/util/List;", "GetTranscodeHandler")]
			public virtual unsafe global::System.Collections.Generic.IList<global::Java.Nio.ByteBuffer> Transcode ()
			{
				if (id_transcode == IntPtr.Zero)
					id_transcode = JNIEnv.GetMethodID (class_ref, "transcode", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transcode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transcode", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks.avc']/class[@name='AVCClipTrack.TranscodePacket']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/avc/AVCClipTrack$TranscodePacket", DoNotGenerateAcw=true)]
		public partial class TranscodePacket : global::Org.Jcodec.Movtool.Streaming.Tracks.VirtualPacketWrapper {

			protected TranscodePacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		protected AVCClipTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
