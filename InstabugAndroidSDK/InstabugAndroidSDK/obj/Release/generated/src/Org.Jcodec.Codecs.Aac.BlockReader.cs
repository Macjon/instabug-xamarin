using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Aac {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockReader']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/aac/BlockReader", DoNotGenerateAcw=true)]
	public partial class BlockReader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/aac/BlockReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockReader); }
		}

		protected BlockReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockReader']/constructor[@name='BlockReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlockReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BlockReader)) {
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

		static Delegate cb_nextBlock_Lorg_jcodec_common_io_BitReader_;
#pragma warning disable 0169
		static Delegate GetNextBlock_Lorg_jcodec_common_io_BitReader_Handler ()
		{
			if (cb_nextBlock_Lorg_jcodec_common_io_BitReader_ == null)
				cb_nextBlock_Lorg_jcodec_common_io_BitReader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NextBlock_Lorg_jcodec_common_io_BitReader_);
			return cb_nextBlock_Lorg_jcodec_common_io_BitReader_;
		}

		static IntPtr n_NextBlock_Lorg_jcodec_common_io_BitReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Aac.BlockReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.BlockReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NextBlock (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_nextBlock_Lorg_jcodec_common_io_BitReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='BlockReader']/method[@name='nextBlock' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("nextBlock", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/aac/blocks/Block;", "GetNextBlock_Lorg_jcodec_common_io_BitReader_Handler")]
		public virtual unsafe global::Org.Jcodec.Codecs.Aac.Blocks.Block NextBlock (global::Org.Jcodec.Common.IO.BitReader p0)
		{
			if (id_nextBlock_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_nextBlock_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetMethodID (class_ref, "nextBlock", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/aac/blocks/Block;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Codecs.Aac.Blocks.Block __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Blocks.Block> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextBlock_Lorg_jcodec_common_io_BitReader_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.Blocks.Block> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextBlock", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/aac/blocks/Block;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
