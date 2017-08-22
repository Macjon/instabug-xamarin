using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/WaveAudioDescriptor", DoNotGenerateAcw=true)]
	public partial class WaveAudioDescriptor : global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/WaveAudioDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WaveAudioDescriptor); }
		}

		protected WaveAudioDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/constructor[@name='WaveAudioDescriptor' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe WaveAudioDescriptor (global::Org.Jcodec.Containers.Mxf.Model.UL ul)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ul);
				if (((object) this).GetType () != typeof (WaveAudioDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/containers/mxf/model/UL;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mxf/model/UL;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mxf_model_UL_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mxf_model_UL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mxf/model/UL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args);
			} finally {
			}
		}

		static Delegate cb_getAvgBps;
#pragma warning disable 0169
		static Delegate GetGetAvgBpsHandler ()
		{
			if (cb_getAvgBps == null)
				cb_getAvgBps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAvgBps);
			return cb_getAvgBps;
		}

		static int n_GetAvgBps (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AvgBps;
		}
#pragma warning restore 0169

		static IntPtr id_getAvgBps;
		public virtual unsafe int AvgBps {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getAvgBps' and count(parameter)=0]"
			[Register ("getAvgBps", "()I", "GetGetAvgBpsHandler")]
			get {
				if (id_getAvgBps == IntPtr.Zero)
					id_getAvgBps = JNIEnv.GetMethodID (class_ref, "getAvgBps", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAvgBps);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvgBps", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getBlockAlign;
#pragma warning disable 0169
		static Delegate GetGetBlockAlignHandler ()
		{
			if (cb_getBlockAlign == null)
				cb_getBlockAlign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetBlockAlign);
			return cb_getBlockAlign;
		}

		static short n_GetBlockAlign (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockAlign;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockAlign;
		public virtual unsafe short BlockAlign {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getBlockAlign' and count(parameter)=0]"
			[Register ("getBlockAlign", "()S", "GetGetBlockAlignHandler")]
			get {
				if (id_getBlockAlign == IntPtr.Zero)
					id_getBlockAlign = JNIEnv.GetMethodID (class_ref, "getBlockAlign", "()S");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getBlockAlign);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockAlign", "()S"));
				} finally {
				}
			}
		}

		static Delegate cb_getChannelAssignment;
#pragma warning disable 0169
		static Delegate GetGetChannelAssignmentHandler ()
		{
			if (cb_getChannelAssignment == null)
				cb_getChannelAssignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelAssignment);
			return cb_getChannelAssignment;
		}

		static IntPtr n_GetChannelAssignment (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChannelAssignment);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelAssignment;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL ChannelAssignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getChannelAssignment' and count(parameter)=0]"
			[Register ("getChannelAssignment", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetChannelAssignmentHandler")]
			get {
				if (id_getChannelAssignment == IntPtr.Zero)
					id_getChannelAssignment = JNIEnv.GetMethodID (class_ref, "getChannelAssignment", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelAssignment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelAssignment", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPeakChannels;
#pragma warning disable 0169
		static Delegate GetGetPeakChannelsHandler ()
		{
			if (cb_getPeakChannels == null)
				cb_getPeakChannels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPeakChannels);
			return cb_getPeakChannels;
		}

		static int n_GetPeakChannels (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeakChannels;
		}
#pragma warning restore 0169

		static IntPtr id_getPeakChannels;
		public virtual unsafe int PeakChannels {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getPeakChannels' and count(parameter)=0]"
			[Register ("getPeakChannels", "()I", "GetGetPeakChannelsHandler")]
			get {
				if (id_getPeakChannels == IntPtr.Zero)
					id_getPeakChannels = JNIEnv.GetMethodID (class_ref, "getPeakChannels", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPeakChannels);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeakChannels", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPeakEnvelopeBlockSize;
#pragma warning disable 0169
		static Delegate GetGetPeakEnvelopeBlockSizeHandler ()
		{
			if (cb_getPeakEnvelopeBlockSize == null)
				cb_getPeakEnvelopeBlockSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPeakEnvelopeBlockSize);
			return cb_getPeakEnvelopeBlockSize;
		}

		static int n_GetPeakEnvelopeBlockSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeakEnvelopeBlockSize;
		}
#pragma warning restore 0169

		static IntPtr id_getPeakEnvelopeBlockSize;
		public virtual unsafe int PeakEnvelopeBlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getPeakEnvelopeBlockSize' and count(parameter)=0]"
			[Register ("getPeakEnvelopeBlockSize", "()I", "GetGetPeakEnvelopeBlockSizeHandler")]
			get {
				if (id_getPeakEnvelopeBlockSize == IntPtr.Zero)
					id_getPeakEnvelopeBlockSize = JNIEnv.GetMethodID (class_ref, "getPeakEnvelopeBlockSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPeakEnvelopeBlockSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeakEnvelopeBlockSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPeakEnvelopeData;
#pragma warning disable 0169
		static Delegate GetGetPeakEnvelopeDataHandler ()
		{
			if (cb_getPeakEnvelopeData == null)
				cb_getPeakEnvelopeData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPeakEnvelopeData);
			return cb_getPeakEnvelopeData;
		}

		static IntPtr n_GetPeakEnvelopeData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeakEnvelopeData);
		}
#pragma warning restore 0169

		static IntPtr id_getPeakEnvelopeData;
		public virtual unsafe global::Java.Nio.ByteBuffer PeakEnvelopeData {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getPeakEnvelopeData' and count(parameter)=0]"
			[Register ("getPeakEnvelopeData", "()Ljava/nio/ByteBuffer;", "GetGetPeakEnvelopeDataHandler")]
			get {
				if (id_getPeakEnvelopeData == IntPtr.Zero)
					id_getPeakEnvelopeData = JNIEnv.GetMethodID (class_ref, "getPeakEnvelopeData", "()Ljava/nio/ByteBuffer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPeakEnvelopeData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeakEnvelopeData", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPeakEnvelopeFormat;
#pragma warning disable 0169
		static Delegate GetGetPeakEnvelopeFormatHandler ()
		{
			if (cb_getPeakEnvelopeFormat == null)
				cb_getPeakEnvelopeFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPeakEnvelopeFormat);
			return cb_getPeakEnvelopeFormat;
		}

		static int n_GetPeakEnvelopeFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeakEnvelopeFormat;
		}
#pragma warning restore 0169

		static IntPtr id_getPeakEnvelopeFormat;
		public virtual unsafe int PeakEnvelopeFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getPeakEnvelopeFormat' and count(parameter)=0]"
			[Register ("getPeakEnvelopeFormat", "()I", "GetGetPeakEnvelopeFormatHandler")]
			get {
				if (id_getPeakEnvelopeFormat == IntPtr.Zero)
					id_getPeakEnvelopeFormat = JNIEnv.GetMethodID (class_ref, "getPeakEnvelopeFormat", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPeakEnvelopeFormat);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeakEnvelopeFormat", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPeakEnvelopeTimestamp;
#pragma warning disable 0169
		static Delegate GetGetPeakEnvelopeTimestampHandler ()
		{
			if (cb_getPeakEnvelopeTimestamp == null)
				cb_getPeakEnvelopeTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPeakEnvelopeTimestamp);
			return cb_getPeakEnvelopeTimestamp;
		}

		static IntPtr n_GetPeakEnvelopeTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeakEnvelopeTimestamp);
		}
#pragma warning restore 0169

		static IntPtr id_getPeakEnvelopeTimestamp;
		public virtual unsafe global::Java.Nio.ByteBuffer PeakEnvelopeTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getPeakEnvelopeTimestamp' and count(parameter)=0]"
			[Register ("getPeakEnvelopeTimestamp", "()Ljava/nio/ByteBuffer;", "GetGetPeakEnvelopeTimestampHandler")]
			get {
				if (id_getPeakEnvelopeTimestamp == IntPtr.Zero)
					id_getPeakEnvelopeTimestamp = JNIEnv.GetMethodID (class_ref, "getPeakEnvelopeTimestamp", "()Ljava/nio/ByteBuffer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPeakEnvelopeTimestamp), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeakEnvelopeTimestamp", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPeakEnvelopeVersion;
#pragma warning disable 0169
		static Delegate GetGetPeakEnvelopeVersionHandler ()
		{
			if (cb_getPeakEnvelopeVersion == null)
				cb_getPeakEnvelopeVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPeakEnvelopeVersion);
			return cb_getPeakEnvelopeVersion;
		}

		static int n_GetPeakEnvelopeVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeakEnvelopeVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getPeakEnvelopeVersion;
		public virtual unsafe int PeakEnvelopeVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getPeakEnvelopeVersion' and count(parameter)=0]"
			[Register ("getPeakEnvelopeVersion", "()I", "GetGetPeakEnvelopeVersionHandler")]
			get {
				if (id_getPeakEnvelopeVersion == IntPtr.Zero)
					id_getPeakEnvelopeVersion = JNIEnv.GetMethodID (class_ref, "getPeakEnvelopeVersion", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPeakEnvelopeVersion);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeakEnvelopeVersion", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPeakFrames;
#pragma warning disable 0169
		static Delegate GetGetPeakFramesHandler ()
		{
			if (cb_getPeakFrames == null)
				cb_getPeakFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPeakFrames);
			return cb_getPeakFrames;
		}

		static int n_GetPeakFrames (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeakFrames;
		}
#pragma warning restore 0169

		static IntPtr id_getPeakFrames;
		public virtual unsafe int PeakFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getPeakFrames' and count(parameter)=0]"
			[Register ("getPeakFrames", "()I", "GetGetPeakFramesHandler")]
			get {
				if (id_getPeakFrames == IntPtr.Zero)
					id_getPeakFrames = JNIEnv.GetMethodID (class_ref, "getPeakFrames", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPeakFrames);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeakFrames", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPeakOfPeaksPosition;
#pragma warning disable 0169
		static Delegate GetGetPeakOfPeaksPositionHandler ()
		{
			if (cb_getPeakOfPeaksPosition == null)
				cb_getPeakOfPeaksPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPeakOfPeaksPosition);
			return cb_getPeakOfPeaksPosition;
		}

		static IntPtr n_GetPeakOfPeaksPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeakOfPeaksPosition);
		}
#pragma warning restore 0169

		static IntPtr id_getPeakOfPeaksPosition;
		public virtual unsafe global::Java.Nio.ByteBuffer PeakOfPeaksPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getPeakOfPeaksPosition' and count(parameter)=0]"
			[Register ("getPeakOfPeaksPosition", "()Ljava/nio/ByteBuffer;", "GetGetPeakOfPeaksPositionHandler")]
			get {
				if (id_getPeakOfPeaksPosition == IntPtr.Zero)
					id_getPeakOfPeaksPosition = JNIEnv.GetMethodID (class_ref, "getPeakOfPeaksPosition", "()Ljava/nio/ByteBuffer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPeakOfPeaksPosition), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeakOfPeaksPosition", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPointsPerPeakValue;
#pragma warning disable 0169
		static Delegate GetGetPointsPerPeakValueHandler ()
		{
			if (cb_getPointsPerPeakValue == null)
				cb_getPointsPerPeakValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPointsPerPeakValue);
			return cb_getPointsPerPeakValue;
		}

		static int n_GetPointsPerPeakValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PointsPerPeakValue;
		}
#pragma warning restore 0169

		static IntPtr id_getPointsPerPeakValue;
		public virtual unsafe int PointsPerPeakValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getPointsPerPeakValue' and count(parameter)=0]"
			[Register ("getPointsPerPeakValue", "()I", "GetGetPointsPerPeakValueHandler")]
			get {
				if (id_getPointsPerPeakValue == IntPtr.Zero)
					id_getPointsPerPeakValue = JNIEnv.GetMethodID (class_ref, "getPointsPerPeakValue", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPointsPerPeakValue);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPointsPerPeakValue", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSequenceOffset;
#pragma warning disable 0169
		static Delegate GetGetSequenceOffsetHandler ()
		{
			if (cb_getSequenceOffset == null)
				cb_getSequenceOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetSequenceOffset);
			return cb_getSequenceOffset;
		}

		static sbyte n_GetSequenceOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SequenceOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getSequenceOffset;
		public virtual unsafe sbyte SequenceOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='WaveAudioDescriptor']/method[@name='getSequenceOffset' and count(parameter)=0]"
			[Register ("getSequenceOffset", "()B", "GetGetSequenceOffsetHandler")]
			get {
				if (id_getSequenceOffset == IntPtr.Zero)
					id_getSequenceOffset = JNIEnv.GetMethodID (class_ref, "getSequenceOffset", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getSequenceOffset);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSequenceOffset", "()B"));
				} finally {
				}
			}
		}

	}
}
