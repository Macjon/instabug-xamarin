using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='QuantMatrixExtension']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/QuantMatrixExtension", DoNotGenerateAcw=true)]
	public partial class QuantMatrixExtension : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {


		static IntPtr chroma_intra_quantiser_matrix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='QuantMatrixExtension']/field[@name='chroma_intra_quantiser_matrix']"
		[Register ("chroma_intra_quantiser_matrix")]
		public IList<int> ChromaIntraQuantiserMatrix {
			get {
				if (chroma_intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					chroma_intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "chroma_intra_quantiser_matrix", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chroma_intra_quantiser_matrix_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chroma_intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					chroma_intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "chroma_intra_quantiser_matrix", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chroma_intra_quantiser_matrix_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr chroma_non_intra_quantiser_matrix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='QuantMatrixExtension']/field[@name='chroma_non_intra_quantiser_matrix']"
		[Register ("chroma_non_intra_quantiser_matrix")]
		public IList<int> ChromaNonIntraQuantiserMatrix {
			get {
				if (chroma_non_intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					chroma_non_intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "chroma_non_intra_quantiser_matrix", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chroma_non_intra_quantiser_matrix_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chroma_non_intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					chroma_non_intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "chroma_non_intra_quantiser_matrix", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chroma_non_intra_quantiser_matrix_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr intra_quantiser_matrix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='QuantMatrixExtension']/field[@name='intra_quantiser_matrix']"
		[Register ("intra_quantiser_matrix")]
		public IList<int> IntraQuantiserMatrix {
			get {
				if (intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "intra_quantiser_matrix", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, intra_quantiser_matrix_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "intra_quantiser_matrix", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, intra_quantiser_matrix_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr non_intra_quantiser_matrix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='QuantMatrixExtension']/field[@name='non_intra_quantiser_matrix']"
		[Register ("non_intra_quantiser_matrix")]
		public IList<int> NonIntraQuantiserMatrix {
			get {
				if (non_intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					non_intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "non_intra_quantiser_matrix", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, non_intra_quantiser_matrix_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (non_intra_quantiser_matrix_jfieldId == IntPtr.Zero)
					non_intra_quantiser_matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "non_intra_quantiser_matrix", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, non_intra_quantiser_matrix_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/QuantMatrixExtension", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuantMatrixExtension); }
		}

		protected QuantMatrixExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='QuantMatrixExtension']/constructor[@name='QuantMatrixExtension' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QuantMatrixExtension ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (QuantMatrixExtension)) {
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

		static IntPtr id_read_Lorg_jcodec_common_io_BitReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='QuantMatrixExtension']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.BitReader']]"
		[Register ("read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/QuantMatrixExtension;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.QuantMatrixExtension Read (global::Org.Jcodec.Common.IO.BitReader @in)
		{
			if (id_read_Lorg_jcodec_common_io_BitReader_ == IntPtr.Zero)
				id_read_Lorg_jcodec_common_io_BitReader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/common/io/BitReader;)Lorg/jcodec/codecs/mpeg12/bitstream/QuantMatrixExtension;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.QuantMatrixExtension __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.QuantMatrixExtension> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_common_io_BitReader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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

		static void n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bb)
		{
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.QuantMatrixExtension __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.QuantMatrixExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer bb = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bb, JniHandleOwnership.DoNotTransfer);
			__this.Write (bb);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='QuantMatrixExtension']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)V", "GetWrite_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Write (global::Java.Nio.ByteBuffer bb)
		{
			if (id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bb);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
