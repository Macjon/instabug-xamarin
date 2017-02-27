using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPEGConst", DoNotGenerateAcw=true)]
	public partial class MPEGConst : global::Java.Lang.Object {


		static IntPtr BLOCK_POS_X_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='BLOCK_POS_X']"
		[Register ("BLOCK_POS_X")]
		public static IList<int> BlockPosX {
			get {
				if (BLOCK_POS_X_jfieldId == IntPtr.Zero)
					BLOCK_POS_X_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_POS_X", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, BLOCK_POS_X_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BLOCK_POS_X_jfieldId == IntPtr.Zero)
					BLOCK_POS_X_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_POS_X", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, BLOCK_POS_X_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr BLOCK_POS_Y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='BLOCK_POS_Y']"
		[Register ("BLOCK_POS_Y")]
		public static IList<int> BlockPosY {
			get {
				if (BLOCK_POS_Y_jfieldId == IntPtr.Zero)
					BLOCK_POS_Y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_POS_Y", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, BLOCK_POS_Y_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BLOCK_POS_Y_jfieldId == IntPtr.Zero)
					BLOCK_POS_Y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_POS_Y", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, BLOCK_POS_Y_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr BLOCK_TO_CC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='BLOCK_TO_CC']"
		[Register ("BLOCK_TO_CC")]
		public static IList<int> BlockToCc {
			get {
				if (BLOCK_TO_CC_jfieldId == IntPtr.Zero)
					BLOCK_TO_CC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_TO_CC", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, BLOCK_TO_CC_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BLOCK_TO_CC_jfieldId == IntPtr.Zero)
					BLOCK_TO_CC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_TO_CC", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, BLOCK_TO_CC_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='CODE_END']"
		[Register ("CODE_END")]
		public const int CodeEnd = (int) 2048;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='CODE_ESCAPE']"
		[Register ("CODE_ESCAPE")]
		public const int CodeEscape = (int) 2049;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='EXTENSION_START_CODE']"
		[Register ("EXTENSION_START_CODE")]
		public const int ExtensionStartCode = (int) 181;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='GROUP_START_CODE']"
		[Register ("GROUP_START_CODE")]
		public const int GroupStartCode = (int) 184;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='PICTURE_START_CODE']"
		[Register ("PICTURE_START_CODE")]
		public const int PictureStartCode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='SEQUENCE_END_CODE']"
		[Register ("SEQUENCE_END_CODE")]
		public const int SequenceEndCode = (int) 183;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='SEQUENCE_ERROR_CODE']"
		[Register ("SEQUENCE_ERROR_CODE")]
		public const int SequenceErrorCode = (int) 180;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='SEQUENCE_HEADER_CODE']"
		[Register ("SEQUENCE_HEADER_CODE")]
		public const int SequenceHeaderCode = (int) 179;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='SLICE_START_CODE_FIRST']"
		[Register ("SLICE_START_CODE_FIRST")]
		public const int SliceStartCodeFirst = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='SLICE_START_CODE_LAST']"
		[Register ("SLICE_START_CODE_LAST")]
		public const int SliceStartCodeLast = (int) 175;

		static IntPtr SQUEEZE_X_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='SQUEEZE_X']"
		[Register ("SQUEEZE_X")]
		public static IList<int> SqueezeX {
			get {
				if (SQUEEZE_X_jfieldId == IntPtr.Zero)
					SQUEEZE_X_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SQUEEZE_X", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, SQUEEZE_X_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SQUEEZE_X_jfieldId == IntPtr.Zero)
					SQUEEZE_X_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SQUEEZE_X", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, SQUEEZE_X_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SQUEEZE_Y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='SQUEEZE_Y']"
		[Register ("SQUEEZE_Y")]
		public static IList<int> SqueezeY {
			get {
				if (SQUEEZE_Y_jfieldId == IntPtr.Zero)
					SQUEEZE_Y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SQUEEZE_Y", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, SQUEEZE_Y_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SQUEEZE_Y_jfieldId == IntPtr.Zero)
					SQUEEZE_Y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SQUEEZE_Y", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, SQUEEZE_Y_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr STEP_Y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='STEP_Y']"
		[Register ("STEP_Y")]
		public static IList<int> StepY {
			get {
				if (STEP_Y_jfieldId == IntPtr.Zero)
					STEP_Y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STEP_Y", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, STEP_Y_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (STEP_Y_jfieldId == IntPtr.Zero)
					STEP_Y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STEP_Y", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, STEP_Y_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='USER_DATA_START_CODE']"
		[Register ("USER_DATA_START_CODE")]
		public const int UserDataStartCode = (int) 178;

		static IntPtr defaultQMatInter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='defaultQMatInter']"
		[Register ("defaultQMatInter")]
		public static IList<int> DefaultQMatInter {
			get {
				if (defaultQMatInter_jfieldId == IntPtr.Zero)
					defaultQMatInter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "defaultQMatInter", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, defaultQMatInter_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (defaultQMatInter_jfieldId == IntPtr.Zero)
					defaultQMatInter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "defaultQMatInter", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, defaultQMatInter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr defaultQMatIntra_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='defaultQMatIntra']"
		[Register ("defaultQMatIntra")]
		public static IList<int> DefaultQMatIntra {
			get {
				if (defaultQMatIntra_jfieldId == IntPtr.Zero)
					defaultQMatIntra_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "defaultQMatIntra", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, defaultQMatIntra_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (defaultQMatIntra_jfieldId == IntPtr.Zero)
					defaultQMatIntra_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "defaultQMatIntra", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, defaultQMatIntra_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mbTypeValB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='mbTypeValB']"
		[Register ("mbTypeValB")]
		public static IList<Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType> MbTypeValB {
			get {
				if (mbTypeValB_jfieldId == IntPtr.Zero)
					mbTypeValB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValB", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, mbTypeValB_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mbTypeValB_jfieldId == IntPtr.Zero)
					mbTypeValB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValB", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mbTypeValB_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mbTypeValBSpat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='mbTypeValBSpat']"
		[Register ("mbTypeValBSpat")]
		public static IList<Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType> MbTypeValBSpat {
			get {
				if (mbTypeValBSpat_jfieldId == IntPtr.Zero)
					mbTypeValBSpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValBSpat", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, mbTypeValBSpat_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mbTypeValBSpat_jfieldId == IntPtr.Zero)
					mbTypeValBSpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValBSpat", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mbTypeValBSpat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mbTypeValI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='mbTypeValI']"
		[Register ("mbTypeValI")]
		public static IList<Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType> MbTypeValI {
			get {
				if (mbTypeValI_jfieldId == IntPtr.Zero)
					mbTypeValI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValI", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, mbTypeValI_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mbTypeValI_jfieldId == IntPtr.Zero)
					mbTypeValI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValI", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mbTypeValI_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mbTypeValISpat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='mbTypeValISpat']"
		[Register ("mbTypeValISpat")]
		public static IList<Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType> MbTypeValISpat {
			get {
				if (mbTypeValISpat_jfieldId == IntPtr.Zero)
					mbTypeValISpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValISpat", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, mbTypeValISpat_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mbTypeValISpat_jfieldId == IntPtr.Zero)
					mbTypeValISpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValISpat", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mbTypeValISpat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mbTypeValP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='mbTypeValP']"
		[Register ("mbTypeValP")]
		public static IList<Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType> MbTypeValP {
			get {
				if (mbTypeValP_jfieldId == IntPtr.Zero)
					mbTypeValP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValP", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, mbTypeValP_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mbTypeValP_jfieldId == IntPtr.Zero)
					mbTypeValP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValP", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mbTypeValP_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mbTypeValPSpat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='mbTypeValPSpat']"
		[Register ("mbTypeValPSpat")]
		public static IList<Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType> MbTypeValPSpat {
			get {
				if (mbTypeValPSpat_jfieldId == IntPtr.Zero)
					mbTypeValPSpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValPSpat", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, mbTypeValPSpat_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mbTypeValPSpat_jfieldId == IntPtr.Zero)
					mbTypeValPSpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValPSpat", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mbTypeValPSpat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mbTypeValSNR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='mbTypeValSNR']"
		[Register ("mbTypeValSNR")]
		public static IList<Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType> MbTypeValSNR {
			get {
				if (mbTypeValSNR_jfieldId == IntPtr.Zero)
					mbTypeValSNR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValSNR", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, mbTypeValSNR_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mbTypeValSNR_jfieldId == IntPtr.Zero)
					mbTypeValSNR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mbTypeValSNR", "[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mbTypeValSNR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr qScaleTab1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='qScaleTab1']"
		[Register ("qScaleTab1")]
		public static IList<int> QScaleTab1 {
			get {
				if (qScaleTab1_jfieldId == IntPtr.Zero)
					qScaleTab1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "qScaleTab1", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, qScaleTab1_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (qScaleTab1_jfieldId == IntPtr.Zero)
					qScaleTab1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "qScaleTab1", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, qScaleTab1_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr qScaleTab2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='qScaleTab2']"
		[Register ("qScaleTab2")]
		public static IList<int> QScaleTab2 {
			get {
				if (qScaleTab2_jfieldId == IntPtr.Zero)
					qScaleTab2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "qScaleTab2", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, qScaleTab2_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (qScaleTab2_jfieldId == IntPtr.Zero)
					qScaleTab2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "qScaleTab2", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, qScaleTab2_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr scan_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='scan']"
		[Register ("scan")]
		public static IList<int[]> Scan {
			get {
				if (scan_jfieldId == IntPtr.Zero)
					scan_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "scan", "[[I");
				return global::Android.Runtime.JavaArray<int[]>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, scan_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (scan_jfieldId == IntPtr.Zero)
					scan_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "scan", "[[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int[]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, scan_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcAddressIncrement_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcAddressIncrement']"
		[Register ("vlcAddressIncrement")]
		public static global::Org.Jcodec.Common.IO.VLC VlcAddressIncrement {
			get {
				if (vlcAddressIncrement_jfieldId == IntPtr.Zero)
					vlcAddressIncrement_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcAddressIncrement", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcAddressIncrement_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcAddressIncrement_jfieldId == IntPtr.Zero)
					vlcAddressIncrement_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcAddressIncrement", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcAddressIncrement_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcCBP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcCBP']"
		[Register ("vlcCBP")]
		public static global::Org.Jcodec.Common.IO.VLC VlcCBP {
			get {
				if (vlcCBP_jfieldId == IntPtr.Zero)
					vlcCBP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcCBP", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcCBP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcCBP_jfieldId == IntPtr.Zero)
					vlcCBP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcCBP", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcCBP_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcCoeff0_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcCoeff0']"
		[Register ("vlcCoeff0")]
		public static global::Org.Jcodec.Common.IO.VLC VlcCoeff0 {
			get {
				if (vlcCoeff0_jfieldId == IntPtr.Zero)
					vlcCoeff0_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcCoeff0", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcCoeff0_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcCoeff0_jfieldId == IntPtr.Zero)
					vlcCoeff0_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcCoeff0", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcCoeff0_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcCoeff1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcCoeff1']"
		[Register ("vlcCoeff1")]
		public static global::Org.Jcodec.Common.IO.VLC VlcCoeff1 {
			get {
				if (vlcCoeff1_jfieldId == IntPtr.Zero)
					vlcCoeff1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcCoeff1", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcCoeff1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcCoeff1_jfieldId == IntPtr.Zero)
					vlcCoeff1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcCoeff1", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcCoeff1_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcDCSizeChroma_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcDCSizeChroma']"
		[Register ("vlcDCSizeChroma")]
		public static global::Org.Jcodec.Common.IO.VLC VlcDCSizeChroma {
			get {
				if (vlcDCSizeChroma_jfieldId == IntPtr.Zero)
					vlcDCSizeChroma_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcDCSizeChroma", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcDCSizeChroma_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcDCSizeChroma_jfieldId == IntPtr.Zero)
					vlcDCSizeChroma_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcDCSizeChroma", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcDCSizeChroma_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcDCSizeLuma_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcDCSizeLuma']"
		[Register ("vlcDCSizeLuma")]
		public static global::Org.Jcodec.Common.IO.VLC VlcDCSizeLuma {
			get {
				if (vlcDCSizeLuma_jfieldId == IntPtr.Zero)
					vlcDCSizeLuma_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcDCSizeLuma", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcDCSizeLuma_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcDCSizeLuma_jfieldId == IntPtr.Zero)
					vlcDCSizeLuma_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcDCSizeLuma", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcDCSizeLuma_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcDualPrime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcDualPrime']"
		[Register ("vlcDualPrime")]
		public static global::Org.Jcodec.Common.IO.VLC VlcDualPrime {
			get {
				if (vlcDualPrime_jfieldId == IntPtr.Zero)
					vlcDualPrime_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcDualPrime", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcDualPrime_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcDualPrime_jfieldId == IntPtr.Zero)
					vlcDualPrime_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcDualPrime", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcDualPrime_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcMBTypeB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcMBTypeB']"
		[Register ("vlcMBTypeB")]
		public static global::Org.Jcodec.Common.IO.VLC VlcMBTypeB {
			get {
				if (vlcMBTypeB_jfieldId == IntPtr.Zero)
					vlcMBTypeB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeB", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcMBTypeB_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcMBTypeB_jfieldId == IntPtr.Zero)
					vlcMBTypeB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeB", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcMBTypeB_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcMBTypeBSpat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcMBTypeBSpat']"
		[Register ("vlcMBTypeBSpat")]
		public static global::Org.Jcodec.Common.IO.VLC VlcMBTypeBSpat {
			get {
				if (vlcMBTypeBSpat_jfieldId == IntPtr.Zero)
					vlcMBTypeBSpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeBSpat", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcMBTypeBSpat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcMBTypeBSpat_jfieldId == IntPtr.Zero)
					vlcMBTypeBSpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeBSpat", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcMBTypeBSpat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcMBTypeI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcMBTypeI']"
		[Register ("vlcMBTypeI")]
		public static global::Org.Jcodec.Common.IO.VLC VlcMBTypeI {
			get {
				if (vlcMBTypeI_jfieldId == IntPtr.Zero)
					vlcMBTypeI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeI", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcMBTypeI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcMBTypeI_jfieldId == IntPtr.Zero)
					vlcMBTypeI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeI", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcMBTypeI_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcMBTypeISpat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcMBTypeISpat']"
		[Register ("vlcMBTypeISpat")]
		public static global::Org.Jcodec.Common.IO.VLC VlcMBTypeISpat {
			get {
				if (vlcMBTypeISpat_jfieldId == IntPtr.Zero)
					vlcMBTypeISpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeISpat", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcMBTypeISpat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcMBTypeISpat_jfieldId == IntPtr.Zero)
					vlcMBTypeISpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeISpat", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcMBTypeISpat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcMBTypeP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcMBTypeP']"
		[Register ("vlcMBTypeP")]
		public static global::Org.Jcodec.Common.IO.VLC VlcMBTypeP {
			get {
				if (vlcMBTypeP_jfieldId == IntPtr.Zero)
					vlcMBTypeP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeP", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcMBTypeP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcMBTypeP_jfieldId == IntPtr.Zero)
					vlcMBTypeP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeP", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcMBTypeP_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcMBTypePSpat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcMBTypePSpat']"
		[Register ("vlcMBTypePSpat")]
		public static global::Org.Jcodec.Common.IO.VLC VlcMBTypePSpat {
			get {
				if (vlcMBTypePSpat_jfieldId == IntPtr.Zero)
					vlcMBTypePSpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypePSpat", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcMBTypePSpat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcMBTypePSpat_jfieldId == IntPtr.Zero)
					vlcMBTypePSpat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypePSpat", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcMBTypePSpat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcMBTypeSNR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcMBTypeSNR']"
		[Register ("vlcMBTypeSNR")]
		public static global::Org.Jcodec.Common.IO.VLC VlcMBTypeSNR {
			get {
				if (vlcMBTypeSNR_jfieldId == IntPtr.Zero)
					vlcMBTypeSNR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeSNR", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcMBTypeSNR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcMBTypeSNR_jfieldId == IntPtr.Zero)
					vlcMBTypeSNR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMBTypeSNR", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcMBTypeSNR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vlcMotionCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/field[@name='vlcMotionCode']"
		[Register ("vlcMotionCode")]
		public static global::Org.Jcodec.Common.IO.VLC VlcMotionCode {
			get {
				if (vlcMotionCode_jfieldId == IntPtr.Zero)
					vlcMotionCode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMotionCode", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vlcMotionCode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vlcMotionCode_jfieldId == IntPtr.Zero)
					vlcMotionCode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vlcMotionCode", "Lorg/jcodec/common/io/VLC;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vlcMotionCode_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst.MBType']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPEGConst$MBType", DoNotGenerateAcw=true)]
		public partial class MBType : global::Java.Lang.Object {


			static IntPtr macroblock_intra_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst.MBType']/field[@name='macroblock_intra']"
			[Register ("macroblock_intra")]
			public int MacroblockIntra {
				get {
					if (macroblock_intra_jfieldId == IntPtr.Zero)
						macroblock_intra_jfieldId = JNIEnv.GetFieldID (class_ref, "macroblock_intra", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, macroblock_intra_jfieldId);
				}
				set {
					if (macroblock_intra_jfieldId == IntPtr.Zero)
						macroblock_intra_jfieldId = JNIEnv.GetFieldID (class_ref, "macroblock_intra", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, macroblock_intra_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr macroblock_motion_backward_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst.MBType']/field[@name='macroblock_motion_backward']"
			[Register ("macroblock_motion_backward")]
			public int MacroblockMotionBackward {
				get {
					if (macroblock_motion_backward_jfieldId == IntPtr.Zero)
						macroblock_motion_backward_jfieldId = JNIEnv.GetFieldID (class_ref, "macroblock_motion_backward", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, macroblock_motion_backward_jfieldId);
				}
				set {
					if (macroblock_motion_backward_jfieldId == IntPtr.Zero)
						macroblock_motion_backward_jfieldId = JNIEnv.GetFieldID (class_ref, "macroblock_motion_backward", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, macroblock_motion_backward_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr macroblock_motion_forward_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst.MBType']/field[@name='macroblock_motion_forward']"
			[Register ("macroblock_motion_forward")]
			public int MacroblockMotionForward {
				get {
					if (macroblock_motion_forward_jfieldId == IntPtr.Zero)
						macroblock_motion_forward_jfieldId = JNIEnv.GetFieldID (class_ref, "macroblock_motion_forward", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, macroblock_motion_forward_jfieldId);
				}
				set {
					if (macroblock_motion_forward_jfieldId == IntPtr.Zero)
						macroblock_motion_forward_jfieldId = JNIEnv.GetFieldID (class_ref, "macroblock_motion_forward", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, macroblock_motion_forward_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr macroblock_pattern_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst.MBType']/field[@name='macroblock_pattern']"
			[Register ("macroblock_pattern")]
			public int MacroblockPattern {
				get {
					if (macroblock_pattern_jfieldId == IntPtr.Zero)
						macroblock_pattern_jfieldId = JNIEnv.GetFieldID (class_ref, "macroblock_pattern", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, macroblock_pattern_jfieldId);
				}
				set {
					if (macroblock_pattern_jfieldId == IntPtr.Zero)
						macroblock_pattern_jfieldId = JNIEnv.GetFieldID (class_ref, "macroblock_pattern", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, macroblock_pattern_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr macroblock_quant_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst.MBType']/field[@name='macroblock_quant']"
			[Register ("macroblock_quant")]
			public int MacroblockQuant {
				get {
					if (macroblock_quant_jfieldId == IntPtr.Zero)
						macroblock_quant_jfieldId = JNIEnv.GetFieldID (class_ref, "macroblock_quant", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, macroblock_quant_jfieldId);
				}
				set {
					if (macroblock_quant_jfieldId == IntPtr.Zero)
						macroblock_quant_jfieldId = JNIEnv.GetFieldID (class_ref, "macroblock_quant", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, macroblock_quant_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr permitted_spatial_temporal_weight_classes_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst.MBType']/field[@name='permitted_spatial_temporal_weight_classes']"
			[Register ("permitted_spatial_temporal_weight_classes")]
			public int PermittedSpatialTemporalWeightClasses {
				get {
					if (permitted_spatial_temporal_weight_classes_jfieldId == IntPtr.Zero)
						permitted_spatial_temporal_weight_classes_jfieldId = JNIEnv.GetFieldID (class_ref, "permitted_spatial_temporal_weight_classes", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, permitted_spatial_temporal_weight_classes_jfieldId);
				}
				set {
					if (permitted_spatial_temporal_weight_classes_jfieldId == IntPtr.Zero)
						permitted_spatial_temporal_weight_classes_jfieldId = JNIEnv.GetFieldID (class_ref, "permitted_spatial_temporal_weight_classes", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, permitted_spatial_temporal_weight_classes_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr spatial_temporal_weight_code_flag_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst.MBType']/field[@name='spatial_temporal_weight_code_flag']"
			[Register ("spatial_temporal_weight_code_flag")]
			public int SpatialTemporalWeightCodeFlag {
				get {
					if (spatial_temporal_weight_code_flag_jfieldId == IntPtr.Zero)
						spatial_temporal_weight_code_flag_jfieldId = JNIEnv.GetFieldID (class_ref, "spatial_temporal_weight_code_flag", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, spatial_temporal_weight_code_flag_jfieldId);
				}
				set {
					if (spatial_temporal_weight_code_flag_jfieldId == IntPtr.Zero)
						spatial_temporal_weight_code_flag_jfieldId = JNIEnv.GetFieldID (class_ref, "spatial_temporal_weight_code_flag", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, spatial_temporal_weight_code_flag_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPEGConst$MBType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MBType); }
			}

			protected MBType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPEGConst", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPEGConst); }
		}

		protected MPEGConst (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/constructor[@name='MPEGConst' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MPEGConst ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MPEGConst)) {
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

		static IntPtr id_mbTypeVal_ILorg_jcodec_codecs_mpeg12_bitstream_SequenceScalableExtension_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/method[@name='mbTypeVal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.jcodec.codecs.mpeg12.bitstream.SequenceScalableExtension']]"
		[Register ("mbTypeVal", "(ILorg/jcodec/codecs/mpeg12/bitstream/SequenceScalableExtension;)[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType[] MbTypeVal (int p0, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceScalableExtension p1)
		{
			if (id_mbTypeVal_ILorg_jcodec_codecs_mpeg12_bitstream_SequenceScalableExtension_ == IntPtr.Zero)
				id_mbTypeVal_ILorg_jcodec_codecs_mpeg12_bitstream_SequenceScalableExtension_ = JNIEnv.GetStaticMethodID (class_ref, "mbTypeVal", "(ILorg/jcodec/codecs/mpeg12/bitstream/SequenceScalableExtension;)[Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType[] __ret = (global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_mbTypeVal_ILorg_jcodec_codecs_mpeg12_bitstream_SequenceScalableExtension_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_vlcMBType_ILorg_jcodec_codecs_mpeg12_bitstream_SequenceScalableExtension_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGConst']/method[@name='vlcMBType' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.jcodec.codecs.mpeg12.bitstream.SequenceScalableExtension']]"
		[Register ("vlcMBType", "(ILorg/jcodec/codecs/mpeg12/bitstream/SequenceScalableExtension;)Lorg/jcodec/common/io/VLC;", "")]
		public static unsafe global::Org.Jcodec.Common.IO.VLC VlcMBType (int p0, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceScalableExtension p1)
		{
			if (id_vlcMBType_ILorg_jcodec_codecs_mpeg12_bitstream_SequenceScalableExtension_ == IntPtr.Zero)
				id_vlcMBType_ILorg_jcodec_codecs_mpeg12_bitstream_SequenceScalableExtension_ = JNIEnv.GetStaticMethodID (class_ref, "vlcMBType", "(ILorg/jcodec/codecs/mpeg12/bitstream/SequenceScalableExtension;)Lorg/jcodec/common/io/VLC;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Jcodec.Common.IO.VLC __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vlcMBType_ILorg_jcodec_codecs_mpeg12_bitstream_SequenceScalableExtension_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
