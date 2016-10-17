using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/util/EbmlUtil", DoNotGenerateAcw=true)]
	public partial class EbmlUtil : global::Java.Lang.Object {


		static IntPtr ebmlLengthMasks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/field[@name='ebmlLengthMasks']"
		[Register ("ebmlLengthMasks")]
		public static IList<long> EbmlLengthMasks {
			get {
				if (ebmlLengthMasks_jfieldId == IntPtr.Zero)
					ebmlLengthMasks_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ebmlLengthMasks", "[J");
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ebmlLengthMasks_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/field[@name='eight']"
		[Register ("eight")]
		public const long Eight = (long) 71494644084506624L;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/field[@name='five']"
		[Register ("five")]
		public const long Five = (long) 34091302912L;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/field[@name='four']"
		[Register ("four")]
		public const long Four = (long) 266338304L;

		static IntPtr lengthOptions_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/field[@name='lengthOptions']"
		[Register ("lengthOptions")]
		public static IList<byte> LengthOptions {
			get {
				if (lengthOptions_jfieldId == IntPtr.Zero)
					lengthOptions_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "lengthOptions", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, lengthOptions_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/field[@name='one']"
		[Register ("one")]
		public const long One = (long) 127L;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/field[@name='seven']"
		[Register ("seven")]
		public const long Seven = (long) 558551906910208L;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/field[@name='six']"
		[Register ("six")]
		public const long Six = (long) 4363686772736L;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/field[@name='three']"
		[Register ("three")]
		public const long Three = (long) 2080768L;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/field[@name='two']"
		[Register ("two")]
		public const long Two = (long) 16256L;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/util/EbmlUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EbmlUtil); }
		}

		protected EbmlUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/constructor[@name='EbmlUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EbmlUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EbmlUtil)) {
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

		static IntPtr id_computeLength_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/method[@name='computeLength' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("computeLength", "(B)I", "")]
		public static unsafe int ComputeLength (sbyte p0)
		{
			if (id_computeLength_B == IntPtr.Zero)
				id_computeLength_B = JNIEnv.GetStaticMethodID (class_ref, "computeLength", "(B)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_computeLength_B, __args);
			} finally {
			}
		}

		static IntPtr id_ebmlEncode_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/method[@name='ebmlEncode' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ebmlEncode", "(J)[B", "")]
		public static unsafe byte[] EbmlEncode (long p0)
		{
			if (id_ebmlEncode_J == IntPtr.Zero)
				id_ebmlEncode_J = JNIEnv.GetStaticMethodID (class_ref, "ebmlEncode", "(J)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_ebmlEncode_J, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_ebmlEncode_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/method[@name='ebmlEncode' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("ebmlEncode", "(JI)[B", "")]
		public static unsafe byte[] EbmlEncode (long p0, int p1)
		{
			if (id_ebmlEncode_JI == IntPtr.Zero)
				id_ebmlEncode_JI = JNIEnv.GetStaticMethodID (class_ref, "ebmlEncode", "(JI)[B");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_ebmlEncode_JI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_ebmlLength_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/method[@name='ebmlLength' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ebmlLength", "(J)I", "")]
		public static unsafe int EbmlLength (long p0)
		{
			if (id_ebmlLength_J == IntPtr.Zero)
				id_ebmlLength_J = JNIEnv.GetStaticMethodID (class_ref, "ebmlLength", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_ebmlLength_J, __args);
			} finally {
			}
		}

		static IntPtr id_toHexString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.util']/class[@name='EbmlUtil']/method[@name='toHexString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toHexString", "([B)Ljava/lang/String;", "")]
		public static unsafe string ToHexString (byte[] p0)
		{
			if (id_toHexString_arrayB == IntPtr.Zero)
				id_toHexString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toHexString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHexString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
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
