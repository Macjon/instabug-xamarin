using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEvent']"
	[global::Android.Runtime.Register ("com/instabug/library/user/UserEvent", DoNotGenerateAcw=true)]
	public partial class UserEvent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/user/UserEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserEvent); }
		}

		protected UserEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEvent']/constructor[@name='UserEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UserEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UserEvent)) {
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

		static Delegate cb_getDate;
#pragma warning disable 0169
		static Delegate GetGetDateHandler ()
		{
			if (cb_getDate == null)
				cb_getDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDate);
			return cb_getDate;
		}

		static long n_GetDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.User.UserEvent __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Date;
		}
#pragma warning restore 0169

		static IntPtr id_getDate;
		public virtual unsafe long Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEvent']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()J", "GetGetDateHandler")]
			get {
				if (id_getDate == IntPtr.Zero)
					id_getDate = JNIEnv.GetMethodID (class_ref, "getDate", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDate);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDate", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getEventIdentifier;
#pragma warning disable 0169
		static Delegate GetGetEventIdentifierHandler ()
		{
			if (cb_getEventIdentifier == null)
				cb_getEventIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventIdentifier);
			return cb_getEventIdentifier;
		}

		static IntPtr n_GetEventIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.User.UserEvent __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventIdentifier);
		}
#pragma warning restore 0169

		static IntPtr id_getEventIdentifier;
		public virtual unsafe string EventIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEvent']/method[@name='getEventIdentifier' and count(parameter)=0]"
			[Register ("getEventIdentifier", "()Ljava/lang/String;", "GetGetEventIdentifierHandler")]
			get {
				if (id_getEventIdentifier == IntPtr.Zero)
					id_getEventIdentifier = JNIEnv.GetMethodID (class_ref, "getEventIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getParams;
#pragma warning disable 0169
		static Delegate GetGetParamsHandler ()
		{
			if (cb_getParams == null)
				cb_getParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParams);
			return cb_getParams;
		}

		static IntPtr n_GetParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.User.UserEvent __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Instabug.Library.User.UserEventParam>.ToLocalJniHandle (__this.Params);
		}
#pragma warning restore 0169

		static IntPtr id_getParams;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Instabug.Library.User.UserEventParam> Params {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEvent']/method[@name='getParams' and count(parameter)=0]"
			[Register ("getParams", "()Ljava/util/List;", "GetGetParamsHandler")]
			get {
				if (id_getParams == IntPtr.Zero)
					id_getParams = JNIEnv.GetMethodID (class_ref, "getParams", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Instabug.Library.User.UserEventParam>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Instabug.Library.User.UserEventParam>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParams", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addParam_Lcom_instabug_library_user_UserEventParam_;
#pragma warning disable 0169
		static Delegate GetAddParam_Lcom_instabug_library_user_UserEventParam_Handler ()
		{
			if (cb_addParam_Lcom_instabug_library_user_UserEventParam_ == null)
				cb_addParam_Lcom_instabug_library_user_UserEventParam_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddParam_Lcom_instabug_library_user_UserEventParam_);
			return cb_addParam_Lcom_instabug_library_user_UserEventParam_;
		}

		static IntPtr n_AddParam_Lcom_instabug_library_user_UserEventParam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.User.UserEvent __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.User.UserEventParam p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEventParam> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddParam (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addParam_Lcom_instabug_library_user_UserEventParam_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEvent']/method[@name='addParam' and count(parameter)=1 and parameter[1][@type='com.instabug.library.user.UserEventParam']]"
		[Register ("addParam", "(Lcom/instabug/library/user/UserEventParam;)Lcom/instabug/library/user/UserEvent;", "GetAddParam_Lcom_instabug_library_user_UserEventParam_Handler")]
		public virtual unsafe global::Com.Instabug.Library.User.UserEvent AddParam (global::Com.Instabug.Library.User.UserEventParam p0)
		{
			if (id_addParam_Lcom_instabug_library_user_UserEventParam_ == IntPtr.Zero)
				id_addParam_Lcom_instabug_library_user_UserEventParam_ = JNIEnv.GetMethodID (class_ref, "addParam", "(Lcom/instabug/library/user/UserEventParam;)Lcom/instabug/library/user/UserEvent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Instabug.Library.User.UserEvent __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addParam_Lcom_instabug_library_user_UserEventParam_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addParam", "(Lcom/instabug/library/user/UserEventParam;)Lcom/instabug/library/user/UserEvent;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDate_J;
#pragma warning disable 0169
		static Delegate GetSetDate_JHandler ()
		{
			if (cb_setDate_J == null)
				cb_setDate_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetDate_J);
			return cb_setDate_J;
		}

		static IntPtr n_SetDate_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Instabug.Library.User.UserEvent __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDate (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setDate_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEvent']/method[@name='setDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDate", "(J)Lcom/instabug/library/user/UserEvent;", "GetSetDate_JHandler")]
		public virtual unsafe global::Com.Instabug.Library.User.UserEvent SetDate (long p0)
		{
			if (id_setDate_J == IntPtr.Zero)
				id_setDate_J = JNIEnv.GetMethodID (class_ref, "setDate", "(J)Lcom/instabug/library/user/UserEvent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDate_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDate", "(J)Lcom/instabug/library/user/UserEvent;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEventIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEventIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setEventIdentifier_Ljava_lang_String_ == null)
				cb_setEventIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEventIdentifier_Ljava_lang_String_);
			return cb_setEventIdentifier_Ljava_lang_String_;
		}

		static IntPtr n_SetEventIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.User.UserEvent __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEventIdentifier (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setEventIdentifier_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEvent']/method[@name='setEventIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEventIdentifier", "(Ljava/lang/String;)Lcom/instabug/library/user/UserEvent;", "GetSetEventIdentifier_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Instabug.Library.User.UserEvent SetEventIdentifier (string p0)
		{
			if (id_setEventIdentifier_Ljava_lang_String_ == IntPtr.Zero)
				id_setEventIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEventIdentifier", "(Ljava/lang/String;)Lcom/instabug/library/user/UserEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Instabug.Library.User.UserEvent __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEventIdentifier_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventIdentifier", "(Ljava/lang/String;)Lcom/instabug/library/user/UserEvent;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.User.UserEvent __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.User.UserEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJson ());
		}
#pragma warning restore 0169

		static IntPtr id_toJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEvent']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Lorg/json/JSONObject;", "GetToJsonHandler")]
		public virtual unsafe global::Org.Json.JSONObject ToJson ()
		{
			if (id_toJson == IntPtr.Zero)
				id_toJson = JNIEnv.GetMethodID (class_ref, "toJson", "()Lorg/json/JSONObject;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJson", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.user']/class[@name='UserEvent']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.instabug.library.user.UserEvent&gt;']]"
		[Register ("toJson", "(Ljava/util/List;)Lorg/json/JSONArray;", "")]
		public static unsafe global::Org.Json.JSONArray ToJson (global::System.Collections.Generic.IList<global::Com.Instabug.Library.User.UserEvent> p0)
		{
			if (id_toJson_Ljava_util_List_ == IntPtr.Zero)
				id_toJson_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "toJson", "(Ljava/util/List;)Lorg/json/JSONArray;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Instabug.Library.User.UserEvent>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Json.JSONArray __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toJson_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
