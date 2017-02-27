using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']"
	[global::Android.Runtime.Register ("com/instabug/library/model/NetworkLog", DoNotGenerateAcw=true)]
	public partial class NetworkLog : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/model/NetworkLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkLog); }
		}

		protected NetworkLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/constructor[@name='NetworkLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetworkLog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NetworkLog)) {
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
				cb_getDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDate);
			return cb_getDate;
		}

		static IntPtr n_GetDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Date);
		}
#pragma warning restore 0169

		static Delegate cb_setDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDate_Ljava_lang_String_Handler ()
		{
			if (cb_setDate_Ljava_lang_String_ == null)
				cb_setDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDate_Ljava_lang_String_);
			return cb_setDate_Ljava_lang_String_;
		}

		static void n_SetDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Date = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDate;
		static IntPtr id_setDate_Ljava_lang_String_;
		public virtual unsafe string Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()Ljava/lang/String;", "GetGetDateHandler")]
			get {
				if (id_getDate == IntPtr.Zero)
					id_getDate = JNIEnv.GetMethodID (class_ref, "getDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='setDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDate", "(Ljava/lang/String;)V", "GetSetDate_Ljava_lang_String_Handler")]
			set {
				if (id_setDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Headers);
		}
#pragma warning restore 0169

		static Delegate cb_setHeaders_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHeaders_Ljava_lang_String_Handler ()
		{
			if (cb_setHeaders_Ljava_lang_String_ == null)
				cb_setHeaders_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeaders_Ljava_lang_String_);
			return cb_setHeaders_Ljava_lang_String_;
		}

		static void n_SetHeaders_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Headers = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		static IntPtr id_setHeaders_Ljava_lang_String_;
		public virtual unsafe string Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/lang/String;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='setHeaders' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHeaders", "(Ljava/lang/String;)V", "GetSetHeaders_Ljava_lang_String_Handler")]
			set {
				if (id_setHeaders_Ljava_lang_String_ == IntPtr.Zero)
					id_setHeaders_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHeaders", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeaders_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeaders", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMethod;
#pragma warning disable 0169
		static Delegate GetGetMethodHandler ()
		{
			if (cb_getMethod == null)
				cb_getMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethod);
			return cb_getMethod;
		}

		static IntPtr n_GetMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Method);
		}
#pragma warning restore 0169

		static Delegate cb_setMethod_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMethod_Ljava_lang_String_Handler ()
		{
			if (cb_setMethod_Ljava_lang_String_ == null)
				cb_setMethod_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMethod_Ljava_lang_String_);
			return cb_setMethod_Ljava_lang_String_;
		}

		static void n_SetMethod_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Method = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMethod;
		static IntPtr id_setMethod_Ljava_lang_String_;
		public virtual unsafe string Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Ljava/lang/String;", "GetGetMethodHandler")]
			get {
				if (id_getMethod == IntPtr.Zero)
					id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMethod", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='setMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMethod", "(Ljava/lang/String;)V", "GetSetMethod_Ljava_lang_String_Handler")]
			set {
				if (id_setMethod_Ljava_lang_String_ == IntPtr.Zero)
					id_setMethod_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMethod", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMethod_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMethod", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Request);
		}
#pragma warning restore 0169

		static Delegate cb_setRequest_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequest_Ljava_lang_String_Handler ()
		{
			if (cb_setRequest_Ljava_lang_String_ == null)
				cb_setRequest_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequest_Ljava_lang_String_);
			return cb_setRequest_Ljava_lang_String_;
		}

		static void n_SetRequest_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Request = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequest;
		static IntPtr id_setRequest_Ljava_lang_String_;
		public virtual unsafe string Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Ljava/lang/String;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequest", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='setRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRequest", "(Ljava/lang/String;)V", "GetSetRequest_Ljava_lang_String_Handler")]
			set {
				if (id_setRequest_Ljava_lang_String_ == IntPtr.Zero)
					id_setRequest_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequest", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequest_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequest", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Response);
		}
#pragma warning restore 0169

		static Delegate cb_setResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setResponse_Ljava_lang_String_ == null)
				cb_setResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponse_Ljava_lang_String_);
			return cb_setResponse_Ljava_lang_String_;
		}

		static void n_SetResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Response = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		static IntPtr id_setResponse_Ljava_lang_String_;
		public virtual unsafe string Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Ljava/lang/String;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponse", "(Ljava/lang/String;)V", "GetSetResponse_Ljava_lang_String_Handler")]
			set {
				if (id_setResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponse_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponse", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponseCode;
#pragma warning disable 0169
		static Delegate GetGetResponseCodeHandler ()
		{
			if (cb_getResponseCode == null)
				cb_getResponseCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResponseCode);
			return cb_getResponseCode;
		}

		static int n_GetResponseCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseCode;
		}
#pragma warning restore 0169

		static Delegate cb_setResponseCode_I;
#pragma warning disable 0169
		static Delegate GetSetResponseCode_IHandler ()
		{
			if (cb_setResponseCode_I == null)
				cb_setResponseCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetResponseCode_I);
			return cb_setResponseCode_I;
		}

		static void n_SetResponseCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResponseCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseCode;
		static IntPtr id_setResponseCode_I;
		public virtual unsafe int ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register ("getResponseCode", "()I", "GetGetResponseCodeHandler")]
			get {
				if (id_getResponseCode == IntPtr.Zero)
					id_getResponseCode = JNIEnv.GetMethodID (class_ref, "getResponseCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getResponseCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseCode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='setResponseCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResponseCode", "(I)V", "GetSetResponseCode_IHandler")]
			set {
				if (id_setResponseCode_I == IntPtr.Zero)
					id_setResponseCode_I = JNIEnv.GetMethodID (class_ref, "setResponseCode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseCode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseCode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Url = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		static IntPtr id_setUrl_Ljava_lang_String_;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_fromJson_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Lcom/instabug/library/model/NetworkLog;", "")]
		public static unsafe global::Com.Instabug.Library.Model.NetworkLog FromJson (string p0)
		{
			if (id_fromJson_Ljava_lang_String_ == IntPtr.Zero)
				id_fromJson_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromJson", "(Ljava/lang/String;)Lcom/instabug/library/model/NetworkLog;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.Model.NetworkLog __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromJson_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_insert_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInsert_Landroid_content_Context_Handler ()
		{
			if (cb_insert_Landroid_content_Context_ == null)
				cb_insert_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_Insert_Landroid_content_Context_);
			return cb_insert_Landroid_content_Context_;
		}

		static long n_Insert_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Insert (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("insert", "(Landroid/content/Context;)J", "GetInsert_Landroid_content_Context_Handler")]
		public virtual unsafe long Insert (global::Android.Content.Context p0)
		{
			if (id_insert_Landroid_content_Context_ == IntPtr.Zero)
				id_insert_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "insert", "(Landroid/content/Context;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_insert_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(Landroid/content/Context;)J"), __args);
				return __ret;
			} finally {
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
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJson ());
		}
#pragma warning restore 0169

		static IntPtr id_toJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Ljava/lang/String;", "GetToJsonHandler")]
		public virtual unsafe string ToJson ()
		{
			if (id_toJson == IntPtr.Zero)
				id_toJson = JNIEnv.GetMethodID (class_ref, "toJson", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJson", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toJsonObject;
#pragma warning disable 0169
		static Delegate GetToJsonObjectHandler ()
		{
			if (cb_toJsonObject == null)
				cb_toJsonObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJsonObject);
			return cb_toJsonObject;
		}

		static IntPtr n_ToJsonObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Model.NetworkLog __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.NetworkLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJsonObject ());
		}
#pragma warning restore 0169

		static IntPtr id_toJsonObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='NetworkLog']/method[@name='toJsonObject' and count(parameter)=0]"
		[Register ("toJsonObject", "()Lorg/json/JSONObject;", "GetToJsonObjectHandler")]
		public virtual unsafe global::Org.Json.JSONObject ToJsonObject ()
		{
			if (id_toJsonObject == IntPtr.Zero)
				id_toJsonObject = JNIEnv.GetMethodID (class_ref, "toJsonObject", "()Lorg/json/JSONObject;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJsonObject), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJsonObject", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
