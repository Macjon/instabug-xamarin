using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Invocation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library.invocation']/interface[@name='InvocationTrigger']"
	[Register ("com/instabug/library/invocation/InvocationTrigger", "", "Com.Instabug.Library.Invocation.IInvocationTriggerInvoker")]
	public partial interface IInvocationTrigger : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/interface[@name='InvocationTrigger']/method[@name='onInvocationDismissed' and count(parameter)=0]"
		[Register ("onInvocationDismissed", "()V", "GetOnInvocationDismissedHandler:Com.Instabug.Library.Invocation.IInvocationTriggerInvoker, InstabugAndroidSDK")]
		void OnInvocationDismissed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/interface[@name='InvocationTrigger']/method[@name='onInvocationTriggered' and count(parameter)=1 and parameter[1][@type='android.net.Uri...']]"
		[Register ("onInvocationTriggered", "([Landroid/net/Uri;)V", "GetOnInvocationTriggered_arrayLandroid_net_Uri_Handler:Com.Instabug.Library.Invocation.IInvocationTriggerInvoker, InstabugAndroidSDK")]
		void OnInvocationTriggered (params global:: Android.Net.Uri[] p0);

	}

	[global::Android.Runtime.Register ("com/instabug/library/invocation/InvocationTrigger", DoNotGenerateAcw=true)]
	internal class IInvocationTriggerInvoker : global::Java.Lang.Object, IInvocationTrigger {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/invocation/InvocationTrigger");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInvocationTriggerInvoker); }
		}

		IntPtr class_ref;

		public static IInvocationTrigger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInvocationTrigger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library.invocation.InvocationTrigger"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInvocationTriggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInvocationDismissed;
#pragma warning disable 0169
		static Delegate GetOnInvocationDismissedHandler ()
		{
			if (cb_onInvocationDismissed == null)
				cb_onInvocationDismissed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInvocationDismissed);
			return cb_onInvocationDismissed;
		}

		static void n_OnInvocationDismissed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Invocation.IInvocationTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.IInvocationTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInvocationDismissed ();
		}
#pragma warning restore 0169

		IntPtr id_onInvocationDismissed;
		public unsafe void OnInvocationDismissed ()
		{
			if (id_onInvocationDismissed == IntPtr.Zero)
				id_onInvocationDismissed = JNIEnv.GetMethodID (class_ref, "onInvocationDismissed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInvocationDismissed);
		}

		static Delegate cb_onInvocationTriggered_arrayLandroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetOnInvocationTriggered_arrayLandroid_net_Uri_Handler ()
		{
			if (cb_onInvocationTriggered_arrayLandroid_net_Uri_ == null)
				cb_onInvocationTriggered_arrayLandroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInvocationTriggered_arrayLandroid_net_Uri_);
			return cb_onInvocationTriggered_arrayLandroid_net_Uri_;
		}

		static void n_OnInvocationTriggered_arrayLandroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Invocation.IInvocationTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.IInvocationTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri[] p0 = (global::Android.Net.Uri[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Net.Uri));
			__this.OnInvocationTriggered (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onInvocationTriggered_arrayLandroid_net_Uri_;
		public unsafe void OnInvocationTriggered (params global:: Android.Net.Uri[] p0)
		{
			if (id_onInvocationTriggered_arrayLandroid_net_Uri_ == IntPtr.Zero)
				id_onInvocationTriggered_arrayLandroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "onInvocationTriggered", "([Landroid/net/Uri;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInvocationTriggered_arrayLandroid_net_Uri_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
