using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInternalBuilder']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugInternalBuilder", DoNotGenerateAcw=true)]
	public partial class InstabugInternalBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugInternalBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugInternalBuilder); }
		}

		protected InstabugInternalBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInternalBuilder']/constructor[@name='InstabugInternalBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugInternalBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InstabugInternalBuilder)) {
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

		static IntPtr id_buildInstabug_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugInternalBuilder']/method[@name='buildInstabug' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("buildInstabug", "(Landroid/content/Context;)Lcom/instabug/library/Instabug;", "")]
		public static unsafe global::Com.Instabug.Library.Instabug BuildInstabug (global::Android.Content.Context p0)
		{
			if (id_buildInstabug_Landroid_content_Context_ == IntPtr.Zero)
				id_buildInstabug_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "buildInstabug", "(Landroid/content/Context;)Lcom/instabug/library/Instabug;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Instabug.Library.Instabug __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildInstabug_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
