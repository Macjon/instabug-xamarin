using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureSpatialScalableExtension']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/PictureSpatialScalableExtension", DoNotGenerateAcw=true)]
	public partial class PictureSpatialScalableExtension : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {


		static IntPtr lower_layer_deinterlaced_field_select_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureSpatialScalableExtension']/field[@name='lower_layer_deinterlaced_field_select']"
		[Register ("lower_layer_deinterlaced_field_select")]
		public int LowerLayerDeinterlacedFieldSelect {
			get {
				if (lower_layer_deinterlaced_field_select_jfieldId == IntPtr.Zero)
					lower_layer_deinterlaced_field_select_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_deinterlaced_field_select", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lower_layer_deinterlaced_field_select_jfieldId);
			}
			set {
				if (lower_layer_deinterlaced_field_select_jfieldId == IntPtr.Zero)
					lower_layer_deinterlaced_field_select_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_deinterlaced_field_select", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lower_layer_deinterlaced_field_select_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lower_layer_horizontal_offset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureSpatialScalableExtension']/field[@name='lower_layer_horizontal_offset']"
		[Register ("lower_layer_horizontal_offset")]
		public int LowerLayerHorizontalOffset {
			get {
				if (lower_layer_horizontal_offset_jfieldId == IntPtr.Zero)
					lower_layer_horizontal_offset_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_horizontal_offset", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lower_layer_horizontal_offset_jfieldId);
			}
			set {
				if (lower_layer_horizontal_offset_jfieldId == IntPtr.Zero)
					lower_layer_horizontal_offset_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_horizontal_offset", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lower_layer_horizontal_offset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lower_layer_progressive_frame_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureSpatialScalableExtension']/field[@name='lower_layer_progressive_frame']"
		[Register ("lower_layer_progressive_frame")]
		public int LowerLayerProgressiveFrame {
			get {
				if (lower_layer_progressive_frame_jfieldId == IntPtr.Zero)
					lower_layer_progressive_frame_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_progressive_frame", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lower_layer_progressive_frame_jfieldId);
			}
			set {
				if (lower_layer_progressive_frame_jfieldId == IntPtr.Zero)
					lower_layer_progressive_frame_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_progressive_frame", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lower_layer_progressive_frame_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lower_layer_temporal_reference_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureSpatialScalableExtension']/field[@name='lower_layer_temporal_reference']"
		[Register ("lower_layer_temporal_reference")]
		public int LowerLayerTemporalReference {
			get {
				if (lower_layer_temporal_reference_jfieldId == IntPtr.Zero)
					lower_layer_temporal_reference_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_temporal_reference", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lower_layer_temporal_reference_jfieldId);
			}
			set {
				if (lower_layer_temporal_reference_jfieldId == IntPtr.Zero)
					lower_layer_temporal_reference_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_temporal_reference", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lower_layer_temporal_reference_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lower_layer_vertical_offset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureSpatialScalableExtension']/field[@name='lower_layer_vertical_offset']"
		[Register ("lower_layer_vertical_offset")]
		public int LowerLayerVerticalOffset {
			get {
				if (lower_layer_vertical_offset_jfieldId == IntPtr.Zero)
					lower_layer_vertical_offset_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_vertical_offset", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lower_layer_vertical_offset_jfieldId);
			}
			set {
				if (lower_layer_vertical_offset_jfieldId == IntPtr.Zero)
					lower_layer_vertical_offset_jfieldId = JNIEnv.GetFieldID (class_ref, "lower_layer_vertical_offset", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lower_layer_vertical_offset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr spatial_temporal_weight_code_table_index_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureSpatialScalableExtension']/field[@name='spatial_temporal_weight_code_table_index']"
		[Register ("spatial_temporal_weight_code_table_index")]
		public int SpatialTemporalWeightCodeTableIndex {
			get {
				if (spatial_temporal_weight_code_table_index_jfieldId == IntPtr.Zero)
					spatial_temporal_weight_code_table_index_jfieldId = JNIEnv.GetFieldID (class_ref, "spatial_temporal_weight_code_table_index", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, spatial_temporal_weight_code_table_index_jfieldId);
			}
			set {
				if (spatial_temporal_weight_code_table_index_jfieldId == IntPtr.Zero)
					spatial_temporal_weight_code_table_index_jfieldId = JNIEnv.GetFieldID (class_ref, "spatial_temporal_weight_code_table_index", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, spatial_temporal_weight_code_table_index_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/PictureSpatialScalableExtension", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PictureSpatialScalableExtension); }
		}

		protected PictureSpatialScalableExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureSpatialScalableExtension']/constructor[@name='PictureSpatialScalableExtension' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PictureSpatialScalableExtension ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PictureSpatialScalableExtension)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureSpatialScalableExtension']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureSpatialScalableExtension;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureSpatialScalableExtension Read (global::Org.Jcodec.Common.IO.BitReader @in)
		{
			if (id_read_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_read_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureSpatialScalableExtension;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureSpatialScalableExtension __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureSpatialScalableExtension> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_common_io_BitReader_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureSpatialScalableExtension __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureSpatialScalableExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer bb = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bb, JniHandleOwnership.DoNotTransfer);
			__this.Write (bb);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureSpatialScalableExtension']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
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
