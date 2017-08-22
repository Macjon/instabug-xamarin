using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Encode {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/interface[@name='RateControl']"
	[Register ("org/jcodec/codecs/h264/encode/RateControl", "", "Org.Jcodec.Codecs.H264.Encode.IRateControlInvoker")]
	public partial interface IRateControl : IJavaObject {

		int InitQp {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/interface[@name='RateControl']/method[@name='getInitQp' and count(parameter)=0]"
			[Register ("getInitQp", "()I", "GetGetInitQpHandler:Org.Jcodec.Codecs.H264.Encode.IRateControlInvoker, InstabugAndroidCoreSDK")] get;
		}

		int QpDelta {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/interface[@name='RateControl']/method[@name='getQpDelta' and count(parameter)=0]"
			[Register ("getQpDelta", "()I", "GetGetQpDeltaHandler:Org.Jcodec.Codecs.H264.Encode.IRateControlInvoker, InstabugAndroidCoreSDK")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/interface[@name='RateControl']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("accept", "(I)Z", "GetAccept_IHandler:Org.Jcodec.Codecs.H264.Encode.IRateControlInvoker, InstabugAndroidCoreSDK")]
		bool Accept (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/interface[@name='RateControl']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Org.Jcodec.Codecs.H264.Encode.IRateControlInvoker, InstabugAndroidCoreSDK")]
		void Reset ();

	}

	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/encode/RateControl", DoNotGenerateAcw=true)]
	internal class IRateControlInvoker : global::Java.Lang.Object, IRateControl {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/codecs/h264/encode/RateControl");

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
							JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.codecs.h264.encode.RateControl"));
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

		static Delegate cb_getInitQp;
#pragma warning disable 0169
		static Delegate GetGetInitQpHandler ()
		{
			if (cb_getInitQp == null)
				cb_getInitQp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInitQp);
			return cb_getInitQp;
		}

		static int n_GetInitQp (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.H264.Encode.IRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.IRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitQp;
		}
#pragma warning restore 0169

		IntPtr id_getInitQp;
		public unsafe int InitQp {
			get {
				if (id_getInitQp == IntPtr.Zero)
					id_getInitQp = JNIEnv.GetMethodID (class_ref, "getInitQp", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInitQp);
			}
		}

		static Delegate cb_getQpDelta;
#pragma warning disable 0169
		static Delegate GetGetQpDeltaHandler ()
		{
			if (cb_getQpDelta == null)
				cb_getQpDelta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetQpDelta);
			return cb_getQpDelta;
		}

		static int n_GetQpDelta (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.H264.Encode.IRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.IRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.QpDelta;
		}
#pragma warning restore 0169

		IntPtr id_getQpDelta;
		public unsafe int QpDelta {
			get {
				if (id_getQpDelta == IntPtr.Zero)
					id_getQpDelta = JNIEnv.GetMethodID (class_ref, "getQpDelta", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getQpDelta);
			}
		}

		static Delegate cb_accept_I;
#pragma warning disable 0169
		static Delegate GetAccept_IHandler ()
		{
			if (cb_accept_I == null)
				cb_accept_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Accept_I);
			return cb_accept_I;
		}

		static bool n_Accept_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.H264.Encode.IRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.IRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Accept (p0);
		}
#pragma warning restore 0169

		IntPtr id_accept_I;
		public unsafe bool Accept (int p0)
		{
			if (id_accept_I == IntPtr.Zero)
				id_accept_I = JNIEnv.GetMethodID (class_ref, "accept", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_accept_I, __args);
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
			global::Org.Jcodec.Codecs.H264.Encode.IRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.IRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
