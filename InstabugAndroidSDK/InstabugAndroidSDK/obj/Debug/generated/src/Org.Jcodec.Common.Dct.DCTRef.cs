using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Dct {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='DCTRef']"
	[global::Android.Runtime.Register ("org/jcodec/common/dct/DCTRef", DoNotGenerateAcw=true)]
	public partial class DCTRef : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/dct/DCTRef", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DCTRef); }
		}

		protected DCTRef (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='DCTRef']/constructor[@name='DCTRef' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DCTRef ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DCTRef)) {
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

		static IntPtr id_fdct_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='DCTRef']/method[@name='fdct' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("fdct", "([II)V", "")]
		public static unsafe void Fdct (int[] p0, int p1)
		{
			if (id_fdct_arrayII == IntPtr.Zero)
				id_fdct_arrayII = JNIEnv.GetStaticMethodID (class_ref, "fdct", "([II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fdct_arrayII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_idct_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='DCTRef']/method[@name='idct' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("idct", "([II)V", "")]
		public static unsafe void Idct (int[] p0, int p1)
		{
			if (id_idct_arrayII == IntPtr.Zero)
				id_idct_arrayII = JNIEnv.GetStaticMethodID (class_ref, "idct", "([II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idct_arrayII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
