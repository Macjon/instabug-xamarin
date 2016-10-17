using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Aac {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockWriter']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/aac/BlockWriter", DoNotGenerateAcw=true)]
	public partial class BlockWriter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/aac/BlockWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockWriter); }
		}

		protected BlockWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockWriter']/constructor[@name='BlockWriter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlockWriter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BlockWriter)) {
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

		static Delegate cb_nextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_;
#pragma warning disable 0169
		static Delegate GetNextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_Handler ()
		{
			if (cb_nextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_ == null)
				cb_nextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_NextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_);
			return cb_nextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_;
		}

		static void n_NextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Aac.BlockWriter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitWriter p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Aac.Blocks.Block p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Blocks.Block> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NextBlock (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_nextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockWriter']/method[@name='nextBlock' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='org.jcodec.codecs.aac.blocks.Block']]"
		[Register ("nextBlock", "(Lorg/jcodec/common/io/BitWriter;Lorg/jcodec/codecs/aac/blocks/Block;)V", "GetNextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_Handler")]
		public virtual unsafe void NextBlock (global::Org.Jcodec.Common.IO.BitWriter p0, global::Org.Jcodec.Codecs.Aac.Blocks.Block p1)
		{
			if (id_nextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_ == IntPtr.Zero)
				id_nextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_ = JNIEnv.GetMethodID (class_ref, "nextBlock", "(Lorg/jcodec/common/io/BitWriter;Lorg/jcodec/codecs/aac/blocks/Block;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_nextBlock_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_aac_blocks_Block_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextBlock", "(Lorg/jcodec/common/io/BitWriter;Lorg/jcodec/codecs/aac/blocks/Block;)V"), __args);
			} finally {
			}
		}

	}
}
