using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']"
	[global::Android.Runtime.Register ("org/jcodec/common/io/BitReader", DoNotGenerateAcw=true)]
	public partial class BitReader : global::Java.Lang.Object {


		static IntPtr curInt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/field[@name='curInt']"
		[Register ("curInt")]
		protected int CurInt {
			get {
				if (curInt_jfieldId == IntPtr.Zero)
					curInt_jfieldId = JNIEnv.GetFieldID (class_ref, "curInt", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, curInt_jfieldId);
			}
			set {
				if (curInt_jfieldId == IntPtr.Zero)
					curInt_jfieldId = JNIEnv.GetFieldID (class_ref, "curInt", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, curInt_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr deficit_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/field[@name='deficit']"
		[Register ("deficit")]
		protected int Deficit {
			get {
				if (deficit_jfieldId == IntPtr.Zero)
					deficit_jfieldId = JNIEnv.GetFieldID (class_ref, "deficit", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, deficit_jfieldId);
			}
			set {
				if (deficit_jfieldId == IntPtr.Zero)
					deficit_jfieldId = JNIEnv.GetFieldID (class_ref, "deficit", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, deficit_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/io/BitReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitReader); }
		}

		protected BitReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/constructor[@name='BitReader' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;)V", "")]
		public unsafe BitReader (global::Java.Nio.ByteBuffer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BitReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_isByteAligned;
		public unsafe bool IsByteAligned {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='isByteAligned' and count(parameter)=0]"
			[Register ("isByteAligned", "()Z", "GetIsByteAlignedHandler")]
			get {
				if (id_isByteAligned == IntPtr.Zero)
					id_isByteAligned = JNIEnv.GetMethodID (class_ref, "isByteAligned", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isByteAligned);
				} finally {
				}
			}
		}

		static Delegate cb_align;
#pragma warning disable 0169
		static Delegate GetAlignHandler ()
		{
			if (cb_align == null)
				cb_align = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Align);
			return cb_align;
		}

		static int n_Align (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Align ();
		}
#pragma warning restore 0169

		static IntPtr id_align;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='align' and count(parameter)=0]"
		[Register ("align", "()I", "GetAlignHandler")]
		public virtual unsafe int Align ()
		{
			if (id_align == IntPtr.Zero)
				id_align = JNIEnv.GetMethodID (class_ref, "align", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_align);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "align", "()I"));
			} finally {
			}
		}

		static Delegate cb_check16Bits;
#pragma warning disable 0169
		static Delegate GetCheck16BitsHandler ()
		{
			if (cb_check16Bits == null)
				cb_check16Bits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Check16Bits);
			return cb_check16Bits;
		}

		static int n_Check16Bits (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Check16Bits ();
		}
#pragma warning restore 0169

		static IntPtr id_check16Bits;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='check16Bits' and count(parameter)=0]"
		[Register ("check16Bits", "()I", "GetCheck16BitsHandler")]
		public virtual unsafe int Check16Bits ()
		{
			if (id_check16Bits == IntPtr.Zero)
				id_check16Bits = JNIEnv.GetMethodID (class_ref, "check16Bits", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_check16Bits);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "check16Bits", "()I"));
			} finally {
			}
		}

		static Delegate cb_check24Bits;
#pragma warning disable 0169
		static Delegate GetCheck24BitsHandler ()
		{
			if (cb_check24Bits == null)
				cb_check24Bits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Check24Bits);
			return cb_check24Bits;
		}

		static int n_Check24Bits (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Check24Bits ();
		}
#pragma warning restore 0169

		static IntPtr id_check24Bits;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='check24Bits' and count(parameter)=0]"
		[Register ("check24Bits", "()I", "GetCheck24BitsHandler")]
		public virtual unsafe int Check24Bits ()
		{
			if (id_check24Bits == IntPtr.Zero)
				id_check24Bits = JNIEnv.GetMethodID (class_ref, "check24Bits", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_check24Bits);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "check24Bits", "()I"));
			} finally {
			}
		}

		static Delegate cb_checkAllBits;
#pragma warning disable 0169
		static Delegate GetCheckAllBitsHandler ()
		{
			if (cb_checkAllBits == null)
				cb_checkAllBits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_CheckAllBits);
			return cb_checkAllBits;
		}

		static int n_CheckAllBits (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckAllBits ();
		}
#pragma warning restore 0169

		static IntPtr id_checkAllBits;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='checkAllBits' and count(parameter)=0]"
		[Register ("checkAllBits", "()I", "GetCheckAllBitsHandler")]
		public virtual unsafe int CheckAllBits ()
		{
			if (id_checkAllBits == IntPtr.Zero)
				id_checkAllBits = JNIEnv.GetMethodID (class_ref, "checkAllBits", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_checkAllBits);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkAllBits", "()I"));
			} finally {
			}
		}

		static Delegate cb_checkNBit_I;
#pragma warning disable 0169
		static Delegate GetCheckNBit_IHandler ()
		{
			if (cb_checkNBit_I == null)
				cb_checkNBit_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_CheckNBit_I);
			return cb_checkNBit_I;
		}

		static int n_CheckNBit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckNBit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_checkNBit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='checkNBit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkNBit", "(I)I", "GetCheckNBit_IHandler")]
		public virtual unsafe int CheckNBit (int p0)
		{
			if (id_checkNBit_I == IntPtr.Zero)
				id_checkNBit_I = JNIEnv.GetMethodID (class_ref, "checkNBit", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_checkNBit_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkNBit", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_curBit;
#pragma warning disable 0169
		static Delegate GetCurBitHandler ()
		{
			if (cb_curBit == null)
				cb_curBit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_CurBit);
			return cb_curBit;
		}

		static int n_CurBit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurBit ();
		}
#pragma warning restore 0169

		static IntPtr id_curBit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='curBit' and count(parameter)=0]"
		[Register ("curBit", "()I", "GetCurBitHandler")]
		public virtual unsafe int CurBit ()
		{
			if (id_curBit == IntPtr.Zero)
				id_curBit = JNIEnv.GetMethodID (class_ref, "curBit", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_curBit);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "curBit", "()I"));
			} finally {
			}
		}

		static Delegate cb_fork;
#pragma warning disable 0169
		static Delegate GetForkHandler ()
		{
			if (cb_fork == null)
				cb_fork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Fork);
			return cb_fork;
		}

		static IntPtr n_Fork (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fork ());
		}
#pragma warning restore 0169

		static IntPtr id_fork;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='fork' and count(parameter)=0]"
		[Register ("fork", "()Lorg/jcodec/common/io/BitReader;", "GetForkHandler")]
		public virtual unsafe global::Org.Jcodec.Common.IO.BitReader Fork ()
		{
			if (id_fork == IntPtr.Zero)
				id_fork = JNIEnv.GetMethodID (class_ref, "fork", "()Lorg/jcodec/common/io/BitReader;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fork), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fork", "()Lorg/jcodec/common/io/BitReader;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_lastByte;
#pragma warning disable 0169
		static Delegate GetLastByteHandler ()
		{
			if (cb_lastByte == null)
				cb_lastByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_LastByte);
			return cb_lastByte;
		}

		static bool n_LastByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastByte ();
		}
#pragma warning restore 0169

		static IntPtr id_lastByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='lastByte' and count(parameter)=0]"
		[Register ("lastByte", "()Z", "GetLastByteHandler")]
		public virtual unsafe bool LastByte ()
		{
			if (id_lastByte == IntPtr.Zero)
				id_lastByte = JNIEnv.GetMethodID (class_ref, "lastByte", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_lastByte);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lastByte", "()Z"));
			} finally {
			}
		}

		static Delegate cb_moreData;
#pragma warning disable 0169
		static Delegate GetMoreDataHandler ()
		{
			if (cb_moreData == null)
				cb_moreData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_MoreData);
			return cb_moreData;
		}

		static bool n_MoreData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MoreData ();
		}
#pragma warning restore 0169

		static IntPtr id_moreData;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='moreData' and count(parameter)=0]"
		[Register ("moreData", "()Z", "GetMoreDataHandler")]
		public virtual unsafe bool MoreData ()
		{
			if (id_moreData == IntPtr.Zero)
				id_moreData = JNIEnv.GetMethodID (class_ref, "moreData", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_moreData);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moreData", "()Z"));
			} finally {
			}
		}

		static Delegate cb_position;
#pragma warning disable 0169
		static Delegate GetPositionHandler ()
		{
			if (cb_position == null)
				cb_position = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Position);
			return cb_position;
		}

		static int n_Position (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position ();
		}
#pragma warning restore 0169

		static IntPtr id_position;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='position' and count(parameter)=0]"
		[Register ("position", "()I", "GetPositionHandler")]
		public virtual unsafe int Position ()
		{
			if (id_position == IntPtr.Zero)
				id_position = JNIEnv.GetMethodID (class_ref, "position", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_position);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "position", "()I"));
			} finally {
			}
		}

		static Delegate cb_read1Bit;
#pragma warning disable 0169
		static Delegate GetRead1BitHandler ()
		{
			if (cb_read1Bit == null)
				cb_read1Bit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read1Bit);
			return cb_read1Bit;
		}

		static int n_Read1Bit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read1Bit ();
		}
#pragma warning restore 0169

		static IntPtr id_read1Bit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='read1Bit' and count(parameter)=0]"
		[Register ("read1Bit", "()I", "GetRead1BitHandler")]
		public virtual unsafe int Read1Bit ()
		{
			if (id_read1Bit == IntPtr.Zero)
				id_read1Bit = JNIEnv.GetMethodID (class_ref, "read1Bit", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read1Bit);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read1Bit", "()I"));
			} finally {
			}
		}

		static Delegate cb_readFast16_I;
#pragma warning disable 0169
		static Delegate GetReadFast16_IHandler ()
		{
			if (cb_readFast16_I == null)
				cb_readFast16_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_ReadFast16_I);
			return cb_readFast16_I;
		}

		static int n_ReadFast16_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadFast16 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readFast16_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='readFast16' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readFast16", "(I)I", "GetReadFast16_IHandler")]
		public virtual unsafe int ReadFast16 (int p0)
		{
			if (id_readFast16_I == IntPtr.Zero)
				id_readFast16_I = JNIEnv.GetMethodID (class_ref, "readFast16", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readFast16_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFast16", "(I)I"), __args);
			} finally {
			}
		}

		static IntPtr id_readInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='readInt' and count(parameter)=0]"
		[Register ("readInt", "()I", "")]
		public unsafe int ReadInt ()
		{
			if (id_readInt == IntPtr.Zero)
				id_readInt = JNIEnv.GetMethodID (class_ref, "readInt", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readInt);
			} finally {
			}
		}

		static Delegate cb_readNBit_I;
#pragma warning disable 0169
		static Delegate GetReadNBit_IHandler ()
		{
			if (cb_readNBit_I == null)
				cb_readNBit_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_ReadNBit_I);
			return cb_readNBit_I;
		}

		static int n_ReadNBit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadNBit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readNBit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='readNBit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readNBit", "(I)I", "GetReadNBit_IHandler")]
		public virtual unsafe int ReadNBit (int p0)
		{
			if (id_readNBit_I == IntPtr.Zero)
				id_readNBit_I = JNIEnv.GetMethodID (class_ref, "readNBit", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readNBit_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readNBit", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_remaining;
#pragma warning disable 0169
		static Delegate GetRemainingHandler ()
		{
			if (cb_remaining == null)
				cb_remaining = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Remaining);
			return cb_remaining;
		}

		static int n_Remaining (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Remaining ();
		}
#pragma warning restore 0169

		static IntPtr id_remaining;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='remaining' and count(parameter)=0]"
		[Register ("remaining", "()I", "GetRemainingHandler")]
		public virtual unsafe int Remaining ()
		{
			if (id_remaining == IntPtr.Zero)
				id_remaining = JNIEnv.GetMethodID (class_ref, "remaining", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_remaining);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remaining", "()I"));
			} finally {
			}
		}

		static Delegate cb_skip_I;
#pragma warning disable 0169
		static Delegate GetSkip_IHandler ()
		{
			if (cb_skip_I == null)
				cb_skip_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Skip_I);
			return cb_skip_I;
		}

		static int n_Skip_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Skip (p0);
		}
#pragma warning restore 0169

		static IntPtr id_skip_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)I", "GetSkip_IHandler")]
		public virtual unsafe int Skip (int p0)
		{
			if (id_skip_I == IntPtr.Zero)
				id_skip_I = JNIEnv.GetMethodID (class_ref, "skip", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_skip_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skip", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_skipFast_I;
#pragma warning disable 0169
		static Delegate GetSkipFast_IHandler ()
		{
			if (cb_skipFast_I == null)
				cb_skipFast_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_SkipFast_I);
			return cb_skipFast_I;
		}

		static int n_SkipFast_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipFast (p0);
		}
#pragma warning restore 0169

		static IntPtr id_skipFast_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='skipFast' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipFast", "(I)I", "GetSkipFast_IHandler")]
		public virtual unsafe int SkipFast (int p0)
		{
			if (id_skipFast_I == IntPtr.Zero)
				id_skipFast_I = JNIEnv.GetMethodID (class_ref, "skipFast", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_skipFast_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skipFast", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

		static Delegate cb_terminate;
#pragma warning disable 0169
		static Delegate GetTerminateHandler ()
		{
			if (cb_terminate == null)
				cb_terminate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Terminate);
			return cb_terminate;
		}

		static void n_Terminate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Terminate ();
		}
#pragma warning restore 0169

		static IntPtr id_terminate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitReader']/method[@name='terminate' and count(parameter)=0]"
		[Register ("terminate", "()V", "GetTerminateHandler")]
		public virtual unsafe void Terminate ()
		{
			if (id_terminate == IntPtr.Zero)
				id_terminate = JNIEnv.GetMethodID (class_ref, "terminate", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_terminate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "terminate", "()V"));
			} finally {
			}
		}

	}
}
