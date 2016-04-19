using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugActivityDelegate']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugActivityDelegate", DoNotGenerateAcw=true)]
	public partial class InstabugActivityDelegate : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugActivityDelegate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugActivityDelegate); }
		}

		protected InstabugActivityDelegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugActivityDelegate']/constructor[@name='InstabugActivityDelegate' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe InstabugActivityDelegate (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (InstabugActivityDelegate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static Delegate cb_dispatchTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_dispatchTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_dispatchTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchTouchEvent_Landroid_view_MotionEvent_);
			return cb_dispatchTouchEvent_Landroid_view_MotionEvent_;
		}

		static void n_DispatchTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugActivityDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchTouchEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugActivityDelegate']/method[@name='dispatchTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("dispatchTouchEvent", "(Landroid/view/MotionEvent;)V", "GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void DispatchTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_dispatchTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_dispatchTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dispatchTouchEvent_Landroid_view_MotionEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugActivityDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugActivityDelegate']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInstabugGestureEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnInstabugGestureEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onInstabugGestureEvent_Landroid_view_MotionEvent_ == null)
				cb_onInstabugGestureEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInstabugGestureEvent_Landroid_view_MotionEvent_);
			return cb_onInstabugGestureEvent_Landroid_view_MotionEvent_;
		}

		static void n_OnInstabugGestureEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugActivityDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInstabugGestureEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onInstabugGestureEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugActivityDelegate']/method[@name='onInstabugGestureEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onInstabugGestureEvent", "(Landroid/view/MotionEvent;)V", "GetOnInstabugGestureEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void OnInstabugGestureEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onInstabugGestureEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onInstabugGestureEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onInstabugGestureEvent", "(Landroid/view/MotionEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInstabugGestureEvent_Landroid_view_MotionEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInstabugGestureEvent", "(Landroid/view/MotionEvent;)V"), __args);
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
			global::Com.Instabug.Library.InstabugActivityDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugActivityDelegate']/method[@name='onPause' and count(parameter)=0]"
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
			global::Com.Instabug.Library.InstabugActivityDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugActivityDelegate']/method[@name='onResume' and count(parameter)=0]"
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

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugActivityDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugActivityDelegate']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStart);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugActivityDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugActivityDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugActivityDelegate']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStop", "()V"));
			} finally {
			}
		}

	}
}
