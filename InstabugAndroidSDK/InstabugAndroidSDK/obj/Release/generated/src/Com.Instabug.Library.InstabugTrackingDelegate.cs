using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugTrackingDelegate", DoNotGenerateAcw=true)]
	public sealed partial class InstabugTrackingDelegate : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugTrackingDelegate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugTrackingDelegate); }
		}

		internal InstabugTrackingDelegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/constructor[@name='InstabugTrackingDelegate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugTrackingDelegate ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InstabugTrackingDelegate)) {
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

		static IntPtr id_notifyActivityCreated_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyActivityCreated' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyActivityCreated", "(Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityCreated (global::Android.App.Activity p0)
		{
			if (id_notifyActivityCreated_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityCreated_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityCreated", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityCreated_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyActivityDestroyed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyActivityDestroyed", "(Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityDestroyed (global::Android.App.Activity p0)
		{
			if (id_notifyActivityDestroyed_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityDestroyed_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityDestroyed", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityDestroyed_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyActivityGotTouchEvent_Landroid_view_MotionEvent_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyActivityGotTouchEvent' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyActivityGotTouchEvent", "(Landroid/view/MotionEvent;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityGotTouchEvent (global::Android.Views.MotionEvent p0, global::Android.App.Activity p1)
		{
			if (id_notifyActivityGotTouchEvent_Landroid_view_MotionEvent_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityGotTouchEvent_Landroid_view_MotionEvent_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityGotTouchEvent", "(Landroid/view/MotionEvent;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityGotTouchEvent_Landroid_view_MotionEvent_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyActivityPaused_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyActivityPaused", "(Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityPaused (global::Android.App.Activity p0)
		{
			if (id_notifyActivityPaused_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityPaused_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityPaused", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityPaused_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyActivityResumed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyActivityResumed", "(Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityResumed (global::Android.App.Activity p0)
		{
			if (id_notifyActivityResumed_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityResumed_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityResumed", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityResumed_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyActivityStarted_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyActivityStarted", "(Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityStarted (global::Android.App.Activity p0)
		{
			if (id_notifyActivityStarted_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityStarted_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityStarted", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityStarted_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyActivityStopped_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyActivityStopped", "(Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityStopped (global::Android.App.Activity p0)
		{
			if (id_notifyActivityStopped_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityStopped_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityStopped", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityStopped_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyApplicationCreated_Landroid_app_Application_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyApplicationCreated' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("notifyApplicationCreated", "(Landroid/app/Application;)V", "")]
		public static unsafe void NotifyApplicationCreated (global::Android.App.Application p0)
		{
			if (id_notifyApplicationCreated_Landroid_app_Application_ == IntPtr.Zero)
				id_notifyApplicationCreated_Landroid_app_Application_ = JNIEnv.GetStaticMethodID (class_ref, "notifyApplicationCreated", "(Landroid/app/Application;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyApplicationCreated_Landroid_app_Application_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentAttached_Landroid_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentAttached' and count(parameter)=2 and parameter[1][@type='android.app.Fragment'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyFragmentAttached", "(Landroid/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentAttached (global::Android.App.Fragment p0, global::Android.App.Activity p1)
		{
			if (id_notifyFragmentAttached_Landroid_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentAttached_Landroid_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentAttached", "(Landroid/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentAttached_Landroid_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentAttached_Landroid_support_v4_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentAttached' and count(parameter)=2 and parameter[1][@type='android.support.v4.app.Fragment'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyFragmentAttached", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentAttached (global::Android.Support.V4.App.Fragment p0, global::Android.App.Activity p1)
		{
			if (id_notifyFragmentAttached_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentAttached_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentAttached", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentAttached_Landroid_support_v4_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentDetached_Landroid_app_Activity_Landroid_app_Fragment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentDetached' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.app.Fragment']]"
		[Register ("notifyFragmentDetached", "(Landroid/app/Activity;Landroid/app/Fragment;)V", "")]
		public static unsafe void NotifyFragmentDetached (global::Android.App.Activity p0, global::Android.App.Fragment p1)
		{
			if (id_notifyFragmentDetached_Landroid_app_Activity_Landroid_app_Fragment_ == IntPtr.Zero)
				id_notifyFragmentDetached_Landroid_app_Activity_Landroid_app_Fragment_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentDetached", "(Landroid/app/Activity;Landroid/app/Fragment;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentDetached_Landroid_app_Activity_Landroid_app_Fragment_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentDetached_Landroid_support_v4_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentDetached' and count(parameter)=2 and parameter[1][@type='android.support.v4.app.Fragment'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyFragmentDetached", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentDetached (global::Android.Support.V4.App.Fragment p0, global::Android.App.Activity p1)
		{
			if (id_notifyFragmentDetached_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentDetached_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentDetached", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentDetached_Landroid_support_v4_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentPaused_Landroid_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentPaused' and count(parameter)=2 and parameter[1][@type='android.app.Fragment'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyFragmentPaused", "(Landroid/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentPaused (global::Android.App.Fragment p0, global::Android.App.Activity p1)
		{
			if (id_notifyFragmentPaused_Landroid_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentPaused_Landroid_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentPaused", "(Landroid/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentPaused_Landroid_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentPaused_Landroid_support_v4_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentPaused' and count(parameter)=2 and parameter[1][@type='android.support.v4.app.Fragment'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyFragmentPaused", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentPaused (global::Android.Support.V4.App.Fragment p0, global::Android.App.Activity p1)
		{
			if (id_notifyFragmentPaused_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentPaused_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentPaused", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentPaused_Landroid_support_v4_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentResumed_Landroid_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentResumed' and count(parameter)=2 and parameter[1][@type='android.app.Fragment'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyFragmentResumed", "(Landroid/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentResumed (global::Android.App.Fragment p0, global::Android.App.Activity p1)
		{
			if (id_notifyFragmentResumed_Landroid_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentResumed_Landroid_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentResumed", "(Landroid/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentResumed_Landroid_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentResumed_Landroid_support_v4_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentResumed' and count(parameter)=2 and parameter[1][@type='android.support.v4.app.Fragment'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyFragmentResumed", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentResumed (global::Android.Support.V4.App.Fragment p0, global::Android.App.Activity p1)
		{
			if (id_notifyFragmentResumed_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentResumed_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentResumed", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentResumed_Landroid_support_v4_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentStarted_Landroid_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentStarted' and count(parameter)=2 and parameter[1][@type='android.app.Fragment'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyFragmentStarted", "(Landroid/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentStarted (global::Android.App.Fragment p0, global::Android.App.Activity p1)
		{
			if (id_notifyFragmentStarted_Landroid_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentStarted_Landroid_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentStarted", "(Landroid/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentStarted_Landroid_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentStarted_Landroid_support_v4_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentStarted' and count(parameter)=2 and parameter[1][@type='android.support.v4.app.Fragment'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyFragmentStarted", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentStarted (global::Android.Support.V4.App.Fragment p0, global::Android.App.Activity p1)
		{
			if (id_notifyFragmentStarted_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentStarted_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentStarted", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentStarted_Landroid_support_v4_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentStopped_Landroid_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentStopped' and count(parameter)=2 and parameter[1][@type='android.app.Fragment'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyFragmentStopped", "(Landroid/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentStopped (global::Android.App.Fragment p0, global::Android.App.Activity p1)
		{
			if (id_notifyFragmentStopped_Landroid_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentStopped_Landroid_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentStopped", "(Landroid/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentStopped_Landroid_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentStopped_Landroid_support_v4_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentStopped' and count(parameter)=2 and parameter[1][@type='android.support.v4.app.Fragment'] and parameter[2][@type='android.app.Activity']]"
		[Register ("notifyFragmentStopped", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentStopped (global::Android.Support.V4.App.Fragment p0, global::Android.App.Activity p1)
		{
			if (id_notifyFragmentStopped_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentStopped_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentStopped", "(Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentStopped_Landroid_support_v4_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentViewCreated_Landroid_view_View_Landroid_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentViewCreated' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.app.Fragment'] and parameter[3][@type='android.app.Activity']]"
		[Register ("notifyFragmentViewCreated", "(Landroid/view/View;Landroid/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentViewCreated (global::Android.Views.View p0, global::Android.App.Fragment p1, global::Android.App.Activity p2)
		{
			if (id_notifyFragmentViewCreated_Landroid_view_View_Landroid_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentViewCreated_Landroid_view_View_Landroid_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentViewCreated", "(Landroid/view/View;Landroid/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentViewCreated_Landroid_view_View_Landroid_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentViewCreated_Landroid_view_View_Landroid_support_v4_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentViewCreated' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.support.v4.app.Fragment'] and parameter[3][@type='android.app.Activity']]"
		[Register ("notifyFragmentViewCreated", "(Landroid/view/View;Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentViewCreated (global::Android.Views.View p0, global::Android.Support.V4.App.Fragment p1, global::Android.App.Activity p2)
		{
			if (id_notifyFragmentViewCreated_Landroid_view_View_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentViewCreated_Landroid_view_View_Landroid_support_v4_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentViewCreated", "(Landroid/view/View;Landroid/support/v4/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentViewCreated_Landroid_view_View_Landroid_support_v4_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentVisibilityChanged_ZLandroid_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentVisibilityChanged' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='android.app.Fragment'] and parameter[3][@type='android.app.Activity']]"
		[Register ("notifyFragmentVisibilityChanged", "(ZLandroid/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentVisibilityChanged (bool p0, global::Android.App.Fragment p1, global::Android.App.Activity p2)
		{
			if (id_notifyFragmentVisibilityChanged_ZLandroid_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentVisibilityChanged_ZLandroid_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentVisibilityChanged", "(ZLandroid/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentVisibilityChanged_ZLandroid_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyFragmentVisibilityChanged_ZLandroid_support_v4_app_Fragment_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTrackingDelegate']/method[@name='notifyFragmentVisibilityChanged' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='android.support.v4.app.Fragment'] and parameter[3][@type='android.app.Activity']]"
		[Register ("notifyFragmentVisibilityChanged", "(ZLandroid/support/v4/app/Fragment;Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyFragmentVisibilityChanged (bool p0, global::Android.Support.V4.App.Fragment p1, global::Android.App.Activity p2)
		{
			if (id_notifyFragmentVisibilityChanged_ZLandroid_support_v4_app_Fragment_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyFragmentVisibilityChanged_ZLandroid_support_v4_app_Fragment_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyFragmentVisibilityChanged", "(ZLandroid/support/v4/app/Fragment;Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyFragmentVisibilityChanged_ZLandroid_support_v4_app_Fragment_Landroid_app_Activity_, __args);
			} finally {
			}
		}

	}
}
