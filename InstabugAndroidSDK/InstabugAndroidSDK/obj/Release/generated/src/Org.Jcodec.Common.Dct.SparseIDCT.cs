using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Dct {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SparseIDCT']"
	[global::Android.Runtime.Register ("org/jcodec/common/dct/SparseIDCT", DoNotGenerateAcw=true)]
	public partial class SparseIDCT : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SparseIDCT']/field[@name='DC_SHIFT']"
		[Register ("DC_SHIFT")]
		public const int DcShift = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SparseIDCT']/field[@name='PRECISION']"
		[Register ("PRECISION")]
		public const int Precision = (int) 13;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/dct/SparseIDCT", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SparseIDCT); }
		}

		protected SparseIDCT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SparseIDCT']/constructor[@name='SparseIDCT' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SparseIDCT ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SparseIDCT)) {
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

		static IntPtr id_coeff_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SparseIDCT']/method[@name='coeff' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("coeff", "([III)V", "")]
		public static unsafe void Coeff (int[] p0, int p1, int p2)
		{
			if (id_coeff_arrayIII == IntPtr.Zero)
				id_coeff_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "coeff", "([III)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_coeff_arrayIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_finish_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SparseIDCT']/method[@name='finish' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("finish", "([I)V", "")]
		public static unsafe void Finish (int[] p0)
		{
			if (id_finish_arrayI == IntPtr.Zero)
				id_finish_arrayI = JNIEnv.GetStaticMethodID (class_ref, "finish", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_finish_arrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_start_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SparseIDCT']/method[@name='start' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("start", "([II)V", "")]
		public static unsafe void Start (int[] p0, int p1)
		{
			if (id_start_arrayII == IntPtr.Zero)
				id_start_arrayII = JNIEnv.GetStaticMethodID (class_ref, "start", "([II)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_arrayII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
