using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Aac.Blocks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockDSE']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/aac/blocks/BlockDSE", DoNotGenerateAcw=true)]
	public partial class BlockDSE : global::Org.Jcodec.Codecs.Aac.Blocks.Block {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/aac/blocks/BlockDSE", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockDSE); }
		}

		protected BlockDSE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockDSE']/constructor[@name='BlockDSE' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlockDSE ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BlockDSE)) {
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

		static Delegate cb_parse_Lorg_jcodec_common_io_BitReader_;
#pragma warning disable 0169
		static Delegate GetParse_Lorg_jcodec_common_io_BitReader_Handler ()
		{
			if (cb_parse_Lorg_jcodec_common_io_BitReader_ == null)
				cb_parse_Lorg_jcodec_common_io_BitReader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Parse_Lorg_jcodec_common_io_BitReader_);
			return cb_parse_Lorg_jcodec_common_io_BitReader_;
		}

		static void n_Parse_Lorg_jcodec_common_io_BitReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Aac.Blocks.BlockDSE __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Blocks.BlockDSE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_parse_Lorg_jcodec_common_io_BitReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac.blocks']/class[@name='BlockDSE']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("parse", "(Lorg/jcodec/common/io/BitReader;)V", "GetParse_Lorg_jcodec_common_io_BitReader_Handler")]
		public override unsafe void Parse (global::Org.Jcodec.Common.IO.BitReader p0)
		{
			if (id_parse_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_parse_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lorg/jcodec/common/io/BitReader;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parse_Lorg_jcodec_common_io_BitReader_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Lorg/jcodec/common/io/BitReader;)V"), __args);
			} finally {
			}
		}

	}
}
