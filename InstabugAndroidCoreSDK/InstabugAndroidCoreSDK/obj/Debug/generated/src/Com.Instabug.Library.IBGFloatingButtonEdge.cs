using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGFloatingButtonEdge']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/instabug/library/IBGFloatingButtonEdge", DoNotGenerateAcw=true)]
	public sealed partial class IBGFloatingButtonEdge : global::Java.Lang.Enum {


		static IntPtr Left_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGFloatingButtonEdge']/field[@name='Left']"
		[Register ("Left")]
		public static global::Com.Instabug.Library.IBGFloatingButtonEdge Left {
			get {
				if (Left_jfieldId == IntPtr.Zero)
					Left_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Left", "Lcom/instabug/library/IBGFloatingButtonEdge;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Left_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGFloatingButtonEdge> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Right_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGFloatingButtonEdge']/field[@name='Right']"
		[Register ("Right")]
		public static global::Com.Instabug.Library.IBGFloatingButtonEdge Right {
			get {
				if (Right_jfieldId == IntPtr.Zero)
					Right_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Right", "Lcom/instabug/library/IBGFloatingButtonEdge;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Right_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGFloatingButtonEdge> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/IBGFloatingButtonEdge", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBGFloatingButtonEdge); }
		}

		internal IBGFloatingButtonEdge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGFloatingButtonEdge']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/IBGFloatingButtonEdge;", "")]
		public static unsafe global::Com.Instabug.Library.IBGFloatingButtonEdge ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/IBGFloatingButtonEdge;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.IBGFloatingButtonEdge __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGFloatingButtonEdge> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGFloatingButtonEdge']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/IBGFloatingButtonEdge;", "")]
		public static unsafe global::Com.Instabug.Library.IBGFloatingButtonEdge[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/IBGFloatingButtonEdge;");
			try {
				return (global::Com.Instabug.Library.IBGFloatingButtonEdge[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.IBGFloatingButtonEdge));
			} finally {
			}
		}

	}
}
