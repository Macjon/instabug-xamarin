using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Prores {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresToThumb4x4']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/prores/ProresToThumb4x4", DoNotGenerateAcw=true)]
	public partial class ProresToThumb4x4 : global::Org.Jcodec.Codecs.Prores.ProresDecoder {


		static IntPtr interlaced_scan_4x4_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresToThumb4x4']/field[@name='interlaced_scan_4x4']"
		[Register ("interlaced_scan_4x4")]
		public static IList<int> InterlacedScan4x4 {
			get {
				if (interlaced_scan_4x4_jfieldId == IntPtr.Zero)
					interlaced_scan_4x4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "interlaced_scan_4x4", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, interlaced_scan_4x4_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (interlaced_scan_4x4_jfieldId == IntPtr.Zero)
					interlaced_scan_4x4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "interlaced_scan_4x4", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, interlaced_scan_4x4_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr progressive_scan_4x4_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresToThumb4x4']/field[@name='progressive_scan_4x4']"
		[Register ("progressive_scan_4x4")]
		public static IList<int> ProgressiveScan4x4 {
			get {
				if (progressive_scan_4x4_jfieldId == IntPtr.Zero)
					progressive_scan_4x4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "progressive_scan_4x4", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, progressive_scan_4x4_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (progressive_scan_4x4_jfieldId == IntPtr.Zero)
					progressive_scan_4x4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "progressive_scan_4x4", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, progressive_scan_4x4_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/prores/ProresToThumb4x4", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProresToThumb4x4); }
		}

		protected ProresToThumb4x4 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresToThumb4x4']/constructor[@name='ProresToThumb4x4' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProresToThumb4x4 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ProresToThumb4x4)) {
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

	}
}
