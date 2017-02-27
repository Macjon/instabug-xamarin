using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/SequenceHeader", DoNotGenerateAcw=true)]
	public partial class SequenceHeader : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='Sequence_Display_Extension']"
		[Register ("Sequence_Display_Extension")]
		public const int SequenceDisplayExtension = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='Sequence_Extension']"
		[Register ("Sequence_Extension")]
		public const int SequenceExtension = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='Sequence_Scalable_Extension']"
		[Register ("Sequence_Scalable_Extension")]
		public const int SequenceScalableExtension = (int) 5;

		static IntPtr aspect_ratio_information_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='aspect_ratio_information']"
		[Register ("aspect_ratio_information")]
		public int AspectRatioInformation {
			get {
				if (aspect_ratio_information_jfieldId == IntPtr.Zero)
					aspect_ratio_information_jfieldId = JNIEnv.GetFieldID (class_ref, "aspect_ratio_information", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, aspect_ratio_information_jfieldId);
			}
			set {
				if (aspect_ratio_information_jfieldId == IntPtr.Zero)
					aspect_ratio_information_jfieldId = JNIEnv.GetFieldID (class_ref, "aspect_ratio_information", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, aspect_ratio_information_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bit_rate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='bit_rate']"
		[Register ("bit_rate")]
		public int BitRate {
			get {
				if (bit_rate_jfieldId == IntPtr.Zero)
					bit_rate_jfieldId = JNIEnv.GetFieldID (class_ref, "bit_rate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, bit_rate_jfieldId);
			}
			set {
				if (bit_rate_jfieldId == IntPtr.Zero)
					bit_rate_jfieldId = JNIEnv.GetFieldID (class_ref, "bit_rate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bit_rate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr constrained_parameters_flag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='constrained_parameters_flag']"
		[Register ("constrained_parameters_flag")]
		public int ConstrainedParametersFlag {
			get {
				if (constrained_parameters_flag_jfieldId == IntPtr.Zero)
					constrained_parameters_flag_jfieldId = JNIEnv.GetFieldID (class_ref, "constrained_parameters_flag", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, constrained_parameters_flag_jfieldId);
			}
			set {
				if (constrained_parameters_flag_jfieldId == IntPtr.Zero)
					constrained_parameters_flag_jfieldId = JNIEnv.GetFieldID (class_ref, "constrained_parameters_flag", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, constrained_parameters_flag_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr frame_rate_code_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='frame_rate_code']"
		[Register ("frame_rate_code")]
		public int FrameRateCode {
			get {
				if (frame_rate_code_jfieldId == IntPtr.Zero)
					frame_rate_code_jfieldId = JNIEnv.GetFieldID (class_ref, "frame_rate_code", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, frame_rate_code_jfieldId);
			}
			set {
				if (frame_rate_code_jfieldId == IntPtr.Zero)
					frame_rate_code_jfieldId = JNIEnv.GetFieldID (class_ref, "frame_rate_code", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frame_rate_code_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr horizontal_size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='horizontal_size']"
		[Register ("horizontal_size")]
		public int HorizontalSize {
			get {
				if (horizontal_size_jfieldId == IntPtr.Zero)
					horizontal_size_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontal_size", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, horizontal_size_jfieldId);
			}
			set {
				if (horizontal_size_jfieldId == IntPtr.Zero)
					horizontal_size_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontal_size", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, horizontal_size_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr intra_quantiser_matrix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='intra_quantiser_matrix']"
		[Register ("intra_quantiser_matrix")]
		public IList<int> IntraQuantiserMatrix {
			get {
				if (intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "intra_quantiser_matrix", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, intra_quantiser_matrix_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "intra_quantiser_matrix", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, intra_quantiser_matrix_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr non_intra_quantiser_matrix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='non_intra_quantiser_matrix']"
		[Register ("non_intra_quantiser_matrix")]
		public IList<int> NonIntraQuantiserMatrix {
			get {
				if (non_intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					non_intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "non_intra_quantiser_matrix", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, non_intra_quantiser_matrix_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (non_intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					non_intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "non_intra_quantiser_matrix", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, non_intra_quantiser_matrix_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vbv_buffer_size_value_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='vbv_buffer_size_value']"
		[Register ("vbv_buffer_size_value")]
		public int VbvBufferSizeValue {
			get {
				if (vbv_buffer_size_value_jfieldId == IntPtr.Zero)
					vbv_buffer_size_value_jfieldId = JNIEnv.GetFieldID (class_ref, "vbv_buffer_size_value", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, vbv_buffer_size_value_jfieldId);
			}
			set {
				if (vbv_buffer_size_value_jfieldId == IntPtr.Zero)
					vbv_buffer_size_value_jfieldId = JNIEnv.GetFieldID (class_ref, "vbv_buffer_size_value", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vbv_buffer_size_value_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr vertical_size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/field[@name='vertical_size']"
		[Register ("vertical_size")]
		public int VerticalSize {
			get {
				if (vertical_size_jfieldId == IntPtr.Zero)
					vertical_size_jfieldId = JNIEnv.GetFieldID (class_ref, "vertical_size", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, vertical_size_jfieldId);
			}
			set {
				if (vertical_size_jfieldId == IntPtr.Zero)
					vertical_size_jfieldId = JNIEnv.GetFieldID (class_ref, "vertical_size", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vertical_size_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/SequenceHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SequenceHeader); }
		}

		protected SequenceHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIIIIIIarrayIarrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/constructor[@name='SequenceHeader' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int[]'] and parameter[9][@type='int[]']]"
		[Register (".ctor", "(IIIIIII[I[I)V", "")]
		public unsafe SequenceHeader (int p0, int p1, int p2, int p3, int p4, int p5, int p6, int[] p7, int[] p8)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p7 = JNIEnv.NewArray (p7);
			IntPtr native_p8 = JNIEnv.NewArray (p8);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (native_p8);
				if (((object) this).GetType () != typeof (SequenceHeader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IIIIIII[I[I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIIIII[I[I)V", __args);
					return;
				}

				if (id_ctor_IIIIIIIarrayIarrayI == IntPtr.Zero)
					id_ctor_IIIIIIIarrayIarrayI = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIIIII[I[I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIIIIIarrayIarrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIIIIIarrayIarrayI, __args);
			} finally {
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
				if (p8 != null) {
					JNIEnv.CopyArray (native_p8, p8);
					JNIEnv.DeleteLocalRef (native_p8);
				}
			}
		}

		static Delegate cb_hasExtensions;
#pragma warning disable 0169
		static Delegate GetHasExtensionsHandler ()
		{
			if (cb_hasExtensions == null)
				cb_hasExtensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasExtensions);
			return cb_hasExtensions;
		}

		static bool n_HasExtensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasExtensions;
		}
#pragma warning restore 0169

		static IntPtr id_hasExtensions;
		public virtual unsafe bool HasExtensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/method[@name='hasExtensions' and count(parameter)=0]"
			[Register ("hasExtensions", "()Z", "GetHasExtensionsHandler")]
			get {
				if (id_hasExtensions == IntPtr.Zero)
					id_hasExtensions = JNIEnv.GetMethodID (class_ref, "hasExtensions", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasExtensions);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasExtensions", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_copyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_;
#pragma warning disable 0169
		static Delegate GetCopyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Handler ()
		{
			if (cb_copyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_ == null)
				cb_copyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CopyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_);
			return cb_copyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_;
		}

		static void n_CopyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CopyExtensions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_copyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/method[@name='copyExtensions' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.mpeg12.bitstream.SequenceHeader']]"
		[Register ("copyExtensions", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;)V", "GetCopyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Handler")]
		public virtual unsafe void CopyExtensions (global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader p0)
		{
			if (id_copyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_ == IntPtr.Zero)
				id_copyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_ = JNIEnv.GetMethodID (class_ref, "copyExtensions", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_copyExtensions_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyExtensions", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader Read (global::Java.Nio.ByteBuffer p0)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readExtension_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/method[@name='readExtension' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='org.jcodec.codecs.mpeg12.bitstream.SequenceHeader']]"
		[Register ("readExtension", "(Ljava/nio/ByteBuffer;Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;)V", "")]
		public static unsafe void ReadExtension (global::Java.Nio.ByteBuffer p0, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader p1)
		{
			if (id_readExtension_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_ == IntPtr.Zero)
				id_readExtension_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_ = JNIEnv.GetStaticMethodID (class_ref, "readExtension", "(Ljava/nio/ByteBuffer;Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_readExtension_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_, __args);
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
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='SequenceHeader']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
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
