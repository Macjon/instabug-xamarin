using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Algo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']"
	[global::Android.Runtime.Register ("org/jcodec/algo/DataConvert", DoNotGenerateAcw=true)]
	public partial class DataConvert : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
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
				if (GetType () != typeof (DataConvert)) {
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

		static IntPtr id_from16BE_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='from16BE' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("from16BE", "([B)[I", "")]
		public static unsafe int[] From16BE (byte[] p0)
		{
			if (id_from16BE_arrayB == IntPtr.Zero)
				id_from16BE_arrayB = JNIEnv.GetStaticMethodID (class_ref, "from16BE", "([B)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_from16BE_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_from16LE_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='from16LE' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("from16LE", "([B)[I", "")]
		public static unsafe int[] From16LE (byte[] p0)
		{
			if (id_from16LE_arrayB == IntPtr.Zero)
				id_from16LE_arrayB = JNIEnv.GetStaticMethodID (class_ref, "from16LE", "([B)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_from16LE_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_from24BE_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='from24BE' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("from24BE", "([B)[I", "")]
		public static unsafe int[] From24BE (byte[] p0)
		{
			if (id_from24BE_arrayB == IntPtr.Zero)
				id_from24BE_arrayB = JNIEnv.GetStaticMethodID (class_ref, "from24BE", "([B)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_from24BE_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_from24LE_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='from24LE' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("from24LE", "([B)[I", "")]
		public static unsafe int[] From24LE (byte[] p0)
		{
			if (id_from24LE_arrayB == IntPtr.Zero)
				id_from24LE_arrayB = JNIEnv.GetStaticMethodID (class_ref, "from24LE", "([B)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_from24LE_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_fromByte_arrayBIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='fromByte' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("fromByte", "([BIZ)[I", "")]
		public static unsafe int[] FromByte (byte[] p0, int p1, bool p2)
		{
			if (id_fromByte_arrayBIZ == IntPtr.Zero)
				id_fromByte_arrayBIZ = JNIEnv.GetStaticMethodID (class_ref, "fromByte", "([BIZ)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromByte_arrayBIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_to16BE_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='to16BE' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("to16BE", "([I)[B", "")]
		public static unsafe byte[] To16BE (int[] p0)
		{
			if (id_to16BE_arrayI == IntPtr.Zero)
				id_to16BE_arrayI = JNIEnv.GetStaticMethodID (class_ref, "to16BE", "([I)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_to16BE_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_to16LE_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='to16LE' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("to16LE", "([I)[B", "")]
		public static unsafe byte[] To16LE (int[] p0)
		{
			if (id_to16LE_arrayI == IntPtr.Zero)
				id_to16LE_arrayI = JNIEnv.GetStaticMethodID (class_ref, "to16LE", "([I)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_to16LE_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_to24BE_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='to24BE' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("to24BE", "([I)[B", "")]
		public static unsafe byte[] To24BE (int[] p0)
		{
			if (id_to24BE_arrayI == IntPtr.Zero)
				id_to24BE_arrayI = JNIEnv.GetStaticMethodID (class_ref, "to24BE", "([I)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_to24BE_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_to24LE_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='to24LE' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("to24LE", "([I)[B", "")]
		public static unsafe byte[] To24LE (int[] p0)
		{
			if (id_to24LE_arrayI == IntPtr.Zero)
				id_to24LE_arrayI = JNIEnv.GetStaticMethodID (class_ref, "to24LE", "([I)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_to24LE_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_toByte_arrayIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='DataConvert']/method[@name='toByte' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("toByte", "([IIZ)[B", "")]
		public static unsafe byte[] ToByte (int[] p0, int p1, bool p2)
		{
			if (id_toByte_arrayIIZ == IntPtr.Zero)
				id_toByte_arrayIIZ = JNIEnv.GetStaticMethodID (class_ref, "toByte", "([IIZ)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toByte_arrayIIZ, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
