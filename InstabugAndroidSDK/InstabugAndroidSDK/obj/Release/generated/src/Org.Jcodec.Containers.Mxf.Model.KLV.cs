using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='KLV']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/KLV", DoNotGenerateAcw=true)]
	public partial class KLV : global::Java.Lang.Object {


		static IntPtr dataOffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='KLV']/field[@name='dataOffset']"
		[Register ("dataOffset")]
		public long DataOffset {
			get {
				if (dataOffset_jfieldId == IntPtr.Zero)
					dataOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "dataOffset", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, dataOffset_jfieldId);
			}
			set {
				if (dataOffset_jfieldId == IntPtr.Zero)
					dataOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "dataOffset", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dataOffset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr key_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='KLV']/field[@name='key']"
		[Register ("key")]
		public global::Org.Jcodec.Containers.Mxf.Model.UL Key {
			get {
				if (key_jfieldId == IntPtr.Zero)
					key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Lorg/jcodec/containers/mxf/model/UL;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, key_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (key_jfieldId == IntPtr.Zero)
					key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Lorg/jcodec/containers/mxf/model/UL;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, key_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr len_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='KLV']/field[@name='len']"
		[Register ("len")]
		public long Len {
			get {
				if (len_jfieldId == IntPtr.Zero)
					len_jfieldId = JNIEnv.GetFieldID (class_ref, "len", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, len_jfieldId);
			}
			set {
				if (len_jfieldId == IntPtr.Zero)
					len_jfieldId = JNIEnv.GetFieldID (class_ref, "len", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, len_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr offset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='KLV']/field[@name='offset']"
		[Register ("offset")]
		public long Offset {
			get {
				if (offset_jfieldId == IntPtr.Zero)
					offset_jfieldId = JNIEnv.GetFieldID (class_ref, "offset", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, offset_jfieldId);
			}
			set {
				if (offset_jfieldId == IntPtr.Zero)
					offset_jfieldId = JNIEnv.GetFieldID (class_ref, "offset", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, offset_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/KLV", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KLV); }
		}

		protected KLV (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_JJJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='KLV']/constructor[@name='KLV' and count(parameter)=4 and parameter[1][@type='org.jcodec.containers.mxf.model.UL'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;JJJ)V", "")]
		public unsafe KLV (global::Org.Jcodec.Containers.Mxf.Model.UL p0, long p1, long p2, long p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (KLV)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/containers/mxf/model/UL;JJJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mxf/model/UL;JJJ)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mxf_model_UL_JJJ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mxf_model_UL_JJJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mxf/model/UL;JJJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_JJJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_JJJ, __args);
			} finally {
			}
		}

		static Delegate cb_getLenByteCount;
#pragma warning disable 0169
		static Delegate GetGetLenByteCountHandler ()
		{
			if (cb_getLenByteCount == null)
				cb_getLenByteCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLenByteCount);
			return cb_getLenByteCount;
		}

		static int n_GetLenByteCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.KLV __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.KLV> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LenByteCount;
		}
#pragma warning restore 0169

		static IntPtr id_getLenByteCount;
		public virtual unsafe int LenByteCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='KLV']/method[@name='getLenByteCount' and count(parameter)=0]"
			[Register ("getLenByteCount", "()I", "GetGetLenByteCountHandler")]
			get {
				if (id_getLenByteCount == IntPtr.Zero)
					id_getLenByteCount = JNIEnv.GetMethodID (class_ref, "getLenByteCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLenByteCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLenByteCount", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_matches_arrayBarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='KLV']/method[@name='matches' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("matches", "([B[BI)Z", "")]
		public static unsafe bool Matches (byte[] p0, byte[] p1, int p2)
		{
			if (id_matches_arrayBarrayBI == IntPtr.Zero)
				id_matches_arrayBarrayBI = JNIEnv.GetStaticMethodID (class_ref, "matches", "([B[BI)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_matches_arrayBarrayBI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_readKL_Ljava_nio_ByteBuffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='KLV']/method[@name='readKL' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long']]"
		[Register ("readKL", "(Ljava/nio/ByteBuffer;J)Lorg/jcodec/containers/mxf/model/KLV;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mxf.Model.KLV ReadKL (global::Java.Nio.ByteBuffer p0, long p1)
		{
			if (id_readKL_Ljava_nio_ByteBuffer_J == IntPtr.Zero)
				id_readKL_Ljava_nio_ByteBuffer_J = JNIEnv.GetStaticMethodID (class_ref, "readKL", "(Ljava/nio/ByteBuffer;J)Lorg/jcodec/containers/mxf/model/KLV;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Jcodec.Containers.Mxf.Model.KLV __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.KLV> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readKL_Ljava_nio_ByteBuffer_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
