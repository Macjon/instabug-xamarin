using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4.Muxer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='TimecodeMP4MuxerTrack']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/muxer/TimecodeMP4MuxerTrack", DoNotGenerateAcw=true)]
	public partial class TimecodeMP4MuxerTrack : global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/muxer/TimecodeMP4MuxerTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimecodeMP4MuxerTrack); }
		}

		protected TimecodeMP4MuxerTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addTimecode_Lorg_jcodec_common_model_Packet_;
#pragma warning disable 0169
		static Delegate GetAddTimecode_Lorg_jcodec_common_model_Packet_Handler ()
		{
			if (cb_addTimecode_Lorg_jcodec_common_model_Packet_ == null)
				cb_addTimecode_Lorg_jcodec_common_model_Packet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTimecode_Lorg_jcodec_common_model_Packet_);
			return cb_addTimecode_Lorg_jcodec_common_model_Packet_;
		}

		static void n_AddTimecode_Lorg_jcodec_common_model_Packet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.TimecodeMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.TimecodeMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Packet p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTimecode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addTimecode_Lorg_jcodec_common_model_Packet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='TimecodeMP4MuxerTrack']/method[@name='addTimecode' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Packet']]"
		[Register ("addTimecode", "(Lorg/jcodec/common/model/Packet;)V", "GetAddTimecode_Lorg_jcodec_common_model_Packet_Handler")]
		public virtual unsafe void AddTimecode (global::Org.Jcodec.Common.Model.Packet p0)
		{
			if (id_addTimecode_Lorg_jcodec_common_model_Packet_ == IntPtr.Zero)
				id_addTimecode_Lorg_jcodec_common_model_Packet_ = JNIEnv.GetMethodID (class_ref, "addTimecode", "(Lorg/jcodec/common/model/Packet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTimecode_Lorg_jcodec_common_model_Packet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTimecode", "(Lorg/jcodec/common/model/Packet;)V"), __args);
			} finally {
			}
		}

	}
}
