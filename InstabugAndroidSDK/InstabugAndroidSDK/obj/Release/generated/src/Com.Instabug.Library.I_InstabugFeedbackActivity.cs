using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library']/interface[@name='_InstabugFeedbackActivity']"
	[Register ("com/instabug/library/_InstabugFeedbackActivity", "", "Com.Instabug.Library.I_InstabugFeedbackActivityInvoker")]
	public partial interface I_InstabugFeedbackActivity : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/instabug/library/_InstabugFeedbackActivity", DoNotGenerateAcw=true)]
	internal class I_InstabugFeedbackActivityInvoker : global::Java.Lang.Object, I_InstabugFeedbackActivity {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/_InstabugFeedbackActivity");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (I_InstabugFeedbackActivityInvoker); }
		}

		IntPtr class_ref;

		public static I_InstabugFeedbackActivity GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<I_InstabugFeedbackActivity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library._InstabugFeedbackActivity"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public I_InstabugFeedbackActivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
