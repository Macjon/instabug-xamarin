using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Prores {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresToProxy']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/prores/ProresToProxy", DoNotGenerateAcw=true)]
	public partial class ProresToProxy : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/prores/ProresToProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProresToProxy); }
		}

		protected ProresToProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresToProxy']/constructor[@name='ProresToProxy' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe ProresToProxy (int p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ProresToProxy)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(III)V", __args);
					return;
				}

				if (id_ctor_III == IntPtr.Zero)
					id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_III, __args);
			} finally {
			}
		}

		static Delegate cb_getFrameSize;
#pragma warning disable 0169
		static Delegate GetGetFrameSizeHandler ()
		{
			if (cb_getFrameSize == null)
				cb_getFrameSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameSize);
			return cb_getFrameSize;
		}

		static int n_GetFrameSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Prores.ProresToProxy __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresToProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameSize;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameSize;
		public virtual unsafe int FrameSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresToProxy']/method[@name='getFrameSize' and count(parameter)=0]"
			[Register ("getFrameSize", "()I", "GetGetFrameSizeHandler")]
			get {
				if (id_getFrameSize == IntPtr.Zero)
					id_getFrameSize = JNIEnv.GetMethodID (class_ref, "getFrameSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFrameSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetTranscode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == null)
				cb_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_);
			return cb_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		}

		static void n_Transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Prores.ProresToProxy __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresToProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Transcode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresToProxy']/method[@name='transcode' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("transcode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V", "GetTranscode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Transcode (global::Java.Nio.ByteBuffer p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "transcode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transcode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
