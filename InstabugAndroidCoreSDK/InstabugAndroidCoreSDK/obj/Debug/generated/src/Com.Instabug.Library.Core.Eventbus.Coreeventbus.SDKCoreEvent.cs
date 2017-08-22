using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Core.Eventbus.Coreeventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.core.eventbus.coreeventbus']/class[@name='SDKCoreEvent']"
	[global::Android.Runtime.Register ("com/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent", DoNotGenerateAcw=true)]
	public sealed partial class SDKCoreEvent : global::Java.Lang.Enum {


		static IntPtr FEATURES_FETCHED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.core.eventbus.coreeventbus']/class[@name='SDKCoreEvent']/field[@name='FEATURES_FETCHED']"
		[Register ("FEATURES_FETCHED")]
		public static global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent FeaturesFetched {
			get {
				if (FEATURES_FETCHED_jfieldId == IntPtr.Zero)
					FEATURES_FETCHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FEATURES_FETCHED", "Lcom/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FEATURES_FETCHED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NETWORK_ACTIVATED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.core.eventbus.coreeventbus']/class[@name='SDKCoreEvent']/field[@name='NETWORK_ACTIVATED']"
		[Register ("NETWORK_ACTIVATED")]
		public static global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent NetworkActivated {
			get {
				if (NETWORK_ACTIVATED_jfieldId == IntPtr.Zero)
					NETWORK_ACTIVATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ACTIVATED", "Lcom/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_ACTIVATED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SESSION_FINISHED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.core.eventbus.coreeventbus']/class[@name='SDKCoreEvent']/field[@name='SESSION_FINISHED']"
		[Register ("SESSION_FINISHED")]
		public static global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent SessionFinished {
			get {
				if (SESSION_FINISHED_jfieldId == IntPtr.Zero)
					SESSION_FINISHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_FINISHED", "Lcom/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_FINISHED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SESSION_STARTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.core.eventbus.coreeventbus']/class[@name='SDKCoreEvent']/field[@name='SESSION_STARTED']"
		[Register ("SESSION_STARTED")]
		public static global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent SessionStarted {
			get {
				if (SESSION_STARTED_jfieldId == IntPtr.Zero)
					SESSION_STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_STARTED", "Lcom/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_STARTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USER_LOGGED_IN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.core.eventbus.coreeventbus']/class[@name='SDKCoreEvent']/field[@name='USER_LOGGED_IN']"
		[Register ("USER_LOGGED_IN")]
		public static global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent UserLoggedIn {
			get {
				if (USER_LOGGED_IN_jfieldId == IntPtr.Zero)
					USER_LOGGED_IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_LOGGED_IN", "Lcom/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_LOGGED_IN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USER_LOGGED_OUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.core.eventbus.coreeventbus']/class[@name='SDKCoreEvent']/field[@name='USER_LOGGED_OUT']"
		[Register ("USER_LOGGED_OUT")]
		public static global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent UserLoggedOut {
			get {
				if (USER_LOGGED_OUT_jfieldId == IntPtr.Zero)
					USER_LOGGED_OUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_LOGGED_OUT", "Lcom/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_LOGGED_OUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SDKCoreEvent); }
		}

		internal SDKCoreEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core.eventbus.coreeventbus']/class[@name='SDKCoreEvent']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent;", "")]
		public static unsafe global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core.eventbus.coreeventbus']/class[@name='SDKCoreEvent']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent;", "")]
		public static unsafe global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/core/eventbus/coreeventbus/SDKCoreEvent;");
			try {
				return (global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.Core.Eventbus.Coreeventbus.SDKCoreEvent));
			} finally {
			}
		}

	}
}
