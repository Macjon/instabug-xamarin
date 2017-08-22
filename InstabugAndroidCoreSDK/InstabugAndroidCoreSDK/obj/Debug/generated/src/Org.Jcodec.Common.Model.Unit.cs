using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Unit']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/Unit", DoNotGenerateAcw=true)]
	public sealed partial class Unit : global::Java.Lang.Enum {


		static IntPtr FRAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Unit']/field[@name='FRAME']"
		[Register ("FRAME")]
		public static global::Org.Jcodec.Common.Model.Unit Frame {
			get {
				if (FRAME_jfieldId == IntPtr.Zero)
					FRAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRAME", "Lorg/jcodec/common/model/Unit;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRAME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Unit> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SEC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Unit']/field[@name='SEC']"
		[Register ("SEC")]
		public static global::Org.Jcodec.Common.Model.Unit Sec {
			get {
				if (SEC_jfieldId == IntPtr.Zero)
					SEC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEC", "Lorg/jcodec/common/model/Unit;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SEC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Unit> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/Unit", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Unit); }
		}

		internal Unit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Unit']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/common/model/Unit;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Unit ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/common/model/Unit;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Org.Jcodec.Common.Model.Unit __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Unit> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Unit']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/jcodec/common/model/Unit;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Unit[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/common/model/Unit;");
			try {
				return (global::Org.Jcodec.Common.Model.Unit[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.Unit));
			} finally {
			}
		}

	}
}
