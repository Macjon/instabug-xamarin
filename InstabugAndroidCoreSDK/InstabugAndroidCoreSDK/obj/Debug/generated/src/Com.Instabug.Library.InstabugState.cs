using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugState", DoNotGenerateAcw=true)]
	public sealed partial class InstabugState : global::Java.Lang.Enum {


		static IntPtr BUILT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/field[@name='BUILT']"
		[Register ("BUILT")]
		public static global::Com.Instabug.Library.InstabugState Built {
			get {
				if (BUILT_jfieldId == IntPtr.Zero)
					BUILT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUILT", "Lcom/instabug/library/InstabugState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUILT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DISABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/field[@name='DISABLED']"
		[Register ("DISABLED")]
		public static global::Com.Instabug.Library.InstabugState Disabled {
			get {
				if (DISABLED_jfieldId == IntPtr.Zero)
					DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISABLED", "Lcom/instabug/library/InstabugState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISABLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ENABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/field[@name='ENABLED']"
		[Register ("ENABLED")]
		public static global::Com.Instabug.Library.InstabugState Enabled {
			get {
				if (ENABLED_jfieldId == IntPtr.Zero)
					ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENABLED", "Lcom/instabug/library/InstabugState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENABLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IMPORTING_IMAGE_FROM_GALLERY_FOR_CHAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/field[@name='IMPORTING_IMAGE_FROM_GALLERY_FOR_CHAT']"
		[Register ("IMPORTING_IMAGE_FROM_GALLERY_FOR_CHAT")]
		public static global::Com.Instabug.Library.InstabugState ImportingImageFromGalleryForChat {
			get {
				if (IMPORTING_IMAGE_FROM_GALLERY_FOR_CHAT_jfieldId == IntPtr.Zero)
					IMPORTING_IMAGE_FROM_GALLERY_FOR_CHAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMPORTING_IMAGE_FROM_GALLERY_FOR_CHAT", "Lcom/instabug/library/InstabugState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMPORTING_IMAGE_FROM_GALLERY_FOR_CHAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVOKED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/field[@name='INVOKED']"
		[Register ("INVOKED")]
		public static global::Com.Instabug.Library.InstabugState Invoked {
			get {
				if (INVOKED_jfieldId == IntPtr.Zero)
					INVOKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVOKED", "Lcom/instabug/library/InstabugState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVOKED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NOT_BUILT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/field[@name='NOT_BUILT']"
		[Register ("NOT_BUILT")]
		public static global::Com.Instabug.Library.InstabugState NotBuilt {
			get {
				if (NOT_BUILT_jfieldId == IntPtr.Zero)
					NOT_BUILT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_BUILT", "Lcom/instabug/library/InstabugState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_BUILT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RECORDING_VIDEO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/field[@name='RECORDING_VIDEO']"
		[Register ("RECORDING_VIDEO")]
		public static global::Com.Instabug.Library.InstabugState RecordingVideo {
			get {
				if (RECORDING_VIDEO_jfieldId == IntPtr.Zero)
					RECORDING_VIDEO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECORDING_VIDEO", "Lcom/instabug/library/InstabugState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECORDING_VIDEO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RECORDING_VIDEO_FOR_CHAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/field[@name='RECORDING_VIDEO_FOR_CHAT']"
		[Register ("RECORDING_VIDEO_FOR_CHAT")]
		public static global::Com.Instabug.Library.InstabugState RecordingVideoForChat {
			get {
				if (RECORDING_VIDEO_FOR_CHAT_jfieldId == IntPtr.Zero)
					RECORDING_VIDEO_FOR_CHAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECORDING_VIDEO_FOR_CHAT", "Lcom/instabug/library/InstabugState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECORDING_VIDEO_FOR_CHAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TAKING_SCREENSHOT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/field[@name='TAKING_SCREENSHOT']"
		[Register ("TAKING_SCREENSHOT")]
		public static global::Com.Instabug.Library.InstabugState TakingScreenshot {
			get {
				if (TAKING_SCREENSHOT_jfieldId == IntPtr.Zero)
					TAKING_SCREENSHOT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAKING_SCREENSHOT", "Lcom/instabug/library/InstabugState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAKING_SCREENSHOT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TAKING_SCREENSHOT_FOR_CHAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/field[@name='TAKING_SCREENSHOT_FOR_CHAT']"
		[Register ("TAKING_SCREENSHOT_FOR_CHAT")]
		public static global::Com.Instabug.Library.InstabugState TakingScreenshotForChat {
			get {
				if (TAKING_SCREENSHOT_FOR_CHAT_jfieldId == IntPtr.Zero)
					TAKING_SCREENSHOT_FOR_CHAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAKING_SCREENSHOT_FOR_CHAT", "Lcom/instabug/library/InstabugState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAKING_SCREENSHOT_FOR_CHAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugState); }
		}

		internal InstabugState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/instabug/library/InstabugState;", "")]
		public static unsafe global::Com.Instabug.Library.InstabugState ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/instabug/library/InstabugState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.InstabugState __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/instabug/library/InstabugState;", "")]
		public static unsafe global::Com.Instabug.Library.InstabugState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/instabug/library/InstabugState;");
			try {
				return (global::Com.Instabug.Library.InstabugState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.InstabugState));
			} finally {
			}
		}

	}
}
