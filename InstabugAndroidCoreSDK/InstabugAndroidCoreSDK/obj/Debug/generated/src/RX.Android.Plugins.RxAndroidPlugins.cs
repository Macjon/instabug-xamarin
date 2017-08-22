using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RX.Android.Plugins {

	// Metadata.xml XPath class reference: path="/api/package[@name='rx.android.plugins']/class[@name='RxAndroidPlugins']"
	[global::Android.Runtime.Register ("rx/android/plugins/RxAndroidPlugins", DoNotGenerateAcw=true)]
	public sealed partial class RxAndroidPlugins : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("rx/android/plugins/RxAndroidPlugins", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RxAndroidPlugins); }
		}

		internal RxAndroidPlugins (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::RX.Android.Plugins.RxAndroidPlugins Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='rx.android.plugins']/class[@name='RxAndroidPlugins']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lrx/android/plugins/RxAndroidPlugins;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lrx/android/plugins/RxAndroidPlugins;");
				try {
					return global::Java.Lang.Object.GetObject<global::RX.Android.Plugins.RxAndroidPlugins> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSchedulersHook;
		public unsafe global::RX.Android.Plugins.RxAndroidSchedulersHook SchedulersHook {
			// Metadata.xml XPath method reference: path="/api/package[@name='rx.android.plugins']/class[@name='RxAndroidPlugins']/method[@name='getSchedulersHook' and count(parameter)=0]"
			[Register ("getSchedulersHook", "()Lrx/android/plugins/RxAndroidSchedulersHook;", "GetGetSchedulersHookHandler")]
			get {
				if (id_getSchedulersHook == IntPtr.Zero)
					id_getSchedulersHook = JNIEnv.GetMethodID (class_ref, "getSchedulersHook", "()Lrx/android/plugins/RxAndroidSchedulersHook;");
				try {
					return global::Java.Lang.Object.GetObject<global::RX.Android.Plugins.RxAndroidSchedulersHook> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSchedulersHook), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_registerSchedulersHook_Lrx_android_plugins_RxAndroidSchedulersHook_;
		// Metadata.xml XPath method reference: path="/api/package[@name='rx.android.plugins']/class[@name='RxAndroidPlugins']/method[@name='registerSchedulersHook' and count(parameter)=1 and parameter[1][@type='rx.android.plugins.RxAndroidSchedulersHook']]"
		[Register ("registerSchedulersHook", "(Lrx/android/plugins/RxAndroidSchedulersHook;)V", "")]
		public unsafe void RegisterSchedulersHook (global::RX.Android.Plugins.RxAndroidSchedulersHook impl)
		{
			if (id_registerSchedulersHook_Lrx_android_plugins_RxAndroidSchedulersHook_ == IntPtr.Zero)
				id_registerSchedulersHook_Lrx_android_plugins_RxAndroidSchedulersHook_ = JNIEnv.GetMethodID (class_ref, "registerSchedulersHook", "(Lrx/android/plugins/RxAndroidSchedulersHook;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (impl);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerSchedulersHook_Lrx_android_plugins_RxAndroidSchedulersHook_, __args);
			} finally {
			}
		}

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='rx.android.plugins']/class[@name='RxAndroidPlugins']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
			} finally {
			}
		}

	}
}
