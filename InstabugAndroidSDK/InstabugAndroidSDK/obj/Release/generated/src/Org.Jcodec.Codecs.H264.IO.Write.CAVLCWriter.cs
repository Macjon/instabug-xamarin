using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.IO.Write {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='CAVLCWriter']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/io/write/CAVLCWriter", DoNotGenerateAcw=true)]
	public partial class CAVLCWriter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/io/write/CAVLCWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CAVLCWriter); }
		}

		protected CAVLCWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_writeBool_Lorg_jcodec_common_io_BitWriter_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='CAVLCWriter']/method[@name='writeBool' and count(parameter)=3 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String']]"
		[Register ("writeBool", "(Lorg/jcodec/common/io/BitWriter;ZLjava/lang/String;)V", "")]
		public static unsafe void WriteBool (global::Org.Jcodec.Common.IO.BitWriter p0, bool p1, string p2)
		{
			if (id_writeBool_Lorg_jcodec_common_io_BitWriter_ZLjava_lang_String_ == IntPtr.Zero)
				id_writeBool_Lorg_jcodec_common_io_BitWriter_ZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeBool", "(Lorg/jcodec/common/io/BitWriter;ZLjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeBool_Lorg_jcodec_common_io_BitWriter_ZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_writeNBit_Lorg_jcodec_common_io_BitWriter_JILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='CAVLCWriter']/method[@name='writeNBit' and count(parameter)=4 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("writeNBit", "(Lorg/jcodec/common/io/BitWriter;JILjava/lang/String;)V", "")]
		public static unsafe void WriteNBit (global::Org.Jcodec.Common.IO.BitWriter p0, long p1, int p2, string p3)
		{
			if (id_writeNBit_Lorg_jcodec_common_io_BitWriter_JILjava_lang_String_ == IntPtr.Zero)
				id_writeNBit_Lorg_jcodec_common_io_BitWriter_JILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeNBit", "(Lorg/jcodec/common/io/BitWriter;JILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeNBit_Lorg_jcodec_common_io_BitWriter_JILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_writeSE_Lorg_jcodec_common_io_BitWriter_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='CAVLCWriter']/method[@name='writeSE' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='int']]"
		[Register ("writeSE", "(Lorg/jcodec/common/io/BitWriter;I)V", "")]
		public static unsafe void WriteSE (global::Org.Jcodec.Common.IO.BitWriter p0, int p1)
		{
			if (id_writeSE_Lorg_jcodec_common_io_BitWriter_I == IntPtr.Zero)
				id_writeSE_Lorg_jcodec_common_io_BitWriter_I = JNIEnv.GetStaticMethodID (class_ref, "writeSE", "(Lorg/jcodec/common/io/BitWriter;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeSE_Lorg_jcodec_common_io_BitWriter_I, __args);
			} finally {
			}
		}

		static IntPtr id_writeSE_Lorg_jcodec_common_io_BitWriter_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='CAVLCWriter']/method[@name='writeSE' and count(parameter)=3 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("writeSE", "(Lorg/jcodec/common/io/BitWriter;ILjava/lang/String;)V", "")]
		public static unsafe void WriteSE (global::Org.Jcodec.Common.IO.BitWriter p0, int p1, string p2)
		{
			if (id_writeSE_Lorg_jcodec_common_io_BitWriter_ILjava_lang_String_ == IntPtr.Zero)
				id_writeSE_Lorg_jcodec_common_io_BitWriter_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeSE", "(Lorg/jcodec/common/io/BitWriter;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeSE_Lorg_jcodec_common_io_BitWriter_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_writeSliceTrailingBits;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='CAVLCWriter']/method[@name='writeSliceTrailingBits' and count(parameter)=0]"
		[Register ("writeSliceTrailingBits", "()V", "")]
		public static unsafe void WriteSliceTrailingBits ()
		{
			if (id_writeSliceTrailingBits == IntPtr.Zero)
				id_writeSliceTrailingBits = JNIEnv.GetStaticMethodID (class_ref, "writeSliceTrailingBits", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeSliceTrailingBits);
			} finally {
			}
		}

		static IntPtr id_writeTrailingBits_Lorg_jcodec_common_io_BitWriter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='CAVLCWriter']/method[@name='writeTrailingBits' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitWriter']]"
		[Register ("writeTrailingBits", "(Lorg/jcodec/common/io/BitWriter;)V", "")]
		public static unsafe void WriteTrailingBits (global::Org.Jcodec.Common.IO.BitWriter p0)
		{
			if (id_writeTrailingBits_Lorg_jcodec_common_io_BitWriter_ == IntPtr.Zero)
				id_writeTrailingBits_Lorg_jcodec_common_io_BitWriter_ = JNIEnv.GetStaticMethodID (class_ref, "writeTrailingBits", "(Lorg/jcodec/common/io/BitWriter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeTrailingBits_Lorg_jcodec_common_io_BitWriter_, __args);
			} finally {
			}
		}

		static IntPtr id_writeU_Lorg_jcodec_common_io_BitWriter_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='CAVLCWriter']/method[@name='writeU' and count(parameter)=3 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("writeU", "(Lorg/jcodec/common/io/BitWriter;II)V", "")]
		public static unsafe void WriteU (global::Org.Jcodec.Common.IO.BitWriter p0, int p1, int p2)
		{
			if (id_writeU_Lorg_jcodec_common_io_BitWriter_II == IntPtr.Zero)
				id_writeU_Lorg_jcodec_common_io_BitWriter_II = JNIEnv.GetStaticMethodID (class_ref, "writeU", "(Lorg/jcodec/common/io/BitWriter;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeU_Lorg_jcodec_common_io_BitWriter_II, __args);
			} finally {
			}
		}

		static IntPtr id_writeU_Lorg_jcodec_common_io_BitWriter_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='CAVLCWriter']/method[@name='writeU' and count(parameter)=4 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("writeU", "(Lorg/jcodec/common/io/BitWriter;IILjava/lang/String;)V", "")]
		public static unsafe void WriteU (global::Org.Jcodec.Common.IO.BitWriter p0, int p1, int p2, string p3)
		{
			if (id_writeU_Lorg_jcodec_common_io_BitWriter_IILjava_lang_String_ == IntPtr.Zero)
				id_writeU_Lorg_jcodec_common_io_BitWriter_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeU", "(Lorg/jcodec/common/io/BitWriter;IILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeU_Lorg_jcodec_common_io_BitWriter_IILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_writeUE_Lorg_jcodec_common_io_BitWriter_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='CAVLCWriter']/method[@name='writeUE' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='int']]"
		[Register ("writeUE", "(Lorg/jcodec/common/io/BitWriter;I)V", "")]
		public static unsafe void WriteUE (global::Org.Jcodec.Common.IO.BitWriter p0, int p1)
		{
			if (id_writeUE_Lorg_jcodec_common_io_BitWriter_I == IntPtr.Zero)
				id_writeUE_Lorg_jcodec_common_io_BitWriter_I = JNIEnv.GetStaticMethodID (class_ref, "writeUE", "(Lorg/jcodec/common/io/BitWriter;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeUE_Lorg_jcodec_common_io_BitWriter_I, __args);
			} finally {
			}
		}

		static IntPtr id_writeUE_Lorg_jcodec_common_io_BitWriter_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.io.write']/class[@name='CAVLCWriter']/method[@name='writeUE' and count(parameter)=3 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("writeUE", "(Lorg/jcodec/common/io/BitWriter;ILjava/lang/String;)V", "")]
		public static unsafe void WriteUE (global::Org.Jcodec.Common.IO.BitWriter p0, int p1, string p2)
		{
			if (id_writeUE_Lorg_jcodec_common_io_BitWriter_ILjava_lang_String_ == IntPtr.Zero)
				id_writeUE_Lorg_jcodec_common_io_BitWriter_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeUE", "(Lorg/jcodec/common/io/BitWriter;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeUE_Lorg_jcodec_common_io_BitWriter_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
