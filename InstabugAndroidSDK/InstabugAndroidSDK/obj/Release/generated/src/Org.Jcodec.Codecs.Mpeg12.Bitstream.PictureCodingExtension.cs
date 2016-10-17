using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/PictureCodingExtension", DoNotGenerateAcw=true)]
	public partial class PictureCodingExtension : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='Bottom_Field']"
		[Register ("Bottom_Field")]
		public const int BottomField = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='Frame']"
		[Register ("Frame")]
		public const int Frame = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='Top_Field']"
		[Register ("Top_Field")]
		public const int TopField = (int) 1;

		static IntPtr alternate_scan_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='alternate_scan']"
		[Register ("alternate_scan")]
		public int AlternateScan {
			get {
				if (alternate_scan_jfieldId == IntPtr.Zero)
					alternate_scan_jfieldId = JNIEnv.GetFieldID (class_ref, "alternate_scan", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, alternate_scan_jfieldId);
			}
			set {
				if (alternate_scan_jfieldId == IntPtr.Zero)
					alternate_scan_jfieldId = JNIEnv.GetFieldID (class_ref, "alternate_scan", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, alternate_scan_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr chroma_420_type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='chroma_420_type']"
		[Register ("chroma_420_type")]
		public int Chroma420Type {
			get {
				if (chroma_420_type_jfieldId == IntPtr.Zero)
					chroma_420_type_jfieldId = JNIEnv.GetFieldID (class_ref, "chroma_420_type", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, chroma_420_type_jfieldId);
			}
			set {
				if (chroma_420_type_jfieldId == IntPtr.Zero)
					chroma_420_type_jfieldId = JNIEnv.GetFieldID (class_ref, "chroma_420_type", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chroma_420_type_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr concealment_motion_vectors_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='concealment_motion_vectors']"
		[Register ("concealment_motion_vectors")]
		public int ConcealmentMotionVectors {
			get {
				if (concealment_motion_vectors_jfieldId == IntPtr.Zero)
					concealment_motion_vectors_jfieldId = JNIEnv.GetFieldID (class_ref, "concealment_motion_vectors", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, concealment_motion_vectors_jfieldId);
			}
			set {
				if (concealment_motion_vectors_jfieldId == IntPtr.Zero)
					concealment_motion_vectors_jfieldId = JNIEnv.GetFieldID (class_ref, "concealment_motion_vectors", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, concealment_motion_vectors_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr f_code_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='f_code']"
		[Register ("f_code")]
		public IList<int[]> FCode {
			get {
				if (f_code_jfieldId == IntPtr.Zero)
					f_code_jfieldId = JNIEnv.GetFieldID (class_ref, "f_code", "[[I");
				return global::Android.Runtime.JavaArray<int[]>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, f_code_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (f_code_jfieldId == IntPtr.Zero)
					f_code_jfieldId = JNIEnv.GetFieldID (class_ref, "f_code", "[[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int[]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, f_code_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr frame_pred_frame_dct_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='frame_pred_frame_dct']"
		[Register ("frame_pred_frame_dct")]
		public int FramePredFrameDct {
			get {
				if (frame_pred_frame_dct_jfieldId == IntPtr.Zero)
					frame_pred_frame_dct_jfieldId = JNIEnv.GetFieldID (class_ref, "frame_pred_frame_dct", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, frame_pred_frame_dct_jfieldId);
			}
			set {
				if (frame_pred_frame_dct_jfieldId == IntPtr.Zero)
					frame_pred_frame_dct_jfieldId = JNIEnv.GetFieldID (class_ref, "frame_pred_frame_dct", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frame_pred_frame_dct_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr intra_dc_precision_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='intra_dc_precision']"
		[Register ("intra_dc_precision")]
		public int IntraDcPrecision {
			get {
				if (intra_dc_precision_jfieldId == IntPtr.Zero)
					intra_dc_precision_jfieldId = JNIEnv.GetFieldID (class_ref, "intra_dc_precision", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, intra_dc_precision_jfieldId);
			}
			set {
				if (intra_dc_precision_jfieldId == IntPtr.Zero)
					intra_dc_precision_jfieldId = JNIEnv.GetFieldID (class_ref, "intra_dc_precision", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, intra_dc_precision_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr intra_vlc_format_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='intra_vlc_format']"
		[Register ("intra_vlc_format")]
		public int IntraVlcFormat {
			get {
				if (intra_vlc_format_jfieldId == IntPtr.Zero)
					intra_vlc_format_jfieldId = JNIEnv.GetFieldID (class_ref, "intra_vlc_format", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, intra_vlc_format_jfieldId);
			}
			set {
				if (intra_vlc_format_jfieldId == IntPtr.Zero)
					intra_vlc_format_jfieldId = JNIEnv.GetFieldID (class_ref, "intra_vlc_format", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, intra_vlc_format_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr picture_structure_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='picture_structure']"
		[Register ("picture_structure")]
		public int PictureStructure {
			get {
				if (picture_structure_jfieldId == IntPtr.Zero)
					picture_structure_jfieldId = JNIEnv.GetFieldID (class_ref, "picture_structure", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, picture_structure_jfieldId);
			}
			set {
				if (picture_structure_jfieldId == IntPtr.Zero)
					picture_structure_jfieldId = JNIEnv.GetFieldID (class_ref, "picture_structure", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, picture_structure_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr progressive_frame_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='progressive_frame']"
		[Register ("progressive_frame")]
		public int ProgressiveFrame {
			get {
				if (progressive_frame_jfieldId == IntPtr.Zero)
					progressive_frame_jfieldId = JNIEnv.GetFieldID (class_ref, "progressive_frame", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, progressive_frame_jfieldId);
			}
			set {
				if (progressive_frame_jfieldId == IntPtr.Zero)
					progressive_frame_jfieldId = JNIEnv.GetFieldID (class_ref, "progressive_frame", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, progressive_frame_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr q_scale_type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='q_scale_type']"
		[Register ("q_scale_type")]
		public int QScaleType {
			get {
				if (q_scale_type_jfieldId == IntPtr.Zero)
					q_scale_type_jfieldId = JNIEnv.GetFieldID (class_ref, "q_scale_type", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, q_scale_type_jfieldId);
			}
			set {
				if (q_scale_type_jfieldId == IntPtr.Zero)
					q_scale_type_jfieldId = JNIEnv.GetFieldID (class_ref, "q_scale_type", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, q_scale_type_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr repeat_first_field_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='repeat_first_field']"
		[Register ("repeat_first_field")]
		public int RepeatFirstField {
			get {
				if (repeat_first_field_jfieldId == IntPtr.Zero)
					repeat_first_field_jfieldId = JNIEnv.GetFieldID (class_ref, "repeat_first_field", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, repeat_first_field_jfieldId);
			}
			set {
				if (repeat_first_field_jfieldId == IntPtr.Zero)
					repeat_first_field_jfieldId = JNIEnv.GetFieldID (class_ref, "repeat_first_field", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, repeat_first_field_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr top_field_first_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/field[@name='top_field_first']"
		[Register ("top_field_first")]
		public int TopFieldFirst {
			get {
				if (top_field_first_jfieldId == IntPtr.Zero)
					top_field_first_jfieldId = JNIEnv.GetFieldID (class_ref, "top_field_first", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, top_field_first_jfieldId);
			}
			set {
				if (top_field_first_jfieldId == IntPtr.Zero)
					top_field_first_jfieldId = JNIEnv.GetFieldID (class_ref, "top_field_first", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, top_field_first_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension.CompositeDisplay']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/PictureCodingExtension$CompositeDisplay", DoNotGenerateAcw=true)]
		public partial class CompositeDisplay : global::Java.Lang.Object {


			static IntPtr burst_amplitude_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension.CompositeDisplay']/field[@name='burst_amplitude']"
			[Register ("burst_amplitude")]
			public int BurstAmplitude {
				get {
					if (burst_amplitude_jfieldId == IntPtr.Zero)
						burst_amplitude_jfieldId = JNIEnv.GetFieldID (class_ref, "burst_amplitude", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, burst_amplitude_jfieldId);
				}
				set {
					if (burst_amplitude_jfieldId == IntPtr.Zero)
						burst_amplitude_jfieldId = JNIEnv.GetFieldID (class_ref, "burst_amplitude", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, burst_amplitude_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr field_sequence_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension.CompositeDisplay']/field[@name='field_sequence']"
			[Register ("field_sequence")]
			public int FieldSequence {
				get {
					if (field_sequence_jfieldId == IntPtr.Zero)
						field_sequence_jfieldId = JNIEnv.GetFieldID (class_ref, "field_sequence", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, field_sequence_jfieldId);
				}
				set {
					if (field_sequence_jfieldId == IntPtr.Zero)
						field_sequence_jfieldId = JNIEnv.GetFieldID (class_ref, "field_sequence", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, field_sequence_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr sub_carrier_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension.CompositeDisplay']/field[@name='sub_carrier']"
			[Register ("sub_carrier")]
			public int SubCarrier {
				get {
					if (sub_carrier_jfieldId == IntPtr.Zero)
						sub_carrier_jfieldId = JNIEnv.GetFieldID (class_ref, "sub_carrier", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sub_carrier_jfieldId);
				}
				set {
					if (sub_carrier_jfieldId == IntPtr.Zero)
						sub_carrier_jfieldId = JNIEnv.GetFieldID (class_ref, "sub_carrier", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sub_carrier_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr sub_carrier_phase_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension.CompositeDisplay']/field[@name='sub_carrier_phase']"
			[Register ("sub_carrier_phase")]
			public int SubCarrierPhase {
				get {
					if (sub_carrier_phase_jfieldId == IntPtr.Zero)
						sub_carrier_phase_jfieldId = JNIEnv.GetFieldID (class_ref, "sub_carrier_phase", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sub_carrier_phase_jfieldId);
				}
				set {
					if (sub_carrier_phase_jfieldId == IntPtr.Zero)
						sub_carrier_phase_jfieldId = JNIEnv.GetFieldID (class_ref, "sub_carrier_phase", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sub_carrier_phase_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr v_axis_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension.CompositeDisplay']/field[@name='v_axis']"
			[Register ("v_axis")]
			public int VAxis {
				get {
					if (v_axis_jfieldId == IntPtr.Zero)
						v_axis_jfieldId = JNIEnv.GetFieldID (class_ref, "v_axis", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, v_axis_jfieldId);
				}
				set {
					if (v_axis_jfieldId == IntPtr.Zero)
						v_axis_jfieldId = JNIEnv.GetFieldID (class_ref, "v_axis", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, v_axis_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/PictureCodingExtension$CompositeDisplay", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CompositeDisplay); }
			}

			protected CompositeDisplay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension.CompositeDisplay']/constructor[@name='PictureCodingExtension.CompositeDisplay' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CompositeDisplay ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (CompositeDisplay)) {
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

			static IntPtr id_read_Lorg_jcodec_common_io_BitReader_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension.CompositeDisplay']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
			[Register ("read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureCodingExtension$CompositeDisplay;", "")]
			public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureCodingExtension.CompositeDisplay Read (global::Org.Jcodec.Common.IO.BitReader p0)
			{
				if (id_read_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
					id_read_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureCodingExtension$CompositeDisplay;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureCodingExtension.CompositeDisplay __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureCodingExtension.CompositeDisplay> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_common_io_BitReader_, __args), JniHandleOwnership.TransferLocalRef);
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

			static void n_Write_Lorg_jcodec_common_io_BitWriter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureCodingExtension.CompositeDisplay __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureCodingExtension.CompositeDisplay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Common.IO.BitWriter p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Write (p0);
			}
#pragma warning restore 0169

			static IntPtr id_write_Lorg_jcodec_common_io_BitWriter_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension.CompositeDisplay']/method[@name='write' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitWriter']]"
			[Register ("write", "(Lorg/jcodec/common/io/BitWriter;)V", "GetWrite_Lorg_jcodec_common_io_BitWriter_Handler")]
			public virtual unsafe void Write (global::Org.Jcodec.Common.IO.BitWriter p0)
			{
				if (id_write_Lorg_jcodec_common_io_BitWriter_ == IntPtr.Zero)
					id_write_Lorg_jcodec_common_io_BitWriter_ = JNIEnv.GetMethodID (class_ref, "write", "(Lorg/jcodec/common/io/BitWriter;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lorg_jcodec_common_io_BitWriter_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lorg/jcodec/common/io/BitWriter;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/PictureCodingExtension", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PictureCodingExtension); }
		}

		protected PictureCodingExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/constructor[@name='PictureCodingExtension' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PictureCodingExtension ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PictureCodingExtension)) {
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

		static IntPtr id_read_Lorg_jcodec_common_io_BitReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureCodingExtension;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureCodingExtension Read (global::Org.Jcodec.Common.IO.BitReader p0)
		{
			if (id_read_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_read_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureCodingExtension;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureCodingExtension __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureCodingExtension> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_common_io_BitReader_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureCodingExtension __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureCodingExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureCodingExtension']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)V", "GetWrite_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Write (global::Java.Nio.ByteBuffer p0)
		{
			if (id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
