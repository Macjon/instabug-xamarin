using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Wav {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/wav/WavInput", DoNotGenerateAcw=true)]
	public partial class WavInput : global::Java.Lang.Object, global::Java.IO.ICloseable {


		static IntPtr in_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput']/field[@name='in']"
		[Register ("in")]
		protected global::Java.Nio.Channels.IReadableByteChannel In {
			get {
				if (in_jfieldId == IntPtr.Zero)
					in_jfieldId = JNIEnv.GetFieldID (class_ref, "in", "Ljava/nio/channels/ReadableByteChannel;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, in_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.IReadableByteChannel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (in_jfieldId == IntPtr.Zero)
					in_jfieldId = JNIEnv.GetFieldID (class_ref, "in", "Ljava/nio/channels/ReadableByteChannel;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, in_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr prevBuf_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput']/field[@name='prevBuf']"
		[Register ("prevBuf")]
		protected IList<byte> PrevBuf {
			get {
				if (prevBuf_jfieldId == IntPtr.Zero)
					prevBuf_jfieldId = JNIEnv.GetFieldID (class_ref, "prevBuf", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, prevBuf_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (prevBuf_jfieldId == IntPtr.Zero)
					prevBuf_jfieldId = JNIEnv.GetFieldID (class_ref, "prevBuf", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, prevBuf_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput.File']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/wav/WavInput$File", DoNotGenerateAcw=true)]
		public partial class File : global::Org.Jcodec.Codecs.Wav.WavInput {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/wav/WavInput$File", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (File); }
			}

			protected File (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_File_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput.File']/constructor[@name='WavInput.File' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
			[Register (".ctor", "(Ljava/io/File;)V", "")]
			public unsafe File (global::Java.IO.File p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (File)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/File;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/File;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_File_ == IntPtr.Zero)
						id_ctor_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_File_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput.Source']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/wav/WavInput$Source", DoNotGenerateAcw=true)]
		public partial class Source : global::Java.Lang.Object, global::Java.IO.ICloseable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/wav/WavInput$Source", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Source); }
			}

			protected Source (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_File_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput.Source']/constructor[@name='WavInput.Source' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
			[Register (".ctor", "(Ljava/io/File;)V", "")]
			public unsafe Source (global::Java.IO.File p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Source)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/File;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/File;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_File_ == IntPtr.Zero)
						id_ctor_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_File_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Ljava_nio_channels_ReadableByteChannel_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput.Source']/constructor[@name='WavInput.Source' and count(parameter)=1 and parameter[1][@type='java.nio.channels.ReadableByteChannel']]"
			[Register (".ctor", "(Ljava/nio/channels/ReadableByteChannel;)V", "")]
			public unsafe Source (global::Java.Nio.Channels.IReadableByteChannel p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Source)) {
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

			static IntPtr id_ctor_Lorg_jcodec_codecs_wav_WavInput_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput.Source']/constructor[@name='WavInput.Source' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.wav.WavInput']]"
			[Register (".ctor", "(Lorg/jcodec/codecs/wav/WavInput;)V", "")]
			public unsafe Source (global::Org.Jcodec.Codecs.Wav.WavInput p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Source)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/codecs/wav/WavInput;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/codecs/wav/WavInput;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_codecs_wav_WavInput_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_codecs_wav_WavInput_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/wav/WavInput;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavInput_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavInput_, __args);
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
				global::Org.Jcodec.Codecs.Wav.WavInput.Source __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavInput.Source> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput.Source']/method[@name='close' and count(parameter)=0]"
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

			static Delegate cb_read_arrayII;
#pragma warning disable 0169
			static Delegate GetRead_arrayIIHandler ()
			{
				if (cb_read_arrayII == null)
					cb_read_arrayII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_Read_arrayII);
				return cb_read_arrayII;
			}

			static int n_Read_arrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Org.Jcodec.Codecs.Wav.WavInput.Source __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavInput.Source> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
				int __ret = __this.Read (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_read_arrayII;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput.Source']/method[@name='read' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
			[Register ("read", "([II)I", "GetRead_arrayIIHandler")]
			public virtual unsafe int Read (int[] p0, int p1)
			{
				if (id_read_arrayII == IntPtr.Zero)
					id_read_arrayII = JNIEnv.GetMethodID (class_ref, "read", "([II)I");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayII, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "([II)I"), __args);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_read_Ljava_nio_FloatBuffer_;
#pragma warning disable 0169
			static Delegate GetRead_Ljava_nio_FloatBuffer_Handler ()
			{
				if (cb_read_Ljava_nio_FloatBuffer_ == null)
					cb_read_Ljava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_Ljava_nio_FloatBuffer_);
				return cb_read_Ljava_nio_FloatBuffer_;
			}

			static int n_Read_Ljava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Codecs.Wav.WavInput.Source __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavInput.Source> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.FloatBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Read (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_read_Ljava_nio_FloatBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput.Source']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.FloatBuffer']]"
			[Register ("read", "(Ljava/nio/FloatBuffer;)I", "GetRead_Ljava_nio_FloatBuffer_Handler")]
			public virtual unsafe int Read (global::Java.Nio.FloatBuffer p0)
			{
				if (id_read_Ljava_nio_FloatBuffer_ == IntPtr.Zero)
					id_read_Ljava_nio_FloatBuffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/FloatBuffer;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_FloatBuffer_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/nio/FloatBuffer;)I"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/wav/WavInput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WavInput); }
		}

		protected WavInput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_channels_ReadableByteChannel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput']/constructor[@name='WavInput' and count(parameter)=1 and parameter[1][@type='java.nio.channels.ReadableByteChannel']]"
		[Register (".ctor", "(Ljava/nio/channels/ReadableByteChannel;)V", "")]
		public unsafe WavInput (global::Java.Nio.Channels.IReadableByteChannel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (WavInput)) {
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

		static Delegate cb_getHeader;
#pragma warning disable 0169
		static Delegate GetGetHeaderHandler ()
		{
			if (cb_getHeader == null)
				cb_getHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeader);
			return cb_getHeader;
		}

		static IntPtr n_GetHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Wav.WavInput __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Header);
		}
#pragma warning restore 0169

		static IntPtr id_getHeader;
		public virtual unsafe global::Org.Jcodec.Codecs.Wav.WavHeader Header {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput']/method[@name='getHeader' and count(parameter)=0]"
			[Register ("getHeader", "()Lorg/jcodec/codecs/wav/WavHeader;", "GetGetHeaderHandler")]
			get {
				if (id_getHeader == IntPtr.Zero)
					id_getHeader = JNIEnv.GetMethodID (class_ref, "getHeader", "()Lorg/jcodec/codecs/wav/WavHeader;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeader", "()Lorg/jcodec/codecs/wav/WavHeader;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Codecs.Wav.WavInput __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput']/method[@name='close' and count(parameter)=0]"
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
			global::Org.Jcodec.Codecs.Wav.WavInput __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavInput']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)I", "GetRead_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe int Read (global::Java.Nio.ByteBuffer p0)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_ByteBuffer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/nio/ByteBuffer;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
