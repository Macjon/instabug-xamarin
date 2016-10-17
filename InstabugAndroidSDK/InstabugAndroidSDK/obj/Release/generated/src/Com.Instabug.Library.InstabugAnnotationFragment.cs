using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugAnnotationFragment", DoNotGenerateAcw=true)]
	public partial class InstabugAnnotationFragment : global::Com.Instabug.Library.InstabugBaseFragment, global::Android.Views.View.IOnClickListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/field[@name='KEY_ANNOTATE_IMAGE_FROM_ATTACHMENT']"
		[Register ("KEY_ANNOTATE_IMAGE_FROM_ATTACHMENT")]
		public const int KeyAnnotateImageFromAttachment = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/field[@name='KEY_ANNOTATE_IMAGE_FROM_GALLERY_FOR_CHAT']"
		[Register ("KEY_ANNOTATE_IMAGE_FROM_GALLERY_FOR_CHAT")]
		public const int KeyAnnotateImageFromGalleryForChat = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/field[@name='KEY_ANNOTATE_INITIAL_SCREENSHOT_FOR_BUG']"
		[Register ("KEY_ANNOTATE_INITIAL_SCREENSHOT_FOR_BUG")]
		public const int KeyAnnotateInitialScreenshotForBug = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/field[@name='KEY_ANNOTATE_SCREENSHOT_FOR_CHAT']"
		[Register ("KEY_ANNOTATE_SCREENSHOT_FOR_CHAT")]
		public const int KeyAnnotateScreenshotForChat = (int) 0;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugAnnotationFragment.Callbacks']"
		[Register ("com/instabug/library/InstabugAnnotationFragment$Callbacks", "", "Com.Instabug.Library.InstabugAnnotationFragment/ICallbacksInvoker")]
		public partial interface ICallbacks : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugAnnotationFragment.Callbacks']/method[@name='onImageEditingCancelled' and count(parameter)=0]"
			[Register ("onImageEditingCancelled", "()V", "GetOnImageEditingCancelledHandler:Com.Instabug.Library.InstabugAnnotationFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void OnImageEditingCancelled ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugAnnotationFragment.Callbacks']/method[@name='onImageEditingDone' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.graphics.Bitmap']]"
			[Register ("onImageEditingDone", "(Landroid/net/Uri;Landroid/graphics/Bitmap;)V", "GetOnImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_Handler:Com.Instabug.Library.InstabugAnnotationFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void OnImageEditingDone (global::Android.Net.Uri p0, global::Android.Graphics.Bitmap p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugAnnotationFragment.Callbacks']/method[@name='onImageEditingDoneForChat' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.graphics.Bitmap']]"
			[Register ("onImageEditingDoneForChat", "(Landroid/net/Uri;Landroid/graphics/Bitmap;)V", "GetOnImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_Handler:Com.Instabug.Library.InstabugAnnotationFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void OnImageEditingDoneForChat (global::Android.Net.Uri p0, global::Android.Graphics.Bitmap p1);

		}

		[global::Android.Runtime.Register ("com/instabug/library/InstabugAnnotationFragment$Callbacks", DoNotGenerateAcw=true)]
		internal class ICallbacksInvoker : global::Java.Lang.Object, ICallbacks {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/InstabugAnnotationFragment$Callbacks");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library.InstabugAnnotationFragment.Callbacks"));
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

			static Delegate cb_onImageEditingCancelled;
#pragma warning disable 0169
			static Delegate GetOnImageEditingCancelledHandler ()
			{
				if (cb_onImageEditingCancelled == null)
					cb_onImageEditingCancelled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnImageEditingCancelled);
				return cb_onImageEditingCancelled;
			}

			static void n_OnImageEditingCancelled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugAnnotationFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAnnotationFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnImageEditingCancelled ();
			}
#pragma warning restore 0169

			IntPtr id_onImageEditingCancelled;
			public unsafe void OnImageEditingCancelled ()
			{
				if (id_onImageEditingCancelled == IntPtr.Zero)
					id_onImageEditingCancelled = JNIEnv.GetMethodID (class_ref, "onImageEditingCancelled", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImageEditingCancelled);
			}

			static Delegate cb_onImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetOnImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_onImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_ == null)
					cb_onImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_);
				return cb_onImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_;
			}

			static void n_OnImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Instabug.Library.InstabugAnnotationFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAnnotationFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnImageEditingDone (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_;
			public unsafe void OnImageEditingDone (global::Android.Net.Uri p0, global::Android.Graphics.Bitmap p1)
			{
				if (id_onImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_onImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onImageEditingDone", "(Landroid/net/Uri;Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImageEditingDone_Landroid_net_Uri_Landroid_graphics_Bitmap_, __args);
			}

			static Delegate cb_onImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetOnImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_onImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_ == null)
					cb_onImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_);
				return cb_onImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_;
			}

			static void n_OnImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Instabug.Library.InstabugAnnotationFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAnnotationFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnImageEditingDoneForChat (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_;
			public unsafe void OnImageEditingDoneForChat (global::Android.Net.Uri p0, global::Android.Graphics.Bitmap p1)
			{
				if (id_onImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_onImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onImageEditingDoneForChat", "(Landroid/net/Uri;Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImageEditingDoneForChat_Landroid_net_Uri_Landroid_graphics_Bitmap_, __args);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugAnnotationFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugAnnotationFragment); }
		}

		protected InstabugAnnotationFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/constructor[@name='InstabugAnnotationFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugAnnotationFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InstabugAnnotationFragment)) {
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
			global::Com.Instabug.Library.InstabugAnnotationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAnnotationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Layout;
		}
#pragma warning restore 0169

		static IntPtr id_getLayout;
		protected override unsafe int Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/method[@name='getLayout' and count(parameter)=0]"
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
			global::Com.Instabug.Library.InstabugAnnotationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAnnotationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		protected override unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/method[@name='getTitle' and count(parameter)=0]"
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
			global::Com.Instabug.Library.InstabugAnnotationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAnnotationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeNewInstanceSavedArguments ();
		}
#pragma warning restore 0169

		static IntPtr id_consumeNewInstanceSavedArguments;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/method[@name='consumeNewInstanceSavedArguments' and count(parameter)=0]"
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

		static IntPtr id_newInstance_Landroid_net_Uri_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("newInstance", "(Landroid/net/Uri;Ljava/lang/String;I)Lcom/instabug/library/InstabugAnnotationFragment;", "")]
		public static unsafe global::Com.Instabug.Library.InstabugAnnotationFragment NewInstance (global::Android.Net.Uri p0, string p1, int p2)
		{
			if (id_newInstance_Landroid_net_Uri_Ljava_lang_String_I == IntPtr.Zero)
				id_newInstance_Landroid_net_Uri_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Landroid/net/Uri;Ljava/lang/String;I)Lcom/instabug/library/InstabugAnnotationFragment;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.Instabug.Library.InstabugAnnotationFragment __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAnnotationFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Landroid_net_Uri_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Instabug.Library.InstabugAnnotationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAnnotationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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
			global::Com.Instabug.Library.InstabugAnnotationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAnnotationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RestoreState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_restoreState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/method[@name='restoreState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
			global::Com.Instabug.Library.InstabugAnnotationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAnnotationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAnnotationFragment']/method[@name='saveState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
