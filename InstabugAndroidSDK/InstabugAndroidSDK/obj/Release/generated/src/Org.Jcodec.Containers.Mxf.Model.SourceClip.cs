using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='SourceClip']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/SourceClip", DoNotGenerateAcw=true)]
	public partial class SourceClip : global::Org.Jcodec.Containers.Mxf.Model.MXFStructuralComponent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/SourceClip", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SourceClip); }
		}

		protected SourceClip (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='SourceClip']/constructor[@name='SourceClip' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe SourceClip (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SourceClip)) {
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

		static Delegate cb_getSourcePackageUid;
#pragma warning disable 0169
		static Delegate GetGetSourcePackageUidHandler ()
		{
			if (cb_getSourcePackageUid == null)
				cb_getSourcePackageUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSourcePackageUid);
			return cb_getSourcePackageUid;
		}

		static IntPtr n_GetSourcePackageUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.SourceClip __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.SourceClip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourcePackageUid);
		}
#pragma warning restore 0169

		static IntPtr id_getSourcePackageUid;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL SourcePackageUid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='SourceClip']/method[@name='getSourcePackageUid' and count(parameter)=0]"
			[Register ("getSourcePackageUid", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetSourcePackageUidHandler")]
			get {
				if (id_getSourcePackageUid == IntPtr.Zero)
					id_getSourcePackageUid = JNIEnv.GetMethodID (class_ref, "getSourcePackageUid", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSourcePackageUid), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSourcePackageUid", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSourceTrackId;
#pragma warning disable 0169
		static Delegate GetGetSourceTrackIdHandler ()
		{
			if (cb_getSourceTrackId == null)
				cb_getSourceTrackId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSourceTrackId);
			return cb_getSourceTrackId;
		}

		static int n_GetSourceTrackId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.SourceClip __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.SourceClip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SourceTrackId;
		}
#pragma warning restore 0169

		static IntPtr id_getSourceTrackId;
		public virtual unsafe int SourceTrackId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='SourceClip']/method[@name='getSourceTrackId' and count(parameter)=0]"
			[Register ("getSourceTrackId", "()I", "GetGetSourceTrackIdHandler")]
			get {
				if (id_getSourceTrackId == IntPtr.Zero)
					id_getSourceTrackId = JNIEnv.GetMethodID (class_ref, "getSourceTrackId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSourceTrackId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSourceTrackId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getStartPosition;
#pragma warning disable 0169
		static Delegate GetGetStartPositionHandler ()
		{
			if (cb_getStartPosition == null)
				cb_getStartPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStartPosition);
			return cb_getStartPosition;
		}

		static long n_GetStartPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.SourceClip __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.SourceClip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getStartPosition;
		public virtual unsafe long StartPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='SourceClip']/method[@name='getStartPosition' and count(parameter)=0]"
			[Register ("getStartPosition", "()J", "GetGetStartPositionHandler")]
			get {
				if (id_getStartPosition == IntPtr.Zero)
					id_getStartPosition = JNIEnv.GetMethodID (class_ref, "getStartPosition", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getStartPosition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartPosition", "()J"));
				} finally {
				}
			}
		}

	}
}
