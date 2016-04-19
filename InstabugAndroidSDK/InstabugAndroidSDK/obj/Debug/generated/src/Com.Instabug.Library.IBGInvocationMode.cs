using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationMode']"
	[global::Android.Runtime.Register ("com/instabug/library/IBGInvocationMode", DoNotGenerateAcw=true)]
	public sealed partial class IBGInvocationMode : global::Java.Lang.Enum {


		static IntPtr IBGInvocationModeBugReporter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationMode']/field[@name='IBGInvocationModeBugReporter']"
		[Register ("IBGInvocationModeBugReporter")]
		public static global::Com.Instabug.Library.IBGInvocationMode IBGInvocationModeBugReporter {
			get {
				if (IBGInvocationModeBugReporter_jfieldId == IntPtr.Zero)
					IBGInvocationModeBugReporter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IBGInvocationModeBugReporter", "Lcom/instabug/library/IBGInvocationMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IBGInvocationModeBugReporter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IBGInvocationModeFeedbackSender_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationMode']/field[@name='IBGInvocationModeFeedbackSender']"
		[Register ("IBGInvocationModeFeedbackSender")]
		public static global::Com.Instabug.Library.IBGInvocationMode IBGInvocationModeFeedbackSender {
			get {
				if (IBGInvocationModeFeedbackSender_jfieldId == IntPtr.Zero)
					IBGInvocationModeFeedbackSender_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IBGInvocationModeFeedbackSender", "Lcom/instabug/library/IBGInvocationMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IBGInvocationModeFeedbackSender_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IBGInvocationModeNA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationMode']/field[@name='IBGInvocationModeNA']"
		[Register ("IBGInvocationModeNA")]
		public static global::Com.Instabug.Library.IBGInvocationMode IBGInvocationModeNA {
			get {
				if (IBGInvocationModeNA_jfieldId == IntPtr.Zero)
					IBGInvocationModeNA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IBGInvocationModeNA", "Lcom/instabug/library/IBGInvocationMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IBGInvocationModeNA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/IBGInvocationMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBGInvocationMode); }
		}

		internal IBGInvocationMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/IBGInvocationMode;", "")]
		public static unsafe global::Com.Instabug.Library.IBGInvocationMode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/IBGInvocationMode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.IBGInvocationMode __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/IBGInvocationMode;", "")]
		public static unsafe global::Com.Instabug.Library.IBGInvocationMode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/IBGInvocationMode;");
			try {
				return (global::Com.Instabug.Library.IBGInvocationMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.IBGInvocationMode));
			} finally {
			}
		}

	}
}
