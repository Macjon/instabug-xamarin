using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Streaming {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/streaming/MXFVirtualTrack", DoNotGenerateAcw=true)]
	public partial class MXFVirtualTrack : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack.MXFVirtualPacket']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mxf/streaming/MXFVirtualTrack$MXFVirtualPacket", DoNotGenerateAcw=true)]
		public partial class MXFVirtualPacket : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mxf/streaming/MXFVirtualTrack$MXFVirtualPacket", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MXFVirtualPacket); }
			}

			protected MXFVirtualPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_containers_mxf_streaming_MXFVirtualTrack_Lorg_jcodec_containers_mxf_MXFDemuxer_MXFPacket_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack.MXFVirtualPacket']/constructor[@name='MXFVirtualTrack.MXFVirtualPacket' and count(parameter)=2 and parameter[1][@type='org.jcodec.containers.mxf.streaming.MXFVirtualTrack'] and parameter[2][@type='org.jcodec.containers.mxf.MXFDemuxer.MXFPacket']]"
			[Register (".ctor", "(Lorg/jcodec/containers/mxf/streaming/MXFVirtualTrack;Lorg/jcodec/containers/mxf/MXFDemuxer$MXFPacket;)V", "")]
			public unsafe MXFVirtualPacket (global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack __self, global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFPacket pkt)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (pkt);
					if (((object) this).GetType () != typeof (MXFVirtualPacket)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/jcodec/containers/mxf/MXFDemuxer$MXFPacket;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/jcodec/containers/mxf/MXFDemuxer$MXFPacket;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_containers_mxf_streaming_MXFVirtualTrack_Lorg_jcodec_containers_mxf_MXFDemuxer_MXFPacket_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_containers_mxf_streaming_MXFVirtualTrack_Lorg_jcodec_containers_mxf_MXFDemuxer_MXFPacket_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mxf/streaming/MXFVirtualTrack;Lorg/jcodec/containers/mxf/MXFDemuxer$MXFPacket;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mxf_streaming_MXFVirtualTrack_Lorg_jcodec_containers_mxf_MXFDemuxer_MXFPacket_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mxf_streaming_MXFVirtualTrack_Lorg_jcodec_containers_mxf_MXFDemuxer_MXFPacket_, __args);
				} finally {
				}
			}

			static Delegate cb_getData;
#pragma warning disable 0169
			static Delegate GetGetDataHandler ()
			{
				if (cb_getData == null)
					cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
				return cb_getData;
			}

			static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Data);
			}
#pragma warning restore 0169

			static IntPtr id_getData;
			public virtual unsafe global::Java.Nio.ByteBuffer Data {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack.MXFVirtualPacket']/method[@name='getData' and count(parameter)=0]"
				[Register ("getData", "()Ljava/nio/ByteBuffer;", "GetGetDataHandler")]
				get {
					if (id_getData == IntPtr.Zero)
						id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/nio/ByteBuffer;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getDataLen;
#pragma warning disable 0169
			static Delegate GetGetDataLenHandler ()
			{
				if (cb_getDataLen == null)
					cb_getDataLen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDataLen);
				return cb_getDataLen;
			}

			static int n_GetDataLen (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DataLen;
			}
#pragma warning restore 0169

			static IntPtr id_getDataLen;
			public virtual unsafe int DataLen {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack.MXFVirtualPacket']/method[@name='getDataLen' and count(parameter)=0]"
				[Register ("getDataLen", "()I", "GetGetDataLenHandler")]
				get {
					if (id_getDataLen == IntPtr.Zero)
						id_getDataLen = JNIEnv.GetMethodID (class_ref, "getDataLen", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDataLen);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataLen", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getDuration;
#pragma warning disable 0169
			static Delegate GetGetDurationHandler ()
			{
				if (cb_getDuration == null)
					cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDuration);
				return cb_getDuration;
			}

			static double n_GetDuration (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Duration;
			}
#pragma warning restore 0169

			static IntPtr id_getDuration;
			public virtual unsafe double Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack.MXFVirtualPacket']/method[@name='getDuration' and count(parameter)=0]"
				[Register ("getDuration", "()D", "GetGetDurationHandler")]
				get {
					if (id_getDuration == IntPtr.Zero)
						id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()D");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
						else
							return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()D"));
					} finally {
					}
				}
			}

			static Delegate cb_getFrameNo;
#pragma warning disable 0169
			static Delegate GetGetFrameNoHandler ()
			{
				if (cb_getFrameNo == null)
					cb_getFrameNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameNo);
				return cb_getFrameNo;
			}

			static int n_GetFrameNo (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FrameNo;
			}
#pragma warning restore 0169

			static IntPtr id_getFrameNo;
			public virtual unsafe int FrameNo {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack.MXFVirtualPacket']/method[@name='getFrameNo' and count(parameter)=0]"
				[Register ("getFrameNo", "()I", "GetGetFrameNoHandler")]
				get {
					if (id_getFrameNo == IntPtr.Zero)
						id_getFrameNo = JNIEnv.GetMethodID (class_ref, "getFrameNo", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFrameNo);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameNo", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_isKeyframe;
#pragma warning disable 0169
			static Delegate GetIsKeyframeHandler ()
			{
				if (cb_isKeyframe == null)
					cb_isKeyframe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsKeyframe);
				return cb_isKeyframe;
			}

			static bool n_IsKeyframe (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsKeyframe;
			}
#pragma warning restore 0169

			static IntPtr id_isKeyframe;
			public virtual unsafe bool IsKeyframe {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack.MXFVirtualPacket']/method[@name='isKeyframe' and count(parameter)=0]"
				[Register ("isKeyframe", "()Z", "GetIsKeyframeHandler")]
				get {
					if (id_isKeyframe == IntPtr.Zero)
						id_isKeyframe = JNIEnv.GetMethodID (class_ref, "isKeyframe", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isKeyframe);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isKeyframe", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_getPts;
#pragma warning disable 0169
			static Delegate GetGetPtsHandler ()
			{
				if (cb_getPts == null)
					cb_getPts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetPts);
				return cb_getPts;
			}

			static double n_GetPts (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack.MXFVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Pts;
			}
#pragma warning restore 0169

			static IntPtr id_getPts;
			public virtual unsafe double Pts {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack.MXFVirtualPacket']/method[@name='getPts' and count(parameter)=0]"
				[Register ("getPts", "()D", "GetGetPtsHandler")]
				get {
					if (id_getPts == IntPtr.Zero)
						id_getPts = JNIEnv.GetMethodID (class_ref, "getPts", "()D");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getPts);
						else
							return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPts", "()D"));
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack.PatchedMXFDemuxer']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mxf/streaming/MXFVirtualTrack$PatchedMXFDemuxer", DoNotGenerateAcw=true)]
		public partial class PatchedMXFDemuxer : global::Org.Jcodec.Containers.Mxf.MXFDemuxer {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mxf/streaming/MXFVirtualTrack$PatchedMXFDemuxer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PatchedMXFDemuxer); }
			}

			protected PatchedMXFDemuxer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/streaming/MXFVirtualTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MXFVirtualTrack); }
		}

		protected MXFVirtualTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreferredTimescale;
		}
#pragma warning restore 0169

		static IntPtr id_getPreferredTimescale;
		public virtual unsafe int PreferredTimescale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack']/method[@name='getPreferredTimescale' and count(parameter)=0]"
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

		static Delegate cb_getTrackId;
#pragma warning disable 0169
		static Delegate GetGetTrackIdHandler ()
		{
			if (cb_getTrackId == null)
				cb_getTrackId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTrackId);
			return cb_getTrackId;
		}

		static int n_GetTrackId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackId;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackId;
		public virtual unsafe int TrackId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack']/method[@name='getTrackId' and count(parameter)=0]"
			[Register ("getTrackId", "()I", "GetGetTrackIdHandler")]
			get {
				if (id_getTrackId == IntPtr.Zero)
					id_getTrackId = JNIEnv.GetMethodID (class_ref, "getTrackId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTrackId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackId", "()I"));
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
			global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Streaming.MXFVirtualTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.streaming']/class[@name='MXFVirtualTrack']/method[@name='close' and count(parameter)=0]"
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

	}
}
