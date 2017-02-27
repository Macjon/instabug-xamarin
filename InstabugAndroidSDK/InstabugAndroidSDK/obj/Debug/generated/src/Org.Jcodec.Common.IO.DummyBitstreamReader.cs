using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']"
	[global::Android.Runtime.Register ("org/jcodec/common/io/DummyBitstreamReader", DoNotGenerateAcw=true)]
	public partial class DummyBitstreamReader : global::Java.Lang.Object {


		static IntPtr bitsRead_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/field[@name='bitsRead']"
		[Register ("bitsRead")]
		protected static int BitsRead {
			get {
				if (bitsRead_jfieldId == IntPtr.Zero)
					bitsRead_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bitsRead", "I");
				return JNIEnv.GetStaticIntField (class_ref, bitsRead_jfieldId);
			}
			set {
				if (bitsRead_jfieldId == IntPtr.Zero)
					bitsRead_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bitsRead", "I");
				try {
					JNIEnv.SetStaticField (class_ref, bitsRead_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/io/DummyBitstreamReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DummyBitstreamReader); }
		}

		protected DummyBitstreamReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/constructor[@name='DummyBitstreamReader' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe DummyBitstreamReader (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (DummyBitstreamReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getBitPosition;
#pragma warning disable 0169
		static Delegate GetGetBitPositionHandler ()
		{
			if (cb_getBitPosition == null)
				cb_getBitPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBitPosition);
			return cb_getBitPosition;
		}

		static long n_GetBitPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BitPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getBitPosition;
		public virtual unsafe long BitPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='getBitPosition' and count(parameter)=0]"
			[Register ("getBitPosition", "()J", "GetGetBitPositionHandler")]
			get {
				if (id_getBitPosition == IntPtr.Zero)
					id_getBitPosition = JNIEnv.GetMethodID (class_ref, "getBitPosition", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBitPosition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitPosition", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurBit;
#pragma warning disable 0169
		static Delegate GetGetCurBitHandler ()
		{
			if (cb_getCurBit == null)
				cb_getCurBit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurBit);
			return cb_getCurBit;
		}

		static int n_GetCurBit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurBit;
		}
#pragma warning restore 0169

		static IntPtr id_getCurBit;
		public virtual unsafe int CurBit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='getCurBit' and count(parameter)=0]"
			[Register ("getCurBit", "()I", "GetGetCurBitHandler")]
			get {
				if (id_getCurBit == IntPtr.Zero)
					id_getCurBit = JNIEnv.GetMethodID (class_ref, "getCurBit", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurBit);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurBit", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isByteAligned;
#pragma warning disable 0169
		static Delegate GetIsByteAlignedHandler ()
		{
			if (cb_isByteAligned == null)
				cb_isByteAligned = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsByteAligned);
			return cb_isByteAligned;
		}

		static bool n_IsByteAligned (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsByteAligned;
		}
#pragma warning restore 0169

		static IntPtr id_isByteAligned;
		public virtual unsafe bool IsByteAligned {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='isByteAligned' and count(parameter)=0]"
			[Register ("isByteAligned", "()Z", "GetIsByteAlignedHandler")]
			get {
				if (id_isByteAligned == IntPtr.Zero)
					id_isByteAligned = JNIEnv.GetMethodID (class_ref, "isByteAligned", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isByteAligned);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isByteAligned", "()Z"));
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
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Align ();
		}
#pragma warning restore 0169

		static IntPtr id_align;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='align' and count(parameter)=0]"
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
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckNBit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_checkNBit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='checkNBit' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_curBit;
#pragma warning disable 0169
		static Delegate GetInvokeCurBitHandler ()
		{
			if (cb_curBit == null)
				cb_curBit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_InvokeCurBit);
			return cb_curBit;
		}

		static int n_InvokeCurBit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvokeCurBit ();
		}
#pragma warning restore 0169

		static IntPtr id_curBit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='curBit' and count(parameter)=0]"
		[Register ("curBit", "()I", "GetInvokeCurBitHandler")]
		public virtual unsafe int InvokeCurBit ()
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
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastByte ();
		}
#pragma warning restore 0169

		static IntPtr id_lastByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='lastByte' and count(parameter)=0]"
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
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MoreData ();
		}
#pragma warning restore 0169

		static IntPtr id_moreData;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='moreData' and count(parameter)=0]"
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

		static Delegate cb_moreData_I;
#pragma warning disable 0169
		static Delegate GetMoreData_IHandler ()
		{
			if (cb_moreData_I == null)
				cb_moreData_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_MoreData_I);
			return cb_moreData_I;
		}

		static bool n_MoreData_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MoreData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_moreData_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='moreData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("moreData", "(I)Z", "GetMoreData_IHandler")]
		public virtual unsafe bool MoreData (int p0)
		{
			if (id_moreData_I == IntPtr.Zero)
				id_moreData_I = JNIEnv.GetMethodID (class_ref, "moreData", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_moreData_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moreData", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_moreRBSPData;
#pragma warning disable 0169
		static Delegate GetMoreRBSPDataHandler ()
		{
			if (cb_moreRBSPData == null)
				cb_moreRBSPData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_MoreRBSPData);
			return cb_moreRBSPData;
		}

		static bool n_MoreRBSPData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MoreRBSPData ();
		}
#pragma warning restore 0169

		static IntPtr id_moreRBSPData;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='moreRBSPData' and count(parameter)=0]"
		[Register ("moreRBSPData", "()Z", "GetMoreRBSPDataHandler")]
		public virtual unsafe bool MoreRBSPData ()
		{
			if (id_moreRBSPData == IntPtr.Zero)
				id_moreRBSPData = JNIEnv.GetMethodID (class_ref, "moreRBSPData", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_moreRBSPData);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moreRBSPData", "()Z"));
			} finally {
			}
		}

		static Delegate cb_peakNextBits_I;
#pragma warning disable 0169
		static Delegate GetPeakNextBits_IHandler ()
		{
			if (cb_peakNextBits_I == null)
				cb_peakNextBits_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_PeakNextBits_I);
			return cb_peakNextBits_I;
		}

		static int n_PeakNextBits_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeakNextBits (p0);
		}
#pragma warning restore 0169

		static IntPtr id_peakNextBits_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='peakNextBits' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("peakNextBits", "(I)I", "GetPeakNextBits_IHandler")]
		public virtual unsafe int PeakNextBits (int p0)
		{
			if (id_peakNextBits_I == IntPtr.Zero)
				id_peakNextBits_I = JNIEnv.GetMethodID (class_ref, "peakNextBits", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_peakNextBits_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peakNextBits", "(I)I"), __args);
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
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read1Bit ();
		}
#pragma warning restore 0169

		static IntPtr id_read1Bit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='read1Bit' and count(parameter)=0]"
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

		static Delegate cb_read1BitInt;
#pragma warning disable 0169
		static Delegate GetRead1BitIntHandler ()
		{
			if (cb_read1BitInt == null)
				cb_read1BitInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read1BitInt);
			return cb_read1BitInt;
		}

		static int n_Read1BitInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read1BitInt ();
		}
#pragma warning restore 0169

		static IntPtr id_read1BitInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='read1BitInt' and count(parameter)=0]"
		[Register ("read1BitInt", "()I", "GetRead1BitIntHandler")]
		public virtual unsafe int Read1BitInt ()
		{
			if (id_read1BitInt == IntPtr.Zero)
				id_read1BitInt = JNIEnv.GetMethodID (class_ref, "read1BitInt", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read1BitInt);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read1BitInt", "()I"));
			} finally {
			}
		}

		static Delegate cb_readByte;
#pragma warning disable 0169
		static Delegate GetReadByteHandler ()
		{
			if (cb_readByte == null)
				cb_readByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ReadByte);
			return cb_readByte;
		}

		static int n_ReadByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadByte ();
		}
#pragma warning restore 0169

		static IntPtr id_readByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='readByte' and count(parameter)=0]"
		[Register ("readByte", "()I", "GetReadByteHandler")]
		public virtual unsafe int ReadByte ()
		{
			if (id_readByte == IntPtr.Zero)
				id_readByte = JNIEnv.GetMethodID (class_ref, "readByte", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readByte);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readByte", "()I"));
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
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadNBit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readNBit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='readNBit' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_readRemainingByte;
#pragma warning disable 0169
		static Delegate GetReadRemainingByteHandler ()
		{
			if (cb_readRemainingByte == null)
				cb_readRemainingByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ReadRemainingByte);
			return cb_readRemainingByte;
		}

		static long n_ReadRemainingByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.DummyBitstreamReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.DummyBitstreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadRemainingByte ();
		}
#pragma warning restore 0169

		static IntPtr id_readRemainingByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='readRemainingByte' and count(parameter)=0]"
		[Register ("readRemainingByte", "()J", "GetReadRemainingByteHandler")]
		public virtual unsafe long ReadRemainingByte ()
		{
			if (id_readRemainingByte == IntPtr.Zero)
				id_readRemainingByte = JNIEnv.GetMethodID (class_ref, "readRemainingByte", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readRemainingByte);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readRemainingByte", "()J"));
			} finally {
			}
		}

		static IntPtr id_skip_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='DummyBitstreamReader']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)I", "")]
		public unsafe int Skip (int p0)
		{
			if (id_skip_I == IntPtr.Zero)
				id_skip_I = JNIEnv.GetMethodID (class_ref, "skip", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_skip_I, __args);
			} finally {
			}
		}

	}
}
