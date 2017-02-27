using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CAVLCReader']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/CAVLCReader", DoNotGenerateAcw=true)]
	public partial class CAVLCReader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/CAVLCReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CAVLCReader); }
		}

		protected CAVLCReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_moreRBSPData_Lorg_jcodec_common_io_BitReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CAVLCReader']/method[@name='moreRBSPData' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("moreRBSPData", "(Lorg/jcodec/common/io/BitReader;)Z", "")]
		public static unsafe bool MoreRBSPData (global::Org.Jcodec.Common.IO.BitReader p0)
		{
			if (id_moreRBSPData_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_moreRBSPData_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "moreRBSPData", "(Lorg/jcodec/common/io/BitReader;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_moreRBSPData_Lorg_jcodec_common_io_BitReader_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readBool_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CAVLCReader']/method[@name='readBool' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='java.lang.String']]"
		[Register ("readBool", "(Lorg/jcodec/common/io/BitReader;Ljava/lang/String;)Z", "")]
		public static unsafe bool ReadBool (global::Org.Jcodec.Common.IO.BitReader p0, string p1)
		{
			if (id_readBool_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_ == IntPtr.Zero)
				id_readBool_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readBool", "(Lorg/jcodec/common/io/BitReader;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_readBool_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_readME_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CAVLCReader']/method[@name='readME' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='java.lang.String']]"
		[Register ("readME", "(Lorg/jcodec/common/io/BitReader;Ljava/lang/String;)I", "")]
		public static unsafe int ReadME (global::Org.Jcodec.Common.IO.BitReader p0, string p1)
		{
			if (id_readME_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_ == IntPtr.Zero)
				id_readME_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readME", "(Lorg/jcodec/common/io/BitReader;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readME_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_readNBit_Lorg_jcodec_common_io_BitReader_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CAVLCReader']/method[@name='readNBit' and count(parameter)=3 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("readNBit", "(Lorg/jcodec/common/io/BitReader;ILjava/lang/String;)I", "")]
		public static unsafe int ReadNBit (global::Org.Jcodec.Common.IO.BitReader p0, int p1, string p2)
		{
			if (id_readNBit_Lorg_jcodec_common_io_BitReader_ILjava_lang_String_ == IntPtr.Zero)
				id_readNBit_Lorg_jcodec_common_io_BitReader_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readNBit", "(Lorg/jcodec/common/io/BitReader;ILjava/lang/String;)I");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readNBit_Lorg_jcodec_common_io_BitReader_ILjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_readSE_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CAVLCReader']/method[@name='readSE' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='java.lang.String']]"
		[Register ("readSE", "(Lorg/jcodec/common/io/BitReader;Ljava/lang/String;)I", "")]
		public static unsafe int ReadSE (global::Org.Jcodec.Common.IO.BitReader p0, string p1)
		{
			if (id_readSE_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_ == IntPtr.Zero)
				id_readSE_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readSE", "(Lorg/jcodec/common/io/BitReader;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readSE_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_readTE_Lorg_jcodec_common_io_BitReader_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CAVLCReader']/method[@name='readTE' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='int']]"
		[Register ("readTE", "(Lorg/jcodec/common/io/BitReader;I)I", "")]
		public static unsafe int ReadTE (global::Org.Jcodec.Common.IO.BitReader p0, int p1)
		{
			if (id_readTE_Lorg_jcodec_common_io_BitReader_I == IntPtr.Zero)
				id_readTE_Lorg_jcodec_common_io_BitReader_I = JNIEnv.GetStaticMethodID (class_ref, "readTE", "(Lorg/jcodec/common/io/BitReader;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readTE_Lorg_jcodec_common_io_BitReader_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readU_Lorg_jcodec_common_io_BitReader_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CAVLCReader']/method[@name='readU' and count(parameter)=3 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("readU", "(Lorg/jcodec/common/io/BitReader;ILjava/lang/String;)I", "")]
		public static unsafe int ReadU (global::Org.Jcodec.Common.IO.BitReader p0, int p1, string p2)
		{
			if (id_readU_Lorg_jcodec_common_io_BitReader_ILjava_lang_String_ == IntPtr.Zero)
				id_readU_Lorg_jcodec_common_io_BitReader_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readU", "(Lorg/jcodec/common/io/BitReader;ILjava/lang/String;)I");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readU_Lorg_jcodec_common_io_BitReader_ILjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_readUE_Lorg_jcodec_common_io_BitReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CAVLCReader']/method[@name='readUE' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("readUE", "(Lorg/jcodec/common/io/BitReader;)I", "")]
		public static unsafe int ReadUE (global::Org.Jcodec.Common.IO.BitReader p0)
		{
			if (id_readUE_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_readUE_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "readUE", "(Lorg/jcodec/common/io/BitReader;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readUE_Lorg_jcodec_common_io_BitReader_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readUE_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CAVLCReader']/method[@name='readUE' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='java.lang.String']]"
		[Register ("readUE", "(Lorg/jcodec/common/io/BitReader;Ljava/lang/String;)I", "")]
		public static unsafe int ReadUE (global::Org.Jcodec.Common.IO.BitReader p0, string p1)
		{
			if (id_readUE_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_ == IntPtr.Zero)
				id_readUE_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readUE", "(Lorg/jcodec/common/io/BitReader;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readUE_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_readZeroBitCount_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CAVLCReader']/method[@name='readZeroBitCount' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='java.lang.String']]"
		[Register ("readZeroBitCount", "(Lorg/jcodec/common/io/BitReader;Ljava/lang/String;)I", "")]
		public static unsafe int ReadZeroBitCount (global::Org.Jcodec.Common.IO.BitReader p0, string p1)
		{
			if (id_readZeroBitCount_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_ == IntPtr.Zero)
				id_readZeroBitCount_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readZeroBitCount", "(Lorg/jcodec/common/io/BitReader;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readZeroBitCount_Lorg_jcodec_common_io_BitReader_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
