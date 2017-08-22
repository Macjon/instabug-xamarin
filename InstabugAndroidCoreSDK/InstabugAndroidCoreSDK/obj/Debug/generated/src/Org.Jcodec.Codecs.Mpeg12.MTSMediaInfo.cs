using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MTSMediaInfo']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MTSMediaInfo", DoNotGenerateAcw=true)]
	public partial class MTSMediaInfo : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MTSMediaInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MTSMediaInfo); }
		}

		protected MTSMediaInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MTSMediaInfo']/constructor[@name='MTSMediaInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MTSMediaInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MTSMediaInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getAudioTracks;
#pragma warning disable 0169
		static Delegate GetGetAudioTracksHandler ()
		{
			if (cb_getAudioTracks == null)
				cb_getAudioTracks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioTracks);
			return cb_getAudioTracks;
		}

		static IntPtr n_GetAudioTracks (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MTSMediaInfo __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MTSMediaInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.ToLocalJniHandle (__this.AudioTracks);
		}
#pragma warning restore 0169

		static IntPtr id_getAudioTracks;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> AudioTracks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MTSMediaInfo']/method[@name='getAudioTracks' and count(parameter)=0]"
			[Register ("getAudioTracks", "()Ljava/util/List;", "GetGetAudioTracksHandler")]
			get {
				if (id_getAudioTracks == IntPtr.Zero)
					id_getAudioTracks = JNIEnv.GetMethodID (class_ref, "getAudioTracks", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioTracks), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioTracks", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoTrack;
#pragma warning disable 0169
		static Delegate GetGetVideoTrackHandler ()
		{
			if (cb_getVideoTrack == null)
				cb_getVideoTrack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoTrack);
			return cb_getVideoTrack;
		}

		static IntPtr n_GetVideoTrack (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MTSMediaInfo __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MTSMediaInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoTrack);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoTrack;
		public virtual unsafe global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata VideoTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MTSMediaInfo']/method[@name='getVideoTrack' and count(parameter)=0]"
			[Register ("getVideoTrack", "()Lorg/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTrackMetadata;", "GetGetVideoTrackHandler")]
			get {
				if (id_getVideoTrack == IntPtr.Zero)
					id_getVideoTrack = JNIEnv.GetMethodID (class_ref, "getVideoTrack", "()Lorg/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTrackMetadata;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoTrack), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoTrack", "()Lorg/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTrackMetadata;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMediaInfo_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetGetMediaInfo_Ljava_io_File_Handler ()
		{
			if (cb_getMediaInfo_Ljava_io_File_ == null)
				cb_getMediaInfo_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMediaInfo_Ljava_io_File_);
			return cb_getMediaInfo_Ljava_io_File_;
		}

		static IntPtr n_GetMediaInfo_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MTSMediaInfo __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MTSMediaInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File f = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_f, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.ToLocalJniHandle (__this.GetMediaInfo (f));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMediaInfo_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MTSMediaInfo']/method[@name='getMediaInfo' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getMediaInfo", "(Ljava/io/File;)Ljava/util/List;", "GetGetMediaInfo_Ljava_io_File_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> GetMediaInfo (global::Java.IO.File f)
		{
			if (id_getMediaInfo_Ljava_io_File_ == IntPtr.Zero)
				id_getMediaInfo_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "getMediaInfo", "(Ljava/io/File;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (f);

				global::System.Collections.Generic.IList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaInfo_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaInfo", "(Ljava/io/File;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MTSMediaInfo']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
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
