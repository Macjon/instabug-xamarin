using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Analytics.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']"
	[global::Android.Runtime.Register ("com/instabug/library/analytics/model/Api", DoNotGenerateAcw=true)]
	public partial class Api : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']"
		[global::Android.Runtime.Register ("com/instabug/library/analytics/model/Api$Parameter", DoNotGenerateAcw=true)]
		public partial class Parameter : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/instabug/library/analytics/model/Api$Parameter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Parameter); }
			}

			protected Parameter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']/constructor[@name='Api.Parameter' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Parameter ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Parameter)) {
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

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.Analytics.Model.Api.Parameter __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			static IntPtr id_getName;
			public virtual unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
				return cb_getType;
			}

			static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.Analytics.Model.Api.Parameter __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Type);
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public virtual unsafe string Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Instabug.Library.Analytics.Model.Api.Parameter __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Value);
			}
#pragma warning restore 0169

			static IntPtr id_getValue;
			public virtual unsafe string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']/method[@name='getValue' and count(parameter)=0]"
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

			static IntPtr id_fromJson_Lorg_json_JSONArray_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
			[Register ("fromJson", "(Lorg/json/JSONArray;)Ljava/util/ArrayList;", "")]
			public static unsafe global::System.Collections.Generic.IList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> FromJson (global::Org.Json.JSONArray p0)
			{
				if (id_fromJson_Lorg_json_JSONArray_ == IntPtr.Zero)
					id_fromJson_Lorg_json_JSONArray_ = JNIEnv.GetStaticMethodID (class_ref, "fromJson", "(Lorg/json/JSONArray;)Ljava/util/ArrayList;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::System.Collections.Generic.IList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> __ret = global::Android.Runtime.JavaList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromJson_Lorg_json_JSONArray_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_fromJson_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("fromJson", "(Lorg/json/JSONObject;)Lcom/instabug/library/analytics/model/Api$Parameter;", "")]
			public static unsafe global::Com.Instabug.Library.Analytics.Model.Api.Parameter FromJson (global::Org.Json.JSONObject p0)
			{
				if (id_fromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_fromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "fromJson", "(Lorg/json/JSONObject;)Lcom/instabug/library/analytics/model/Api$Parameter;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Instabug.Library.Analytics.Model.Api.Parameter __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromJson_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetName_Ljava_lang_String_Handler ()
			{
				if (cb_setName_Ljava_lang_String_ == null)
					cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
				return cb_setName_Ljava_lang_String_;
			}

			static IntPtr n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Analytics.Model.Api.Parameter __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)Lcom/instabug/library/analytics/model/Api$Parameter;", "GetSetName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Analytics.Model.Api.Parameter SetName (string p0)
			{
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)Lcom/instabug/library/analytics/model/Api$Parameter;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Instabug.Library.Analytics.Model.Api.Parameter __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)Lcom/instabug/library/analytics/model/Api$Parameter;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setType_Ljava_lang_Class_;
#pragma warning disable 0169
			static Delegate GetSetType_Ljava_lang_Class_Handler ()
			{
				if (cb_setType_Ljava_lang_Class_ == null)
					cb_setType_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_Class_);
				return cb_setType_Ljava_lang_Class_;
			}

			static IntPtr n_SetType_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Analytics.Model.Api.Parameter __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetType (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setType_Ljava_lang_Class_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
			[Register ("setType", "(Ljava/lang/Class;)Lcom/instabug/library/analytics/model/Api$Parameter;", "GetSetType_Ljava_lang_Class_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Analytics.Model.Api.Parameter SetType (global::Java.Lang.Class p0)
			{
				if (id_setType_Ljava_lang_Class_ == IntPtr.Zero)
					id_setType_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/Class;)Lcom/instabug/library/analytics/model/Api$Parameter;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Analytics.Model.Api.Parameter __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/Class;)Lcom/instabug/library/analytics/model/Api$Parameter;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setValue_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSetValue_Ljava_lang_Object_Handler ()
			{
				if (cb_setValue_Ljava_lang_Object_ == null)
					cb_setValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_Object_);
				return cb_setValue_Ljava_lang_Object_;
			}

			static IntPtr n_SetValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Analytics.Model.Api.Parameter __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetValue (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setValue_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setValue", "(Ljava/lang/Object;)Lcom/instabug/library/analytics/model/Api$Parameter;", "GetSetValue_Ljava_lang_Object_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Analytics.Model.Api.Parameter SetValue (global::Java.Lang.Object p0)
			{
				if (id_setValue_Ljava_lang_Object_ == IntPtr.Zero)
					id_setValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Object;)Lcom/instabug/library/analytics/model/Api$Parameter;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Analytics.Model.Api.Parameter __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/Object;)Lcom/instabug/library/analytics/model/Api$Parameter;"), __args), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Instabug.Library.Analytics.Model.Api.Parameter __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ToJson ());
			}
#pragma warning restore 0169

			static IntPtr id_toJson;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']/method[@name='toJson' and count(parameter)=0]"
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

			static IntPtr id_toJson_Ljava_util_ArrayList_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api.Parameter']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.instabug.library.analytics.model.Api.Parameter&gt;']]"
			[Register ("toJson", "(Ljava/util/ArrayList;)Lorg/json/JSONArray;", "")]
			public static unsafe global::Org.Json.JSONArray ToJson (global::System.Collections.Generic.IList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> p0)
			{
				if (id_toJson_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_toJson_Ljava_util_ArrayList_ = JNIEnv.GetStaticMethodID (class_ref, "toJson", "(Ljava/util/ArrayList;)Lorg/json/JSONArray;");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Json.JSONArray __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toJson_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/analytics/model/Api", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Api); }
		}

		protected Api (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']/constructor[@name='Api' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Api ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Api)) {
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

		static Delegate cb_getApiName;
#pragma warning disable 0169
		static Delegate GetGetApiNameHandler ()
		{
			if (cb_getApiName == null)
				cb_getApiName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApiName);
			return cb_getApiName;
		}

		static IntPtr n_GetApiName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Analytics.Model.Api __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApiName);
		}
#pragma warning restore 0169

		static IntPtr id_getApiName;
		public virtual unsafe string ApiName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']/method[@name='getApiName' and count(parameter)=0]"
			[Register ("getApiName", "()Ljava/lang/String;", "GetGetApiNameHandler")]
			get {
				if (id_getApiName == IntPtr.Zero)
					id_getApiName = JNIEnv.GetMethodID (class_ref, "getApiName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApiName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApiName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDeprecated;
#pragma warning disable 0169
		static Delegate GetIsDeprecatedHandler ()
		{
			if (cb_isDeprecated == null)
				cb_isDeprecated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeprecated);
			return cb_isDeprecated;
		}

		static bool n_IsDeprecated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Analytics.Model.Api __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeprecated;
		}
#pragma warning restore 0169

		static IntPtr id_isDeprecated;
		public virtual unsafe bool IsDeprecated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']/method[@name='isDeprecated' and count(parameter)=0]"
			[Register ("isDeprecated", "()Z", "GetIsDeprecatedHandler")]
			get {
				if (id_isDeprecated == IntPtr.Zero)
					id_isDeprecated = JNIEnv.GetMethodID (class_ref, "isDeprecated", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDeprecated);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeprecated", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getParameters;
#pragma warning disable 0169
		static Delegate GetGetParametersHandler ()
		{
			if (cb_getParameters == null)
				cb_getParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParameters);
			return cb_getParameters;
		}

		static IntPtr n_GetParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Analytics.Model.Api __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter>.ToLocalJniHandle (__this.Parameters);
		}
#pragma warning restore 0169

		static IntPtr id_getParameters;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> Parameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']/method[@name='getParameters' and count(parameter)=0]"
			[Register ("getParameters", "()Ljava/util/ArrayList;", "GetGetParametersHandler")]
			get {
				if (id_getParameters == IntPtr.Zero)
					id_getParameters = JNIEnv.GetMethodID (class_ref, "getParameters", "()Ljava/util/ArrayList;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParameters", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetTimeStampHandler ()
		{
			if (cb_getTimeStamp == null)
				cb_getTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeStamp);
			return cb_getTimeStamp;
		}

		static long n_GetTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Analytics.Model.Api __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public virtual unsafe long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()J", "GetGetTimeStampHandler")]
			get {
				if (id_getTimeStamp == IntPtr.Zero)
					id_getTimeStamp = JNIEnv.GetMethodID (class_ref, "getTimeStamp", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimeStamp);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeStamp", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_setApiName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApiName_Ljava_lang_String_Handler ()
		{
			if (cb_setApiName_Ljava_lang_String_ == null)
				cb_setApiName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetApiName_Ljava_lang_String_);
			return cb_setApiName_Ljava_lang_String_;
		}

		static IntPtr n_SetApiName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Analytics.Model.Api __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetApiName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setApiName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']/method[@name='setApiName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setApiName", "(Ljava/lang/String;)Lcom/instabug/library/analytics/model/Api;", "GetSetApiName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Instabug.Library.Analytics.Model.Api SetApiName (string p0)
		{
			if (id_setApiName_Ljava_lang_String_ == IntPtr.Zero)
				id_setApiName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApiName", "(Ljava/lang/String;)Lcom/instabug/library/analytics/model/Api;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Instabug.Library.Analytics.Model.Api __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setApiName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApiName", "(Ljava/lang/String;)Lcom/instabug/library/analytics/model/Api;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDeprecated_Z;
#pragma warning disable 0169
		static Delegate GetSetDeprecated_ZHandler ()
		{
			if (cb_setDeprecated_Z == null)
				cb_setDeprecated_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDeprecated_Z);
			return cb_setDeprecated_Z;
		}

		static IntPtr n_SetDeprecated_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Instabug.Library.Analytics.Model.Api __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDeprecated (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setDeprecated_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']/method[@name='setDeprecated' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDeprecated", "(Z)Lcom/instabug/library/analytics/model/Api;", "GetSetDeprecated_ZHandler")]
		public virtual unsafe global::Com.Instabug.Library.Analytics.Model.Api SetDeprecated (bool p0)
		{
			if (id_setDeprecated_Z == IntPtr.Zero)
				id_setDeprecated_Z = JNIEnv.GetMethodID (class_ref, "setDeprecated", "(Z)Lcom/instabug/library/analytics/model/Api;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDeprecated_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeprecated", "(Z)Lcom/instabug/library/analytics/model/Api;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setParameters_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetParameters_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setParameters_Ljava_util_ArrayList_ == null)
				cb_setParameters_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetParameters_Ljava_util_ArrayList_);
			return cb_setParameters_Ljava_util_ArrayList_;
		}

		static IntPtr n_SetParameters_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Analytics.Model.Api __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetParameters (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setParameters_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']/method[@name='setParameters' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.instabug.library.analytics.model.Api.Parameter&gt;']]"
		[Register ("setParameters", "(Ljava/util/ArrayList;)Lcom/instabug/library/analytics/model/Api;", "GetSetParameters_Ljava_util_ArrayList_Handler")]
		public virtual unsafe global::Com.Instabug.Library.Analytics.Model.Api SetParameters (global::System.Collections.Generic.IList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter> p0)
		{
			if (id_setParameters_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_setParameters_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "setParameters", "(Ljava/util/ArrayList;)Lcom/instabug/library/analytics/model/Api;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Instabug.Library.Analytics.Model.Api.Parameter>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Instabug.Library.Analytics.Model.Api __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setParameters_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParameters", "(Ljava/util/ArrayList;)Lcom/instabug/library/analytics/model/Api;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTimeStamp_J;
#pragma warning disable 0169
		static Delegate GetSetTimeStamp_JHandler ()
		{
			if (cb_setTimeStamp_J == null)
				cb_setTimeStamp_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetTimeStamp_J);
			return cb_setTimeStamp_J;
		}

		static IntPtr n_SetTimeStamp_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Instabug.Library.Analytics.Model.Api __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTimeStamp (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setTimeStamp_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']/method[@name='setTimeStamp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTimeStamp", "(J)Lcom/instabug/library/analytics/model/Api;", "GetSetTimeStamp_JHandler")]
		public virtual unsafe global::Com.Instabug.Library.Analytics.Model.Api SetTimeStamp (long p0)
		{
			if (id_setTimeStamp_J == IntPtr.Zero)
				id_setTimeStamp_J = JNIEnv.GetMethodID (class_ref, "setTimeStamp", "(J)Lcom/instabug/library/analytics/model/Api;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTimeStamp_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeStamp", "(J)Lcom/instabug/library/analytics/model/Api;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Instabug.Library.Analytics.Model.Api __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Analytics.Model.Api> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJson ());
		}
#pragma warning restore 0169

		static IntPtr id_toJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']/method[@name='toJson' and count(parameter)=0]"
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

		static IntPtr id_toJson_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.model']/class[@name='Api']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.instabug.library.analytics.model.Api&gt;']]"
		[Register ("toJson", "(Ljava/util/ArrayList;)Lorg/json/JSONArray;", "")]
		public static unsafe global::Org.Json.JSONArray ToJson (global::System.Collections.Generic.IList<global::Com.Instabug.Library.Analytics.Model.Api> p0)
		{
			if (id_toJson_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_toJson_Ljava_util_ArrayList_ = JNIEnv.GetStaticMethodID (class_ref, "toJson", "(Ljava/util/ArrayList;)Lorg/json/JSONArray;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Instabug.Library.Analytics.Model.Api>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Json.JSONArray __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toJson_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
