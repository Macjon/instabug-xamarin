using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugSuccessFragment']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugSuccessFragment", DoNotGenerateAcw=true)]
	public partial class InstabugSuccessFragment : global::Com.Instabug.Library.InstabugBaseFragment, global::Android.Views.View.IOnClickListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugSuccessFragment.Callbacks']"
		[Register ("com/instabug/library/InstabugSuccessFragment$Callbacks", "", "Com.Instabug.Library.InstabugSuccessFragment/ICallbacksInvoker")]
		public partial interface ICallbacks : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugSuccessFragment.Callbacks']/method[@name='onSuccessDismissed' and count(parameter)=0]"
			[Register ("onSuccessDismissed", "()V", "GetOnSuccessDismissedHandler:Com.Instabug.Library.InstabugSuccessFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void OnSuccessDismissed ();

		}

		[global::Android.Runtime.Register ("com/instabug/library/InstabugSuccessFragment$Callbacks", DoNotGenerateAcw=true)]
		internal class ICallbacksInvoker : global::Java.Lang.Object, ICallbacks {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/InstabugSuccessFragment$Callbacks");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICallbacksInvoker); }
			}

			IntPtr class_ref;

			public static ICallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallbacks> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library.InstabugSuccessFragment.Callbacks"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSuccessDismissed;
#pragma warning disable 0169
			static Delegate GetOnSuccessDismissedHandler ()
			{
				if (cb_onSuccessDismissed == null)
					cb_onSuccessDismissed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccessDismissed);
				return cb_onSuccessDismissed;
			}

			static void n_OnSuccessDismissed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugSuccessFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugSuccessFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccessDismissed ();
			}
#pragma warning restore 0169

			IntPtr id_onSuccessDismissed;
			public unsafe void OnSuccessDismissed ()
			{
				if (id_onSuccessDismissed == IntPtr.Zero)
					id_onSuccessDismissed = JNIEnv.GetMethodID (class_ref, "onSuccessDismissed", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccessDismissed);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugSuccessFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugSuccessFragment); }
		}

		protected InstabugSuccessFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugSuccessFragment']/constructor[@name='InstabugSuccessFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugSuccessFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InstabugSuccessFragment)) {
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
			global::Com.Instabug.Library.InstabugSuccessFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugSuccessFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Layout;
		}
#pragma warning restore 0169

		static IntPtr id_getLayout;
		protected override unsafe int Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugSuccessFragment']/method[@name='getLayout' and count(parameter)=0]"
			[Register ("getLayout", "()I", "GetGetLayoutHandler")]
			get {
				if (id_getLayout == IntPtr.Zero)
					id_getLayout = JNIEnv.GetMethodID (class_ref, "getLayout", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLayout);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayout", "()I"));
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
			global::Com.Instabug.Library.InstabugSuccessFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugSuccessFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		protected override unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugSuccessFragment']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			global::Com.Instabug.Library.InstabugSuccessFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugSuccessFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeNewInstanceSavedArguments ();
		}
#pragma warning restore 0169

		static IntPtr id_consumeNewInstanceSavedArguments;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugSuccessFragment']/method[@name='consumeNewInstanceSavedArguments' and count(parameter)=0]"
		[Register ("consumeNewInstanceSavedArguments", "()V", "GetConsumeNewInstanceSavedArgumentsHandler")]
		protected override unsafe void ConsumeNewInstanceSavedArguments ()
		{
			if (id_consumeNewInstanceSavedArguments == IntPtr.Zero)
				id_consumeNewInstanceSavedArguments = JNIEnv.GetMethodID (class_ref, "consumeNewInstanceSavedArguments", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_consumeNewInstanceSavedArguments);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "consumeNewInstanceSavedArguments", "()V"));
			} finally {
			}
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugSuccessFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugSuccessFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugSuccessFragment']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnClick (global::Android.Views.View p0)
		{
			if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
				id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Instabug.Library.InstabugSuccessFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugSuccessFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RestoreState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_restoreState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugSuccessFragment']/method[@name='restoreState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("restoreState", "(Landroid/os/Bundle;)V", "GetRestoreState_Landroid_os_Bundle_Handler")]
		protected override unsafe void RestoreState (global::Android.OS.Bundle p0)
		{
			if (id_restoreState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_restoreState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "restoreState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_restoreState_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restoreState", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Instabug.Library.InstabugSuccessFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugSuccessFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugSuccessFragment']/method[@name='saveState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("saveState", "(Landroid/os/Bundle;)V", "GetSaveState_Landroid_os_Bundle_Handler")]
		protected override unsafe void SaveState (global::Android.OS.Bundle p0)
		{
			if (id_saveState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_saveState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "saveState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveState_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveState", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

	}
}
