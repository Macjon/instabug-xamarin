using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mps {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDump']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSDump", DoNotGenerateAcw=true)]
	public partial class MPSDump : global::Java.Lang.Object {


		static IntPtr ch_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDump']/field[@name='ch']"
		[Register ("ch")]
		protected global::Java.Nio.Channels.IReadableByteChannel Ch {
			get {
				if (ch_jfieldId == IntPtr.Zero)
					ch_jfieldId = JNIEnv.GetFieldID (class_ref, "ch", "Ljava/nio/channels/ReadableByteChannel;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ch_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.IReadableByteChannel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ch_jfieldId == IntPtr.Zero)
					ch_jfieldId = JNIEnv.GetFieldID (class_ref, "ch", "Ljava/nio/channels/ReadableByteChannel;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ch_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSDump", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPSDump); }
		}

		protected MPSDump (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_channels_ReadableByteChannel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDump']/constructor[@name='MPSDump' and count(parameter)=1 and parameter[1][@type='java.nio.channels.ReadableByteChannel']]"
		[Register (".ctor", "(Ljava/nio/channels/ReadableByteChannel;)V", "")]
		public unsafe MPSDump (global::Java.Nio.Channels.IReadableByteChannel ch)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				if (((object) this).GetType () != typeof (MPSDump)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/channels/ReadableByteChannel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/channels/ReadableByteChannel;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_channels_ReadableByteChannel_ == IntPtr.Zero)
					id_ctor_Ljava_nio_channels_ReadableByteChannel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/channels/ReadableByteChannel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_, __args);
			} finally {
			}
		}

		static Delegate cb_dump_Ljava_lang_Long_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetDump_Ljava_lang_Long_Ljava_lang_Long_Handler ()
		{
			if (cb_dump_Ljava_lang_Long_Ljava_lang_Long_ == null)
				cb_dump_Ljava_lang_Long_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dump_Ljava_lang_Long_Ljava_lang_Long_);
			return cb_dump_Ljava_lang_Long_Ljava_lang_Long_;
		}

		static void n_Dump_Ljava_lang_Long_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dumpAfterPts, IntPtr native_stopPts)
		{
			global::Org.Jcodec.Containers.Mps.MPSDump __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDump> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long dumpAfterPts = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_dumpAfterPts, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long stopPts = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_stopPts, JniHandleOwnership.DoNotTransfer);
			__this.Dump (dumpAfterPts, stopPts);
		}
#pragma warning restore 0169

		static IntPtr id_dump_Ljava_lang_Long_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDump']/method[@name='dump' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long']]"
		[Register ("dump", "(Ljava/lang/Long;Ljava/lang/Long;)V", "GetDump_Ljava_lang_Long_Ljava_lang_Long_Handler")]
		public virtual unsafe void Dump (global::Java.Lang.Long dumpAfterPts, global::Java.Lang.Long stopPts)
		{
			if (id_dump_Ljava_lang_Long_Ljava_lang_Long_ == IntPtr.Zero)
				id_dump_Ljava_lang_Long_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "dump", "(Ljava/lang/Long;Ljava/lang/Long;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dumpAfterPts);
				__args [1] = new JValue (stopPts);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dump_Ljava_lang_Long_Ljava_lang_Long_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dump", "(Ljava/lang/Long;Ljava/lang/Long;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_fillBuffer_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetFillBuffer_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_fillBuffer_Ljava_nio_ByteBuffer_ == null)
				cb_fillBuffer_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_FillBuffer_Ljava_nio_ByteBuffer_);
			return cb_fillBuffer_Ljava_nio_ByteBuffer_;
		}

		static int n_FillBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			global::Org.Jcodec.Containers.Mps.MPSDump __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDump> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FillBuffer (buffer);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fillBuffer_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDump']/method[@name='fillBuffer' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("fillBuffer", "(Ljava/nio/ByteBuffer;)I", "GetFillBuffer_Ljava_nio_ByteBuffer_Handler")]
		protected virtual unsafe int FillBuffer (global::Java.Nio.ByteBuffer buffer)
		{
			if (id_fillBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_fillBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "fillBuffer", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (buffer);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_fillBuffer_Ljava_nio_ByteBuffer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fillBuffer", "(Ljava/nio/ByteBuffer;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_logPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetLogPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_Handler ()
		{
			if (cb_logPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_ == null)
				cb_logPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_LogPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_);
			return cb_logPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_;
		}

		static void n_LogPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pkt, int hdrSize, IntPtr native_payload)
		{
			global::Org.Jcodec.Containers.Mps.MPSDump __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDump> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket pkt = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket> (native_pkt, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer payload = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_payload, JniHandleOwnership.DoNotTransfer);
			__this.LogPes (pkt, hdrSize, payload);
		}
#pragma warning restore 0169

		static IntPtr id_logPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDump']/method[@name='logPes' and count(parameter)=3 and parameter[1][@type='org.jcodec.containers.mps.MPSDemuxer.PESPacket'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer']]"
		[Register ("logPes", "(Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;ILjava/nio/ByteBuffer;)V", "GetLogPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_Handler")]
		protected virtual unsafe void LogPes (global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket pkt, int hdrSize, global::Java.Nio.ByteBuffer payload)
		{
			if (id_logPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_logPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "logPes", "(Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;ILjava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (pkt);
				__args [1] = new JValue (hdrSize);
				__args [2] = new JValue (payload);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logPes_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ILjava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logPes", "(Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;ILjava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDump']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] args)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_args);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
			}
		}

	}
}
