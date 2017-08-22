using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Invocation.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugVideoRecordingButtonCorner']"
	[global::Android.Runtime.Register ("com/instabug/library/invocation/util/InstabugVideoRecordingButtonCorner", DoNotGenerateAcw=true)]
	public sealed partial class InstabugVideoRecordingButtonCorner : global::Java.Lang.Enum {


		static IntPtr BOTTOM_LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugVideoRecordingButtonCorner']/field[@name='BOTTOM_LEFT']"
		[Register ("BOTTOM_LEFT")]
		public static global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner BottomLeft {
			get {
				if (BOTTOM_LEFT_jfieldId == IntPtr.Zero)
					BOTTOM_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_LEFT", "Lcom/instabug/library/invocation/util/InstabugVideoRecordingButtonCorner;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOTTOM_LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BOTTOM_RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugVideoRecordingButtonCorner']/field[@name='BOTTOM_RIGHT']"
		[Register ("BOTTOM_RIGHT")]
		public static global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner BottomRight {
			get {
				if (BOTTOM_RIGHT_jfieldId == IntPtr.Zero)
					BOTTOM_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_RIGHT", "Lcom/instabug/library/invocation/util/InstabugVideoRecordingButtonCorner;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOTTOM_RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TOP_LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugVideoRecordingButtonCorner']/field[@name='TOP_LEFT']"
		[Register ("TOP_LEFT")]
		public static global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner TopLeft {
			get {
				if (TOP_LEFT_jfieldId == IntPtr.Zero)
					TOP_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_LEFT", "Lcom/instabug/library/invocation/util/InstabugVideoRecordingButtonCorner;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOP_LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TOP_RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugVideoRecordingButtonCorner']/field[@name='TOP_RIGHT']"
		[Register ("TOP_RIGHT")]
		public static global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner TopRight {
			get {
				if (TOP_RIGHT_jfieldId == IntPtr.Zero)
					TOP_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_RIGHT", "Lcom/instabug/library/invocation/util/InstabugVideoRecordingButtonCorner;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOP_RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/invocation/util/InstabugVideoRecordingButtonCorner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugVideoRecordingButtonCorner); }
		}

		internal InstabugVideoRecordingButtonCorner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugVideoRecordingButtonCorner']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/invocation/util/InstabugVideoRecordingButtonCorner;", "")]
		public static unsafe global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/invocation/util/InstabugVideoRecordingButtonCorner;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation.util']/class[@name='InstabugVideoRecordingButtonCorner']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/invocation/util/InstabugVideoRecordingButtonCorner;", "")]
		public static unsafe global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/invocation/util/InstabugVideoRecordingButtonCorner;");
			try {
				return (global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.Invocation.Util.InstabugVideoRecordingButtonCorner));
			} finally {
			}
		}

	}
}
