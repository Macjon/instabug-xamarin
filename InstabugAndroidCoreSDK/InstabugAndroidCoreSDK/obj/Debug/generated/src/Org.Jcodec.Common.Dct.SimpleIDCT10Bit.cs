using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Dct {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']"
	[global::Android.Runtime.Register ("org/jcodec/common/dct/SimpleIDCT10Bit", DoNotGenerateAcw=true)]
	public partial class SimpleIDCT10Bit : global::Java.Lang.Object {


		static IntPtr COL_SHIFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']/field[@name='COL_SHIFT']"
		[Register ("COL_SHIFT")]
		public static int ColShift {
			get {
				if (COL_SHIFT_jfieldId == IntPtr.Zero)
					COL_SHIFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COL_SHIFT", "I");
				return JNIEnv.GetStaticIntField (class_ref, COL_SHIFT_jfieldId);
			}
			set {
				if (COL_SHIFT_jfieldId == IntPtr.Zero)
					COL_SHIFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COL_SHIFT", "I");
				try {
					JNIEnv.SetStaticField (class_ref, COL_SHIFT_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr ROW_SHIFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']/field[@name='ROW_SHIFT']"
		[Register ("ROW_SHIFT")]
		public static int RowShift {
			get {
				if (ROW_SHIFT_jfieldId == IntPtr.Zero)
					ROW_SHIFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROW_SHIFT", "I");
				return JNIEnv.GetStaticIntField (class_ref, ROW_SHIFT_jfieldId);
			}
			set {
				if (ROW_SHIFT_jfieldId == IntPtr.Zero)
					ROW_SHIFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROW_SHIFT", "I");
				try {
					JNIEnv.SetStaticField (class_ref, ROW_SHIFT_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr W1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']/field[@name='W1']"
		[Register ("W1")]
		public static int W1 {
			get {
				if (W1_jfieldId == IntPtr.Zero)
					W1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W1", "I");
				return JNIEnv.GetStaticIntField (class_ref, W1_jfieldId);
			}
			set {
				if (W1_jfieldId == IntPtr.Zero)
					W1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W1", "I");
				try {
					JNIEnv.SetStaticField (class_ref, W1_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr W2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']/field[@name='W2']"
		[Register ("W2")]
		public static int W2 {
			get {
				if (W2_jfieldId == IntPtr.Zero)
					W2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W2", "I");
				return JNIEnv.GetStaticIntField (class_ref, W2_jfieldId);
			}
			set {
				if (W2_jfieldId == IntPtr.Zero)
					W2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W2", "I");
				try {
					JNIEnv.SetStaticField (class_ref, W2_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr W3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']/field[@name='W3']"
		[Register ("W3")]
		public static int W3 {
			get {
				if (W3_jfieldId == IntPtr.Zero)
					W3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W3", "I");
				return JNIEnv.GetStaticIntField (class_ref, W3_jfieldId);
			}
			set {
				if (W3_jfieldId == IntPtr.Zero)
					W3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W3", "I");
				try {
					JNIEnv.SetStaticField (class_ref, W3_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr W4_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']/field[@name='W4']"
		[Register ("W4")]
		public static int W4 {
			get {
				if (W4_jfieldId == IntPtr.Zero)
					W4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W4", "I");
				return JNIEnv.GetStaticIntField (class_ref, W4_jfieldId);
			}
			set {
				if (W4_jfieldId == IntPtr.Zero)
					W4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W4", "I");
				try {
					JNIEnv.SetStaticField (class_ref, W4_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr W5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']/field[@name='W5']"
		[Register ("W5")]
		public static int W5 {
			get {
				if (W5_jfieldId == IntPtr.Zero)
					W5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W5", "I");
				return JNIEnv.GetStaticIntField (class_ref, W5_jfieldId);
			}
			set {
				if (W5_jfieldId == IntPtr.Zero)
					W5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W5", "I");
				try {
					JNIEnv.SetStaticField (class_ref, W5_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr W6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']/field[@name='W6']"
		[Register ("W6")]
		public static int W6 {
			get {
				if (W6_jfieldId == IntPtr.Zero)
					W6_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W6", "I");
				return JNIEnv.GetStaticIntField (class_ref, W6_jfieldId);
			}
			set {
				if (W6_jfieldId == IntPtr.Zero)
					W6_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W6", "I");
				try {
					JNIEnv.SetStaticField (class_ref, W6_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr W7_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']/field[@name='W7']"
		[Register ("W7")]
		public static int W7 {
			get {
				if (W7_jfieldId == IntPtr.Zero)
					W7_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W7", "I");
				return JNIEnv.GetStaticIntField (class_ref, W7_jfieldId);
			}
			set {
				if (W7_jfieldId == IntPtr.Zero)
					W7_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "W7", "I");
				try {
					JNIEnv.SetStaticField (class_ref, W7_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/dct/SimpleIDCT10Bit", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleIDCT10Bit); }
		}

		protected SimpleIDCT10Bit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']/constructor[@name='SimpleIDCT10Bit' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleIDCT10Bit ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SimpleIDCT10Bit)) {
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

		static IntPtr id_idct10_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='SimpleIDCT10Bit']/method[@name='idct10' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("idct10", "([II)V", "")]
		public static unsafe void Idct10 (int[] buf, int off)
		{
			if (id_idct10_arrayII == IntPtr.Zero)
				id_idct10_arrayII = JNIEnv.GetStaticMethodID (class_ref, "idct10", "([II)V");
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_buf);
				__args [1] = new JValue (off);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idct10_arrayII, __args);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
			}
		}

	}
}
