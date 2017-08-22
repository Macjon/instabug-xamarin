using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/SequenceScalableExtension", DoNotGenerateAcw=true)]
	public partial class SequenceScalableExtension : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='DATA_PARTITIONING']"
		[Register ("DATA_PARTITIONING")]
		public const int DataPartitioning = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='SNR_SCALABILITY']"
		[Register ("SNR_SCALABILITY")]
		public const int SnrScalability = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='SPATIAL_SCALABILITY']"
		[Register ("SPATIAL_SCALABILITY")]
		public const int SpatialScalability = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='TEMPORAL_SCALABILITY']"
		[Register ("TEMPORAL_SCALABILITY")]
		public const int TemporalScalability = (int) 3;

		static IntPtr horizontal_subsampling_factor_m_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='horizontal_subsampling_factor_m']"
		[Register ("horizontal_subsampling_factor_m")]
		public int HorizontalSubsamplingFactorM {
			get {
				if (horizontal_subsampling_factor_m_jfieldId == IntPtr.Zero)
					horizontal_subsampling_factor_m_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontal_subsampling_factor_m", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, horizontal_subsampling_factor_m_jfieldId);
			}
			set {
				if (horizontal_subsampling_factor_m_jfieldId == IntPtr.Zero)
					horizontal_subsampling_factor_m_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontal_subsampling_factor_m", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, horizontal_subsampling_factor_m_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr horizontal_subsampling_factor_n_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='horizontal_subsampling_factor_n']"
		[Register ("horizontal_subsampling_factor_n")]
		public int HorizontalSubsamplingFactorN {
			get {
				if (horizontal_subsampling_factor_n_jfieldId == IntPtr.Zero)
					horizontal_subsampling_factor_n_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontal_subsampling_factor_n", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, horizontal_subsampling_factor_n_jfieldId);
			}
			set {
				if (horizontal_subsampling_factor_n_jfieldId == IntPtr.Zero)
					horizontal_subsampling_factor_n_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontal_subsampling_factor_n", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, horizontal_subsampling_factor_n_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr layer_id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='layer_id']"
		[Register ("layer_id")]
		public int LayerId {
			get {
				if (layer_id_jfieldId == IntPtr.Zero)
					layer_id_jfieldId = JNIEnv.GetFieldID (class_ref, "layer_id", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, layer_id_jfieldId);
			}
			set {
				if (layer_id_jfieldId == IntPtr.Zero)
					layer_id_jfieldId = JNIEnv.GetFieldID (class_ref, "layer_id", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, layer_id_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lower_layer_prediction_horizontal_size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='lower_layer_prediction_horizontal_size']"
		[Register ("lower_layer_prediction_horizontal_size")]
		public int LowerLayerPredictionHorizontalSize {
			get {
				if (lower_layer_prediction_horizontal_size_jfieldId == IntPtr.Zero)
					lower_layer_prediction_horizontal_size_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_prediction_horizontal_size", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lower_layer_prediction_horizontal_size_jfieldId);
			}
			set {
				if (lower_layer_prediction_horizontal_size_jfieldId == IntPtr.Zero)
					lower_layer_prediction_horizontal_size_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_prediction_horizontal_size", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lower_layer_prediction_horizontal_size_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lower_layer_prediction_vertical_size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='lower_layer_prediction_vertical_size']"
		[Register ("lower_layer_prediction_vertical_size")]
		public int LowerLayerPredictionVerticalSize {
			get {
				if (lower_layer_prediction_vertical_size_jfieldId == IntPtr.Zero)
					lower_layer_prediction_vertical_size_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_prediction_vertical_size", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lower_layer_prediction_vertical_size_jfieldId);
			}
			set {
				if (lower_layer_prediction_vertical_size_jfieldId == IntPtr.Zero)
					lower_layer_prediction_vertical_size_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_prediction_vertical_size", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lower_layer_prediction_vertical_size_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mux_to_progressive_sequence_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='mux_to_progressive_sequence']"
		[Register ("mux_to_progressive_sequence")]
		public int MuxToProgressiveSequence {
			get {
				if (mux_to_progressive_sequence_jfieldId == IntPtr.Zero)
					mux_to_progressive_sequence_jfieldId = JNIEnv.GetFieldID (class_ref, "mux_to_progressive_sequence", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mux_to_progressive_sequence_jfieldId);
			}
			set {
				if (mux_to_progressive_sequence_jfieldId == IntPtr.Zero)
					mux_to_progressive_sequence_jfieldId = JNIEnv.GetFieldID (class_ref, "mux_to_progressive_sequence", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mux_to_progressive_sequence_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr picture_mux_enable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='picture_mux_enable']"
		[Register ("picture_mux_enable")]
		public int PictureMuxEnable {
			get {
				if (picture_mux_enable_jfieldId == IntPtr.Zero)
					picture_mux_enable_jfieldId = JNIEnv.GetFieldID (class_ref, "picture_mux_enable", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, picture_mux_enable_jfieldId);
			}
			set {
				if (picture_mux_enable_jfieldId == IntPtr.Zero)
					picture_mux_enable_jfieldId = JNIEnv.GetFieldID (class_ref, "picture_mux_enable", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, picture_mux_enable_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr picture_mux_factor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='picture_mux_factor']"
		[Register ("picture_mux_factor")]
		public int PictureMuxFactor {
			get {
				if (picture_mux_factor_jfieldId == IntPtr.Zero)
					picture_mux_factor_jfieldId = JNIEnv.GetFieldID (class_ref, "picture_mux_factor", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, picture_mux_factor_jfieldId);
			}
			set {
				if (picture_mux_factor_jfieldId == IntPtr.Zero)
					picture_mux_factor_jfieldId = JNIEnv.GetFieldID (class_ref, "picture_mux_factor", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, picture_mux_factor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr picture_mux_order_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='picture_mux_order']"
		[Register ("picture_mux_order")]
		public int PictureMuxOrder {
			get {
				if (picture_mux_order_jfieldId == IntPtr.Zero)
					picture_mux_order_jfieldId = JNIEnv.GetFieldID (class_ref, "picture_mux_order", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, picture_mux_order_jfieldId);
			}
			set {
				if (picture_mux_order_jfieldId == IntPtr.Zero)
					picture_mux_order_jfieldId = JNIEnv.GetFieldID (class_ref, "picture_mux_order", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, picture_mux_order_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr scalable_mode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='scalable_mode']"
		[Register ("scalable_mode")]
		public int ScalableMode {
			get {
				if (scalable_mode_jfieldId == IntPtr.Zero)
					scalable_mode_jfieldId = JNIEnv.GetFieldID (class_ref, "scalable_mode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, scalable_mode_jfieldId);
			}
			set {
				if (scalable_mode_jfieldId == IntPtr.Zero)
					scalable_mode_jfieldId = JNIEnv.GetFieldID (class_ref, "scalable_mode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, scalable_mode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr vertical_subsampling_factor_m_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='vertical_subsampling_factor_m']"
		[Register ("vertical_subsampling_factor_m")]
		public int VerticalSubsamplingFactorM {
			get {
				if (vertical_subsampling_factor_m_jfieldId == IntPtr.Zero)
					vertical_subsampling_factor_m_jfieldId = JNIEnv.GetFieldID (class_ref, "vertical_subsampling_factor_m", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, vertical_subsampling_factor_m_jfieldId);
			}
			set {
				if (vertical_subsampling_factor_m_jfieldId == IntPtr.Zero)
					vertical_subsampling_factor_m_jfieldId = JNIEnv.GetFieldID (class_ref, "vertical_subsampling_factor_m", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vertical_subsampling_factor_m_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr vertical_subsampling_factor_n_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/field[@name='vertical_subsampling_factor_n']"
		[Register ("vertical_subsampling_factor_n")]
		public int VerticalSubsamplingFactorN {
			get {
				if (vertical_subsampling_factor_n_jfieldId == IntPtr.Zero)
					vertical_subsampling_factor_n_jfieldId = JNIEnv.GetFieldID (class_ref, "vertical_subsampling_factor_n", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, vertical_subsampling_factor_n_jfieldId);
			}
			set {
				if (vertical_subsampling_factor_n_jfieldId == IntPtr.Zero)
					vertical_subsampling_factor_n_jfieldId = JNIEnv.GetFieldID (class_ref, "vertical_subsampling_factor_n", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vertical_subsampling_factor_n_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/SequenceScalableExtension", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SequenceScalableExtension); }
		}

		protected SequenceScalableExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/constructor[@name='SequenceScalableExtension' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SequenceScalableExtension ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SequenceScalableExtension)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/SequenceScalableExtension;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceScalableExtension Read (global::Org.Jcodec.Common.IO.BitReader @in)
		{
			if (id_read_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_read_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/SequenceScalableExtension;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceScalableExtension __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceScalableExtension> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_common_io_BitReader_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceScalableExtension __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceScalableExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer bb = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bb, JniHandleOwnership.DoNotTransfer);
			__this.Write (bb);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceScalableExtension']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
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
