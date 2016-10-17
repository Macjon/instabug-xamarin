using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Invocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationEvent']"
	[global::Android.Runtime.Register ("com/instabug/library/invocation/InstabugInvocationEvent", DoNotGenerateAcw=true)]
	public sealed partial class InstabugInvocationEvent : global::Java.Lang.Enum {


		static IntPtr FLOATING_BUTTON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationEvent']/field[@name='FLOATING_BUTTON']"
		[Register ("FLOATING_BUTTON")]
		public static global::Com.Instabug.Library.Invocation.InstabugInvocationEvent FloatingButton {
			get {
				if (FLOATING_BUTTON_jfieldId == IntPtr.Zero)
					FLOATING_BUTTON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOATING_BUTTON", "Lcom/instabug/library/invocation/InstabugInvocationEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOATING_BUTTON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationEvent']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Instabug.Library.Invocation.InstabugInvocationEvent None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/instabug/library/invocation/InstabugInvocationEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SCREENSHOT_GESTURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationEvent']/field[@name='SCREENSHOT_GESTURE']"
		[Register ("SCREENSHOT_GESTURE")]
		public static global::Com.Instabug.Library.Invocation.InstabugInvocationEvent ScreenshotGesture {
			get {
				if (SCREENSHOT_GESTURE_jfieldId == IntPtr.Zero)
					SCREENSHOT_GESTURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCREENSHOT_GESTURE", "Lcom/instabug/library/invocation/InstabugInvocationEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCREENSHOT_GESTURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SHAKE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationEvent']/field[@name='SHAKE']"
		[Register ("SHAKE")]
		public static global::Com.Instabug.Library.Invocation.InstabugInvocationEvent Shake {
			get {
				if (SHAKE_jfieldId == IntPtr.Zero)
					SHAKE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHAKE", "Lcom/instabug/library/invocation/InstabugInvocationEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHAKE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TWO_FINGER_SWIPE_LEFTt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationEvent']/field[@name='TWO_FINGER_SWIPE_LEFTt']"
		[Register ("TWO_FINGER_SWIPE_LEFTt")]
		public static global::Com.Instabug.Library.Invocation.InstabugInvocationEvent TWOFINGERSWIPELEFTt {
			get {
				if (TWO_FINGER_SWIPE_LEFTt_jfieldId == IntPtr.Zero)
					TWO_FINGER_SWIPE_LEFTt_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWO_FINGER_SWIPE_LEFTt", "Lcom/instabug/library/invocation/InstabugInvocationEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TWO_FINGER_SWIPE_LEFTt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/invocation/InstabugInvocationEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugInvocationEvent); }
		}

		internal InstabugInvocationEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationEvent']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/invocation/InstabugInvocationEvent;", "")]
		public static unsafe global::Com.Instabug.Library.Invocation.InstabugInvocationEvent ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/invocation/InstabugInvocationEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.Invocation.InstabugInvocationEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='InstabugInvocationEvent']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/invocation/InstabugInvocationEvent;", "")]
		public static unsafe global::Com.Instabug.Library.Invocation.InstabugInvocationEvent[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/invocation/InstabugInvocationEvent;");
			try {
				return (global::Com.Instabug.Library.Invocation.InstabugInvocationEvent[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.Invocation.InstabugInvocationEvent));
			} finally {
			}
		}

	}
}
