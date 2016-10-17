using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Sequence']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/Sequence", DoNotGenerateAcw=true)]
	public partial class Sequence : global::Org.Jcodec.Containers.Mxf.Model.MXFStructuralComponent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/Sequence", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Sequence); }
		}

		protected Sequence (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Sequence']/constructor[@name='Sequence' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe Sequence (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Sequence)) {
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

		static Delegate cb_getStructuralComponentsRefs;
#pragma warning disable 0169
		static Delegate GetGetStructuralComponentsRefsHandler ()
		{
			if (cb_getStructuralComponentsRefs == null)
				cb_getStructuralComponentsRefs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStructuralComponentsRefs);
			return cb_getStructuralComponentsRefs;
		}

		static IntPtr n_GetStructuralComponentsRefs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Sequence __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Sequence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetStructuralComponentsRefs ());
		}
#pragma warning restore 0169

		static IntPtr id_getStructuralComponentsRefs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Sequence']/method[@name='getStructuralComponentsRefs' and count(parameter)=0]"
		[Register ("getStructuralComponentsRefs", "()[Lorg/jcodec/containers/mxf/model/UL;", "GetGetStructuralComponentsRefsHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL[] GetStructuralComponentsRefs ()
		{
			if (id_getStructuralComponentsRefs == IntPtr.Zero)
				id_getStructuralComponentsRefs = JNIEnv.GetMethodID (class_ref, "getStructuralComponentsRefs", "()[Lorg/jcodec/containers/mxf/model/UL;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStructuralComponentsRefs), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
				else
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStructuralComponentsRefs", "()[Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
			} finally {
			}
		}

	}
}
