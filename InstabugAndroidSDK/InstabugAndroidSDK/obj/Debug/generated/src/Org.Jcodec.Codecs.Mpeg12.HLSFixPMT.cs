using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='HLSFixPMT']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/HLSFixPMT", DoNotGenerateAcw=true)]
	public partial class HLSFixPMT : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/HLSFixPMT", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HLSFixPMT); }
		}

		protected HLSFixPMT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='HLSFixPMT']/constructor[@name='HLSFixPMT' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HLSFixPMT ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HLSFixPMT)) {
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

		static Delegate cb_fix_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetFix_Ljava_io_File_Handler ()
		{
			if (cb_fix_Ljava_io_File_ == null)
				cb_fix_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Fix_Ljava_io_File_);
			return cb_fix_Ljava_io_File_;
		}

		static void n_Fix_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Mpeg12.HLSFixPMT __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.HLSFixPMT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Fix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fix_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='HLSFixPMT']/method[@name='fix' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("fix", "(Ljava/io/File;)V", "GetFix_Ljava_io_File_Handler")]
		public virtual unsafe void Fix (global::Java.IO.File p0)
		{
			if (id_fix_Ljava_io_File_ == IntPtr.Zero)
				id_fix_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "fix", "(Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fix_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fix", "(Ljava/io/File;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_fixPAT_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='HLSFixPMT']/method[@name='fixPAT' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("fixPAT", "(Ljava/nio/ByteBuffer;)V", "")]
		public static unsafe void FixPAT (global::Java.Nio.ByteBuffer p0)
		{
			if (id_fixPAT_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_fixPAT_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "fixPAT", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fixPAT_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='HLSFixPMT']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
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

	}
}
