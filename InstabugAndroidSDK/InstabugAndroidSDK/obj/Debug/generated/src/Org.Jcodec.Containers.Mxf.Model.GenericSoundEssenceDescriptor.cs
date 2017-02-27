using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericSoundEssenceDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/GenericSoundEssenceDescriptor", DoNotGenerateAcw=true)]
	public partial class GenericSoundEssenceDescriptor : global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/GenericSoundEssenceDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericSoundEssenceDescriptor); }
		}

		protected GenericSoundEssenceDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericSoundEssenceDescriptor']/constructor[@name='GenericSoundEssenceDescriptor' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe GenericSoundEssenceDescriptor (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (GenericSoundEssenceDescriptor)) {
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

		static Delegate cb_getAudioRefLevel;
#pragma warning disable 0169
		static Delegate GetGetAudioRefLevelHandler ()
		{
			if (cb_getAudioRefLevel == null)
				cb_getAudioRefLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetAudioRefLevel);
			return cb_getAudioRefLevel;
		}

		static sbyte n_GetAudioRefLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioRefLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioRefLevel;
		public virtual unsafe sbyte AudioRefLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericSoundEssenceDescriptor']/method[@name='getAudioRefLevel' and count(parameter)=0]"
			[Register ("getAudioRefLevel", "()B", "GetGetAudioRefLevelHandler")]
			get {
				if (id_getAudioRefLevel == IntPtr.Zero)
					id_getAudioRefLevel = JNIEnv.GetMethodID (class_ref, "getAudioRefLevel", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getAudioRefLevel);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioRefLevel", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getAudioSamplingRate;
#pragma warning disable 0169
		static Delegate GetGetAudioSamplingRateHandler ()
		{
			if (cb_getAudioSamplingRate == null)
				cb_getAudioSamplingRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioSamplingRate);
			return cb_getAudioSamplingRate;
		}

		static IntPtr n_GetAudioSamplingRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioSamplingRate);
		}
#pragma warning restore 0169

		static IntPtr id_getAudioSamplingRate;
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational AudioSamplingRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericSoundEssenceDescriptor']/method[@name='getAudioSamplingRate' and count(parameter)=0]"
			[Register ("getAudioSamplingRate", "()Lorg/jcodec/common/model/Rational;", "GetGetAudioSamplingRateHandler")]
			get {
				if (id_getAudioSamplingRate == IntPtr.Zero)
					id_getAudioSamplingRate = JNIEnv.GetMethodID (class_ref, "getAudioSamplingRate", "()Lorg/jcodec/common/model/Rational;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioSamplingRate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioSamplingRate", "()Lorg/jcodec/common/model/Rational;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelCount;
#pragma warning disable 0169
		static Delegate GetGetChannelCountHandler ()
		{
			if (cb_getChannelCount == null)
				cb_getChannelCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChannelCount);
			return cb_getChannelCount;
		}

		static int n_GetChannelCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChannelCount;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelCount;
		public virtual unsafe int ChannelCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericSoundEssenceDescriptor']/method[@name='getChannelCount' and count(parameter)=0]"
			[Register ("getChannelCount", "()I", "GetGetChannelCountHandler")]
			get {
				if (id_getChannelCount == IntPtr.Zero)
					id_getChannelCount = JNIEnv.GetMethodID (class_ref, "getChannelCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChannelCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDialNorm;
#pragma warning disable 0169
		static Delegate GetGetDialNormHandler ()
		{
			if (cb_getDialNorm == null)
				cb_getDialNorm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetDialNorm);
			return cb_getDialNorm;
		}

		static sbyte n_GetDialNorm (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DialNorm;
		}
#pragma warning restore 0169

		static IntPtr id_getDialNorm;
		public virtual unsafe sbyte DialNorm {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericSoundEssenceDescriptor']/method[@name='getDialNorm' and count(parameter)=0]"
			[Register ("getDialNorm", "()B", "GetGetDialNormHandler")]
			get {
				if (id_getDialNorm == IntPtr.Zero)
					id_getDialNorm = JNIEnv.GetMethodID (class_ref, "getDialNorm", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getDialNorm);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDialNorm", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getElectroSpatialFormulation;
#pragma warning disable 0169
		static Delegate GetGetElectroSpatialFormulationHandler ()
		{
			if (cb_getElectroSpatialFormulation == null)
				cb_getElectroSpatialFormulation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetElectroSpatialFormulation);
			return cb_getElectroSpatialFormulation;
		}

		static sbyte n_GetElectroSpatialFormulation (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElectroSpatialFormulation;
		}
#pragma warning restore 0169

		static IntPtr id_getElectroSpatialFormulation;
		public virtual unsafe sbyte ElectroSpatialFormulation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericSoundEssenceDescriptor']/method[@name='getElectroSpatialFormulation' and count(parameter)=0]"
			[Register ("getElectroSpatialFormulation", "()B", "GetGetElectroSpatialFormulationHandler")]
			get {
				if (id_getElectroSpatialFormulation == IntPtr.Zero)
					id_getElectroSpatialFormulation = JNIEnv.GetMethodID (class_ref, "getElectroSpatialFormulation", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getElectroSpatialFormulation);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElectroSpatialFormulation", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getLocked;
#pragma warning disable 0169
		static Delegate GetGetLockedHandler ()
		{
			if (cb_getLocked == null)
				cb_getLocked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetLocked);
			return cb_getLocked;
		}

		static sbyte n_GetLocked (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Locked;
		}
#pragma warning restore 0169

		static IntPtr id_getLocked;
		public virtual unsafe sbyte Locked {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericSoundEssenceDescriptor']/method[@name='getLocked' and count(parameter)=0]"
			[Register ("getLocked", "()B", "GetGetLockedHandler")]
			get {
				if (id_getLocked == IntPtr.Zero)
					id_getLocked = JNIEnv.GetMethodID (class_ref, "getLocked", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getLocked);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocked", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getQuantizationBits;
#pragma warning disable 0169
		static Delegate GetGetQuantizationBitsHandler ()
		{
			if (cb_getQuantizationBits == null)
				cb_getQuantizationBits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetQuantizationBits);
			return cb_getQuantizationBits;
		}

		static int n_GetQuantizationBits (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.QuantizationBits;
		}
#pragma warning restore 0169

		static IntPtr id_getQuantizationBits;
		public virtual unsafe int QuantizationBits {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericSoundEssenceDescriptor']/method[@name='getQuantizationBits' and count(parameter)=0]"
			[Register ("getQuantizationBits", "()I", "GetGetQuantizationBitsHandler")]
			get {
				if (id_getQuantizationBits == IntPtr.Zero)
					id_getQuantizationBits = JNIEnv.GetMethodID (class_ref, "getQuantizationBits", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getQuantizationBits);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuantizationBits", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSoundEssenceCompression;
#pragma warning disable 0169
		static Delegate GetGetSoundEssenceCompressionHandler ()
		{
			if (cb_getSoundEssenceCompression == null)
				cb_getSoundEssenceCompression = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSoundEssenceCompression);
			return cb_getSoundEssenceCompression;
		}

		static IntPtr n_GetSoundEssenceCompression (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericSoundEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SoundEssenceCompression);
		}
#pragma warning restore 0169

		static IntPtr id_getSoundEssenceCompression;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL SoundEssenceCompression {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericSoundEssenceDescriptor']/method[@name='getSoundEssenceCompression' and count(parameter)=0]"
			[Register ("getSoundEssenceCompression", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetSoundEssenceCompressionHandler")]
			get {
				if (id_getSoundEssenceCompression == IntPtr.Zero)
					id_getSoundEssenceCompression = JNIEnv.GetMethodID (class_ref, "getSoundEssenceCompression", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSoundEssenceCompression), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSoundEssenceCompression", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
