using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RX.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='rx.android']/class[@name='MainThreadSubscription']"
	[global::Android.Runtime.Register ("rx/android/MainThreadSubscription", DoNotGenerateAcw=true)]
	public abstract partial class MainThreadSubscription : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("rx/android/MainThreadSubscription", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MainThreadSubscription); }
		}

		protected MainThreadSubscription (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='rx.android']/class[@name='MainThreadSubscription']/constructor[@name='MainThreadSubscription' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MainThreadSubscription ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MainThreadSubscription)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
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

		static IntPtr id_isUnsubscribed;
		public unsafe bool IsUnsubscribed {
			// Metadata.xml XPath method reference: path="/api/package[@name='rx.android']/class[@name='MainThreadSubscription']/method[@name='isUnsubscribed' and count(parameter)=0]"
			[Register ("isUnsubscribed", "()Z", "GetIsUnsubscribedHandler")]
			get {
				if (id_isUnsubscribed == IntPtr.Zero)
					id_isUnsubscribed = JNIEnv.GetMethodID (class_ref, "isUnsubscribed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUnsubscribed);
				} finally {
				}
			}
		}

		static Delegate cb_onUnsubscribe;
#pragma warning disable 0169
		static Delegate GetOnUnsubscribeHandler ()
		{
			if (cb_onUnsubscribe == null)
				cb_onUnsubscribe = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUnsubscribe);
			return cb_onUnsubscribe;
		}

		static void n_OnUnsubscribe (IntPtr jnienv, IntPtr native__this)
		{
			global::RX.Android.MainThreadSubscription __this = global::Java.Lang.Object.GetObject<global::RX.Android.MainThreadSubscription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnsubscribe ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='rx.android']/class[@name='MainThreadSubscription']/method[@name='onUnsubscribe' and count(parameter)=0]"
		[Register ("onUnsubscribe", "()V", "GetOnUnsubscribeHandler")]
		protected abstract void OnUnsubscribe ();

		static IntPtr id_unsubscribe;
		// Metadata.xml XPath method reference: path="/api/package[@name='rx.android']/class[@name='MainThreadSubscription']/method[@name='unsubscribe' and count(parameter)=0]"
		[Register ("unsubscribe", "()V", "")]
		public unsafe void Unsubscribe ()
		{
			if (id_unsubscribe == IntPtr.Zero)
				id_unsubscribe = JNIEnv.GetMethodID (class_ref, "unsubscribe", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe);
			} finally {
			}
		}

		static IntPtr id_verifyMainThread;
		// Metadata.xml XPath method reference: path="/api/package[@name='rx.android']/class[@name='MainThreadSubscription']/method[@name='verifyMainThread' and count(parameter)=0]"
		[Register ("verifyMainThread", "()V", "")]
		public static unsafe void VerifyMainThread ()
		{
			if (id_verifyMainThread == IntPtr.Zero)
				id_verifyMainThread = JNIEnv.GetStaticMethodID (class_ref, "verifyMainThread", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_verifyMainThread);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("rx/android/MainThreadSubscription", DoNotGenerateAcw=true)]
	internal partial class MainThreadSubscriptionInvoker : MainThreadSubscription {

		public MainThreadSubscriptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MainThreadSubscriptionInvoker); }
		}

		static IntPtr id_onUnsubscribe;
		// Metadata.xml XPath method reference: path="/api/package[@name='rx.android']/class[@name='MainThreadSubscription']/method[@name='onUnsubscribe' and count(parameter)=0]"
		[Register ("onUnsubscribe", "()V", "GetOnUnsubscribeHandler")]
		protected override unsafe void OnUnsubscribe ()
		{
			if (id_onUnsubscribe == IntPtr.Zero)
				id_onUnsubscribe = JNIEnv.GetMethodID (class_ref, "onUnsubscribe", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnsubscribe);
			} finally {
			}
		}

	}

}
