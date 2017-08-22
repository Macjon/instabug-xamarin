using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Analytics.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.analytics.util']/class[@name='ViewResourcesUtil']"
	[global::Android.Runtime.Register ("com/instabug/library/analytics/util/ViewResourcesUtil", DoNotGenerateAcw=true)]
	public partial class ViewResourcesUtil : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/analytics/util/ViewResourcesUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewResourcesUtil); }
		}

		protected ViewResourcesUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.analytics.util']/class[@name='ViewResourcesUtil']/constructor[@name='ViewResourcesUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ViewResourcesUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ViewResourcesUtil)) {
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

		static IntPtr id_getViewResourceIdAsString_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.analytics.util']/class[@name='ViewResourcesUtil']/method[@name='getViewResourceIdAsString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getViewResourceIdAsString", "(Landroid/content/Context;I)Ljava/lang/String;", "")]
		public static unsafe string GetViewResourceIdAsString (global::Android.Content.Context p0, int p1)
		{
			if (id_getViewResourceIdAsString_Landroid_content_Context_I == IntPtr.Zero)
				id_getViewResourceIdAsString_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "getViewResourceIdAsString", "(Landroid/content/Context;I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getViewResourceIdAsString_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
