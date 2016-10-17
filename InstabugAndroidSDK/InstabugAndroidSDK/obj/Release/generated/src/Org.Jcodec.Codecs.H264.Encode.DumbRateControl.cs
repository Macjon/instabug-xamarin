using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Encode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='DumbRateControl']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/encode/DumbRateControl", DoNotGenerateAcw=true)]
	public partial class DumbRateControl : global::Java.Lang.Object, global::Org.Jcodec.Codecs.H264.Encode.IRateControl {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/encode/DumbRateControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DumbRateControl); }
		}

		protected DumbRateControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='DumbRateControl']/constructor[@name='DumbRateControl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DumbRateControl ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DumbRateControl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
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
			global::Org.Jcodec.Codecs.H264.Encode.DumbRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.DumbRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitQp;
		}
#pragma warning restore 0169

		static IntPtr id_getInitQp;
		public virtual unsafe int InitQp {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='DumbRateControl']/method[@name='getInitQp' and count(parameter)=0]"
			[Register ("getInitQp", "()I", "GetGetInitQpHandler")]
			get {
				if (id_getInitQp == IntPtr.Zero)
					id_getInitQp = JNIEnv.GetMethodID (class_ref, "getInitQp", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInitQp);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitQp", "()I"));
				} finally {
				}
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
			global::Org.Jcodec.Codecs.H264.Encode.DumbRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.DumbRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.QpDelta;
		}
#pragma warning restore 0169

		static IntPtr id_getQpDelta;
		public virtual unsafe int QpDelta {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='DumbRateControl']/method[@name='getQpDelta' and count(parameter)=0]"
			[Register ("getQpDelta", "()I", "GetGetQpDeltaHandler")]
			get {
				if (id_getQpDelta == IntPtr.Zero)
					id_getQpDelta = JNIEnv.GetMethodID (class_ref, "getQpDelta", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getQpDelta);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQpDelta", "()I"));
				} finally {
				}
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
			global::Org.Jcodec.Codecs.H264.Encode.DumbRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.DumbRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Accept (p0);
		}
#pragma warning restore 0169

		static IntPtr id_accept_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='DumbRateControl']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("accept", "(I)Z", "GetAccept_IHandler")]
		public virtual unsafe bool Accept (int p0)
		{
			if (id_accept_I == IntPtr.Zero)
				id_accept_I = JNIEnv.GetMethodID (class_ref, "accept", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_accept_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accept", "(I)Z"), __args);
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
			global::Org.Jcodec.Codecs.H264.Encode.DumbRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.DumbRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='DumbRateControl']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

	}
}
