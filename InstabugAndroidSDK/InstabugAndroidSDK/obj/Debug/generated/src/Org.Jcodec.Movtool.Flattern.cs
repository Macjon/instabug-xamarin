using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Flattern']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/Flattern", DoNotGenerateAcw=true)]
	public partial class Flattern : global::Java.Lang.Object {


		static IntPtr listeners_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Flattern']/field[@name='listeners']"
		[Register ("listeners")]
		public global::System.Collections.IList Listeners {
			get {
				if (listeners_jfieldId == IntPtr.Zero)
					listeners_jfieldId = JNIEnv.GetFieldID (class_ref, "listeners", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, listeners_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (listeners_jfieldId == IntPtr.Zero)
					listeners_jfieldId = JNIEnv.GetFieldID (class_ref, "listeners", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, listeners_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.movtool']/interface[@name='Flattern.ProgressListener']"
		[Register ("org/jcodec/movtool/Flattern$ProgressListener", "", "Org.Jcodec.Movtool.Flattern/IProgressListenerInvoker")]
		public partial interface IProgressListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/interface[@name='Flattern.ProgressListener']/method[@name='trigger' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("trigger", "(I)V", "GetTrigger_IHandler:Org.Jcodec.Movtool.Flattern/IProgressListenerInvoker, InstabugAndroidSDK")]
			void Trigger (int p0);

		}

		[global::Android.Runtime.Register ("org/jcodec/movtool/Flattern$ProgressListener", DoNotGenerateAcw=true)]
		internal class IProgressListenerInvoker : global::Java.Lang.Object, IProgressListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/movtool/Flattern$ProgressListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IProgressListenerInvoker); }
			}

			IntPtr class_ref;

			public static IProgressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProgressListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.movtool.Flattern.ProgressListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProgressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_trigger_I;
#pragma warning disable 0169
			static Delegate GetTrigger_IHandler ()
			{
				if (cb_trigger_I == null)
					cb_trigger_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Trigger_I);
				return cb_trigger_I;
			}

			static void n_Trigger_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Jcodec.Movtool.Flattern.IProgressListener __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Flattern.IProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Trigger (p0);
			}
#pragma warning restore 0169

			IntPtr id_trigger_I;
			public unsafe void Trigger (int p0)
			{
				if (id_trigger_I == IntPtr.Zero)
					id_trigger_I = JNIEnv.GetMethodID (class_ref, "trigger", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trigger_I, __args);
			}

		}

		public partial class ProgressEventArgs : global::System.EventArgs {

			public ProgressEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/org/jcodec/movtool/Flattern_ProgressListenerImplementor")]
		internal sealed partial class IProgressListenerImplementor : global::Java.Lang.Object, IProgressListener {

			object sender;

			public IProgressListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/jcodec/movtool/Flattern_ProgressListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ProgressEventArgs> Handler;
#pragma warning restore 0649

			public void Trigger (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ProgressEventArgs (p0));
			}

			internal static bool __IsEmpty (IProgressListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/Flattern", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Flattern); }
		}

		protected Flattern (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Flattern']/constructor[@name='Flattern' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Flattern ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Flattern)) {
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

		static Delegate cb_addProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_;
#pragma warning disable 0169
		static Delegate GetAddProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_Handler ()
		{
			if (cb_addProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_ == null)
				cb_addProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_);
			return cb_addProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_;
		}

		static void n_AddProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Movtool.Flattern __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Flattern> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Movtool.Flattern.IProgressListener p0 = (global::Org.Jcodec.Movtool.Flattern.IProgressListener)global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Flattern.IProgressListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddProgressListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Flattern']/method[@name='addProgressListener' and count(parameter)=1 and parameter[1][@type='org.jcodec.movtool.Flattern.ProgressListener']]"
		[Register ("addProgressListener", "(Lorg/jcodec/movtool/Flattern$ProgressListener;)V", "GetAddProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_Handler")]
		public virtual unsafe void AddProgressListener (global::Org.Jcodec.Movtool.Flattern.IProgressListener p0)
		{
			if (id_addProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_ == IntPtr.Zero)
				id_addProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_ = JNIEnv.GetMethodID (class_ref, "addProgressListener", "(Lorg/jcodec/movtool/Flattern$ProgressListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addProgressListener", "(Lorg/jcodec/movtool/Flattern$ProgressListener;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Flattern']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

#region "Event implementation for Org.Jcodec.Movtool.Flattern.IProgressListener"
		public event EventHandler<global::Org.Jcodec.Movtool.Flattern.ProgressEventArgs> Progress {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Org.Jcodec.Movtool.Flattern.IProgressListener, global::Org.Jcodec.Movtool.Flattern.IProgressListenerImplementor>(
						ref weak_implementor_AddProgressListener,
						__CreateIProgressListenerImplementor,
						AddProgressListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Org.Jcodec.Movtool.Flattern.IProgressListener, global::Org.Jcodec.Movtool.Flattern.IProgressListenerImplementor>(
						ref weak_implementor_AddProgressListener,
						global::Org.Jcodec.Movtool.Flattern.IProgressListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Org.Jcodec.Movtool.Flattern.IProgressListener.AddProgressListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddProgressListener;

		global::Org.Jcodec.Movtool.Flattern.IProgressListenerImplementor __CreateIProgressListenerImplementor ()
		{
			return new global::Org.Jcodec.Movtool.Flattern.IProgressListenerImplementor (this);
		}
#endregion
	}
}
