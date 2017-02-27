using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/MXFDemuxer", DoNotGenerateAcw=true)]
	public partial class MXFDemuxer : global::Java.Lang.Object {


		static IntPtr duration_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/field[@name='duration']"
		[Register ("duration")]
		protected double Duration {
			get {
				if (duration_jfieldId == IntPtr.Zero)
					duration_jfieldId = JNIEnv.GetFieldID (class_ref, "duration", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, duration_jfieldId);
			}
			set {
				if (duration_jfieldId == IntPtr.Zero)
					duration_jfieldId = JNIEnv.GetFieldID (class_ref, "duration", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, duration_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr header_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/field[@name='header']"
		[Register ("header")]
		protected global::Org.Jcodec.Containers.Mxf.Model.MXFPartition Header {
			get {
				if (header_jfieldId == IntPtr.Zero)
					header_jfieldId = JNIEnv.GetFieldID (class_ref, "header", "Lorg/jcodec/containers/mxf/model/MXFPartition;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, header_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (header_jfieldId == IntPtr.Zero)
					header_jfieldId = JNIEnv.GetFieldID (class_ref, "header", "Lorg/jcodec/containers/mxf/model/MXFPartition;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, header_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr indexSegments_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/field[@name='indexSegments']"
		[Register ("indexSegments")]
		protected global::System.Collections.IList IndexSegments {
			get {
				if (indexSegments_jfieldId == IntPtr.Zero)
					indexSegments_jfieldId = JNIEnv.GetFieldID (class_ref, "indexSegments", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, indexSegments_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (indexSegments_jfieldId == IntPtr.Zero)
					indexSegments_jfieldId = JNIEnv.GetFieldID (class_ref, "indexSegments", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, indexSegments_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr metadata_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/field[@name='metadata']"
		[Register ("metadata")]
		protected global::System.Collections.IList Metadata {
			get {
				if (metadata_jfieldId == IntPtr.Zero)
					metadata_jfieldId = JNIEnv.GetFieldID (class_ref, "metadata", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, metadata_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (metadata_jfieldId == IntPtr.Zero)
					metadata_jfieldId = JNIEnv.GetFieldID (class_ref, "metadata", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, metadata_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr partitions_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/field[@name='partitions']"
		[Register ("partitions")]
		protected global::System.Collections.IList Partitions {
			get {
				if (partitions_jfieldId == IntPtr.Zero)
					partitions_jfieldId = JNIEnv.GetFieldID (class_ref, "partitions", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, partitions_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (partitions_jfieldId == IntPtr.Zero)
					partitions_jfieldId = JNIEnv.GetFieldID (class_ref, "partitions", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, partitions_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr totalFrames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/field[@name='totalFrames']"
		[Register ("totalFrames")]
		protected int TotalFrames {
			get {
				if (totalFrames_jfieldId == IntPtr.Zero)
					totalFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "totalFrames", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, totalFrames_jfieldId);
			}
			set {
				if (totalFrames_jfieldId == IntPtr.Zero)
					totalFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "totalFrames", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, totalFrames_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr tracks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/field[@name='tracks']"
		[Register ("tracks")]
		protected IList<Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> Tracks {
			get {
				if (tracks_jfieldId == IntPtr.Zero)
					tracks_jfieldId = JNIEnv.GetFieldID (class_ref, "tracks", "[Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tracks_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tracks_jfieldId == IntPtr.Zero)
					tracks_jfieldId = JNIEnv.GetFieldID (class_ref, "tracks", "[Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tracks_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.Fast']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mxf/MXFDemuxer$Fast", DoNotGenerateAcw=true)]
		public partial class Fast : global::Org.Jcodec.Containers.Mxf.MXFDemuxer {

			protected Fast (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack", DoNotGenerateAcw=true)]
		public partial class MXFDemuxerTrack : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MXFDemuxerTrack); }
			}

			protected MXFDemuxerTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_containers_mxf_MXFDemuxer_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/constructor[@name='MXFDemuxer.MXFDemuxerTrack' and count(parameter)=4 and parameter[1][@type='org.jcodec.containers.mxf.MXFDemuxer'] and parameter[2][@type='org.jcodec.containers.mxf.model.UL'] and parameter[3][@type='org.jcodec.containers.mxf.model.TimelineTrack'] and parameter[4][@type='org.jcodec.containers.mxf.model.GenericDescriptor']]"
			[Register (".ctor", "(Lorg/jcodec/containers/mxf/MXFDemuxer;Lorg/jcodec/containers/mxf/model/UL;Lorg/jcodec/containers/mxf/model/TimelineTrack;Lorg/jcodec/containers/mxf/model/GenericDescriptor;)V", "")]
			public unsafe MXFDemuxerTrack (global::Org.Jcodec.Containers.Mxf.MXFDemuxer __self, global::Org.Jcodec.Containers.Mxf.Model.UL p1, global::Org.Jcodec.Containers.Mxf.Model.TimelineTrack p2, global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (((object) this).GetType () != typeof (MXFDemuxerTrack)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/jcodec/containers/mxf/model/UL;Lorg/jcodec/containers/mxf/model/TimelineTrack;Lorg/jcodec/containers/mxf/model/GenericDescriptor;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/jcodec/containers/mxf/model/UL;Lorg/jcodec/containers/mxf/model/TimelineTrack;Lorg/jcodec/containers/mxf/model/GenericDescriptor;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_containers_mxf_MXFDemuxer_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_containers_mxf_MXFDemuxer_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mxf/MXFDemuxer;Lorg/jcodec/containers/mxf/model/UL;Lorg/jcodec/containers/mxf/model/TimelineTrack;Lorg/jcodec/containers/mxf/model/GenericDescriptor;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mxf_MXFDemuxer_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mxf_MXFDemuxer_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_, __args);
				} finally {
				}
			}

			static Delegate cb_getCodec;
#pragma warning disable 0169
			static Delegate GetGetCodecHandler ()
			{
				if (cb_getCodec == null)
					cb_getCodec = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCodec);
				return cb_getCodec;
			}

			static IntPtr n_GetCodec (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Codec);
			}
#pragma warning restore 0169

			static IntPtr id_getCodec;
			public virtual unsafe global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Codec {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='getCodec' and count(parameter)=0]"
				[Register ("getCodec", "()Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;", "GetGetCodecHandler")]
				get {
					if (id_getCodec == IntPtr.Zero)
						id_getCodec = JNIEnv.GetMethodID (class_ref, "getCodec", "()Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodec), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodec", "()Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getCurFrame;
#pragma warning disable 0169
			static Delegate GetGetCurFrameHandler ()
			{
				if (cb_getCurFrame == null)
					cb_getCurFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurFrame);
				return cb_getCurFrame;
			}

			static long n_GetCurFrame (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CurFrame;
			}
#pragma warning restore 0169

			static IntPtr id_getCurFrame;
			public virtual unsafe long CurFrame {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='getCurFrame' and count(parameter)=0]"
				[Register ("getCurFrame", "()J", "GetGetCurFrameHandler")]
				get {
					if (id_getCurFrame == IntPtr.Zero)
						id_getCurFrame = JNIEnv.GetMethodID (class_ref, "getCurFrame", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurFrame);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurFrame", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_getDescriptor;
#pragma warning disable 0169
			static Delegate GetGetDescriptorHandler ()
			{
				if (cb_getDescriptor == null)
					cb_getDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescriptor);
				return cb_getDescriptor;
			}

			static IntPtr n_GetDescriptor (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Descriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getDescriptor;
			public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor Descriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='getDescriptor' and count(parameter)=0]"
				[Register ("getDescriptor", "()Lorg/jcodec/containers/mxf/model/GenericDescriptor;", "GetGetDescriptorHandler")]
				get {
					if (id_getDescriptor == IntPtr.Zero)
						id_getDescriptor = JNIEnv.GetMethodID (class_ref, "getDescriptor", "()Lorg/jcodec/containers/mxf/model/GenericDescriptor;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescriptor), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescriptor", "()Lorg/jcodec/containers/mxf/model/GenericDescriptor;")), JniHandleOwnership.TransferLocalRef);
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
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Duration;
			}
#pragma warning restore 0169

			static IntPtr id_getDuration;
			public virtual unsafe double Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='getDuration' and count(parameter)=0]"
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

			static Delegate cb_getEssenceUL;
#pragma warning disable 0169
			static Delegate GetGetEssenceULHandler ()
			{
				if (cb_getEssenceUL == null)
					cb_getEssenceUL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEssenceUL);
				return cb_getEssenceUL;
			}

			static IntPtr n_GetEssenceUL (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.EssenceUL);
			}
#pragma warning restore 0169

			static IntPtr id_getEssenceUL;
			public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL EssenceUL {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='getEssenceUL' and count(parameter)=0]"
				[Register ("getEssenceUL", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetEssenceULHandler")]
				get {
					if (id_getEssenceUL == IntPtr.Zero)
						id_getEssenceUL = JNIEnv.GetMethodID (class_ref, "getEssenceUL", "()Lorg/jcodec/containers/mxf/model/UL;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEssenceUL), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEssenceUL", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
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
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsAudio;
			}
#pragma warning restore 0169

			static IntPtr id_isAudio;
			public virtual unsafe bool IsAudio {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='isAudio' and count(parameter)=0]"
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
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsVideo;
			}
#pragma warning restore 0169

			static IntPtr id_isVideo;
			public virtual unsafe bool IsVideo {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='isVideo' and count(parameter)=0]"
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

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			static IntPtr id_getName;
			public virtual unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getNumFrames;
#pragma warning disable 0169
			static Delegate GetGetNumFramesHandler ()
			{
				if (cb_getNumFrames == null)
					cb_getNumFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumFrames);
				return cb_getNumFrames;
			}

			static int n_GetNumFrames (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NumFrames;
			}
#pragma warning restore 0169

			static IntPtr id_getNumFrames;
			public virtual unsafe int NumFrames {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='getNumFrames' and count(parameter)=0]"
				[Register ("getNumFrames", "()I", "GetGetNumFramesHandler")]
				get {
					if (id_getNumFrames == IntPtr.Zero)
						id_getNumFrames = JNIEnv.GetMethodID (class_ref, "getNumFrames", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumFrames);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumFrames", "()I"));
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
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TrackId;
			}
#pragma warning restore 0169

			static IntPtr id_getTrackId;
			public virtual unsafe int TrackId {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='getTrackId' and count(parameter)=0]"
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

			static Delegate cb_gotoFrame_J;
#pragma warning disable 0169
			static Delegate GetGotoFrame_JHandler ()
			{
				if (cb_gotoFrame_J == null)
					cb_gotoFrame_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_GotoFrame_J);
				return cb_gotoFrame_J;
			}

			static bool n_GotoFrame_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GotoFrame (p0);
			}
#pragma warning restore 0169

			static IntPtr id_gotoFrame_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='gotoFrame' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("gotoFrame", "(J)Z", "GetGotoFrame_JHandler")]
			public virtual unsafe bool GotoFrame (long p0)
			{
				if (id_gotoFrame_J == IntPtr.Zero)
					id_gotoFrame_J = JNIEnv.GetMethodID (class_ref, "gotoFrame", "(J)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_gotoFrame_J, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "gotoFrame", "(J)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_gotoSyncFrame_J;
#pragma warning disable 0169
			static Delegate GetGotoSyncFrame_JHandler ()
			{
				if (cb_gotoSyncFrame_J == null)
					cb_gotoSyncFrame_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_GotoSyncFrame_J);
				return cb_gotoSyncFrame_J;
			}

			static bool n_GotoSyncFrame_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GotoSyncFrame (p0);
			}
#pragma warning restore 0169

			static IntPtr id_gotoSyncFrame_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='gotoSyncFrame' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("gotoSyncFrame", "(J)Z", "GetGotoSyncFrame_JHandler")]
			public virtual unsafe bool GotoSyncFrame (long p0)
			{
				if (id_gotoSyncFrame_J == IntPtr.Zero)
					id_gotoSyncFrame_J = JNIEnv.GetMethodID (class_ref, "gotoSyncFrame", "(J)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_gotoSyncFrame_J, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "gotoSyncFrame", "(J)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_nextFrame;
#pragma warning disable 0169
			static Delegate GetNextFrameHandler ()
			{
				if (cb_nextFrame == null)
					cb_nextFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NextFrame);
				return cb_nextFrame;
			}

			static IntPtr n_NextFrame (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NextFrame ());
			}
#pragma warning restore 0169

			static IntPtr id_nextFrame;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='nextFrame' and count(parameter)=0]"
			[Register ("nextFrame", "()Lorg/jcodec/common/model/Packet;", "GetNextFrameHandler")]
			public virtual unsafe global::Org.Jcodec.Common.Model.Packet NextFrame ()
			{
				if (id_nextFrame == IntPtr.Zero)
					id_nextFrame = JNIEnv.GetMethodID (class_ref, "nextFrame", "()Lorg/jcodec/common/model/Packet;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextFrame), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextFrame", "()Lorg/jcodec/common/model/Packet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_readPacket_JIJIIIZ;
#pragma warning disable 0169
			static Delegate GetReadPacket_JIJIIIZHandler ()
			{
				if (cb_readPacket_JIJIIIZ == null)
					cb_readPacket_JIJIIIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, long, int, int, int, bool, IntPtr>) n_ReadPacket_JIJIIIZ);
				return cb_readPacket_JIJIIIZ;
			}

			static IntPtr n_ReadPacket_JIJIIIZ (IntPtr jnienv, IntPtr native__this, long p0, int p1, long p2, int p3, int p4, int p5, bool p6)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ReadPacket (p0, p1, p2, p3, p4, p5, p6));
			}
#pragma warning restore 0169

			static IntPtr id_readPacket_JIJIIIZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='readPacket' and count(parameter)=7 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='boolean']]"
			[Register ("readPacket", "(JIJIIIZ)Lorg/jcodec/containers/mxf/MXFDemuxer$MXFPacket;", "GetReadPacket_JIJIIIZHandler")]
			public virtual unsafe global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFPacket ReadPacket (long p0, int p1, long p2, int p3, int p4, int p5, bool p6)
			{
				if (id_readPacket_JIJIIIZ == IntPtr.Zero)
					id_readPacket_JIJIIIZ = JNIEnv.GetMethodID (class_ref, "readPacket", "(JIJIIIZ)Lorg/jcodec/containers/mxf/MXFDemuxer$MXFPacket;");
				try {
					JValue* __args = stackalloc JValue [7];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					__args [6] = new JValue (p6);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFPacket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readPacket_JIJIIIZ, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFPacket> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readPacket", "(JIJIIIZ)Lorg/jcodec/containers/mxf/MXFDemuxer$MXFPacket;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_seek_D;
#pragma warning disable 0169
			static Delegate GetSeek_DHandler ()
			{
				if (cb_seek_D == null)
					cb_seek_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Seek_D);
				return cb_seek_D;
			}

			static void n_Seek_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Seek (p0);
			}
#pragma warning restore 0169

			static IntPtr id_seek_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFDemuxerTrack']/method[@name='seek' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("seek", "(D)V", "GetSeek_DHandler")]
			public virtual unsafe void Seek (double p0)
			{
				if (id_seek_D == IntPtr.Zero)
					id_seek_D = JNIEnv.GetMethodID (class_ref, "seek", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seek_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seek", "(D)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFPacket']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mxf/MXFDemuxer$MXFPacket", DoNotGenerateAcw=true)]
		public partial class MXFPacket : global::Org.Jcodec.Common.Model.Packet {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mxf/MXFDemuxer$MXFPacket", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MXFPacket); }
			}

			protected MXFPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JI;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFPacket']/constructor[@name='MXFDemuxer.MXFPacket' and count(parameter)=9 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='boolean'] and parameter[7][@type='org.jcodec.common.model.TapeTimecode'] and parameter[8][@type='long'] and parameter[9][@type='int']]"
			[Register (".ctor", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JI)V", "")]
			public unsafe MXFPacket (global::Java.Nio.ByteBuffer p0, long p1, long p2, long p3, long p4, bool p5, global::Org.Jcodec.Common.Model.TapeTimecode p6, long p7, int p8)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [9];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					__args [6] = new JValue (p6);
					__args [7] = new JValue (p7);
					__args [8] = new JValue (p8);
					if (((object) this).GetType () != typeof (MXFPacket)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JI)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JI)V", __args);
						return;
					}

					if (id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JI == IntPtr.Zero)
						id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JI)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JI, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JI, __args);
				} finally {
				}
			}

			static Delegate cb_getLen;
#pragma warning disable 0169
			static Delegate GetGetLenHandler ()
			{
				if (cb_getLen == null)
					cb_getLen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLen);
				return cb_getLen;
			}

			static int n_GetLen (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Len;
			}
#pragma warning restore 0169

			static IntPtr id_getLen;
			public virtual unsafe int Len {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFPacket']/method[@name='getLen' and count(parameter)=0]"
				[Register ("getLen", "()I", "GetGetLenHandler")]
				get {
					if (id_getLen == IntPtr.Zero)
						id_getLen = JNIEnv.GetMethodID (class_ref, "getLen", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLen);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLen", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getOffset;
#pragma warning disable 0169
			static Delegate GetGetOffsetHandler ()
			{
				if (cb_getOffset == null)
					cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetOffset);
				return cb_getOffset;
			}

			static long n_GetOffset (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Offset;
			}
#pragma warning restore 0169

			static IntPtr id_getOffset;
			public virtual unsafe long Offset {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.MXFPacket']/method[@name='getOffset' and count(parameter)=0]"
				[Register ("getOffset", "()J", "GetGetOffsetHandler")]
				get {
					if (id_getOffset == IntPtr.Zero)
						id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getOffset);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()J"));
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mxf/MXFDemuxer$OP", DoNotGenerateAcw=true)]
		public sealed partial class OP : global::Java.Lang.Enum {


			static IntPtr OP1a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='OP1a']"
			[Register ("OP1a")]
			public static global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP OP1a {
				get {
					if (OP1a_jfieldId == IntPtr.Zero)
						OP1a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OP1a", "Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OP1a_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OP1b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='OP1b']"
			[Register ("OP1b")]
			public static global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP OP1b {
				get {
					if (OP1b_jfieldId == IntPtr.Zero)
						OP1b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OP1b", "Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OP1b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OP1c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='OP1c']"
			[Register ("OP1c")]
			public static global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP OP1c {
				get {
					if (OP1c_jfieldId == IntPtr.Zero)
						OP1c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OP1c", "Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OP1c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OP2a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='OP2a']"
			[Register ("OP2a")]
			public static global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP OP2a {
				get {
					if (OP2a_jfieldId == IntPtr.Zero)
						OP2a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OP2a", "Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OP2a_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OP2b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='OP2b']"
			[Register ("OP2b")]
			public static global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP OP2b {
				get {
					if (OP2b_jfieldId == IntPtr.Zero)
						OP2b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OP2b", "Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OP2b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OP2c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='OP2c']"
			[Register ("OP2c")]
			public static global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP OP2c {
				get {
					if (OP2c_jfieldId == IntPtr.Zero)
						OP2c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OP2c", "Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OP2c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OP3a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='OP3a']"
			[Register ("OP3a")]
			public static global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP OP3a {
				get {
					if (OP3a_jfieldId == IntPtr.Zero)
						OP3a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OP3a", "Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OP3a_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OP3b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='OP3b']"
			[Register ("OP3b")]
			public static global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP OP3b {
				get {
					if (OP3b_jfieldId == IntPtr.Zero)
						OP3b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OP3b", "Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OP3b_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OP3c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='OP3c']"
			[Register ("OP3c")]
			public static global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP OP3c {
				get {
					if (OP3c_jfieldId == IntPtr.Zero)
						OP3c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OP3c", "Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OP3c_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OPAtom_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='OPAtom']"
			[Register ("OPAtom")]
			public static global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP OPAtom {
				get {
					if (OPAtom_jfieldId == IntPtr.Zero)
						OPAtom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPAtom", "Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPAtom_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr major_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='major']"
			[Register ("major")]
			public int Major {
				get {
					if (major_jfieldId == IntPtr.Zero)
						major_jfieldId = JNIEnv.GetFieldID (class_ref, "major", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, major_jfieldId);
				}
				set {
					if (major_jfieldId == IntPtr.Zero)
						major_jfieldId = JNIEnv.GetFieldID (class_ref, "major", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, major_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr minor_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/field[@name='minor']"
			[Register ("minor")]
			public int Minor {
				get {
					if (minor_jfieldId == IntPtr.Zero)
						minor_jfieldId = JNIEnv.GetFieldID (class_ref, "minor", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, minor_jfieldId);
				}
				set {
					if (minor_jfieldId == IntPtr.Zero)
						minor_jfieldId = JNIEnv.GetFieldID (class_ref, "minor", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, minor_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mxf/MXFDemuxer$OP", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OP); }
			}

			internal OP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mxf/MXFDemuxer$OP;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer.OP']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/jcodec/containers/mxf/MXFDemuxer$OP;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
				try {
					return (global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/MXFDemuxer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MXFDemuxer); }
		}

		protected MXFDemuxer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getEssencePartitions;
#pragma warning disable 0169
		static Delegate GetGetEssencePartitionsHandler ()
		{
			if (cb_getEssencePartitions == null)
				cb_getEssencePartitions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEssencePartitions);
			return cb_getEssencePartitions;
		}

		static IntPtr n_GetEssencePartitions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.MXFDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mxf.Model.MXFPartition>.ToLocalJniHandle (__this.EssencePartitions);
		}
#pragma warning restore 0169

		static IntPtr id_getEssencePartitions;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mxf.Model.MXFPartition> EssencePartitions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/method[@name='getEssencePartitions' and count(parameter)=0]"
			[Register ("getEssencePartitions", "()Ljava/util/List;", "GetGetEssencePartitionsHandler")]
			get {
				if (id_getEssencePartitions == IntPtr.Zero)
					id_getEssencePartitions = JNIEnv.GetMethodID (class_ref, "getEssencePartitions", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mxf.Model.MXFPartition>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEssencePartitions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mxf.Model.MXFPartition>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEssencePartitions", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIndexes;
#pragma warning disable 0169
		static Delegate GetGetIndexesHandler ()
		{
			if (cb_getIndexes == null)
				cb_getIndexes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIndexes);
			return cb_getIndexes;
		}

		static IntPtr n_GetIndexes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.MXFDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment>.ToLocalJniHandle (__this.Indexes);
		}
#pragma warning restore 0169

		static IntPtr id_getIndexes;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> Indexes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/method[@name='getIndexes' and count(parameter)=0]"
			[Register ("getIndexes", "()Ljava/util/List;", "GetGetIndexesHandler")]
			get {
				if (id_getIndexes == IntPtr.Zero)
					id_getIndexes = JNIEnv.GetMethodID (class_ref, "getIndexes", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIndexes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexes", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOp;
#pragma warning disable 0169
		static Delegate GetGetOpHandler ()
		{
			if (cb_getOp == null)
				cb_getOp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOp);
			return cb_getOp;
		}

		static IntPtr n_GetOp (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.MXFDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Op);
		}
#pragma warning restore 0169

		static IntPtr id_getOp;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP Op {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/method[@name='getOp' and count(parameter)=0]"
			[Register ("getOp", "()Lorg/jcodec/containers/mxf/MXFDemuxer$OP;", "GetGetOpHandler")]
			get {
				if (id_getOp == IntPtr.Zero)
					id_getOp = JNIEnv.GetMethodID (class_ref, "getOp", "()Lorg/jcodec/containers/mxf/MXFDemuxer$OP;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOp), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.OP> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOp", "()Lorg/jcodec/containers/mxf/MXFDemuxer$OP;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimecode;
#pragma warning disable 0169
		static Delegate GetGetTimecodeHandler ()
		{
			if (cb_getTimecode == null)
				cb_getTimecode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimecode);
			return cb_getTimecode;
		}

		static IntPtr n_GetTimecode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.MXFDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Timecode);
		}
#pragma warning restore 0169

		static IntPtr id_getTimecode;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.TimecodeComponent Timecode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/method[@name='getTimecode' and count(parameter)=0]"
			[Register ("getTimecode", "()Lorg/jcodec/containers/mxf/model/TimecodeComponent;", "GetGetTimecodeHandler")]
			get {
				if (id_getTimecode == IntPtr.Zero)
					id_getTimecode = JNIEnv.GetMethodID (class_ref, "getTimecode", "()Lorg/jcodec/containers/mxf/model/TimecodeComponent;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.TimecodeComponent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimecode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.TimecodeComponent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimecode", "()Lorg/jcodec/containers/mxf/model/TimecodeComponent;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Containers.Mxf.MXFDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoTrack);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoTrack;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack VideoTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/method[@name='getVideoTrack' and count(parameter)=0]"
			[Register ("getVideoTrack", "()Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;", "GetGetVideoTrackHandler")]
			get {
				if (id_getVideoTrack == IntPtr.Zero)
					id_getVideoTrack = JNIEnv.GetMethodID (class_ref, "getVideoTrack", "()Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoTrack), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoTrack", "()Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_;
#pragma warning disable 0169
		static Delegate GetCreateTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_Handler ()
		{
			if (cb_createTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_ == null)
				cb_createTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_);
			return cb_createTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_;
		}

		static IntPtr n_CreateTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Jcodec.Containers.Mxf.MXFDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mxf.Model.UL p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mxf.Model.TimelineTrack p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.TimelineTrack> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor p2 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateTrack (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/method[@name='createTrack' and count(parameter)=3 and parameter[1][@type='org.jcodec.containers.mxf.model.UL'] and parameter[2][@type='org.jcodec.containers.mxf.model.TimelineTrack'] and parameter[3][@type='org.jcodec.containers.mxf.model.GenericDescriptor']]"
		[Register ("createTrack", "(Lorg/jcodec/containers/mxf/model/UL;Lorg/jcodec/containers/mxf/model/TimelineTrack;Lorg/jcodec/containers/mxf/model/GenericDescriptor;)Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;", "GetCreateTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_Handler")]
		protected virtual unsafe global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack CreateTrack (global::Org.Jcodec.Containers.Mxf.Model.UL p0, global::Org.Jcodec.Containers.Mxf.Model.TimelineTrack p1, global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor p2)
		{
			if (id_createTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_ == IntPtr.Zero)
				id_createTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_ = JNIEnv.GetMethodID (class_ref, "createTrack", "(Lorg/jcodec/containers/mxf/model/UL;Lorg/jcodec/containers/mxf/model/TimelineTrack;Lorg/jcodec/containers/mxf/model/GenericDescriptor;)Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createTrack_Lorg_jcodec_containers_mxf_model_UL_Lorg_jcodec_containers_mxf_model_TimelineTrack_Lorg_jcodec_containers_mxf_model_GenericDescriptor_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createTrack", "(Lorg/jcodec/containers/mxf/model/UL;Lorg/jcodec/containers/mxf/model/TimelineTrack;Lorg/jcodec/containers/mxf/model/GenericDescriptor;)Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findDescriptor_Ljava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/method[@name='findDescriptor' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.jcodec.containers.mxf.model.FileDescriptor&gt;'] and parameter[2][@type='int']]"
		[Register ("findDescriptor", "(Ljava/util/List;I)Lorg/jcodec/containers/mxf/model/FileDescriptor;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor FindDescriptor (global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor> p0, int p1)
		{
			if (id_findDescriptor_Ljava_util_List_I == IntPtr.Zero)
				id_findDescriptor_Ljava_util_List_I = JNIEnv.GetStaticMethodID (class_ref, "findDescriptor", "(Ljava/util/List;I)Lorg/jcodec/containers/mxf/model/FileDescriptor;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findDescriptor_Ljava_util_List_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Jcodec.Containers.Mxf.MXFDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAudioTracks ());
		}
#pragma warning restore 0169

		static IntPtr id_getAudioTracks;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/method[@name='getAudioTracks' and count(parameter)=0]"
		[Register ("getAudioTracks", "()[Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;", "GetGetAudioTracksHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack[] GetAudioTracks ()
		{
			if (id_getAudioTracks == IntPtr.Zero)
				id_getAudioTracks = JNIEnv.GetMethodID (class_ref, "getAudioTracks", "()[Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioTracks), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack));
				else
					return (global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioTracks", "()[Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack));
			} finally {
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
			global::Org.Jcodec.Containers.Mxf.MXFDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTracks ());
		}
#pragma warning restore 0169

		static IntPtr id_getTracks;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFDemuxer']/method[@name='getTracks' and count(parameter)=0]"
		[Register ("getTracks", "()[Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;", "GetGetTracksHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack[] GetTracks ()
		{
			if (id_getTracks == IntPtr.Zero)
				id_getTracks = JNIEnv.GetMethodID (class_ref, "getTracks", "()[Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTracks), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack));
				else
					return (global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTracks", "()[Lorg/jcodec/containers/mxf/MXFDemuxer$MXFDemuxerTrack;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.MXFDemuxer.MXFDemuxerTrack));
			} finally {
			}
		}

	}
}
