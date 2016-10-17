using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitWriter']"
	[global::Android.Runtime.Register ("org/jcodec/common/io/BitWriter", DoNotGenerateAcw=true)]
	public partial class BitWriter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/io/BitWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitWriter); }
		}

		protected BitWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitWriter']/constructor[@name='BitWriter' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;)V", "")]
		public unsafe BitWriter (global::Java.Nio.ByteBuffer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BitWriter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/ByteBuffer;)V", __args),
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

		static Delegate cb_getBuffer;
#pragma warning disable 0169
		static Delegate GetGetBufferHandler ()
		{
			if (cb_getBuffer == null)
				cb_getBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuffer);
			return cb_getBuffer;
		}

		static IntPtr n_GetBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitWriter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Buffer);
		}
#pragma warning restore 0169

		static IntPtr id_getBuffer;
		public virtual unsafe global::Java.Nio.ByteBuffer Buffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitWriter']/method[@name='getBuffer' and count(parameter)=0]"
			[Register ("getBuffer", "()Ljava/nio/ByteBuffer;", "GetGetBufferHandler")]
			get {
				if (id_getBuffer == IntPtr.Zero)
					id_getBuffer = JNIEnv.GetMethodID (class_ref, "getBuffer", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBuffer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBuffer", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Org.Jcodec.Common.IO.BitWriter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurBit ();
		}
#pragma warning restore 0169

		static IntPtr id_curBit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitWriter']/method[@name='curBit' and count(parameter)=0]"
		[Register ("curBit", "()I", "GetCurBitHandler")]
		public virtual unsafe int CurBit ()
		{
			if (id_curBit == IntPtr.Zero)
				id_curBit = JNIEnv.GetMethodID (class_ref, "curBit", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_curBit);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "curBit", "()I"));
			} finally {
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.BitWriter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitWriter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flush", "()V"));
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
			global::Org.Jcodec.Common.IO.BitWriter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fork ());
		}
#pragma warning restore 0169

		static IntPtr id_fork;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitWriter']/method[@name='fork' and count(parameter)=0]"
		[Register ("fork", "()Lorg/jcodec/common/io/BitWriter;", "GetForkHandler")]
		public virtual unsafe global::Org.Jcodec.Common.IO.BitWriter Fork ()
		{
			if (id_fork == IntPtr.Zero)
				id_fork = JNIEnv.GetMethodID (class_ref, "fork", "()Lorg/jcodec/common/io/BitWriter;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fork), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fork", "()Lorg/jcodec/common/io/BitWriter;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Common.IO.BitWriter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position ();
		}
#pragma warning restore 0169

		static IntPtr id_position;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitWriter']/method[@name='position' and count(parameter)=0]"
		[Register ("position", "()I", "GetPositionHandler")]
		public virtual unsafe int Position ()
		{
			if (id_position == IntPtr.Zero)
				id_position = JNIEnv.GetMethodID (class_ref, "position", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_position);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "position", "()I"));
			} finally {
			}
		}

		static Delegate cb_write1Bit_I;
#pragma warning disable 0169
		static Delegate GetWrite1Bit_IHandler ()
		{
			if (cb_write1Bit_I == null)
				cb_write1Bit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Write1Bit_I);
			return cb_write1Bit_I;
		}

		static void n_Write1Bit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.IO.BitWriter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write1Bit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write1Bit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitWriter']/method[@name='write1Bit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("write1Bit", "(I)V", "GetWrite1Bit_IHandler")]
		public virtual unsafe void Write1Bit (int p0)
		{
			if (id_write1Bit_I == IntPtr.Zero)
				id_write1Bit_I = JNIEnv.GetMethodID (class_ref, "write1Bit", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write1Bit_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write1Bit", "(I)V"), __args);
			} finally {
			}
		}

		static IntPtr id_writeNBit_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='BitWriter']/method[@name='writeNBit' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeNBit", "(II)V", "")]
		public unsafe void WriteNBit (int p0, int p1)
		{
			if (id_writeNBit_II == IntPtr.Zero)
				id_writeNBit_II = JNIEnv.GetMethodID (class_ref, "writeNBit", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeNBit_II, __args);
			} finally {
			}
		}

	}
}
