using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Aac.Blocks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockCCE']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/aac/blocks/BlockCCE", DoNotGenerateAcw=true)]
	public partial class BlockCCE : global::Org.Jcodec.Codecs.Aac.Blocks.Block {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockCCE.CouplingPoint']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/aac/blocks/BlockCCE$CouplingPoint", DoNotGenerateAcw=true)]
		public sealed partial class CouplingPoint : global::Java.Lang.Enum {


			static IntPtr AFTER_IMDCT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockCCE.CouplingPoint']/field[@name='AFTER_IMDCT']"
			[Register ("AFTER_IMDCT")]
			public static global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE.CouplingPoint AfterImdct {
				get {
					if (AFTER_IMDCT_jfieldId == IntPtr.Zero)
						AFTER_IMDCT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AFTER_IMDCT", "Lorg/jcodec/codecs/aac/blocks/BlockCCE$CouplingPoint;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AFTER_IMDCT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE.CouplingPoint> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BEFORE_TNS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockCCE.CouplingPoint']/field[@name='BEFORE_TNS']"
			[Register ("BEFORE_TNS")]
			public static global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE.CouplingPoint BeforeTns {
				get {
					if (BEFORE_TNS_jfieldId == IntPtr.Zero)
						BEFORE_TNS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BEFORE_TNS", "Lorg/jcodec/codecs/aac/blocks/BlockCCE$CouplingPoint;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BEFORE_TNS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE.CouplingPoint> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BETWEEN_TNS_AND_IMDCT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockCCE.CouplingPoint']/field[@name='BETWEEN_TNS_AND_IMDCT']"
			[Register ("BETWEEN_TNS_AND_IMDCT")]
			public static global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE.CouplingPoint BetweenTnsAndImdct {
				get {
					if (BETWEEN_TNS_AND_IMDCT_jfieldId == IntPtr.Zero)
						BETWEEN_TNS_AND_IMDCT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BETWEEN_TNS_AND_IMDCT", "Lorg/jcodec/codecs/aac/blocks/BlockCCE$CouplingPoint;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BETWEEN_TNS_AND_IMDCT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE.CouplingPoint> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNDEF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockCCE.CouplingPoint']/field[@name='UNDEF']"
			[Register ("UNDEF")]
			public static global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE.CouplingPoint Undef {
				get {
					if (UNDEF_jfieldId == IntPtr.Zero)
						UNDEF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNDEF", "Lorg/jcodec/codecs/aac/blocks/BlockCCE$CouplingPoint;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNDEF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE.CouplingPoint> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/aac/blocks/BlockCCE$CouplingPoint", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CouplingPoint); }
			}

			internal CouplingPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockCCE.CouplingPoint']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
			public static unsafe global::Java.Lang.Enum ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Java.Lang.Enum __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockCCE.CouplingPoint']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/jcodec/codecs/aac/blocks/BlockCCE$CouplingPoint;", "")]
			public static unsafe global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE.CouplingPoint[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/codecs/aac/blocks/BlockCCE$CouplingPoint;");
				try {
					return (global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE.CouplingPoint[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE.CouplingPoint));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/aac/blocks/BlockCCE", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockCCE); }
		}

		protected BlockCCE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_parse_Lorg_jcodec_common_io_BitReader_;
#pragma warning disable 0169
		static Delegate GetParse_Lorg_jcodec_common_io_BitReader_Handler ()
		{
			if (cb_parse_Lorg_jcodec_common_io_BitReader_ == null)
				cb_parse_Lorg_jcodec_common_io_BitReader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Parse_Lorg_jcodec_common_io_BitReader_);
			return cb_parse_Lorg_jcodec_common_io_BitReader_;
		}

		static void n_Parse_Lorg_jcodec_common_io_BitReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Blocks.BlockCCE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader @in = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native__in, JniHandleOwnership.DoNotTransfer);
			__this.Parse (@in);
		}
#pragma warning restore 0169

		static IntPtr id_parse_Lorg_jcodec_common_io_BitReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockCCE']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("parse", "(Lorg/jcodec/common/io/BitReader;)V", "GetParse_Lorg_jcodec_common_io_BitReader_Handler")]
		public override unsafe void Parse (global::Org.Jcodec.Common.IO.BitReader @in)
		{
			if (id_parse_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_parse_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lorg/jcodec/common/io/BitReader;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parse_Lorg_jcodec_common_io_BitReader_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Lorg/jcodec/common/io/BitReader;)V"), __args);
			} finally {
			}
		}

	}
}
