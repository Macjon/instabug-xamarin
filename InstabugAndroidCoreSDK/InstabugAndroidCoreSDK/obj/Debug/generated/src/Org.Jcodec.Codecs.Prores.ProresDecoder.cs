using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Prores {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/prores/ProresDecoder", DoNotGenerateAcw=true)]
	public partial class ProresDecoder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/prores/ProresDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProresDecoder); }
		}

		protected ProresDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/constructor[@name='ProresDecoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProresDecoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ProresDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
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

		static Delegate cb_decodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayI;
#pragma warning disable 0169
		static Delegate GetDecodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayIHandler ()
		{
			if (cb_decodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayI == null)
				cb_decodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayI);
			return cb_decodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayI;
		}

		static IntPtr n_DecodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_target)
		{
			global::Org.Jcodec.Codecs.Prores.ProresDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer data = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_data, JniHandleOwnership.DoNotTransfer);
			int[][][] target = (int[][][]) JNIEnv.GetArray (native_target, JniHandleOwnership.DoNotTransfer, typeof (int[][]));
			IntPtr __ret = JNIEnv.NewArray (__this.DecodeFields (data, target));
			if (target != null)
				JNIEnv.CopyArray (target, native_target);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='decodeFields' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[][][]']]"
		[Register ("decodeFields", "(Ljava/nio/ByteBuffer;[[[I)[Lorg/jcodec/common/model/Picture;", "GetDecodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayIHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture[] DecodeFields (global::Java.Nio.ByteBuffer data, int[][][] target)
		{
			if (id_decodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayI == IntPtr.Zero)
				id_decodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayI = JNIEnv.GetMethodID (class_ref, "decodeFields", "(Ljava/nio/ByteBuffer;[[[I)[Lorg/jcodec/common/model/Picture;");
			IntPtr native_target = JNIEnv.NewArray (target);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (data);
				__args [1] = new JValue (native_target);

				global::Org.Jcodec.Common.Model.Picture[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (global::Org.Jcodec.Common.Model.Picture[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeFields_Ljava_nio_ByteBuffer_arrayarrayarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.Picture));
				else
					__ret = (global::Org.Jcodec.Common.Model.Picture[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeFields", "(Ljava/nio/ByteBuffer;[[[I)[Lorg/jcodec/common/model/Picture;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.Picture));
				return __ret;
			} finally {
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
			}
		}

		static Delegate cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI;
#pragma warning disable 0169
		static Delegate GetDecodeFrame_Ljava_nio_ByteBuffer_arrayarrayIHandler ()
		{
			if (cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI == null)
				cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeFrame_Ljava_nio_ByteBuffer_arrayarrayI);
			return cb_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI;
		}

		static IntPtr n_DecodeFrame_Ljava_nio_ByteBuffer_arrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_target)
		{
			global::Org.Jcodec.Codecs.Prores.ProresDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer data = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_data, JniHandleOwnership.DoNotTransfer);
			int[][] target = (int[][]) JNIEnv.GetArray (native_target, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeFrame (data, target));
			if (target != null)
				JNIEnv.CopyArray (target, native_target);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='decodeFrame' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[][]']]"
		[Register ("decodeFrame", "(Ljava/nio/ByteBuffer;[[I)Lorg/jcodec/common/model/Picture;", "GetDecodeFrame_Ljava_nio_ByteBuffer_arrayarrayIHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture DecodeFrame (global::Java.Nio.ByteBuffer data, int[][] target)
		{
			if (id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI == IntPtr.Zero)
				id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI = JNIEnv.GetMethodID (class_ref, "decodeFrame", "(Ljava/nio/ByteBuffer;[[I)Lorg/jcodec/common/model/Picture;");
			IntPtr native_target = JNIEnv.NewArray (target);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (data);
				__args [1] = new JValue (native_target);

				global::Org.Jcodec.Common.Model.Picture __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeFrame_Ljava_nio_ByteBuffer_arrayarrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeFrame", "(Ljava/nio/ByteBuffer;[[I)Lorg/jcodec/common/model/Picture;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (target != null) {
					JNIEnv.CopyArray (native_target, target);
					JNIEnv.DeleteLocalRef (native_target);
				}
			}
		}

		static Delegate cb_decodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIII;
#pragma warning disable 0169
		static Delegate GetDecodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIIIHandler ()
		{
			if (cb_decodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIII == null)
				cb_decodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int, int, int, IntPtr>) n_DecodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIII);
			return cb_decodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIII;
		}

		static IntPtr n_DecodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_bits, int blocksPerSlice, IntPtr native_qMat, IntPtr native_scan, int mbX, int mbY, int plane)
		{
			global::Org.Jcodec.Codecs.Prores.ProresDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader bits = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_bits, JniHandleOwnership.DoNotTransfer);
			int[] qMat = (int[]) JNIEnv.GetArray (native_qMat, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] scan = (int[]) JNIEnv.GetArray (native_scan, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.NewArray (__this.DecodeOnePlane (bits, blocksPerSlice, qMat, scan, mbX, mbY, plane));
			if (qMat != null)
				JNIEnv.CopyArray (qMat, native_qMat);
			if (scan != null)
				JNIEnv.CopyArray (scan, native_scan);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='decodeOnePlane' and count(parameter)=7 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("decodeOnePlane", "(Lorg/jcodec/common/io/BitReader;I[I[IIII)[I", "GetDecodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIIIHandler")]
		protected virtual unsafe int[] DecodeOnePlane (global::Org.Jcodec.Common.IO.BitReader bits, int blocksPerSlice, int[] qMat, int[] scan, int mbX, int mbY, int plane)
		{
			if (id_decodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIII == IntPtr.Zero)
				id_decodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIII = JNIEnv.GetMethodID (class_ref, "decodeOnePlane", "(Lorg/jcodec/common/io/BitReader;I[I[IIII)[I");
			IntPtr native_qMat = JNIEnv.NewArray (qMat);
			IntPtr native_scan = JNIEnv.NewArray (scan);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (bits);
				__args [1] = new JValue (blocksPerSlice);
				__args [2] = new JValue (native_qMat);
				__args [3] = new JValue (native_scan);
				__args [4] = new JValue (mbX);
				__args [5] = new JValue (mbY);
				__args [6] = new JValue (plane);

				int[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeOnePlane_Lorg_jcodec_common_io_BitReader_IarrayIarrayIIII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					__ret = (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeOnePlane", "(Lorg/jcodec/common/io/BitReader;I[I[IIII)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (qMat != null) {
					JNIEnv.CopyArray (native_qMat, qMat);
					JNIEnv.DeleteLocalRef (native_qMat);
				}
				if (scan != null) {
					JNIEnv.CopyArray (native_scan, scan);
					JNIEnv.DeleteLocalRef (native_scan);
				}
			}
		}

		static Delegate cb_decodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIII;
#pragma warning disable 0169
		static Delegate GetDecodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIIIHandler ()
		{
			if (cb_decodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIII == null)
				cb_decodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, IntPtr, IntPtr, IntPtr, int, int>) n_DecodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIII);
			return cb_decodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIII;
		}

		static void n_DecodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIII (IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_result, int width, int height, int mbWidth, IntPtr native_qMatLuma, IntPtr native_qMatChroma, IntPtr native_scan, int pictureType, int chromaType)
		{
			global::Org.Jcodec.Codecs.Prores.ProresDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer data = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_data, JniHandleOwnership.DoNotTransfer);
			int[][] result = (int[][]) JNIEnv.GetArray (native_result, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			int[] qMatLuma = (int[]) JNIEnv.GetArray (native_qMatLuma, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] qMatChroma = (int[]) JNIEnv.GetArray (native_qMatChroma, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] scan = (int[]) JNIEnv.GetArray (native_scan, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.DecodePicture (data, result, width, height, mbWidth, qMatLuma, qMatChroma, scan, pictureType, chromaType);
			if (result != null)
				JNIEnv.CopyArray (result, native_result);
			if (qMatLuma != null)
				JNIEnv.CopyArray (qMatLuma, native_qMatLuma);
			if (qMatChroma != null)
				JNIEnv.CopyArray (qMatChroma, native_qMatChroma);
			if (scan != null)
				JNIEnv.CopyArray (scan, native_scan);
		}
#pragma warning restore 0169

		static IntPtr id_decodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='decodePicture' and count(parameter)=10 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[][]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int[]'] and parameter[7][@type='int[]'] and parameter[8][@type='int[]'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("decodePicture", "(Ljava/nio/ByteBuffer;[[IIII[I[I[III)V", "GetDecodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIIIHandler")]
		protected virtual unsafe void DecodePicture (global::Java.Nio.ByteBuffer data, int[][] result, int width, int height, int mbWidth, int[] qMatLuma, int[] qMatChroma, int[] scan, int pictureType, int chromaType)
		{
			if (id_decodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIII == IntPtr.Zero)
				id_decodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIII = JNIEnv.GetMethodID (class_ref, "decodePicture", "(Ljava/nio/ByteBuffer;[[IIII[I[I[III)V");
			IntPtr native_result = JNIEnv.NewArray (result);
			IntPtr native_qMatLuma = JNIEnv.NewArray (qMatLuma);
			IntPtr native_qMatChroma = JNIEnv.NewArray (qMatChroma);
			IntPtr native_scan = JNIEnv.NewArray (scan);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (data);
				__args [1] = new JValue (native_result);
				__args [2] = new JValue (width);
				__args [3] = new JValue (height);
				__args [4] = new JValue (mbWidth);
				__args [5] = new JValue (native_qMatLuma);
				__args [6] = new JValue (native_qMatChroma);
				__args [7] = new JValue (native_scan);
				__args [8] = new JValue (pictureType);
				__args [9] = new JValue (chromaType);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodePicture_Ljava_nio_ByteBuffer_arrayarrayIIIIarrayIarrayIarrayIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodePicture", "(Ljava/nio/ByteBuffer;[[IIII[I[I[III)V"), __args);
			} finally {
				if (result != null) {
					JNIEnv.CopyArray (native_result, result);
					JNIEnv.DeleteLocalRef (native_result);
				}
				if (qMatLuma != null) {
					JNIEnv.CopyArray (native_qMatLuma, qMatLuma);
					JNIEnv.DeleteLocalRef (native_qMatLuma);
				}
				if (qMatChroma != null) {
					JNIEnv.CopyArray (native_qMatChroma, qMatChroma);
					JNIEnv.DeleteLocalRef (native_qMatChroma);
				}
				if (scan != null) {
					JNIEnv.CopyArray (native_scan, scan);
					JNIEnv.DeleteLocalRef (native_scan);
				}
			}
		}

		static IntPtr id_golumbSign_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='golumbSign' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("golumbSign", "(I)I", "")]
		public static unsafe int GolumbSign (int val)
		{
			if (id_golumbSign_I == IntPtr.Zero)
				id_golumbSign_I = JNIEnv.GetStaticMethodID (class_ref, "golumbSign", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (val);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_golumbSign_I, __args);
			} finally {
			}
		}

		static IntPtr id_golumbToSigned_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='golumbToSigned' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("golumbToSigned", "(I)I", "")]
		public static unsafe int GolumbToSigned (int val)
		{
			if (id_golumbToSigned_I == IntPtr.Zero)
				id_golumbToSigned_I = JNIEnv.GetStaticMethodID (class_ref, "golumbToSigned", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (val);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_golumbToSigned_I, __args);
			} finally {
			}
		}

		static Delegate cb_isProgressive_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetIsProgressive_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_isProgressive_Ljava_nio_ByteBuffer_ == null)
				cb_isProgressive_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsProgressive_Ljava_nio_ByteBuffer_);
			return cb_isProgressive_Ljava_nio_ByteBuffer_;
		}

		static bool n_IsProgressive_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Org.Jcodec.Codecs.Prores.ProresDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer data = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_data, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsProgressive (data);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isProgressive_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='isProgressive' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("isProgressive", "(Ljava/nio/ByteBuffer;)Z", "GetIsProgressive_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe bool IsProgressive (global::Java.Nio.ByteBuffer data)
		{
			if (id_isProgressive_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_isProgressive_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "isProgressive", "(Ljava/nio/ByteBuffer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (data);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isProgressive_Ljava_nio_ByteBuffer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isProgressive", "(Ljava/nio/ByteBuffer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_nZeros_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='nZeros' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("nZeros", "(I)I", "")]
		public static unsafe int NZeros (int check16Bit)
		{
			if (id_nZeros_I == IntPtr.Zero)
				id_nZeros_I = JNIEnv.GetStaticMethodID (class_ref, "nZeros", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (check16Bit);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_nZeros_I, __args);
			} finally {
			}
		}

		static Delegate cb_probe_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetProbe_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_probe_Ljava_nio_ByteBuffer_ == null)
				cb_probe_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Probe_Ljava_nio_ByteBuffer_);
			return cb_probe_Ljava_nio_ByteBuffer_;
		}

		static int n_Probe_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Org.Jcodec.Codecs.Prores.ProresDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer data = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_data, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Probe (data);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_probe_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='probe' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("probe", "(Ljava/nio/ByteBuffer;)I", "GetProbe_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe int Probe (global::Java.Nio.ByteBuffer data)
		{
			if (id_probe_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_probe_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "probe", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (data);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_probe_Ljava_nio_ByteBuffer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "probe", "(Ljava/nio/ByteBuffer;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_putSlice_arrayarrayIIIIarrayIarrayIarrayIIII;
#pragma warning disable 0169
		static Delegate GetPutSlice_arrayarrayIIIIarrayIarrayIarrayIIIIHandler ()
		{
			if (cb_putSlice_arrayarrayIIIIarrayIarrayIarrayIIII == null)
				cb_putSlice_arrayarrayIIIIarrayIarrayIarrayIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, IntPtr, IntPtr, IntPtr, int, int, int>) n_PutSlice_arrayarrayIIIIarrayIarrayIarrayIIII);
			return cb_putSlice_arrayarrayIIIIarrayIarrayIarrayIIII;
		}

		static void n_PutSlice_arrayarrayIIIIarrayIarrayIarrayIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_result, int lumaStride, int mbX, int mbY, IntPtr native_y, IntPtr native_u, IntPtr native_v, int dist, int shift, int chromaType)
		{
			global::Org.Jcodec.Codecs.Prores.ProresDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[][] result = (int[][]) JNIEnv.GetArray (native_result, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			int[] y = (int[]) JNIEnv.GetArray (native_y, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] u = (int[]) JNIEnv.GetArray (native_u, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] v = (int[]) JNIEnv.GetArray (native_v, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.PutSlice (result, lumaStride, mbX, mbY, y, u, v, dist, shift, chromaType);
			if (result != null)
				JNIEnv.CopyArray (result, native_result);
			if (y != null)
				JNIEnv.CopyArray (y, native_y);
			if (u != null)
				JNIEnv.CopyArray (u, native_u);
			if (v != null)
				JNIEnv.CopyArray (v, native_v);
		}
#pragma warning restore 0169

		static IntPtr id_putSlice_arrayarrayIIIIarrayIarrayIarrayIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='putSlice' and count(parameter)=10 and parameter[1][@type='int[][]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int[]'] and parameter[6][@type='int[]'] and parameter[7][@type='int[]'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("putSlice", "([[IIII[I[I[IIII)V", "GetPutSlice_arrayarrayIIIIarrayIarrayIarrayIIIIHandler")]
		protected virtual unsafe void PutSlice (int[][] result, int lumaStride, int mbX, int mbY, int[] y, int[] u, int[] v, int dist, int shift, int chromaType)
		{
			if (id_putSlice_arrayarrayIIIIarrayIarrayIarrayIIII == IntPtr.Zero)
				id_putSlice_arrayarrayIIIIarrayIarrayIarrayIIII = JNIEnv.GetMethodID (class_ref, "putSlice", "([[IIII[I[I[IIII)V");
			IntPtr native_result = JNIEnv.NewArray (result);
			IntPtr native_y = JNIEnv.NewArray (y);
			IntPtr native_u = JNIEnv.NewArray (u);
			IntPtr native_v = JNIEnv.NewArray (v);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_result);
				__args [1] = new JValue (lumaStride);
				__args [2] = new JValue (mbX);
				__args [3] = new JValue (mbY);
				__args [4] = new JValue (native_y);
				__args [5] = new JValue (native_u);
				__args [6] = new JValue (native_v);
				__args [7] = new JValue (dist);
				__args [8] = new JValue (shift);
				__args [9] = new JValue (chromaType);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putSlice_arrayarrayIIIIarrayIarrayIarrayIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putSlice", "([[IIII[I[I[IIII)V"), __args);
			} finally {
				if (result != null) {
					JNIEnv.CopyArray (native_result, result);
					JNIEnv.DeleteLocalRef (native_result);
				}
				if (y != null) {
					JNIEnv.CopyArray (native_y, y);
					JNIEnv.DeleteLocalRef (native_y);
				}
				if (u != null) {
					JNIEnv.CopyArray (native_u, u);
					JNIEnv.DeleteLocalRef (native_u);
				}
				if (v != null) {
					JNIEnv.CopyArray (native_v, v);
					JNIEnv.DeleteLocalRef (native_v);
				}
			}
		}

		static IntPtr id_readACCoeffs_Lorg_jcodec_common_io_BitReader_arrayIarrayIIarrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='readACCoeffs' and count(parameter)=7 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='int'] and parameter[5][@type='int[]'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("readACCoeffs", "(Lorg/jcodec/common/io/BitReader;[I[II[III)V", "")]
		protected static unsafe void ReadACCoeffs (global::Org.Jcodec.Common.IO.BitReader bits, int[] qMat, int[] @out, int blocksPerSlice, int[] scan, int max, int log2blkSize)
		{
			if (id_readACCoeffs_Lorg_jcodec_common_io_BitReader_arrayIarrayIIarrayIII == IntPtr.Zero)
				id_readACCoeffs_Lorg_jcodec_common_io_BitReader_arrayIarrayIIarrayIII = JNIEnv.GetStaticMethodID (class_ref, "readACCoeffs", "(Lorg/jcodec/common/io/BitReader;[I[II[III)V");
			IntPtr native_qMat = JNIEnv.NewArray (qMat);
			IntPtr native__out = JNIEnv.NewArray (@out);
			IntPtr native_scan = JNIEnv.NewArray (scan);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (bits);
				__args [1] = new JValue (native_qMat);
				__args [2] = new JValue (native__out);
				__args [3] = new JValue (blocksPerSlice);
				__args [4] = new JValue (native_scan);
				__args [5] = new JValue (max);
				__args [6] = new JValue (log2blkSize);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_readACCoeffs_Lorg_jcodec_common_io_BitReader_arrayIarrayIIarrayIII, __args);
			} finally {
				if (qMat != null) {
					JNIEnv.CopyArray (native_qMat, qMat);
					JNIEnv.DeleteLocalRef (native_qMat);
				}
				if (@out != null) {
					JNIEnv.CopyArray (native__out, @out);
					JNIEnv.DeleteLocalRef (native__out);
				}
				if (scan != null) {
					JNIEnv.CopyArray (native_scan, scan);
					JNIEnv.DeleteLocalRef (native_scan);
				}
			}
		}

		static IntPtr id_readCodeword_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_codecs_prores_Codebook_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='readCodeword' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='org.jcodec.codecs.prores.Codebook']]"
		[Register ("readCodeword", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/codecs/prores/Codebook;)I", "")]
		public static unsafe int ReadCodeword (global::Org.Jcodec.Common.IO.BitReader reader, global::Org.Jcodec.Codecs.Prores.Codebook codebook)
		{
			if (id_readCodeword_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_codecs_prores_Codebook_ == IntPtr.Zero)
				id_readCodeword_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_codecs_prores_Codebook_ = JNIEnv.GetStaticMethodID (class_ref, "readCodeword", "(Lorg/jcodec/common/io/BitReader;Lorg/jcodec/codecs/prores/Codebook;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (reader);
				__args [1] = new JValue (codebook);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readCodeword_Lorg_jcodec_common_io_BitReader_Lorg_jcodec_codecs_prores_Codebook_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readDCCoeffs_Lorg_jcodec_common_io_BitReader_arrayIarrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='readDCCoeffs' and count(parameter)=5 and parameter[1][@type='org.jcodec.common.io.BitReader'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("readDCCoeffs", "(Lorg/jcodec/common/io/BitReader;[I[III)V", "")]
		public static unsafe void ReadDCCoeffs (global::Org.Jcodec.Common.IO.BitReader bits, int[] qMat, int[] @out, int blocksPerSlice, int blkSize)
		{
			if (id_readDCCoeffs_Lorg_jcodec_common_io_BitReader_arrayIarrayIII == IntPtr.Zero)
				id_readDCCoeffs_Lorg_jcodec_common_io_BitReader_arrayIarrayIII = JNIEnv.GetStaticMethodID (class_ref, "readDCCoeffs", "(Lorg/jcodec/common/io/BitReader;[I[III)V");
			IntPtr native_qMat = JNIEnv.NewArray (qMat);
			IntPtr native__out = JNIEnv.NewArray (@out);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (bits);
				__args [1] = new JValue (native_qMat);
				__args [2] = new JValue (native__out);
				__args [3] = new JValue (blocksPerSlice);
				__args [4] = new JValue (blkSize);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_readDCCoeffs_Lorg_jcodec_common_io_BitReader_arrayIarrayIII, __args);
			} finally {
				if (qMat != null) {
					JNIEnv.CopyArray (native_qMat, qMat);
					JNIEnv.DeleteLocalRef (native_qMat);
				}
				if (@out != null) {
					JNIEnv.CopyArray (native__out, @out);
					JNIEnv.DeleteLocalRef (native__out);
				}
			}
		}

		static IntPtr id_readFrameHeader_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='readFrameHeader' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readFrameHeader", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/prores/ProresConsts$FrameHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Prores.ProresConsts.FrameHeader ReadFrameHeader (global::Java.Nio.ByteBuffer inp)
		{
			if (id_readFrameHeader_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readFrameHeader_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "readFrameHeader", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/prores/ProresConsts$FrameHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (inp);
				global::Org.Jcodec.Codecs.Prores.ProresConsts.FrameHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresConsts.FrameHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readFrameHeader_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readPictureHeader_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='readPictureHeader' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readPictureHeader", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/prores/ProresConsts$PictureHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Prores.ProresConsts.PictureHeader ReadPictureHeader (global::Java.Nio.ByteBuffer inp)
		{
			if (id_readPictureHeader_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readPictureHeader_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "readPictureHeader", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/prores/ProresConsts$PictureHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (inp);
				global::Org.Jcodec.Codecs.Prores.ProresConsts.PictureHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresConsts.PictureHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readPictureHeader_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_scaleMat_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresDecoder']/method[@name='scaleMat' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("scaleMat", "([II)[I", "")]
		public static unsafe int[] ScaleMat (int[] qMatLuma, int qScale)
		{
			if (id_scaleMat_arrayII == IntPtr.Zero)
				id_scaleMat_arrayII = JNIEnv.GetStaticMethodID (class_ref, "scaleMat", "([II)[I");
			IntPtr native_qMatLuma = JNIEnv.NewArray (qMatLuma);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_qMatLuma);
				__args [1] = new JValue (qScale);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_scaleMat_arrayII, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (qMatLuma != null) {
					JNIEnv.CopyArray (native_qMatLuma, qMatLuma);
					JNIEnv.DeleteLocalRef (native_qMatLuma);
				}
			}
		}

	}
}
