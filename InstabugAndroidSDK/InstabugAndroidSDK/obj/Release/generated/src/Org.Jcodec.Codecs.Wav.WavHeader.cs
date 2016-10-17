using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Wav {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/wav/WavHeader", DoNotGenerateAcw=true)]
	public partial class WavHeader : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/field[@name='WAV_HEADER_SIZE']"
		[Register ("WAV_HEADER_SIZE")]
		public const int WavHeaderSize = (int) 44;

		static IntPtr chunkId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/field[@name='chunkId']"
		[Register ("chunkId")]
		public string ChunkId {
			get {
				if (chunkId_jfieldId == IntPtr.Zero)
					chunkId_jfieldId = JNIEnv.GetFieldID (class_ref, "chunkId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chunkId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chunkId_jfieldId == IntPtr.Zero)
					chunkId_jfieldId = JNIEnv.GetFieldID (class_ref, "chunkId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chunkId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr chunkSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/field[@name='chunkSize']"
		[Register ("chunkSize")]
		public int ChunkSize {
			get {
				if (chunkSize_jfieldId == IntPtr.Zero)
					chunkSize_jfieldId = JNIEnv.GetFieldID (class_ref, "chunkSize", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, chunkSize_jfieldId);
			}
			set {
				if (chunkSize_jfieldId == IntPtr.Zero)
					chunkSize_jfieldId = JNIEnv.GetFieldID (class_ref, "chunkSize", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chunkSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr dataOffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/field[@name='dataOffset']"
		[Register ("dataOffset")]
		public int DataOffset {
			get {
				if (dataOffset_jfieldId == IntPtr.Zero)
					dataOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "dataOffset", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, dataOffset_jfieldId);
			}
			set {
				if (dataOffset_jfieldId == IntPtr.Zero)
					dataOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "dataOffset", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dataOffset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr dataSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/field[@name='dataSize']"
		[Register ("dataSize")]
		public long DataSize {
			get {
				if (dataSize_jfieldId == IntPtr.Zero)
					dataSize_jfieldId = JNIEnv.GetFieldID (class_ref, "dataSize", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, dataSize_jfieldId);
			}
			set {
				if (dataSize_jfieldId == IntPtr.Zero)
					dataSize_jfieldId = JNIEnv.GetFieldID (class_ref, "dataSize", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dataSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fmt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/field[@name='fmt']"
		[Register ("fmt")]
		public global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk Fmt {
			get {
				if (fmt_jfieldId == IntPtr.Zero)
					fmt_jfieldId = JNIEnv.GetFieldID (class_ref, "fmt", "Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, fmt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (fmt_jfieldId == IntPtr.Zero)
					fmt_jfieldId = JNIEnv.GetFieldID (class_ref, "fmt", "Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fmt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr format_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/field[@name='format']"
		[Register ("format")]
		public string Format {
			get {
				if (format_jfieldId == IntPtr.Zero)
					format_jfieldId = JNIEnv.GetFieldID (class_ref, "format", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, format_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (format_jfieldId == IntPtr.Zero)
					format_jfieldId = JNIEnv.GetFieldID (class_ref, "format", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, format_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/wav/WavHeader$FmtChunk", DoNotGenerateAcw=true)]
		public partial class FmtChunk : global::Java.Lang.Object {


			static IntPtr audioFormat_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/field[@name='audioFormat']"
			[Register ("audioFormat")]
			public short AudioFormat {
				get {
					if (audioFormat_jfieldId == IntPtr.Zero)
						audioFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "audioFormat", "S");
					return JNIEnv.GetShortField (((global::Java.Lang.Object) this).Handle, audioFormat_jfieldId);
				}
				set {
					if (audioFormat_jfieldId == IntPtr.Zero)
						audioFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "audioFormat", "S");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, audioFormat_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr bitsPerSample_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/field[@name='bitsPerSample']"
			[Register ("bitsPerSample")]
			public short BitsPerSample {
				get {
					if (bitsPerSample_jfieldId == IntPtr.Zero)
						bitsPerSample_jfieldId = JNIEnv.GetFieldID (class_ref, "bitsPerSample", "S");
					return JNIEnv.GetShortField (((global::Java.Lang.Object) this).Handle, bitsPerSample_jfieldId);
				}
				set {
					if (bitsPerSample_jfieldId == IntPtr.Zero)
						bitsPerSample_jfieldId = JNIEnv.GetFieldID (class_ref, "bitsPerSample", "S");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bitsPerSample_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr blockAlign_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/field[@name='blockAlign']"
			[Register ("blockAlign")]
			public short BlockAlign {
				get {
					if (blockAlign_jfieldId == IntPtr.Zero)
						blockAlign_jfieldId = JNIEnv.GetFieldID (class_ref, "blockAlign", "S");
					return JNIEnv.GetShortField (((global::Java.Lang.Object) this).Handle, blockAlign_jfieldId);
				}
				set {
					if (blockAlign_jfieldId == IntPtr.Zero)
						blockAlign_jfieldId = JNIEnv.GetFieldID (class_ref, "blockAlign", "S");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, blockAlign_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr byteRate_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/field[@name='byteRate']"
			[Register ("byteRate")]
			public int ByteRate {
				get {
					if (byteRate_jfieldId == IntPtr.Zero)
						byteRate_jfieldId = JNIEnv.GetFieldID (class_ref, "byteRate", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, byteRate_jfieldId);
				}
				set {
					if (byteRate_jfieldId == IntPtr.Zero)
						byteRate_jfieldId = JNIEnv.GetFieldID (class_ref, "byteRate", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, byteRate_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr numChannels_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/field[@name='numChannels']"
			[Register ("numChannels")]
			public short NumChannels {
				get {
					if (numChannels_jfieldId == IntPtr.Zero)
						numChannels_jfieldId = JNIEnv.GetFieldID (class_ref, "numChannels", "S");
					return JNIEnv.GetShortField (((global::Java.Lang.Object) this).Handle, numChannels_jfieldId);
				}
				set {
					if (numChannels_jfieldId == IntPtr.Zero)
						numChannels_jfieldId = JNIEnv.GetFieldID (class_ref, "numChannels", "S");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, numChannels_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr sampleRate_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/field[@name='sampleRate']"
			[Register ("sampleRate")]
			public int SampleRate {
				get {
					if (sampleRate_jfieldId == IntPtr.Zero)
						sampleRate_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleRate", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sampleRate_jfieldId);
				}
				set {
					if (sampleRate_jfieldId == IntPtr.Zero)
						sampleRate_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleRate", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sampleRate_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/wav/WavHeader$FmtChunk", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FmtChunk); }
			}

			protected FmtChunk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/constructor[@name='WavHeader.FmtChunk' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.wav.WavHeader.FmtChunk']]"
			[Register (".ctor", "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;)V", "")]
			public unsafe FmtChunk (global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (FmtChunk)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_SSIISS;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/constructor[@name='WavHeader.FmtChunk' and count(parameter)=6 and parameter[1][@type='short'] and parameter[2][@type='short'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='short'] and parameter[6][@type='short']]"
			[Register (".ctor", "(SSIISS)V", "")]
			public unsafe FmtChunk (short p0, short p1, int p2, int p3, short p4, short p5)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [6];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					if (GetType () != typeof (FmtChunk)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(SSIISS)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(SSIISS)V", __args);
						return;
					}

					if (id_ctor_SSIISS == IntPtr.Zero)
						id_ctor_SSIISS = JNIEnv.GetMethodID (class_ref, "<init>", "(SSIISS)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_SSIISS, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_SSIISS, __args);
				} finally {
				}
			}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/constructor[@name='WavHeader.FmtChunk' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe FmtChunk ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (FmtChunk)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static IntPtr id_get_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("get", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;", "")]
			public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk Get (global::Java.Nio.ByteBuffer p0)
			{
				if (id_get_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_get_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_put_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetPut_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_put_Ljava_nio_ByteBuffer_ == null)
					cb_put_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Put_Ljava_nio_ByteBuffer_);
				return cb_put_Ljava_nio_ByteBuffer_;
			}

			static void n_Put_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Put (p0);
			}
#pragma warning restore 0169

			static IntPtr id_put_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/method[@name='put' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("put", "(Ljava/nio/ByteBuffer;)V", "GetPut_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe void Put (global::Java.Nio.ByteBuffer p0)
			{
				if (id_put_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_put_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/nio/ByteBuffer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_nio_ByteBuffer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/nio/ByteBuffer;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_size;
#pragma warning disable 0169
			static Delegate GetSizeHandler ()
			{
				if (cb_size == null)
					cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
				return cb_size;
			}

			static int n_Size (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Size ();
			}
#pragma warning restore 0169

			static IntPtr id_size;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunk']/method[@name='size' and count(parameter)=0]"
			[Register ("size", "()I", "GetSizeHandler")]
			public virtual unsafe int Size ()
			{
				if (id_size == IntPtr.Zero)
					id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunkExtended']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/wav/WavHeader$FmtChunkExtended", DoNotGenerateAcw=true)]
		public partial class FmtChunkExtended : global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/wav/WavHeader$FmtChunkExtended", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FmtChunkExtended); }
			}

			protected FmtChunkExtended (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_SSII;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunkExtended']/constructor[@name='WavHeader.FmtChunkExtended' and count(parameter)=5 and parameter[1][@type='org.jcodec.codecs.wav.WavHeader.FmtChunk'] and parameter[2][@type='short'] and parameter[3][@type='short'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register (".ctor", "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;SSII)V", "")]
			public unsafe FmtChunkExtended (global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk p0, short p1, short p2, int p3, int p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					if (GetType () != typeof (FmtChunkExtended)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;SSII)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;SSII)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_SSII == IntPtr.Zero)
						id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_SSII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;SSII)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_SSII, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_SSII, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunkExtended_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunkExtended']/constructor[@name='WavHeader.FmtChunkExtended' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.wav.WavHeader.FmtChunkExtended']]"
			[Register (".ctor", "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunkExtended;)V", "")]
			public unsafe FmtChunkExtended (global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunkExtended p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (FmtChunkExtended)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunkExtended;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunkExtended;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunkExtended_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunkExtended_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/wav/WavHeader$FmtChunkExtended;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunkExtended_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavHeader_FmtChunkExtended_, __args);
				} finally {
				}
			}

			static Delegate cb_getLabels;
#pragma warning disable 0169
			static Delegate GetGetLabelsHandler ()
			{
				if (cb_getLabels == null)
					cb_getLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabels);
				return cb_getLabels;
			}

			static IntPtr n_GetLabels (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunkExtended __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunkExtended> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetLabels ());
			}
#pragma warning restore 0169

			static IntPtr id_getLabels;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunkExtended']/method[@name='getLabels' and count(parameter)=0]"
			[Register ("getLabels", "()[Lorg/jcodec/common/model/ChannelLabel;", "GetGetLabelsHandler")]
			public virtual unsafe global::Org.Jcodec.Common.Model.ChannelLabel[] GetLabels ()
			{
				if (id_getLabels == IntPtr.Zero)
					id_getLabels = JNIEnv.GetMethodID (class_ref, "getLabels", "()[Lorg/jcodec/common/model/ChannelLabel;");
				try {

					if (GetType () == ThresholdType)
						return (global::Org.Jcodec.Common.Model.ChannelLabel[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLabels), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ChannelLabel));
					else
						return (global::Org.Jcodec.Common.Model.ChannelLabel[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabels", "()[Lorg/jcodec/common/model/ChannelLabel;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ChannelLabel));
				} finally {
				}
			}

			static IntPtr id_read_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader.FmtChunkExtended']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;", "")]
			public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk Read (global::Java.Nio.ByteBuffer p0)
			{
				if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/wav/WavHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WavHeader); }
		}

		protected WavHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_codecs_wav_WavHeader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/constructor[@name='WavHeader' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.wav.WavHeader']]"
		[Register (".ctor", "(Lorg/jcodec/codecs/wav/WavHeader;)V", "")]
		public unsafe WavHeader (global::Org.Jcodec.Codecs.Wav.WavHeader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (WavHeader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/codecs/wav/WavHeader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/codecs/wav/WavHeader;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_codecs_wav_WavHeader_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_codecs_wav_WavHeader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/wav/WavHeader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavHeader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavHeader_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_ILjava_lang_String_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_IJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/constructor[@name='WavHeader' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.jcodec.codecs.wav.WavHeader.FmtChunk'] and parameter[5][@type='int'] and parameter[6][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;ILjava/lang/String;Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;IJ)V", "")]
		public unsafe WavHeader (string p0, int p1, string p2, global::Org.Jcodec.Codecs.Wav.WavHeader.FmtChunk p3, int p4, long p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (WavHeader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;ILjava/lang/String;Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;IJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;ILjava/lang/String;Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;IJ)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ILjava_lang_String_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_IJ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ILjava_lang_String_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ILjava/lang/String;Lorg/jcodec/codecs/wav/WavHeader$FmtChunk;IJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_IJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_Lorg_jcodec_codecs_wav_WavHeader_FmtChunk_IJ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_calcDataSize_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='calcDataSize' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("calcDataSize", "(IIJ)J", "")]
		public static unsafe long CalcDataSize (int p0, int p1, long p2)
		{
			if (id_calcDataSize_IIJ == IntPtr.Zero)
				id_calcDataSize_IIJ = JNIEnv.GetStaticMethodID (class_ref, "calcDataSize", "(IIJ)J");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_calcDataSize_IIJ, __args);
			} finally {
			}
		}

		static IntPtr id_copyWithChannels_Lorg_jcodec_codecs_wav_WavHeader_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='copyWithChannels' and count(parameter)=2 and parameter[1][@type='org.jcodec.codecs.wav.WavHeader'] and parameter[2][@type='int']]"
		[Register ("copyWithChannels", "(Lorg/jcodec/codecs/wav/WavHeader;I)Lorg/jcodec/codecs/wav/WavHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader CopyWithChannels (global::Org.Jcodec.Codecs.Wav.WavHeader p0, int p1)
		{
			if (id_copyWithChannels_Lorg_jcodec_codecs_wav_WavHeader_I == IntPtr.Zero)
				id_copyWithChannels_Lorg_jcodec_codecs_wav_WavHeader_I = JNIEnv.GetStaticMethodID (class_ref, "copyWithChannels", "(Lorg/jcodec/codecs/wav/WavHeader;I)Lorg/jcodec/codecs/wav/WavHeader;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Jcodec.Codecs.Wav.WavHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copyWithChannels_Lorg_jcodec_codecs_wav_WavHeader_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_copyWithRate_Lorg_jcodec_codecs_wav_WavHeader_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='copyWithRate' and count(parameter)=2 and parameter[1][@type='org.jcodec.codecs.wav.WavHeader'] and parameter[2][@type='int']]"
		[Register ("copyWithRate", "(Lorg/jcodec/codecs/wav/WavHeader;I)Lorg/jcodec/codecs/wav/WavHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader CopyWithRate (global::Org.Jcodec.Codecs.Wav.WavHeader p0, int p1)
		{
			if (id_copyWithRate_Lorg_jcodec_codecs_wav_WavHeader_I == IntPtr.Zero)
				id_copyWithRate_Lorg_jcodec_codecs_wav_WavHeader_I = JNIEnv.GetStaticMethodID (class_ref, "copyWithRate", "(Lorg/jcodec/codecs/wav/WavHeader;I)Lorg/jcodec/codecs/wav/WavHeader;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Jcodec.Codecs.Wav.WavHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copyWithRate_Lorg_jcodec_codecs_wav_WavHeader_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_emptyWavHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='emptyWavHeader' and count(parameter)=0]"
		[Register ("emptyWavHeader", "()Lorg/jcodec/codecs/wav/WavHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader EmptyWavHeader ()
		{
			if (id_emptyWavHeader == IntPtr.Zero)
				id_emptyWavHeader = JNIEnv.GetStaticMethodID (class_ref, "emptyWavHeader", "()Lorg/jcodec/codecs/wav/WavHeader;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_emptyWavHeader), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getChannelLabels;
#pragma warning disable 0169
		static Delegate GetGetChannelLabelsHandler ()
		{
			if (cb_getChannelLabels == null)
				cb_getChannelLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelLabels);
			return cb_getChannelLabels;
		}

		static IntPtr n_GetChannelLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Wav.WavHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetChannelLabels ());
		}
#pragma warning restore 0169

		static IntPtr id_getChannelLabels;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='getChannelLabels' and count(parameter)=0]"
		[Register ("getChannelLabels", "()[Lorg/jcodec/common/model/ChannelLabel;", "GetGetChannelLabelsHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.ChannelLabel[] GetChannelLabels ()
		{
			if (id_getChannelLabels == IntPtr.Zero)
				id_getChannelLabels = JNIEnv.GetMethodID (class_ref, "getChannelLabels", "()[Lorg/jcodec/common/model/ChannelLabel;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Jcodec.Common.Model.ChannelLabel[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelLabels), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ChannelLabel));
				else
					return (global::Org.Jcodec.Common.Model.ChannelLabel[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelLabels", "()[Lorg/jcodec/common/model/ChannelLabel;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ChannelLabel));
			} finally {
			}
		}

		static IntPtr id_mono48k_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='mono48k' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("mono48k", "(J)Lorg/jcodec/codecs/wav/WavHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader Mono48k (long p0)
		{
			if (id_mono48k_J == IntPtr.Zero)
				id_mono48k_J = JNIEnv.GetStaticMethodID (class_ref, "mono48k", "(J)Lorg/jcodec/codecs/wav/WavHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mono48k_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_multiChannelWav_arrayLjava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='multiChannelWav' and count(parameter)=1 and parameter[1][@type='java.io.File...']]"
		[Register ("multiChannelWav", "([Ljava/io/File;)Lorg/jcodec/codecs/wav/WavHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader MultiChannelWav (params global:: Java.IO.File[] p0)
		{
			if (id_multiChannelWav_arrayLjava_io_File_ == IntPtr.Zero)
				id_multiChannelWav_arrayLjava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "multiChannelWav", "([Ljava/io/File;)Lorg/jcodec/codecs/wav/WavHeader;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Codecs.Wav.WavHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_multiChannelWav_arrayLjava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_multiChannelWav_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='multiChannelWav' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.io.File&gt;']]"
		[Register ("multiChannelWav", "(Ljava/util/List;)Lorg/jcodec/codecs/wav/WavHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader MultiChannelWav (global::System.Collections.Generic.IList<global::Java.IO.File> p0)
		{
			if (id_multiChannelWav_Ljava_util_List_ == IntPtr.Zero)
				id_multiChannelWav_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "multiChannelWav", "(Ljava/util/List;)Lorg/jcodec/codecs/wav/WavHeader;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.IO.File>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Codecs.Wav.WavHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_multiChannelWav_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_multiChannelWav_arrayLorg_jcodec_codecs_wav_WavHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='multiChannelWav' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.wav.WavHeader...']]"
		[Register ("multiChannelWav", "([Lorg/jcodec/codecs/wav/WavHeader;)Lorg/jcodec/codecs/wav/WavHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader MultiChannelWav (params global:: Org.Jcodec.Codecs.Wav.WavHeader[] p0)
		{
			if (id_multiChannelWav_arrayLorg_jcodec_codecs_wav_WavHeader_ == IntPtr.Zero)
				id_multiChannelWav_arrayLorg_jcodec_codecs_wav_WavHeader_ = JNIEnv.GetStaticMethodID (class_ref, "multiChannelWav", "([Lorg/jcodec/codecs/wav/WavHeader;)Lorg/jcodec/codecs/wav/WavHeader;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Codecs.Wav.WavHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_multiChannelWav_arrayLorg_jcodec_codecs_wav_WavHeader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("read", "(Ljava/io/File;)Lorg/jcodec/codecs/wav/WavHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader Read (global::Java.IO.File p0)
		{
			if (id_read_Ljava_io_File_ == IntPtr.Zero)
				id_read_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/io/File;)Lorg/jcodec/codecs/wav/WavHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Codecs.Wav.WavHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_read_Ljava_nio_channels_ReadableByteChannel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.channels.ReadableByteChannel']]"
		[Register ("read", "(Ljava/nio/channels/ReadableByteChannel;)Lorg/jcodec/codecs/wav/WavHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader Read (global::Java.Nio.Channels.IReadableByteChannel p0)
		{
			if (id_read_Ljava_nio_channels_ReadableByteChannel_ == IntPtr.Zero)
				id_read_Ljava_nio_channels_ReadableByteChannel_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/channels/ReadableByteChannel;)Lorg/jcodec/codecs/wav/WavHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Codecs.Wav.WavHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_channels_ReadableByteChannel_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_stereo48k;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='stereo48k' and count(parameter)=0]"
		[Register ("stereo48k", "()Lorg/jcodec/codecs/wav/WavHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader Stereo48k ()
		{
			if (id_stereo48k == IntPtr.Zero)
				id_stereo48k = JNIEnv.GetStaticMethodID (class_ref, "stereo48k", "()Lorg/jcodec/codecs/wav/WavHeader;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_stereo48k), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_stereo48k_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='stereo48k' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("stereo48k", "(J)Lorg/jcodec/codecs/wav/WavHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Wav.WavHeader Stereo48k (long p0)
		{
			if (id_stereo48k_J == IntPtr.Zero)
				id_stereo48k_J = JNIEnv.GetStaticMethodID (class_ref, "stereo48k", "(J)Lorg/jcodec/codecs/wav/WavHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_stereo48k_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_nio_channels_WritableByteChannel_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_channels_WritableByteChannel_Handler ()
		{
			if (cb_write_Ljava_nio_channels_WritableByteChannel_ == null)
				cb_write_Ljava_nio_channels_WritableByteChannel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_nio_channels_WritableByteChannel_);
			return cb_write_Ljava_nio_channels_WritableByteChannel_;
		}

		static void n_Write_Ljava_nio_channels_WritableByteChannel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Wav.WavHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Channels.IWritableByteChannel p0 = (global::Java.Nio.Channels.IWritableByteChannel)global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.IWritableByteChannel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_channels_WritableByteChannel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavHeader']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.channels.WritableByteChannel']]"
		[Register ("write", "(Ljava/nio/channels/WritableByteChannel;)V", "GetWrite_Ljava_nio_channels_WritableByteChannel_Handler")]
		public virtual unsafe void Write (global::Java.Nio.Channels.IWritableByteChannel p0)
		{
			if (id_write_Ljava_nio_channels_WritableByteChannel_ == IntPtr.Zero)
				id_write_Ljava_nio_channels_WritableByteChannel_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/channels/WritableByteChannel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_channels_WritableByteChannel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/nio/channels/WritableByteChannel;)V"), __args);
			} finally {
			}
		}

	}
}
