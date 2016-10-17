using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Common.Biari {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MConst']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/MConst", DoNotGenerateAcw=true)]
	public partial class MConst : global::Java.Lang.Object {


		static IntPtr rangeLPS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MConst']/field[@name='rangeLPS']"
		[Register ("rangeLPS")]
		public static IList<int[]> RangeLPS {
			get {
				if (rangeLPS_jfieldId == IntPtr.Zero)
					rangeLPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "rangeLPS", "[[I");
				return global::Android.Runtime.JavaArray<int[]>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, rangeLPS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr transitLPS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MConst']/field[@name='transitLPS']"
		[Register ("transitLPS")]
		public static IList<int> TransitLPS {
			get {
				if (transitLPS_jfieldId == IntPtr.Zero)
					transitLPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "transitLPS", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, transitLPS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/MConst", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MConst); }
		}

		protected MConst (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='MConst']/constructor[@name='MConst' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MConst ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MConst)) {
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
