using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='TimelineTrack']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/TimelineTrack", DoNotGenerateAcw=true)]
	public partial class TimelineTrack : global::Org.Jcodec.Containers.Mxf.Model.GenericTrack {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/TimelineTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimelineTrack); }
		}

		protected TimelineTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='TimelineTrack']/constructor[@name='TimelineTrack' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe TimelineTrack (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TimelineTrack)) {
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

		static Delegate cb_getEditRate;
#pragma warning disable 0169
		static Delegate GetGetEditRateHandler ()
		{
			if (cb_getEditRate == null)
				cb_getEditRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEditRate);
			return cb_getEditRate;
		}

		static IntPtr n_GetEditRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.TimelineTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.TimelineTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EditRate);
		}
#pragma warning restore 0169

		static IntPtr id_getEditRate;
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational EditRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='TimelineTrack']/method[@name='getEditRate' and count(parameter)=0]"
			[Register ("getEditRate", "()Lorg/jcodec/common/model/Rational;", "GetGetEditRateHandler")]
			get {
				if (id_getEditRate == IntPtr.Zero)
					id_getEditRate = JNIEnv.GetMethodID (class_ref, "getEditRate", "()Lorg/jcodec/common/model/Rational;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEditRate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEditRate", "()Lorg/jcodec/common/model/Rational;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrigin;
#pragma warning disable 0169
		static Delegate GetGetOriginHandler ()
		{
			if (cb_getOrigin == null)
				cb_getOrigin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetOrigin);
			return cb_getOrigin;
		}

		static long n_GetOrigin (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.TimelineTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.TimelineTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Origin;
		}
#pragma warning restore 0169

		static IntPtr id_getOrigin;
		public virtual unsafe long Origin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='TimelineTrack']/method[@name='getOrigin' and count(parameter)=0]"
			[Register ("getOrigin", "()J", "GetGetOriginHandler")]
			get {
				if (id_getOrigin == IntPtr.Zero)
					id_getOrigin = JNIEnv.GetMethodID (class_ref, "getOrigin", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getOrigin);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrigin", "()J"));
				} finally {
				}
			}
		}

	}
}
