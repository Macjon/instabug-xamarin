using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vpx {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='NopRateControl']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vpx/NopRateControl", DoNotGenerateAcw=true)]
	public partial class NopRateControl : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Vpx.IRateControl {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vpx/NopRateControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NopRateControl); }
		}

		protected NopRateControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='NopRateControl']/constructor[@name='NopRateControl' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe NopRateControl (int qp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (qp);
				if (((object) this).GetType () != typeof (NopRateControl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_getSegment;
#pragma warning disable 0169
		static Delegate GetGetSegmentHandler ()
		{
			if (cb_getSegment == null)
				cb_getSegment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSegment);
			return cb_getSegment;
		}

		static int n_GetSegment (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Vpx.NopRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.NopRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Segment;
		}
#pragma warning restore 0169

		static IntPtr id_getSegment;
		public virtual unsafe int Segment {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='NopRateControl']/method[@name='getSegment' and count(parameter)=0]"
			[Register ("getSegment", "()I", "GetGetSegmentHandler")]
			get {
				if (id_getSegment == IntPtr.Zero)
					id_getSegment = JNIEnv.GetMethodID (class_ref, "getSegment", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSegment);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSegment", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSegmentQps;
#pragma warning disable 0169
		static Delegate GetGetSegmentQpsHandler ()
		{
			if (cb_getSegmentQps == null)
				cb_getSegmentQps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSegmentQps);
			return cb_getSegmentQps;
		}

		static IntPtr n_GetSegmentQps (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Vpx.NopRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.NopRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSegmentQps ());
		}
#pragma warning restore 0169

		static IntPtr id_getSegmentQps;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='NopRateControl']/method[@name='getSegmentQps' and count(parameter)=0]"
		[Register ("getSegmentQps", "()[I", "GetGetSegmentQpsHandler")]
		public virtual unsafe int[] GetSegmentQps ()
		{
			if (id_getSegmentQps == IntPtr.Zero)
				id_getSegmentQps = JNIEnv.GetMethodID (class_ref, "getSegmentQps", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSegmentQps), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSegmentQps", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_report_I;
#pragma warning disable 0169
		static Delegate GetReport_IHandler ()
		{
			if (cb_report_I == null)
				cb_report_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Report_I);
			return cb_report_I;
		}

		static void n_Report_I (IntPtr jnienv, IntPtr native__this, int bits)
		{
			global::Org.Jcodec.Codecs.Vpx.NopRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.NopRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Report (bits);
		}
#pragma warning restore 0169

		static IntPtr id_report_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='NopRateControl']/method[@name='report' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("report", "(I)V", "GetReport_IHandler")]
		public virtual unsafe void Report (int bits)
		{
			if (id_report_I == IntPtr.Zero)
				id_report_I = JNIEnv.GetMethodID (class_ref, "report", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bits);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_report_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "report", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Vpx.NopRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.NopRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='NopRateControl']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

	}
}
