using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='BER']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/BER", DoNotGenerateAcw=true)]
	public partial class BER : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='BER']/field[@name='ASN_LONG_LEN']"
		[Register ("ASN_LONG_LEN")]
		public const sbyte AsnLongLen = (sbyte) -128;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/BER", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BER); }
		}

		protected BER (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='BER']/constructor[@name='BER' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BER ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BER)) {
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

		static IntPtr id_decodeLength_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='BER']/method[@name='decodeLength' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("decodeLength", "(Ljava/nio/ByteBuffer;)J", "")]
		public static unsafe long DecodeLength (global::Java.Nio.ByteBuffer buffer)
		{
			if (id_decodeLength_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_decodeLength_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "decodeLength", "(Ljava/nio/ByteBuffer;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (buffer);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_decodeLength_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
