using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceDisplayExtension']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/SequenceDisplayExtension", DoNotGenerateAcw=true)]
	public partial class SequenceDisplayExtension : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {


		static IntPtr display_horizontal_size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceDisplayExtension']/field[@name='display_horizontal_size']"
		[Register ("display_horizontal_size")]
		public int DisplayHorizontalSize {
			get {
				if (display_horizontal_size_jfieldId == IntPtr.Zero)
					display_horizontal_size_jfieldId = JNIEnv.GetFieldID (class_ref, "display_horizontal_size", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, display_horizontal_size_jfieldId);
			}
			set {
				if (display_horizontal_size_jfieldId == IntPtr.Zero)
					display_horizontal_size_jfieldId = JNIEnv.GetFieldID (class_ref, "display_horizontal_size", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, display_horizontal_size_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr display_vertical_size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceDisplayExtension']/field[@name='display_vertical_size']"
		[Register ("display_vertical_size")]
		public int DisplayVerticalSize {
			get {
				if (display_vertical_size_jfieldId == IntPtr.Zero)
					display_vertical_size_jfieldId = JNIEnv.GetFieldID (class_ref, "display_vertical_size", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, display_vertical_size_jfieldId);
			}
			set {
				if (display_vertical_size_jfieldId == IntPtr.Zero)
					display_vertical_size_jfieldId = JNIEnv.GetFieldID (class_ref, "display_vertical_size", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, display_vertical_size_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr video_format_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceDisplayExtension']/field[@name='video_format']"
		[Register ("video_format")]
		public int VideoFormat {
			get {
				if (video_format_jfieldId == IntPtr.Zero)
					video_format_jfieldId = JNIEnv.GetFieldID (class_ref, "video_format", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, video_format_jfieldId);
			}
			set {
				if (video_format_jfieldId == IntPtr.Zero)
					video_format_jfieldId = JNIEnv.GetFieldID (class_ref, "video_format", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, video_format_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceDisplayExtension.ColorDescription']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/SequenceDisplayExtension$ColorDescription", DoNotGenerateAcw=true)]
		public partial class ColorDescription : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/SequenceDisplayExtension$ColorDescription", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ColorDescription); }
			}

			protected ColorDescription (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceDisplayExtension.ColorDescription']/constructor[@name='SequenceDisplayExtension.ColorDescription' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ColorDescription ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (ColorDescription)) {
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceDisplayExtension.ColorDescription']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
			[Register ("read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/SequenceDisplayExtension$ColorDescription;", "")]
			public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceDisplayExtension.ColorDescription Read (global::Org.Jcodec.Common.IO.BitReader @in)
			{
				if (id_read_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
					id_read_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/SequenceDisplayExtension$ColorDescription;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (@in);
					global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceDisplayExtension.ColorDescription __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceDisplayExtension.ColorDescription> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_common_io_BitReader_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_write_Lorg_jcodec_common_io_BitWriter_;
#pragma warning disable 0169
			static Delegate GetWrite_Lorg_jcodec_common_io_BitWriter_Handler ()
			{
				if (cb_write_Lorg_jcodec_common_io_BitWriter_ == null)
					cb_write_Lorg_jcodec_common_io_BitWriter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Lorg_jcodec_common_io_BitWriter_);
				return cb_write_Lorg_jcodec_common_io_BitWriter_;
			}

			static void n_Write_Lorg_jcodec_common_io_BitWriter_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
			{
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceDisplayExtension.ColorDescription __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceDisplayExtension.ColorDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Common.IO.BitWriter @out = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (native__out, JniHandleOwnership.DoNotTransfer);
				__this.Write (@out);
			}
#pragma warning restore 0169

			static IntPtr id_write_Lorg_jcodec_common_io_BitWriter_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceDisplayExtension.ColorDescription']/method[@name='write' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitWriter']]"
			[Register ("write", "(Lorg/jcodec/common/io/BitWriter;)V", "GetWrite_Lorg_jcodec_common_io_BitWriter_Handler")]
			public virtual unsafe void Write (global::Org.Jcodec.Common.IO.BitWriter @out)
			{
				if (id_write_Lorg_jcodec_common_io_BitWriter_ == IntPtr.Zero)
					id_write_Lorg_jcodec_common_io_BitWriter_ = JNIEnv.GetMethodID (class_ref, "write", "(Lorg/jcodec/common/io/BitWriter;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (@out);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lorg_jcodec_common_io_BitWriter_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lorg/jcodec/common/io/BitWriter;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/SequenceDisplayExtension", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SequenceDisplayExtension); }
		}

		protected SequenceDisplayExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceDisplayExtension']/constructor[@name='SequenceDisplayExtension' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SequenceDisplayExtension ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SequenceDisplayExtension)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceDisplayExtension']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/SequenceDisplayExtension;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceDisplayExtension Read (global::Org.Jcodec.Common.IO.BitReader @in)
		{
			if (id_read_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_read_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/SequenceDisplayExtension;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceDisplayExtension __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceDisplayExtension> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_common_io_BitReader_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceDisplayExtension __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceDisplayExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer bb = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bb, JniHandleOwnership.DoNotTransfer);
			__this.Write (bb);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceDisplayExtension']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
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
