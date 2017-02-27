using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vpx {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXConst']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vpx/VPXConst", DoNotGenerateAcw=true)]
	public partial class VPXConst : global::Java.Lang.Object {


		static IntPtr ac_qlookup_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXConst']/field[@name='ac_qlookup']"
		[Register ("ac_qlookup")]
		public static IList<int> AcQlookup {
			get {
				if (ac_qlookup_jfieldId == IntPtr.Zero)
					ac_qlookup_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ac_qlookup", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ac_qlookup_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr dc_qlookup_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXConst']/field[@name='dc_qlookup']"
		[Register ("dc_qlookup")]
		public static IList<int> DcQlookup {
			get {
				if (dc_qlookup_jfieldId == IntPtr.Zero)
					dc_qlookup_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "dc_qlookup", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, dc_qlookup_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr probCoeffExtCat5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXConst']/field[@name='probCoeffExtCat5']"
		[Register ("probCoeffExtCat5")]
		public static IList<int> ProbCoeffExtCat5 {
			get {
				if (probCoeffExtCat5_jfieldId == IntPtr.Zero)
					probCoeffExtCat5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "probCoeffExtCat5", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, probCoeffExtCat5_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr probCoeffExtCat6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXConst']/field[@name='probCoeffExtCat6']"
		[Register ("probCoeffExtCat6")]
		public static IList<int> ProbCoeffExtCat6 {
			get {
				if (probCoeffExtCat6_jfieldId == IntPtr.Zero)
					probCoeffExtCat6_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "probCoeffExtCat6", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, probCoeffExtCat6_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr tokenDefaultBinProbs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXConst']/field[@name='tokenDefaultBinProbs']"
		[Register ("tokenDefaultBinProbs")]
		public static IList<int[][][]> TokenDefaultBinProbs {
			get {
				if (tokenDefaultBinProbs_jfieldId == IntPtr.Zero)
					tokenDefaultBinProbs_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "tokenDefaultBinProbs", "[[[[I");
				return global::Android.Runtime.JavaArray<int[][][]>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, tokenDefaultBinProbs_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr tokenProbUpdateFlagProbs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXConst']/field[@name='tokenProbUpdateFlagProbs']"
		[Register ("tokenProbUpdateFlagProbs")]
		public static IList<int[][][]> TokenProbUpdateFlagProbs {
			get {
				if (tokenProbUpdateFlagProbs_jfieldId == IntPtr.Zero)
					tokenProbUpdateFlagProbs_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "tokenProbUpdateFlagProbs", "[[[[I");
				return global::Android.Runtime.JavaArray<int[][][]>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, tokenProbUpdateFlagProbs_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tokenProbUpdateFlagProbs_jfieldId == IntPtr.Zero)
					tokenProbUpdateFlagProbs_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "tokenProbUpdateFlagProbs", "[[[[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int[][][]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, tokenProbUpdateFlagProbs_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vp8Norm_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXConst']/field[@name='vp8Norm']"
		[Register ("vp8Norm")]
		public static IList<int> Vp8Norm {
			get {
				if (vp8Norm_jfieldId == IntPtr.Zero)
					vp8Norm_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vp8Norm", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, vp8Norm_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr zigzag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXConst']/field[@name='zigzag']"
		[Register ("zigzag")]
		public static IList<int> Zigzag {
			get {
				if (zigzag_jfieldId == IntPtr.Zero)
					zigzag_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "zigzag", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, zigzag_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vpx/VPXConst", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VPXConst); }
		}

		protected VPXConst (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXConst']/constructor[@name='VPXConst' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VPXConst ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VPXConst)) {
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
