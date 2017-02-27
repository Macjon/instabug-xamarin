using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixHLSTimestamps']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/FixHLSTimestamps", DoNotGenerateAcw=true)]
	public partial class FixHLSTimestamps : global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/FixHLSTimestamps", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FixHLSTimestamps); }
		}

		protected FixHLSTimestamps (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixHLSTimestamps']/constructor[@name='FixHLSTimestamps' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FixHLSTimestamps ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FixHLSTimestamps)) {
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

		static Delegate cb_doWithTimestamp_IJZ;
#pragma warning disable 0169
		static Delegate GetDoWithTimestamp_IJZHandler ()
		{
			if (cb_doWithTimestamp_IJZ == null)
				cb_doWithTimestamp_IJZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, bool, long>) n_DoWithTimestamp_IJZ);
			return cb_doWithTimestamp_IJZ;
		}

		static long n_DoWithTimestamp_IJZ (IntPtr jnienv, IntPtr native__this, int p0, long p1, bool p2)
		{
			global::Org.Jcodec.Codecs.Mpeg12.FixHLSTimestamps __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.FixHLSTimestamps> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWithTimestamp (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_doWithTimestamp_IJZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixHLSTimestamps']/method[@name='doWithTimestamp' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("doWithTimestamp", "(IJZ)J", "GetDoWithTimestamp_IJZHandler")]
		protected override unsafe long DoWithTimestamp (int p0, long p1, bool p2)
		{
			if (id_doWithTimestamp_IJZ == IntPtr.Zero)
				id_doWithTimestamp_IJZ = JNIEnv.GetMethodID (class_ref, "doWithTimestamp", "(IJZ)J");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_doWithTimestamp_IJZ, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doWithTimestamp", "(IJZ)J"), __args);
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixHLSTimestamps']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
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
