using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JPEGBitStream']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mjpeg/JPEGBitStream", DoNotGenerateAcw=true)]
	public partial class JPEGBitStream : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mjpeg/JPEGBitStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JPEGBitStream); }
		}

		protected JPEGBitStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_io_VLC_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JPEGBitStream']/constructor[@name='JPEGBitStream' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='org.jcodec.common.io.VLC[]'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;[Lorg/jcodec/common/io/VLC;I)V", "")]
		public unsafe JPEGBitStream (global::Java.Nio.ByteBuffer b, global::Org.Jcodec.Common.IO.VLC[] huff, int lumaLen)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_huff = JNIEnv.NewArray (huff);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (b);
				__args [1] = new JValue (native_huff);
				__args [2] = new JValue (lumaLen);
				if (((object) this).GetType () != typeof (JPEGBitStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;[Lorg/jcodec/common/io/VLC;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;[Lorg/jcodec/common/io/VLC;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_io_VLC_I == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_io_VLC_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;[Lorg/jcodec/common/io/VLC;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_io_VLC_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_io_VLC_I, __args);
			} finally {
				if (huff != null) {
					JNIEnv.CopyArray (native_huff, huff);
					JNIEnv.DeleteLocalRef (native_huff);
				}
			}
		}

		static Delegate cb_readACValues_arrayILorg_jcodec_common_io_VLC_;
#pragma warning disable 0169
		static Delegate GetReadACValues_arrayILorg_jcodec_common_io_VLC_Handler ()
		{
			if (cb_readACValues_arrayILorg_jcodec_common_io_VLC_ == null)
				cb_readACValues_arrayILorg_jcodec_common_io_VLC_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadACValues_arrayILorg_jcodec_common_io_VLC_);
			return cb_readACValues_arrayILorg_jcodec_common_io_VLC_;
		}

		static void n_ReadACValues_arrayILorg_jcodec_common_io_VLC_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target, IntPtr native_table)
		{
			global::Org.Jcodec.Codecs.Mjpeg.JPEGBitStream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mjpeg.JPEGBitStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] target = (int[]) JNIEnv.GetArray (native_target, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Jcodec.Common.IO.VLC table = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (native_table, JniHandleOwnership.DoNotTransfer);
			__this.ReadACValues (target, table);
			if (target != null)
				JNIEnv.CopyArray (target, native_target);
		}
#pragma warning restore 0169

		static IntPtr id_readACValues_arrayILorg_jcodec_common_io_VLC_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JPEGBitStream']/method[@name='readACValues' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='org.jcodec.common.io.VLC']]"
		[Register ("readACValues", "([ILorg/jcodec/common/io/VLC;)V", "GetReadACValues_arrayILorg_jcodec_common_io_VLC_Handler")]
		public virtual unsafe void ReadACValues (int[] target, global::Org.Jcodec.Common.IO.VLC table)
		{
			if (id_readACValues_arrayILorg_jcodec_common_io_VLC_ == IntPtr.Zero)
				id_readACValues_arrayILorg_jcodec_common_io_VLC_ = JNIEnv.GetMethodID (class_ref, "readACValues", "([ILorg/jcodec/common/io/VLC;)V");
			IntPtr native_target = JNIEnv.NewArray (target);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_target);
				__args [1] = new JValue (table);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readACValues_arrayILorg_jcodec_common_io_VLC_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readACValues", "([ILorg/jcodec/common/io/VLC;)V"), __args);
			} finally {
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
			}
		}

		static Delegate cb_readDCValue_ILorg_jcodec_common_io_VLC_;
#pragma warning disable 0169
		static Delegate GetReadDCValue_ILorg_jcodec_common_io_VLC_Handler ()
		{
			if (cb_readDCValue_ILorg_jcodec_common_io_VLC_ == null)
				cb_readDCValue_ILorg_jcodec_common_io_VLC_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_ReadDCValue_ILorg_jcodec_common_io_VLC_);
			return cb_readDCValue_ILorg_jcodec_common_io_VLC_;
		}

		static int n_ReadDCValue_ILorg_jcodec_common_io_VLC_ (IntPtr jnienv, IntPtr native__this, int prevDC, IntPtr native_table)
		{
			global::Org.Jcodec.Codecs.Mjpeg.JPEGBitStream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mjpeg.JPEGBitStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.VLC table = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (native_table, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadDCValue (prevDC, table);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readDCValue_ILorg_jcodec_common_io_VLC_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JPEGBitStream']/method[@name='readDCValue' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.jcodec.common.io.VLC']]"
		[Register ("readDCValue", "(ILorg/jcodec/common/io/VLC;)I", "GetReadDCValue_ILorg_jcodec_common_io_VLC_Handler")]
		public virtual unsafe int ReadDCValue (int prevDC, global::Org.Jcodec.Common.IO.VLC table)
		{
			if (id_readDCValue_ILorg_jcodec_common_io_VLC_ == IntPtr.Zero)
				id_readDCValue_ILorg_jcodec_common_io_VLC_ = JNIEnv.GetMethodID (class_ref, "readDCValue", "(ILorg/jcodec/common/io/VLC;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (prevDC);
				__args [1] = new JValue (table);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readDCValue_ILorg_jcodec_common_io_VLC_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readDCValue", "(ILorg/jcodec/common/io/VLC;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_readMCU_arrayarrayI;
#pragma warning disable 0169
		static Delegate GetReadMCU_arrayarrayIHandler ()
		{
			if (cb_readMCU_arrayarrayI == null)
				cb_readMCU_arrayarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReadMCU_arrayarrayI);
			return cb_readMCU_arrayarrayI;
		}

		static void n_ReadMCU_arrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_buf)
		{
			global::Org.Jcodec.Codecs.Mjpeg.JPEGBitStream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mjpeg.JPEGBitStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[][] buf = (int[][]) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			__this.ReadMCU (buf);
			if (buf != null)
				JNIEnv.CopyArray (buf, native_buf);
		}
#pragma warning restore 0169

		static IntPtr id_readMCU_arrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JPEGBitStream']/method[@name='readMCU' and count(parameter)=1 and parameter[1][@type='int[][]']]"
		[Register ("readMCU", "([[I)V", "GetReadMCU_arrayarrayIHandler")]
		public virtual unsafe void ReadMCU (int[][] buf)
		{
			if (id_readMCU_arrayarrayI == IntPtr.Zero)
				id_readMCU_arrayarrayI = JNIEnv.GetMethodID (class_ref, "readMCU", "([[I)V");
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_buf);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readMCU_arrayarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readMCU", "([[I)V"), __args);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
			}
		}

		static IntPtr id_toValue_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JPEGBitStream']/method[@name='toValue' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("toValue", "(II)I", "")]
		public unsafe int ToValue (int raw, int length)
		{
			if (id_toValue_II == IntPtr.Zero)
				id_toValue_II = JNIEnv.GetMethodID (class_ref, "toValue", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (raw);
				__args [1] = new JValue (length);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_toValue_II, __args);
			} finally {
			}
		}

	}
}
