using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Crash {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.crash']/class[@name='InternalCrashReporter']"
	[global::Android.Runtime.Register ("com/instabug/crash/InternalCrashReporter", DoNotGenerateAcw=true)]
	public partial class InternalCrashReporter : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.crash']/class[@name='InternalCrashReporter']/field[@name='internalAppToken']"
		[Register ("internalAppToken")]
		public const string InternalAppToken = (string) "b1a9630002b2cbdfbfecd942744b9018";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.crash']/class[@name='InternalCrashReporter']/field[@name='internalCrashKey']"
		[Register ("internalCrashKey")]
		public const string InternalCrashKey = (string) "InstabugSDK-v: ";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/crash/InternalCrashReporter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InternalCrashReporter); }
		}

		protected InternalCrashReporter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.crash']/class[@name='InternalCrashReporter']/constructor[@name='InternalCrashReporter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InternalCrashReporter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InternalCrashReporter)) {
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

		static IntPtr id_report_Ljava_lang_Throwable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.crash']/class[@name='InternalCrashReporter']/method[@name='report' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String']]"
		[Register ("report", "(Ljava/lang/Throwable;Ljava/lang/String;)V", "")]
		public static unsafe void Report (global::Java.Lang.Throwable caughtException, string exceptionIdentifier)
		{
			if (id_report_Ljava_lang_Throwable_Ljava_lang_String_ == IntPtr.Zero)
				id_report_Ljava_lang_Throwable_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "report", "(Ljava/lang/Throwable;Ljava/lang/String;)V");
			IntPtr native_exceptionIdentifier = JNIEnv.NewString (exceptionIdentifier);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (caughtException);
				__args [1] = new JValue (native_exceptionIdentifier);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_report_Ljava_lang_Throwable_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_exceptionIdentifier);
			}
		}

	}
}
