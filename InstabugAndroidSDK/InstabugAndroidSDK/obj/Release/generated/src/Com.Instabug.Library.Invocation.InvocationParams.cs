using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Invocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']"
	[global::Android.Runtime.Register ("com/instabug/library/invocation/InvocationParams", DoNotGenerateAcw=true)]
	public partial class InvocationParams : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/invocation/InvocationParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InvocationParams); }
		}

		protected InvocationParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getInitialScreenshotUri;
#pragma warning disable 0169
		static Delegate GetGetInitialScreenshotUriHandler ()
		{
			if (cb_getInitialScreenshotUri == null)
				cb_getInitialScreenshotUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInitialScreenshotUri);
			return cb_getInitialScreenshotUri;
		}

		static IntPtr n_GetInitialScreenshotUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Invocation.InvocationParams __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitialScreenshotUri);
		}
#pragma warning restore 0169

		static IntPtr id_getInitialScreenshotUri;
		public virtual unsafe global::Android.Net.Uri InitialScreenshotUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']/method[@name='getInitialScreenshotUri' and count(parameter)=0]"
			[Register ("getInitialScreenshotUri", "()Landroid/net/Uri;", "GetGetInitialScreenshotUriHandler")]
			get {
				if (id_getInitialScreenshotUri == IntPtr.Zero)
					id_getInitialScreenshotUri = JNIEnv.GetMethodID (class_ref, "getInitialScreenshotUri", "()Landroid/net/Uri;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInitialScreenshotUri), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitialScreenshotUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPromptOptions;
#pragma warning disable 0169
		static Delegate GetGetPromptOptionsHandler ()
		{
			if (cb_getPromptOptions == null)
				cb_getPromptOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPromptOptions);
			return cb_getPromptOptions;
		}

		static IntPtr n_GetPromptOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Invocation.InvocationParams __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PromptOptions);
		}
#pragma warning restore 0169

		static IntPtr id_getPromptOptions;
		public virtual unsafe global::Com.Instabug.Library.Invocation.PromptOptions PromptOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']/method[@name='getPromptOptions' and count(parameter)=0]"
			[Register ("getPromptOptions", "()Lcom/instabug/library/invocation/PromptOptions;", "GetGetPromptOptionsHandler")]
			get {
				if (id_getPromptOptions == IntPtr.Zero)
					id_getPromptOptions = JNIEnv.GetMethodID (class_ref, "getPromptOptions", "()Lcom/instabug/library/invocation/PromptOptions;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPromptOptions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPromptOptions", "()Lcom/instabug/library/invocation/PromptOptions;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getShouldInvokedWithMode;
#pragma warning disable 0169
		static Delegate GetGetShouldInvokedWithModeHandler ()
		{
			if (cb_getShouldInvokedWithMode == null)
				cb_getShouldInvokedWithMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShouldInvokedWithMode);
			return cb_getShouldInvokedWithMode;
		}

		static IntPtr n_GetShouldInvokedWithMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Invocation.InvocationParams __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShouldInvokedWithMode);
		}
#pragma warning restore 0169

		static IntPtr id_getShouldInvokedWithMode;
		public virtual unsafe global::Com.Instabug.Library.Invocation.InstabugInvocationMode ShouldInvokedWithMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']/method[@name='getShouldInvokedWithMode' and count(parameter)=0]"
			[Register ("getShouldInvokedWithMode", "()Lcom/instabug/library/invocation/InstabugInvocationMode;", "GetGetShouldInvokedWithModeHandler")]
			get {
				if (id_getShouldInvokedWithMode == IntPtr.Zero)
					id_getShouldInvokedWithMode = JNIEnv.GetMethodID (class_ref, "getShouldInvokedWithMode", "()Lcom/instabug/library/invocation/InstabugInvocationMode;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShouldInvokedWithMode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationMode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShouldInvokedWithMode", "()Lcom/instabug/library/invocation/InstabugInvocationMode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setInitialScreenshotUri_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetInitialScreenshotUri_Landroid_net_Uri_Handler ()
		{
			if (cb_setInitialScreenshotUri_Landroid_net_Uri_ == null)
				cb_setInitialScreenshotUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInitialScreenshotUri_Landroid_net_Uri_);
			return cb_setInitialScreenshotUri_Landroid_net_Uri_;
		}

		static IntPtr n_SetInitialScreenshotUri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Invocation.InvocationParams __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInitialScreenshotUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setInitialScreenshotUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']/method[@name='setInitialScreenshotUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setInitialScreenshotUri", "(Landroid/net/Uri;)Lcom/instabug/library/invocation/InvocationParams;", "GetSetInitialScreenshotUri_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Com.Instabug.Library.Invocation.InvocationParams SetInitialScreenshotUri (global::Android.Net.Uri p0)
		{
			if (id_setInitialScreenshotUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_setInitialScreenshotUri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setInitialScreenshotUri", "(Landroid/net/Uri;)Lcom/instabug/library/invocation/InvocationParams;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Instabug.Library.Invocation.InvocationParams __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setInitialScreenshotUri_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitialScreenshotUri", "(Landroid/net/Uri;)Lcom/instabug/library/invocation/InvocationParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_;
#pragma warning disable 0169
		static Delegate GetSetShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_Handler ()
		{
			if (cb_setShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_ == null)
				cb_setShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_);
			return cb_setShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_;
		}

		static IntPtr n_SetShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Invocation.InvocationParams __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Invocation.InstabugInvocationMode p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetShouldInvokedWithMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']/method[@name='setShouldInvokedWithMode' and count(parameter)=1 and parameter[1][@type='com.instabug.library.invocation.InstabugInvocationMode']]"
		[Register ("setShouldInvokedWithMode", "(Lcom/instabug/library/invocation/InstabugInvocationMode;)Lcom/instabug/library/invocation/InvocationParams;", "GetSetShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_Handler")]
		public virtual unsafe global::Com.Instabug.Library.Invocation.InvocationParams SetShouldInvokedWithMode (global::Com.Instabug.Library.Invocation.InstabugInvocationMode p0)
		{
			if (id_setShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_ == IntPtr.Zero)
				id_setShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_ = JNIEnv.GetMethodID (class_ref, "setShouldInvokedWithMode", "(Lcom/instabug/library/invocation/InstabugInvocationMode;)Lcom/instabug/library/invocation/InvocationParams;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Instabug.Library.Invocation.InvocationParams __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldInvokedWithMode", "(Lcom/instabug/library/invocation/InstabugInvocationMode;)Lcom/instabug/library/invocation/InvocationParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
