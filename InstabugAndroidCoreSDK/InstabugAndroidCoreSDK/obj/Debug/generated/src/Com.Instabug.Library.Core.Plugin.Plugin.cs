using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Core.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.core.plugin']/class[@name='Plugin']"
	[global::Android.Runtime.Register ("com/instabug/library/core/plugin/Plugin", DoNotGenerateAcw=true)]
	public abstract partial class Plugin : global::Java.Lang.Object {


		static IntPtr contextWeakReference_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.core.plugin']/class[@name='Plugin']/field[@name='contextWeakReference']"
		[Register ("contextWeakReference")]
		protected global::Java.Lang.Ref.WeakReference ContextWeakReference {
			get {
				if (contextWeakReference_jfieldId == IntPtr.Zero)
					contextWeakReference_jfieldId = JNIEnv.GetFieldID (class_ref, "contextWeakReference", "Ljava/lang/ref/WeakReference;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, contextWeakReference_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.WeakReference> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (contextWeakReference_jfieldId == IntPtr.Zero)
					contextWeakReference_jfieldId = JNIEnv.GetFieldID (class_ref, "contextWeakReference", "Ljava/lang/ref/WeakReference;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, contextWeakReference_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/core/plugin/Plugin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Plugin); }
		}

		protected Plugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.core.plugin']/class[@name='Plugin']/constructor[@name='Plugin' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Plugin ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Plugin)) {
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

		static Delegate cb_getLastActivityTime;
#pragma warning disable 0169
		static Delegate GetGetLastActivityTimeHandler ()
		{
			if (cb_getLastActivityTime == null)
				cb_getLastActivityTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastActivityTime);
			return cb_getLastActivityTime;
		}

		static long n_GetLastActivityTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Core.Plugin.Plugin __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Core.Plugin.Plugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastActivityTime;
		}
#pragma warning restore 0169

		public abstract long LastActivityTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core.plugin']/class[@name='Plugin']/method[@name='getLastActivityTime' and count(parameter)=0]"
			[Register ("getLastActivityTime", "()J", "GetGetLastActivityTimeHandler")] get;
		}

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Core.Plugin.Plugin __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Core.Plugin.Plugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core.plugin']/class[@name='Plugin']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Core.Plugin.Plugin __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Core.Plugin.Plugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core.plugin']/class[@name='Plugin']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public abstract void Release ();

	}

	[global::Android.Runtime.Register ("com/instabug/library/core/plugin/Plugin", DoNotGenerateAcw=true)]
	internal partial class PluginInvoker : Plugin {

		public PluginInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PluginInvoker); }
		}

		static IntPtr id_getLastActivityTime;
		public override unsafe long LastActivityTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core.plugin']/class[@name='Plugin']/method[@name='getLastActivityTime' and count(parameter)=0]"
			[Register ("getLastActivityTime", "()J", "GetGetLastActivityTimeHandler")]
			get {
				if (id_getLastActivityTime == IntPtr.Zero)
					id_getLastActivityTime = JNIEnv.GetMethodID (class_ref, "getLastActivityTime", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastActivityTime);
				} finally {
				}
			}
		}

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.core.plugin']/class[@name='Plugin']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public override unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
			} finally {
			}
		}

	}

}
