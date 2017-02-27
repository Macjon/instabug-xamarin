using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Prores {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresFix']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/prores/ProresFix", DoNotGenerateAcw=true)]
	public partial class ProresFix : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/prores/ProresFix", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProresFix); }
		}

		protected ProresFix (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresFix']/constructor[@name='ProresFix' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProresFix ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ProresFix)) {
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

		static IntPtr id_check_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresFix']/method[@name='check' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("check", "(Ljava/nio/ByteBuffer;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> Check (global::Java.Nio.ByteBuffer p0)
		{
			if (id_check_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_check_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "check", "(Ljava/nio/ByteBuffer;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_check_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresFix']/method[@name='transcode' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("transcode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer Transcode (global::Java.Nio.ByteBuffer p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "transcode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Nio.ByteBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
