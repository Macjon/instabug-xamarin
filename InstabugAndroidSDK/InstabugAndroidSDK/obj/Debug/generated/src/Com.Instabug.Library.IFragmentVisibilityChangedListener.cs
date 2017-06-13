using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library']/interface[@name='FragmentVisibilityChangedListener']"
	[Register ("com/instabug/library/FragmentVisibilityChangedListener", "", "Com.Instabug.Library.IFragmentVisibilityChangedListenerInvoker")]
	public partial interface IFragmentVisibilityChangedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='FragmentVisibilityChangedListener']/method[@name='onVisibilityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onVisibilityChanged", "(Z)V", "GetOnVisibilityChanged_ZHandler:Com.Instabug.Library.IFragmentVisibilityChangedListenerInvoker, InstabugAndroidSDK")]
		void OnVisibilityChanged (bool p0);

	}

	[global::Android.Runtime.Register ("com/instabug/library/FragmentVisibilityChangedListener", DoNotGenerateAcw=true)]
	internal class IFragmentVisibilityChangedListenerInvoker : global::Java.Lang.Object, IFragmentVisibilityChangedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/FragmentVisibilityChangedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFragmentVisibilityChangedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IFragmentVisibilityChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFragmentVisibilityChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library.FragmentVisibilityChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFragmentVisibilityChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onVisibilityChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnVisibilityChanged_ZHandler ()
		{
			if (cb_onVisibilityChanged_Z == null)
				cb_onVisibilityChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnVisibilityChanged_Z);
			return cb_onVisibilityChanged_Z;
		}

		static void n_OnVisibilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Instabug.Library.IFragmentVisibilityChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IFragmentVisibilityChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVisibilityChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onVisibilityChanged_Z;
		public unsafe void OnVisibilityChanged (bool p0)
		{
			if (id_onVisibilityChanged_Z == IntPtr.Zero)
				id_onVisibilityChanged_Z = JNIEnv.GetMethodID (class_ref, "onVisibilityChanged", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVisibilityChanged_Z, __args);
		}

	}

	public partial class FragmentVisibilityChangedEventArgs : global::System.EventArgs {

		public FragmentVisibilityChangedEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/instabug/library/FragmentVisibilityChangedListenerImplementor")]
	internal sealed partial class IFragmentVisibilityChangedListenerImplementor : global::Java.Lang.Object, IFragmentVisibilityChangedListener {

		object sender;

		public IFragmentVisibilityChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/instabug/library/FragmentVisibilityChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FragmentVisibilityChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnVisibilityChanged (bool p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new FragmentVisibilityChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (IFragmentVisibilityChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
