using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/SequenceExtension", DoNotGenerateAcw=true)]
	public partial class SequenceExtension : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='Chroma420']"
		[Register ("Chroma420")]
		public const int Chroma420 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='Chroma422']"
		[Register ("Chroma422")]
		public const int Chroma422 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='Chroma444']"
		[Register ("Chroma444")]
		public const int Chroma444 = (int) 3;

		static IntPtr bit_rate_extension_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='bit_rate_extension']"
		[Register ("bit_rate_extension")]
		public int BitRateExtension {
			get {
				if (bit_rate_extension_jfieldId == IntPtr.Zero)
					bit_rate_extension_jfieldId = JNIEnv.GetFieldID (class_ref, "bit_rate_extension", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, bit_rate_extension_jfieldId);
			}
			set {
				if (bit_rate_extension_jfieldId == IntPtr.Zero)
					bit_rate_extension_jfieldId = JNIEnv.GetFieldID (class_ref, "bit_rate_extension", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bit_rate_extension_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr chroma_format_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='chroma_format']"
		[Register ("chroma_format")]
		public int ChromaFormat {
			get {
				if (chroma_format_jfieldId == IntPtr.Zero)
					chroma_format_jfieldId = JNIEnv.GetFieldID (class_ref, "chroma_format", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, chroma_format_jfieldId);
			}
			set {
				if (chroma_format_jfieldId == IntPtr.Zero)
					chroma_format_jfieldId = JNIEnv.GetFieldID (class_ref, "chroma_format", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chroma_format_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr frame_rate_extension_d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='frame_rate_extension_d']"
		[Register ("frame_rate_extension_d")]
		public int FrameRateExtensionD {
			get {
				if (frame_rate_extension_d_jfieldId == IntPtr.Zero)
					frame_rate_extension_d_jfieldId = JNIEnv.GetFieldID (class_ref, "frame_rate_extension_d", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, frame_rate_extension_d_jfieldId);
			}
			set {
				if (frame_rate_extension_d_jfieldId == IntPtr.Zero)
					frame_rate_extension_d_jfieldId = JNIEnv.GetFieldID (class_ref, "frame_rate_extension_d", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frame_rate_extension_d_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr frame_rate_extension_n_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='frame_rate_extension_n']"
		[Register ("frame_rate_extension_n")]
		public int FrameRateExtensionN {
			get {
				if (frame_rate_extension_n_jfieldId == IntPtr.Zero)
					frame_rate_extension_n_jfieldId = JNIEnv.GetFieldID (class_ref, "frame_rate_extension_n", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, frame_rate_extension_n_jfieldId);
			}
			set {
				if (frame_rate_extension_n_jfieldId == IntPtr.Zero)
					frame_rate_extension_n_jfieldId = JNIEnv.GetFieldID (class_ref, "frame_rate_extension_n", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frame_rate_extension_n_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr horizontal_size_extension_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='horizontal_size_extension']"
		[Register ("horizontal_size_extension")]
		public int HorizontalSizeExtension {
			get {
				if (horizontal_size_extension_jfieldId == IntPtr.Zero)
					horizontal_size_extension_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontal_size_extension", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, horizontal_size_extension_jfieldId);
			}
			set {
				if (horizontal_size_extension_jfieldId == IntPtr.Zero)
					horizontal_size_extension_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontal_size_extension", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, horizontal_size_extension_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr low_delay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='low_delay']"
		[Register ("low_delay")]
		public int LowDelay {
			get {
				if (low_delay_jfieldId == IntPtr.Zero)
					low_delay_jfieldId = JNIEnv.GetFieldID (class_ref, "low_delay", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, low_delay_jfieldId);
			}
			set {
				if (low_delay_jfieldId == IntPtr.Zero)
					low_delay_jfieldId = JNIEnv.GetFieldID (class_ref, "low_delay", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, low_delay_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr profile_and_level_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='profile_and_level']"
		[Register ("profile_and_level")]
		public int ProfileAndLevel {
			get {
				if (profile_and_level_jfieldId == IntPtr.Zero)
					profile_and_level_jfieldId = JNIEnv.GetFieldID (class_ref, "profile_and_level", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, profile_and_level_jfieldId);
			}
			set {
				if (profile_and_level_jfieldId == IntPtr.Zero)
					profile_and_level_jfieldId = JNIEnv.GetFieldID (class_ref, "profile_and_level", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, profile_and_level_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr progressive_sequence_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='progressive_sequence']"
		[Register ("progressive_sequence")]
		public int ProgressiveSequence {
			get {
				if (progressive_sequence_jfieldId == IntPtr.Zero)
					progressive_sequence_jfieldId = JNIEnv.GetFieldID (class_ref, "progressive_sequence", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, progressive_sequence_jfieldId);
			}
			set {
				if (progressive_sequence_jfieldId == IntPtr.Zero)
					progressive_sequence_jfieldId = JNIEnv.GetFieldID (class_ref, "progressive_sequence", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, progressive_sequence_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr vbv_buffer_size_extension_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='vbv_buffer_size_extension']"
		[Register ("vbv_buffer_size_extension")]
		public int VbvBufferSizeExtension {
			get {
				if (vbv_buffer_size_extension_jfieldId == IntPtr.Zero)
					vbv_buffer_size_extension_jfieldId = JNIEnv.GetFieldID (class_ref, "vbv_buffer_size_extension", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, vbv_buffer_size_extension_jfieldId);
			}
			set {
				if (vbv_buffer_size_extension_jfieldId == IntPtr.Zero)
					vbv_buffer_size_extension_jfieldId = JNIEnv.GetFieldID (class_ref, "vbv_buffer_size_extension", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vbv_buffer_size_extension_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr vertical_size_extension_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/field[@name='vertical_size_extension']"
		[Register ("vertical_size_extension")]
		public int VerticalSizeExtension {
			get {
				if (vertical_size_extension_jfieldId == IntPtr.Zero)
					vertical_size_extension_jfieldId = JNIEnv.GetFieldID (class_ref, "vertical_size_extension", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, vertical_size_extension_jfieldId);
			}
			set {
				if (vertical_size_extension_jfieldId == IntPtr.Zero)
					vertical_size_extension_jfieldId = JNIEnv.GetFieldID (class_ref, "vertical_size_extension", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vertical_size_extension_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/SequenceExtension", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SequenceExtension); }
		}

		protected SequenceExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIIIIIIIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/constructor[@name='SequenceExtension' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register (".ctor", "(IIIIIIIIII)V", "")]
		public unsafe SequenceExtension (int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				if (((object) this).GetType () != typeof (SequenceExtension)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IIIIIIIIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIIIIIIII)V", __args);
					return;
				}

				if (id_ctor_IIIIIIIIII == IntPtr.Zero)
					id_ctor_IIIIIIIIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIIIIIIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIIIIIIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIIIIIIII, __args);
			} finally {
			}
		}

		static IntPtr id_read_Lorg_jcodec_common_io_BitReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/SequenceExtension;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceExtension Read (global::Org.Jcodec.Common.IO.BitReader p0)
		{
			if (id_read_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_read_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/SequenceExtension;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceExtension __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceExtension> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_common_io_BitReader_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceExtension __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceExtension']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
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
