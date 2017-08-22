using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.api']/class[@name='UnsupportedFormatException']"
	[global::Android.Runtime.Register ("org/jcodec/api/UnsupportedFormatException", DoNotGenerateAcw=true)]
	public partial class UnsupportedFormatException : global::Org.Jcodec.Api.JCodecException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/api/UnsupportedFormatException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnsupportedFormatException); }
		}

		protected UnsupportedFormatException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.api']/class[@name='UnsupportedFormatException']/constructor[@name='UnsupportedFormatException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe UnsupportedFormatException (string arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_arg0 = JNIEnv.NewString (arg0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_arg0);
				if (((object) this).GetType () != typeof (UnsupportedFormatException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_arg0);
			}
		}

	}
}
