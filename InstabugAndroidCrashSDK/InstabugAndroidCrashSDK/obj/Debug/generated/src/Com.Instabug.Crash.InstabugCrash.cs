using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Crash {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.crash']/class[@name='InstabugCrash']"
	[global::Android.Runtime.Register ("com/instabug/crash/InstabugCrash", DoNotGenerateAcw=true)]
	public partial class InstabugCrash : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/crash/InstabugCrash", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugCrash); }
		}

		protected InstabugCrash (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.crash']/class[@name='InstabugCrash']/constructor[@name='InstabugCrash' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugCrash ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InstabugCrash)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_reportCaughtException_Landroid_content_Context_Ljava_lang_Throwable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.crash']/class[@name='InstabugCrash']/method[@name='reportCaughtException' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String']]"
		[Register ("reportCaughtException", "(Landroid/content/Context;Ljava/lang/Throwable;Ljava/lang/String;)V", "")]
		public static unsafe void ReportCaughtException (global::Android.Content.Context context, global::Java.Lang.Throwable caughtException, string exceptionIdentifier)
		{
			if (id_reportCaughtException_Landroid_content_Context_Ljava_lang_Throwable_Ljava_lang_String_ == IntPtr.Zero)
				id_reportCaughtException_Landroid_content_Context_Ljava_lang_Throwable_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reportCaughtException", "(Landroid/content/Context;Ljava/lang/Throwable;Ljava/lang/String;)V");
			IntPtr native_exceptionIdentifier = JNIEnv.NewString (exceptionIdentifier);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (caughtException);
				__args [2] = new JValue (native_exceptionIdentifier);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportCaughtException_Landroid_content_Context_Ljava_lang_Throwable_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_exceptionIdentifier);
			}
		}

	}
}
