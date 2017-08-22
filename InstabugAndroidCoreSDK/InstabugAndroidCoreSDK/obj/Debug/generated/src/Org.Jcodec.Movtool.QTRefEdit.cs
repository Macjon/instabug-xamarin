using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='QTRefEdit']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/QTRefEdit", DoNotGenerateAcw=true)]
	public partial class QTRefEdit : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/QTRefEdit", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QTRefEdit); }
		}

		protected QTRefEdit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_execute_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExecute_arrayLjava_lang_String_Handler ()
		{
			if (cb_execute_arrayLjava_lang_String_ == null)
				cb_execute_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Execute_arrayLjava_lang_String_);
			return cb_execute_arrayLjava_lang_String_;
		}

		static void n_Execute_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			global::Org.Jcodec.Movtool.QTRefEdit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.QTRefEdit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] args = (string[]) JNIEnv.GetArray (native_args, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Execute (args);
			if (args != null)
				JNIEnv.CopyArray (args, native_args);
		}
#pragma warning restore 0169

		static IntPtr id_execute_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='QTRefEdit']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("execute", "([Ljava/lang/String;)V", "GetExecute_arrayLjava_lang_String_Handler")]
		public virtual unsafe void Execute (string[] args)
		{
			if (id_execute_arrayLjava_lang_String_ == IntPtr.Zero)
				id_execute_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "execute", "([Ljava/lang/String;)V");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_args);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
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
			global::Org.Jcodec.Movtool.QTRefEdit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.QTRefEdit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Help ();
		}
#pragma warning restore 0169

		static IntPtr id_help;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='QTRefEdit']/method[@name='help' and count(parameter)=0]"
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

	}
}
