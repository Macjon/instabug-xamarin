using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4.Muxer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='PCMMP4MuxerTrack']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/muxer/PCMMP4MuxerTrack", DoNotGenerateAcw=true)]
	public partial class PCMMP4MuxerTrack : global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/muxer/PCMMP4MuxerTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PCMMP4MuxerTrack); }
		}

		protected PCMMP4MuxerTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getTrackTotalDuration;
#pragma warning disable 0169
		static Delegate GetGetTrackTotalDurationHandler ()
		{
			if (cb_getTrackTotalDuration == null)
				cb_getTrackTotalDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTrackTotalDuration);
			return cb_getTrackTotalDuration;
		}

		static long n_GetTrackTotalDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.PCMMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.PCMMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackTotalDuration;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackTotalDuration;
		public override unsafe long TrackTotalDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='PCMMP4MuxerTrack']/method[@name='getTrackTotalDuration' and count(parameter)=0]"
			[Register ("getTrackTotalDuration", "()J", "GetGetTrackTotalDurationHandler")]
			get {
				if (id_getTrackTotalDuration == IntPtr.Zero)
					id_getTrackTotalDuration = JNIEnv.GetMethodID (class_ref, "getTrackTotalDuration", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTrackTotalDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackTotalDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_addSamples_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetAddSamples_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_addSamples_Ljava_nio_ByteBuffer_ == null)
				cb_addSamples_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSamples_Ljava_nio_ByteBuffer_);
			return cb_addSamples_Ljava_nio_ByteBuffer_;
		}

		static void n_AddSamples_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.PCMMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.PCMMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.AddSamples (buffer);
		}
#pragma warning restore 0169

		static IntPtr id_addSamples_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='PCMMP4MuxerTrack']/method[@name='addSamples' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("addSamples", "(Ljava/nio/ByteBuffer;)V", "GetAddSamples_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void AddSamples (global::Java.Nio.ByteBuffer buffer)
		{
			if (id_addSamples_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_addSamples_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "addSamples", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (buffer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSamples_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSamples", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
