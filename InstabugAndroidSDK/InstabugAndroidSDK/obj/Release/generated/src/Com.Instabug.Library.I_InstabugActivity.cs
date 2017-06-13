using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library']/interface[@name='_InstabugActivity']"
	[Register ("com/instabug/library/_InstabugActivity", "", "Com.Instabug.Library.I_InstabugActivityInvoker")]
	public partial interface I_InstabugActivity : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/instabug/library/_InstabugActivity", DoNotGenerateAcw=true)]
	internal class I_InstabugActivityInvoker : global::Java.Lang.Object, I_InstabugActivity {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/_InstabugActivity");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (I_InstabugActivityInvoker); }
		}

		IntPtr class_ref;

		public static I_InstabugActivity GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<I_InstabugActivity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library._InstabugActivity"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public I_InstabugActivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
