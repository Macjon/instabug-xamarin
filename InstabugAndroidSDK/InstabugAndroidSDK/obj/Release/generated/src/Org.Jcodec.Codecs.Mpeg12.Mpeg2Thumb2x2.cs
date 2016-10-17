using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='Mpeg2Thumb2x2']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/Mpeg2Thumb2x2", DoNotGenerateAcw=true)]
	public partial class Mpeg2Thumb2x2 : global::Org.Jcodec.Codecs.Mpeg12.MPEGDecoder {


		static IntPtr BLOCK_POS_X_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='Mpeg2Thumb2x2']/field[@name='BLOCK_POS_X']"
		[Register ("BLOCK_POS_X")]
		public static IList<int> BlockPosX {
			get {
				if (BLOCK_POS_X_jfieldId == IntPtr.Zero)
					BLOCK_POS_X_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_POS_X", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, BLOCK_POS_X_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BLOCK_POS_X_jfieldId == IntPtr.Zero)
					BLOCK_POS_X_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_POS_X", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, BLOCK_POS_X_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr BLOCK_POS_Y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='Mpeg2Thumb2x2']/field[@name='BLOCK_POS_Y']"
		[Register ("BLOCK_POS_Y")]
		public static IList<int> BlockPosY {
			get {
				if (BLOCK_POS_Y_jfieldId == IntPtr.Zero)
					BLOCK_POS_Y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_POS_Y", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, BLOCK_POS_Y_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BLOCK_POS_Y_jfieldId == IntPtr.Zero)
					BLOCK_POS_Y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCK_POS_Y", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, BLOCK_POS_Y_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr scan2x2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='Mpeg2Thumb2x2']/field[@name='scan2x2']"
		[Register ("scan2x2")]
		public static IList<int[]> Scan2x2 {
			get {
				if (scan2x2_jfieldId == IntPtr.Zero)
					scan2x2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "scan2x2", "[[I");
				return global::Android.Runtime.JavaArray<int[]>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, scan2x2_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (scan2x2_jfieldId == IntPtr.Zero)
					scan2x2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "scan2x2", "[[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int[]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, scan2x2_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/Mpeg2Thumb2x2", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Mpeg2Thumb2x2); }
		}

		protected Mpeg2Thumb2x2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='Mpeg2Thumb2x2']/constructor[@name='Mpeg2Thumb2x2' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Mpeg2Thumb2x2 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Mpeg2Thumb2x2)) {
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

	}
}
