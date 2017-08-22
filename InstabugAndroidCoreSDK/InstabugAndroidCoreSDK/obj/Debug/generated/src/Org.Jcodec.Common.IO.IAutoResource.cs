using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.IO {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.common.io']/interface[@name='AutoResource']"
	[Register ("org/jcodec/common/io/AutoResource", "", "Org.Jcodec.Common.IO.IAutoResourceInvoker")]
	public partial interface IAutoResource : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/interface[@name='AutoResource']/method[@name='setCurTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setCurTime", "(J)V", "GetSetCurTime_JHandler:Org.Jcodec.Common.IO.IAutoResourceInvoker, InstabugAndroidCoreSDK")]
		void SetCurTime (long p0);

	}

	[global::Android.Runtime.Register ("org/jcodec/common/io/AutoResource", DoNotGenerateAcw=true)]
	internal class IAutoResourceInvoker : global::Java.Lang.Object, IAutoResource {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/common/io/AutoResource");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAutoResourceInvoker); }
		}

		IntPtr class_ref;

		public static IAutoResource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAutoResource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.common.io.AutoResource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAutoResourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setCurTime_J;
#pragma warning disable 0169
		static Delegate GetSetCurTime_JHandler ()
		{
			if (cb_setCurTime_J == null)
				cb_setCurTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetCurTime_J);
			return cb_setCurTime_J;
		}

		static void n_SetCurTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Jcodec.Common.IO.IAutoResource __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.IAutoResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurTime (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCurTime_J;
		public unsafe void SetCurTime (long p0)
		{
			if (id_setCurTime_J == IntPtr.Zero)
				id_setCurTime_J = JNIEnv.GetMethodID (class_ref, "setCurTime", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurTime_J, __args);
		}

	}

}
