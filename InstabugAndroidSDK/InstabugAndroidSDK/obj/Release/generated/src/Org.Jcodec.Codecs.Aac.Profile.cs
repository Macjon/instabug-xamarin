using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Aac {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='Profile']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/aac/Profile", DoNotGenerateAcw=true)]
	public sealed partial class Profile : global::Java.Lang.Enum {


		static IntPtr LC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='Profile']/field[@name='LC']"
		[Register ("LC")]
		public static global::Org.Jcodec.Codecs.Aac.Profile Lc {
			get {
				if (LC_jfieldId == IntPtr.Zero)
					LC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LC", "Lorg/jcodec/codecs/aac/Profile;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Profile> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MAIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='Profile']/field[@name='MAIN']"
		[Register ("MAIN")]
		public static global::Org.Jcodec.Codecs.Aac.Profile Main {
			get {
				if (MAIN_jfieldId == IntPtr.Zero)
					MAIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAIN", "Lorg/jcodec/codecs/aac/Profile;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAIN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Profile> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OTHER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='Profile']/field[@name='OTHER']"
		[Register ("OTHER")]
		public static global::Org.Jcodec.Codecs.Aac.Profile Other {
			get {
				if (OTHER_jfieldId == IntPtr.Zero)
					OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lorg/jcodec/codecs/aac/Profile;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Profile> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/aac/Profile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Profile); }
		}

		internal Profile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='Profile']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/aac/Profile;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Aac.Profile ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/aac/Profile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Codecs.Aac.Profile __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Profile> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='Profile']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/jcodec/codecs/aac/Profile;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Aac.Profile[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/codecs/aac/Profile;");
			try {
				return (global::Org.Jcodec.Codecs.Aac.Profile[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Codecs.Aac.Profile));
			} finally {
			}
		}

	}
}
