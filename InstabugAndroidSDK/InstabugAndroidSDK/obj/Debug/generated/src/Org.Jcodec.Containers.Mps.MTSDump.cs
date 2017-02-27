using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mps {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDump']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mps/MTSDump", DoNotGenerateAcw=true)]
	public partial class MTSDump : global::Org.Jcodec.Containers.Mps.MPSDump {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mps/MTSDump", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MTSDump); }
		}

		protected MTSDump (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_channels_ReadableByteChannel_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDump']/constructor[@name='MTSDump' and count(parameter)=2 and parameter[1][@type='java.nio.channels.ReadableByteChannel'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/nio/channels/ReadableByteChannel;I)V", "")]
		public unsafe MTSDump (global::Java.Nio.Channels.IReadableByteChannel p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MTSDump)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/channels/ReadableByteChannel;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/channels/ReadableByteChannel;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_channels_ReadableByteChannel_I == IntPtr.Zero)
					id_ctor_Ljava_nio_channels_ReadableByteChannel_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/channels/ReadableByteChannel;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_I, __args);
			} finally {
			}
		}

		static Delegate cb_fillBuffer_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetFillBuffer_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_fillBuffer_Ljava_nio_ByteBuffer_ == null)
				cb_fillBuffer_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_FillBuffer_Ljava_nio_ByteBuffer_);
			return cb_fillBuffer_Ljava_nio_ByteBuffer_;
		}

		static int n_FillBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mps.MTSDump __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDump> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FillBuffer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fillBuffer_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDump']/method[@name='fillBuffer' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("fillBuffer", "(Ljava/nio/ByteBuffer;)I", "GetFillBuffer_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe int FillBuffer (global::Java.Nio.ByteBuffer p0)
		{
			if (id_fillBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_fillBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "fillBuffer", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_fillBuffer_Ljava_nio_ByteBuffer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fillBuffer", "(Ljava/nio/ByteBuffer;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDump']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
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
