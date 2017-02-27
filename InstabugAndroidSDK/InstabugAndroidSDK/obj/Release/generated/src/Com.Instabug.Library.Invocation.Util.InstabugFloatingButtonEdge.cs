using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Invocation.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugFloatingButtonEdge']"
	[global::Android.Runtime.Register ("com/instabug/library/invocation/util/InstabugFloatingButtonEdge", DoNotGenerateAcw=true)]
	public sealed partial class InstabugFloatingButtonEdge : global::Java.Lang.Enum {


		static IntPtr LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugFloatingButtonEdge']/field[@name='LEFT']"
		[Register ("LEFT")]
		public static global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge Left {
			get {
				if (LEFT_jfieldId == IntPtr.Zero)
					LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT", "Lcom/instabug/library/invocation/util/InstabugFloatingButtonEdge;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugFloatingButtonEdge']/field[@name='RIGHT']"
		[Register ("RIGHT")]
		public static global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge Right {
			get {
				if (RIGHT_jfieldId == IntPtr.Zero)
					RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT", "Lcom/instabug/library/invocation/util/InstabugFloatingButtonEdge;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/invocation/util/InstabugFloatingButtonEdge", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugFloatingButtonEdge); }
		}

		internal InstabugFloatingButtonEdge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugFloatingButtonEdge']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/invocation/util/InstabugFloatingButtonEdge;", "")]
		public static unsafe global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/invocation/util/InstabugFloatingButtonEdge;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugFloatingButtonEdge']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/invocation/util/InstabugFloatingButtonEdge;", "")]
		public static unsafe global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/invocation/util/InstabugFloatingButtonEdge;");
			try {
				return (global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge));
			} finally {
			}
		}

	}
}
