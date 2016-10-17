using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugBaseFragment", DoNotGenerateAcw=true)]
	public abstract partial class InstabugBaseFragment : global::Android.Support.V4.App.Fragment {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugBaseFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugBaseFragment); }
		}

		protected InstabugBaseFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/constructor[@name='InstabugBaseFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugBaseFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InstabugBaseFragment)) {
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

		static Delegate cb_isStateRestored;
#pragma warning disable 0169
		static Delegate GetIsStateRestoredHandler ()
		{
			if (cb_isStateRestored == null)
				cb_isStateRestored = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStateRestored);
			return cb_isStateRestored;
		}

		static bool n_IsStateRestored (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugBaseFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStateRestored;
		}
#pragma warning restore 0169

		static IntPtr id_isStateRestored;
		public virtual unsafe bool IsStateRestored {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='isStateRestored' and count(parameter)=0]"
			[Register ("isStateRestored", "()Z", "GetIsStateRestoredHandler")]
			get {
				if (id_isStateRestored == IntPtr.Zero)
					id_isStateRestored = JNIEnv.GetMethodID (class_ref, "isStateRestored", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStateRestored);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStateRestored", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLayout;
#pragma warning disable 0169
		static Delegate GetGetLayoutHandler ()
		{
			if (cb_getLayout == null)
				cb_getLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLayout);
			return cb_getLayout;
		}

		static int n_GetLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugBaseFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Layout;
		}
#pragma warning restore 0169

		protected abstract int Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='getLayout' and count(parameter)=0]"
			[Register ("getLayout", "()I", "GetGetLayoutHandler")] get;
		}

		static Delegate cb_getPreservedActivity;
#pragma warning disable 0169
		static Delegate GetGetPreservedActivityHandler ()
		{
			if (cb_getPreservedActivity == null)
				cb_getPreservedActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreservedActivity);
			return cb_getPreservedActivity;
		}

		static IntPtr n_GetPreservedActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugBaseFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreservedActivity);
		}
#pragma warning restore 0169

		static IntPtr id_getPreservedActivity;
		public virtual unsafe global::Android.App.Activity PreservedActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='getPreservedActivity' and count(parameter)=0]"
			[Register ("getPreservedActivity", "()Landroid/app/Activity;", "GetGetPreservedActivityHandler")]
			get {
				if (id_getPreservedActivity == IntPtr.Zero)
					id_getPreservedActivity = JNIEnv.GetMethodID (class_ref, "getPreservedActivity", "()Landroid/app/Activity;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreservedActivity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreservedActivity", "()Landroid/app/Activity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugBaseFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		protected abstract string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")] get;
		}

		static Delegate cb_consumeNewInstanceSavedArguments;
#pragma warning disable 0169
		static Delegate GetConsumeNewInstanceSavedArgumentsHandler ()
		{
			if (cb_consumeNewInstanceSavedArguments == null)
				cb_consumeNewInstanceSavedArguments = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConsumeNewInstanceSavedArguments);
			return cb_consumeNewInstanceSavedArguments;
		}

		static void n_ConsumeNewInstanceSavedArguments (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugBaseFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeNewInstanceSavedArguments ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='consumeNewInstanceSavedArguments' and count(parameter)=0]"
		[Register ("consumeNewInstanceSavedArguments", "()V", "GetConsumeNewInstanceSavedArgumentsHandler")]
		protected abstract void ConsumeNewInstanceSavedArguments ();

		static Delegate cb_restoreState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRestoreState_Landroid_os_Bundle_Handler ()
		{
			if (cb_restoreState_Landroid_os_Bundle_ == null)
				cb_restoreState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RestoreState_Landroid_os_Bundle_);
			return cb_restoreState_Landroid_os_Bundle_;
		}

		static void n_RestoreState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugBaseFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RestoreState (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='restoreState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("restoreState", "(Landroid/os/Bundle;)V", "GetRestoreState_Landroid_os_Bundle_Handler")]
		protected abstract void RestoreState (global::Android.OS.Bundle p0);

		static Delegate cb_saveState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSaveState_Landroid_os_Bundle_Handler ()
		{
			if (cb_saveState_Landroid_os_Bundle_ == null)
				cb_saveState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveState_Landroid_os_Bundle_);
			return cb_saveState_Landroid_os_Bundle_;
		}

		static void n_SaveState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugBaseFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveState (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='saveState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("saveState", "(Landroid/os/Bundle;)V", "GetSaveState_Landroid_os_Bundle_Handler")]
		protected abstract void SaveState (global::Android.OS.Bundle p0);

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugBaseFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTitle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTitle (string p0)
		{
			if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
				id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitle_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/instabug/library/InstabugBaseFragment", DoNotGenerateAcw=true)]
	internal partial class InstabugBaseFragmentInvoker : InstabugBaseFragment {

		public InstabugBaseFragmentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugBaseFragmentInvoker); }
		}

		static IntPtr id_getLayout;
		protected override unsafe int Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='getLayout' and count(parameter)=0]"
			[Register ("getLayout", "()I", "GetGetLayoutHandler")]
			get {
				if (id_getLayout == IntPtr.Zero)
					id_getLayout = JNIEnv.GetMethodID (class_ref, "getLayout", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLayout);
				} finally {
				}
			}
		}

		static IntPtr id_getTitle;
		protected override unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_consumeNewInstanceSavedArguments;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='consumeNewInstanceSavedArguments' and count(parameter)=0]"
		[Register ("consumeNewInstanceSavedArguments", "()V", "GetConsumeNewInstanceSavedArgumentsHandler")]
		protected override unsafe void ConsumeNewInstanceSavedArguments ()
		{
			if (id_consumeNewInstanceSavedArguments == IntPtr.Zero)
				id_consumeNewInstanceSavedArguments = JNIEnv.GetMethodID (class_ref, "consumeNewInstanceSavedArguments", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_consumeNewInstanceSavedArguments);
			} finally {
			}
		}

		static IntPtr id_restoreState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='restoreState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("restoreState", "(Landroid/os/Bundle;)V", "GetRestoreState_Landroid_os_Bundle_Handler")]
		protected override unsafe void RestoreState (global::Android.OS.Bundle p0)
		{
			if (id_restoreState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_restoreState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "restoreState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_restoreState_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_saveState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseFragment']/method[@name='saveState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("saveState", "(Landroid/os/Bundle;)V", "GetSaveState_Landroid_os_Bundle_Handler")]
		protected override unsafe void SaveState (global::Android.OS.Bundle p0)
		{
			if (id_saveState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_saveState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "saveState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveState_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

	}

}
