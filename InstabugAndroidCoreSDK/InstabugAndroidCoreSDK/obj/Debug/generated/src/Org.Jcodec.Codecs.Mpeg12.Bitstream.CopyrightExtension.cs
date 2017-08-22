using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='CopyrightExtension']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/CopyrightExtension", DoNotGenerateAcw=true)]
	public partial class CopyrightExtension : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {


		static IntPtr copyright_flag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='CopyrightExtension']/field[@name='copyright_flag']"
		[Register ("copyright_flag")]
		public int CopyrightFlag {
			get {
				if (copyright_flag_jfieldId == IntPtr.Zero)
					copyright_flag_jfieldId = JNIEnv.GetFieldID (class_ref, "copyright_flag", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, copyright_flag_jfieldId);
			}
			set {
				if (copyright_flag_jfieldId == IntPtr.Zero)
					copyright_flag_jfieldId = JNIEnv.GetFieldID (class_ref, "copyright_flag", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, copyright_flag_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr copyright_identifier_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='CopyrightExtension']/field[@name='copyright_identifier']"
		[Register ("copyright_identifier")]
		public int CopyrightIdentifier {
			get {
				if (copyright_identifier_jfieldId == IntPtr.Zero)
					copyright_identifier_jfieldId = JNIEnv.GetFieldID (class_ref, "copyright_identifier", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, copyright_identifier_jfieldId);
			}
			set {
				if (copyright_identifier_jfieldId == IntPtr.Zero)
					copyright_identifier_jfieldId = JNIEnv.GetFieldID (class_ref, "copyright_identifier", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, copyright_identifier_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr copyright_number_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='CopyrightExtension']/field[@name='copyright_number_1']"
		[Register ("copyright_number_1")]
		public int CopyrightNumber1 {
			get {
				if (copyright_number_1_jfieldId == IntPtr.Zero)
					copyright_number_1_jfieldId = JNIEnv.GetFieldID (class_ref, "copyright_number_1", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, copyright_number_1_jfieldId);
			}
			set {
				if (copyright_number_1_jfieldId == IntPtr.Zero)
					copyright_number_1_jfieldId = JNIEnv.GetFieldID (class_ref, "copyright_number_1", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, copyright_number_1_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr copyright_number_2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='CopyrightExtension']/field[@name='copyright_number_2']"
		[Register ("copyright_number_2")]
		public int CopyrightNumber2 {
			get {
				if (copyright_number_2_jfieldId == IntPtr.Zero)
					copyright_number_2_jfieldId = JNIEnv.GetFieldID (class_ref, "copyright_number_2", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, copyright_number_2_jfieldId);
			}
			set {
				if (copyright_number_2_jfieldId == IntPtr.Zero)
					copyright_number_2_jfieldId = JNIEnv.GetFieldID (class_ref, "copyright_number_2", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, copyright_number_2_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr copyright_number_3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='CopyrightExtension']/field[@name='copyright_number_3']"
		[Register ("copyright_number_3")]
		public int CopyrightNumber3 {
			get {
				if (copyright_number_3_jfieldId == IntPtr.Zero)
					copyright_number_3_jfieldId = JNIEnv.GetFieldID (class_ref, "copyright_number_3", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, copyright_number_3_jfieldId);
			}
			set {
				if (copyright_number_3_jfieldId == IntPtr.Zero)
					copyright_number_3_jfieldId = JNIEnv.GetFieldID (class_ref, "copyright_number_3", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, copyright_number_3_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr original_or_copy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='CopyrightExtension']/field[@name='original_or_copy']"
		[Register ("original_or_copy")]
		public int OriginalOrCopy {
			get {
				if (original_or_copy_jfieldId == IntPtr.Zero)
					original_or_copy_jfieldId = JNIEnv.GetFieldID (class_ref, "original_or_copy", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, original_or_copy_jfieldId);
			}
			set {
				if (original_or_copy_jfieldId == IntPtr.Zero)
					original_or_copy_jfieldId = JNIEnv.GetFieldID (class_ref, "original_or_copy", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, original_or_copy_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/CopyrightExtension", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CopyrightExtension); }
		}

		protected CopyrightExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='CopyrightExtension']/constructor[@name='CopyrightExtension' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CopyrightExtension ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CopyrightExtension)) {
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

		static IntPtr id_read_Lorg_jcodec_common_io_BitReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='CopyrightExtension']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/CopyrightExtension;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.CopyrightExtension Read (global::Org.Jcodec.Common.IO.BitReader @in)
		{
			if (id_read_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_read_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/CopyrightExtension;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.CopyrightExtension __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.CopyrightExtension> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_common_io_BitReader_, __args), JniHandleOwnership.TransferLocalRef);
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

		static void n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bb)
		{
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.CopyrightExtension __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.CopyrightExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer bb = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bb, JniHandleOwnership.DoNotTransfer);
			__this.Write (bb);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='CopyrightExtension']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)V", "GetWrite_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Write (global::Java.Nio.ByteBuffer bb)
		{
			if (id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bb);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
