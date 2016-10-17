using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAddAttachmentsFragment']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugAddAttachmentsFragment", DoNotGenerateAcw=true)]
	public partial class InstabugAddAttachmentsFragment : global::Com.Instabug.Library.InstabugBaseFragment, global::Android.Views.View.IOnClickListener, global::Com.Instabug.Library.IFragmentVisibilityChangedListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugAddAttachmentsFragment.Callbacks']"
		[Register ("com/instabug/library/InstabugAddAttachmentsFragment$Callbacks", "", "Com.Instabug.Library.InstabugAddAttachmentsFragment/ICallbacksInvoker")]
		public partial interface ICallbacks : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugAddAttachmentsFragment.Callbacks']/method[@name='attachImageFromGallery' and count(parameter)=0]"
			[Register ("attachImageFromGallery", "()V", "GetAttachImageFromGalleryHandler:Com.Instabug.Library.InstabugAddAttachmentsFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void AttachImageFromGallery ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugAddAttachmentsFragment.Callbacks']/method[@name='attachScreenshot' and count(parameter)=0]"
			[Register ("attachScreenshot", "()V", "GetAttachScreenshotHandler:Com.Instabug.Library.InstabugAddAttachmentsFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void AttachScreenshot ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugAddAttachmentsFragment.Callbacks']/method[@name='attachVideo' and count(parameter)=0]"
			[Register ("attachVideo", "()V", "GetAttachVideoHandler:Com.Instabug.Library.InstabugAddAttachmentsFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void AttachVideo ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugAddAttachmentsFragment.Callbacks']/method[@name='attachVoiceNote' and count(parameter)=0]"
			[Register ("attachVoiceNote", "()V", "GetAttachVoiceNoteHandler:Com.Instabug.Library.InstabugAddAttachmentsFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void AttachVoiceNote ();

		}

		[global::Android.Runtime.Register ("com/instabug/library/InstabugAddAttachmentsFragment$Callbacks", DoNotGenerateAcw=true)]
		internal class ICallbacksInvoker : global::Java.Lang.Object, ICallbacks {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/InstabugAddAttachmentsFragment$Callbacks");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library.InstabugAddAttachmentsFragment.Callbacks"));
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

			static Delegate cb_attachImageFromGallery;
#pragma warning disable 0169
			static Delegate GetAttachImageFromGalleryHandler ()
			{
				if (cb_attachImageFromGallery == null)
					cb_attachImageFromGallery = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AttachImageFromGallery);
				return cb_attachImageFromGallery;
			}

			static void n_AttachImageFromGallery (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugAddAttachmentsFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AttachImageFromGallery ();
			}
#pragma warning restore 0169

			IntPtr id_attachImageFromGallery;
			public unsafe void AttachImageFromGallery ()
			{
				if (id_attachImageFromGallery == IntPtr.Zero)
					id_attachImageFromGallery = JNIEnv.GetMethodID (class_ref, "attachImageFromGallery", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attachImageFromGallery);
			}

			static Delegate cb_attachScreenshot;
#pragma warning disable 0169
			static Delegate GetAttachScreenshotHandler ()
			{
				if (cb_attachScreenshot == null)
					cb_attachScreenshot = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AttachScreenshot);
				return cb_attachScreenshot;
			}

			static void n_AttachScreenshot (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugAddAttachmentsFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AttachScreenshot ();
			}
#pragma warning restore 0169

			IntPtr id_attachScreenshot;
			public unsafe void AttachScreenshot ()
			{
				if (id_attachScreenshot == IntPtr.Zero)
					id_attachScreenshot = JNIEnv.GetMethodID (class_ref, "attachScreenshot", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attachScreenshot);
			}

			static Delegate cb_attachVideo;
#pragma warning disable 0169
			static Delegate GetAttachVideoHandler ()
			{
				if (cb_attachVideo == null)
					cb_attachVideo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AttachVideo);
				return cb_attachVideo;
			}

			static void n_AttachVideo (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugAddAttachmentsFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AttachVideo ();
			}
#pragma warning restore 0169

			IntPtr id_attachVideo;
			public unsafe void AttachVideo ()
			{
				if (id_attachVideo == IntPtr.Zero)
					id_attachVideo = JNIEnv.GetMethodID (class_ref, "attachVideo", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attachVideo);
			}

			static Delegate cb_attachVoiceNote;
#pragma warning disable 0169
			static Delegate GetAttachVoiceNoteHandler ()
			{
				if (cb_attachVoiceNote == null)
					cb_attachVoiceNote = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AttachVoiceNote);
				return cb_attachVoiceNote;
			}

			static void n_AttachVoiceNote (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugAddAttachmentsFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AttachVoiceNote ();
			}
#pragma warning restore 0169

			IntPtr id_attachVoiceNote;
			public unsafe void AttachVoiceNote ()
			{
				if (id_attachVoiceNote == IntPtr.Zero)
					id_attachVoiceNote = JNIEnv.GetMethodID (class_ref, "attachVoiceNote", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attachVoiceNote);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugAddAttachmentsFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugAddAttachmentsFragment); }
		}

		protected InstabugAddAttachmentsFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAddAttachmentsFragment']/constructor[@name='InstabugAddAttachmentsFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugAddAttachmentsFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InstabugAddAttachmentsFragment)) {
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
			global::Com.Instabug.Library.InstabugAddAttachmentsFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Layout;
		}
#pragma warning restore 0169

		static IntPtr id_getLayout;
		protected override unsafe int Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAddAttachmentsFragment']/method[@name='getLayout' and count(parameter)=0]"
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
			global::Com.Instabug.Library.InstabugAddAttachmentsFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		protected override unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAddAttachmentsFragment']/method[@name='getTitle' and count(parameter)=0]"
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
			global::Com.Instabug.Library.InstabugAddAttachmentsFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeNewInstanceSavedArguments ();
		}
#pragma warning restore 0169

		static IntPtr id_consumeNewInstanceSavedArguments;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAddAttachmentsFragment']/method[@name='consumeNewInstanceSavedArguments' and count(parameter)=0]"
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

		static IntPtr id_newInstance_Lcom_instabug_library_InstabugAddAttachmentsFragment_Callbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAddAttachmentsFragment']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='com.instabug.library.InstabugAddAttachmentsFragment.Callbacks']]"
		[Register ("newInstance", "(Lcom/instabug/library/InstabugAddAttachmentsFragment$Callbacks;)Lcom/instabug/library/InstabugAddAttachmentsFragment;", "")]
		public static unsafe global::Com.Instabug.Library.InstabugAddAttachmentsFragment NewInstance (global::Com.Instabug.Library.InstabugAddAttachmentsFragment.ICallbacks p0)
		{
			if (id_newInstance_Lcom_instabug_library_InstabugAddAttachmentsFragment_Callbacks_ == IntPtr.Zero)
				id_newInstance_Lcom_instabug_library_InstabugAddAttachmentsFragment_Callbacks_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Lcom/instabug/library/InstabugAddAttachmentsFragment$Callbacks;)Lcom/instabug/library/InstabugAddAttachmentsFragment;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Instabug.Library.InstabugAddAttachmentsFragment __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Lcom_instabug_library_InstabugAddAttachmentsFragment_Callbacks_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Instabug.Library.InstabugAddAttachmentsFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAddAttachmentsFragment']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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
			global::Com.Instabug.Library.InstabugAddAttachmentsFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVisibilityChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onVisibilityChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAddAttachmentsFragment']/method[@name='onVisibilityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Instabug.Library.InstabugAddAttachmentsFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RestoreState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_restoreState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAddAttachmentsFragment']/method[@name='restoreState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
			global::Com.Instabug.Library.InstabugAddAttachmentsFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAddAttachmentsFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAddAttachmentsFragment']/method[@name='saveState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
