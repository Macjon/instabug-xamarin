using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4.Muxer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='FramesMP4MuxerTrack']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/muxer/FramesMP4MuxerTrack", DoNotGenerateAcw=true)]
	public partial class FramesMP4MuxerTrack : global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/muxer/FramesMP4MuxerTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FramesMP4MuxerTrack); }
		}

		protected FramesMP4MuxerTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getTimecodeTrack;
#pragma warning disable 0169
		static Delegate GetGetTimecodeTrackHandler ()
		{
			if (cb_getTimecodeTrack == null)
				cb_getTimecodeTrack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimecodeTrack);
			return cb_getTimecodeTrack;
		}

		static IntPtr n_GetTimecodeTrack (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimecodeTrack);
		}
#pragma warning restore 0169

		static IntPtr id_getTimecodeTrack;
		public virtual unsafe global::Org.Jcodec.Containers.Mp4.Muxer.TimecodeMP4MuxerTrack TimecodeTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='FramesMP4MuxerTrack']/method[@name='getTimecodeTrack' and count(parameter)=0]"
			[Register ("getTimecodeTrack", "()Lorg/jcodec/containers/mp4/muxer/TimecodeMP4MuxerTrack;", "GetGetTimecodeTrackHandler")]
			get {
				if (id_getTimecodeTrack == IntPtr.Zero)
					id_getTimecodeTrack = JNIEnv.GetMethodID (class_ref, "getTimecodeTrack", "()Lorg/jcodec/containers/mp4/muxer/TimecodeMP4MuxerTrack;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.TimecodeMP4MuxerTrack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimecodeTrack), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.TimecodeMP4MuxerTrack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimecodeTrack", "()Lorg/jcodec/containers/mp4/muxer/TimecodeMP4MuxerTrack;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

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
			global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackTotalDuration;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackTotalDuration;
		public override unsafe long TrackTotalDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='FramesMP4MuxerTrack']/method[@name='getTrackTotalDuration' and count(parameter)=0]"
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

		static Delegate cb_addFrame_Lorg_jcodec_containers_mp4_MP4Packet_;
#pragma warning disable 0169
		static Delegate GetAddFrame_Lorg_jcodec_containers_mp4_MP4Packet_Handler ()
		{
			if (cb_addFrame_Lorg_jcodec_containers_mp4_MP4Packet_ == null)
				cb_addFrame_Lorg_jcodec_containers_mp4_MP4Packet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFrame_Lorg_jcodec_containers_mp4_MP4Packet_);
			return cb_addFrame_Lorg_jcodec_containers_mp4_MP4Packet_;
		}

		static void n_AddFrame_Lorg_jcodec_containers_mp4_MP4Packet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pkt)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mp4.MP4Packet pkt = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.MP4Packet> (native_pkt, JniHandleOwnership.DoNotTransfer);
			__this.AddFrame (pkt);
		}
#pragma warning restore 0169

		static IntPtr id_addFrame_Lorg_jcodec_containers_mp4_MP4Packet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='FramesMP4MuxerTrack']/method[@name='addFrame' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mp4.MP4Packet']]"
		[Register ("addFrame", "(Lorg/jcodec/containers/mp4/MP4Packet;)V", "GetAddFrame_Lorg_jcodec_containers_mp4_MP4Packet_Handler")]
		public virtual unsafe void AddFrame (global::Org.Jcodec.Containers.Mp4.MP4Packet pkt)
		{
			if (id_addFrame_Lorg_jcodec_containers_mp4_MP4Packet_ == IntPtr.Zero)
				id_addFrame_Lorg_jcodec_containers_mp4_MP4Packet_ = JNIEnv.GetMethodID (class_ref, "addFrame", "(Lorg/jcodec/containers/mp4/MP4Packet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pkt);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFrame_Lorg_jcodec_containers_mp4_MP4Packet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFrame", "(Lorg/jcodec/containers/mp4/MP4Packet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_;
#pragma warning disable 0169
		static Delegate GetSetTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_Handler ()
		{
			if (cb_setTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_ == null)
				cb_setTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_);
			return cb_setTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_;
		}

		static void n_SetTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_timecodeTrack)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mp4.Muxer.TimecodeMP4MuxerTrack timecodeTrack = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.TimecodeMP4MuxerTrack> (native_timecodeTrack, JniHandleOwnership.DoNotTransfer);
			__this.SetTimecode (timecodeTrack);
		}
#pragma warning restore 0169

		static IntPtr id_setTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='FramesMP4MuxerTrack']/method[@name='setTimecode' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mp4.muxer.TimecodeMP4MuxerTrack']]"
		[Register ("setTimecode", "(Lorg/jcodec/containers/mp4/muxer/TimecodeMP4MuxerTrack;)V", "GetSetTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_Handler")]
		public virtual unsafe void SetTimecode (global::Org.Jcodec.Containers.Mp4.Muxer.TimecodeMP4MuxerTrack timecodeTrack)
		{
			if (id_setTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_ == IntPtr.Zero)
				id_setTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_ = JNIEnv.GetMethodID (class_ref, "setTimecode", "(Lorg/jcodec/containers/mp4/muxer/TimecodeMP4MuxerTrack;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timecodeTrack);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimecode_Lorg_jcodec_containers_mp4_muxer_TimecodeMP4MuxerTrack_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimecode", "(Lorg/jcodec/containers/mp4/muxer/TimecodeMP4MuxerTrack;)V"), __args);
			} finally {
			}
		}

	}
}
