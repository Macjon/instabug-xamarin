using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Wav {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavOutput']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/wav/WavOutput", DoNotGenerateAcw=true)]
	public partial class WavOutput : global::Java.Lang.Object, global::Java.IO.ICloseable {


		static IntPtr header_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavOutput']/field[@name='header']"
		[Register ("header")]
		protected global::Org.Jcodec.Codecs.Wav.WavHeader Header {
			get {
				if (header_jfieldId == IntPtr.Zero)
					header_jfieldId = JNIEnv.GetFieldID (class_ref, "header", "Lorg/jcodec/codecs/wav/WavHeader;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, header_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (header_jfieldId == IntPtr.Zero)
					header_jfieldId = JNIEnv.GetFieldID (class_ref, "header", "Lorg/jcodec/codecs/wav/WavHeader;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, header_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr written_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavOutput']/field[@name='written']"
		[Register ("written")]
		protected int Written {
			get {
				if (written_jfieldId == IntPtr.Zero)
					written_jfieldId = JNIEnv.GetFieldID (class_ref, "written", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, written_jfieldId);
			}
			set {
				if (written_jfieldId == IntPtr.Zero)
					written_jfieldId = JNIEnv.GetFieldID (class_ref, "written", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, written_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavOutput.File']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/wav/WavOutput$File", DoNotGenerateAcw=true)]
		public partial class File : global::Org.Jcodec.Codecs.Wav.WavOutput {

			protected File (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavOutput.Sink']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/wav/WavOutput$Sink", DoNotGenerateAcw=true)]
		public partial class Sink : global::Java.Lang.Object, global::Java.IO.ICloseable, global::Org.Jcodec.Audio.IAudioSink {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/wav/WavOutput$Sink", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Sink); }
			}

			protected Sink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_codecs_wav_WavOutput_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavOutput.Sink']/constructor[@name='WavOutput.Sink' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.wav.WavOutput']]"
			[Register (".ctor", "(Lorg/jcodec/codecs/wav/WavOutput;)V", "")]
			public unsafe Sink (global::Org.Jcodec.Codecs.Wav.WavOutput p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Sink)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/codecs/wav/WavOutput;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/codecs/wav/WavOutput;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_codecs_wav_WavOutput_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_codecs_wav_WavOutput_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/wav/WavOutput;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavOutput_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_wav_WavOutput_, __args);
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
				global::Org.Jcodec.Codecs.Wav.WavOutput.Sink __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavOutput.Sink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavOutput.Sink']/method[@name='close' and count(parameter)=0]"
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

			static Delegate cb_write_arrayII;
#pragma warning disable 0169
			static Delegate GetWrite_arrayIIHandler ()
			{
				if (cb_write_arrayII == null)
					cb_write_arrayII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayII);
				return cb_write_arrayII;
			}

			static void n_Write_arrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Org.Jcodec.Codecs.Wav.WavOutput.Sink __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavOutput.Sink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
				__this.Write (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_write_arrayII;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavOutput.Sink']/method[@name='write' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
			[Register ("write", "([II)V", "GetWrite_arrayIIHandler")]
			public virtual unsafe void Write (int[] p0, int p1)
			{
				if (id_write_arrayII == IntPtr.Zero)
					id_write_arrayII = JNIEnv.GetMethodID (class_ref, "write", "([II)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayII, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([II)V"), __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_write_Ljava_nio_FloatBuffer_;
#pragma warning disable 0169
			static Delegate GetWrite_Ljava_nio_FloatBuffer_Handler ()
			{
				if (cb_write_Ljava_nio_FloatBuffer_ == null)
					cb_write_Ljava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_nio_FloatBuffer_);
				return cb_write_Ljava_nio_FloatBuffer_;
			}

			static void n_Write_Ljava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Codecs.Wav.WavOutput.Sink __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavOutput.Sink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.FloatBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Write (p0);
			}
#pragma warning restore 0169

			static IntPtr id_write_Ljava_nio_FloatBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavOutput.Sink']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.FloatBuffer']]"
			[Register ("write", "(Ljava/nio/FloatBuffer;)V", "GetWrite_Ljava_nio_FloatBuffer_Handler")]
			public virtual unsafe void Write (global::Java.Nio.FloatBuffer p0)
			{
				if (id_write_Ljava_nio_FloatBuffer_ == IntPtr.Zero)
					id_write_Ljava_nio_FloatBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/FloatBuffer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_FloatBuffer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/nio/FloatBuffer;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/wav/WavOutput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WavOutput); }
		}

		protected WavOutput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Jcodec.Codecs.Wav.WavOutput __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavOutput']/method[@name='close' and count(parameter)=0]"
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

		static Delegate cb_write_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_write_Ljava_nio_ByteBuffer_ == null)
				cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_nio_ByteBuffer_);
			return cb_write_Ljava_nio_ByteBuffer_;
		}

		static void n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Wav.WavOutput __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Wav.WavOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.wav']/class[@name='WavOutput']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)V", "GetWrite_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Write (global::Java.Nio.ByteBuffer p0)
		{
			if (id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
