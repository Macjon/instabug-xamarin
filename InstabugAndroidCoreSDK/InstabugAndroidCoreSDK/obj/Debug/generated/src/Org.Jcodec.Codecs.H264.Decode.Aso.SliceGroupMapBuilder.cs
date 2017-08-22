using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode.Aso {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='SliceGroupMapBuilder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/aso/SliceGroupMapBuilder", DoNotGenerateAcw=true)]
	public partial class SliceGroupMapBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/aso/SliceGroupMapBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SliceGroupMapBuilder); }
		}

		protected SliceGroupMapBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='SliceGroupMapBuilder']/constructor[@name='SliceGroupMapBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SliceGroupMapBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SliceGroupMapBuilder)) {
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

		static IntPtr id_buildBoxOutMap_IIZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='SliceGroupMapBuilder']/method[@name='buildBoxOutMap' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("buildBoxOutMap", "(IIZI)[I", "")]
		public static unsafe int[] BuildBoxOutMap (int picWidthInMbs, int picHeightInMbs, bool changeDirection, int numberOfMbsInBox)
		{
			if (id_buildBoxOutMap_IIZI == IntPtr.Zero)
				id_buildBoxOutMap_IIZI = JNIEnv.GetStaticMethodID (class_ref, "buildBoxOutMap", "(IIZI)[I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (picWidthInMbs);
				__args [1] = new JValue (picHeightInMbs);
				__args [2] = new JValue (changeDirection);
				__args [3] = new JValue (numberOfMbsInBox);
				return (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildBoxOutMap_IIZI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_buildDispersedMap_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='SliceGroupMapBuilder']/method[@name='buildDispersedMap' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("buildDispersedMap", "(III)[I", "")]
		public static unsafe int[] BuildDispersedMap (int picWidthInMbs, int picHeightInMbs, int numSliceGroups)
		{
			if (id_buildDispersedMap_III == IntPtr.Zero)
				id_buildDispersedMap_III = JNIEnv.GetStaticMethodID (class_ref, "buildDispersedMap", "(III)[I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (picWidthInMbs);
				__args [1] = new JValue (picHeightInMbs);
				__args [2] = new JValue (numSliceGroups);
				return (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildDispersedMap_III, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_buildForegroundMap_IIIarrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='SliceGroupMapBuilder']/method[@name='buildForegroundMap' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int[]']]"
		[Register ("buildForegroundMap", "(III[I[I)[I", "")]
		public static unsafe int[] BuildForegroundMap (int picWidthInMbs, int picHeightInMbs, int numSliceGroups, int[] topLeftAddr, int[] bottomRightAddr)
		{
			if (id_buildForegroundMap_IIIarrayIarrayI == IntPtr.Zero)
				id_buildForegroundMap_IIIarrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "buildForegroundMap", "(III[I[I)[I");
			IntPtr native_topLeftAddr = JNIEnv.NewArray (topLeftAddr);
			IntPtr native_bottomRightAddr = JNIEnv.NewArray (bottomRightAddr);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (picWidthInMbs);
				__args [1] = new JValue (picHeightInMbs);
				__args [2] = new JValue (numSliceGroups);
				__args [3] = new JValue (native_topLeftAddr);
				__args [4] = new JValue (native_bottomRightAddr);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildForegroundMap_IIIarrayIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (topLeftAddr != null) {
					JNIEnv.CopyArray (native_topLeftAddr, topLeftAddr);
					JNIEnv.DeleteLocalRef (native_topLeftAddr);
				}
				if (bottomRightAddr != null) {
					JNIEnv.CopyArray (native_bottomRightAddr, bottomRightAddr);
					JNIEnv.DeleteLocalRef (native_bottomRightAddr);
				}
			}
		}

		static IntPtr id_buildInterleavedMap_IIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='SliceGroupMapBuilder']/method[@name='buildInterleavedMap' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("buildInterleavedMap", "(II[I)[I", "")]
		public static unsafe int[] BuildInterleavedMap (int picWidthInMbs, int picHeightInMbs, int[] runLength)
		{
			if (id_buildInterleavedMap_IIarrayI == IntPtr.Zero)
				id_buildInterleavedMap_IIarrayI = JNIEnv.GetStaticMethodID (class_ref, "buildInterleavedMap", "(II[I)[I");
			IntPtr native_runLength = JNIEnv.NewArray (runLength);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (picWidthInMbs);
				__args [1] = new JValue (picHeightInMbs);
				__args [2] = new JValue (native_runLength);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildInterleavedMap_IIarrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (runLength != null) {
					JNIEnv.CopyArray (native_runLength, runLength);
					JNIEnv.DeleteLocalRef (native_runLength);
				}
			}
		}

		static IntPtr id_buildRasterScanMap_IIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='SliceGroupMapBuilder']/method[@name='buildRasterScanMap' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("buildRasterScanMap", "(IIIZ)[I", "")]
		public static unsafe int[] BuildRasterScanMap (int picWidthInMbs, int picHeightInMbs, int sizeOfUpperLeftGroup, bool changeDirection)
		{
			if (id_buildRasterScanMap_IIIZ == IntPtr.Zero)
				id_buildRasterScanMap_IIIZ = JNIEnv.GetStaticMethodID (class_ref, "buildRasterScanMap", "(IIIZ)[I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (picWidthInMbs);
				__args [1] = new JValue (picHeightInMbs);
				__args [2] = new JValue (sizeOfUpperLeftGroup);
				__args [3] = new JValue (changeDirection);
				return (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildRasterScanMap_IIIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_buildWipeMap_IIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='SliceGroupMapBuilder']/method[@name='buildWipeMap' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("buildWipeMap", "(IIIZ)[I", "")]
		public static unsafe int[] BuildWipeMap (int picWidthInMbs, int picHeightInMbs, int sizeOfUpperLeftGroup, bool changeDirection)
		{
			if (id_buildWipeMap_IIIZ == IntPtr.Zero)
				id_buildWipeMap_IIIZ = JNIEnv.GetStaticMethodID (class_ref, "buildWipeMap", "(IIIZ)[I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (picWidthInMbs);
				__args [1] = new JValue (picHeightInMbs);
				__args [2] = new JValue (sizeOfUpperLeftGroup);
				__args [3] = new JValue (changeDirection);
				return (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildWipeMap_IIIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}
}
