using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEventParam']"
	[global::Android.Runtime.Register ("com/instabug/library/user/UserEventParam", DoNotGenerateAcw=true)]
	public partial class UserEventParam : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/user/UserEventParam", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserEventParam); }
		}

		protected UserEventParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEventParam']/constructor[@name='UserEventParam' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UserEventParam ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UserEventParam)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
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

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.User.UserEventParam __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEventParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEventParam']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.User.UserEventParam __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEventParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEventParam']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKey_Ljava_lang_String_Handler ()
		{
			if (cb_setKey_Ljava_lang_String_ == null)
				cb_setKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetKey_Ljava_lang_String_);
			return cb_setKey_Ljava_lang_String_;
		}

		static IntPtr n_SetKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.User.UserEventParam __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEventParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEventParam']/method[@name='setKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setKey", "(Ljava/lang/String;)Lcom/instabug/library/user/UserEventParam;", "GetSetKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Instabug.Library.User.UserEventParam SetKey (string p0)
		{
			if (id_setKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKey", "(Ljava/lang/String;)Lcom/instabug/library/user/UserEventParam;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Instabug.Library.User.UserEventParam __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEventParam> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEventParam> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKey", "(Ljava/lang/String;)Lcom/instabug/library/user/UserEventParam;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_String_Handler ()
		{
			if (cb_setValue_Ljava_lang_String_ == null)
				cb_setValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_String_);
			return cb_setValue_Ljava_lang_String_;
		}

		static IntPtr n_SetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.User.UserEventParam __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEventParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEventParam']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setValue", "(Ljava/lang/String;)Lcom/instabug/library/user/UserEventParam;", "GetSetValue_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Instabug.Library.User.UserEventParam SetValue (string p0)
		{
			if (id_setValue_Ljava_lang_String_ == IntPtr.Zero)
				id_setValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/String;)Lcom/instabug/library/user/UserEventParam;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Instabug.Library.User.UserEventParam __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEventParam> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEventParam> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/String;)Lcom/instabug/library/user/UserEventParam;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
