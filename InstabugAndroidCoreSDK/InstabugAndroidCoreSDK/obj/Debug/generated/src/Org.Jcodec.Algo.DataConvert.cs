using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Algo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']"
	[global::Android.Runtime.Register ("org/jcodec/algo/DataConvert", DoNotGenerateAcw=true)]
	public partial class DataConvert : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/algo/DataConvert", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataConvert); }
		}

		protected DataConvert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/constructor[@name='DataConvert' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataConvert ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DataConvert)) {
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

		static IntPtr id_from16BE_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='from16BE' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("from16BE", "([B)[I", "")]
		public static unsafe int[] From16BE (byte[] b)
		{
			if (id_from16BE_arrayB == IntPtr.Zero)
				id_from16BE_arrayB = JNIEnv.GetStaticMethodID (class_ref, "from16BE", "([B)[I");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_from16BE_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_from16LE_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='from16LE' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("from16LE", "([B)[I", "")]
		public static unsafe int[] From16LE (byte[] b)
		{
			if (id_from16LE_arrayB == IntPtr.Zero)
				id_from16LE_arrayB = JNIEnv.GetStaticMethodID (class_ref, "from16LE", "([B)[I");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_from16LE_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_from24BE_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='from24BE' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("from24BE", "([B)[I", "")]
		public static unsafe int[] From24BE (byte[] b)
		{
			if (id_from24BE_arrayB == IntPtr.Zero)
				id_from24BE_arrayB = JNIEnv.GetStaticMethodID (class_ref, "from24BE", "([B)[I");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_from24BE_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_from24LE_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='from24LE' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("from24LE", "([B)[I", "")]
		public static unsafe int[] From24LE (byte[] b)
		{
			if (id_from24LE_arrayB == IntPtr.Zero)
				id_from24LE_arrayB = JNIEnv.GetStaticMethodID (class_ref, "from24LE", "([B)[I");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_from24LE_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_fromByte_arrayBIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='fromByte' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("fromByte", "([BIZ)[I", "")]
		public static unsafe int[] FromByte (byte[] b, int depth, bool isBe)
		{
			if (id_fromByte_arrayBIZ == IntPtr.Zero)
				id_fromByte_arrayBIZ = JNIEnv.GetStaticMethodID (class_ref, "fromByte", "([BIZ)[I");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_b);
				__args [1] = new JValue (depth);
				__args [2] = new JValue (isBe);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromByte_arrayBIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		static IntPtr id_to16BE_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='to16BE' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("to16BE", "([I)[B", "")]
		public static unsafe byte[] To16BE (int[] ia)
		{
			if (id_to16BE_arrayI == IntPtr.Zero)
				id_to16BE_arrayI = JNIEnv.GetStaticMethodID (class_ref, "to16BE", "([I)[B");
			IntPtr native_ia = JNIEnv.NewArray (ia);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_ia);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_to16BE_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (ia != null) {
					JNIEnv.CopyArray (native_ia, ia);
					JNIEnv.DeleteLocalRef (native_ia);
				}
			}
		}

		static IntPtr id_to16LE_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='to16LE' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("to16LE", "([I)[B", "")]
		public static unsafe byte[] To16LE (int[] ia)
		{
			if (id_to16LE_arrayI == IntPtr.Zero)
				id_to16LE_arrayI = JNIEnv.GetStaticMethodID (class_ref, "to16LE", "([I)[B");
			IntPtr native_ia = JNIEnv.NewArray (ia);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_ia);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_to16LE_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (ia != null) {
					JNIEnv.CopyArray (native_ia, ia);
					JNIEnv.DeleteLocalRef (native_ia);
				}
			}
		}

		static IntPtr id_to24BE_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='to24BE' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("to24BE", "([I)[B", "")]
		public static unsafe byte[] To24BE (int[] ia)
		{
			if (id_to24BE_arrayI == IntPtr.Zero)
				id_to24BE_arrayI = JNIEnv.GetStaticMethodID (class_ref, "to24BE", "([I)[B");
			IntPtr native_ia = JNIEnv.NewArray (ia);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_ia);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_to24BE_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (ia != null) {
					JNIEnv.CopyArray (native_ia, ia);
					JNIEnv.DeleteLocalRef (native_ia);
				}
			}
		}

		static IntPtr id_to24LE_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='to24LE' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("to24LE", "([I)[B", "")]
		public static unsafe byte[] To24LE (int[] ia)
		{
			if (id_to24LE_arrayI == IntPtr.Zero)
				id_to24LE_arrayI = JNIEnv.GetStaticMethodID (class_ref, "to24LE", "([I)[B");
			IntPtr native_ia = JNIEnv.NewArray (ia);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_ia);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_to24LE_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (ia != null) {
					JNIEnv.CopyArray (native_ia, ia);
					JNIEnv.DeleteLocalRef (native_ia);
				}
			}
		}

		static IntPtr id_toByte_arrayIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='toByte' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("toByte", "([IIZ)[B", "")]
		public static unsafe byte[] ToByte (int[] ia, int depth, bool isBe)
		{
			if (id_toByte_arrayIIZ == IntPtr.Zero)
				id_toByte_arrayIIZ = JNIEnv.GetStaticMethodID (class_ref, "toByte", "([IIZ)[B");
			IntPtr native_ia = JNIEnv.NewArray (ia);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_ia);
				__args [1] = new JValue (depth);
				__args [2] = new JValue (isBe);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toByte_arrayIIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (ia != null) {
					JNIEnv.CopyArray (native_ia, ia);
					JNIEnv.DeleteLocalRef (native_ia);
				}
			}
		}

	}
}
