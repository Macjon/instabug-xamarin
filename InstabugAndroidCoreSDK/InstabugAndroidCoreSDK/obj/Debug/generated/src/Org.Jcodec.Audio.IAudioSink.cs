using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Audio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.audio']/interface[@name='AudioSink']"
	[Register ("org/jcodec/audio/AudioSink", "", "Org.Jcodec.Audio.IAudioSinkInvoker")]
	public partial interface IAudioSink : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/interface[@name='AudioSink']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.FloatBuffer']]"
		[Register ("write", "(Ljava/nio/FloatBuffer;)V", "GetWrite_Ljava_nio_FloatBuffer_Handler:Org.Jcodec.Audio.IAudioSinkInvoker, InstabugAndroidCoreSDK")]
		void Write (global::Java.Nio.FloatBuffer p0);

	}

	[global::Android.Runtime.Register ("org/jcodec/audio/AudioSink", DoNotGenerateAcw=true)]
	internal class IAudioSinkInvoker : global::Java.Lang.Object, IAudioSink {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/audio/AudioSink");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAudioSinkInvoker); }
		}

		IntPtr class_ref;

		public static IAudioSink GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioSink> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.audio.AudioSink"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioSinkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_write_Ljava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_FloatBuffer_Handler ()
		{
			if (cb_write_Ljava_nio_FloatBuffer_ == null)
				cb_write_Ljava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_nio_FloatBuffer_);
			return cb_write_Ljava_nio_FloatBuffer_;
		}

		static void n_Write_Ljava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Audio.IAudioSink __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.IAudioSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		IntPtr id_write_Ljava_nio_FloatBuffer_;
		public unsafe void Write (global::Java.Nio.FloatBuffer p0)
		{
			if (id_write_Ljava_nio_FloatBuffer_ == IntPtr.Zero)
				id_write_Ljava_nio_FloatBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/FloatBuffer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_FloatBuffer_, __args);
		}

	}

}
