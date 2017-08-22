using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Dct {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT2x2']"
	[global::Android.Runtime.Register ("org/jcodec/common/dct/IDCT2x2", DoNotGenerateAcw=true)]
	public partial class IDCT2x2 : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/dct/IDCT2x2", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDCT2x2); }
		}

		protected IDCT2x2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT2x2']/constructor[@name='IDCT2x2' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IDCT2x2 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IDCT2x2)) {
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

		static IntPtr id_idct_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT2x2']/method[@name='idct' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("idct", "([II)V", "")]
		public static unsafe void Idct (int[] blk, int off)
		{
			if (id_idct_arrayII == IntPtr.Zero)
				id_idct_arrayII = JNIEnv.GetStaticMethodID (class_ref, "idct", "([II)V");
			IntPtr native_blk = JNIEnv.NewArray (blk);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_blk);
				__args [1] = new JValue (off);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idct_arrayII, __args);
			} finally {
				if (blk != null) {
					JNIEnv.CopyArray (native_blk, blk);
					JNIEnv.DeleteLocalRef (native_blk);
				}
			}
		}

	}
}
