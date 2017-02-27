using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureDisplayExtension']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/PictureDisplayExtension", DoNotGenerateAcw=true)]
	public partial class PictureDisplayExtension : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {


		static IntPtr frame_centre_offsets_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureDisplayExtension']/field[@name='frame_centre_offsets']"
		[Register ("frame_centre_offsets")]
		public IList<Org.Jcodec.Common.Model.Point> FrameCentreOffsets {
			get {
				if (frame_centre_offsets_jfieldId == IntPtr.Zero)
					frame_centre_offsets_jfieldId = JNIEnv.GetFieldID (class_ref, "frame_centre_offsets", "[Lorg/jcodec/common/model/Point;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Common.Model.Point>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, frame_centre_offsets_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (frame_centre_offsets_jfieldId == IntPtr.Zero)
					frame_centre_offsets_jfieldId = JNIEnv.GetFieldID (class_ref, "frame_centre_offsets", "[Lorg/jcodec/common/model/Point;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Common.Model.Point>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frame_centre_offsets_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/PictureDisplayExtension", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PictureDisplayExtension); }
		}

		protected PictureDisplayExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureDisplayExtension']/constructor[@name='PictureDisplayExtension' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PictureDisplayExtension ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PictureDisplayExtension)) {
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

		static IntPtr id_read_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceExtension_Lorg_jcodec_codecs_mpeg12_bitstream_PictureCodingExtension_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureDisplayExtension']/method[@name='read' and count(parameter)=3 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='org.jcodec.codecs.mpeg12.bitstream.SequenceExtension'] and parameter[3][@type='org.jcodec.codecs.mpeg12.bitstream.PictureCodingExtension']]"
		[Register ("read", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/codecs/mpeg12/bitstream/SequenceExtension;Lorg/jcodec/codecs/mpeg12/bitstream/PictureCodingExtension;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureDisplayExtension;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureDisplayExtension Read (global::Org.Jcodec.Common.IO.BitReader p0, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceExtension p1, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureCodingExtension p2)
		{
			if (id_read_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceExtension_Lorg_jcodec_codecs_mpeg12_bitstream_PictureCodingExtension_ == IntPtr.Zero)
				id_read_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceExtension_Lorg_jcodec_codecs_mpeg12_bitstream_PictureCodingExtension_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/codecs/mpeg12/bitstream/SequenceExtension;Lorg/jcodec/codecs/mpeg12/bitstream/PictureCodingExtension;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureDisplayExtension;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureDisplayExtension __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureDisplayExtension> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceExtension_Lorg_jcodec_codecs_mpeg12_bitstream_PictureCodingExtension_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
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
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureDisplayExtension __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureDisplayExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureDisplayExtension']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)V", "GetWrite_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Write (global::Java.Nio.ByteBuffer p0)
		{
			if (id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
