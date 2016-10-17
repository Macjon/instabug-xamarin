using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Common.Biari {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='Context']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/Context", DoNotGenerateAcw=true)]
	public partial class Context : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/Context", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Context); }
		}

		protected Context (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='Context']/constructor[@name='Context' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Context (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Context)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
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

		static Delegate cb_getMps;
#pragma warning disable 0169
		static Delegate GetGetMpsHandler ()
		{
			if (cb_getMps == null)
				cb_getMps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMps);
			return cb_getMps;
		}

		static int n_GetMps (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Common.Biari.Context __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mps;
		}
#pragma warning restore 0169

		static Delegate cb_setMps_I;
#pragma warning disable 0169
		static Delegate GetSetMps_IHandler ()
		{
			if (cb_setMps_I == null)
				cb_setMps_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMps_I);
			return cb_setMps_I;
		}

		static void n_SetMps_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.Common.Biari.Context __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mps = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMps;
		static IntPtr id_setMps_I;
		public virtual unsafe int Mps {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='Context']/method[@name='getMps' and count(parameter)=0]"
			[Register ("getMps", "()I", "GetGetMpsHandler")]
			get {
				if (id_getMps == IntPtr.Zero)
					id_getMps = JNIEnv.GetMethodID (class_ref, "getMps", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMps);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMps", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='Context']/method[@name='setMps' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMps", "(I)V", "GetSetMps_IHandler")]
			set {
				if (id_setMps_I == IntPtr.Zero)
					id_setMps_I = JNIEnv.GetMethodID (class_ref, "setMps", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMps_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMps", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetState);
			return cb_getState;
		}

		static int n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Common.Biari.Context __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.State;
		}
#pragma warning restore 0169

		static Delegate cb_setState_I;
#pragma warning disable 0169
		static Delegate GetSetState_IHandler ()
		{
			if (cb_setState_I == null)
				cb_setState_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetState_I);
			return cb_setState_I;
		}

		static void n_SetState_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.Common.Biari.Context __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.State = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		static IntPtr id_setState_I;
		public virtual unsafe int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='Context']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getState);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='Context']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setState", "(I)V", "GetSetState_IHandler")]
			set {
				if (id_setState_I == IntPtr.Zero)
					id_setState_I = JNIEnv.GetMethodID (class_ref, "setState", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setState_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setState", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
