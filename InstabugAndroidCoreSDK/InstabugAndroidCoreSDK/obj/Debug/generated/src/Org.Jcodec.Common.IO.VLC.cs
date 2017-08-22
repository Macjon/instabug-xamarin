using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLC']"
	[global::Android.Runtime.Register ("org/jcodec/common/io/VLC", DoNotGenerateAcw=true)]
	public partial class VLC : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/io/VLC", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VLC); }
		}

		protected VLC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayIarrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLC']/constructor[@name='VLC' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register (".ctor", "([I[I)V", "")]
		public unsafe VLC (int[] codes, int[] codeSizes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_codes = JNIEnv.NewArray (codes);
			IntPtr native_codeSizes = JNIEnv.NewArray (codeSizes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_codes);
				__args [1] = new JValue (native_codeSizes);
				if (((object) this).GetType () != typeof (VLC)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([I[I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([I[I)V", __args);
					return;
				}

				if (id_ctor_arrayIarrayI == IntPtr.Zero)
					id_ctor_arrayIarrayI = JNIEnv.GetMethodID (class_ref, "<init>", "([I[I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayIarrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayIarrayI, __args);
			} finally {
				if (codes != null) {
					JNIEnv.CopyArray (native_codes, codes);
					JNIEnv.DeleteLocalRef (native_codes);
				}
				if (codeSizes != null) {
					JNIEnv.CopyArray (native_codeSizes, codeSizes);
					JNIEnv.DeleteLocalRef (native_codeSizes);
				}
			}
		}

		static IntPtr id_ctor_arrayLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLC']/constructor[@name='VLC' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register (".ctor", "([Ljava/lang/String;)V", "")]
		public unsafe VLC (params  string[] codes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_codes = JNIEnv.NewArray (codes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_codes);
				if (((object) this).GetType () != typeof (VLC)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_lang_String_ == IntPtr.Zero)
					id_ctor_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLjava_lang_String_, __args);
			} finally {
				if (codes != null) {
					JNIEnv.CopyArray (native_codes, codes);
					JNIEnv.DeleteLocalRef (native_codes);
				}
			}
		}

		static Delegate cb_getCodeSizes;
#pragma warning disable 0169
		static Delegate GetGetCodeSizesHandler ()
		{
			if (cb_getCodeSizes == null)
				cb_getCodeSizes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCodeSizes);
			return cb_getCodeSizes;
		}

		static IntPtr n_GetCodeSizes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.VLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCodeSizes ());
		}
#pragma warning restore 0169

		static IntPtr id_getCodeSizes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLC']/method[@name='getCodeSizes' and count(parameter)=0]"
		[Register ("getCodeSizes", "()[I", "GetGetCodeSizesHandler")]
		public virtual unsafe int[] GetCodeSizes ()
		{
			if (id_getCodeSizes == IntPtr.Zero)
				id_getCodeSizes = JNIEnv.GetMethodID (class_ref, "getCodeSizes", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodeSizes), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodeSizes", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getCodes;
#pragma warning disable 0169
		static Delegate GetGetCodesHandler ()
		{
			if (cb_getCodes == null)
				cb_getCodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCodes);
			return cb_getCodes;
		}

		static IntPtr n_GetCodes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.VLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCodes ());
		}
#pragma warning restore 0169

		static IntPtr id_getCodes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLC']/method[@name='getCodes' and count(parameter)=0]"
		[Register ("getCodes", "()[I", "GetGetCodesHandler")]
		public virtual unsafe int[] GetCodes ()
		{
			if (id_getCodes == IntPtr.Zero)
				id_getCodes = JNIEnv.GetMethodID (class_ref, "getCodes", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodes), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodes", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_printTable_Ljava_io_PrintStream_;
#pragma warning disable 0169
		static Delegate GetPrintTable_Ljava_io_PrintStream_Handler ()
		{
			if (cb_printTable_Ljava_io_PrintStream_ == null)
				cb_printTable_Ljava_io_PrintStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PrintTable_Ljava_io_PrintStream_);
			return cb_printTable_Ljava_io_PrintStream_;
		}

		static void n_PrintTable_Ljava_io_PrintStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ps)
		{
			global::Org.Jcodec.Common.IO.VLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.PrintStream ps = global::Java.Lang.Object.GetObject<global::Java.IO.PrintStream> (native_ps, JniHandleOwnership.DoNotTransfer);
			__this.PrintTable (ps);
		}
#pragma warning restore 0169

		static IntPtr id_printTable_Ljava_io_PrintStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLC']/method[@name='printTable' and count(parameter)=1 and parameter[1][@type='java.io.PrintStream']]"
		[Register ("printTable", "(Ljava/io/PrintStream;)V", "GetPrintTable_Ljava_io_PrintStream_Handler")]
		public virtual unsafe void PrintTable (global::Java.IO.PrintStream ps)
		{
			if (id_printTable_Ljava_io_PrintStream_ == IntPtr.Zero)
				id_printTable_Ljava_io_PrintStream_ = JNIEnv.GetMethodID (class_ref, "printTable", "(Ljava/io/PrintStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ps);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printTable_Ljava_io_PrintStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "printTable", "(Ljava/io/PrintStream;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_readVLC_Lorg_jcodec_common_io_BitReader_;
#pragma warning disable 0169
		static Delegate GetReadVLC_Lorg_jcodec_common_io_BitReader_Handler ()
		{
			if (cb_readVLC_Lorg_jcodec_common_io_BitReader_ == null)
				cb_readVLC_Lorg_jcodec_common_io_BitReader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReadVLC_Lorg_jcodec_common_io_BitReader_);
			return cb_readVLC_Lorg_jcodec_common_io_BitReader_;
		}

		static int n_ReadVLC_Lorg_jcodec_common_io_BitReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			global::Org.Jcodec.Common.IO.VLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader @in = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native__in, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadVLC (@in);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readVLC_Lorg_jcodec_common_io_BitReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLC']/method[@name='readVLC' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("readVLC", "(Lorg/jcodec/common/io/BitReader;)I", "GetReadVLC_Lorg_jcodec_common_io_BitReader_Handler")]
		public virtual unsafe int ReadVLC (global::Org.Jcodec.Common.IO.BitReader @in)
		{
			if (id_readVLC_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_readVLC_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetMethodID (class_ref, "readVLC", "(Lorg/jcodec/common/io/BitReader;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readVLC_Lorg_jcodec_common_io_BitReader_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readVLC", "(Lorg/jcodec/common/io/BitReader;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_readVLC16_Lorg_jcodec_common_io_BitReader_;
#pragma warning disable 0169
		static Delegate GetReadVLC16_Lorg_jcodec_common_io_BitReader_Handler ()
		{
			if (cb_readVLC16_Lorg_jcodec_common_io_BitReader_ == null)
				cb_readVLC16_Lorg_jcodec_common_io_BitReader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReadVLC16_Lorg_jcodec_common_io_BitReader_);
			return cb_readVLC16_Lorg_jcodec_common_io_BitReader_;
		}

		static int n_ReadVLC16_Lorg_jcodec_common_io_BitReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			global::Org.Jcodec.Common.IO.VLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader @in = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native__in, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadVLC16 (@in);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readVLC16_Lorg_jcodec_common_io_BitReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLC']/method[@name='readVLC16' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("readVLC16", "(Lorg/jcodec/common/io/BitReader;)I", "GetReadVLC16_Lorg_jcodec_common_io_BitReader_Handler")]
		public virtual unsafe int ReadVLC16 (global::Org.Jcodec.Common.IO.BitReader @in)
		{
			if (id_readVLC16_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_readVLC16_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetMethodID (class_ref, "readVLC16", "(Lorg/jcodec/common/io/BitReader;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readVLC16_Lorg_jcodec_common_io_BitReader_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readVLC16", "(Lorg/jcodec/common/io/BitReader;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_writeVLC_Lorg_jcodec_common_io_BitWriter_I;
#pragma warning disable 0169
		static Delegate GetWriteVLC_Lorg_jcodec_common_io_BitWriter_IHandler ()
		{
			if (cb_writeVLC_Lorg_jcodec_common_io_BitWriter_I == null)
				cb_writeVLC_Lorg_jcodec_common_io_BitWriter_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteVLC_Lorg_jcodec_common_io_BitWriter_I);
			return cb_writeVLC_Lorg_jcodec_common_io_BitWriter_I;
		}

		static void n_WriteVLC_Lorg_jcodec_common_io_BitWriter_I (IntPtr jnienv, IntPtr native__this, IntPtr native__out, int code)
		{
			global::Org.Jcodec.Common.IO.VLC __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitWriter @out = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.WriteVLC (@out, code);
		}
#pragma warning restore 0169

		static IntPtr id_writeVLC_Lorg_jcodec_common_io_BitWriter_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLC']/method[@name='writeVLC' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='int']]"
		[Register ("writeVLC", "(Lorg/jcodec/common/io/BitWriter;I)V", "GetWriteVLC_Lorg_jcodec_common_io_BitWriter_IHandler")]
		public virtual unsafe void WriteVLC (global::Org.Jcodec.Common.IO.BitWriter @out, int code)
		{
			if (id_writeVLC_Lorg_jcodec_common_io_BitWriter_I == IntPtr.Zero)
				id_writeVLC_Lorg_jcodec_common_io_BitWriter_I = JNIEnv.GetMethodID (class_ref, "writeVLC", "(Lorg/jcodec/common/io/BitWriter;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@out);
				__args [1] = new JValue (code);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeVLC_Lorg_jcodec_common_io_BitWriter_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeVLC", "(Lorg/jcodec/common/io/BitWriter;I)V"), __args);
			} finally {
			}
		}

	}
}
