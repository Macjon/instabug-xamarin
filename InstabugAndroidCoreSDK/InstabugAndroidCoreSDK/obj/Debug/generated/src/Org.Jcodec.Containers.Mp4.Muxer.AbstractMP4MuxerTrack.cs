using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4.Muxer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/muxer/AbstractMP4MuxerTrack", DoNotGenerateAcw=true)]
	public abstract partial class AbstractMP4MuxerTrack : global::Java.Lang.Object {


		static IntPtr chunkDuration_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='chunkDuration']"
		[Register ("chunkDuration")]
		protected long ChunkDuration {
			get {
				if (chunkDuration_jfieldId == IntPtr.Zero)
					chunkDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "chunkDuration", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, chunkDuration_jfieldId);
			}
			set {
				if (chunkDuration_jfieldId == IntPtr.Zero)
					chunkDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "chunkDuration", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chunkDuration_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr chunkNo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='chunkNo']"
		[Register ("chunkNo")]
		protected int ChunkNo {
			get {
				if (chunkNo_jfieldId == IntPtr.Zero)
					chunkNo_jfieldId = JNIEnv.GetFieldID (class_ref, "chunkNo", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, chunkNo_jfieldId);
			}
			set {
				if (chunkNo_jfieldId == IntPtr.Zero)
					chunkNo_jfieldId = JNIEnv.GetFieldID (class_ref, "chunkNo", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chunkNo_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr curChunk_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='curChunk']"
		[Register ("curChunk")]
		protected global::System.Collections.IList CurChunk {
			get {
				if (curChunk_jfieldId == IntPtr.Zero)
					curChunk_jfieldId = JNIEnv.GetFieldID (class_ref, "curChunk", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, curChunk_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (curChunk_jfieldId == IntPtr.Zero)
					curChunk_jfieldId = JNIEnv.GetFieldID (class_ref, "curChunk", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, curChunk_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr edits_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='edits']"
		[Register ("edits")]
		protected global::System.Collections.IList Edits {
			get {
				if (edits_jfieldId == IntPtr.Zero)
					edits_jfieldId = JNIEnv.GetFieldID (class_ref, "edits", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, edits_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (edits_jfieldId == IntPtr.Zero)
					edits_jfieldId = JNIEnv.GetFieldID (class_ref, "edits", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, edits_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr finished_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='finished']"
		[Register ("finished")]
		protected bool Finished {
			get {
				if (finished_jfieldId == IntPtr.Zero)
					finished_jfieldId = JNIEnv.GetFieldID (class_ref, "finished", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, finished_jfieldId);
			}
			set {
				if (finished_jfieldId == IntPtr.Zero)
					finished_jfieldId = JNIEnv.GetFieldID (class_ref, "finished", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, finished_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sampleEntries_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='sampleEntries']"
		[Register ("sampleEntries")]
		protected global::System.Collections.IList SampleEntries {
			get {
				if (sampleEntries_jfieldId == IntPtr.Zero)
					sampleEntries_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleEntries", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sampleEntries_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sampleEntries_jfieldId == IntPtr.Zero)
					sampleEntries_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleEntries", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sampleEntries_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr samplesInChunks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='samplesInChunks']"
		[Register ("samplesInChunks")]
		protected global::System.Collections.IList SamplesInChunks {
			get {
				if (samplesInChunks_jfieldId == IntPtr.Zero)
					samplesInChunks_jfieldId = JNIEnv.GetFieldID (class_ref, "samplesInChunks", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, samplesInChunks_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (samplesInChunks_jfieldId == IntPtr.Zero)
					samplesInChunks_jfieldId = JNIEnv.GetFieldID (class_ref, "samplesInChunks", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, samplesInChunks_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr samplesInLastChunk_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='samplesInLastChunk']"
		[Register ("samplesInLastChunk")]
		protected int SamplesInLastChunk {
			get {
				if (samplesInLastChunk_jfieldId == IntPtr.Zero)
					samplesInLastChunk_jfieldId = JNIEnv.GetFieldID (class_ref, "samplesInLastChunk", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, samplesInLastChunk_jfieldId);
			}
			set {
				if (samplesInLastChunk_jfieldId == IntPtr.Zero)
					samplesInLastChunk_jfieldId = JNIEnv.GetFieldID (class_ref, "samplesInLastChunk", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, samplesInLastChunk_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr tgtChunkDuration_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='tgtChunkDuration']"
		[Register ("tgtChunkDuration")]
		protected global::Org.Jcodec.Common.Model.Rational TgtChunkDuration {
			get {
				if (tgtChunkDuration_jfieldId == IntPtr.Zero)
					tgtChunkDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "tgtChunkDuration", "Lorg/jcodec/common/model/Rational;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tgtChunkDuration_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tgtChunkDuration_jfieldId == IntPtr.Zero)
					tgtChunkDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "tgtChunkDuration", "Lorg/jcodec/common/model/Rational;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tgtChunkDuration_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr tgtChunkDurationUnit_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='tgtChunkDurationUnit']"
		[Register ("tgtChunkDurationUnit")]
		protected global::Org.Jcodec.Common.Model.Unit TgtChunkDurationUnit {
			get {
				if (tgtChunkDurationUnit_jfieldId == IntPtr.Zero)
					tgtChunkDurationUnit_jfieldId = JNIEnv.GetFieldID (class_ref, "tgtChunkDurationUnit", "Lorg/jcodec/common/model/Unit;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tgtChunkDurationUnit_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Unit> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tgtChunkDurationUnit_jfieldId == IntPtr.Zero)
					tgtChunkDurationUnit_jfieldId = JNIEnv.GetFieldID (class_ref, "tgtChunkDurationUnit", "Lorg/jcodec/common/model/Unit;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tgtChunkDurationUnit_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr trackId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='trackId']"
		[Register ("trackId")]
		protected int TrackId {
			get {
				if (trackId_jfieldId == IntPtr.Zero)
					trackId_jfieldId = JNIEnv.GetFieldID (class_ref, "trackId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, trackId_jfieldId);
			}
			set {
				if (trackId_jfieldId == IntPtr.Zero)
					trackId_jfieldId = JNIEnv.GetFieldID (class_ref, "trackId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, trackId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/field[@name='type']"
		[Register ("type")]
		protected global::Org.Jcodec.Containers.Mp4.TrackType Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/muxer/AbstractMP4MuxerTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractMP4MuxerTrack); }
		}

		protected AbstractMP4MuxerTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILorg_jcodec_containers_mp4_TrackType_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/constructor[@name='AbstractMP4MuxerTrack' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='org.jcodec.containers.mp4.TrackType'] and parameter[3][@type='int']]"
		[Register (".ctor", "(ILorg/jcodec/containers/mp4/TrackType;I)V", "")]
		public unsafe AbstractMP4MuxerTrack (int trackId, global::Org.Jcodec.Containers.Mp4.TrackType type, int timescale)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (trackId);
				__args [1] = new JValue (type);
				__args [2] = new JValue (timescale);
				if (((object) this).GetType () != typeof (AbstractMP4MuxerTrack)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILorg/jcodec/containers/mp4/TrackType;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILorg/jcodec/containers/mp4/TrackType;I)V", __args);
					return;
				}

				if (id_ctor_ILorg_jcodec_containers_mp4_TrackType_I == IntPtr.Zero)
					id_ctor_ILorg_jcodec_containers_mp4_TrackType_I = JNIEnv.GetMethodID (class_ref, "<init>", "(ILorg/jcodec/containers/mp4/TrackType;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILorg_jcodec_containers_mp4_TrackType_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILorg_jcodec_containers_mp4_TrackType_I, __args);
			} finally {
			}
		}

		static Delegate cb_getDisplayDimensions;
#pragma warning disable 0169
		static Delegate GetGetDisplayDimensionsHandler ()
		{
			if (cb_getDisplayDimensions == null)
				cb_getDisplayDimensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayDimensions);
			return cb_getDisplayDimensions;
		}

		static IntPtr n_GetDisplayDimensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisplayDimensions);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayDimensions;
		public virtual unsafe global::Org.Jcodec.Common.Model.Size DisplayDimensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/method[@name='getDisplayDimensions' and count(parameter)=0]"
			[Register ("getDisplayDimensions", "()Lorg/jcodec/common/model/Size;", "GetGetDisplayDimensionsHandler")]
			get {
				if (id_getDisplayDimensions == IntPtr.Zero)
					id_getDisplayDimensions = JNIEnv.GetMethodID (class_ref, "getDisplayDimensions", "()Lorg/jcodec/common/model/Size;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayDimensions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayDimensions", "()Lorg/jcodec/common/model/Size;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAudio;
#pragma warning disable 0169
		static Delegate GetIsAudioHandler ()
		{
			if (cb_isAudio == null)
				cb_isAudio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAudio);
			return cb_isAudio;
		}

		static bool n_IsAudio (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAudio;
		}
#pragma warning restore 0169

		static IntPtr id_isAudio;
		public virtual unsafe bool IsAudio {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/method[@name='isAudio' and count(parameter)=0]"
			[Register ("isAudio", "()Z", "GetIsAudioHandler")]
			get {
				if (id_isAudio == IntPtr.Zero)
					id_isAudio = JNIEnv.GetMethodID (class_ref, "isAudio", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAudio);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAudio", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTimecode;
#pragma warning disable 0169
		static Delegate GetIsTimecodeHandler ()
		{
			if (cb_isTimecode == null)
				cb_isTimecode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTimecode);
			return cb_isTimecode;
		}

		static bool n_IsTimecode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTimecode;
		}
#pragma warning restore 0169

		static IntPtr id_isTimecode;
		public virtual unsafe bool IsTimecode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/method[@name='isTimecode' and count(parameter)=0]"
			[Register ("isTimecode", "()Z", "GetIsTimecodeHandler")]
			get {
				if (id_isTimecode == IntPtr.Zero)
					id_isTimecode = JNIEnv.GetMethodID (class_ref, "isTimecode", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTimecode);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTimecode", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isVideo;
#pragma warning disable 0169
		static Delegate GetIsVideoHandler ()
		{
			if (cb_isVideo == null)
				cb_isVideo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVideo);
			return cb_isVideo;
		}

		static bool n_IsVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVideo;
		}
#pragma warning restore 0169

		static IntPtr id_isVideo;
		public virtual unsafe bool IsVideo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/method[@name='isVideo' and count(parameter)=0]"
			[Register ("isVideo", "()Z", "GetIsVideoHandler")]
			get {
				if (id_isVideo == IntPtr.Zero)
					id_isVideo = JNIEnv.GetMethodID (class_ref, "isVideo", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVideo);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVideo", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getTimescale;
#pragma warning disable 0169
		static Delegate GetGetTimescaleHandler ()
		{
			if (cb_getTimescale == null)
				cb_getTimescale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimescale);
			return cb_getTimescale;
		}

		static int n_GetTimescale (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timescale;
		}
#pragma warning restore 0169

		static IntPtr id_getTimescale;
		public virtual unsafe int Timescale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/method[@name='getTimescale' and count(parameter)=0]"
			[Register ("getTimescale", "()I", "GetGetTimescaleHandler")]
			get {
				if (id_getTimescale == IntPtr.Zero)
					id_getTimescale = JNIEnv.GetMethodID (class_ref, "getTimescale", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTimescale);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimescale", "()I"));
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
			global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackTotalDuration;
		}
#pragma warning restore 0169

		public abstract long TrackTotalDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/method[@name='getTrackTotalDuration' and count(parameter)=0]"
			[Register ("getTrackTotalDuration", "()J", "GetGetTrackTotalDurationHandler")] get;
		}

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.SetName (name);
		}
#pragma warning restore 0169

		static IntPtr id_setName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetName (string name)
		{
			if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
				id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_;
#pragma warning disable 0169
		static Delegate GetSetTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_Handler ()
		{
			if (cb_setTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_ == null)
				cb_setTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_);
			return cb_setTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_;
		}

		static void n_SetTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_duration, IntPtr native_unit)
		{
			global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Muxer.AbstractMP4MuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational duration = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_duration, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Unit unit = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Unit> (native_unit, JniHandleOwnership.DoNotTransfer);
			__this.SetTgtChunkDuration (duration, unit);
		}
#pragma warning restore 0169

		static IntPtr id_setTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/method[@name='setTgtChunkDuration' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Rational'] and parameter[2][@type='org.jcodec.common.model.Unit']]"
		[Register ("setTgtChunkDuration", "(Lorg/jcodec/common/model/Rational;Lorg/jcodec/common/model/Unit;)V", "GetSetTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_Handler")]
		public virtual unsafe void SetTgtChunkDuration (global::Org.Jcodec.Common.Model.Rational duration, global::Org.Jcodec.Common.Model.Unit unit)
		{
			if (id_setTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_ == IntPtr.Zero)
				id_setTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_ = JNIEnv.GetMethodID (class_ref, "setTgtChunkDuration", "(Lorg/jcodec/common/model/Rational;Lorg/jcodec/common/model/Unit;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (duration);
				__args [1] = new JValue (unit);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTgtChunkDuration_Lorg_jcodec_common_model_Rational_Lorg_jcodec_common_model_Unit_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTgtChunkDuration", "(Lorg/jcodec/common/model/Rational;Lorg/jcodec/common/model/Unit;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/muxer/AbstractMP4MuxerTrack", DoNotGenerateAcw=true)]
	internal partial class AbstractMP4MuxerTrackInvoker : AbstractMP4MuxerTrack {

		public AbstractMP4MuxerTrackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractMP4MuxerTrackInvoker); }
		}

		static IntPtr id_getTrackTotalDuration;
		public override unsafe long TrackTotalDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.muxer']/class[@name='AbstractMP4MuxerTrack']/method[@name='getTrackTotalDuration' and count(parameter)=0]"
			[Register ("getTrackTotalDuration", "()J", "GetGetTrackTotalDurationHandler")]
			get {
				if (id_getTrackTotalDuration == IntPtr.Zero)
					id_getTrackTotalDuration = JNIEnv.GetMethodID (class_ref, "getTrackTotalDuration", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTrackTotalDuration);
				} finally {
				}
			}
		}

	}

}
