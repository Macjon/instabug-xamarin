using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='DownmixHelper']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/DownmixHelper", DoNotGenerateAcw=true)]
	public partial class DownmixHelper : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/DownmixHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownmixHelper); }
		}

		protected DownmixHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_clamp1f_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='DownmixHelper']/method[@name='clamp1f' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("clamp1f", "(F)F", "")]
		public static unsafe float Clamp1f (float f)
		{
			if (id_clamp1f_F == IntPtr.Zero)
				id_clamp1f_F = JNIEnv.GetStaticMethodID (class_ref, "clamp1f", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (f);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_clamp1f_F, __args);
			} finally {
			}
		}

		static Delegate cb_downmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetDownmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_downmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == null)
				cb_downmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Downmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_);
			return cb_downmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		}

		static void n_Downmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native__out)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.DownmixHelper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.DownmixHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer[] data = (global::Java.Nio.ByteBuffer[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Nio.ByteBuffer));
			global::Java.Nio.ByteBuffer @out = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Downmix (data, @out);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		static IntPtr id_downmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='DownmixHelper']/method[@name='downmix' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer[]'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("downmix", "([Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V", "GetDownmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Downmix (global::Java.Nio.ByteBuffer[] data, global::Java.Nio.ByteBuffer @out)
		{
			if (id_downmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_downmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "downmix", "([Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_data);
				__args [1] = new JValue (@out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_downmix_arrayLjava_nio_ByteBuffer_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downmix", "([Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

	}
}