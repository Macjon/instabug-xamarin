using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mjpeg.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mjpeg.tools']/class[@name='Asserts']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mjpeg/tools/Asserts", DoNotGenerateAcw=true)]
	public partial class Asserts : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mjpeg/tools/Asserts", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Asserts); }
		}

		protected Asserts (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mjpeg.tools']/class[@name='Asserts']/constructor[@name='Asserts' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Asserts ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Asserts)) {
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

		static IntPtr id_assertEpsilonEquals_arrayBarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg.tools']/class[@name='Asserts']/method[@name='assertEpsilonEquals' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("assertEpsilonEquals", "([B[BI)V", "")]
		public static unsafe void AssertEpsilonEquals (byte[] expected, byte[] actual, int eps)
		{
			if (id_assertEpsilonEquals_arrayBarrayBI == IntPtr.Zero)
				id_assertEpsilonEquals_arrayBarrayBI = JNIEnv.GetStaticMethodID (class_ref, "assertEpsilonEquals", "([B[BI)V");
			IntPtr native_expected = JNIEnv.NewArray (expected);
			IntPtr native_actual = JNIEnv.NewArray (actual);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_expected);
				__args [1] = new JValue (native_actual);
				__args [2] = new JValue (eps);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_assertEpsilonEquals_arrayBarrayBI, __args);
			} finally {
				if (expected != null) {
					JNIEnv.CopyArray (native_expected, expected);
					JNIEnv.DeleteLocalRef (native_expected);
				}
				if (actual != null) {
					JNIEnv.CopyArray (native_actual, actual);
					JNIEnv.DeleteLocalRef (native_actual);
				}
			}
		}

		static IntPtr id_assertEpsilonEquals_arrayIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg.tools']/class[@name='Asserts']/method[@name='assertEpsilonEquals' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int']]"
		[Register ("assertEpsilonEquals", "([I[II)V", "")]
		public static unsafe void AssertEpsilonEquals (int[] expected, int[] actual, int eps)
		{
			if (id_assertEpsilonEquals_arrayIarrayII == IntPtr.Zero)
				id_assertEpsilonEquals_arrayIarrayII = JNIEnv.GetStaticMethodID (class_ref, "assertEpsilonEquals", "([I[II)V");
			IntPtr native_expected = JNIEnv.NewArray (expected);
			IntPtr native_actual = JNIEnv.NewArray (actual);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_expected);
				__args [1] = new JValue (native_actual);
				__args [2] = new JValue (eps);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_assertEpsilonEquals_arrayIarrayII, __args);
			} finally {
				if (expected != null) {
					JNIEnv.CopyArray (native_expected, expected);
					JNIEnv.DeleteLocalRef (native_expected);
				}
				if (actual != null) {
					JNIEnv.CopyArray (native_actual, actual);
					JNIEnv.DeleteLocalRef (native_actual);
				}
			}
		}

		static IntPtr id_assertEquals_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg.tools']/class[@name='Asserts']/method[@name='assertEquals' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("assertEquals", "(II)V", "")]
		public static unsafe void AssertEquals (int expected, int actual)
		{
			if (id_assertEquals_II == IntPtr.Zero)
				id_assertEquals_II = JNIEnv.GetStaticMethodID (class_ref, "assertEquals", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (expected);
				__args [1] = new JValue (actual);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_assertEquals_II, __args);
			} finally {
			}
		}

		static IntPtr id_assertInRange_Ljava_lang_String_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg.tools']/class[@name='Asserts']/method[@name='assertInRange' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("assertInRange", "(Ljava/lang/String;III)V", "")]
		public static unsafe void AssertInRange (string message, int low, int up, int val)
		{
			if (id_assertInRange_Ljava_lang_String_III == IntPtr.Zero)
				id_assertInRange_Ljava_lang_String_III = JNIEnv.GetStaticMethodID (class_ref, "assertInRange", "(Ljava/lang/String;III)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (low);
				__args [2] = new JValue (up);
				__args [3] = new JValue (val);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_assertInRange_Ljava_lang_String_III, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
