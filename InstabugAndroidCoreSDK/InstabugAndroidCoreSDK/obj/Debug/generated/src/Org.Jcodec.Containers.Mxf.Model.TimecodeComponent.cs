using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='TimecodeComponent']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/TimecodeComponent", DoNotGenerateAcw=true)]
	public partial class TimecodeComponent : global::Org.Jcodec.Containers.Mxf.Model.MXFStructuralComponent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/TimecodeComponent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimecodeComponent); }
		}

		protected TimecodeComponent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='TimecodeComponent']/constructor[@name='TimecodeComponent' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe TimecodeComponent (global::Org.Jcodec.Containers.Mxf.Model.UL ul)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ul);
				if (((object) this).GetType () != typeof (TimecodeComponent)) {
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

		static Delegate cb_getBase;
#pragma warning disable 0169
		static Delegate GetGetBaseHandler ()
		{
			if (cb_getBase == null)
				cb_getBase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBase);
			return cb_getBase;
		}

		static int n_GetBase (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.TimecodeComponent __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.TimecodeComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Base;
		}
#pragma warning restore 0169

		static IntPtr id_getBase;
		public virtual unsafe int Base {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='TimecodeComponent']/method[@name='getBase' and count(parameter)=0]"
			[Register ("getBase", "()I", "GetGetBaseHandler")]
			get {
				if (id_getBase == IntPtr.Zero)
					id_getBase = JNIEnv.GetMethodID (class_ref, "getBase", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBase);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBase", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDropFrame;
#pragma warning disable 0169
		static Delegate GetGetDropFrameHandler ()
		{
			if (cb_getDropFrame == null)
				cb_getDropFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDropFrame);
			return cb_getDropFrame;
		}

		static int n_GetDropFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.TimecodeComponent __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.TimecodeComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DropFrame;
		}
#pragma warning restore 0169

		static IntPtr id_getDropFrame;
		public virtual unsafe int DropFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='TimecodeComponent']/method[@name='getDropFrame' and count(parameter)=0]"
			[Register ("getDropFrame", "()I", "GetGetDropFrameHandler")]
			get {
				if (id_getDropFrame == IntPtr.Zero)
					id_getDropFrame = JNIEnv.GetMethodID (class_ref, "getDropFrame", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDropFrame);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDropFrame", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getStart;
#pragma warning disable 0169
		static Delegate GetGetStartHandler ()
		{
			if (cb_getStart == null)
				cb_getStart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStart);
			return cb_getStart;
		}

		static long n_GetStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.TimecodeComponent __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.TimecodeComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Start;
		}
#pragma warning restore 0169

		static IntPtr id_getStart;
		public virtual unsafe long Start {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='TimecodeComponent']/method[@name='getStart' and count(parameter)=0]"
			[Register ("getStart", "()J", "GetGetStartHandler")]
			get {
				if (id_getStart == IntPtr.Zero)
					id_getStart = JNIEnv.GetMethodID (class_ref, "getStart", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getStart);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStart", "()J"));
				} finally {
				}
			}
		}

	}
}
