using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGES']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPEGES", DoNotGenerateAcw=true)]
	public partial class MPEGES : global::Org.Jcodec.Codecs.Mpeg12.SegmentReader {


		static IntPtr curPts_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGES']/field[@name='curPts']"
		[Register ("curPts")]
		public long CurPts {
			get {
				if (curPts_jfieldId == IntPtr.Zero)
					curPts_jfieldId = JNIEnv.GetFieldID (class_ref, "curPts", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, curPts_jfieldId);
			}
			set {
				if (curPts_jfieldId == IntPtr.Zero)
					curPts_jfieldId = JNIEnv.GetFieldID (class_ref, "curPts", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, curPts_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPEGES", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPEGES); }
		}

		protected MPEGES (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_channels_ReadableByteChannel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGES']/constructor[@name='MPEGES' and count(parameter)=1 and parameter[1][@type='java.nio.channels.ReadableByteChannel']]"
		[Register (".ctor", "(Ljava/nio/channels/ReadableByteChannel;)V", "")]
		public unsafe MPEGES (global::Java.Nio.Channels.IReadableByteChannel channel)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (channel);
				if (((object) this).GetType () != typeof (MPEGES)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/channels/ReadableByteChannel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/channels/ReadableByteChannel;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_channels_ReadableByteChannel_ == IntPtr.Zero)
					id_ctor_Ljava_nio_channels_ReadableByteChannel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/channels/ReadableByteChannel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_nio_channels_ReadableByteChannel_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGES']/constructor[@name='MPEGES' and count(parameter)=2 and parameter[1][@type='java.nio.channels.ReadableByteChannel'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/nio/channels/ReadableByteChannel;I)V", "")]
		public unsafe MPEGES (global::Java.Nio.Channels.IReadableByteChannel channel, int fetchSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (channel);
				__args [1] = new JValue (fetchSize);
				if (((object) this).GetType () != typeof (MPEGES)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/channels/ReadableByteChannel;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/channels/ReadableByteChannel;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_channels_ReadableByteChannel_I == IntPtr.Zero)
					id_ctor_Ljava_nio_channels_ReadableByteChannel_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/channels/ReadableByteChannel;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_I, __args);
			} finally {
			}
		}

		static Delegate cb_getFrame_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetGetFrame_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_getFrame_Ljava_nio_ByteBuffer_ == null)
				cb_getFrame_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFrame_Ljava_nio_ByteBuffer_);
			return cb_getFrame_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_GetFrame_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGES __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGES> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFrame (buffer));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFrame_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGES']/method[@name='getFrame' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getFrame", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/MPSDemuxer$MPEGPacket;", "GetGetFrame_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket GetFrame (global::Java.Nio.ByteBuffer buffer)
		{
			if (id_getFrame_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_getFrame_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "getFrame", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/MPSDemuxer$MPEGPacket;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (buffer);

				global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFrame_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrame", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/MPSDemuxer$MPEGPacket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
