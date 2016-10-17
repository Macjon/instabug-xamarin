using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericDataEssenceDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/GenericDataEssenceDescriptor", DoNotGenerateAcw=true)]
	public partial class GenericDataEssenceDescriptor : global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/GenericDataEssenceDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericDataEssenceDescriptor); }
		}

		protected GenericDataEssenceDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericDataEssenceDescriptor']/constructor[@name='GenericDataEssenceDescriptor' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe GenericDataEssenceDescriptor (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GenericDataEssenceDescriptor)) {
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

		static Delegate cb_getDataEssenceCoding;
#pragma warning disable 0169
		static Delegate GetGetDataEssenceCodingHandler ()
		{
			if (cb_getDataEssenceCoding == null)
				cb_getDataEssenceCoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataEssenceCoding);
			return cb_getDataEssenceCoding;
		}

		static IntPtr n_GetDataEssenceCoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericDataEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericDataEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataEssenceCoding);
		}
#pragma warning restore 0169

		static IntPtr id_getDataEssenceCoding;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL DataEssenceCoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericDataEssenceDescriptor']/method[@name='getDataEssenceCoding' and count(parameter)=0]"
			[Register ("getDataEssenceCoding", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetDataEssenceCodingHandler")]
			get {
				if (id_getDataEssenceCoding == IntPtr.Zero)
					id_getDataEssenceCoding = JNIEnv.GetMethodID (class_ref, "getDataEssenceCoding", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataEssenceCoding), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataEssenceCoding", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
