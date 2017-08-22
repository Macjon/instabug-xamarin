using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vpx {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.codecs.vpx']/interface[@name='RateControl']"
	[Register ("org/jcodec/codecs/vpx/RateControl", "", "Org.Jcodec.Codecs.Vpx.IRateControlInvoker")]
	public partial interface IRateControl : IJavaObject {

		int Segment {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/interface[@name='RateControl']/method[@name='getSegment' and count(parameter)=0]"
			[Register ("getSegment", "()I", "GetGetSegmentHandler:Org.Jcodec.Codecs.Vpx.IRateControlInvoker, InstabugAndroidCoreSDK")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/interface[@name='RateControl']/method[@name='getSegmentQps' and count(parameter)=0]"
		[Register ("getSegmentQps", "()[I", "GetGetSegmentQpsHandler:Org.Jcodec.Codecs.Vpx.IRateControlInvoker, InstabugAndroidCoreSDK")]
		int[] GetSegmentQps ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/interface[@name='RateControl']/method[@name='report' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("report", "(I)V", "GetReport_IHandler:Org.Jcodec.Codecs.Vpx.IRateControlInvoker, InstabugAndroidCoreSDK")]
		void Report (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/interface[@name='RateControl']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Org.Jcodec.Codecs.Vpx.IRateControlInvoker, InstabugAndroidCoreSDK")]
		void Reset ();

	}

	[global::Android.Runtime.Register ("org/jcodec/codecs/vpx/RateControl", DoNotGenerateAcw=true)]
	internal class IRateControlInvoker : global::Java.Lang.Object, IRateControl {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/codecs/vpx/RateControl");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRateControlInvoker); }
		}

		IntPtr class_ref;

		public static IRateControl GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRateControl> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.codecs.vpx.RateControl"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRateControlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Jcodec.Codecs.Vpx.IRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.IRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Segment;
		}
#pragma warning restore 0169

		IntPtr id_getSegment;
		public unsafe int Segment {
			get {
				if (id_getSegment == IntPtr.Zero)
					id_getSegment = JNIEnv.GetMethodID (class_ref, "getSegment", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSegment);
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
			global::Org.Jcodec.Codecs.Vpx.IRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.IRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSegmentQps ());
		}
#pragma warning restore 0169

		IntPtr id_getSegmentQps;
		public unsafe int[] GetSegmentQps ()
		{
			if (id_getSegmentQps == IntPtr.Zero)
				id_getSegmentQps = JNIEnv.GetMethodID (class_ref, "getSegmentQps", "()[I");
			return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSegmentQps), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static Delegate cb_report_I;
#pragma warning disable 0169
		static Delegate GetReport_IHandler ()
		{
			if (cb_report_I == null)
				cb_report_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Report_I);
			return cb_report_I;
		}

		static void n_Report_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.Vpx.IRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.IRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Report (p0);
		}
#pragma warning restore 0169

		IntPtr id_report_I;
		public unsafe void Report (int p0)
		{
			if (id_report_I == IntPtr.Zero)
				id_report_I = JNIEnv.GetMethodID (class_ref, "report", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_report_I, __args);
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
			global::Org.Jcodec.Codecs.Vpx.IRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.IRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
		}

	}

}
