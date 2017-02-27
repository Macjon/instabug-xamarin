using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.audio']/class[@name='SincLowPassFilter']"
	[global::Android.Runtime.Register ("org/jcodec/audio/SincLowPassFilter", DoNotGenerateAcw=true)]
	public partial class SincLowPassFilter : global::Org.Jcodec.Audio.ConvolutionFilter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/audio/SincLowPassFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SincLowPassFilter); }
		}

		protected SincLowPassFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ID;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.audio']/class[@name='SincLowPassFilter']/constructor[@name='SincLowPassFilter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register (".ctor", "(ID)V", "")]
		public unsafe SincLowPassFilter (int p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SincLowPassFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ID)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ID)V", __args);
					return;
				}

				if (id_ctor_ID == IntPtr.Zero)
					id_ctor_ID = JNIEnv.GetMethodID (class_ref, "<init>", "(ID)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ID, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ID, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.audio']/class[@name='SincLowPassFilter']/constructor[@name='SincLowPassFilter' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe SincLowPassFilter (double p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (SincLowPassFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(D)V", __args);
					return;
				}

				if (id_ctor_D == IntPtr.Zero)
					id_ctor_D = JNIEnv.GetMethodID (class_ref, "<init>", "(D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_D, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.audio']/class[@name='SincLowPassFilter']/constructor[@name='SincLowPassFilter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe SincLowPassFilter (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SincLowPassFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_buildKernel;
#pragma warning disable 0169
		static Delegate GetBuildKernelHandler ()
		{
			if (cb_buildKernel == null)
				cb_buildKernel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildKernel);
			return cb_buildKernel;
		}

		static IntPtr n_BuildKernel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Audio.SincLowPassFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.SincLowPassFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.BuildKernel ());
		}
#pragma warning restore 0169

		static IntPtr id_buildKernel;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='SincLowPassFilter']/method[@name='buildKernel' and count(parameter)=0]"
		[Register ("buildKernel", "()[D", "GetBuildKernelHandler")]
		protected override unsafe double[] BuildKernel ()
		{
			if (id_buildKernel == IntPtr.Zero)
				id_buildKernel = JNIEnv.GetMethodID (class_ref, "buildKernel", "()[D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildKernel), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildKernel", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

	}
}
