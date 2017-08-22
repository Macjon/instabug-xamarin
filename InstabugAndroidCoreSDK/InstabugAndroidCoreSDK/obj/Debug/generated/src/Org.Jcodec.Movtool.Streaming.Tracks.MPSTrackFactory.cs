using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/MPSTrackFactory", DoNotGenerateAcw=true)]
	public partial class MPSTrackFactory : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/MPSTrackFactory$Stream", DoNotGenerateAcw=true)]
		public partial class Stream : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream.MPSPacket']"
			[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/MPSTrackFactory$Stream$MPSPacket", DoNotGenerateAcw=true)]
			protected internal partial class MPSPacket : global::Java.Lang.Object {

				internal static new IntPtr java_class_handle;
				internal static new IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/MPSTrackFactory$Stream$MPSPacket", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (MPSPacket); }
				}

				protected MPSPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor_Lorg_jcodec_movtool_streaming_tracks_MPSTrackFactory_Stream_IJII;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream.MPSPacket']/constructor[@name='MPSTrackFactory.Stream.MPSPacket' and count(parameter)=5 and parameter[1][@type='org.jcodec.movtool.streaming.tracks.MPSTrackFactory.Stream'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
				[Register (".ctor", "(Lorg/jcodec/movtool/streaming/tracks/MPSTrackFactory$Stream;IJII)V", "")]
				public unsafe MPSPacket (global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream __self, int pesOff, long fileOff, int curFrame, int pesIdx)
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						JValue* __args = stackalloc JValue [5];
						__args [0] = new JValue (__self);
						__args [1] = new JValue (pesOff);
						__args [2] = new JValue (fileOff);
						__args [3] = new JValue (curFrame);
						__args [4] = new JValue (pesIdx);
						if (((object) this).GetType () != typeof (MPSPacket)) {
							SetHandle (
									global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IJII)V", __args),
									JniHandleOwnership.TransferLocalRef);
							global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IJII)V", __args);
							return;
						}

						if (id_ctor_Lorg_jcodec_movtool_streaming_tracks_MPSTrackFactory_Stream_IJII == IntPtr.Zero)
							id_ctor_Lorg_jcodec_movtool_streaming_tracks_MPSTrackFactory_Stream_IJII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/movtool/streaming/tracks/MPSTrackFactory$Stream;IJII)V");
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_MPSTrackFactory_Stream_IJII, __args),
								JniHandleOwnership.TransferLocalRef);
						JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_MPSTrackFactory_Stream_IJII, __args);
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
					global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.Data);
				}
#pragma warning restore 0169

				static IntPtr id_getData;
				public virtual unsafe global::Java.Nio.ByteBuffer Data {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream.MPSPacket']/method[@name='getData' and count(parameter)=0]"
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
					global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.DataLen;
				}
#pragma warning restore 0169

				static IntPtr id_getDataLen;
				public virtual unsafe int DataLen {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream.MPSPacket']/method[@name='getDataLen' and count(parameter)=0]"
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
					global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.Duration;
				}
#pragma warning restore 0169

				static IntPtr id_getDuration;
				public virtual unsafe double Duration {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream.MPSPacket']/method[@name='getDuration' and count(parameter)=0]"
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
					global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.FrameNo;
				}
#pragma warning restore 0169

				static IntPtr id_getFrameNo;
				public virtual unsafe int FrameNo {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream.MPSPacket']/method[@name='getFrameNo' and count(parameter)=0]"
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
					global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.IsKeyframe;
				}
#pragma warning restore 0169

				static IntPtr id_isKeyframe;
				public virtual unsafe bool IsKeyframe {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream.MPSPacket']/method[@name='isKeyframe' and count(parameter)=0]"
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
					global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream.MPSPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.Pts;
				}
#pragma warning restore 0169

				static IntPtr id_getPts;
				public virtual unsafe double Pts {
					// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream.MPSPacket']/method[@name='getPts' and count(parameter)=0]"
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

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/MPSTrackFactory$Stream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Stream); }
			}

			protected Stream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_movtool_streaming_tracks_MPSTrackFactory_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream']/constructor[@name='MPSTrackFactory.Stream' and count(parameter)=2 and parameter[1][@type='org.jcodec.movtool.streaming.tracks.MPSTrackFactory'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lorg/jcodec/movtool/streaming/tracks/MPSTrackFactory;I)V", "")]
			public unsafe Stream (global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory __self, int streamId)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (streamId);
					if (((object) this).GetType () != typeof (Stream)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_movtool_streaming_tracks_MPSTrackFactory_I == IntPtr.Zero)
						id_ctor_Lorg_jcodec_movtool_streaming_tracks_MPSTrackFactory_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/movtool/streaming/tracks/MPSTrackFactory;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_MPSTrackFactory_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_MPSTrackFactory_I, __args);
				} finally {
				}
			}

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
				global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.PreferredTimescale;
			}
#pragma warning restore 0169

			static IntPtr id_getPreferredTimescale;
			public virtual unsafe int PreferredTimescale {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream']/method[@name='getPreferredTimescale' and count(parameter)=0]"
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
				global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream']/method[@name='close' and count(parameter)=0]"
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

			static Delegate cb_parseIndex_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetParseIndex_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_parseIndex_Ljava_nio_ByteBuffer_ == null)
					cb_parseIndex_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParseIndex_Ljava_nio_ByteBuffer_);
				return cb_parseIndex_Ljava_nio_ByteBuffer_;
			}

			static void n_ParseIndex_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index)
			{
				global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer index = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_index, JniHandleOwnership.DoNotTransfer);
				__this.ParseIndex (index);
			}
#pragma warning restore 0169

			static IntPtr id_parseIndex_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory.Stream']/method[@name='parseIndex' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("parseIndex", "(Ljava/nio/ByteBuffer;)V", "GetParseIndex_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe void ParseIndex (global::Java.Nio.ByteBuffer index)
			{
				if (id_parseIndex_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_parseIndex_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "parseIndex", "(Ljava/nio/ByteBuffer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (index);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parseIndex_Ljava_nio_ByteBuffer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseIndex", "(Ljava/nio/ByteBuffer;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/MPSTrackFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPSTrackFactory); }
		}

		protected MPSTrackFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_Lorg_jcodec_movtool_streaming_tracks_FilePool_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory']/constructor[@name='MPSTrackFactory' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='org.jcodec.movtool.streaming.tracks.FilePool']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;Lorg/jcodec/movtool/streaming/tracks/FilePool;)V", "")]
		public unsafe MPSTrackFactory (global::Java.Nio.ByteBuffer index, global::Org.Jcodec.Movtool.Streaming.Tracks.FilePool fp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (fp);
				if (((object) this).GetType () != typeof (MPSTrackFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;Lorg/jcodec/movtool/streaming/tracks/FilePool;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;Lorg/jcodec/movtool/streaming/tracks/FilePool;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_Lorg_jcodec_movtool_streaming_tracks_FilePool_ == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_Lorg_jcodec_movtool_streaming_tracks_FilePool_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;Lorg/jcodec/movtool/streaming/tracks/FilePool;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_Lorg_jcodec_movtool_streaming_tracks_FilePool_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_Lorg_jcodec_movtool_streaming_tracks_FilePool_, __args);
			} finally {
			}
		}

		static Delegate cb_getAudioStreams;
#pragma warning disable 0169
		static Delegate GetGetAudioStreamsHandler ()
		{
			if (cb_getAudioStreams == null)
				cb_getAudioStreams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioStreams);
			return cb_getAudioStreams;
		}

		static IntPtr n_GetAudioStreams (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.ToLocalJniHandle (__this.AudioStreams);
		}
#pragma warning restore 0169

		static IntPtr id_getAudioStreams;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream> AudioStreams {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory']/method[@name='getAudioStreams' and count(parameter)=0]"
			[Register ("getAudioStreams", "()Ljava/util/List;", "GetGetAudioStreamsHandler")]
			get {
				if (id_getAudioStreams == IntPtr.Zero)
					id_getAudioStreams = JNIEnv.GetMethodID (class_ref, "getAudioStreams", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioStreams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioStreams", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStreams;
#pragma warning disable 0169
		static Delegate GetGetStreamsHandler ()
		{
			if (cb_getStreams == null)
				cb_getStreams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreams);
			return cb_getStreams;
		}

		static IntPtr n_GetStreams (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.ToLocalJniHandle (__this.Streams);
		}
#pragma warning restore 0169

		static IntPtr id_getStreams;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream> Streams {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory']/method[@name='getStreams' and count(parameter)=0]"
			[Register ("getStreams", "()Ljava/util/List;", "GetGetStreamsHandler")]
			get {
				if (id_getStreams == IntPtr.Zero)
					id_getStreams = JNIEnv.GetMethodID (class_ref, "getStreams", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreams", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoStreams;
#pragma warning disable 0169
		static Delegate GetGetVideoStreamsHandler ()
		{
			if (cb_getVideoStreams == null)
				cb_getVideoStreams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoStreams);
			return cb_getVideoStreams;
		}

		static IntPtr n_GetVideoStreams (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.ToLocalJniHandle (__this.VideoStreams);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoStreams;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream> VideoStreams {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory']/method[@name='getVideoStreams' and count(parameter)=0]"
			[Register ("getVideoStreams", "()Ljava/util/List;", "GetGetVideoStreamsHandler")]
			get {
				if (id_getVideoStreams == IntPtr.Zero)
					id_getVideoStreams = JNIEnv.GetMethodID (class_ref, "getVideoStreams", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoStreams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoStreams", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createStream_I;
#pragma warning disable 0169
		static Delegate GetCreateStream_IHandler ()
		{
			if (cb_createStream_I == null)
				cb_createStream_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_CreateStream_I);
			return cb_createStream_I;
		}

		static IntPtr n_CreateStream_I (IntPtr jnienv, IntPtr native__this, int streamId)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateStream (streamId));
		}
#pragma warning restore 0169

		static IntPtr id_createStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory']/method[@name='createStream' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createStream", "(I)Lorg/jcodec/movtool/streaming/tracks/MPSTrackFactory$Stream;", "GetCreateStream_IHandler")]
		protected virtual unsafe global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream CreateStream (int streamId)
		{
			if (id_createStream_I == IntPtr.Zero)
				id_createStream_I = JNIEnv.GetMethodID (class_ref, "createStream", "(I)Lorg/jcodec/movtool/streaming/tracks/MPSTrackFactory$Stream;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (streamId);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createStream_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createStream", "(I)Lorg/jcodec/movtool/streaming/tracks/MPSTrackFactory$Stream;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] args)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

		static Delegate cb_readIndex_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetReadIndex_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_readIndex_Ljava_nio_ByteBuffer_ == null)
				cb_readIndex_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReadIndex_Ljava_nio_ByteBuffer_);
			return cb_readIndex_Ljava_nio_ByteBuffer_;
		}

		static void n_ReadIndex_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer index = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_index, JniHandleOwnership.DoNotTransfer);
			__this.ReadIndex (index);
		}
#pragma warning restore 0169

		static IntPtr id_readIndex_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MPSTrackFactory']/method[@name='readIndex' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readIndex", "(Ljava/nio/ByteBuffer;)V", "GetReadIndex_Ljava_nio_ByteBuffer_Handler")]
		protected virtual unsafe void ReadIndex (global::Java.Nio.ByteBuffer index)
		{
			if (id_readIndex_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readIndex_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "readIndex", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readIndex_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readIndex", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
