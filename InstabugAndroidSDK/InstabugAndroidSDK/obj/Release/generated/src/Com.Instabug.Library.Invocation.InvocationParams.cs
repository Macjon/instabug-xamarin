using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Invocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']"
	[global::Android.Runtime.Register ("com/instabug/library/invocation/InvocationParams", DoNotGenerateAcw=true)]
	public partial class InvocationParams : global::Java.Lang.Object, global::Java.IO.ISerializable {

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

		static Delegate cb_getInitialScreenshotUriAsString;
#pragma warning disable 0169
		static Delegate GetGetInitialScreenshotUriAsStringHandler ()
		{
			if (cb_getInitialScreenshotUriAsString == null)
				cb_getInitialScreenshotUriAsString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInitialScreenshotUriAsString);
			return cb_getInitialScreenshotUriAsString;
		}

		static IntPtr n_GetInitialScreenshotUriAsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Invocation.InvocationParams __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InitialScreenshotUriAsString);
		}
#pragma warning restore 0169

		static IntPtr id_getInitialScreenshotUriAsString;
		public virtual unsafe string InitialScreenshotUriAsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']/method[@name='getInitialScreenshotUriAsString' and count(parameter)=0]"
			[Register ("getInitialScreenshotUriAsString", "()Ljava/lang/String;", "GetGetInitialScreenshotUriAsStringHandler")]
			get {
				if (id_getInitialScreenshotUriAsString == IntPtr.Zero)
					id_getInitialScreenshotUriAsString = JNIEnv.GetMethodID (class_ref, "getInitialScreenshotUriAsString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInitialScreenshotUriAsString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitialScreenshotUriAsString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPromptOptions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPromptOptions", "()Lcom/instabug/library/invocation/PromptOptions;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isShouldInspectView;
#pragma warning disable 0169
		static Delegate GetIsShouldInspectViewHandler ()
		{
			if (cb_isShouldInspectView == null)
				cb_isShouldInspectView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShouldInspectView);
			return cb_isShouldInspectView;
		}

		static bool n_IsShouldInspectView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Invocation.InvocationParams __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldInspectView;
		}
#pragma warning restore 0169

		static Delegate cb_setShouldInspectView_Z;
#pragma warning disable 0169
		static Delegate GetSetShouldInspectView_ZHandler ()
		{
			if (cb_setShouldInspectView_Z == null)
				cb_setShouldInspectView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShouldInspectView_Z);
			return cb_setShouldInspectView_Z;
		}

		static void n_SetShouldInspectView_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Instabug.Library.Invocation.InvocationParams __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShouldInspectView = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShouldInspectView;
		static IntPtr id_setShouldInspectView_Z;
		public virtual unsafe bool ShouldInspectView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']/method[@name='isShouldInspectView' and count(parameter)=0]"
			[Register ("isShouldInspectView", "()Z", "GetIsShouldInspectViewHandler")]
			get {
				if (id_isShouldInspectView == IntPtr.Zero)
					id_isShouldInspectView = JNIEnv.GetMethodID (class_ref, "isShouldInspectView", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShouldInspectView);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShouldInspectView", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']/method[@name='setShouldInspectView' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShouldInspectView", "(Z)V", "GetSetShouldInspectView_ZHandler")]
			set {
				if (id_setShouldInspectView_Z == IntPtr.Zero)
					id_setShouldInspectView_Z = JNIEnv.GetMethodID (class_ref, "setShouldInspectView", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShouldInspectView_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldInspectView", "(Z)V"), __args);
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

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShouldInvokedWithMode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationMode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShouldInvokedWithMode", "()Lcom/instabug/library/invocation/InstabugInvocationMode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getViewHierarchy;
#pragma warning disable 0169
		static Delegate GetGetViewHierarchyHandler ()
		{
			if (cb_getViewHierarchy == null)
				cb_getViewHierarchy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetViewHierarchy);
			return cb_getViewHierarchy;
		}

		static IntPtr n_GetViewHierarchy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Invocation.InvocationParams __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ViewHierarchy);
		}
#pragma warning restore 0169

		static Delegate cb_setViewHierarchy_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetViewHierarchy_Ljava_lang_String_Handler ()
		{
			if (cb_setViewHierarchy_Ljava_lang_String_ == null)
				cb_setViewHierarchy_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetViewHierarchy_Ljava_lang_String_);
			return cb_setViewHierarchy_Ljava_lang_String_;
		}

		static void n_SetViewHierarchy_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Invocation.InvocationParams __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ViewHierarchy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getViewHierarchy;
		static IntPtr id_setViewHierarchy_Ljava_lang_String_;
		public virtual unsafe string ViewHierarchy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']/method[@name='getViewHierarchy' and count(parameter)=0]"
			[Register ("getViewHierarchy", "()Ljava/lang/String;", "GetGetViewHierarchyHandler")]
			get {
				if (id_getViewHierarchy == IntPtr.Zero)
					id_getViewHierarchy = JNIEnv.GetMethodID (class_ref, "getViewHierarchy", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getViewHierarchy), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getViewHierarchy", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']/method[@name='setViewHierarchy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setViewHierarchy", "(Ljava/lang/String;)V", "GetSetViewHierarchy_Ljava_lang_String_Handler")]
			set {
				if (id_setViewHierarchy_Ljava_lang_String_ == IntPtr.Zero)
					id_setViewHierarchy_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setViewHierarchy", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewHierarchy_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewHierarchy", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setInitialScreenshotUriAsString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInitialScreenshotUriAsString_Ljava_lang_String_Handler ()
		{
			if (cb_setInitialScreenshotUriAsString_Ljava_lang_String_ == null)
				cb_setInitialScreenshotUriAsString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInitialScreenshotUriAsString_Ljava_lang_String_);
			return cb_setInitialScreenshotUriAsString_Ljava_lang_String_;
		}

		static IntPtr n_SetInitialScreenshotUriAsString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Invocation.InvocationParams __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInitialScreenshotUriAsString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setInitialScreenshotUriAsString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InvocationParams']/method[@name='setInitialScreenshotUriAsString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setInitialScreenshotUriAsString", "(Ljava/lang/String;)Lcom/instabug/library/invocation/InvocationParams;", "GetSetInitialScreenshotUriAsString_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Instabug.Library.Invocation.InvocationParams SetInitialScreenshotUriAsString (string p0)
		{
			if (id_setInitialScreenshotUriAsString_Ljava_lang_String_ == IntPtr.Zero)
				id_setInitialScreenshotUriAsString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInitialScreenshotUriAsString", "(Ljava/lang/String;)Lcom/instabug/library/invocation/InvocationParams;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Instabug.Library.Invocation.InvocationParams __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setInitialScreenshotUriAsString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitialScreenshotUriAsString", "(Ljava/lang/String;)Lcom/instabug/library/invocation/InvocationParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShouldInvokedWithMode_Lcom_instabug_library_invocation_InstabugInvocationMode_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InvocationParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldInvokedWithMode", "(Lcom/instabug/library/invocation/InstabugInvocationMode;)Lcom/instabug/library/invocation/InvocationParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
