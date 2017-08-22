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
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
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
		public static unsafe void Coeff (int[] block, int ind, int level)
		{
			if (id_coeff_arrayIII == IntPtr.Zero)
				id_coeff_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "coeff", "([III)V");
			IntPtr native_block = JNIEnv.NewArray (block);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_block);
				__args [1] = new JValue (ind);
				__args [2] = new JValue (level);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_coeff_arrayIII, __args);
			} finally {
				if (block != null) {
					JNIEnv.CopyArray (native_block, block);
					JNIEnv.DeleteLocalRef (native_block);
				}
			}
		}

		static IntPtr id_finish_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SparseIDCT']/method[@name='finish' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("finish", "([I)V", "")]
		public static unsafe void Finish (int[] block)
		{
			if (id_finish_arrayI == IntPtr.Zero)
				id_finish_arrayI = JNIEnv.GetStaticMethodID (class_ref, "finish", "([I)V");
			IntPtr native_block = JNIEnv.NewArray (block);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_block);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_finish_arrayI, __args);
			} finally {
				if (block != null) {
					JNIEnv.CopyArray (native_block, block);
					JNIEnv.DeleteLocalRef (native_block);
				}
			}
		}

		static IntPtr id_start_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SparseIDCT']/method[@name='start' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("start", "([II)V", "")]
		public static unsafe void Start (int[] block, int dc)
		{
			if (id_start_arrayII == IntPtr.Zero)
				id_start_arrayII = JNIEnv.GetStaticMethodID (class_ref, "start", "([II)V");
			IntPtr native_block = JNIEnv.NewArray (block);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_block);
				__args [1] = new JValue (dc);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_arrayII, __args);
			} finally {
				if (block != null) {
					JNIEnv.CopyArray (native_block, block);
					JNIEnv.DeleteLocalRef (native_block);
				}
			}
		}

	}
}
