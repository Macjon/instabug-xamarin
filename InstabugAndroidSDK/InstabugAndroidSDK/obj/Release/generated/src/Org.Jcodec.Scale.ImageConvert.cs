using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Scale {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']"
	[global::Android.Runtime.Register ("org/jcodec/scale/ImageConvert", DoNotGenerateAcw=true)]
	public partial class ImageConvert : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/scale/ImageConvert", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageConvert); }
		}

		protected ImageConvert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']/constructor[@name='ImageConvert' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageConvert ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageConvert)) {
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

		static IntPtr id_RGB888toU4_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']/method[@name='RGB888toU4' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("RGB888toU4", "(III)B", "")]
		public static unsafe sbyte RGB888toU4 (int p0, int p1, int p2)
		{
			if (id_RGB888toU4_III == IntPtr.Zero)
				id_RGB888toU4_III = JNIEnv.GetStaticMethodID (class_ref, "RGB888toU4", "(III)B");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_RGB888toU4_III, __args);
			} finally {
			}
		}

		static IntPtr id_RGB888toV4_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']/method[@name='RGB888toV4' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("RGB888toV4", "(III)B", "")]
		public static unsafe sbyte RGB888toV4 (int p0, int p1, int p2)
		{
			if (id_RGB888toV4_III == IntPtr.Zero)
				id_RGB888toV4_III = JNIEnv.GetStaticMethodID (class_ref, "RGB888toV4", "(III)B");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_RGB888toV4_III, __args);
			} finally {
			}
		}

		static IntPtr id_RGB888toY4_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']/method[@name='RGB888toY4' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("RGB888toY4", "(III)B", "")]
		public static unsafe sbyte RGB888toY4 (int p0, int p1, int p2)
		{
			if (id_RGB888toY4_III == IntPtr.Zero)
				id_RGB888toY4_III = JNIEnv.GetStaticMethodID (class_ref, "RGB888toY4", "(III)B");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_RGB888toY4_III, __args);
			} finally {
			}
		}

		static IntPtr id_RGB888toYUV444_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']/method[@name='RGB888toYUV444' and count(parameter)=4 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='java.nio.ByteBuffer']]"
		[Register ("RGB888toYUV444", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V", "")]
		public static unsafe void RGB888toYUV444 (global::Java.Nio.ByteBuffer p0, global::Java.Nio.ByteBuffer p1, global::Java.Nio.ByteBuffer p2, global::Java.Nio.ByteBuffer p3)
		{
			if (id_RGB888toYUV444_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_RGB888toYUV444_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "RGB888toYUV444", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_RGB888toYUV444_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_YUV444toRGB888_IIILjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']/method[@name='YUV444toRGB888' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.nio.ByteBuffer']]"
		[Register ("YUV444toRGB888", "(IIILjava/nio/ByteBuffer;)V", "")]
		public static unsafe void YUV444toRGB888 (int p0, int p1, int p2, global::Java.Nio.ByteBuffer p3)
		{
			if (id_YUV444toRGB888_IIILjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_YUV444toRGB888_IIILjava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "YUV444toRGB888", "(IIILjava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_YUV444toRGB888_IIILjava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_crop_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']/method[@name='crop' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("crop", "(I)B", "")]
		public static unsafe sbyte Crop (int p0)
		{
			if (id_crop_I == IntPtr.Zero)
				id_crop_I = JNIEnv.GetStaticMethodID (class_ref, "crop", "(I)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_crop_I, __args);
			} finally {
			}
		}

		static IntPtr id_icrop_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']/method[@name='icrop' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("icrop", "(I)I", "")]
		public static unsafe int Icrop (int p0)
		{
			if (id_icrop_I == IntPtr.Zero)
				id_icrop_I = JNIEnv.GetStaticMethodID (class_ref, "icrop", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_icrop_I, __args);
			} finally {
			}
		}

		static IntPtr id_y_ccir_to_jpeg_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']/method[@name='y_ccir_to_jpeg' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("y_ccir_to_jpeg", "(B)B", "")]
		public static unsafe sbyte Y_ccir_to_jpeg (sbyte p0)
		{
			if (id_y_ccir_to_jpeg_B == IntPtr.Zero)
				id_y_ccir_to_jpeg_B = JNIEnv.GetStaticMethodID (class_ref, "y_ccir_to_jpeg", "(B)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_y_ccir_to_jpeg_B, __args);
			} finally {
			}
		}

		static IntPtr id_y_jpeg_to_ccir_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']/method[@name='y_jpeg_to_ccir' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("y_jpeg_to_ccir", "(B)B", "")]
		public static unsafe sbyte Y_jpeg_to_ccir (sbyte p0)
		{
			if (id_y_jpeg_to_ccir_B == IntPtr.Zero)
				id_y_jpeg_to_ccir_B = JNIEnv.GetStaticMethodID (class_ref, "y_jpeg_to_ccir", "(B)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_y_jpeg_to_ccir_B, __args);
			} finally {
			}
		}

		static IntPtr id_ycbcr_to_rgb24_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ImageConvert']/method[@name='ycbcr_to_rgb24' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ycbcr_to_rgb24", "(III)I", "")]
		public static unsafe int Ycbcr_to_rgb24 (int p0, int p1, int p2)
		{
			if (id_ycbcr_to_rgb24_III == IntPtr.Zero)
				id_ycbcr_to_rgb24_III = JNIEnv.GetStaticMethodID (class_ref, "ycbcr_to_rgb24", "(III)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_ycbcr_to_rgb24_III, __args);
			} finally {
			}
		}

	}
}
