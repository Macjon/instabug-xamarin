using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MTSTrackFactory']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/MTSTrackFactory", DoNotGenerateAcw=true)]
	public partial class MTSTrackFactory : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MTSTrackFactory.MTSProgram']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/MTSTrackFactory$MTSProgram", DoNotGenerateAcw=true)]
		public partial class MTSProgram : global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory {

			// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MTSTrackFactory.MTSProgram.MTSStream']"
			[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/MTSTrackFactory$MTSProgram$MTSStream", DoNotGenerateAcw=true)]
			public partial class MTSStream : global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream {

				internal static new IntPtr java_class_handle;
				internal static new IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/MTSTrackFactory$MTSProgram$MTSStream", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (MTSStream); }
				}

				protected MTSStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor_Lorg_jcodec_movtool_streaming_tracks_MTSTrackFactory_MTSProgram_I;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MTSTrackFactory.MTSProgram.MTSStream']/constructor[@name='MTSTrackFactory.MTSProgram.MTSStream' and count(parameter)=2 and parameter[1][@type='org.jcodec.movtool.streaming.tracks.MTSTrackFactory.MTSProgram'] and parameter[2][@type='int']]"
				[Register (".ctor", "(Lorg/jcodec/movtool/streaming/tracks/MTSTrackFactory$MTSProgram;I)V", "")]
				public unsafe MTSStream (global::Org.Jcodec.Movtool.Streaming.Tracks.MTSTrackFactory.MTSProgram __self, int streamId)
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						JValue* __args = stackalloc JValue [2];
						__args [0] = new JValue (__self);
						__args [1] = new JValue (streamId);
						if (((object) this).GetType () != typeof (MTSStream)) {
							SetHandle (
									global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", __args),
									JniHandleOwnership.TransferLocalRef);
							global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", __args);
							return;
						}

						if (id_ctor_Lorg_jcodec_movtool_streaming_tracks_MTSTrackFactory_MTSProgram_I == IntPtr.Zero)
							id_ctor_Lorg_jcodec_movtool_streaming_tracks_MTSTrackFactory_MTSProgram_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/movtool/streaming/tracks/MTSTrackFactory$MTSProgram;I)V");
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_MTSTrackFactory_MTSProgram_I, __args),
								JniHandleOwnership.TransferLocalRef);
						JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_MTSTrackFactory_MTSProgram_I, __args);
					} finally {
					}
				}

			}

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/MTSTrackFactory$MTSProgram", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MTSProgram); }
			}

			protected MTSProgram (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_movtool_streaming_tracks_MTSTrackFactory_Ljava_nio_ByteBuffer_Lorg_jcodec_movtool_streaming_tracks_FilePool_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MTSTrackFactory.MTSProgram']/constructor[@name='MTSTrackFactory.MTSProgram' and count(parameter)=3 and parameter[1][@type='org.jcodec.movtool.streaming.tracks.MTSTrackFactory'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='org.jcodec.movtool.streaming.tracks.FilePool']]"
			[Register (".ctor", "(Lorg/jcodec/movtool/streaming/tracks/MTSTrackFactory;Ljava/nio/ByteBuffer;Lorg/jcodec/movtool/streaming/tracks/FilePool;)V", "")]
			public unsafe MTSProgram (global::Org.Jcodec.Movtool.Streaming.Tracks.MTSTrackFactory __self, global::Java.Nio.ByteBuffer index, global::Org.Jcodec.Movtool.Streaming.Tracks.FilePool fp)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (index);
					__args [2] = new JValue (fp);
					if (((object) this).GetType () != typeof (MTSProgram)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/nio/ByteBuffer;Lorg/jcodec/movtool/streaming/tracks/FilePool;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/nio/ByteBuffer;Lorg/jcodec/movtool/streaming/tracks/FilePool;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_movtool_streaming_tracks_MTSTrackFactory_Ljava_nio_ByteBuffer_Lorg_jcodec_movtool_streaming_tracks_FilePool_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_movtool_streaming_tracks_MTSTrackFactory_Ljava_nio_ByteBuffer_Lorg_jcodec_movtool_streaming_tracks_FilePool_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/movtool/streaming/tracks/MTSTrackFactory;Ljava/nio/ByteBuffer;Lorg/jcodec/movtool/streaming/tracks/FilePool;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_MTSTrackFactory_Ljava_nio_ByteBuffer_Lorg_jcodec_movtool_streaming_tracks_FilePool_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_MTSTrackFactory_Ljava_nio_ByteBuffer_Lorg_jcodec_movtool_streaming_tracks_FilePool_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/MTSTrackFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MTSTrackFactory); }
		}

		protected MTSTrackFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_Lorg_jcodec_movtool_streaming_tracks_FilePool_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MTSTrackFactory']/constructor[@name='MTSTrackFactory' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='org.jcodec.movtool.streaming.tracks.FilePool']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;Lorg/jcodec/movtool/streaming/tracks/FilePool;)V", "")]
		public unsafe MTSTrackFactory (global::Java.Nio.ByteBuffer index, global::Org.Jcodec.Movtool.Streaming.Tracks.FilePool fp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (fp);
				if (((object) this).GetType () != typeof (MTSTrackFactory)) {
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
			global::Org.Jcodec.Movtool.Streaming.Tracks.MTSTrackFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MTSTrackFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.ToLocalJniHandle (__this.AudioStreams);
		}
#pragma warning restore 0169

		static IntPtr id_getAudioStreams;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream> AudioStreams {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MTSTrackFactory']/method[@name='getAudioStreams' and count(parameter)=0]"
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
			global::Org.Jcodec.Movtool.Streaming.Tracks.MTSTrackFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MTSTrackFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.ToLocalJniHandle (__this.Streams);
		}
#pragma warning restore 0169

		static IntPtr id_getStreams;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream> Streams {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MTSTrackFactory']/method[@name='getStreams' and count(parameter)=0]"
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
			global::Org.Jcodec.Movtool.Streaming.Tracks.MTSTrackFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MTSTrackFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream>.ToLocalJniHandle (__this.VideoStreams);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoStreams;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Movtool.Streaming.Tracks.MPSTrackFactory.Stream> VideoStreams {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MTSTrackFactory']/method[@name='getVideoStreams' and count(parameter)=0]"
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

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='MTSTrackFactory']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
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

	}
}
