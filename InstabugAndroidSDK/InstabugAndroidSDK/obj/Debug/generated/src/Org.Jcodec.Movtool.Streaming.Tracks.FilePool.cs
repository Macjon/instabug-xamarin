using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='FilePool']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/FilePool", DoNotGenerateAcw=true)]
	public partial class FilePool : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='FilePool.PoolChannel']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/FilePool$PoolChannel", DoNotGenerateAcw=true)]
		public partial class PoolChannel : global::Org.Jcodec.Movtool.Streaming.Tracks.SeekableByteChannelWrapper {

			protected PoolChannel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/FilePool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FilePool); }
		}

		protected FilePool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='FilePool']/constructor[@name='FilePool' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/io/File;I)V", "")]
		public unsafe FilePool (global::Java.IO.File p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (FilePool)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/File;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/File;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_I == IntPtr.Zero)
					id_ctor_Ljava_io_File_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_File_I, __args);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.FilePool __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.FilePool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='FilePool']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

	}
}
