using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vp8 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vp8/BooleanArithmeticDecoder", DoNotGenerateAcw=true)]
	public partial class BooleanArithmeticDecoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vp8/BooleanArithmeticDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BooleanArithmeticDecoder); }
		}

		protected BooleanArithmeticDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']/constructor[@name='BooleanArithmeticDecoder' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;ILjava/lang/String;)V", "")]
		public unsafe BooleanArithmeticDecoder (global::Java.Nio.ByteBuffer p0, int p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (BooleanArithmeticDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/ByteBuffer;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']/constructor[@name='BooleanArithmeticDecoder' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;I)V", "")]
		public unsafe BooleanArithmeticDecoder (global::Java.Nio.ByteBuffer p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BooleanArithmeticDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/ByteBuffer;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_I == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_I, __args);
			} finally {
			}
		}

		static Delegate cb_decodeBit;
#pragma warning disable 0169
		static Delegate GetDecodeBitHandler ()
		{
			if (cb_decodeBit == null)
				cb_decodeBit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DecodeBit);
			return cb_decodeBit;
		}

		static int n_DecodeBit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecodeBit ();
		}
#pragma warning restore 0169

		static IntPtr id_decodeBit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']/method[@name='decodeBit' and count(parameter)=0]"
		[Register ("decodeBit", "()I", "GetDecodeBitHandler")]
		public virtual unsafe int DecodeBit ()
		{
			if (id_decodeBit == IntPtr.Zero)
				id_decodeBit = JNIEnv.GetMethodID (class_ref, "decodeBit", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_decodeBit);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBit", "()I"));
			} finally {
			}
		}

		static Delegate cb_decodeBool_I;
#pragma warning disable 0169
		static Delegate GetDecodeBool_IHandler ()
		{
			if (cb_decodeBool_I == null)
				cb_decodeBool_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_DecodeBool_I);
			return cb_decodeBool_I;
		}

		static int n_DecodeBool_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecodeBool (p0);
		}
#pragma warning restore 0169

		static IntPtr id_decodeBool_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']/method[@name='decodeBool' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("decodeBool", "(I)I", "GetDecodeBool_IHandler")]
		public virtual unsafe int DecodeBool (int p0)
		{
			if (id_decodeBool_I == IntPtr.Zero)
				id_decodeBool_I = JNIEnv.GetMethodID (class_ref, "decodeBool", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_decodeBool_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBool", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_decodeInt_I;
#pragma warning disable 0169
		static Delegate GetDecodeInt_IHandler ()
		{
			if (cb_decodeInt_I == null)
				cb_decodeInt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_DecodeInt_I);
			return cb_decodeInt_I;
		}

		static int n_DecodeInt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecodeInt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_decodeInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']/method[@name='decodeInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("decodeInt", "(I)I", "GetDecodeInt_IHandler")]
		public virtual unsafe int DecodeInt (int p0)
		{
			if (id_decodeInt_I == IntPtr.Zero)
				id_decodeInt_I = JNIEnv.GetMethodID (class_ref, "decodeInt", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_decodeInt_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeInt", "(I)I"), __args);
			} finally {
			}
		}

		static IntPtr id_getBitInBytes_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']/method[@name='getBitInBytes' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']/method[@name='getBitsInBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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

		static IntPtr id_leadingZeroCountInByte_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']/method[@name='leadingZeroCountInByte' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("leadingZeroCountInByte", "(B)I", "")]
		public static unsafe int LeadingZeroCountInByte (sbyte p0)
		{
			if (id_leadingZeroCountInByte_B == IntPtr.Zero)
				id_leadingZeroCountInByte_B = JNIEnv.GetStaticMethodID (class_ref, "leadingZeroCountInByte", "(B)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_leadingZeroCountInByte_B, __args);
			} finally {
			}
		}

		static Delegate cb_readTree_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetReadTree_arrayIarrayIHandler ()
		{
			if (cb_readTree_arrayIarrayI == null)
				cb_readTree_arrayIarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ReadTree_arrayIarrayI);
			return cb_readTree_arrayIarrayI;
		}

		static int n_ReadTree_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.ReadTree (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readTree_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']/method[@name='readTree' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("readTree", "([I[I)I", "GetReadTree_arrayIarrayIHandler")]
		public virtual unsafe int ReadTree (int[] p0, int[] p1)
		{
			if (id_readTree_arrayIarrayI == IntPtr.Zero)
				id_readTree_arrayIarrayI = JNIEnv.GetMethodID (class_ref, "readTree", "([I[I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readTree_arrayIarrayI, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readTree", "([I[I)I"), __args);
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

		static Delegate cb_readTreeSkip_arrayIarrayII;
#pragma warning disable 0169
		static Delegate GetReadTreeSkip_arrayIarrayIIHandler ()
		{
			if (cb_readTreeSkip_arrayIarrayII == null)
				cb_readTreeSkip_arrayIarrayII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_ReadTreeSkip_arrayIarrayII);
			return cb_readTreeSkip_arrayIarrayII;
		}

		static int n_ReadTreeSkip_arrayIarrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.ReadTreeSkip (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readTreeSkip_arrayIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']/method[@name='readTreeSkip' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int']]"
		[Register ("readTreeSkip", "([I[II)I", "GetReadTreeSkip_arrayIarrayIIHandler")]
		public virtual unsafe int ReadTreeSkip (int[] p0, int[] p1, int p2)
		{
			if (id_readTreeSkip_arrayIarrayII == IntPtr.Zero)
				id_readTreeSkip_arrayIarrayII = JNIEnv.GetMethodID (class_ref, "readTreeSkip", "([I[II)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readTreeSkip_arrayIarrayII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readTreeSkip", "([I[II)I"), __args);
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

		static Delegate cb_seek;
#pragma warning disable 0169
		static Delegate GetSeekHandler ()
		{
			if (cb_seek == null)
				cb_seek = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Seek);
			return cb_seek;
		}

		static void n_Seek (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.BooleanArithmeticDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Seek ();
		}
#pragma warning restore 0169

		static IntPtr id_seek;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='BooleanArithmeticDecoder']/method[@name='seek' and count(parameter)=0]"
		[Register ("seek", "()V", "GetSeekHandler")]
		public virtual unsafe void Seek ()
		{
			if (id_seek == IntPtr.Zero)
				id_seek = JNIEnv.GetMethodID (class_ref, "seek", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seek);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seek", "()V"));
			} finally {
			}
		}

	}
}
