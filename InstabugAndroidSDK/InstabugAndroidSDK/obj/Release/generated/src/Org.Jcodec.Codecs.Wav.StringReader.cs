using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Wav {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='StringReader']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/wav/StringReader", DoNotGenerateAcw=true)]
	public abstract partial class StringReader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/wav/StringReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringReader); }
		}

		protected StringReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='StringReader']/constructor[@name='StringReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StringReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		static IntPtr id_readString_Ljava_io_InputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='StringReader']/method[@name='readString' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("readString", "(Ljava/io/InputStream;I)Ljava/lang/String;", "")]
		public static unsafe string ReadString (global::System.IO.Stream p0, int p1)
		{
			if (id_readString_Ljava_io_InputStream_I == IntPtr.Zero)
				id_readString_Ljava_io_InputStream_I = JNIEnv.GetStaticMethodID (class_ref, "readString", "(Ljava/io/InputStream;I)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readString_Ljava_io_InputStream_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_sureRead_Ljava_io_InputStream_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='StringReader']/method[@name='sureRead' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("sureRead", "(Ljava/io/InputStream;[BI)I", "")]
		public static unsafe int SureRead (global::System.IO.Stream p0, byte[] p1, int p2)
		{
			if (id_sureRead_Ljava_io_InputStream_arrayBI == IntPtr.Zero)
				id_sureRead_Ljava_io_InputStream_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "sureRead", "(Ljava/io/InputStream;[BI)I");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_sureRead_Ljava_io_InputStream_arrayBI, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_sureRead_Ljava_io_InputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='StringReader']/method[@name='sureRead' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("sureRead", "(Ljava/io/InputStream;I)[B", "")]
		public static unsafe byte[] SureRead (global::System.IO.Stream p0, int p1)
		{
			if (id_sureRead_Ljava_io_InputStream_I == IntPtr.Zero)
				id_sureRead_Ljava_io_InputStream_I = JNIEnv.GetStaticMethodID (class_ref, "sureRead", "(Ljava/io/InputStream;I)[B");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sureRead_Ljava_io_InputStream_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_sureSkip_Ljava_io_InputStream_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='StringReader']/method[@name='sureSkip' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long']]"
		[Register ("sureSkip", "(Ljava/io/InputStream;J)V", "")]
		public static unsafe void SureSkip (global::System.IO.Stream p0, long p1)
		{
			if (id_sureSkip_Ljava_io_InputStream_J == IntPtr.Zero)
				id_sureSkip_Ljava_io_InputStream_J = JNIEnv.GetStaticMethodID (class_ref, "sureSkip", "(Ljava/io/InputStream;J)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sureSkip_Ljava_io_InputStream_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("org/jcodec/codecs/wav/StringReader", DoNotGenerateAcw=true)]
	internal partial class StringReaderInvoker : StringReader {

		public StringReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringReaderInvoker); }
		}

	}

}
