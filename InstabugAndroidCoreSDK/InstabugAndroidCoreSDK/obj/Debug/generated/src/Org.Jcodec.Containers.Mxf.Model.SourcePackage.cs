using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='SourcePackage']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/SourcePackage", DoNotGenerateAcw=true)]
	public partial class SourcePackage : global::Org.Jcodec.Containers.Mxf.Model.GenericPackage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/SourcePackage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SourcePackage); }
		}

		protected SourcePackage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='SourcePackage']/constructor[@name='SourcePackage' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe SourcePackage (global::Org.Jcodec.Containers.Mxf.Model.UL ul)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ul);
				if (((object) this).GetType () != typeof (SourcePackage)) {
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

		static Delegate cb_getDescriptorRef;
#pragma warning disable 0169
		static Delegate GetGetDescriptorRefHandler ()
		{
			if (cb_getDescriptorRef == null)
				cb_getDescriptorRef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescriptorRef);
			return cb_getDescriptorRef;
		}

		static IntPtr n_GetDescriptorRef (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.SourcePackage __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.SourcePackage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DescriptorRef);
		}
#pragma warning restore 0169

		static IntPtr id_getDescriptorRef;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL DescriptorRef {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='SourcePackage']/method[@name='getDescriptorRef' and count(parameter)=0]"
			[Register ("getDescriptorRef", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetDescriptorRefHandler")]
			get {
				if (id_getDescriptorRef == IntPtr.Zero)
					id_getDescriptorRef = JNIEnv.GetMethodID (class_ref, "getDescriptorRef", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescriptorRef), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescriptorRef", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackageUid;
#pragma warning disable 0169
		static Delegate GetGetPackageUidHandler ()
		{
			if (cb_getPackageUid == null)
				cb_getPackageUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageUid);
			return cb_getPackageUid;
		}

		static IntPtr n_GetPackageUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.SourcePackage __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.SourcePackage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackageUid);
		}
#pragma warning restore 0169

		static IntPtr id_getPackageUid;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL PackageUid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='SourcePackage']/method[@name='getPackageUid' and count(parameter)=0]"
			[Register ("getPackageUid", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetPackageUidHandler")]
			get {
				if (id_getPackageUid == IntPtr.Zero)
					id_getPackageUid = JNIEnv.GetMethodID (class_ref, "getPackageUid", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackageUid), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPackageUid", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackRefs;
#pragma warning disable 0169
		static Delegate GetGetTrackRefsHandler ()
		{
			if (cb_getTrackRefs == null)
				cb_getTrackRefs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackRefs);
			return cb_getTrackRefs;
		}

		static IntPtr n_GetTrackRefs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.SourcePackage __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.SourcePackage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTrackRefs ());
		}
#pragma warning restore 0169

		static IntPtr id_getTrackRefs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='SourcePackage']/method[@name='getTrackRefs' and count(parameter)=0]"
		[Register ("getTrackRefs", "()[Lorg/jcodec/containers/mxf/model/UL;", "GetGetTrackRefsHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL[] GetTrackRefs ()
		{
			if (id_getTrackRefs == IntPtr.Zero)
				id_getTrackRefs = JNIEnv.GetMethodID (class_ref, "getTrackRefs", "()[Lorg/jcodec/containers/mxf/model/UL;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackRefs), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
				else
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackRefs", "()[Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
			} finally {
			}
		}

	}
}
