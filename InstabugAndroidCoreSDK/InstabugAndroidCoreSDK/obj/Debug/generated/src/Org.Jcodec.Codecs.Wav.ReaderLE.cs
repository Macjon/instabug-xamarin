using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Wav {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='ReaderLE']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/wav/ReaderLE", DoNotGenerateAcw=true)]
	public abstract partial class ReaderLE : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/wav/ReaderLE", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReaderLE); }
		}

		protected ReaderLE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='ReaderLE']/constructor[@name='ReaderLE' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReaderLE ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ReaderLE)) {
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

		static IntPtr id_readInt_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='ReaderLE']/method[@name='readInt' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readInt", "(Ljava/io/InputStream;)I", "")]
		public static unsafe int ReadInt (global::System.IO.Stream input)
		{
			if (id_readInt_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readInt_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readInt", "(Ljava/io/InputStream;)I");
			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readInt_Ljava_io_InputStream_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_readLong_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='ReaderLE']/method[@name='readLong' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readLong", "(Ljava/io/InputStream;)J", "")]
		public static unsafe long ReadLong (global::System.IO.Stream input)
		{
			if (id_readLong_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readLong_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readLong", "(Ljava/io/InputStream;)J");
			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_readLong_Ljava_io_InputStream_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static IntPtr id_readShort_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='ReaderLE']/method[@name='readShort' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readShort", "(Ljava/io/InputStream;)S", "")]
		public static unsafe short ReadShort (global::System.IO.Stream input)
		{
			if (id_readShort_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readShort_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readShort", "(Ljava/io/InputStream;)S");
			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				short __ret = JNIEnv.CallStaticShortMethod  (class_ref, id_readShort_Ljava_io_InputStream_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

	}

	[global::Android.Runtime.Register ("org/jcodec/codecs/wav/ReaderLE", DoNotGenerateAcw=true)]
	internal partial class ReaderLEInvoker : ReaderLE {

		public ReaderLEInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReaderLEInvoker); }
		}

	}

}
