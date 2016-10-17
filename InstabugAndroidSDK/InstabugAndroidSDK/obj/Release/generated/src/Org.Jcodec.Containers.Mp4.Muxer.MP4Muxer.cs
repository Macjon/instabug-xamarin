using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4.Muxer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='MP4Muxer']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/muxer/MP4Muxer", DoNotGenerateAcw=true)]
	public partial class MP4Muxer : global::Java.Lang.Object {


		static IntPtr mdatOffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='MP4Muxer']/field[@name='mdatOffset']"
		[Register ("mdatOffset")]
		protected long MdatOffset {
			get {
				if (mdatOffset_jfieldId == IntPtr.Zero)
					mdatOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "mdatOffset", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, mdatOffset_jfieldId);
			}
			set {
				if (mdatOffset_jfieldId == IntPtr.Zero)
					mdatOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "mdatOffset", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mdatOffset_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/muxer/MP4Muxer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MP4Muxer); }
		}

		protected MP4Muxer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack>.ToLocalJniHandle (__this.AudioTracks);
		}
#pragma warning restore 0169

		static IntPtr id_getAudioTracks;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> AudioTracks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='MP4Muxer']/method[@name='getAudioTracks' and count(parameter)=0]"
			[Register ("getAudioTracks", "()Ljava/util/List;", "GetGetAudioTracksHandler")]
			get {
				if (id_getAudioTracks == IntPtr.Zero)
					id_getAudioTracks = JNIEnv.GetMethodID (class_ref, "getAudioTracks", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioTracks), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioTracks", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

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
			global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimecodeTrack);
		}
#pragma warning restore 0169

		static IntPtr id_getTimecodeTrack;
		public virtual unsafe global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack TimecodeTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='MP4Muxer']/method[@name='getTimecodeTrack' and count(parameter)=0]"
			[Register ("getTimecodeTrack", "()Lorg/jcodec/containers/mp4/muxer/AbstractMP4MuxerTrack;", "GetGetTimecodeTrackHandler")]
			get {
				if (id_getTimecodeTrack == IntPtr.Zero)
					id_getTimecodeTrack = JNIEnv.GetMethodID (class_ref, "getTimecodeTrack", "()Lorg/jcodec/containers/mp4/muxer/AbstractMP4MuxerTrack;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimecodeTrack), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimecodeTrack", "()Lorg/jcodec/containers/mp4/muxer/AbstractMP4MuxerTrack;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTracks;
#pragma warning disable 0169
		static Delegate GetGetTracksHandler ()
		{
			if (cb_getTracks == null)
				cb_getTracks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTracks);
			return cb_getTracks;
		}

		static IntPtr n_GetTracks (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack>.ToLocalJniHandle (__this.Tracks);
		}
#pragma warning restore 0169

		static IntPtr id_getTracks;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> Tracks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='MP4Muxer']/method[@name='getTracks' and count(parameter)=0]"
			[Register ("getTracks", "()Ljava/util/List;", "GetGetTracksHandler")]
			get {
				if (id_getTracks == IntPtr.Zero)
					id_getTracks = JNIEnv.GetMethodID (class_ref, "getTracks", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTracks), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTracks", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoTrack);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoTrack;
		public virtual unsafe global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack VideoTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='MP4Muxer']/method[@name='getVideoTrack' and count(parameter)=0]"
			[Register ("getVideoTrack", "()Lorg/jcodec/containers/mp4/muxer/AbstractMP4MuxerTrack;", "GetGetVideoTrackHandler")]
			get {
				if (id_getVideoTrack == IntPtr.Zero)
					id_getVideoTrack = JNIEnv.GetMethodID (class_ref, "getVideoTrack", "()Lorg/jcodec/containers/mp4/muxer/AbstractMP4MuxerTrack;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoTrack), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoTrack", "()Lorg/jcodec/containers/mp4/muxer/AbstractMP4MuxerTrack;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addTimecodeTrack_I;
#pragma warning disable 0169
		static Delegate GetAddTimecodeTrack_IHandler ()
		{
			if (cb_addTimecodeTrack_I == null)
				cb_addTimecodeTrack_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AddTimecodeTrack_I);
			return cb_addTimecodeTrack_I;
		}

		static IntPtr n_AddTimecodeTrack_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddTimecodeTrack (p0));
		}
#pragma warning restore 0169

		static IntPtr id_addTimecodeTrack_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='MP4Muxer']/method[@name='addTimecodeTrack' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addTimecodeTrack", "(I)Lorg/jcodec/containers/mp4/muxer/TimecodeMP4MuxerTrack;", "GetAddTimecodeTrack_IHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mp4.Muxer.TimecodeMP4MuxerTrack AddTimecodeTrack (int p0)
		{
			if (id_addTimecodeTrack_I == IntPtr.Zero)
				id_addTimecodeTrack_I = JNIEnv.GetMethodID (class_ref, "addTimecodeTrack", "(I)Lorg/jcodec/containers/mp4/muxer/TimecodeMP4MuxerTrack;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.TimecodeMP4MuxerTrack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addTimecodeTrack_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.TimecodeMP4MuxerTrack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTimecodeTrack", "(I)Lorg/jcodec/containers/mp4/muxer/TimecodeMP4MuxerTrack;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addTrack_Lorg_jcodec_containers_mp4_TrackType_I;
#pragma warning disable 0169
		static Delegate GetAddTrack_Lorg_jcodec_containers_mp4_TrackType_IHandler ()
		{
			if (cb_addTrack_Lorg_jcodec_containers_mp4_TrackType_I == null)
				cb_addTrack_Lorg_jcodec_containers_mp4_TrackType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_AddTrack_Lorg_jcodec_containers_mp4_TrackType_I);
			return cb_addTrack_Lorg_jcodec_containers_mp4_TrackType_I;
		}

		static IntPtr n_AddTrack_Lorg_jcodec_containers_mp4_TrackType_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mp4.TrackType p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTrack (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addTrack_Lorg_jcodec_containers_mp4_TrackType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='MP4Muxer']/method[@name='addTrack' and count(parameter)=2 and parameter[1][@type='org.jcodec.containers.mp4.TrackType'] and parameter[2][@type='int']]"
		[Register ("addTrack", "(Lorg/jcodec/containers/mp4/TrackType;I)Lorg/jcodec/containers/mp4/muxer/FramesMP4MuxerTrack;", "GetAddTrack_Lorg_jcodec_containers_mp4_TrackType_IHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack AddTrack (global::Org.Jcodec.Containers.Mp4.TrackType p0, int p1)
		{
			if (id_addTrack_Lorg_jcodec_containers_mp4_TrackType_I == IntPtr.Zero)
				id_addTrack_Lorg_jcodec_containers_mp4_TrackType_I = JNIEnv.GetMethodID (class_ref, "addTrack", "(Lorg/jcodec/containers/mp4/TrackType;I)Lorg/jcodec/containers/mp4/muxer/FramesMP4MuxerTrack;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addTrack_Lorg_jcodec_containers_mp4_TrackType_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTrack", "(Lorg/jcodec/containers/mp4/TrackType;I)Lorg/jcodec/containers/mp4/muxer/FramesMP4MuxerTrack;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAddVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_IHandler ()
		{
			if (cb_addVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I == null)
				cb_addVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_AddVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I);
			return cb_addVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I;
		}

		static IntPtr n_AddVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Size p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddVideoTrack (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='MP4Muxer']/method[@name='addVideoTrack' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.jcodec.common.model.Size'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("addVideoTrack", "(Ljava/lang/String;Lorg/jcodec/common/model/Size;Ljava/lang/String;I)Lorg/jcodec/containers/mp4/muxer/FramesMP4MuxerTrack;", "GetAddVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack AddVideoTrack (string p0, global::Org.Jcodec.Common.Model.Size p1, string p2, int p3)
		{
			if (id_addVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I == IntPtr.Zero)
				id_addVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "addVideoTrack", "(Ljava/lang/String;Lorg/jcodec/common/model/Size;Ljava/lang/String;I)Lorg/jcodec/containers/mp4/muxer/FramesMP4MuxerTrack;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addVideoTrack_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addVideoTrack", "(Ljava/lang/String;Lorg/jcodec/common/model/Size;Ljava/lang/String;I)Lorg/jcodec/containers/mp4/muxer/FramesMP4MuxerTrack;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAddVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_IHandler ()
		{
			if (cb_addVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I == null)
				cb_addVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_AddVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I);
			return cb_addVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I;
		}

		static IntPtr n_AddVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Size p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddVideoTrackWithTimecode (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='MP4Muxer']/method[@name='addVideoTrackWithTimecode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.jcodec.common.model.Size'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("addVideoTrackWithTimecode", "(Ljava/lang/String;Lorg/jcodec/common/model/Size;Ljava/lang/String;I)Lorg/jcodec/containers/mp4/muxer/FramesMP4MuxerTrack;", "GetAddVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack AddVideoTrackWithTimecode (string p0, global::Org.Jcodec.Common.Model.Size p1, string p2, int p3)
		{
			if (id_addVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I == IntPtr.Zero)
				id_addVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "addVideoTrackWithTimecode", "(Ljava/lang/String;Lorg/jcodec/common/model/Size;Ljava/lang/String;I)Lorg/jcodec/containers/mp4/muxer/FramesMP4MuxerTrack;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addVideoTrackWithTimecode_Ljava_lang_String_Lorg_jcodec_common_model_Size_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.FramesMP4MuxerTrack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addVideoTrackWithTimecode", "(Ljava/lang/String;Lorg/jcodec/common/model/Size;Ljava/lang/String;I)Lorg/jcodec/containers/mp4/muxer/FramesMP4MuxerTrack;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_writeHeader;
#pragma warning disable 0169
		static Delegate GetWriteHeaderHandler ()
		{
			if (cb_writeHeader == null)
				cb_writeHeader = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WriteHeader);
			return cb_writeHeader;
		}

		static void n_WriteHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.MP4Muxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteHeader ();
		}
#pragma warning restore 0169

		static IntPtr id_writeHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='MP4Muxer']/method[@name='writeHeader' and count(parameter)=0]"
		[Register ("writeHeader", "()V", "GetWriteHeaderHandler")]
		public virtual unsafe void WriteHeader ()
		{
			if (id_writeHeader == IntPtr.Zero)
				id_writeHeader = JNIEnv.GetMethodID (class_ref, "writeHeader", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeHeader);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeHeader", "()V"));
			} finally {
			}
		}

	}
}
