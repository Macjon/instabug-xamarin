using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='EditedPCMTrack']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/EditedPCMTrack", DoNotGenerateAcw=true)]
	public partial class EditedPCMTrack : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='EditedPCMTrack.EditedPCMPacket']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/EditedPCMTrack$EditedPCMPacket", DoNotGenerateAcw=true)]
		public partial class EditedPCMPacket : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/EditedPCMTrack$EditedPCMPacket", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EditedPCMPacket); }
			}

			protected EditedPCMPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Data);
			}
#pragma warning restore 0169

			static IntPtr id_getData;
			public virtual unsafe global::Java.Nio.ByteBuffer Data {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='EditedPCMTrack.EditedPCMPacket']/method[@name='getData' and count(parameter)=0]"
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
				global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DataLen;
			}
#pragma warning restore 0169

			static IntPtr id_getDataLen;
			public virtual unsafe int DataLen {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='EditedPCMTrack.EditedPCMPacket']/method[@name='getDataLen' and count(parameter)=0]"
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
				global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Duration;
			}
#pragma warning restore 0169

			static IntPtr id_getDuration;
			public virtual unsafe double Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='EditedPCMTrack.EditedPCMPacket']/method[@name='getDuration' and count(parameter)=0]"
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
				global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FrameNo;
			}
#pragma warning restore 0169

			static IntPtr id_getFrameNo;
			public virtual unsafe int FrameNo {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='EditedPCMTrack.EditedPCMPacket']/method[@name='getFrameNo' and count(parameter)=0]"
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
				global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsKeyframe;
			}
#pragma warning restore 0169

			static IntPtr id_isKeyframe;
			public virtual unsafe bool IsKeyframe {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='EditedPCMTrack.EditedPCMPacket']/method[@name='isKeyframe' and count(parameter)=0]"
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
				global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack.EditedPCMPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Pts;
			}
#pragma warning restore 0169

			static IntPtr id_getPts;
			public virtual unsafe double Pts {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='EditedPCMTrack.EditedPCMPacket']/method[@name='getPts' and count(parameter)=0]"
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
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/EditedPCMTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EditedPCMTrack); }
		}

		protected EditedPCMTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreferredTimescale;
		}
#pragma warning restore 0169

		static IntPtr id_getPreferredTimescale;
		public virtual unsafe int PreferredTimescale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='EditedPCMTrack']/method[@name='getPreferredTimescale' and count(parameter)=0]"
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
			global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.EditedPCMTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='EditedPCMTrack']/method[@name='close' and count(parameter)=0]"
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

	}
}
