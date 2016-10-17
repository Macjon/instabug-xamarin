using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/interface[@name='MPEGHeader']"
	[Register ("org/jcodec/codecs/mpeg12/bitstream/MPEGHeader", "", "Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeaderInvoker")]
	public partial interface IMPEGHeader : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/interface[@name='MPEGHeader']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)V", "GetWrite_Ljava_nio_ByteBuffer_Handler:Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeaderInvoker, InstabugAndroidSDK")]
		void Write (global::Java.Nio.ByteBuffer p0);

	}

	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/MPEGHeader", DoNotGenerateAcw=true)]
	internal class IMPEGHeaderInvoker : global::Java.Lang.Object, IMPEGHeader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/MPEGHeader");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMPEGHeaderInvoker); }
		}

		IntPtr class_ref;

		public static IMPEGHeader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMPEGHeader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.codecs.mpeg12.bitstream.MPEGHeader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMPEGHeaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_write_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_write_Ljava_nio_ByteBuffer_ == null)
				cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_nio_ByteBuffer_);
			return cb_write_Ljava_nio_ByteBuffer_;
		}

		static void n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		IntPtr id_write_Ljava_nio_ByteBuffer_;
		public unsafe void Write (global::Java.Nio.ByteBuffer p0)
		{
			if (id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_ByteBuffer_, __args);
		}

	}

}
