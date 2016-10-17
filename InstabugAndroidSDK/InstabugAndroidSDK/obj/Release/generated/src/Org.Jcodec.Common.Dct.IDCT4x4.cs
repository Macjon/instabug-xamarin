using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Dct {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']"
	[global::Android.Runtime.Register ("org/jcodec/common/dct/IDCT4x4", DoNotGenerateAcw=true)]
	public partial class IDCT4x4 : global::Java.Lang.Object {


		static IntPtr C1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/field[@name='C1']"
		[Register ("C1")]
		public static int C1 {
			get {
				if (C1_jfieldId == IntPtr.Zero)
					C1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "C1", "I");
				return JNIEnv.GetStaticIntField (class_ref, C1_jfieldId);
			}
		}

		static IntPtr C2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/field[@name='C2']"
		[Register ("C2")]
		public static int C2 {
			get {
				if (C2_jfieldId == IntPtr.Zero)
					C2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "C2", "I");
				return JNIEnv.GetStaticIntField (class_ref, C2_jfieldId);
			}
		}

		static IntPtr C3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/field[@name='C3']"
		[Register ("C3")]
		public static int C3 {
			get {
				if (C3_jfieldId == IntPtr.Zero)
					C3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "C3", "I");
				return JNIEnv.GetStaticIntField (class_ref, C3_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/field[@name='CN_SHIFT']"
		[Register ("CN_SHIFT")]
		public const int CnShift = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/field[@name='C_SHIFT']"
		[Register ("C_SHIFT")]
		public const int CShift = (int) 18;

		static IntPtr R1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/field[@name='R1']"
		[Register ("R1")]
		public static int R1 {
			get {
				if (R1_jfieldId == IntPtr.Zero)
					R1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "R1", "I");
				return JNIEnv.GetStaticIntField (class_ref, R1_jfieldId);
			}
		}

		static IntPtr R2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/field[@name='R2']"
		[Register ("R2")]
		public static int R2 {
			get {
				if (R2_jfieldId == IntPtr.Zero)
					R2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "R2", "I");
				return JNIEnv.GetStaticIntField (class_ref, R2_jfieldId);
			}
		}

		static IntPtr R3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/field[@name='R3']"
		[Register ("R3")]
		public static int R3 {
			get {
				if (R3_jfieldId == IntPtr.Zero)
					R3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "R3", "I");
				return JNIEnv.GetStaticIntField (class_ref, R3_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/field[@name='RN_SHIFT']"
		[Register ("RN_SHIFT")]
		public const int RnShift = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/field[@name='R_SHIFT']"
		[Register ("R_SHIFT")]
		public const int RShift = (int) 11;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/dct/IDCT4x4", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDCT4x4); }
		}

		protected IDCT4x4 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/constructor[@name='IDCT4x4' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IDCT4x4 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (IDCT4x4)) {
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

		static IntPtr id_C_FIX_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/method[@name='C_FIX' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("C_FIX", "(D)I", "")]
		public static unsafe int C_FIX (double p0)
		{
			if (id_C_FIX_D == IntPtr.Zero)
				id_C_FIX_D = JNIEnv.GetStaticMethodID (class_ref, "C_FIX", "(D)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_C_FIX_D, __args);
			} finally {
			}
		}

		static IntPtr id_R_FIX_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/method[@name='R_FIX' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("R_FIX", "(D)I", "")]
		public static unsafe int R_FIX (double p0)
		{
			if (id_R_FIX_D == IntPtr.Zero)
				id_R_FIX_D = JNIEnv.GetStaticMethodID (class_ref, "R_FIX", "(D)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_R_FIX_D, __args);
			} finally {
			}
		}

		static IntPtr id_idct_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='IDCT4x4']/method[@name='idct' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
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
