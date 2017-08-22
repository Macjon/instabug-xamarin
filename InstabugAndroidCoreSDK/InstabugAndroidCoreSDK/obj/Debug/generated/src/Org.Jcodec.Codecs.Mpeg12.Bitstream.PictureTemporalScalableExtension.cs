using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureTemporalScalableExtension']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/PictureTemporalScalableExtension", DoNotGenerateAcw=true)]
	public partial class PictureTemporalScalableExtension : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {


		static IntPtr backward_temporal_reference_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureTemporalScalableExtension']/field[@name='backward_temporal_reference']"
		[Register ("backward_temporal_reference")]
		public int BackwardTemporalReference {
			get {
				if (backward_temporal_reference_jfieldId == IntPtr.Zero)
					backward_temporal_reference_jfieldId = JNIEnv.GetFieldID (class_ref, "backward_temporal_reference", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, backward_temporal_reference_jfieldId);
			}
			set {
				if (backward_temporal_reference_jfieldId == IntPtr.Zero)
					backward_temporal_reference_jfieldId = JNIEnv.GetFieldID (class_ref, "backward_temporal_reference", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, backward_temporal_reference_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr forward_temporal_reference_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureTemporalScalableExtension']/field[@name='forward_temporal_reference']"
		[Register ("forward_temporal_reference")]
		public int ForwardTemporalReference {
			get {
				if (forward_temporal_reference_jfieldId == IntPtr.Zero)
					forward_temporal_reference_jfieldId = JNIEnv.GetFieldID (class_ref, "forward_temporal_reference", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, forward_temporal_reference_jfieldId);
			}
			set {
				if (forward_temporal_reference_jfieldId == IntPtr.Zero)
					forward_temporal_reference_jfieldId = JNIEnv.GetFieldID (class_ref, "forward_temporal_reference", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, forward_temporal_reference_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr reference_select_code_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureTemporalScalableExtension']/field[@name='reference_select_code']"
		[Register ("reference_select_code")]
		public int ReferenceSelectCode {
			get {
				if (reference_select_code_jfieldId == IntPtr.Zero)
					reference_select_code_jfieldId = JNIEnv.GetFieldID (class_ref, "reference_select_code", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, reference_select_code_jfieldId);
			}
			set {
				if (reference_select_code_jfieldId == IntPtr.Zero)
					reference_select_code_jfieldId = JNIEnv.GetFieldID (class_ref, "reference_select_code", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, reference_select_code_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/PictureTemporalScalableExtension", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PictureTemporalScalableExtension); }
		}

		protected PictureTemporalScalableExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureTemporalScalableExtension']/constructor[@name='PictureTemporalScalableExtension' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PictureTemporalScalableExtension ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PictureTemporalScalableExtension)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureTemporalScalableExtension']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureTemporalScalableExtension;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureTemporalScalableExtension Read (global::Org.Jcodec.Common.IO.BitReader @in)
		{
			if (id_read_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_read_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureTemporalScalableExtension;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureTemporalScalableExtension __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureTemporalScalableExtension> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_common_io_BitReader_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureTemporalScalableExtension __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureTemporalScalableExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer bb = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bb, JniHandleOwnership.DoNotTransfer);
			__this.Write (bb);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureTemporalScalableExtension']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
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
