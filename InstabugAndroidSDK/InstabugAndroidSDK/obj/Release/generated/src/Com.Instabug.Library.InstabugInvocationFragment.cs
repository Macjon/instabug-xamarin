using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInvocationFragment']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugInvocationFragment", DoNotGenerateAcw=true)]
	public partial class InstabugInvocationFragment : global::Com.Instabug.Library.InstabugBaseFragment, global::Android.Views.View.IOnClickListener, global::Com.Instabug.Library.IFragmentVisibilityChangedListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugInvocationFragment.Callbacks']"
		[Register ("com/instabug/library/InstabugInvocationFragment$Callbacks", "", "Com.Instabug.Library.InstabugInvocationFragment/ICallbacksInvoker")]
		public partial interface ICallbacks : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugInvocationFragment.Callbacks']/method[@name='startBugReporter' and count(parameter)=0]"
			[Register ("startBugReporter", "()V", "GetStartBugReporterHandler:Com.Instabug.Library.InstabugInvocationFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void StartBugReporter ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugInvocationFragment.Callbacks']/method[@name='startChats' and count(parameter)=0]"
			[Register ("startChats", "()V", "GetStartChatsHandler:Com.Instabug.Library.InstabugInvocationFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void StartChats ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugInvocationFragment.Callbacks']/method[@name='startFeedbackSender' and count(parameter)=0]"
			[Register ("startFeedbackSender", "()V", "GetStartFeedbackSenderHandler:Com.Instabug.Library.InstabugInvocationFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void StartFeedbackSender ();

		}

		[global::Android.Runtime.Register ("com/instabug/library/InstabugInvocationFragment$Callbacks", DoNotGenerateAcw=true)]
		internal class ICallbacksInvoker : global::Java.Lang.Object, ICallbacks {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/InstabugInvocationFragment$Callbacks");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library.InstabugInvocationFragment.Callbacks"));
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

			static Delegate cb_startBugReporter;
#pragma warning disable 0169
			static Delegate GetStartBugReporterHandler ()
			{
				if (cb_startBugReporter == null)
					cb_startBugReporter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartBugReporter);
				return cb_startBugReporter;
			}

			static void n_StartBugReporter (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugInvocationFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugInvocationFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.StartBugReporter ();
			}
#pragma warning restore 0169

			IntPtr id_startBugReporter;
			public unsafe void StartBugReporter ()
			{
				if (id_startBugReporter == IntPtr.Zero)
					id_startBugReporter = JNIEnv.GetMethodID (class_ref, "startBugReporter", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startBugReporter);
			}

			static Delegate cb_startChats;
#pragma warning disable 0169
			static Delegate GetStartChatsHandler ()
			{
				if (cb_startChats == null)
					cb_startChats = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartChats);
				return cb_startChats;
			}

			static void n_StartChats (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugInvocationFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugInvocationFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.StartChats ();
			}
#pragma warning restore 0169

			IntPtr id_startChats;
			public unsafe void StartChats ()
			{
				if (id_startChats == IntPtr.Zero)
					id_startChats = JNIEnv.GetMethodID (class_ref, "startChats", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startChats);
			}

			static Delegate cb_startFeedbackSender;
#pragma warning disable 0169
			static Delegate GetStartFeedbackSenderHandler ()
			{
				if (cb_startFeedbackSender == null)
					cb_startFeedbackSender = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartFeedbackSender);
				return cb_startFeedbackSender;
			}

			static void n_StartFeedbackSender (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugInvocationFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugInvocationFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.StartFeedbackSender ();
			}
#pragma warning restore 0169

			IntPtr id_startFeedbackSender;
			public unsafe void StartFeedbackSender ()
			{
				if (id_startFeedbackSender == IntPtr.Zero)
					id_startFeedbackSender = JNIEnv.GetMethodID (class_ref, "startFeedbackSender", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startFeedbackSender);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugInvocationFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugInvocationFragment); }
		}

		protected InstabugInvocationFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInvocationFragment']/constructor[@name='InstabugInvocationFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugInvocationFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InstabugInvocationFragment)) {
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
			global::Com.Instabug.Library.InstabugInvocationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugInvocationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Layout;
		}
#pragma warning restore 0169

		static IntPtr id_getLayout;
		protected override unsafe int Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInvocationFragment']/method[@name='getLayout' and count(parameter)=0]"
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
			global::Com.Instabug.Library.InstabugInvocationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugInvocationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		protected override unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInvocationFragment']/method[@name='getTitle' and count(parameter)=0]"
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
			global::Com.Instabug.Library.InstabugInvocationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugInvocationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeNewInstanceSavedArguments ();
		}
#pragma warning restore 0169

		static IntPtr id_consumeNewInstanceSavedArguments;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInvocationFragment']/method[@name='consumeNewInstanceSavedArguments' and count(parameter)=0]"
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
			global::Com.Instabug.Library.InstabugInvocationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugInvocationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInvocationFragment']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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

		static Delegate cb_onVisibilityChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnVisibilityChanged_ZHandler ()
		{
			if (cb_onVisibilityChanged_Z == null)
				cb_onVisibilityChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnVisibilityChanged_Z);
			return cb_onVisibilityChanged_Z;
		}

		static void n_OnVisibilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Instabug.Library.InstabugInvocationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugInvocationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVisibilityChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onVisibilityChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInvocationFragment']/method[@name='onVisibilityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onVisibilityChanged", "(Z)V", "GetOnVisibilityChanged_ZHandler")]
		public virtual unsafe void OnVisibilityChanged (bool p0)
		{
			if (id_onVisibilityChanged_Z == IntPtr.Zero)
				id_onVisibilityChanged_Z = JNIEnv.GetMethodID (class_ref, "onVisibilityChanged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVisibilityChanged_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onVisibilityChanged", "(Z)V"), __args);
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
			global::Com.Instabug.Library.InstabugInvocationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugInvocationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RestoreState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_restoreState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInvocationFragment']/method[@name='restoreState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
			global::Com.Instabug.Library.InstabugInvocationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugInvocationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInvocationFragment']/method[@name='saveState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
