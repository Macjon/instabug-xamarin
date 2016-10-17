using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='FileDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/FileDescriptor", DoNotGenerateAcw=true)]
	public partial class FileDescriptor : global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/FileDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileDescriptor); }
		}

		protected FileDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='FileDescriptor']/constructor[@name='FileDescriptor' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe FileDescriptor (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FileDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/containers/mxf/model/UL;)V", __args),
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
			global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Codec);
		}
#pragma warning restore 0169

		static IntPtr id_getCodec;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL Codec {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='FileDescriptor']/method[@name='getCodec' and count(parameter)=0]"
			[Register ("getCodec", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetCodecHandler")]
			get {
				if (id_getCodec == IntPtr.Zero)
					id_getCodec = JNIEnv.GetMethodID (class_ref, "getCodec", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodec), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodec", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContainerDuration;
#pragma warning disable 0169
		static Delegate GetGetContainerDurationHandler ()
		{
			if (cb_getContainerDuration == null)
				cb_getContainerDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetContainerDuration);
			return cb_getContainerDuration;
		}

		static long n_GetContainerDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContainerDuration;
		}
#pragma warning restore 0169

		static IntPtr id_getContainerDuration;
		public virtual unsafe long ContainerDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='FileDescriptor']/method[@name='getContainerDuration' and count(parameter)=0]"
			[Register ("getContainerDuration", "()J", "GetGetContainerDurationHandler")]
			get {
				if (id_getContainerDuration == IntPtr.Zero)
					id_getContainerDuration = JNIEnv.GetMethodID (class_ref, "getContainerDuration", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getContainerDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContainerDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getEssenceContainer;
#pragma warning disable 0169
		static Delegate GetGetEssenceContainerHandler ()
		{
			if (cb_getEssenceContainer == null)
				cb_getEssenceContainer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEssenceContainer);
			return cb_getEssenceContainer;
		}

		static IntPtr n_GetEssenceContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EssenceContainer);
		}
#pragma warning restore 0169

		static IntPtr id_getEssenceContainer;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL EssenceContainer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='FileDescriptor']/method[@name='getEssenceContainer' and count(parameter)=0]"
			[Register ("getEssenceContainer", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetEssenceContainerHandler")]
			get {
				if (id_getEssenceContainer == IntPtr.Zero)
					id_getEssenceContainer = JNIEnv.GetMethodID (class_ref, "getEssenceContainer", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEssenceContainer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEssenceContainer", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLinkedTrackId;
#pragma warning disable 0169
		static Delegate GetGetLinkedTrackIdHandler ()
		{
			if (cb_getLinkedTrackId == null)
				cb_getLinkedTrackId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLinkedTrackId);
			return cb_getLinkedTrackId;
		}

		static int n_GetLinkedTrackId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LinkedTrackId;
		}
#pragma warning restore 0169

		static IntPtr id_getLinkedTrackId;
		public virtual unsafe int LinkedTrackId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='FileDescriptor']/method[@name='getLinkedTrackId' and count(parameter)=0]"
			[Register ("getLinkedTrackId", "()I", "GetGetLinkedTrackIdHandler")]
			get {
				if (id_getLinkedTrackId == IntPtr.Zero)
					id_getLinkedTrackId = JNIEnv.GetMethodID (class_ref, "getLinkedTrackId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLinkedTrackId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLinkedTrackId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSampleRate;
#pragma warning disable 0169
		static Delegate GetGetSampleRateHandler ()
		{
			if (cb_getSampleRate == null)
				cb_getSampleRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSampleRate);
			return cb_getSampleRate;
		}

		static IntPtr n_GetSampleRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SampleRate);
		}
#pragma warning restore 0169

		static IntPtr id_getSampleRate;
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational SampleRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='FileDescriptor']/method[@name='getSampleRate' and count(parameter)=0]"
			[Register ("getSampleRate", "()Lorg/jcodec/common/model/Rational;", "GetGetSampleRateHandler")]
			get {
				if (id_getSampleRate == IntPtr.Zero)
					id_getSampleRate = JNIEnv.GetMethodID (class_ref, "getSampleRate", "()Lorg/jcodec/common/model/Rational;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSampleRate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampleRate", "()Lorg/jcodec/common/model/Rational;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
