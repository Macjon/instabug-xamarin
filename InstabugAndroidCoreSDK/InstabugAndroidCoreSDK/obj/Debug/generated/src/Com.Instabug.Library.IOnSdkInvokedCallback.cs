using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library']/interface[@name='OnSdkInvokedCallback']"
	[Register ("com/instabug/library/OnSdkInvokedCallback", "", "Com.Instabug.Library.IOnSdkInvokedCallbackInvoker")]
	public partial interface IOnSdkInvokedCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='OnSdkInvokedCallback']/method[@name='onSdkInvoked' and count(parameter)=0]"
		[Register ("onSdkInvoked", "()V", "GetOnSdkInvokedHandler:Com.Instabug.Library.IOnSdkInvokedCallbackInvoker, InstabugAndroidCoreSDK")]
		void OnSdkInvoked ();

	}

	[global::Android.Runtime.Register ("com/instabug/library/OnSdkInvokedCallback", DoNotGenerateAcw=true)]
	internal class IOnSdkInvokedCallbackInvoker : global::Java.Lang.Object, IOnSdkInvokedCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/OnSdkInvokedCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnSdkInvokedCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IOnSdkInvokedCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSdkInvokedCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library.OnSdkInvokedCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSdkInvokedCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSdkInvoked;
#pragma warning disable 0169
		static Delegate GetOnSdkInvokedHandler ()
		{
			if (cb_onSdkInvoked == null)
				cb_onSdkInvoked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSdkInvoked);
			return cb_onSdkInvoked;
		}

		static void n_OnSdkInvoked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.IOnSdkInvokedCallback __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IOnSdkInvokedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSdkInvoked ();
		}
#pragma warning restore 0169

		IntPtr id_onSdkInvoked;
		public unsafe void OnSdkInvoked ()
		{
			if (id_onSdkInvoked == IntPtr.Zero)
				id_onSdkInvoked = JNIEnv.GetMethodID (class_ref, "onSdkInvoked", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSdkInvoked);
		}

	}

}
