using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Wav {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WriterLE']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/wav/WriterLE", DoNotGenerateAcw=true)]
	public abstract partial class WriterLE : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/wav/WriterLE", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WriterLE); }
		}

		protected WriterLE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WriterLE']/constructor[@name='WriterLE' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WriterLE ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (WriterLE)) {
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

		static IntPtr id_writeInt_Ljava_io_OutputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WriterLE']/method[@name='writeInt' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='int']]"
		[Register ("writeInt", "(Ljava/io/OutputStream;I)V", "")]
		public static unsafe void WriteInt (global::System.IO.Stream p0, int p1)
		{
			if (id_writeInt_Ljava_io_OutputStream_I == IntPtr.Zero)
				id_writeInt_Ljava_io_OutputStream_I = JNIEnv.GetStaticMethodID (class_ref, "writeInt", "(Ljava/io/OutputStream;I)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeInt_Ljava_io_OutputStream_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_writeLong_Ljava_io_OutputStream_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WriterLE']/method[@name='writeLong' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='long']]"
		[Register ("writeLong", "(Ljava/io/OutputStream;J)V", "")]
		public static unsafe void WriteLong (global::System.IO.Stream p0, long p1)
		{
			if (id_writeLong_Ljava_io_OutputStream_J == IntPtr.Zero)
				id_writeLong_Ljava_io_OutputStream_J = JNIEnv.GetStaticMethodID (class_ref, "writeLong", "(Ljava/io/OutputStream;J)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeLong_Ljava_io_OutputStream_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_writeShort_Ljava_io_OutputStream_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WriterLE']/method[@name='writeShort' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='short']]"
		[Register ("writeShort", "(Ljava/io/OutputStream;S)V", "")]
		public static unsafe void WriteShort (global::System.IO.Stream p0, short p1)
		{
			if (id_writeShort_Ljava_io_OutputStream_S == IntPtr.Zero)
				id_writeShort_Ljava_io_OutputStream_S = JNIEnv.GetStaticMethodID (class_ref, "writeShort", "(Ljava/io/OutputStream;S)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeShort_Ljava_io_OutputStream_S, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("org/jcodec/codecs/wav/WriterLE", DoNotGenerateAcw=true)]
	internal partial class WriterLEInvoker : WriterLE {

		public WriterLEInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (WriterLEInvoker); }
		}

	}

}
