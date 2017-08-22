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
		public unsafe Mpeg2Prores (global::Org.Jcodec.Codecs.Mpeg12.Bitstream.SequenceHeader sh, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader gh, global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile profile)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (sh);
				__args [1] = new JValue (gh);
				__args [2] = new JValue (profile);
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

		static void n_IdctPut_arrayIarrayarrayIIIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_block, IntPtr native_buf, int stride, int chromaFormat, int blkNo, int mbX, int mbY, int dctType)
		{
			global::Org.Jcodec.Codecs.Prores.Mpeg2Prores __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.Mpeg2Prores> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] block = (int[]) JNIEnv.GetArray (native_block, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[][] buf = (int[][]) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			__this.IdctPut (block, buf, stride, chromaFormat, blkNo, mbX, mbY, dctType);
			if (block != null)
				JNIEnv.CopyArray (block, native_block);
			if (buf != null)
				JNIEnv.CopyArray (buf, native_buf);
		}
#pragma warning restore 0169

		static IntPtr id_idctPut_arrayIarrayarrayIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='Mpeg2Prores']/method[@name='idctPut' and count(parameter)=8 and parameter[1][@type='int[]'] and parameter[2][@type='int[][]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("idctPut", "([I[[IIIIIII)V", "GetIdctPut_arrayIarrayarrayIIIIIIIHandler")]
		protected virtual unsafe void IdctPut (int[] block, int[][] buf, int stride, int chromaFormat, int blkNo, int mbX, int mbY, int dctType)
		{
			if (id_idctPut_arrayIarrayarrayIIIIIII == IntPtr.Zero)
				id_idctPut_arrayIarrayarrayIIIIIII = JNIEnv.GetMethodID (class_ref, "idctPut", "([I[[IIIIIII)V");
			IntPtr native_block = JNIEnv.NewArray (block);
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_block);
				__args [1] = new JValue (native_buf);
				__args [2] = new JValue (stride);
				__args [3] = new JValue (chromaFormat);
				__args [4] = new JValue (blkNo);
				__args [5] = new JValue (mbX);
				__args [6] = new JValue (mbY);
				__args [7] = new JValue (dctType);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_idctPut_arrayIarrayarrayIIIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "idctPut", "([I[[IIIIIII)V"), __args);
			} finally {
				if (block != null) {
					JNIEnv.CopyArray (native_block, block);
					JNIEnv.DeleteLocalRef (native_block);
				}
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
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

		static IntPtr n_Transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in, IntPtr native__out)
		{
			global::Org.Jcodec.Codecs.Prores.Mpeg2Prores __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.Mpeg2Prores> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer @in = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native__in, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer _out = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native__out, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transcode (@in, _out));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='Mpeg2Prores']/method[@name='transcode' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("transcode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "GetTranscode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe global::Java.Nio.ByteBuffer Transcode (global::Java.Nio.ByteBuffer @in, global::Java.Nio.ByteBuffer _out)
		{
			if (id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_transcode_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "transcode", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@in);
				__args [1] = new JValue (_out);

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
