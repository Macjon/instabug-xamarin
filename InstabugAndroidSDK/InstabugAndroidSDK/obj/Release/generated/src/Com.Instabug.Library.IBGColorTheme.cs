using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGColorTheme']"
	[global::Android.Runtime.Register ("com/instabug/library/IBGColorTheme", DoNotGenerateAcw=true)]
	public sealed partial class IBGColorTheme : global::Java.Lang.Enum {


		static IntPtr IBGColorThemeDark_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGColorTheme']/field[@name='IBGColorThemeDark']"
		[Register ("IBGColorThemeDark")]
		public static global::Com.Instabug.Library.IBGColorTheme IBGColorThemeDark {
			get {
				if (IBGColorThemeDark_jfieldId == IntPtr.Zero)
					IBGColorThemeDark_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IBGColorThemeDark", "Lcom/instabug/library/IBGColorTheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IBGColorThemeDark_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGColorTheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IBGColorThemeLight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGColorTheme']/field[@name='IBGColorThemeLight']"
		[Register ("IBGColorThemeLight")]
		public static global::Com.Instabug.Library.IBGColorTheme IBGColorThemeLight {
			get {
				if (IBGColorThemeLight_jfieldId == IntPtr.Zero)
					IBGColorThemeLight_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IBGColorThemeLight", "Lcom/instabug/library/IBGColorTheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IBGColorThemeLight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGColorTheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr theme_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGColorTheme']/field[@name='theme']"
		[Register ("theme")]
		public static global::Com.Instabug.Library.IBGColorTheme Theme {
			get {
				if (theme_jfieldId == IntPtr.Zero)
					theme_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "theme", "Lcom/instabug/library/IBGColorTheme;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, theme_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGColorTheme> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/IBGColorTheme", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBGColorTheme); }
		}

		internal IBGColorTheme (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGColorTheme']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/IBGColorTheme;", "")]
		public static unsafe global::Com.Instabug.Library.IBGColorTheme ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/IBGColorTheme;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.IBGColorTheme __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGColorTheme> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGColorTheme']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/IBGColorTheme;", "")]
		public static unsafe global::Com.Instabug.Library.IBGColorTheme[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/IBGColorTheme;");
			try {
				return (global::Com.Instabug.Library.IBGColorTheme[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.IBGColorTheme));
			} finally {
			}
		}

	}
}
