using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/MXFConst", DoNotGenerateAcw=true)]
	public partial class MXFConst : global::Java.Lang.Object {


		static IntPtr GENERIC_DESCRIPTOR_KLV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst']/field[@name='GENERIC_DESCRIPTOR_KLV']"
		[Register ("GENERIC_DESCRIPTOR_KLV")]
		public static global::Org.Jcodec.Containers.Mxf.Model.UL GenericDescriptorKlv {
			get {
				if (GENERIC_DESCRIPTOR_KLV_jfieldId == IntPtr.Zero)
					GENERIC_DESCRIPTOR_KLV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERIC_DESCRIPTOR_KLV", "Lorg/jcodec/containers/mxf/model/UL;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GENERIC_DESCRIPTOR_KLV_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GENERIC_DESCRIPTOR_KLV_jfieldId == IntPtr.Zero)
					GENERIC_DESCRIPTOR_KLV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERIC_DESCRIPTOR_KLV", "Lorg/jcodec/containers/mxf/model/UL;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, GENERIC_DESCRIPTOR_KLV_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr HEADER_PARTITION_KLV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst']/field[@name='HEADER_PARTITION_KLV']"
		[Register ("HEADER_PARTITION_KLV")]
		public static global::Org.Jcodec.Containers.Mxf.Model.UL HeaderPartitionKlv {
			get {
				if (HEADER_PARTITION_KLV_jfieldId == IntPtr.Zero)
					HEADER_PARTITION_KLV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HEADER_PARTITION_KLV", "Lorg/jcodec/containers/mxf/model/UL;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HEADER_PARTITION_KLV_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HEADER_PARTITION_KLV_jfieldId == IntPtr.Zero)
					HEADER_PARTITION_KLV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HEADER_PARTITION_KLV", "Lorg/jcodec/containers/mxf/model/UL;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, HEADER_PARTITION_KLV_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr INDEX_KLV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst']/field[@name='INDEX_KLV']"
		[Register ("INDEX_KLV")]
		public static global::Org.Jcodec.Containers.Mxf.Model.UL IndexKlv {
			get {
				if (INDEX_KLV_jfieldId == IntPtr.Zero)
					INDEX_KLV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INDEX_KLV", "Lorg/jcodec/containers/mxf/model/UL;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INDEX_KLV_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INDEX_KLV_jfieldId == IntPtr.Zero)
					INDEX_KLV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INDEX_KLV", "Lorg/jcodec/containers/mxf/model/UL;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, INDEX_KLV_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr klMetadataMapping_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst']/field[@name='klMetadataMapping']"
		[Register ("klMetadataMapping")]
		public static global::System.Collections.IDictionary KlMetadataMapping {
			get {
				if (klMetadataMapping_jfieldId == IntPtr.Zero)
					klMetadataMapping_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "klMetadataMapping", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, klMetadataMapping_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (klMetadataMapping_jfieldId == IntPtr.Zero)
					klMetadataMapping_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "klMetadataMapping", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, klMetadataMapping_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.KLVFill']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mxf/MXFConst$KLVFill", DoNotGenerateAcw=true)]
		public partial class KLVFill : global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mxf/MXFConst$KLVFill", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (KLVFill); }
			}

			protected KLVFill (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.KLVFill']/constructor[@name='MXFConst.KLVFill' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
			[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
			public unsafe KLVFill (global::Org.Jcodec.Containers.Mxf.Model.UL ul)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (ul);
					if (((object) this).GetType () != typeof (KLVFill)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/containers/mxf/model/UL;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mxf/model/UL;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_containers_mxf_model_UL_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_containers_mxf_model_UL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mxf/model/UL;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args);
				} finally {
				}
			}

			static Delegate cb_read_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetRead_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_read_Ljava_nio_ByteBuffer_ == null)
					cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_nio_ByteBuffer_);
				return cb_read_Ljava_nio_ByteBuffer_;
			}

			static void n_Read_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bb)
			{
				global::Org.Jcodec.Containers.Mxf.MXFConst.KLVFill __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.KLVFill> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer bb = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bb, JniHandleOwnership.DoNotTransfer);
				__this.Read (bb);
			}
#pragma warning restore 0169

			static IntPtr id_read_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.KLVFill']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("read", "(Ljava/nio/ByteBuffer;)V", "GetRead_Ljava_nio_ByteBuffer_Handler")]
			public override unsafe void Read (global::Java.Nio.ByteBuffer bb)
			{
				if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (bb);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_ByteBuffer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/nio/ByteBuffer;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mxf/MXFConst$MXFCodecMapping", DoNotGenerateAcw=true)]
		public sealed partial class MXFCodecMapping : global::Java.Lang.Enum {


			static IntPtr AC3_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='AC3']"
			[Register ("AC3")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Ac3 {
				get {
					if (AC3_jfieldId == IntPtr.Zero)
						AC3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AC3", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AC3_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AVC_INTRA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='AVC_INTRA']"
			[Register ("AVC_INTRA")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping AvcIntra {
				get {
					if (AVC_INTRA_jfieldId == IntPtr.Zero)
						AVC_INTRA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AVC_INTRA", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AVC_INTRA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DV_25_PAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='DV_25_PAL']"
			[Register ("DV_25_PAL")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Dv25Pal {
				get {
					if (DV_25_PAL_jfieldId == IntPtr.Zero)
						DV_25_PAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DV_25_PAL", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DV_25_PAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr JPEG2000_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='JPEG2000']"
			[Register ("JPEG2000")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Jpeg2000 {
				get {
					if (JPEG2000_jfieldId == IntPtr.Zero)
						JPEG2000_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JPEG2000", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JPEG2000_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MP2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='MP2']"
			[Register ("MP2")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Mp2 {
				get {
					if (MP2_jfieldId == IntPtr.Zero)
						MP2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MP2", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MP2_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MPEG2_D10_PAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='MPEG2_D10_PAL']"
			[Register ("MPEG2_D10_PAL")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Mpeg2D10Pal {
				get {
					if (MPEG2_D10_PAL_jfieldId == IntPtr.Zero)
						MPEG2_D10_PAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MPEG2_D10_PAL", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MPEG2_D10_PAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MPEG2_HL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='MPEG2_HL']"
			[Register ("MPEG2_HL")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Mpeg2Hl {
				get {
					if (MPEG2_HL_jfieldId == IntPtr.Zero)
						MPEG2_HL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MPEG2_HL", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MPEG2_HL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MPEG2_HL_422_I_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='MPEG2_HL_422_I']"
			[Register ("MPEG2_HL_422_I")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Mpeg2Hl422I {
				get {
					if (MPEG2_HL_422_I_jfieldId == IntPtr.Zero)
						MPEG2_HL_422_I_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MPEG2_HL_422_I", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MPEG2_HL_422_I_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MPEG2_ML_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='MPEG2_ML']"
			[Register ("MPEG2_ML")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Mpeg2Ml {
				get {
					if (MPEG2_ML_jfieldId == IntPtr.Zero)
						MPEG2_ML_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MPEG2_ML", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MPEG2_ML_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MPEG2_XDCAM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='MPEG2_XDCAM']"
			[Register ("MPEG2_XDCAM")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Mpeg2Xdcam {
				get {
					if (MPEG2_XDCAM_jfieldId == IntPtr.Zero)
						MPEG2_XDCAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MPEG2_XDCAM", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MPEG2_XDCAM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MPEG4_XDCAM_PROXY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='MPEG4_XDCAM_PROXY']"
			[Register ("MPEG4_XDCAM_PROXY")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Mpeg4XdcamProxy {
				get {
					if (MPEG4_XDCAM_PROXY_jfieldId == IntPtr.Zero)
						MPEG4_XDCAM_PROXY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MPEG4_XDCAM_PROXY", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MPEG4_XDCAM_PROXY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PCM_ALAW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='PCM_ALAW']"
			[Register ("PCM_ALAW")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping PcmAlaw {
				get {
					if (PCM_ALAW_jfieldId == IntPtr.Zero)
						PCM_ALAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PCM_ALAW", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PCM_ALAW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PCM_S16BE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='PCM_S16BE']"
			[Register ("PCM_S16BE")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping PcmS16be {
				get {
					if (PCM_S16BE_jfieldId == IntPtr.Zero)
						PCM_S16BE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PCM_S16BE", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PCM_S16BE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PCM_S16LE_1_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='PCM_S16LE_1']"
			[Register ("PCM_S16LE_1")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping PcmS16le1 {
				get {
					if (PCM_S16LE_1_jfieldId == IntPtr.Zero)
						PCM_S16LE_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PCM_S16LE_1", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PCM_S16LE_1_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PCM_S16LE_2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='PCM_S16LE_2']"
			[Register ("PCM_S16LE_2")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping PcmS16le2 {
				get {
					if (PCM_S16LE_2_jfieldId == IntPtr.Zero)
						PCM_S16LE_2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PCM_S16LE_2", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PCM_S16LE_2_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PCM_S16LE_3_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='PCM_S16LE_3']"
			[Register ("PCM_S16LE_3")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping PcmS16le3 {
				get {
					if (PCM_S16LE_3_jfieldId == IntPtr.Zero)
						PCM_S16LE_3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PCM_S16LE_3", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PCM_S16LE_3_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RAW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='RAW']"
			[Register ("RAW")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Raw {
				get {
					if (RAW_jfieldId == IntPtr.Zero)
						RAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RAW", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RAW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr V210_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='V210']"
			[Register ("V210")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping V210 {
				get {
					if (V210_jfieldId == IntPtr.Zero)
						V210_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "V210", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, V210_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VC3_DNXD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/field[@name='VC3_DNXD']"
			[Register ("VC3_DNXD")]
			public static global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping Vc3Dnxd {
				get {
					if (VC3_DNXD_jfieldId == IntPtr.Zero)
						VC3_DNXD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VC3_DNXD", "Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VC3_DNXD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mxf/MXFConst$MXFCodecMapping", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MXFCodecMapping); }
			}

			internal MXFCodecMapping (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getUl;
			public unsafe global::Org.Jcodec.Containers.Mxf.Model.UL Ul {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/method[@name='getUl' and count(parameter)=0]"
				[Register ("getUl", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetUlHandler")]
				get {
					if (id_getUl == IntPtr.Zero)
						id_getUl = JNIEnv.GetMethodID (class_ref, "getUl", "()Lorg/jcodec/containers/mxf/model/UL;");
					try {
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUl), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst.MXFCodecMapping']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/containers/mxf/MXFConst$MXFCodecMapping;");
				try {
					return (global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.MXFConst.MXFCodecMapping));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/MXFConst", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MXFConst); }
		}

		protected MXFConst (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf']/class[@name='MXFConst']/constructor[@name='MXFConst' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MXFConst ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MXFConst)) {
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

	}
}
