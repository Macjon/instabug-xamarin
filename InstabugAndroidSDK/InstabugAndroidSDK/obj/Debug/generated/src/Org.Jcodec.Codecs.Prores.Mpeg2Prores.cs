using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Prores {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='Mpeg2Prores']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/prores/Mpeg2Prores", DoNotGenerateAcw=true)]
	public partial class Mpeg2Prores : global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/prores/Mpeg2Prores", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Mpeg2Prores); }
		}

		protected Mpeg2Prores (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_GOPHeader_Lorg_jcodec_codecs_prores_ProresEncoder_Profile_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='Mpeg2Prores']/constructor[@name='Mpeg2Prores' and count(parameter)=3 and parameter[1][@type='org.jcodec.codecs.mpeg12.bitstream.SequenceHeader'] and parameter[2][@type='org.jcodec.codecs.mpeg12.bitstream.GOPHeader'] and parameter[3][@type='org.jcodec.codecs.prores.ProresEncoder.Profile']]"
		[Register (".ctor", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;Lorg/jcodec/codecs/prores/ProresEncoder$Profile;)V", "")]
		public unsafe Mpeg2Prores (global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader p0, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader p1, global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (Mpeg2Prores)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;Lorg/jcodec/codecs/prores/ProresEncoder$Profile;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;Lorg/jcodec/codecs/prores/ProresEncoder$Profile;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_GOPHeader_Lorg_jcodec_codecs_prores_ProresEncoder_Profile_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_GOPHeader_Lorg_jcodec_codecs_prores_ProresEncoder_Profile_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/mpeg12/bitstream/SequenceHeader;Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;Lorg/jcodec/codecs/prores/ProresEncoder$Profile;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_GOPHeader_Lorg_jcodec_codecs_prores_ProresEncoder_Profile_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_bitstream_SequenceHeader_Lorg_jcodec_codecs_mpeg12_bitstream_GOPHeader_Lorg_jcodec_codecs_prores_ProresEncoder_Profile_, __args);
			} finally {
			}
		}

		static Delegate cb_idctPut_arrayIarrayarrayIIIIIII;
#pragma warning disable 0169
		static Delegate GetIdctPut_arrayIarrayarrayIIIIIIIHandler ()
		{
			if (cb_idctPut_arrayIarrayarrayIIIIIII == null)
				cb_idctPut_arrayIarrayarrayIIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, int, int>) n_IdctPut_arrayIarrayarrayIIIIIII);
			return cb_idctPut_arrayIarrayarrayIIIIIII;
		}

		static void n_IdctPut_arrayIarrayarrayIIIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, int p5, int p6, int p7)
		{
			global::Org.Jcodec.Codecs.Prores.Mpeg2Prores __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.Mpeg2Prores> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[][] p1 = (int[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			__this.IdctPut (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_idctPut_arrayIarrayarrayIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='Mpeg2Prores']/method[@name='idctPut' and count(parameter)=8 and parameter[1][@type='int[]'] and parameter[2][@type='int[][]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("idctPut", "([I[[IIIIIII)V", "GetIdctPut_arrayIarrayarrayIIIIIIIHandler")]
		protected virtual unsafe void IdctPut (int[] p0, int[][] p1, int p2, int p3, int p4, int p5, int p6, int p7)
		{
			if (id_idctPut_arrayIarrayarrayIIIIIII == IntPtr.Zero)
				id_idctPut_arrayIarrayarrayIIIIIII = JNIEnv.GetMethodID (class_ref, "idctPut", "([I[[IIIIIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_idctPut_arrayIarrayarrayIIIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "idctPut", "([I[[IIIIIII)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetTranscode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == null)
				cb_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_);
			return cb_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_Transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Prores.Mpeg2Prores __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.Mpeg2Prores> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transcode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='Mpeg2Prores']/method[@name='transcode' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("transcode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "GetTranscode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe global::Java.Nio.ByteBuffer Transcode (global::Java.Nio.ByteBuffer p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "transcode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Nio.ByteBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transcode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
