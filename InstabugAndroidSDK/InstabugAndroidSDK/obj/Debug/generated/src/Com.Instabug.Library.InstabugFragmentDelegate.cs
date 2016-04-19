using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFragmentDelegate']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugFragmentDelegate", DoNotGenerateAcw=true)]
	public partial class InstabugFragmentDelegate : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugFragmentDelegate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugFragmentDelegate); }
		}

		protected InstabugFragmentDelegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Fragment_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFragmentDelegate']/constructor[@name='InstabugFragmentDelegate' and count(parameter)=1 and parameter[1][@type='android.app.Fragment']]"
		[Register (".ctor", "(Landroid/app/Fragment;)V", "")]
		public unsafe InstabugFragmentDelegate (global::Android.App.Fragment p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (InstabugFragmentDelegate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Fragment;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Fragment;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Fragment_ == IntPtr.Zero)
					id_ctor_Landroid_app_Fragment_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Fragment;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Fragment_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Fragment_, __args);
			} finally {
			}
		}

		static Delegate cb_onDetach;
#pragma warning disable 0169
		static Delegate GetOnDetachHandler ()
		{
			if (cb_onDetach == null)
				cb_onDetach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDetach);
			return cb_onDetach;
		}

		static void n_OnDetach (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDetach ();
		}
#pragma warning restore 0169

		static IntPtr id_onDetach;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFragmentDelegate']/method[@name='onDetach' and count(parameter)=0]"
		[Register ("onDetach", "()V", "GetOnDetachHandler")]
		public virtual unsafe void OnDetach ()
		{
			if (id_onDetach == IntPtr.Zero)
				id_onDetach = JNIEnv.GetMethodID (class_ref, "onDetach", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDetach);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDetach", "()V"));
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFragmentDelegate']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPause);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPause", "()V"));
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFragmentDelegate']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResume);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "()V"));
			} finally {
			}
		}

	}
}
