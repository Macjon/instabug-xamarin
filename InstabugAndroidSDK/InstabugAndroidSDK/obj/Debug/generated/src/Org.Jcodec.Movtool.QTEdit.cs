using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='QTEdit']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/QTEdit", DoNotGenerateAcw=true)]
	public partial class QTEdit : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='QTEdit.BaseCommand']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/QTEdit$BaseCommand", DoNotGenerateAcw=true)]
		public abstract partial class BaseCommand : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/movtool/QTEdit$BaseCommand", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BaseCommand); }
			}

			protected BaseCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='QTEdit.BaseCommand']/constructor[@name='QTEdit.BaseCommand' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BaseCommand ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (BaseCommand)) {
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

		}

		[global::Android.Runtime.Register ("org/jcodec/movtool/QTEdit$BaseCommand", DoNotGenerateAcw=true)]
		internal partial class BaseCommandInvoker : BaseCommand {

			public BaseCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (BaseCommandInvoker); }
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/QTEdit", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QTEdit); }
		}

		protected QTEdit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Jcodec.Movtool.QTEdit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.QTEdit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Movtool.Flattern.IProgressListener p0 = (global::Org.Jcodec.Movtool.Flattern.IProgressListener)global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Flattern.IProgressListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddProgressListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addProgressListener_Lorg_jcodec_movtool_Flattern_ProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='QTEdit']/method[@name='addProgressListener' and count(parameter)=1 and parameter[1][@type='org.jcodec.movtool.Flattern.ProgressListener']]"
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

		static Delegate cb_execute_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExecute_arrayLjava_lang_String_Handler ()
		{
			if (cb_execute_arrayLjava_lang_String_ == null)
				cb_execute_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Execute_arrayLjava_lang_String_);
			return cb_execute_arrayLjava_lang_String_;
		}

		static void n_Execute_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Movtool.QTEdit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.QTEdit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Execute (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_execute_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='QTEdit']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("execute", "([Ljava/lang/String;)V", "GetExecute_arrayLjava_lang_String_Handler")]
		public virtual unsafe void Execute (string[] p0)
		{
			if (id_execute_arrayLjava_lang_String_ == IntPtr.Zero)
				id_execute_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "execute", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_help;
#pragma warning disable 0169
		static Delegate GetHelpHandler ()
		{
			if (cb_help == null)
				cb_help = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Help);
			return cb_help;
		}

		static void n_Help (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.QTEdit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.QTEdit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Help ();
		}
#pragma warning restore 0169

		static IntPtr id_help;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='QTEdit']/method[@name='help' and count(parameter)=0]"
		[Register ("help", "()V", "GetHelpHandler")]
		protected virtual unsafe void Help ()
		{
			if (id_help == IntPtr.Zero)
				id_help = JNIEnv.GetMethodID (class_ref, "help", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_help);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "help", "()V"));
			} finally {
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
