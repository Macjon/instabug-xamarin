using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Aac {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/aac/BlockType", DoNotGenerateAcw=true)]
	public sealed partial class BlockType : global::Java.Lang.Enum {


		static IntPtr TYPE_CCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/field[@name='TYPE_CCE']"
		[Register ("TYPE_CCE")]
		public static global::Org.Jcodec.Codecs.Aac.BlockType TypeCce {
			get {
				if (TYPE_CCE_jfieldId == IntPtr.Zero)
					TYPE_CCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_CCE", "Lorg/jcodec/codecs/aac/BlockType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_CCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TYPE_CPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/field[@name='TYPE_CPE']"
		[Register ("TYPE_CPE")]
		public static global::Org.Jcodec.Codecs.Aac.BlockType TypeCpe {
			get {
				if (TYPE_CPE_jfieldId == IntPtr.Zero)
					TYPE_CPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_CPE", "Lorg/jcodec/codecs/aac/BlockType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_CPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TYPE_DSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/field[@name='TYPE_DSE']"
		[Register ("TYPE_DSE")]
		public static global::Org.Jcodec.Codecs.Aac.BlockType TypeDse {
			get {
				if (TYPE_DSE_jfieldId == IntPtr.Zero)
					TYPE_DSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_DSE", "Lorg/jcodec/codecs/aac/BlockType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_DSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TYPE_END_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/field[@name='TYPE_END']"
		[Register ("TYPE_END")]
		public static global::Org.Jcodec.Codecs.Aac.BlockType TypeEnd {
			get {
				if (TYPE_END_jfieldId == IntPtr.Zero)
					TYPE_END_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_END", "Lorg/jcodec/codecs/aac/BlockType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_END_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TYPE_FIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/field[@name='TYPE_FIL']"
		[Register ("TYPE_FIL")]
		public static global::Org.Jcodec.Codecs.Aac.BlockType TypeFil {
			get {
				if (TYPE_FIL_jfieldId == IntPtr.Zero)
					TYPE_FIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_FIL", "Lorg/jcodec/codecs/aac/BlockType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_FIL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TYPE_LFE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/field[@name='TYPE_LFE']"
		[Register ("TYPE_LFE")]
		public static global::Org.Jcodec.Codecs.Aac.BlockType TypeLfe {
			get {
				if (TYPE_LFE_jfieldId == IntPtr.Zero)
					TYPE_LFE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_LFE", "Lorg/jcodec/codecs/aac/BlockType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_LFE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TYPE_PCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/field[@name='TYPE_PCE']"
		[Register ("TYPE_PCE")]
		public static global::Org.Jcodec.Codecs.Aac.BlockType TypePce {
			get {
				if (TYPE_PCE_jfieldId == IntPtr.Zero)
					TYPE_PCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_PCE", "Lorg/jcodec/codecs/aac/BlockType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_PCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TYPE_SCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/field[@name='TYPE_SCE']"
		[Register ("TYPE_SCE")]
		public static global::Org.Jcodec.Codecs.Aac.BlockType TypeSce {
			get {
				if (TYPE_SCE_jfieldId == IntPtr.Zero)
					TYPE_SCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_SCE", "Lorg/jcodec/codecs/aac/BlockType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_SCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/aac/BlockType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockType); }
		}

		internal BlockType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCode;
		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCode);
				} finally {
				}
			}
		}

		static IntPtr id_fromCode_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/method[@name='fromCode' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("fromCode", "(J)Lorg/jcodec/codecs/aac/BlockType;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Aac.BlockType FromCode (long p0)
		{
			if (id_fromCode_J == IntPtr.Zero)
				id_fromCode_J = JNIEnv.GetStaticMethodID (class_ref, "fromCode", "(J)Lorg/jcodec/codecs/aac/BlockType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCode_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/aac/BlockType;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Aac.BlockType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/aac/BlockType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Codecs.Aac.BlockType __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/jcodec/codecs/aac/BlockType;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Aac.BlockType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/codecs/aac/BlockType;");
			try {
				return (global::Org.Jcodec.Codecs.Aac.BlockType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Codecs.Aac.BlockType));
			} finally {
			}
		}

	}
}
