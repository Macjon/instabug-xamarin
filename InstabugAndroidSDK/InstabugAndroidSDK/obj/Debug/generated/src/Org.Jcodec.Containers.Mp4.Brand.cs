using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Brand']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/Brand", DoNotGenerateAcw=true)]
	public sealed partial class Brand : global::Java.Lang.Enum {


		static IntPtr MOV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Brand']/field[@name='MOV']"
		[Register ("MOV")]
		public static global::Org.Jcodec.Containers.Mp4.Brand Mov {
			get {
				if (MOV_jfieldId == IntPtr.Zero)
					MOV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOV", "Lorg/jcodec/containers/mp4/Brand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOV_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Brand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MP4_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Brand']/field[@name='MP4']"
		[Register ("MP4")]
		public static global::Org.Jcodec.Containers.Mp4.Brand Mp4 {
			get {
				if (MP4_jfieldId == IntPtr.Zero)
					MP4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MP4", "Lorg/jcodec/containers/mp4/Brand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MP4_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Brand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/Brand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Brand); }
		}

		internal Brand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Brand']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mp4/Brand;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mp4.Brand ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mp4/Brand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Containers.Mp4.Brand __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Brand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Brand']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/jcodec/containers/mp4/Brand;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mp4.Brand[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/containers/mp4/Brand;");
			try {
				return (global::Org.Jcodec.Containers.Mp4.Brand[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mp4.Brand));
			} finally {
			}
		}

	}
}
