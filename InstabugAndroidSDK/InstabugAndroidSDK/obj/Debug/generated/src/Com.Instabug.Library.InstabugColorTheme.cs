using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugColorTheme']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugColorTheme", DoNotGenerateAcw=true)]
	public sealed partial class InstabugColorTheme : global::Java.Lang.Enum {


		static IntPtr InstabugColorThemeDark_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugColorTheme']/field[@name='InstabugColorThemeDark']"
		[Register ("InstabugColorThemeDark")]
		public static global::Com.Instabug.Library.InstabugColorTheme InstabugColorThemeDark {
			get {
				if (InstabugColorThemeDark_jfieldId == IntPtr.Zero)
					InstabugColorThemeDark_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InstabugColorThemeDark", "Lcom/instabug/library/InstabugColorTheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InstabugColorThemeDark_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugColorTheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr InstabugColorThemeLight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugColorTheme']/field[@name='InstabugColorThemeLight']"
		[Register ("InstabugColorThemeLight")]
		public static global::Com.Instabug.Library.InstabugColorTheme InstabugColorThemeLight {
			get {
				if (InstabugColorThemeLight_jfieldId == IntPtr.Zero)
					InstabugColorThemeLight_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InstabugColorThemeLight", "Lcom/instabug/library/InstabugColorTheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InstabugColorThemeLight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugColorTheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugColorTheme", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugColorTheme); }
		}

		internal InstabugColorTheme (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugColorTheme']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/InstabugColorTheme;", "")]
		public static unsafe global::Com.Instabug.Library.InstabugColorTheme ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/InstabugColorTheme;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.InstabugColorTheme __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugColorTheme> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugColorTheme']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/InstabugColorTheme;", "")]
		public static unsafe global::Com.Instabug.Library.InstabugColorTheme[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/InstabugColorTheme;");
			try {
				return (global::Com.Instabug.Library.InstabugColorTheme[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.InstabugColorTheme));
			} finally {
			}
		}

	}
}
