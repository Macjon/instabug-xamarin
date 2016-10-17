using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='Constants']"
	[global::Android.Runtime.Register ("com/instabug/library/Constants", DoNotGenerateAcw=true)]
	public partial class Constants : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='Constants.IntentParams']"
		[global::Android.Runtime.Register ("com/instabug/library/Constants$IntentParams", DoNotGenerateAcw=true)]
		public partial class IntentParams : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Constants.IntentParams']/field[@name='AUDIO_RECORDING_PERMISSION_REQUEST_CODE']"
			[Register ("AUDIO_RECORDING_PERMISSION_REQUEST_CODE")]
			public const int AudioRecordingPermissionRequestCode = (int) 1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/instabug/library/Constants$IntentParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IntentParams); }
			}

			protected IntentParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_instabug_library_Constants_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='Constants.IntentParams']/constructor[@name='Constants.IntentParams' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Constants']]"
			[Register (".ctor", "(Lcom/instabug/library/Constants;)V", "")]
			public unsafe IntentParams (global::Com.Instabug.Library.Constants __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (IntentParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_instabug_library_Constants_ == IntPtr.Zero)
						id_ctor_Lcom_instabug_library_Constants_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/instabug/library/Constants;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_instabug_library_Constants_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_instabug_library_Constants_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/Constants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Constants); }
		}

		protected Constants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='Constants']/constructor[@name='Constants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Constants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Constants)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

	}
}
