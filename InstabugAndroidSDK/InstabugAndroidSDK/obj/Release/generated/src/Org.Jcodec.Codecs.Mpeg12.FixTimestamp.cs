using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixTimestamp']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/FixTimestamp", DoNotGenerateAcw=true)]
	public abstract partial class FixTimestamp : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/FixTimestamp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FixTimestamp); }
		}

		protected FixTimestamp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixTimestamp']/constructor[@name='FixTimestamp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FixTimestamp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FixTimestamp)) {
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

		static Delegate cb_doWithTimestamp_IJZ;
#pragma warning disable 0169
		static Delegate GetDoWithTimestamp_IJZHandler ()
		{
			if (cb_doWithTimestamp_IJZ == null)
				cb_doWithTimestamp_IJZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, bool, long>) n_DoWithTimestamp_IJZ);
			return cb_doWithTimestamp_IJZ;
		}

		static long n_DoWithTimestamp_IJZ (IntPtr jnienv, IntPtr native__this, int p0, long p1, bool p2)
		{
			global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoWithTimestamp (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixTimestamp']/method[@name='doWithTimestamp' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("doWithTimestamp", "(IJZ)J", "GetDoWithTimestamp_IJZHandler")]
		protected abstract long DoWithTimestamp (int p0, long p1, bool p2);

		static Delegate cb_fix_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetFix_Ljava_io_File_Handler ()
		{
			if (cb_fix_Ljava_io_File_ == null)
				cb_fix_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Fix_Ljava_io_File_);
			return cb_fix_Ljava_io_File_;
		}

		static void n_Fix_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Fix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fix_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixTimestamp']/method[@name='fix' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("fix", "(Ljava/io/File;)V", "GetFix_Ljava_io_File_Handler")]
		public virtual unsafe void Fix (global::Java.IO.File p0)
		{
			if (id_fix_Ljava_io_File_ == IntPtr.Zero)
				id_fix_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "fix", "(Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fix_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fix", "(Ljava/io/File;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_fixMpeg1_ILjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetFixMpeg1_ILjava_nio_ByteBuffer_Handler ()
		{
			if (cb_fixMpeg1_ILjava_nio_ByteBuffer_ == null)
				cb_fixMpeg1_ILjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_FixMpeg1_ILjava_nio_ByteBuffer_);
			return cb_fixMpeg1_ILjava_nio_ByteBuffer_;
		}

		static void n_FixMpeg1_ILjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.FixMpeg1 (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_fixMpeg1_ILjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixTimestamp']/method[@name='fixMpeg1' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("fixMpeg1", "(ILjava/nio/ByteBuffer;)V", "GetFixMpeg1_ILjava_nio_ByteBuffer_Handler")]
		public virtual unsafe void FixMpeg1 (int p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_fixMpeg1_ILjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_fixMpeg1_ILjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "fixMpeg1", "(ILjava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fixMpeg1_ILjava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fixMpeg1", "(ILjava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_fixMpeg2_ILjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetFixMpeg2_ILjava_nio_ByteBuffer_Handler ()
		{
			if (cb_fixMpeg2_ILjava_nio_ByteBuffer_ == null)
				cb_fixMpeg2_ILjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_FixMpeg2_ILjava_nio_ByteBuffer_);
			return cb_fixMpeg2_ILjava_nio_ByteBuffer_;
		}

		static void n_FixMpeg2_ILjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.FixMpeg2 (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_fixMpeg2_ILjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixTimestamp']/method[@name='fixMpeg2' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("fixMpeg2", "(ILjava/nio/ByteBuffer;)V", "GetFixMpeg2_ILjava_nio_ByteBuffer_Handler")]
		public virtual unsafe void FixMpeg2 (int p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_fixMpeg2_ILjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_fixMpeg2_ILjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "fixMpeg2", "(ILjava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fixMpeg2_ILjava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fixMpeg2", "(ILjava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_fixTs_ILjava_nio_ByteBuffer_Z;
#pragma warning disable 0169
		static Delegate GetFixTs_ILjava_nio_ByteBuffer_ZHandler ()
		{
			if (cb_fixTs_ILjava_nio_ByteBuffer_Z == null)
				cb_fixTs_ILjava_nio_ByteBuffer_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool, long>) n_FixTs_ILjava_nio_ByteBuffer_Z);
			return cb_fixTs_ILjava_nio_ByteBuffer_Z;
		}

		static long n_FixTs_ILjava_nio_ByteBuffer_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, bool p2)
		{
			global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.FixTs (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fixTs_ILjava_nio_ByteBuffer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixTimestamp']/method[@name='fixTs' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='boolean']]"
		[Register ("fixTs", "(ILjava/nio/ByteBuffer;Z)J", "GetFixTs_ILjava_nio_ByteBuffer_ZHandler")]
		public virtual unsafe long FixTs (int p0, global::Java.Nio.ByteBuffer p1, bool p2)
		{
			if (id_fixTs_ILjava_nio_ByteBuffer_Z == IntPtr.Zero)
				id_fixTs_ILjava_nio_ByteBuffer_Z = JNIEnv.GetMethodID (class_ref, "fixTs", "(ILjava/nio/ByteBuffer;Z)J");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				long __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_fixTs_ILjava_nio_ByteBuffer_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fixTs", "(ILjava/nio/ByteBuffer;Z)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isAudio_I;
#pragma warning disable 0169
		static Delegate GetIsAudio_IHandler ()
		{
			if (cb_isAudio_I == null)
				cb_isAudio_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsAudio_I);
			return cb_isAudio_I;
		}

		static bool n_IsAudio_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAudio (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isAudio_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixTimestamp']/method[@name='isAudio' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isAudio", "(I)Z", "GetIsAudio_IHandler")]
		public virtual unsafe bool IsAudio (int p0)
		{
			if (id_isAudio_I == IntPtr.Zero)
				id_isAudio_I = JNIEnv.GetMethodID (class_ref, "isAudio", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAudio_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAudio", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_isVideo_I;
#pragma warning disable 0169
		static Delegate GetIsVideo_IHandler ()
		{
			if (cb_isVideo_I == null)
				cb_isVideo_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsVideo_I);
			return cb_isVideo_I;
		}

		static bool n_IsVideo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.FixTimestamp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVideo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isVideo_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixTimestamp']/method[@name='isVideo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isVideo", "(I)Z", "GetIsVideo_IHandler")]
		public virtual unsafe bool IsVideo (int p0)
		{
			if (id_isVideo_I == IntPtr.Zero)
				id_isVideo_I = JNIEnv.GetMethodID (class_ref, "isVideo", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVideo_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVideo", "(I)Z"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/FixTimestamp", DoNotGenerateAcw=true)]
	internal partial class FixTimestampInvoker : FixTimestamp {

		public FixTimestampInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FixTimestampInvoker); }
		}

		static IntPtr id_doWithTimestamp_IJZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='FixTimestamp']/method[@name='doWithTimestamp' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("doWithTimestamp", "(IJZ)J", "GetDoWithTimestamp_IJZHandler")]
		protected override unsafe long DoWithTimestamp (int p0, long p1, bool p2)
		{
			if (id_doWithTimestamp_IJZ == IntPtr.Zero)
				id_doWithTimestamp_IJZ = JNIEnv.GetMethodID (class_ref, "doWithTimestamp", "(IJZ)J");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_doWithTimestamp_IJZ, __args);
			} finally {
			}
		}

	}

}
