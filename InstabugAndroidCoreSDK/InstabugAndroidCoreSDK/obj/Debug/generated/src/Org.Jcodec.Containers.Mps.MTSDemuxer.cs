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
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
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
			public unsafe MTSPacket (int guid, bool payloadStart, global::Java.Nio.ByteBuffer payload)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (guid);
					__args [1] = new JValue (payloadStart);
					__args [2] = new JValue (payload);
					if (((object) this).GetType () != typeof (MTSPacket)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IZLjava/nio/ByteBuffer;)V", __args),
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
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
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> GetPrograms (global::Java.IO.File file)
		{
			if (id_getPrograms_Ljava_io_File_ == IntPtr.Zero)
				id_getPrograms_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getPrograms", "(Ljava/io/File;)Ljava/util/Set;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (file);
				global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> __ret = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPrograms_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parsePacket_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer']/method[@name='parsePacket' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parsePacket", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/MTSDemuxer$MTSPacket;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket ParsePacket (global::Java.Nio.ByteBuffer buffer)
		{
			if (id_parsePacket_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parsePacket_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parsePacket", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/MTSDemuxer$MTSPacket;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (buffer);
				global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parsePacket_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_probe_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer']/method[@name='probe' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("probe", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int Probe (global::Java.Nio.ByteBuffer b)
		{
			if (id_probe_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_probe_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "probe", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (b);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_probe_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readPacket_Ljava_nio_channels_ReadableByteChannel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer']/method[@name='readPacket' and count(parameter)=1 and parameter[1][@type='java.nio.channels.ReadableByteChannel']]"
		[Register ("readPacket", "(Ljava/nio/channels/ReadableByteChannel;)Lorg/jcodec/containers/mps/MTSDemuxer$MTSPacket;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.MTSDemuxer.MTSPacket ReadPacket (global::Java.Nio.Channels.IReadableByteChannel channel)
		{
			if (id_readPacket_Ljava_nio_channels_ReadableByteChannel_ == IntPtr.Zero)
				id_readPacket_Ljava_nio_channels_ReadableByteChannel_ = JNIEnv.GetStaticMethodID (class_ref, "readPacket", "(Ljava/nio/channels/ReadableByteChannel;)Lorg/jcodec/containers/mps/MTSDemuxer$MTSPacket;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (channel);
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

		static void n_SeekByte_J (IntPtr jnienv, IntPtr native__this, long offset)
		{
			global::Org.Jcodec.Containers.Mps.MTSDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekByte (offset);
		}
#pragma warning restore 0169

		static IntPtr id_seekByte_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSDemuxer']/method[@name='seekByte' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekByte", "(J)V", "GetSeekByte_JHandler")]
		public virtual unsafe void SeekByte (long offset)
		{
			if (id_seekByte_J == IntPtr.Zero)
				id_seekByte_J = JNIEnv.GetMethodID (class_ref, "seekByte", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (offset);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekByte_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekByte", "(J)V"), __args);
			} finally {
			}
		}

	}
}
