using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGUtil']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPEGUtil", DoNotGenerateAcw=true)]
	public partial class MPEGUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPEGUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPEGUtil); }
		}

		protected MPEGUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGUtil']/constructor[@name='MPEGUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MPEGUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MPEGUtil)) {
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

		static IntPtr id_gotoMarker_Ljava_nio_ByteBuffer_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGUtil']/method[@name='gotoMarker' and count(parameter)=4 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("gotoMarker", "(Ljava/nio/ByteBuffer;III)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer GotoMarker (global::Java.Nio.ByteBuffer p0, int p1, int p2, int p3)
		{
			if (id_gotoMarker_Ljava_nio_ByteBuffer_III == IntPtr.Zero)
				id_gotoMarker_Ljava_nio_ByteBuffer_III = JNIEnv.GetStaticMethodID (class_ref, "gotoMarker", "(Ljava/nio/ByteBuffer;III)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Java.Nio.ByteBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_gotoMarker_Ljava_nio_ByteBuffer_III, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_gotoNextMarker_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGUtil']/method[@name='gotoNextMarker' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("gotoNextMarker", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer GotoNextMarker (global::Java.Nio.ByteBuffer p0)
		{
			if (id_gotoNextMarker_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_gotoNextMarker_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "gotoNextMarker", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Nio.ByteBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_gotoNextMarker_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_nextSegment_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGUtil']/method[@name='nextSegment' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("nextSegment", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer NextSegment (global::Java.Nio.ByteBuffer p0)
		{
			if (id_nextSegment_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_nextSegment_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "nextSegment", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Nio.ByteBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_nextSegment_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
