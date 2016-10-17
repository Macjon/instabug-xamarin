using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='LiveBugManager']"
	[global::Android.Runtime.Register ("com/instabug/library/LiveBugManager", DoNotGenerateAcw=true)]
	public partial class LiveBugManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/LiveBugManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LiveBugManager); }
		}

		protected LiveBugManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		protected static unsafe global::Com.Instabug.Library.LiveBugManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='LiveBugManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/library/LiveBugManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/library/LiveBugManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.LiveBugManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isInBackground;
#pragma warning disable 0169
		static Delegate GetIsInBackgroundHandler ()
		{
			if (cb_isInBackground == null)
				cb_isInBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInBackground);
			return cb_isInBackground;
		}

		static bool n_IsInBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.LiveBugManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.LiveBugManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInBackground;
		}
#pragma warning restore 0169

		static Delegate cb_setIsInBackground_Z;
#pragma warning disable 0169
		static Delegate GetSetIsInBackground_ZHandler ()
		{
			if (cb_setIsInBackground_Z == null)
				cb_setIsInBackground_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsInBackground_Z);
			return cb_setIsInBackground_Z;
		}

		static void n_SetIsInBackground_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Instabug.Library.LiveBugManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.LiveBugManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsInBackground = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isInBackground;
		static IntPtr id_setIsInBackground_Z;
		public virtual unsafe bool IsInBackground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='LiveBugManager']/method[@name='isInBackground' and count(parameter)=0]"
			[Register ("isInBackground", "()Z", "GetIsInBackgroundHandler")]
			get {
				if (id_isInBackground == IntPtr.Zero)
					id_isInBackground = JNIEnv.GetMethodID (class_ref, "isInBackground", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInBackground);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInBackground", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='LiveBugManager']/method[@name='setIsInBackground' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsInBackground", "(Z)V", "GetSetIsInBackground_ZHandler")]
			set {
				if (id_setIsInBackground_Z == IntPtr.Zero)
					id_setIsInBackground_Z = JNIEnv.GetMethodID (class_ref, "setIsInBackground", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsInBackground_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsInBackground", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_addAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_Handler ()
		{
			if (cb_addAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_ == null)
				cb_addAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_);
			return cb_addAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_;
		}

		static void n_AddAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Instabug.Library.LiveBugManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.LiveBugManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddAudioAttachment (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='LiveBugManager']/method[@name='addAudioAttachment' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.String']]"
		[Register ("addAudioAttachment", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;)V", "GetAddAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_Handler")]
		protected virtual unsafe void AddAudioAttachment (global::Android.Content.Context p0, global::Android.Net.Uri p1, string p2)
		{
			if (id_addAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_ == IntPtr.Zero)
				id_addAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addAudioAttachment", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addAudioAttachment_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAudioAttachment", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addImageAttachment_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetAddImageAttachment_Landroid_content_Context_Landroid_net_Uri_Handler ()
		{
			if (cb_addImageAttachment_Landroid_content_Context_Landroid_net_Uri_ == null)
				cb_addImageAttachment_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddImageAttachment_Landroid_content_Context_Landroid_net_Uri_);
			return cb_addImageAttachment_Landroid_content_Context_Landroid_net_Uri_;
		}

		static void n_AddImageAttachment_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Instabug.Library.LiveBugManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.LiveBugManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddImageAttachment (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addImageAttachment_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='LiveBugManager']/method[@name='addImageAttachment' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("addImageAttachment", "(Landroid/content/Context;Landroid/net/Uri;)V", "GetAddImageAttachment_Landroid_content_Context_Landroid_net_Uri_Handler")]
		protected virtual unsafe void AddImageAttachment (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_addImageAttachment_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_addImageAttachment_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "addImageAttachment", "(Landroid/content/Context;Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addImageAttachment_Landroid_content_Context_Landroid_net_Uri_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addImageAttachment", "(Landroid/content/Context;Landroid/net/Uri;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createBug_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCreateBug_Landroid_content_Context_Handler ()
		{
			if (cb_createBug_Landroid_content_Context_ == null)
				cb_createBug_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateBug_Landroid_content_Context_);
			return cb_createBug_Landroid_content_Context_;
		}

		static void n_CreateBug_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.LiveBugManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.LiveBugManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateBug (p0);
		}
#pragma warning restore 0169

		static IntPtr id_createBug_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='LiveBugManager']/method[@name='createBug' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createBug", "(Landroid/content/Context;)V", "GetCreateBug_Landroid_content_Context_Handler")]
		protected virtual unsafe void CreateBug (global::Android.Content.Context p0)
		{
			if (id_createBug_Landroid_content_Context_ == IntPtr.Zero)
				id_createBug_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "createBug", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createBug_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createBug", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_refreshAttachments_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetRefreshAttachments_Landroid_content_Context_Handler ()
		{
			if (cb_refreshAttachments_Landroid_content_Context_ == null)
				cb_refreshAttachments_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RefreshAttachments_Landroid_content_Context_);
			return cb_refreshAttachments_Landroid_content_Context_;
		}

		static void n_RefreshAttachments_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.LiveBugManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.LiveBugManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RefreshAttachments (p0);
		}
#pragma warning restore 0169

		static IntPtr id_refreshAttachments_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='LiveBugManager']/method[@name='refreshAttachments' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("refreshAttachments", "(Landroid/content/Context;)V", "GetRefreshAttachments_Landroid_content_Context_Handler")]
		protected virtual unsafe void RefreshAttachments (global::Android.Content.Context p0)
		{
			if (id_refreshAttachments_Landroid_content_Context_ == IntPtr.Zero)
				id_refreshAttachments_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "refreshAttachments", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshAttachments_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshAttachments", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

	}
}
