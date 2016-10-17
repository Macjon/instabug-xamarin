using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/StereoDownmixTrack", DoNotGenerateAcw=true)]
	public partial class StereoDownmixTrack : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack.DownmixVirtualPacket']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/StereoDownmixTrack$DownmixVirtualPacket", DoNotGenerateAcw=true)]
		protected internal partial class DownmixVirtualPacket : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/StereoDownmixTrack$DownmixVirtualPacket", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DownmixVirtualPacket); }
			}

			protected DownmixVirtualPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Data);
			}
#pragma warning restore 0169

			static IntPtr id_getData;
			public virtual unsafe global::Java.Nio.ByteBuffer Data {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack.DownmixVirtualPacket']/method[@name='getData' and count(parameter)=0]"
				[Register ("getData", "()Ljava/nio/ByteBuffer;", "GetGetDataHandler")]
				get {
					if (id_getData == IntPtr.Zero)
						id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/nio/ByteBuffer;");
					try {

						if (GetType () == ThresholdType)
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
				global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DataLen;
			}
#pragma warning restore 0169

			static IntPtr id_getDataLen;
			public virtual unsafe int DataLen {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack.DownmixVirtualPacket']/method[@name='getDataLen' and count(parameter)=0]"
				[Register ("getDataLen", "()I", "GetGetDataLenHandler")]
				get {
					if (id_getDataLen == IntPtr.Zero)
						id_getDataLen = JNIEnv.GetMethodID (class_ref, "getDataLen", "()I");
					try {

						if (GetType () == ThresholdType)
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
				global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Duration;
			}
#pragma warning restore 0169

			static IntPtr id_getDuration;
			public virtual unsafe double Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack.DownmixVirtualPacket']/method[@name='getDuration' and count(parameter)=0]"
				[Register ("getDuration", "()D", "GetGetDurationHandler")]
				get {
					if (id_getDuration == IntPtr.Zero)
						id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()D");
					try {

						if (GetType () == ThresholdType)
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
				global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FrameNo;
			}
#pragma warning restore 0169

			static IntPtr id_getFrameNo;
			public virtual unsafe int FrameNo {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack.DownmixVirtualPacket']/method[@name='getFrameNo' and count(parameter)=0]"
				[Register ("getFrameNo", "()I", "GetGetFrameNoHandler")]
				get {
					if (id_getFrameNo == IntPtr.Zero)
						id_getFrameNo = JNIEnv.GetMethodID (class_ref, "getFrameNo", "()I");
					try {

						if (GetType () == ThresholdType)
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
				global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsKeyframe;
			}
#pragma warning restore 0169

			static IntPtr id_isKeyframe;
			public virtual unsafe bool IsKeyframe {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack.DownmixVirtualPacket']/method[@name='isKeyframe' and count(parameter)=0]"
				[Register ("isKeyframe", "()Z", "GetIsKeyframeHandler")]
				get {
					if (id_isKeyframe == IntPtr.Zero)
						id_isKeyframe = JNIEnv.GetMethodID (class_ref, "isKeyframe", "()Z");
					try {

						if (GetType () == ThresholdType)
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
				global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack.DownmixVirtualPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Pts;
			}
#pragma warning restore 0169

			static IntPtr id_getPts;
			public virtual unsafe double Pts {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack.DownmixVirtualPacket']/method[@name='getPts' and count(parameter)=0]"
				[Register ("getPts", "()D", "GetGetPtsHandler")]
				get {
					if (id_getPts == IntPtr.Zero)
						id_getPts = JNIEnv.GetMethodID (class_ref, "getPts", "()D");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getPts);
						else
							return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPts", "()D"));
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/StereoDownmixTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StereoDownmixTrack); }
		}

		protected StereoDownmixTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreferredTimescale;
		}
#pragma warning restore 0169

		static IntPtr id_getPreferredTimescale;
		public virtual unsafe int PreferredTimescale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack']/method[@name='getPreferredTimescale' and count(parameter)=0]"
			[Register ("getPreferredTimescale", "()I", "GetGetPreferredTimescaleHandler")]
			get {
				if (id_getPreferredTimescale == IntPtr.Zero)
					id_getPreferredTimescale = JNIEnv.GetMethodID (class_ref, "getPreferredTimescale", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreferredTimescale);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreferredTimescale", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_bulkGetSolo;
#pragma warning disable 0169
		static Delegate GetBulkGetSoloHandler ()
		{
			if (cb_bulkGetSolo == null)
				cb_bulkGetSolo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BulkGetSolo);
			return cb_bulkGetSolo;
		}

		static IntPtr n_BulkGetSolo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.BulkGetSolo ());
		}
#pragma warning restore 0169

		static IntPtr id_bulkGetSolo;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack']/method[@name='bulkGetSolo' and count(parameter)=0]"
		[Register ("bulkGetSolo", "()[[Z", "GetBulkGetSoloHandler")]
		public virtual unsafe bool[][] BulkGetSolo ()
		{
			if (id_bulkGetSolo == IntPtr.Zero)
				id_bulkGetSolo = JNIEnv.GetMethodID (class_ref, "bulkGetSolo", "()[[Z");
			try {

				if (GetType () == ThresholdType)
					return (bool[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_bulkGetSolo), JniHandleOwnership.TransferLocalRef, typeof (bool[]));
				else
					return (bool[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bulkGetSolo", "()[[Z")), JniHandleOwnership.TransferLocalRef, typeof (bool[]));
			} finally {
			}
		}

		static Delegate cb_bulkSetSolo_arrayarrayZ;
#pragma warning disable 0169
		static Delegate GetBulkSetSolo_arrayarrayZHandler ()
		{
			if (cb_bulkSetSolo_arrayarrayZ == null)
				cb_bulkSetSolo_arrayarrayZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BulkSetSolo_arrayarrayZ);
			return cb_bulkSetSolo_arrayarrayZ;
		}

		static void n_BulkSetSolo_arrayarrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			bool[][] p0 = (bool[][]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (bool[]));
			__this.BulkSetSolo (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_bulkSetSolo_arrayarrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack']/method[@name='bulkSetSolo' and count(parameter)=1 and parameter[1][@type='boolean[][]']]"
		[Register ("bulkSetSolo", "([[Z)V", "GetBulkSetSolo_arrayarrayZHandler")]
		public virtual unsafe void BulkSetSolo (bool[][] p0)
		{
			if (id_bulkSetSolo_arrayarrayZ == IntPtr.Zero)
				id_bulkSetSolo_arrayarrayZ = JNIEnv.GetMethodID (class_ref, "bulkSetSolo", "([[Z)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bulkSetSolo_arrayarrayZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bulkSetSolo", "([[Z)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_isChannelMute_II;
#pragma warning disable 0169
		static Delegate GetIsChannelMute_IIHandler ()
		{
			if (cb_isChannelMute_II == null)
				cb_isChannelMute_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_IsChannelMute_II);
			return cb_isChannelMute_II;
		}

		static bool n_IsChannelMute_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChannelMute (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_isChannelMute_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack']/method[@name='isChannelMute' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("isChannelMute", "(II)Z", "GetIsChannelMute_IIHandler")]
		public virtual unsafe bool IsChannelMute (int p0, int p1)
		{
			if (id_isChannelMute_II == IntPtr.Zero)
				id_isChannelMute_II = JNIEnv.GetMethodID (class_ref, "isChannelMute", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isChannelMute_II, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChannelMute", "(II)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_muteAll;
#pragma warning disable 0169
		static Delegate GetMuteAllHandler ()
		{
			if (cb_muteAll == null)
				cb_muteAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MuteAll);
			return cb_muteAll;
		}

		static void n_MuteAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MuteAll ();
		}
#pragma warning restore 0169

		static IntPtr id_muteAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack']/method[@name='muteAll' and count(parameter)=0]"
		[Register ("muteAll", "()V", "GetMuteAllHandler")]
		public virtual unsafe void MuteAll ()
		{
			if (id_muteAll == IntPtr.Zero)
				id_muteAll = JNIEnv.GetMethodID (class_ref, "muteAll", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_muteAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "muteAll", "()V"));
			} finally {
			}
		}

		static Delegate cb_soloAll;
#pragma warning disable 0169
		static Delegate GetSoloAllHandler ()
		{
			if (cb_soloAll == null)
				cb_soloAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SoloAll);
			return cb_soloAll;
		}

		static void n_SoloAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SoloAll ();
		}
#pragma warning restore 0169

		static IntPtr id_soloAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack']/method[@name='soloAll' and count(parameter)=0]"
		[Register ("soloAll", "()V", "GetSoloAllHandler")]
		public virtual unsafe void SoloAll ()
		{
			if (id_soloAll == IntPtr.Zero)
				id_soloAll = JNIEnv.GetMethodID (class_ref, "soloAll", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_soloAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "soloAll", "()V"));
			} finally {
			}
		}

		static Delegate cb_soloChannel_IIZ;
#pragma warning disable 0169
		static Delegate GetSoloChannel_IIZHandler ()
		{
			if (cb_soloChannel_IIZ == null)
				cb_soloChannel_IIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, bool>) n_SoloChannel_IIZ);
			return cb_soloChannel_IIZ;
		}

		static void n_SoloChannel_IIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SoloChannel (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_soloChannel_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack']/method[@name='soloChannel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("soloChannel", "(IIZ)V", "GetSoloChannel_IIZHandler")]
		public virtual unsafe void SoloChannel (int p0, int p1, bool p2)
		{
			if (id_soloChannel_IIZ == IntPtr.Zero)
				id_soloChannel_IIZ = JNIEnv.GetMethodID (class_ref, "soloChannel", "(IIZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_soloChannel_IIZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "soloChannel", "(IIZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_soloTrack_IZ;
#pragma warning disable 0169
		static Delegate GetSoloTrack_IZHandler ()
		{
			if (cb_soloTrack_IZ == null)
				cb_soloTrack_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SoloTrack_IZ);
			return cb_soloTrack_IZ;
		}

		static void n_SoloTrack_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.StereoDownmixTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SoloTrack (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_soloTrack_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='StereoDownmixTrack']/method[@name='soloTrack' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("soloTrack", "(IZ)V", "GetSoloTrack_IZHandler")]
		public virtual unsafe void SoloTrack (int p0, bool p1)
		{
			if (id_soloTrack_IZ == IntPtr.Zero)
				id_soloTrack_IZ = JNIEnv.GetMethodID (class_ref, "soloTrack", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_soloTrack_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "soloTrack", "(IZ)V"), __args);
			} finally {
			}
		}

	}
}
