using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPEGDecoder", DoNotGenerateAcw=true)]
	public partial class MPEGDecoder : global::Java.Lang.Object {


		static IntPtr gh_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/field[@name='gh']"
		[Register ("gh")]
		protected global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader Gh {
			get {
				if (gh_jfieldId == IntPtr.Zero)
					gh_jfieldId = JNIEnv.GetFieldID (class_ref, "gh", "Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, gh_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (gh_jfieldId == IntPtr.Zero)
					gh_jfieldId = JNIEnv.GetFieldID (class_ref, "gh", "Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, gh_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sh_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/field[@name='sh']"
		[Register ("sh")]
		protected global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader Sh {
			get {
				if (sh_jfieldId == IntPtr.Zero)
					sh_jfieldId = JNIEnv.GetFieldID (class_ref, "sh", "Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sh_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sh_jfieldId == IntPtr.Zero)
					sh_jfieldId = JNIEnv.GetFieldID (class_ref, "sh", "Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sh_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPEGDecoder$Context", DoNotGenerateAcw=true)]
		public partial class Context : global::Java.Lang.Object {


			static IntPtr codedHeight_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']/field[@name='codedHeight']"
			[Register ("codedHeight")]
			public int CodedHeight {
				get {
					if (codedHeight_jfieldId == IntPtr.Zero)
						codedHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "codedHeight", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, codedHeight_jfieldId);
				}
				set {
					if (codedHeight_jfieldId == IntPtr.Zero)
						codedHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "codedHeight", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codedHeight_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr codedWidth_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']/field[@name='codedWidth']"
			[Register ("codedWidth")]
			public int CodedWidth {
				get {
					if (codedWidth_jfieldId == IntPtr.Zero)
						codedWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "codedWidth", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, codedWidth_jfieldId);
				}
				set {
					if (codedWidth_jfieldId == IntPtr.Zero)
						codedWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "codedWidth", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codedWidth_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr color_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']/field[@name='color']"
			[Register ("color")]
			public global::Org.Jcodec.Common.Model.ColorSpace Color {
				get {
					if (color_jfieldId == IntPtr.Zero)
						color_jfieldId = JNIEnv.GetFieldID (class_ref, "color", "Lorg/jcodec/common/model/ColorSpace;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, color_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (color_jfieldId == IntPtr.Zero)
						color_jfieldId = JNIEnv.GetFieldID (class_ref, "color", "Lorg/jcodec/common/model/ColorSpace;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, color_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr lastPredB_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']/field[@name='lastPredB']"
			[Register ("lastPredB")]
			public global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType LastPredB {
				get {
					if (lastPredB_jfieldId == IntPtr.Zero)
						lastPredB_jfieldId = JNIEnv.GetFieldID (class_ref, "lastPredB", "Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, lastPredB_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGConst.MBType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (lastPredB_jfieldId == IntPtr.Zero)
						lastPredB_jfieldId = JNIEnv.GetFieldID (class_ref, "lastPredB", "Lorg/jcodec/codecs/mpeg12/MPEGConst$MBType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lastPredB_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr mbHeight_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']/field[@name='mbHeight']"
			[Register ("mbHeight")]
			public int MbHeight {
				get {
					if (mbHeight_jfieldId == IntPtr.Zero)
						mbHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mbHeight", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mbHeight_jfieldId);
				}
				set {
					if (mbHeight_jfieldId == IntPtr.Zero)
						mbHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mbHeight", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mbHeight_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr mbWidth_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']/field[@name='mbWidth']"
			[Register ("mbWidth")]
			public int MbWidth {
				get {
					if (mbWidth_jfieldId == IntPtr.Zero)
						mbWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mbWidth", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mbWidth_jfieldId);
				}
				set {
					if (mbWidth_jfieldId == IntPtr.Zero)
						mbWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mbWidth", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mbWidth_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr picHeight_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']/field[@name='picHeight']"
			[Register ("picHeight")]
			public int PicHeight {
				get {
					if (picHeight_jfieldId == IntPtr.Zero)
						picHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "picHeight", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, picHeight_jfieldId);
				}
				set {
					if (picHeight_jfieldId == IntPtr.Zero)
						picHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "picHeight", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, picHeight_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr picWidth_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']/field[@name='picWidth']"
			[Register ("picWidth")]
			public int PicWidth {
				get {
					if (picWidth_jfieldId == IntPtr.Zero)
						picWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "picWidth", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, picWidth_jfieldId);
				}
				set {
					if (picWidth_jfieldId == IntPtr.Zero)
						picWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "picWidth", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, picWidth_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr qMats_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']/field[@name='qMats']"
			[Register ("qMats")]
			public IList<int[]> QMats {
				get {
					if (qMats_jfieldId == IntPtr.Zero)
						qMats_jfieldId = JNIEnv.GetFieldID (class_ref, "qMats", "[[I");
					return global::Android.Runtime.JavaArray<int[]>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, qMats_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (qMats_jfieldId == IntPtr.Zero)
						qMats_jfieldId = JNIEnv.GetFieldID (class_ref, "qMats", "[[I");
					IntPtr native_value = global::Android.Runtime.JavaArray<int[]>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, qMats_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr scan_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']/field[@name='scan']"
			[Register ("scan")]
			public IList<int> Scan {
				get {
					if (scan_jfieldId == IntPtr.Zero)
						scan_jfieldId = JNIEnv.GetFieldID (class_ref, "scan", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, scan_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (scan_jfieldId == IntPtr.Zero)
						scan_jfieldId = JNIEnv.GetFieldID (class_ref, "scan", "[I");
					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, scan_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPEGDecoder$Context", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Context); }
			}

			protected Context (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder.Context']/constructor[@name='MPEGDecoder.Context' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.mpeg12.MPEGDecoder']]"
			[Register (".ctor", "(Lorg/jcodec/codecs/mpeg12/MPEGDecoder;)V", "")]
			public unsafe Context (global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (Context)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/mpeg12/MPEGDecoder;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPEGDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPEGDecoder); }
		}

		protected MPEGDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_GOPHeader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/constructor[@name='MPEGDecoder' and count(parameter)=2 and parameter[1][@type='org.jcodec.codecs.mpeg12.bitstream.SequenceHeader'] and parameter[2][@type='org.jcodec.codecs.mpeg12.bitstream.GOPHeader']]"
		[Register (".ctor", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;)V", "")]
		public unsafe MPEGDecoder (global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader p0, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MPEGDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_GOPHeader_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_GOPHeader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_GOPHeader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_GOPHeader_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/constructor[@name='MPEGDecoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MPEGDecoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MPEGDecoder)) {
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

		static Delegate cb_blockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayI;
#pragma warning disable 0169
		static Delegate GetBlockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayIHandler ()
		{
			if (cb_blockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayI == null)
				cb_blockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_BlockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayI);
			return cb_blockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayI;
		}

		static void n_BlockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, int p5, IntPtr native_p6)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.VLC p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (native_p1, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p6 = (int[]) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.BlockInter (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
		}
#pragma warning restore 0169

		static IntPtr id_blockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='blockInter' and count(parameter)=7 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='org.jcodec.common.io.VLC'] and parameter[3][@type='int[]'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int[]']]"
		[Register ("blockInter", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/common/io/VLC;[I[III[I)V", "GetBlockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayIHandler")]
		protected virtual unsafe void BlockInter (global::Org.Jcodec.Common.IO.BitReader p0, global::Org.Jcodec.Common.IO.VLC p1, int[] p2, int[] p3, int p4, int p5, int[] p6)
		{
			if (id_blockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayI == IntPtr.Zero)
				id_blockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayI = JNIEnv.GetMethodID (class_ref, "blockInter", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/common/io/VLC;[I[III[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockInter_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIIarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "blockInter", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/common/io/VLC;[I[III[I)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}
		}

		static Delegate cb_blockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayI;
#pragma warning disable 0169
		static Delegate GetBlockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayIHandler ()
		{
			if (cb_blockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayI == null)
				cb_blockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, int, int, IntPtr>) n_BlockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayI);
			return cb_blockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayI;
		}

		static void n_BlockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, IntPtr native_p5, int p6, int p7, int p8, IntPtr native_p9)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.VLC p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (native_p1, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p5 = (int[]) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p9 = (int[]) JNIEnv.GetArray (native_p9, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.BlockIntra (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			if (p9 != null)
				JNIEnv.CopyArray (p9, native_p9);
		}
#pragma warning restore 0169

		static IntPtr id_blockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='blockIntra' and count(parameter)=10 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='org.jcodec.common.io.VLC'] and parameter[3][@type='int[]'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int[]'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int[]']]"
		[Register ("blockIntra", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/common/io/VLC;[I[II[IIII[I)V", "GetBlockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayIHandler")]
		protected virtual unsafe void BlockIntra (global::Org.Jcodec.Common.IO.BitReader p0, global::Org.Jcodec.Common.IO.VLC p1, int[] p2, int[] p3, int p4, int[] p5, int p6, int p7, int p8, int[] p9)
		{
			if (id_blockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayI == IntPtr.Zero)
				id_blockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayI = JNIEnv.GetMethodID (class_ref, "blockIntra", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/common/io/VLC;[I[II[IIII[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p9 = JNIEnv.NewArray (p9);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (native_p9);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockIntra_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_common_io_VLC_arrayIarrayIIarrayIIIIarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "blockIntra", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/common/io/VLC;[I[II[IIII[I)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
				if (p9 != null) {
					JNIEnv.CopyArray (native_p9, p9);
					JNIEnv.DeleteLocalRef (native_p9);
				}
			}
		}

		static IntPtr id_clip_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='clip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("clip", "(I)I", "")]
		protected static unsafe int Clip (int p0)
		{
			if (id_clip_I == IntPtr.Zero)
				id_clip_I = JNIEnv.GetStaticMethodID (class_ref, "clip", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_clip_I, __args);
			} finally {
			}
		}

		static Delegate cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI;
#pragma warning disable 0169
		static Delegate GetDecodeFrame_Ljava_nio_ByteBuffer_arrayarrayIHandler ()
		{
			if (cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI == null)
				cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeFrame_Ljava_nio_ByteBuffer_arrayarrayI);
			return cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI;
		}

		static IntPtr n_DecodeFrame_Ljava_nio_ByteBuffer_arrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[][] p1 = (int[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeFrame (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='decodeFrame' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[][]']]"
		[Register ("decodeFrame", "(Ljava/nio/ByteBuffer;[[I)Lorg/jcodec/common/model/Picture;", "GetDecodeFrame_Ljava_nio_ByteBuffer_arrayarrayIHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture DecodeFrame (global::Java.Nio.ByteBuffer p0, int[][] p1)
		{
			if (id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI == IntPtr.Zero)
				id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI = JNIEnv.GetMethodID (class_ref, "decodeFrame", "(Ljava/nio/ByteBuffer;[[I)Lorg/jcodec/common/model/Picture;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Org.Jcodec.Common.Model.Picture __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeFrame", "(Ljava/nio/ByteBuffer;[[I)Lorg/jcodec/common/model/Picture;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_decodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_;
#pragma warning disable 0169
		static Delegate GetDecodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_Handler ()
		{
			if (cb_decodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_ == null)
				cb_decodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int, IntPtr, int, int, IntPtr, int>) n_DecodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_);
			return cb_decodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_;
		}

		static int n_DecodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4, int p5, IntPtr native_p6, int p7, int p8, IntPtr native_p9)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[][] p4 = (int[][]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			global::Org.Jcodec.Common.IO.BitReader p6 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_p6, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred p9 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (native_p9, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DecodeMacroblock (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='decodeMacroblock' and count(parameter)=10 and parameter[1][@type='org.jcodec.codecs.mpeg12.bitstream.PictureHeader'] and parameter[2][@type='org.jcodec.codecs.mpeg12.MPEGDecoder.Context'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int[][]'] and parameter[6][@type='int'] and parameter[7][@type='org.jcodec.common.io.BitReader'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='org.jcodec.codecs.mpeg12.MPEGPred']]"
		[Register ("decodeMacroblock", "(Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;Lorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;I[I[[IILorg/jcodec/common/io/BitReader;IILorg/jcodec/codecs/mpeg12/MPEGPred;)I", "GetDecodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_Handler")]
		public virtual unsafe int DecodeMacroblock (global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader p0, global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context p1, int p2, int[] p3, int[][] p4, int p5, global::Org.Jcodec.Common.IO.BitReader p6, int p7, int p8, global::Org.Jcodec.Codecs.Mpeg12.MPEGPred p9)
		{
			if (id_decodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_ == IntPtr.Zero)
				id_decodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_ = JNIEnv.GetMethodID (class_ref, "decodeMacroblock", "(Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;Lorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;I[I[[IILorg/jcodec/common/io/BitReader;IILorg/jcodec/codecs/mpeg12/MPEGPred;)I");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_decodeMacroblock_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_IarrayIarrayarrayIILorg_jcodec_common_io_BitReader_IILorg_jcodec_codecs_mpeg12_MPEGPred_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeMacroblock", "(Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;Lorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;I[I[[IILorg/jcodec/common/io/BitReader;IILorg/jcodec/codecs/mpeg12/MPEGPred;)I"), __args);
				return __ret;
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static Delegate cb_decodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIII;
#pragma warning disable 0169
		static Delegate GetDecodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIIIHandler ()
		{
			if (cb_decodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIII == null)
				cb_decodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_DecodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIII);
			return cb_decodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIII;
		}

		static IntPtr n_DecodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, int p5)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p2 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
			int[][] p3 = (int[][]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodePicture (p0, p1, p2, p3, p4, p5));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='decodePicture' and count(parameter)=6 and parameter[1][@type='org.jcodec.codecs.mpeg12.MPEGDecoder.Context'] and parameter[2][@type='org.jcodec.codecs.mpeg12.bitstream.PictureHeader'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='int[][]'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("decodePicture", "(Lorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;Ljava/nio/ByteBuffer;[[III)Lorg/jcodec/common/model/Picture;", "GetDecodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIIIHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture DecodePicture (global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context p0, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader p1, global::Java.Nio.ByteBuffer p2, int[][] p3, int p4, int p5)
		{
			if (id_decodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIII == IntPtr.Zero)
				id_decodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIII = JNIEnv.GetMethodID (class_ref, "decodePicture", "(Lorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;Ljava/nio/ByteBuffer;[[III)Lorg/jcodec/common/model/Picture;");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				global::Org.Jcodec.Common.Model.Picture __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodePicture_Lorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Ljava_nio_ByteBuffer_arrayarrayIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodePicture", "(Lorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;Ljava/nio/ByteBuffer;[[III)Lorg/jcodec/common/model/Picture;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_decodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_II;
#pragma warning disable 0169
		static Delegate GetDecodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_IIHandler ()
		{
			if (cb_decodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_II == null)
				cb_decodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, int>) n_DecodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_II);
			return cb_decodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_II;
		}

		static void n_DecodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, int p5, int p6)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context p2 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context> (native_p2, JniHandleOwnership.DoNotTransfer);
			int[][] p3 = (int[][]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			global::Org.Jcodec.Common.IO.BitReader p4 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.DecodeSlice (p0, p1, p2, p3, p4, p5, p6);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		static IntPtr id_decodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='decodeSlice' and count(parameter)=7 and parameter[1][@type='org.jcodec.codecs.mpeg12.bitstream.PictureHeader'] and parameter[2][@type='int'] and parameter[3][@type='org.jcodec.codecs.mpeg12.MPEGDecoder.Context'] and parameter[4][@type='int[][]'] and parameter[5][@type='org.jcodec.common.io.BitReader'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("decodeSlice", "(Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;ILorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;[[ILorg/jcodec/common/io/BitReader;II)V", "GetDecodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_IIHandler")]
		public virtual unsafe void DecodeSlice (global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader p0, int p1, global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context p2, int[][] p3, global::Org.Jcodec.Common.IO.BitReader p4, int p5, int p6)
		{
			if (id_decodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_II == IntPtr.Zero)
				id_decodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_II = JNIEnv.GetMethodID (class_ref, "decodeSlice", "(Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;ILorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;[[ILorg/jcodec/common/io/BitReader;II)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeSlice_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ILorg_jcodec_codecs_mpeg12_MPEGDecoder_Context_arrayarrayILorg_jcodec_common_io_BitReader_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeSlice", "(Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;ILorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;[[ILorg/jcodec/common/io/BitReader;II)V"), __args);
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_getCodedHeight_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='getCodedHeight' and count(parameter)=2 and parameter[1][@type='org.jcodec.codecs.mpeg12.bitstream.SequenceHeader'] and parameter[2][@type='org.jcodec.codecs.mpeg12.bitstream.PictureHeader']]"
		[Register ("getCodedHeight", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;)I", "")]
		public static unsafe int GetCodedHeight (global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader p0, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader p1)
		{
			if (id_getCodedHeight_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ == IntPtr.Zero)
				id_getCodedHeight_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ = JNIEnv.GetStaticMethodID (class_ref, "getCodedHeight", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getCodedHeight_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSize_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getSize", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/common/model/Size;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Size GetSize (global::Java.Nio.ByteBuffer p0)
		{
			if (id_getSize_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_getSize_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getSize", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/common/model/Size;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Common.Model.Size __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSize_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_initContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_;
#pragma warning disable 0169
		static Delegate GetInitContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Handler ()
		{
			if (cb_initContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ == null)
				cb_initContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InitContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_);
			return cb_initContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_;
		}

		static IntPtr n_InitContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InitContext (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_initContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='initContext' and count(parameter)=2 and parameter[1][@type='org.jcodec.codecs.mpeg12.bitstream.SequenceHeader'] and parameter[2][@type='org.jcodec.codecs.mpeg12.bitstream.PictureHeader']]"
		[Register ("initContext", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;)Lorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;", "GetInitContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_Handler")]
		protected virtual unsafe global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context InitContext (global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader p0, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.PictureHeader p1)
		{
			if (id_initContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ == IntPtr.Zero)
				id_initContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_ = JNIEnv.GetMethodID (class_ref, "initContext", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;)Lorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initContext_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_PictureHeader_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder.Context> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initContext", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/PictureHeader;)Lorg/jcodec/codecs/mpeg12/MPEGDecoder$Context;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_mapBlock_arrayIarrayIIII;
#pragma warning disable 0169
		static Delegate GetMapBlock_arrayIarrayIIIIHandler ()
		{
			if (cb_mapBlock_arrayIarrayIIII == null)
				cb_mapBlock_arrayIarrayIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int>) n_MapBlock_arrayIarrayIIII);
			return cb_mapBlock_arrayIarrayIIII;
		}

		static void n_MapBlock_arrayIarrayIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.MapBlock (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_mapBlock_arrayIarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='mapBlock' and count(parameter)=5 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("mapBlock", "([I[IIII)V", "GetMapBlock_arrayIarrayIIIIHandler")]
		protected virtual unsafe void MapBlock (int[] p0, int[] p1, int p2, int p3, int p4)
		{
			if (id_mapBlock_arrayIarrayIIII == IntPtr.Zero)
				id_mapBlock_arrayIarrayIIII = JNIEnv.GetMethodID (class_ref, "mapBlock", "([I[IIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_mapBlock_arrayIarrayIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mapBlock", "([I[IIII)V"), __args);
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

		static IntPtr id_mpegSigned_Lorg_jcodec_common_io_BitReader_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='mpegSigned' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='int']]"
		[Register ("mpegSigned", "(Lorg/jcodec/common/io/BitReader;I)I", "")]
		public static unsafe int MpegSigned (global::Org.Jcodec.Common.IO.BitReader p0, int p1)
		{
			if (id_mpegSigned_Lorg_jcodec_common_io_BitReader_I == IntPtr.Zero)
				id_mpegSigned_Lorg_jcodec_common_io_BitReader_I = JNIEnv.GetStaticMethodID (class_ref, "mpegSigned", "(Lorg/jcodec/common/io/BitReader;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_mpegSigned_Lorg_jcodec_common_io_BitReader_I, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_probe_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetProbe_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_probe_Ljava_nio_ByteBuffer_ == null)
				cb_probe_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Probe_Ljava_nio_ByteBuffer_);
			return cb_probe_Ljava_nio_ByteBuffer_;
		}

		static int n_Probe_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Probe (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_probe_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='probe' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("probe", "(Ljava/nio/ByteBuffer;)I", "GetProbe_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe int Probe (global::Java.Nio.ByteBuffer p0)
		{
			if (id_probe_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_probe_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "probe", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_probe_Ljava_nio_ByteBuffer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "probe", "(Ljava/nio/ByteBuffer;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_put_arrayarrayIarrayarrayIIIIIIIII;
#pragma warning disable 0169
		static Delegate GetPut_arrayarrayIarrayarrayIIIIIIIIIHandler ()
		{
			if (cb_put_arrayarrayIarrayarrayIIIIIIIII == null)
				cb_put_arrayarrayIarrayarrayIIIIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, int, int>) n_Put_arrayarrayIarrayarrayIIIIIIIII);
			return cb_put_arrayarrayIarrayarrayIIIIIIIII;
		}

		static void n_Put_arrayarrayIarrayarrayIIIIIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[][] p0 = (int[][]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			int[][] p1 = (int[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			__this.Put (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_arrayarrayIarrayarrayIIIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='put' and count(parameter)=10 and parameter[1][@type='int[][]'] and parameter[2][@type='int[][]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("put", "([[I[[IIIIIIIII)V", "GetPut_arrayarrayIarrayarrayIIIIIIIIIHandler")]
		protected virtual unsafe void Put (int[][] p0, int[][] p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9)
		{
			if (id_put_arrayarrayIarrayarrayIIIIIIIII == IntPtr.Zero)
				id_put_arrayarrayIarrayarrayIIIIIIIII = JNIEnv.GetMethodID (class_ref, "put", "([[I[[IIIIIIIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_arrayarrayIarrayarrayIIIIIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "([[I[[IIIIIIIII)V"), __args);
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

		static IntPtr id_quantInter_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='quantInter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("quantInter", "(II)I", "")]
		protected static unsafe int QuantInter (int p0, int p1)
		{
			if (id_quantInter_II == IntPtr.Zero)
				id_quantInter_II = JNIEnv.GetStaticMethodID (class_ref, "quantInter", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_quantInter_II, __args);
			} finally {
			}
		}

		static IntPtr id_quantInterSigned_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='quantInterSigned' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("quantInterSigned", "(II)I", "")]
		protected static unsafe int QuantInterSigned (int p0, int p1)
		{
			if (id_quantInterSigned_II == IntPtr.Zero)
				id_quantInterSigned_II = JNIEnv.GetStaticMethodID (class_ref, "quantInterSigned", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_quantInterSigned_II, __args);
			} finally {
			}
		}

		static IntPtr id_toSigned_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='toSigned' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("toSigned", "(II)I", "")]
		public static unsafe int ToSigned (int p0, int p1)
		{
			if (id_toSigned_II == IntPtr.Zero)
				id_toSigned_II = JNIEnv.GetStaticMethodID (class_ref, "toSigned", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_toSigned_II, __args);
			} finally {
			}
		}

		static IntPtr id_twosSigned_Lorg_jcodec_common_io_BitReader_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGDecoder']/method[@name='twosSigned' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='int']]"
		[Register ("twosSigned", "(Lorg/jcodec/common/io/BitReader;I)I", "")]
		public static unsafe int TwosSigned (global::Org.Jcodec.Common.IO.BitReader p0, int p1)
		{
			if (id_twosSigned_Lorg_jcodec_common_io_BitReader_I == IntPtr.Zero)
				id_twosSigned_Lorg_jcodec_common_io_BitReader_I = JNIEnv.GetStaticMethodID (class_ref, "twosSigned", "(Lorg/jcodec/common/io/BitReader;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_twosSigned_Lorg_jcodec_common_io_BitReader_I, __args);
				return __ret;
			} finally {
			}
		}

	}
}
