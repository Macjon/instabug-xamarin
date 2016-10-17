using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Encode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='H264FixedRateControl']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/encode/H264FixedRateControl", DoNotGenerateAcw=true)]
	public partial class H264FixedRateControl : global::Java.Lang.Object, global::Org.Jcodec.Codecs.H264.Encode.IRateControl {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/encode/H264FixedRateControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (H264FixedRateControl); }
		}

		protected H264FixedRateControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='H264FixedRateControl']/constructor[@name='H264FixedRateControl' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe H264FixedRateControl (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (H264FixedRateControl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
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
			global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitQp;
		}
#pragma warning restore 0169

		static IntPtr id_getInitQp;
		public virtual unsafe int InitQp {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='H264FixedRateControl']/method[@name='getInitQp' and count(parameter)=0]"
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
			global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.QpDelta;
		}
#pragma warning restore 0169

		static IntPtr id_getQpDelta;
		public virtual unsafe int QpDelta {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='H264FixedRateControl']/method[@name='getQpDelta' and count(parameter)=0]"
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
			global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Accept (p0);
		}
#pragma warning restore 0169

		static IntPtr id_accept_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='H264FixedRateControl']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_calcFrameSize_I;
#pragma warning disable 0169
		static Delegate GetCalcFrameSize_IHandler ()
		{
			if (cb_calcFrameSize_I == null)
				cb_calcFrameSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_CalcFrameSize_I);
			return cb_calcFrameSize_I;
		}

		static int n_CalcFrameSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalcFrameSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_calcFrameSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='H264FixedRateControl']/method[@name='calcFrameSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("calcFrameSize", "(I)I", "GetCalcFrameSize_IHandler")]
		public virtual unsafe int CalcFrameSize (int p0)
		{
			if (id_calcFrameSize_I == IntPtr.Zero)
				id_calcFrameSize_I = JNIEnv.GetMethodID (class_ref, "calcFrameSize", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcFrameSize_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calcFrameSize", "(I)I"), __args);
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
			global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='H264FixedRateControl']/method[@name='reset' and count(parameter)=0]"
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

		static Delegate cb_setRate_I;
#pragma warning disable 0169
		static Delegate GetSetRate_IHandler ()
		{
			if (cb_setRate_I == null)
				cb_setRate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRate_I);
			return cb_setRate_I;
		}

		static void n_SetRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Encode.H264FixedRateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.encode']/class[@name='H264FixedRateControl']/method[@name='setRate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRate", "(I)V", "GetSetRate_IHandler")]
		public virtual unsafe void SetRate (int p0)
		{
			if (id_setRate_I == IntPtr.Zero)
				id_setRate_I = JNIEnv.GetMethodID (class_ref, "setRate", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRate_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRate", "(I)V"), __args);
			} finally {
			}
		}

	}
}
