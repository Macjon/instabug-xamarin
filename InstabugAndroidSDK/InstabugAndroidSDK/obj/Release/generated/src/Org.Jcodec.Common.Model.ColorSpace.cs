using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/ColorSpace", DoNotGenerateAcw=true)]
	public sealed partial class ColorSpace : global::Java.Lang.Enum {


		static IntPtr GREY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='GREY']"
		[Register ("GREY")]
		public static global::Org.Jcodec.Common.Model.ColorSpace Grey {
			get {
				if (GREY_jfieldId == IntPtr.Zero)
					GREY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GREY", "Lorg/jcodec/common/model/ColorSpace;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GREY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='MAX_PLANES']"
		[Register ("MAX_PLANES")]
		public const int MaxPlanes = (int) 4;

		static IntPtr MONO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='MONO']"
		[Register ("MONO")]
		public static global::Org.Jcodec.Common.Model.ColorSpace Mono {
			get {
				if (MONO_jfieldId == IntPtr.Zero)
					MONO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MONO", "Lorg/jcodec/common/model/ColorSpace;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MONO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RGB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='RGB']"
		[Register ("RGB")]
		public static global::Org.Jcodec.Common.Model.ColorSpace Rgb {
			get {
				if (RGB_jfieldId == IntPtr.Zero)
					RGB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RGB", "Lorg/jcodec/common/model/ColorSpace;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RGB_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr YUV420_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='YUV420']"
		[Register ("YUV420")]
		public static global::Org.Jcodec.Common.Model.ColorSpace Yuv420 {
			get {
				if (YUV420_jfieldId == IntPtr.Zero)
					YUV420_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YUV420", "Lorg/jcodec/common/model/ColorSpace;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YUV420_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr YUV420J_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='YUV420J']"
		[Register ("YUV420J")]
		public static global::Org.Jcodec.Common.Model.ColorSpace Yuv420j {
			get {
				if (YUV420J_jfieldId == IntPtr.Zero)
					YUV420J_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YUV420J", "Lorg/jcodec/common/model/ColorSpace;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YUV420J_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr YUV422_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='YUV422']"
		[Register ("YUV422")]
		public static global::Org.Jcodec.Common.Model.ColorSpace Yuv422 {
			get {
				if (YUV422_jfieldId == IntPtr.Zero)
					YUV422_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YUV422", "Lorg/jcodec/common/model/ColorSpace;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YUV422_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr YUV422J_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='YUV422J']"
		[Register ("YUV422J")]
		public static global::Org.Jcodec.Common.Model.ColorSpace Yuv422j {
			get {
				if (YUV422J_jfieldId == IntPtr.Zero)
					YUV422J_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YUV422J", "Lorg/jcodec/common/model/ColorSpace;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YUV422J_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr YUV422_10_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='YUV422_10']"
		[Register ("YUV422_10")]
		public static global::Org.Jcodec.Common.Model.ColorSpace Yuv42210 {
			get {
				if (YUV422_10_jfieldId == IntPtr.Zero)
					YUV422_10_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YUV422_10", "Lorg/jcodec/common/model/ColorSpace;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YUV422_10_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr YUV444_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='YUV444']"
		[Register ("YUV444")]
		public static global::Org.Jcodec.Common.Model.ColorSpace Yuv444 {
			get {
				if (YUV444_jfieldId == IntPtr.Zero)
					YUV444_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YUV444", "Lorg/jcodec/common/model/ColorSpace;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YUV444_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr YUV444J_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='YUV444J']"
		[Register ("YUV444J")]
		public static global::Org.Jcodec.Common.Model.ColorSpace Yuv444j {
			get {
				if (YUV444J_jfieldId == IntPtr.Zero)
					YUV444J_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YUV444J", "Lorg/jcodec/common/model/ColorSpace;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YUV444J_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr YUV444_10_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='YUV444_10']"
		[Register ("YUV444_10")]
		public static global::Org.Jcodec.Common.Model.ColorSpace Yuv44410 {
			get {
				if (YUV444_10_jfieldId == IntPtr.Zero)
					YUV444_10_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YUV444_10", "Lorg/jcodec/common/model/ColorSpace;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YUV444_10_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr compHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='compHeight']"
		[Register ("compHeight")]
		public IList<int> CompHeight {
			get {
				if (compHeight_jfieldId == IntPtr.Zero)
					compHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "compHeight", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, compHeight_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (compHeight_jfieldId == IntPtr.Zero)
					compHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "compHeight", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, compHeight_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr compPlane_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='compPlane']"
		[Register ("compPlane")]
		public IList<int> CompPlane {
			get {
				if (compPlane_jfieldId == IntPtr.Zero)
					compPlane_jfieldId = JNIEnv.GetFieldID (class_ref, "compPlane", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, compPlane_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (compPlane_jfieldId == IntPtr.Zero)
					compPlane_jfieldId = JNIEnv.GetFieldID (class_ref, "compPlane", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, compPlane_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr compWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='compWidth']"
		[Register ("compWidth")]
		public IList<int> CompWidth {
			get {
				if (compWidth_jfieldId == IntPtr.Zero)
					compWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "compWidth", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, compWidth_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (compWidth_jfieldId == IntPtr.Zero)
					compWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "compWidth", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, compWidth_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr nComp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/field[@name='nComp']"
		[Register ("nComp")]
		public int NComp {
			get {
				if (nComp_jfieldId == IntPtr.Zero)
					nComp_jfieldId = JNIEnv.GetFieldID (class_ref, "nComp", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, nComp_jfieldId);
			}
			set {
				if (nComp_jfieldId == IntPtr.Zero)
					nComp_jfieldId = JNIEnv.GetFieldID (class_ref, "nComp", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nComp_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/ColorSpace", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorSpace); }
		}

		internal ColorSpace (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/common/model/ColorSpace;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.ColorSpace ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/common/model/ColorSpace;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Common.Model.ColorSpace __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ColorSpace']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/jcodec/common/model/ColorSpace;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.ColorSpace[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/common/model/ColorSpace;");
			try {
				return (global::Org.Jcodec.Common.Model.ColorSpace[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ColorSpace));
			} finally {
			}
		}

	}
}
