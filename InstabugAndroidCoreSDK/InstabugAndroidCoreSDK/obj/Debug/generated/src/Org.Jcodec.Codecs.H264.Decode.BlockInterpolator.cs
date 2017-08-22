using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='BlockInterpolator']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/BlockInterpolator", DoNotGenerateAcw=true)]
	public partial class BlockInterpolator : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/BlockInterpolator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockInterpolator); }
		}

		protected BlockInterpolator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='BlockInterpolator']/constructor[@name='BlockInterpolator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlockInterpolator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BlockInterpolator)) {
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

		static IntPtr id_getBlockChroma_arrayIIIarrayIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='BlockInterpolator']/method[@name='getBlockChroma' and count(parameter)=10 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("getBlockChroma", "([III[IIIIIII)V", "")]
		public static unsafe void GetBlockChroma (int[] pels, int picW, int picH, int[] blk, int blkOff, int blkStride, int x, int y, int blkW, int blkH)
		{
			if (id_getBlockChroma_arrayIIIarrayIIIIIII == IntPtr.Zero)
				id_getBlockChroma_arrayIIIarrayIIIIIII = JNIEnv.GetStaticMethodID (class_ref, "getBlockChroma", "([III[IIIIIII)V");
			IntPtr native_pels = JNIEnv.NewArray (pels);
			IntPtr native_blk = JNIEnv.NewArray (blk);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_pels);
				__args [1] = new JValue (picW);
				__args [2] = new JValue (picH);
				__args [3] = new JValue (native_blk);
				__args [4] = new JValue (blkOff);
				__args [5] = new JValue (blkStride);
				__args [6] = new JValue (x);
				__args [7] = new JValue (y);
				__args [8] = new JValue (blkW);
				__args [9] = new JValue (blkH);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getBlockChroma_arrayIIIarrayIIIIIII, __args);
			} finally {
				if (pels != null) {
					JNIEnv.CopyArray (native_pels, pels);
					JNIEnv.DeleteLocalRef (native_pels);
				}
				if (blk != null) {
					JNIEnv.CopyArray (native_blk, blk);
					JNIEnv.DeleteLocalRef (native_blk);
				}
			}
		}

		static IntPtr id_getBlockLuma_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_IIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='BlockInterpolator']/method[@name='getBlockLuma' and count(parameter)=7 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='org.jcodec.common.model.Picture'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("getBlockLuma", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;IIIII)V", "")]
		public static unsafe void GetBlockLuma (global::Org.Jcodec.Common.Model.Picture pic, global::Org.Jcodec.Common.Model.Picture @out, int off, int x, int y, int w, int h)
		{
			if (id_getBlockLuma_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_IIIII == IntPtr.Zero)
				id_getBlockLuma_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_IIIII = JNIEnv.GetStaticMethodID (class_ref, "getBlockLuma", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;IIIII)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (pic);
				__args [1] = new JValue (@out);
				__args [2] = new JValue (off);
				__args [3] = new JValue (x);
				__args [4] = new JValue (y);
				__args [5] = new JValue (w);
				__args [6] = new JValue (h);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getBlockLuma_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_IIIII, __args);
			} finally {
			}
		}

	}
}
