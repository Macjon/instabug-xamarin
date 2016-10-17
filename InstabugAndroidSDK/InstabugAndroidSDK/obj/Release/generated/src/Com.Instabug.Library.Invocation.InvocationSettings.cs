using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Invocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationSettings']"
	[global::Android.Runtime.Register ("com/instabug/library/invocation/InvocationSettings", DoNotGenerateAcw=true)]
	public partial class InvocationSettings : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationSettings']/field[@name='SHAKE_DEFAULT_THRESHOLD']"
		[Register ("SHAKE_DEFAULT_THRESHOLD")]
		public const int ShakeDefaultThreshold = (int) 350;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/invocation/InvocationSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InvocationSettings); }
		}

		protected InvocationSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationSettings']/constructor[@name='InvocationSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InvocationSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InvocationSettings)) {
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

		static Delegate cb_setFloatingButtonOffsetFromTop_I;
#pragma warning disable 0169
		static Delegate GetSetFloatingButtonOffsetFromTop_IHandler ()
		{
			if (cb_setFloatingButtonOffsetFromTop_I == null)
				cb_setFloatingButtonOffsetFromTop_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFloatingButtonOffsetFromTop_I);
			return cb_setFloatingButtonOffsetFromTop_I;
		}

		static void n_SetFloatingButtonOffsetFromTop_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Instabug.Library.Invocation.InvocationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFloatingButtonOffsetFromTop (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFloatingButtonOffsetFromTop_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationSettings']/method[@name='setFloatingButtonOffsetFromTop' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFloatingButtonOffsetFromTop", "(I)V", "GetSetFloatingButtonOffsetFromTop_IHandler")]
		public virtual unsafe void SetFloatingButtonOffsetFromTop (int p0)
		{
			if (id_setFloatingButtonOffsetFromTop_I == IntPtr.Zero)
				id_setFloatingButtonOffsetFromTop_I = JNIEnv.GetMethodID (class_ref, "setFloatingButtonOffsetFromTop", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFloatingButtonOffsetFromTop_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatingButtonOffsetFromTop", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShakingThreshold_I;
#pragma warning disable 0169
		static Delegate GetSetShakingThreshold_IHandler ()
		{
			if (cb_setShakingThreshold_I == null)
				cb_setShakingThreshold_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShakingThreshold_I);
			return cb_setShakingThreshold_I;
		}

		static void n_SetShakingThreshold_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Instabug.Library.Invocation.InvocationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShakingThreshold (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShakingThreshold_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationSettings']/method[@name='setShakingThreshold' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShakingThreshold", "(I)V", "GetSetShakingThreshold_IHandler")]
		public virtual unsafe void SetShakingThreshold (int p0)
		{
			if (id_setShakingThreshold_I == IntPtr.Zero)
				id_setShakingThreshold_I = JNIEnv.GetMethodID (class_ref, "setShakingThreshold", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShakingThreshold_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShakingThreshold", "(I)V"), __args);
			} finally {
			}
		}

	}
}
