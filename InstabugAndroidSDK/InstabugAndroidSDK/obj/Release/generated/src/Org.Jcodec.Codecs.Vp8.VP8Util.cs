using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vp8 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vp8/VP8Util", DoNotGenerateAcw=true)]
	public partial class VP8Util : global::Java.Lang.Object {


		static IntPtr BLOCK_TYPES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='BLOCK_TYPES']"
		[Register ("BLOCK_TYPES")]
		public static int BlockTypes {
			get {
				if (BLOCK_TYPES_jfieldId == IntPtr.Zero)
					BLOCK_TYPES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_TYPES", "I");
				return JNIEnv.GetStaticIntField (class_ref, BLOCK_TYPES_jfieldId);
			}
			set {
				if (BLOCK_TYPES_jfieldId == IntPtr.Zero)
					BLOCK_TYPES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_TYPES", "I");
				try {
					JNIEnv.SetStaticField (class_ref, BLOCK_TYPES_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr COEF_BANDS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='COEF_BANDS']"
		[Register ("COEF_BANDS")]
		public static int CoefBands {
			get {
				if (COEF_BANDS_jfieldId == IntPtr.Zero)
					COEF_BANDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COEF_BANDS", "I");
				return JNIEnv.GetStaticIntField (class_ref, COEF_BANDS_jfieldId);
			}
			set {
				if (COEF_BANDS_jfieldId == IntPtr.Zero)
					COEF_BANDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COEF_BANDS", "I");
				try {
					JNIEnv.SetStaticField (class_ref, COEF_BANDS_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr MAX_ENTROPY_TOKENS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='MAX_ENTROPY_TOKENS']"
		[Register ("MAX_ENTROPY_TOKENS")]
		public static int MaxEntropyTokens {
			get {
				if (MAX_ENTROPY_TOKENS_jfieldId == IntPtr.Zero)
					MAX_ENTROPY_TOKENS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_ENTROPY_TOKENS", "I");
				return JNIEnv.GetStaticIntField (class_ref, MAX_ENTROPY_TOKENS_jfieldId);
			}
			set {
				if (MAX_ENTROPY_TOKENS_jfieldId == IntPtr.Zero)
					MAX_ENTROPY_TOKENS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_ENTROPY_TOKENS", "I");
				try {
					JNIEnv.SetStaticField (class_ref, MAX_ENTROPY_TOKENS_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr MAX_MODE_LF_DELTAS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='MAX_MODE_LF_DELTAS']"
		[Register ("MAX_MODE_LF_DELTAS")]
		public static int MaxModeLfDeltas {
			get {
				if (MAX_MODE_LF_DELTAS_jfieldId == IntPtr.Zero)
					MAX_MODE_LF_DELTAS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_MODE_LF_DELTAS", "I");
				return JNIEnv.GetStaticIntField (class_ref, MAX_MODE_LF_DELTAS_jfieldId);
			}
			set {
				if (MAX_MODE_LF_DELTAS_jfieldId == IntPtr.Zero)
					MAX_MODE_LF_DELTAS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_MODE_LF_DELTAS", "I");
				try {
					JNIEnv.SetStaticField (class_ref, MAX_MODE_LF_DELTAS_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr MAX_REF_LF_DELTAS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='MAX_REF_LF_DELTAS']"
		[Register ("MAX_REF_LF_DELTAS")]
		public static int MaxRefLfDeltas {
			get {
				if (MAX_REF_LF_DELTAS_jfieldId == IntPtr.Zero)
					MAX_REF_LF_DELTAS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_REF_LF_DELTAS", "I");
				return JNIEnv.GetStaticIntField (class_ref, MAX_REF_LF_DELTAS_jfieldId);
			}
			set {
				if (MAX_REF_LF_DELTAS_jfieldId == IntPtr.Zero)
					MAX_REF_LF_DELTAS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_REF_LF_DELTAS", "I");
				try {
					JNIEnv.SetStaticField (class_ref, MAX_REF_LF_DELTAS_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='MB_FEATURE_TREE_PROBS']"
		[Register ("MB_FEATURE_TREE_PROBS")]
		public const int MbFeatureTreeProbs = (int) 3;

		static IntPtr PRED_BLOCK_127_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='PRED_BLOCK_127']"
		[Register ("PRED_BLOCK_127")]
		public static IList<int> PredBlock127 {
			get {
				if (PRED_BLOCK_127_jfieldId == IntPtr.Zero)
					PRED_BLOCK_127_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRED_BLOCK_127", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, PRED_BLOCK_127_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PRED_BLOCK_129_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='PRED_BLOCK_129']"
		[Register ("PRED_BLOCK_129")]
		public static IList<int> PredBlock129 {
			get {
				if (PRED_BLOCK_129_jfieldId == IntPtr.Zero)
					PRED_BLOCK_129_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRED_BLOCK_129", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, PRED_BLOCK_129_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PREV_COEF_CONTEXTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='PREV_COEF_CONTEXTS']"
		[Register ("PREV_COEF_CONTEXTS")]
		public static int PrevCoefContexts {
			get {
				if (PREV_COEF_CONTEXTS_jfieldId == IntPtr.Zero)
					PREV_COEF_CONTEXTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREV_COEF_CONTEXTS", "I");
				return JNIEnv.GetStaticIntField (class_ref, PREV_COEF_CONTEXTS_jfieldId);
			}
			set {
				if (PREV_COEF_CONTEXTS_jfieldId == IntPtr.Zero)
					PREV_COEF_CONTEXTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREV_COEF_CONTEXTS", "I");
				try {
					JNIEnv.SetStaticField (class_ref, PREV_COEF_CONTEXTS_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr keyFrameYModeProb_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='keyFrameYModeProb']"
		[Register ("keyFrameYModeProb")]
		public static IList<int> KeyFrameYModeProb {
			get {
				if (keyFrameYModeProb_jfieldId == IntPtr.Zero)
					keyFrameYModeProb_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "keyFrameYModeProb", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, keyFrameYModeProb_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (keyFrameYModeProb_jfieldId == IntPtr.Zero)
					keyFrameYModeProb_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "keyFrameYModeProb", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, keyFrameYModeProb_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr keyFrameYModeTree_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='keyFrameYModeTree']"
		[Register ("keyFrameYModeTree")]
		public static IList<int> KeyFrameYModeTree {
			get {
				if (keyFrameYModeTree_jfieldId == IntPtr.Zero)
					keyFrameYModeTree_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "keyFrameYModeTree", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, keyFrameYModeTree_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (keyFrameYModeTree_jfieldId == IntPtr.Zero)
					keyFrameYModeTree_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "keyFrameYModeTree", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, keyFrameYModeTree_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vp8KeyFrameUVModeProb_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='vp8KeyFrameUVModeProb']"
		[Register ("vp8KeyFrameUVModeProb")]
		public static IList<int> Vp8KeyFrameUVModeProb {
			get {
				if (vp8KeyFrameUVModeProb_jfieldId == IntPtr.Zero)
					vp8KeyFrameUVModeProb_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vp8KeyFrameUVModeProb", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, vp8KeyFrameUVModeProb_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vp8KeyFrameUVModeProb_jfieldId == IntPtr.Zero)
					vp8KeyFrameUVModeProb_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vp8KeyFrameUVModeProb", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vp8KeyFrameUVModeProb_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vp8UVModeTree_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/field[@name='vp8UVModeTree']"
		[Register ("vp8UVModeTree")]
		public static IList<int> Vp8UVModeTree {
			get {
				if (vp8UVModeTree_jfieldId == IntPtr.Zero)
					vp8UVModeTree_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vp8UVModeTree", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, vp8UVModeTree_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vp8UVModeTree_jfieldId == IntPtr.Zero)
					vp8UVModeTree_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vp8UVModeTree", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, vp8UVModeTree_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.PLANE']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/vp8/VP8Util$PLANE", DoNotGenerateAcw=true)]
		public sealed partial class PLANE : global::Java.Lang.Enum {


			static IntPtr U_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.PLANE']/field[@name='U']"
			[Register ("U")]
			public static global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE U {
				get {
					if (U_jfieldId == IntPtr.Zero)
						U_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "U", "Lorg/jcodec/codecs/vp8/VP8Util$PLANE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, U_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr V_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.PLANE']/field[@name='V']"
			[Register ("V")]
			public static global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE V {
				get {
					if (V_jfieldId == IntPtr.Zero)
						V_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "V", "Lorg/jcodec/codecs/vp8/VP8Util$PLANE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, V_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Y1_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.PLANE']/field[@name='Y1']"
			[Register ("Y1")]
			public static global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE Y1 {
				get {
					if (Y1_jfieldId == IntPtr.Zero)
						Y1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Y1", "Lorg/jcodec/codecs/vp8/VP8Util$PLANE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Y1_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Y2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.PLANE']/field[@name='Y2']"
			[Register ("Y2")]
			public static global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE Y2 {
				get {
					if (Y2_jfieldId == IntPtr.Zero)
						Y2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Y2", "Lorg/jcodec/codecs/vp8/VP8Util$PLANE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Y2_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/vp8/VP8Util$PLANE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PLANE); }
			}

			internal PLANE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.PLANE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/vp8/VP8Util$PLANE;", "")]
			public static unsafe global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/vp8/VP8Util$PLANE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.PLANE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/jcodec/codecs/vp8/VP8Util$PLANE;", "")]
			public static unsafe global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/codecs/vp8/VP8Util$PLANE;");
				try {
					return (global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.QuantizationParams']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/vp8/VP8Util$QuantizationParams", DoNotGenerateAcw=true)]
		public partial class QuantizationParams : global::Java.Lang.Object {


			static IntPtr acQLookup_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.QuantizationParams']/field[@name='acQLookup']"
			[Register ("acQLookup")]
			public static IList<int> AcQLookup {
				get {
					if (acQLookup_jfieldId == IntPtr.Zero)
						acQLookup_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "acQLookup", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, acQLookup_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr dcQLookup_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.QuantizationParams']/field[@name='dcQLookup']"
			[Register ("dcQLookup")]
			public static IList<int> DcQLookup {
				get {
					if (dcQLookup_jfieldId == IntPtr.Zero)
						dcQLookup_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "dcQLookup", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, dcQLookup_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/vp8/VP8Util$QuantizationParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (QuantizationParams); }
			}

			protected QuantizationParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IIIIII;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.QuantizationParams']/constructor[@name='VP8Util.QuantizationParams' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
			[Register (".ctor", "(IIIIII)V", "")]
			public unsafe QuantizationParams (int p0, int p1, int p2, int p3, int p4, int p5)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [6];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					if (GetType () != typeof (QuantizationParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIIII)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIIII)V", __args);
						return;
					}

					if (id_ctor_IIIIII == IntPtr.Zero)
						id_ctor_IIIIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIIII)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIIII, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIIII, __args);
				} finally {
				}
			}

			static IntPtr id_clip255_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.QuantizationParams']/method[@name='clip255' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("clip255", "(I)I", "")]
			public static unsafe int Clip255 (int p0)
			{
				if (id_clip255_I == IntPtr.Zero)
					id_clip255_I = JNIEnv.GetStaticMethodID (class_ref, "clip255", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.CallStaticIntMethod  (class_ref, id_clip255_I, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/vp8/VP8Util$SubblockConstants", DoNotGenerateAcw=true)]
		public partial class SubblockConstants : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='B_DC_PRED']"
			[Register ("B_DC_PRED")]
			public const int BDcPred = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='B_HD_PRED']"
			[Register ("B_HD_PRED")]
			public const int BHdPred = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='B_HE_PRED']"
			[Register ("B_HE_PRED")]
			public const int BHePred = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='B_HU_PRED']"
			[Register ("B_HU_PRED")]
			public const int BHuPred = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='B_LD_PRED']"
			[Register ("B_LD_PRED")]
			public const int BLdPred = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='B_PRED']"
			[Register ("B_PRED")]
			public const int BPred = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='B_RD_PRED']"
			[Register ("B_RD_PRED")]
			public const int BRdPred = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='B_TM_PRED']"
			[Register ("B_TM_PRED")]
			public const int BTmPred = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='B_VE_PRED']"
			[Register ("B_VE_PRED")]
			public const int BVePred = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='B_VL_PRED']"
			[Register ("B_VL_PRED")]
			public const int BVlPred = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='B_VR_PRED']"
			[Register ("B_VR_PRED")]
			public const int BVrPred = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='DCT_0']"
			[Register ("DCT_0")]
			public const int Dct0 = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='DCT_1']"
			[Register ("DCT_1")]
			public const int Dct1 = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='DCT_2']"
			[Register ("DCT_2")]
			public const int Dct2 = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='DCT_3']"
			[Register ("DCT_3")]
			public const int Dct3 = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='DCT_4']"
			[Register ("DCT_4")]
			public const int Dct4 = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='DC_PRED']"
			[Register ("DC_PRED")]
			public const int DcPred = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='H_PRED']"
			[Register ("H_PRED")]
			public const int HPred = (int) 2;

			static IntPtr Pcat1_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='Pcat1']"
			[Register ("Pcat1")]
			public static IList<int> Pcat1 {
				get {
					if (Pcat1_jfieldId == IntPtr.Zero)
						Pcat1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Pcat1", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, Pcat1_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Pcat2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='Pcat2']"
			[Register ("Pcat2")]
			public static IList<int> Pcat2 {
				get {
					if (Pcat2_jfieldId == IntPtr.Zero)
						Pcat2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Pcat2", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, Pcat2_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Pcat3_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='Pcat3']"
			[Register ("Pcat3")]
			public static IList<int> Pcat3 {
				get {
					if (Pcat3_jfieldId == IntPtr.Zero)
						Pcat3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Pcat3", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, Pcat3_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Pcat4_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='Pcat4']"
			[Register ("Pcat4")]
			public static IList<int> Pcat4 {
				get {
					if (Pcat4_jfieldId == IntPtr.Zero)
						Pcat4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Pcat4", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, Pcat4_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Pcat5_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='Pcat5']"
			[Register ("Pcat5")]
			public static IList<int> Pcat5 {
				get {
					if (Pcat5_jfieldId == IntPtr.Zero)
						Pcat5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Pcat5", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, Pcat5_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Pcat6_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='Pcat6']"
			[Register ("Pcat6")]
			public static IList<int> Pcat6 {
				get {
					if (Pcat6_jfieldId == IntPtr.Zero)
						Pcat6_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Pcat6", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, Pcat6_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='TM_PRED']"
			[Register ("TM_PRED")]
			public const int TmPred = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='V_PRED']"
			[Register ("V_PRED")]
			public const int VPred = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='cat_11_18']"
			[Register ("cat_11_18")]
			public const int Cat1118 = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='cat_19_34']"
			[Register ("cat_19_34")]
			public const int Cat1934 = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='cat_35_66']"
			[Register ("cat_35_66")]
			public const int Cat3566 = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='cat_5_6']"
			[Register ("cat_5_6")]
			public const int Cat56 = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='cat_67_2048']"
			[Register ("cat_67_2048")]
			public const int Cat672048 = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='cat_7_10']"
			[Register ("cat_7_10")]
			public const int Cat710 = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='dct_eob']"
			[Register ("dct_eob")]
			public const int DctEob = (int) 11;

			static IntPtr keyFrameSubblockModeProb_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='keyFrameSubblockModeProb']"
			[Register ("keyFrameSubblockModeProb")]
			public static IList<int[][]> KeyFrameSubblockModeProb {
				get {
					if (keyFrameSubblockModeProb_jfieldId == IntPtr.Zero)
						keyFrameSubblockModeProb_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "keyFrameSubblockModeProb", "[[[I");
					return global::Android.Runtime.JavaArray<int[][]>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, keyFrameSubblockModeProb_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (keyFrameSubblockModeProb_jfieldId == IntPtr.Zero)
						keyFrameSubblockModeProb_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "keyFrameSubblockModeProb", "[[[I");
					IntPtr native_value = global::Android.Runtime.JavaArray<int[][]>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetStaticField (class_ref, keyFrameSubblockModeProb_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr subblockModeTree_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='subblockModeTree']"
			[Register ("subblockModeTree")]
			public static IList<int> SubblockModeTree {
				get {
					if (subblockModeTree_jfieldId == IntPtr.Zero)
						subblockModeTree_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "subblockModeTree", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, subblockModeTree_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (subblockModeTree_jfieldId == IntPtr.Zero)
						subblockModeTree_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "subblockModeTree", "[I");
					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetStaticField (class_ref, subblockModeTree_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr vp8CoefBands_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='vp8CoefBands']"
			[Register ("vp8CoefBands")]
			public static IList<int> Vp8CoefBands {
				get {
					if (vp8CoefBands_jfieldId == IntPtr.Zero)
						vp8CoefBands_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vp8CoefBands", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, vp8CoefBands_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr vp8CoefTree_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='vp8CoefTree']"
			[Register ("vp8CoefTree")]
			public static IList<int> Vp8CoefTree {
				get {
					if (vp8CoefTree_jfieldId == IntPtr.Zero)
						vp8CoefTree_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vp8CoefTree", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, vp8CoefTree_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr vp8defaultZigZag1d_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/field[@name='vp8defaultZigZag1d']"
			[Register ("vp8defaultZigZag1d")]
			public static IList<int> Vp8defaultZigZag1d {
				get {
					if (vp8defaultZigZag1d_jfieldId == IntPtr.Zero)
						vp8defaultZigZag1d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vp8defaultZigZag1d", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, vp8defaultZigZag1d_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/vp8/VP8Util$SubblockConstants", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SubblockConstants); }
			}

			protected SubblockConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util.SubblockConstants']/constructor[@name='VP8Util.SubblockConstants' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SubblockConstants ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (SubblockConstants)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vp8/VP8Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VP8Util); }
		}

		protected VP8Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/constructor[@name='VP8Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VP8Util ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VP8Util)) {
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

		static IntPtr id_avg2_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='avg2' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("avg2", "(II)I", "")]
		public static unsafe int Avg2 (int p0, int p1)
		{
			if (id_avg2_II == IntPtr.Zero)
				id_avg2_II = JNIEnv.GetStaticMethodID (class_ref, "avg2", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_avg2_II, __args);
			} finally {
			}
		}

		static IntPtr id_avg3_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='avg3' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("avg3", "(III)I", "")]
		public static unsafe int Avg3 (int p0, int p1, int p2)
		{
			if (id_avg3_III == IntPtr.Zero)
				id_avg3_III = JNIEnv.GetStaticMethodID (class_ref, "avg3", "(III)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_avg3_III, __args);
			} finally {
			}
		}

		static IntPtr id_delta_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='delta' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.vp8.BooleanArithmeticDecoder']]"
		[Register ("delta", "(Lorg/jcodec/codecs/vp8/BooleanArithmeticDecoder;)I", "")]
		public static unsafe int Delta (global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder p0)
		{
			if (id_delta_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_ == IntPtr.Zero)
				id_delta_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_ = JNIEnv.GetStaticMethodID (class_ref, "delta", "(Lorg/jcodec/codecs/vp8/BooleanArithmeticDecoder;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_delta_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBitInBytes_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='getBitInBytes' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getBitInBytes", "([BI)I", "")]
		public static unsafe int GetBitInBytes (byte[] p0, int p1)
		{
			if (id_getBitInBytes_arrayBI == IntPtr.Zero)
				id_getBitInBytes_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "getBitInBytes", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getBitInBytes_arrayBI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getBitsInBytes_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='getBitsInBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getBitsInBytes", "([BII)I", "")]
		public static unsafe int GetBitsInBytes (byte[] p0, int p1, int p2)
		{
			if (id_getBitsInBytes_arrayBII == IntPtr.Zero)
				id_getBitsInBytes_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "getBitsInBytes", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getBitsInBytes_arrayBII, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getDefaultCoefProbs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='getDefaultCoefProbs' and count(parameter)=0]"
		[Register ("getDefaultCoefProbs", "()[[[[I", "")]
		public static unsafe int[][][][] GetDefaultCoefProbs ()
		{
			if (id_getDefaultCoefProbs == IntPtr.Zero)
				id_getDefaultCoefProbs = JNIEnv.GetStaticMethodID (class_ref, "getDefaultCoefProbs", "()[[[[I");
			try {
				return (int[][][][]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultCoefProbs), JniHandleOwnership.TransferLocalRef, typeof (int[][][]));
			} finally {
			}
		}

		static IntPtr id_getMacroblockCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='getMacroblockCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMacroblockCount", "(I)I", "")]
		public static unsafe int GetMacroblockCount (int p0)
		{
			if (id_getMacroblockCount_I == IntPtr.Zero)
				id_getMacroblockCount_I = JNIEnv.GetStaticMethodID (class_ref, "getMacroblockCount", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getMacroblockCount_I, __args);
			} finally {
			}
		}

		static IntPtr id_pickDefaultPrediction_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='pickDefaultPrediction' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pickDefaultPrediction", "(I)[I", "")]
		public static unsafe int[] PickDefaultPrediction (int p0)
		{
			if (id_pickDefaultPrediction_I == IntPtr.Zero)
				id_pickDefaultPrediction_I = JNIEnv.GetStaticMethodID (class_ref, "pickDefaultPrediction", "(I)[I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_pickDefaultPrediction_I, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_planeToType_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='planeToType' and count(parameter)=2 and parameter[1][@type='org.jcodec.codecs.vp8.VP8Util.PLANE'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("planeToType", "(Lorg/jcodec/codecs/vp8/VP8Util$PLANE;Ljava/lang/Boolean;)I", "")]
		public static unsafe int PlaneToType (global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE p0, global::Java.Lang.Boolean p1)
		{
			if (id_planeToType_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_planeToType_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "planeToType", "(Lorg/jcodec/codecs/vp8/VP8Util$PLANE;Ljava/lang/Boolean;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_planeToType_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_Ljava_lang_Boolean_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_predictDC_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='predictDC' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("predictDC", "([I[I)[I", "")]
		public static unsafe int[] PredictDC (int[] p0, int[] p1)
		{
			if (id_predictDC_arrayIarrayI == IntPtr.Zero)
				id_predictDC_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictDC", "([I[I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_predictDC_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_predictHD_arrayIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='predictHD' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int']]"
		[Register ("predictHD", "([I[II)[I", "")]
		public static unsafe int[] PredictHD (int[] p0, int[] p1, int p2)
		{
			if (id_predictHD_arrayIarrayII == IntPtr.Zero)
				id_predictHD_arrayIarrayII = JNIEnv.GetStaticMethodID (class_ref, "predictHD", "([I[II)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_predictHD_arrayIarrayII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_predictHE_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='predictHE' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("predictHE", "([II)[I", "")]
		public static unsafe int[] PredictHE (int[] p0, int p1)
		{
			if (id_predictHE_arrayII == IntPtr.Zero)
				id_predictHE_arrayII = JNIEnv.GetStaticMethodID (class_ref, "predictHE", "([II)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_predictHE_arrayII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_predictHU_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='predictHU' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("predictHU", "([I)[I", "")]
		public static unsafe int[] PredictHU (int[] p0)
		{
			if (id_predictHU_arrayI == IntPtr.Zero)
				id_predictHU_arrayI = JNIEnv.GetStaticMethodID (class_ref, "predictHU", "([I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_predictHU_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_predictLD_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='predictLD' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("predictLD", "([I[I)[I", "")]
		public static unsafe int[] PredictLD (int[] p0, int[] p1)
		{
			if (id_predictLD_arrayIarrayI == IntPtr.Zero)
				id_predictLD_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictLD", "([I[I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_predictLD_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_predictRD_arrayIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='predictRD' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int']]"
		[Register ("predictRD", "([I[II)[I", "")]
		public static unsafe int[] PredictRD (int[] p0, int[] p1, int p2)
		{
			if (id_predictRD_arrayIarrayII == IntPtr.Zero)
				id_predictRD_arrayIarrayII = JNIEnv.GetStaticMethodID (class_ref, "predictRD", "([I[II)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_predictRD_arrayIarrayII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_predictTM_arrayIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='predictTM' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int']]"
		[Register ("predictTM", "([I[II)[I", "")]
		public static unsafe int[] PredictTM (int[] p0, int[] p1, int p2)
		{
			if (id_predictTM_arrayIarrayII == IntPtr.Zero)
				id_predictTM_arrayIarrayII = JNIEnv.GetStaticMethodID (class_ref, "predictTM", "([I[II)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_predictTM_arrayIarrayII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_predictVE_arrayIIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='predictVE' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("predictVE", "([II[I)[I", "")]
		public static unsafe int[] PredictVE (int[] p0, int p1, int[] p2)
		{
			if (id_predictVE_arrayIIarrayI == IntPtr.Zero)
				id_predictVE_arrayIIarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictVE", "([II[I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_predictVE_arrayIIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_predictVL_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='predictVL' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("predictVL", "([I[I)[I", "")]
		public static unsafe int[] PredictVL (int[] p0, int[] p1)
		{
			if (id_predictVL_arrayIarrayI == IntPtr.Zero)
				id_predictVL_arrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "predictVL", "([I[I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_predictVL_arrayIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_predictVR_arrayIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='VP8Util']/method[@name='predictVR' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int']]"
		[Register ("predictVR", "([I[II)[I", "")]
		public static unsafe int[] PredictVR (int[] p0, int[] p1, int p2)
		{
			if (id_predictVR_arrayIarrayII == IntPtr.Zero)
				id_predictVR_arrayIarrayII = JNIEnv.GetStaticMethodID (class_ref, "predictVR", "([I[II)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_predictVR_arrayIarrayII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
