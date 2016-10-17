using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mps {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mps/MTSDemuxer", DoNotGenerateAcw=true)]
	public partial class MTSDemuxer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.MTSPacket']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MTSDemuxer$MTSPacket", DoNotGenerateAcw=true)]
		public partial class MTSPacket : global::Java.Lang.Object {


			static IntPtr payload_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.MTSPacket']/field[@name='payload']"
			[Register ("payload")]
			public global::Java.Nio.ByteBuffer Payload {
				get {
					if (payload_jfieldId == IntPtr.Zero)
						payload_jfieldId = JNIEnv.GetFieldID (class_ref, "payload", "Ljava/nio/ByteBuffer;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, payload_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (payload_jfieldId == IntPtr.Zero)
						payload_jfieldId = JNIEnv.GetFieldID (class_ref, "payload", "Ljava/nio/ByteBuffer;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, payload_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr payloadStart_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.MTSPacket']/field[@name='payloadStart']"
			[Register ("payloadStart")]
			public bool PayloadStart {
				get {
					if (payloadStart_jfieldId == IntPtr.Zero)
						payloadStart_jfieldId = JNIEnv.GetFieldID (class_ref, "payloadStart", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, payloadStart_jfieldId);
				}
				set {
					if (payloadStart_jfieldId == IntPtr.Zero)
						payloadStart_jfieldId = JNIEnv.GetFieldID (class_ref, "payloadStart", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, payloadStart_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr pid_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.MTSPacket']/field[@name='pid']"
			[Register ("pid")]
			public int Pid {
				get {
					if (pid_jfieldId == IntPtr.Zero)
						pid_jfieldId = JNIEnv.GetFieldID (class_ref, "pid", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, pid_jfieldId);
				}
				set {
					if (pid_jfieldId == IntPtr.Zero)
						pid_jfieldId = JNIEnv.GetFieldID (class_ref, "pid", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pid_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MTSDemuxer$MTSPacket", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MTSPacket); }
			}

			protected MTSPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IZLjava_nio_ByteBuffer_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.MTSPacket']/constructor[@name='MTSDemuxer.MTSPacket' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='java.nio.ByteBuffer']]"
			[Register (".ctor", "(IZLjava/nio/ByteBuffer;)V", "")]
			public unsafe MTSPacket (int p0, bool p1, global::Java.Nio.ByteBuffer p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (MTSPacket)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IZLjava/nio/ByteBuffer;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IZLjava/nio/ByteBuffer;)V", __args);
						return;
					}

					if (id_ctor_IZLjava_nio_ByteBuffer_ == IntPtr.Zero)
						id_ctor_IZLjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IZLjava/nio/ByteBuffer;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IZLjava_nio_ByteBuffer_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IZLjava_nio_ByteBuffer_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.TSChannel']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MTSDemuxer$TSChannel", DoNotGenerateAcw=true)]
		public partial class TSChannel : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MTSDemuxer$TSChannel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TSChannel); }
			}

			protected TSChannel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_isOpen;
#pragma warning disable 0169
			static Delegate GetIsOpenHandler ()
			{
				if (cb_isOpen == null)
					cb_isOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpen);
				return cb_isOpen;
			}

			static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsOpen;
			}
#pragma warning restore 0169

			static IntPtr id_isOpen;
			public virtual unsafe bool IsOpen {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.TSChannel']/method[@name='isOpen' and count(parameter)=0]"
				[Register ("isOpen", "()Z", "GetIsOpenHandler")]
				get {
					if (id_isOpen == IntPtr.Zero)
						id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOpen", "()Z"));
					} finally {
					}
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
				global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.TSChannel']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "GetCloseHandler")]
			public virtual unsafe void Close ()
			{
				if (id_close == IntPtr.Zero)
					id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
				} finally {
				}
			}

			static Delegate cb_getPacket_Ljava_nio_channels_ReadableByteChannel_;
#pragma warning disable 0169
			static Delegate GetGetPacket_Ljava_nio_channels_ReadableByteChannel_Handler ()
			{
				if (cb_getPacket_Ljava_nio_channels_ReadableByteChannel_ == null)
					cb_getPacket_Ljava_nio_channels_ReadableByteChannel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPacket_Ljava_nio_channels_ReadableByteChannel_);
				return cb_getPacket_Ljava_nio_channels_ReadableByteChannel_;
			}

			static IntPtr n_GetPacket_Ljava_nio_channels_ReadableByteChannel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.Channels.IReadableByteChannel p0 = (global::Java.Nio.Channels.IReadableByteChannel)global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.IReadableByteChannel> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPacket (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getPacket_Ljava_nio_channels_ReadableByteChannel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.TSChannel']/method[@name='getPacket' and count(parameter)=1 and parameter[1][@type='java.nio.channels.ReadableByteChannel']]"
			[Register ("getPacket", "(Ljava/nio/channels/ReadableByteChannel;)Lorg/jcodec/containers/mps/MTSDemuxer$MTSPacket;", "GetGetPacket_Ljava_nio_channels_ReadableByteChannel_Handler")]
			protected virtual unsafe global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket GetPacket (global::Java.Nio.Channels.IReadableByteChannel p0)
			{
				if (id_getPacket_Ljava_nio_channels_ReadableByteChannel_ == IntPtr.Zero)
					id_getPacket_Ljava_nio_channels_ReadableByteChannel_ = JNIEnv.GetMethodID (class_ref, "getPacket", "(Ljava/nio/channels/ReadableByteChannel;)Lorg/jcodec/containers/mps/MTSDemuxer$MTSPacket;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPacket_Ljava_nio_channels_ReadableByteChannel_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPacket", "(Ljava/nio/channels/ReadableByteChannel;)Lorg/jcodec/containers/mps/MTSDemuxer$MTSPacket;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_position;
#pragma warning disable 0169
			static Delegate GetPositionHandler ()
			{
				if (cb_position == null)
					cb_position = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Position);
				return cb_position;
			}

			static long n_Position (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Position ();
			}
#pragma warning restore 0169

			static IntPtr id_position;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.TSChannel']/method[@name='position' and count(parameter)=0]"
			[Register ("position", "()J", "GetPositionHandler")]
			public virtual unsafe long Position ()
			{
				if (id_position == IntPtr.Zero)
					id_position = JNIEnv.GetMethodID (class_ref, "position", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_position);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "position", "()J"));
				} finally {
				}
			}

			static Delegate cb_read_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetRead_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_read_Ljava_nio_ByteBuffer_ == null)
					cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_Ljava_nio_ByteBuffer_);
				return cb_read_Ljava_nio_ByteBuffer_;
			}

			static int n_Read_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Read (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_read_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.TSChannel']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("read", "(Ljava/nio/ByteBuffer;)I", "GetRead_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe int Read (global::Java.Nio.ByteBuffer p0)
			{
				if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_ByteBuffer_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/nio/ByteBuffer;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_size;
#pragma warning disable 0169
			static Delegate GetSizeHandler ()
			{
				if (cb_size == null)
					cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Size);
				return cb_size;
			}

			static long n_Size (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Size ();
			}
#pragma warning restore 0169

			static IntPtr id_size;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.TSChannel']/method[@name='size' and count(parameter)=0]"
			[Register ("size", "()J", "GetSizeHandler")]
			public virtual unsafe long Size ()
			{
				if (id_size == IntPtr.Zero)
					id_size = JNIEnv.GetMethodID (class_ref, "size", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_size);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()J"));
				} finally {
				}
			}

			static Delegate cb_write_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_write_Ljava_nio_ByteBuffer_ == null)
					cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_nio_ByteBuffer_);
				return cb_write_Ljava_nio_ByteBuffer_;
			}

			static int n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.TSChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Write (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_write_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer.TSChannel']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("write", "(Ljava/nio/ByteBuffer;)I", "GetWrite_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe int Write (global::Java.Nio.ByteBuffer p0)
			{
				if (id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_ByteBuffer_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/nio/ByteBuffer;)I"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mps/MTSDemuxer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MTSDemuxer); }
		}

		protected MTSDemuxer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getPrograms_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer']/method[@name='getPrograms' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getPrograms", "(Ljava/io/File;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> GetPrograms (global::Java.IO.File p0)
		{
			if (id_getPrograms_Ljava_io_File_ == IntPtr.Zero)
				id_getPrograms_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getPrograms", "(Ljava/io/File;)Ljava/util/Set;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> __ret = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPrograms_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parsePacket_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer']/method[@name='parsePacket' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parsePacket", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/MTSDemuxer$MTSPacket;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket ParsePacket (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parsePacket_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parsePacket_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parsePacket", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/MTSDemuxer$MTSPacket;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parsePacket_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_probe_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer']/method[@name='probe' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("probe", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int Probe (global::Java.Nio.ByteBuffer p0)
		{
			if (id_probe_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_probe_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "probe", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_probe_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readPacket_Ljava_nio_channels_ReadableByteChannel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer']/method[@name='readPacket' and count(parameter)=1 and parameter[1][@type='java.nio.channels.ReadableByteChannel']]"
		[Register ("readPacket", "(Ljava/nio/channels/ReadableByteChannel;)Lorg/jcodec/containers/mps/MTSDemuxer$MTSPacket;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket ReadPacket (global::Java.Nio.Channels.IReadableByteChannel p0)
		{
			if (id_readPacket_Ljava_nio_channels_ReadableByteChannel_ == IntPtr.Zero)
				id_readPacket_Ljava_nio_channels_ReadableByteChannel_ = JNIEnv.GetStaticMethodID (class_ref, "readPacket", "(Ljava/nio/channels/ReadableByteChannel;)Lorg/jcodec/containers/mps/MTSDemuxer$MTSPacket;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readPacket_Ljava_nio_channels_ReadableByteChannel_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_seekByte_J;
#pragma warning disable 0169
		static Delegate GetSeekByte_JHandler ()
		{
			if (cb_seekByte_J == null)
				cb_seekByte_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SeekByte_J);
			return cb_seekByte_J;
		}

		static void n_SeekByte_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Jcodec.Containers.Mps.MTSDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekByte (p0);
		}
#pragma warning restore 0169

		static IntPtr id_seekByte_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer']/method[@name='seekByte' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekByte", "(J)V", "GetSeekByte_JHandler")]
		public virtual unsafe void SeekByte (long p0)
		{
			if (id_seekByte_J == IntPtr.Zero)
				id_seekByte_J = JNIEnv.GetMethodID (class_ref, "seekByte", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekByte_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekByte", "(J)V"), __args);
			} finally {
			}
		}

	}
}
