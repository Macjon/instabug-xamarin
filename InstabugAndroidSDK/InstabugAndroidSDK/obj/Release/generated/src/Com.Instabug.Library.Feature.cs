using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']"
	[global::Android.Runtime.Register ("com/instabug/library/Feature", DoNotGenerateAcw=true)]
	public sealed partial class Feature : global::Java.Lang.Enum {


		static IntPtr CONSOLE_LOGS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/field[@name='CONSOLE_LOGS']"
		[Register ("CONSOLE_LOGS")]
		public static global::Com.Instabug.Library.Feature ConsoleLogs {
			get {
				if (CONSOLE_LOGS_jfieldId == IntPtr.Zero)
					CONSOLE_LOGS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSOLE_LOGS", "Lcom/instabug/library/Feature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSOLE_LOGS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CRASH_REPORTING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/field[@name='CRASH_REPORTING']"
		[Register ("CRASH_REPORTING")]
		public static global::Com.Instabug.Library.Feature CrashReporting {
			get {
				if (CRASH_REPORTING_jfieldId == IntPtr.Zero)
					CRASH_REPORTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CRASH_REPORTING", "Lcom/instabug/library/Feature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CRASH_REPORTING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INSTABUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/field[@name='INSTABUG']"
		[Register ("INSTABUG")]
		public static global::Com.Instabug.Library.Feature Instabug {
			get {
				if (INSTABUG_jfieldId == IntPtr.Zero)
					INSTABUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTABUG", "Lcom/instabug/library/Feature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTABUG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INSTABUG_LOGS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/field[@name='INSTABUG_LOGS']"
		[Register ("INSTABUG_LOGS")]
		public static global::Com.Instabug.Library.Feature InstabugLogs {
			get {
				if (INSTABUG_LOGS_jfieldId == IntPtr.Zero)
					INSTABUG_LOGS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTABUG_LOGS", "Lcom/instabug/library/Feature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTABUG_LOGS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IN_APP_MESSAGING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/field[@name='IN_APP_MESSAGING']"
		[Register ("IN_APP_MESSAGING")]
		public static global::Com.Instabug.Library.Feature InAppMessaging {
			get {
				if (IN_APP_MESSAGING_jfieldId == IntPtr.Zero)
					IN_APP_MESSAGING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IN_APP_MESSAGING", "Lcom/instabug/library/Feature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IN_APP_MESSAGING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MULTIPLE_ATTACHMENTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/field[@name='MULTIPLE_ATTACHMENTS']"
		[Register ("MULTIPLE_ATTACHMENTS")]
		public static global::Com.Instabug.Library.Feature MultipleAttachments {
			get {
				if (MULTIPLE_ATTACHMENTS_jfieldId == IntPtr.Zero)
					MULTIPLE_ATTACHMENTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MULTIPLE_ATTACHMENTS", "Lcom/instabug/library/Feature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MULTIPLE_ATTACHMENTS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PUSH_NOTIFICATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/field[@name='PUSH_NOTIFICATION']"
		[Register ("PUSH_NOTIFICATION")]
		public static global::Com.Instabug.Library.Feature PushNotification {
			get {
				if (PUSH_NOTIFICATION_jfieldId == IntPtr.Zero)
					PUSH_NOTIFICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUSH_NOTIFICATION", "Lcom/instabug/library/Feature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUSH_NOTIFICATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TRACK_USER_STEPS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/field[@name='TRACK_USER_STEPS']"
		[Register ("TRACK_USER_STEPS")]
		public static global::Com.Instabug.Library.Feature TrackUserSteps {
			get {
				if (TRACK_USER_STEPS_jfieldId == IntPtr.Zero)
					TRACK_USER_STEPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACK_USER_STEPS", "Lcom/instabug/library/Feature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACK_USER_STEPS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USER_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/field[@name='USER_DATA']"
		[Register ("USER_DATA")]
		public static global::Com.Instabug.Library.Feature UserData {
			get {
				if (USER_DATA_jfieldId == IntPtr.Zero)
					USER_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_DATA", "Lcom/instabug/library/Feature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WHITE_LABELING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/field[@name='WHITE_LABELING']"
		[Register ("WHITE_LABELING")]
		public static global::Com.Instabug.Library.Feature WhiteLabeling {
			get {
				if (WHITE_LABELING_jfieldId == IntPtr.Zero)
					WHITE_LABELING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WHITE_LABELING", "Lcom/instabug/library/Feature;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WHITE_LABELING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature.State']"
		[global::Android.Runtime.Register ("com/instabug/library/Feature$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr DISABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature.State']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Com.Instabug.Library.Feature.State Disabled {
				get {
					if (DISABLED_jfieldId == IntPtr.Zero)
						DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISABLED", "Lcom/instabug/library/Feature$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ENABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature.State']/field[@name='ENABLED']"
			[Register ("ENABLED")]
			public static global::Com.Instabug.Library.Feature.State Enabled {
				get {
					if (ENABLED_jfieldId == IntPtr.Zero)
						ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENABLED", "Lcom/instabug/library/Feature$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/instabug/library/Feature$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/Feature$State;", "")]
			public static unsafe global::Com.Instabug.Library.Feature.State ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/Feature$State;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Instabug.Library.Feature.State __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/instabug/library/Feature$State;", "")]
			public static unsafe global::Com.Instabug.Library.Feature.State[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/Feature$State;");
				try {
					return (global::Com.Instabug.Library.Feature.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.Feature.State));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/Feature", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Feature); }
		}

		internal Feature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/Feature;", "")]
		public static unsafe global::Com.Instabug.Library.Feature ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/Feature;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.Feature __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Feature']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/Feature;", "")]
		public static unsafe global::Com.Instabug.Library.Feature[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/Feature;");
			try {
				return (global::Com.Instabug.Library.Feature[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.Feature));
			} finally {
			}
		}

	}
}
