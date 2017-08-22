using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Internal.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']"
	[global::Android.Runtime.Register ("com/instabug/library/internal/module/InstabugLocale", DoNotGenerateAcw=true)]
	public sealed partial class InstabugLocale : global::Java.Lang.Enum {


		static IntPtr ARABIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='ARABIC']"
		[Register ("ARABIC")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale Arabic {
			get {
				if (ARABIC_jfieldId == IntPtr.Zero)
					ARABIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ARABIC", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ARABIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CZECH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='CZECH']"
		[Register ("CZECH")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale Czech {
			get {
				if (CZECH_jfieldId == IntPtr.Zero)
					CZECH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CZECH", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CZECH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ENGLISH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='ENGLISH']"
		[Register ("ENGLISH")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale English {
			get {
				if (ENGLISH_jfieldId == IntPtr.Zero)
					ENGLISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENGLISH", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENGLISH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FRENCH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='FRENCH']"
		[Register ("FRENCH")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale French {
			get {
				if (FRENCH_jfieldId == IntPtr.Zero)
					FRENCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRENCH", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRENCH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GERMAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='GERMAN']"
		[Register ("GERMAN")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale German {
			get {
				if (GERMAN_jfieldId == IntPtr.Zero)
					GERMAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GERMAN", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GERMAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ITALIAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='ITALIAN']"
		[Register ("ITALIAN")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale Italian {
			get {
				if (ITALIAN_jfieldId == IntPtr.Zero)
					ITALIAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ITALIAN", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ITALIAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAPANESE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='JAPANESE']"
		[Register ("JAPANESE")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale Japanese {
			get {
				if (JAPANESE_jfieldId == IntPtr.Zero)
					JAPANESE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAPANESE", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAPANESE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr KOREAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='KOREAN']"
		[Register ("KOREAN")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale Korean {
			get {
				if (KOREAN_jfieldId == IntPtr.Zero)
					KOREAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KOREAN", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KOREAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PERSIAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='PERSIAN']"
		[Register ("PERSIAN")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale Persian {
			get {
				if (PERSIAN_jfieldId == IntPtr.Zero)
					PERSIAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERSIAN", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERSIAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr POLISH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='POLISH']"
		[Register ("POLISH")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale Polish {
			get {
				if (POLISH_jfieldId == IntPtr.Zero)
					POLISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POLISH", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POLISH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PORTUGUESE_BRAZIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='PORTUGUESE_BRAZIL']"
		[Register ("PORTUGUESE_BRAZIL")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale PortugueseBrazil {
			get {
				if (PORTUGUESE_BRAZIL_jfieldId == IntPtr.Zero)
					PORTUGUESE_BRAZIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PORTUGUESE_BRAZIL", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PORTUGUESE_BRAZIL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PORTUGUESE_PORTUGAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='PORTUGUESE_PORTUGAL']"
		[Register ("PORTUGUESE_PORTUGAL")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale PortuguesePortugal {
			get {
				if (PORTUGUESE_PORTUGAL_jfieldId == IntPtr.Zero)
					PORTUGUESE_PORTUGAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PORTUGUESE_PORTUGAL", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PORTUGUESE_PORTUGAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RUSSIAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='RUSSIAN']"
		[Register ("RUSSIAN")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale Russian {
			get {
				if (RUSSIAN_jfieldId == IntPtr.Zero)
					RUSSIAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RUSSIAN", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RUSSIAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIMPLIFIED_CHINESE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='SIMPLIFIED_CHINESE']"
		[Register ("SIMPLIFIED_CHINESE")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale SimplifiedChinese {
			get {
				if (SIMPLIFIED_CHINESE_jfieldId == IntPtr.Zero)
					SIMPLIFIED_CHINESE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIMPLIFIED_CHINESE", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIMPLIFIED_CHINESE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SPANISH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='SPANISH']"
		[Register ("SPANISH")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale Spanish {
			get {
				if (SPANISH_jfieldId == IntPtr.Zero)
					SPANISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPANISH", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPANISH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SWEDISH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='SWEDISH']"
		[Register ("SWEDISH")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale Swedish {
			get {
				if (SWEDISH_jfieldId == IntPtr.Zero)
					SWEDISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SWEDISH", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SWEDISH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TRADITIONAL_CHINESE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='TRADITIONAL_CHINESE']"
		[Register ("TRADITIONAL_CHINESE")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale TraditionalChinese {
			get {
				if (TRADITIONAL_CHINESE_jfieldId == IntPtr.Zero)
					TRADITIONAL_CHINESE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRADITIONAL_CHINESE", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRADITIONAL_CHINESE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TURKISH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/field[@name='TURKISH']"
		[Register ("TURKISH")]
		public static global::Com.Instabug.Library.Internal.Module.InstabugLocale Turkish {
			get {
				if (TURKISH_jfieldId == IntPtr.Zero)
					TURKISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TURKISH", "Lcom/instabug/library/internal/module/InstabugLocale;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TURKISH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/internal/module/InstabugLocale", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugLocale); }
		}

		internal InstabugLocale (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCode;
		public unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/String;", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCode), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCountry;
		public unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				if (id_getCountry == IntPtr.Zero)
					id_getCountry = JNIEnv.GetMethodID (class_ref, "getCountry", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCountry), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/internal/module/InstabugLocale;", "")]
		public static unsafe global::Com.Instabug.Library.Internal.Module.InstabugLocale ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/internal/module/InstabugLocale;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.Internal.Module.InstabugLocale __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Module.InstabugLocale> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.module']/class[@name='InstabugLocale']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/internal/module/InstabugLocale;", "")]
		public static unsafe global::Com.Instabug.Library.Internal.Module.InstabugLocale[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/internal/module/InstabugLocale;");
			try {
				return (global::Com.Instabug.Library.Internal.Module.InstabugLocale[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.Internal.Module.InstabugLocale));
			} finally {
			}
		}

	}
}
