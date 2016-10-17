using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Common.Biari {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQConst']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/MQConst", DoNotGenerateAcw=true)]
	public partial class MQConst : global::Java.Lang.Object {


		static IntPtr mpsSwitch_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQConst']/field[@name='mpsSwitch']"
		[Register ("mpsSwitch")]
		public static IList<int> MpsSwitch {
			get {
				if (mpsSwitch_jfieldId == IntPtr.Zero)
					mpsSwitch_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mpsSwitch", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, mpsSwitch_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr pLps_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQConst']/field[@name='pLps']"
		[Register ("pLps")]
		public static IList<int> PLps {
			get {
				if (pLps_jfieldId == IntPtr.Zero)
					pLps_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pLps", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, pLps_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr transitLPS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQConst']/field[@name='transitLPS']"
		[Register ("transitLPS")]
		public static IList<int> TransitLPS {
			get {
				if (transitLPS_jfieldId == IntPtr.Zero)
					transitLPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "transitLPS", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, transitLPS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr transitMPS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQConst']/field[@name='transitMPS']"
		[Register ("transitMPS")]
		public static IList<int> TransitMPS {
			get {
				if (transitMPS_jfieldId == IntPtr.Zero)
					transitMPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "transitMPS", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, transitMPS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/MQConst", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MQConst); }
		}

		protected MQConst (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MQConst']/constructor[@name='MQConst' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MQConst ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MQConst)) {
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
