using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vp8 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vp8/Macroblock", DoNotGenerateAcw=true)]
	public partial class Macroblock : global::Java.Lang.Object {


		static IntPtr Rrow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='Rrow']"
		[Register ("Rrow")]
		public int Rrow {
			get {
				if (Rrow_jfieldId == IntPtr.Zero)
					Rrow_jfieldId = JNIEnv.GetFieldID (class_ref, "Rrow", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, Rrow_jfieldId);
			}
			set {
				if (Rrow_jfieldId == IntPtr.Zero)
					Rrow_jfieldId = JNIEnv.GetFieldID (class_ref, "Rrow", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, Rrow_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr chromaMode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='chromaMode']"
		[Register ("chromaMode")]
		public int ChromaMode {
			get {
				if (chromaMode_jfieldId == IntPtr.Zero)
					chromaMode_jfieldId = JNIEnv.GetFieldID (class_ref, "chromaMode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, chromaMode_jfieldId);
			}
			set {
				if (chromaMode_jfieldId == IntPtr.Zero)
					chromaMode_jfieldId = JNIEnv.GetFieldID (class_ref, "chromaMode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chromaMode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr column_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='column']"
		[Register ("column")]
		public int Column {
			get {
				if (column_jfieldId == IntPtr.Zero)
					column_jfieldId = JNIEnv.GetFieldID (class_ref, "column", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, column_jfieldId);
			}
			set {
				if (column_jfieldId == IntPtr.Zero)
					column_jfieldId = JNIEnv.GetFieldID (class_ref, "column", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, column_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr debug_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='debug']"
		[Register ("debug")]
		public bool Debug {
			get {
				if (debug_jfieldId == IntPtr.Zero)
					debug_jfieldId = JNIEnv.GetFieldID (class_ref, "debug", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, debug_jfieldId);
			}
			set {
				if (debug_jfieldId == IntPtr.Zero)
					debug_jfieldId = JNIEnv.GetFieldID (class_ref, "debug", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, debug_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr filterLevel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='filterLevel']"
		[Register ("filterLevel")]
		public int FilterLevel {
			get {
				if (filterLevel_jfieldId == IntPtr.Zero)
					filterLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "filterLevel", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, filterLevel_jfieldId);
			}
			set {
				if (filterLevel_jfieldId == IntPtr.Zero)
					filterLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "filterLevel", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, filterLevel_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lumaMode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='lumaMode']"
		[Register ("lumaMode")]
		public int LumaMode {
			get {
				if (lumaMode_jfieldId == IntPtr.Zero)
					lumaMode_jfieldId = JNIEnv.GetFieldID (class_ref, "lumaMode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lumaMode_jfieldId);
			}
			set {
				if (lumaMode_jfieldId == IntPtr.Zero)
					lumaMode_jfieldId = JNIEnv.GetFieldID (class_ref, "lumaMode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lumaMode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr segment_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='segment']"
		[Register ("segment")]
		public int Segment {
			get {
				if (segment_jfieldId == IntPtr.Zero)
					segment_jfieldId = JNIEnv.GetFieldID (class_ref, "segment", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, segment_jfieldId);
			}
			set {
				if (segment_jfieldId == IntPtr.Zero)
					segment_jfieldId = JNIEnv.GetFieldID (class_ref, "segment", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, segment_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr skipCoeff_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='skipCoeff']"
		[Register ("skipCoeff")]
		public int SkipCoeff {
			get {
				if (skipCoeff_jfieldId == IntPtr.Zero)
					skipCoeff_jfieldId = JNIEnv.GetFieldID (class_ref, "skipCoeff", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, skipCoeff_jfieldId);
			}
			set {
				if (skipCoeff_jfieldId == IntPtr.Zero)
					skipCoeff_jfieldId = JNIEnv.GetFieldID (class_ref, "skipCoeff", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, skipCoeff_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr uSubblocks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='uSubblocks']"
		[Register ("uSubblocks")]
		public IList<Org.Jcodec.Codecs.Vp8.Macroblock.Subblock[]> USubblocks {
			get {
				if (uSubblocks_jfieldId == IntPtr.Zero)
					uSubblocks_jfieldId = JNIEnv.GetFieldID (class_ref, "uSubblocks", "[[Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock[]>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, uSubblocks_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (uSubblocks_jfieldId == IntPtr.Zero)
					uSubblocks_jfieldId = JNIEnv.GetFieldID (class_ref, "uSubblocks", "[[Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock[]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, uSubblocks_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vSubblocks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='vSubblocks']"
		[Register ("vSubblocks")]
		public IList<Org.Jcodec.Codecs.Vp8.Macroblock.Subblock[]> VSubblocks {
			get {
				if (vSubblocks_jfieldId == IntPtr.Zero)
					vSubblocks_jfieldId = JNIEnv.GetFieldID (class_ref, "vSubblocks", "[[Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock[]>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, vSubblocks_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vSubblocks_jfieldId == IntPtr.Zero)
					vSubblocks_jfieldId = JNIEnv.GetFieldID (class_ref, "vSubblocks", "[[Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock[]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vSubblocks_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr y2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='y2']"
		[Register ("y2")]
		public global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock Y2 {
			get {
				if (y2_jfieldId == IntPtr.Zero)
					y2_jfieldId = JNIEnv.GetFieldID (class_ref, "y2", "Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, y2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (y2_jfieldId == IntPtr.Zero)
					y2_jfieldId = JNIEnv.GetFieldID (class_ref, "y2", "Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, y2_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ySubblocks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/field[@name='ySubblocks']"
		[Register ("ySubblocks")]
		public IList<Org.Jcodec.Codecs.Vp8.Macroblock.Subblock[]> YSubblocks {
			get {
				if (ySubblocks_jfieldId == IntPtr.Zero)
					ySubblocks_jfieldId = JNIEnv.GetFieldID (class_ref, "ySubblocks", "[[Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
				return global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock[]>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ySubblocks_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ySubblocks_jfieldId == IntPtr.Zero)
					ySubblocks_jfieldId = JNIEnv.GetFieldID (class_ref, "ySubblocks", "[[Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock[]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ySubblocks_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/vp8/Macroblock$Subblock", DoNotGenerateAcw=true)]
		public partial class Subblock : global::Java.Lang.Object {


			static IntPtr mode_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']/field[@name='mode']"
			[Register ("mode")]
			public int Mode {
				get {
					if (mode_jfieldId == IntPtr.Zero)
						mode_jfieldId = JNIEnv.GetFieldID (class_ref, "mode", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mode_jfieldId);
				}
				set {
					if (mode_jfieldId == IntPtr.Zero)
						mode_jfieldId = JNIEnv.GetFieldID (class_ref, "mode", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mode_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr residue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']/field[@name='residue']"
			[Register ("residue")]
			public IList<int> Residue {
				get {
					if (residue_jfieldId == IntPtr.Zero)
						residue_jfieldId = JNIEnv.GetFieldID (class_ref, "residue", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, residue_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (residue_jfieldId == IntPtr.Zero)
						residue_jfieldId = JNIEnv.GetFieldID (class_ref, "residue", "[I");
					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, residue_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr someValuePresent_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']/field[@name='someValuePresent']"
			[Register ("someValuePresent")]
			public bool SomeValuePresent {
				get {
					if (someValuePresent_jfieldId == IntPtr.Zero)
						someValuePresent_jfieldId = JNIEnv.GetFieldID (class_ref, "someValuePresent", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, someValuePresent_jfieldId);
				}
				set {
					if (someValuePresent_jfieldId == IntPtr.Zero)
						someValuePresent_jfieldId = JNIEnv.GetFieldID (class_ref, "someValuePresent", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, someValuePresent_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr val_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']/field[@name='val']"
			[Register ("val")]
			public IList<int> Val {
				get {
					if (val_jfieldId == IntPtr.Zero)
						val_jfieldId = JNIEnv.GetFieldID (class_ref, "val", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, val_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (val_jfieldId == IntPtr.Zero)
						val_jfieldId = JNIEnv.GetFieldID (class_ref, "val", "[I");
					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, val_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/vp8/Macroblock$Subblock", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Subblock); }
			}

			protected Subblock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_codecs_vp8_Macroblock_IILorg_jcodec_codecs_vp8_VP8Util_PLANE_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']/constructor[@name='Macroblock.Subblock' and count(parameter)=4 and parameter[1][@type='org.jcodec.codecs.vp8.Macroblock'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.jcodec.codecs.vp8.VP8Util.PLANE']]"
			[Register (".ctor", "(Lorg/jcodec/codecs/vp8/Macroblock;IILorg/jcodec/codecs/vp8/VP8Util$PLANE;)V", "")]
			public unsafe Subblock (global::Org.Jcodec.Codecs.Vp8.Macroblock __self, int p1, int p2, global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (((object) this).GetType () != typeof (Subblock)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IILorg/jcodec/codecs/vp8/VP8Util$PLANE;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IILorg/jcodec/codecs/vp8/VP8Util$PLANE;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_codecs_vp8_Macroblock_IILorg_jcodec_codecs_vp8_VP8Util_PLANE_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_codecs_vp8_Macroblock_IILorg_jcodec_codecs_vp8_VP8Util_PLANE_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/vp8/Macroblock;IILorg/jcodec/codecs/vp8/VP8Util$PLANE;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_vp8_Macroblock_IILorg_jcodec_codecs_vp8_VP8Util_PLANE_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_vp8_Macroblock_IILorg_jcodec_codecs_vp8_VP8Util_PLANE_, __args);
				} finally {
				}
			}

			static Delegate cb_decodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZ;
#pragma warning disable 0169
			static Delegate GetDecodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZHandler ()
			{
				if (cb_decodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZ == null)
					cb_decodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, bool>) n_DecodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZ);
				return cb_decodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZ;
			}

			static void n_DecodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, bool p4)
			{
				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
				int[][][][] p1 = (int[][][][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int[][][]));
				__this.DecodeSubBlock (p0, p1, p2, p3, p4);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			static IntPtr id_decodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']/method[@name='decodeSubBlock' and count(parameter)=5 and parameter[1][@type='org.jcodec.codecs.vp8.BooleanArithmeticDecoder'] and parameter[2][@type='int[][][][]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
			[Register ("decodeSubBlock", "(Lorg/jcodec/codecs/vp8/BooleanArithmeticDecoder;[[[[IIIZ)V", "GetDecodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZHandler")]
			public virtual unsafe void DecodeSubBlock (global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder p0, int[][][][] p1, int p2, int p3, bool p4)
			{
				if (id_decodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZ == IntPtr.Zero)
					id_decodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZ = JNIEnv.GetMethodID (class_ref, "decodeSubBlock", "(Lorg/jcodec/codecs/vp8/BooleanArithmeticDecoder;[[[[IIIZ)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeSubBlock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIIIZ, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeSubBlock", "(Lorg/jcodec/codecs/vp8/BooleanArithmeticDecoder;[[[[IIIZ)V"), __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_dequantSubblock_IILjava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetDequantSubblock_IILjava_lang_Integer_Handler ()
			{
				if (cb_dequantSubblock_IILjava_lang_Integer_ == null)
					cb_dequantSubblock_IILjava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_DequantSubblock_IILjava_lang_Integer_);
				return cb_dequantSubblock_IILjava_lang_Integer_;
			}

			static void n_DequantSubblock_IILjava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.DequantSubblock (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_dequantSubblock_IILjava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']/method[@name='dequantSubblock' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Integer']]"
			[Register ("dequantSubblock", "(IILjava/lang/Integer;)V", "GetDequantSubblock_IILjava_lang_Integer_Handler")]
			public virtual unsafe void DequantSubblock (int p0, int p1, global::Java.Lang.Integer p2)
			{
				if (id_dequantSubblock_IILjava_lang_Integer_ == IntPtr.Zero)
					id_dequantSubblock_IILjava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "dequantSubblock", "(IILjava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dequantSubblock_IILjava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dequantSubblock", "(IILjava/lang/Integer;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_getAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
#pragma warning disable 0169
			static Delegate GetGetAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Handler ()
			{
				if (cb_getAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ == null)
					cb_getAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_);
				return cb_getAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
			}

			static IntPtr n_GetAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p1 = (global::Org.Jcodec.Codecs.Vp8.Macroblock[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Codecs.Vp8.Macroblock[]));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAbove (p0, p1));
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']/method[@name='getAbove' and count(parameter)=2 and parameter[1][@type='org.jcodec.codecs.vp8.VP8Util.PLANE'] and parameter[2][@type='org.jcodec.codecs.vp8.Macroblock[][]']]"
			[Register ("getAbove", "(Lorg/jcodec/codecs/vp8/VP8Util$PLANE;[[Lorg/jcodec/codecs/vp8/Macroblock;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;", "GetGetAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Handler")]
			public virtual unsafe global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock GetAbove (global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE p0, global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p1)
			{
				if (id_getAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ == IntPtr.Zero)
					id_getAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ = JNIEnv.GetMethodID (class_ref, "getAbove", "(Lorg/jcodec/codecs/vp8/VP8Util$PLANE;[[Lorg/jcodec/codecs/vp8/Macroblock;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAbove_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAbove", "(Lorg/jcodec/codecs/vp8/VP8Util$PLANE;[[Lorg/jcodec/codecs/vp8/Macroblock;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_getLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
#pragma warning disable 0169
			static Delegate GetGetLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Handler ()
			{
				if (cb_getLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ == null)
					cb_getLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_);
				return cb_getLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
			}

			static IntPtr n_GetLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p1 = (global::Org.Jcodec.Codecs.Vp8.Macroblock[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Codecs.Vp8.Macroblock[]));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLeft (p0, p1));
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']/method[@name='getLeft' and count(parameter)=2 and parameter[1][@type='org.jcodec.codecs.vp8.VP8Util.PLANE'] and parameter[2][@type='org.jcodec.codecs.vp8.Macroblock[][]']]"
			[Register ("getLeft", "(Lorg/jcodec/codecs/vp8/VP8Util$PLANE;[[Lorg/jcodec/codecs/vp8/Macroblock;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;", "GetGetLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Handler")]
			public virtual unsafe global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock GetLeft (global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE p0, global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p1)
			{
				if (id_getLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ == IntPtr.Zero)
					id_getLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ = JNIEnv.GetMethodID (class_ref, "getLeft", "(Lorg/jcodec/codecs/vp8/VP8Util$PLANE;[[Lorg/jcodec/codecs/vp8/Macroblock;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLeft_Lorg_jcodec_codecs_vp8_VP8Util_PLANE_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeft", "(Lorg/jcodec/codecs/vp8/VP8Util$PLANE;[[Lorg/jcodec/codecs/vp8/Macroblock;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_predict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
#pragma warning disable 0169
			static Delegate GetPredict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Handler ()
			{
				if (cb_predict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ == null)
					cb_predict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Predict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_);
				return cb_predict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
			}

			static void n_Predict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p0 = (global::Org.Jcodec.Codecs.Vp8.Macroblock[][]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Codecs.Vp8.Macroblock[]));
				__this.Predict (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_predict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']/method[@name='predict' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.vp8.Macroblock[][]']]"
			[Register ("predict", "([[Lorg/jcodec/codecs/vp8/Macroblock;)V", "GetPredict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Handler")]
			public virtual unsafe void Predict (global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p0)
			{
				if (id_predict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ == IntPtr.Zero)
					id_predict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ = JNIEnv.GetMethodID (class_ref, "predict", "([[Lorg/jcodec/codecs/vp8/Macroblock;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predict_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predict", "([[Lorg/jcodec/codecs/vp8/Macroblock;)V"), __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_reconstruct;
#pragma warning disable 0169
			static Delegate GetReconstructHandler ()
			{
				if (cb_reconstruct == null)
					cb_reconstruct = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reconstruct);
				return cb_reconstruct;
			}

			static void n_Reconstruct (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Reconstruct ();
			}
#pragma warning restore 0169

			static IntPtr id_reconstruct;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock.Subblock']/method[@name='reconstruct' and count(parameter)=0]"
			[Register ("reconstruct", "()V", "GetReconstructHandler")]
			public virtual unsafe void Reconstruct ()
			{
				if (id_reconstruct == IntPtr.Zero)
					id_reconstruct = JNIEnv.GetMethodID (class_ref, "reconstruct", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reconstruct);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reconstruct", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vp8/Macroblock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Macroblock); }
		}

		protected Macroblock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/constructor[@name='Macroblock' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Macroblock (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Macroblock)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_decodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayI;
#pragma warning disable 0169
		static Delegate GetDecodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIHandler ()
		{
			if (cb_decodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayI == null)
				cb_decodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayI);
			return cb_decodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayI;
		}

		static void n_DecodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Jcodec.Codecs.Vp8.Macroblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p0 = (global::Org.Jcodec.Codecs.Vp8.Macroblock[][]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Codecs.Vp8.Macroblock[]));
			global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder> (native_p1, JniHandleOwnership.DoNotTransfer);
			int[][][][] p2 = (int[][][][]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int[][][]));
			__this.DecodeMacroBlock (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_decodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/method[@name='decodeMacroBlock' and count(parameter)=3 and parameter[1][@type='org.jcodec.codecs.vp8.Macroblock[][]'] and parameter[2][@type='org.jcodec.codecs.vp8.BooleanArithmeticDecoder'] and parameter[3][@type='int[][][][]']]"
		[Register ("decodeMacroBlock", "([[Lorg/jcodec/codecs/vp8/Macroblock;Lorg/jcodec/codecs/vp8/BooleanArithmeticDecoder;[[[[I)V", "GetDecodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayIHandler")]
		public virtual unsafe void DecodeMacroBlock (global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p0, global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder p1, int[][][][] p2)
		{
			if (id_decodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayI == IntPtr.Zero)
				id_decodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayI = JNIEnv.GetMethodID (class_ref, "decodeMacroBlock", "([[Lorg/jcodec/codecs/vp8/Macroblock;Lorg/jcodec/codecs/vp8/BooleanArithmeticDecoder;[[[[I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_BooleanArithmeticDecoder_arrayarrayarrayarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeMacroBlock", "([[Lorg/jcodec/codecs/vp8/Macroblock;Lorg/jcodec/codecs/vp8/BooleanArithmeticDecoder;[[[[I)V"), __args);
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

		static Delegate cb_dequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_;
#pragma warning disable 0169
		static Delegate GetDequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_Handler ()
		{
			if (cb_dequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_ == null)
				cb_dequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_);
			return cb_dequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_;
		}

		static void n_DequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Vp8.Macroblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p0 = (global::Org.Jcodec.Codecs.Vp8.Macroblock[][]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Codecs.Vp8.Macroblock[]));
			global::Org.Jcodec.Codecs.Vp8.VP8Util.QuantizationParams p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Util.QuantizationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DequantMacroBlock (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_dequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/method[@name='dequantMacroBlock' and count(parameter)=2 and parameter[1][@type='org.jcodec.codecs.vp8.Macroblock[][]'] and parameter[2][@type='org.jcodec.codecs.vp8.VP8Util.QuantizationParams']]"
		[Register ("dequantMacroBlock", "([[Lorg/jcodec/codecs/vp8/Macroblock;Lorg/jcodec/codecs/vp8/VP8Util$QuantizationParams;)V", "GetDequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_Handler")]
		public virtual unsafe void DequantMacroBlock (global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p0, global::Org.Jcodec.Codecs.Vp8.VP8Util.QuantizationParams p1)
		{
			if (id_dequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_ == IntPtr.Zero)
				id_dequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_ = JNIEnv.GetMethodID (class_ref, "dequantMacroBlock", "([[Lorg/jcodec/codecs/vp8/Macroblock;Lorg/jcodec/codecs/vp8/VP8Util$QuantizationParams;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dequantMacroBlock_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Lorg_jcodec_codecs_vp8_VP8Util_QuantizationParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dequantMacroBlock", "([[Lorg/jcodec/codecs/vp8/Macroblock;Lorg/jcodec/codecs/vp8/VP8Util$QuantizationParams;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_;
#pragma warning disable 0169
		static Delegate GetGetBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_Handler ()
		{
			if (cb_getBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_ == null)
				cb_getBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_);
			return cb_getBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_;
		}

		static IntPtr n_GetBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Vp8.Macroblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBottomSubblock (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/method[@name='getBottomSubblock' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.jcodec.codecs.vp8.VP8Util.PLANE']]"
		[Register ("getBottomSubblock", "(ILorg/jcodec/codecs/vp8/VP8Util$PLANE;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;", "GetGetBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_Handler")]
		public virtual unsafe global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock GetBottomSubblock (int p0, global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE p1)
		{
			if (id_getBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_ == IntPtr.Zero)
				id_getBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_ = JNIEnv.GetMethodID (class_ref, "getBottomSubblock", "(ILorg/jcodec/codecs/vp8/VP8Util$PLANE;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBottomSubblock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBottomSubblock", "(ILorg/jcodec/codecs/vp8/VP8Util$PLANE;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_;
#pragma warning disable 0169
		static Delegate GetGetRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_Handler ()
		{
			if (cb_getRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_ == null)
				cb_getRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_);
			return cb_getRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_;
		}

		static IntPtr n_GetRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Vp8.Macroblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRightSubBlock (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/method[@name='getRightSubBlock' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.jcodec.codecs.vp8.VP8Util.PLANE']]"
		[Register ("getRightSubBlock", "(ILorg/jcodec/codecs/vp8/VP8Util$PLANE;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;", "GetGetRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_Handler")]
		public virtual unsafe global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock GetRightSubBlock (int p0, global::Org.Jcodec.Codecs.Vp8.VP8Util.PLANE p1)
		{
			if (id_getRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_ == IntPtr.Zero)
				id_getRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_ = JNIEnv.GetMethodID (class_ref, "getRightSubBlock", "(ILorg/jcodec/codecs/vp8/VP8Util$PLANE;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRightSubBlock_ILorg_jcodec_codecs_vp8_VP8Util_PLANE_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRightSubBlock", "(ILorg/jcodec/codecs/vp8/VP8Util$PLANE;)Lorg/jcodec/codecs/vp8/Macroblock$Subblock;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_predictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
#pragma warning disable 0169
		static Delegate GetPredictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Handler ()
		{
			if (cb_predictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ == null)
				cb_predictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PredictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_);
			return cb_predictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
		}

		static void n_PredictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Vp8.Macroblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p0 = (global::Org.Jcodec.Codecs.Vp8.Macroblock[][]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Codecs.Vp8.Macroblock[]));
			__this.PredictUV (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_predictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/method[@name='predictUV' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.vp8.Macroblock[][]']]"
		[Register ("predictUV", "([[Lorg/jcodec/codecs/vp8/Macroblock;)V", "GetPredictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_Handler")]
		public virtual unsafe void PredictUV (global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p0)
		{
			if (id_predictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ == IntPtr.Zero)
				id_predictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_ = JNIEnv.GetMethodID (class_ref, "predictUV", "([[Lorg/jcodec/codecs/vp8/Macroblock;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictUV", "([[Lorg/jcodec/codecs/vp8/Macroblock;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_reconstruct;
#pragma warning disable 0169
		static Delegate GetReconstructHandler ()
		{
			if (cb_reconstruct == null)
				cb_reconstruct = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reconstruct);
			return cb_reconstruct;
		}

		static void n_Reconstruct (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Vp8.Macroblock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reconstruct ();
		}
#pragma warning restore 0169

		static IntPtr id_reconstruct;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='Macroblock']/method[@name='reconstruct' and count(parameter)=0]"
		[Register ("reconstruct", "()V", "GetReconstructHandler")]
		public virtual unsafe void Reconstruct ()
		{
			if (id_reconstruct == IntPtr.Zero)
				id_reconstruct = JNIEnv.GetMethodID (class_ref, "reconstruct", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reconstruct);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reconstruct", "()V"));
			} finally {
			}
		}

	}
}
