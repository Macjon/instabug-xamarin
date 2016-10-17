using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/PictureHeader", DoNotGenerateAcw=true)]
	public partial class PictureHeader : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='BiPredictiveCoded']"
		[Register ("BiPredictiveCoded")]
		public const int BiPredictiveCoded = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='Copyright_Extension']"
		[Register ("Copyright_Extension")]
		public const int CopyrightExtension = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='IntraCoded']"
		[Register ("IntraCoded")]
		public const int IntraCoded = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='Picture_Coding_Extension']"
		[Register ("Picture_Coding_Extension")]
		public const int PictureCodingExtension = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='Picture_Display_Extension']"
		[Register ("Picture_Display_Extension")]
		public const int PictureDisplayExtension = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='Picture_Spatial_Scalable_Extension']"
		[Register ("Picture_Spatial_Scalable_Extension")]
		public const int PictureSpatialScalableExtension = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='Picture_Temporal_Scalable_Extension']"
		[Register ("Picture_Temporal_Scalable_Extension")]
		public const int PictureTemporalScalableExtension = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='PredictiveCoded']"
		[Register ("PredictiveCoded")]
		public const int PredictiveCoded = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='Quant_Matrix_Extension']"
		[Register ("Quant_Matrix_Extension")]
		public const int QuantMatrixExtension = (int) 3;

		static IntPtr backward_f_code_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='backward_f_code']"
		[Register ("backward_f_code")]
		public int BackwardFCode {
			get {
				if (backward_f_code_jfieldId == IntPtr.Zero)
					backward_f_code_jfieldId = JNIEnv.GetFieldID (class_ref, "backward_f_code", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, backward_f_code_jfieldId);
			}
			set {
				if (backward_f_code_jfieldId == IntPtr.Zero)
					backward_f_code_jfieldId = JNIEnv.GetFieldID (class_ref, "backward_f_code", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, backward_f_code_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr forward_f_code_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='forward_f_code']"
		[Register ("forward_f_code")]
		public int ForwardFCode {
			get {
				if (forward_f_code_jfieldId == IntPtr.Zero)
					forward_f_code_jfieldId = JNIEnv.GetFieldID (class_ref, "forward_f_code", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, forward_f_code_jfieldId);
			}
			set {
				if (forward_f_code_jfieldId == IntPtr.Zero)
					forward_f_code_jfieldId = JNIEnv.GetFieldID (class_ref, "forward_f_code", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, forward_f_code_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr full_pel_backward_vector_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='full_pel_backward_vector']"
		[Register ("full_pel_backward_vector")]
		public int FullPelBackwardVector {
			get {
				if (full_pel_backward_vector_jfieldId == IntPtr.Zero)
					full_pel_backward_vector_jfieldId = JNIEnv.GetFieldID (class_ref, "full_pel_backward_vector", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, full_pel_backward_vector_jfieldId);
			}
			set {
				if (full_pel_backward_vector_jfieldId == IntPtr.Zero)
					full_pel_backward_vector_jfieldId = JNIEnv.GetFieldID (class_ref, "full_pel_backward_vector", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, full_pel_backward_vector_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr full_pel_forward_vector_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='full_pel_forward_vector']"
		[Register ("full_pel_forward_vector")]
		public int FullPelForwardVector {
			get {
				if (full_pel_forward_vector_jfieldId == IntPtr.Zero)
					full_pel_forward_vector_jfieldId = JNIEnv.GetFieldID (class_ref, "full_pel_forward_vector", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, full_pel_forward_vector_jfieldId);
			}
			set {
				if (full_pel_forward_vector_jfieldId == IntPtr.Zero)
					full_pel_forward_vector_jfieldId = JNIEnv.GetFieldID (class_ref, "full_pel_forward_vector", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, full_pel_forward_vector_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr picture_coding_type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='picture_coding_type']"
		[Register ("picture_coding_type")]
		public int PictureCodingType {
			get {
				if (picture_coding_type_jfieldId == IntPtr.Zero)
					picture_coding_type_jfieldId = JNIEnv.GetFieldID (class_ref, "picture_coding_type", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, picture_coding_type_jfieldId);
			}
			set {
				if (picture_coding_type_jfieldId == IntPtr.Zero)
					picture_coding_type_jfieldId = JNIEnv.GetFieldID (class_ref, "picture_coding_type", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, picture_coding_type_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr temporal_reference_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='temporal_reference']"
		[Register ("temporal_reference")]
		public int TemporalReference {
			get {
				if (temporal_reference_jfieldId == IntPtr.Zero)
					temporal_reference_jfieldId = JNIEnv.GetFieldID (class_ref, "temporal_reference", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, temporal_reference_jfieldId);
			}
			set {
				if (temporal_reference_jfieldId == IntPtr.Zero)
					temporal_reference_jfieldId = JNIEnv.GetFieldID (class_ref, "temporal_reference", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, temporal_reference_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr vbv_delay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/field[@name='vbv_delay']"
		[Register ("vbv_delay")]
		public int VbvDelay {
			get {
				if (vbv_delay_jfieldId == IntPtr.Zero)
					vbv_delay_jfieldId = JNIEnv.GetFieldID (class_ref, "vbv_delay", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, vbv_delay_jfieldId);
			}
			set {
				if (vbv_delay_jfieldId == IntPtr.Zero)
					vbv_delay_jfieldId = JNIEnv.GetFieldID (class_ref, "vbv_delay", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vbv_delay_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/PictureHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PictureHeader); }
		}

		protected PictureHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIIIIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/constructor[@name='PictureHeader' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register (".ctor", "(IIIIIII)V", "")]
		public unsafe PictureHeader (int p0, int p1, int p2, int p3, int p4, int p5, int p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				if (GetType () != typeof (PictureHeader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIIIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIIIII)V", __args);
					return;
				}

				if (id_ctor_IIIIIII == IntPtr.Zero)
					id_ctor_IIIIIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIIIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIIIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIIIII, __args);
			} finally {
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
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasExtensions;
		}
#pragma warning restore 0169

		static IntPtr id_hasExtensions;
		public virtual unsafe bool HasExtensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/method[@name='hasExtensions' and count(parameter)=0]"
			[Register ("hasExtensions", "()Z", "GetHasExtensionsHandler")]
			get {
				if (id_hasExtensions == IntPtr.Zero)
					id_hasExtensions = JNIEnv.GetMethodID (class_ref, "hasExtensions", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasExtensions);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasExtensions", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader Read (global::Java.Nio.ByteBuffer p0)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readExtension_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/method[@name='readExtension' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='org.jcodec.codecs.mpeg12.bitstream.PictureHeader'] and parameter[3][@type='org.jcodec.codecs.mpeg12.bitstream.SequenceHeader']]"
		[Register ("readExtension", "(Ljava/nio/ByteBuffer;Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;)V", "")]
		public static unsafe void ReadExtension (global::Java.Nio.ByteBuffer p0, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader p1, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader p2)
		{
			if (id_readExtension_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_ == IntPtr.Zero)
				id_readExtension_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_ = JNIEnv.GetStaticMethodID (class_ref, "readExtension", "(Ljava/nio/ByteBuffer;Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_readExtension_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_, __args);
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
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='PictureHeader']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
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
