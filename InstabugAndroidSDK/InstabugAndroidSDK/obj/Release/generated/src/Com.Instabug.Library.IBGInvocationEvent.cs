using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationEvent']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/instabug/library/IBGInvocationEvent", DoNotGenerateAcw=true)]
	public sealed partial class IBGInvocationEvent : global::Java.Lang.Enum {


		static IntPtr IBGInvocationEventFloatingButton_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationEvent']/field[@name='IBGInvocationEventFloatingButton']"
		[Register ("IBGInvocationEventFloatingButton")]
		public static global::Com.Instabug.Library.IBGInvocationEvent IBGInvocationEventFloatingButton {
			get {
				if (IBGInvocationEventFloatingButton_jfieldId == IntPtr.Zero)
					IBGInvocationEventFloatingButton_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IBGInvocationEventFloatingButton", "Lcom/instabug/library/IBGInvocationEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IBGInvocationEventFloatingButton_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IBGInvocationEventNone_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationEvent']/field[@name='IBGInvocationEventNone']"
		[Register ("IBGInvocationEventNone")]
		public static global::Com.Instabug.Library.IBGInvocationEvent IBGInvocationEventNone {
			get {
				if (IBGInvocationEventNone_jfieldId == IntPtr.Zero)
					IBGInvocationEventNone_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IBGInvocationEventNone", "Lcom/instabug/library/IBGInvocationEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IBGInvocationEventNone_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IBGInvocationEventShake_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationEvent']/field[@name='IBGInvocationEventShake']"
		[Register ("IBGInvocationEventShake")]
		public static global::Com.Instabug.Library.IBGInvocationEvent IBGInvocationEventShake {
			get {
				if (IBGInvocationEventShake_jfieldId == IntPtr.Zero)
					IBGInvocationEventShake_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IBGInvocationEventShake", "Lcom/instabug/library/IBGInvocationEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IBGInvocationEventShake_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IBGInvocationEventTwoFingersSwipeLeft_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationEvent']/field[@name='IBGInvocationEventTwoFingersSwipeLeft']"
		[Register ("IBGInvocationEventTwoFingersSwipeLeft")]
		public static global::Com.Instabug.Library.IBGInvocationEvent IBGInvocationEventTwoFingersSwipeLeft {
			get {
				if (IBGInvocationEventTwoFingersSwipeLeft_jfieldId == IntPtr.Zero)
					IBGInvocationEventTwoFingersSwipeLeft_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IBGInvocationEventTwoFingersSwipeLeft", "Lcom/instabug/library/IBGInvocationEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IBGInvocationEventTwoFingersSwipeLeft_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IBGInvocationScreenshotGesture_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationEvent']/field[@name='IBGInvocationScreenshotGesture']"
		[Register ("IBGInvocationScreenshotGesture")]
		public static global::Com.Instabug.Library.IBGInvocationEvent IBGInvocationScreenshotGesture {
			get {
				if (IBGInvocationScreenshotGesture_jfieldId == IntPtr.Zero)
					IBGInvocationScreenshotGesture_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IBGInvocationScreenshotGesture", "Lcom/instabug/library/IBGInvocationEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IBGInvocationScreenshotGesture_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/IBGInvocationEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBGInvocationEvent); }
		}

		internal IBGInvocationEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationEvent']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/IBGInvocationEvent;", "")]
		public static unsafe global::Com.Instabug.Library.IBGInvocationEvent ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/IBGInvocationEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.IBGInvocationEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='IBGInvocationEvent']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/IBGInvocationEvent;", "")]
		public static unsafe global::Com.Instabug.Library.IBGInvocationEvent[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/IBGInvocationEvent;");
			try {
				return (global::Com.Instabug.Library.IBGInvocationEvent[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.IBGInvocationEvent));
			} finally {
			}
		}

	}
}
