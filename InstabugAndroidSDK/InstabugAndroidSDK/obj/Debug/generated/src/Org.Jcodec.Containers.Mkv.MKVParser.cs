using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVParser']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/MKVParser", DoNotGenerateAcw=true)]
	public partial class MKVParser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/MKVParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MKVParser); }
		}

		protected MKVParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isKnownType_arrayB;
#pragma warning disable 0169
		static Delegate GetIsKnownType_arrayBHandler ()
		{
			if (cb_isKnownType_arrayB == null)
				cb_isKnownType_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsKnownType_arrayB);
			return cb_isKnownType_arrayB;
		}

		static bool n_IsKnownType_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mkv.MKVParser __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.MKVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.IsKnownType (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isKnownType_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVParser']/method[@name='isKnownType' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isKnownType", "([B)Z", "GetIsKnownType_arrayBHandler")]
		public virtual unsafe bool IsKnownType (byte[] p0)
		{
			if (id_isKnownType_arrayB == IntPtr.Zero)
				id_isKnownType_arrayB = JNIEnv.GetMethodID (class_ref, "isKnownType", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isKnownType_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isKnownType", "([B)Z"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_parse;
#pragma warning disable 0169
		static Delegate GetParseHandler ()
		{
			if (cb_parse == null)
				cb_parse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Parse);
			return cb_parse;
		}

		static IntPtr n_Parse (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.MKVParser __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.MKVParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster>.ToLocalJniHandle (__this.Parse ());
		}
#pragma warning restore 0169

		static IntPtr id_parse;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVParser']/method[@name='parse' and count(parameter)=0]"
		[Register ("parse", "()Ljava/util/List;", "GetParseHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster> Parse ()
		{
			if (id_parse == IntPtr.Zero)
				id_parse = JNIEnv.GetMethodID (class_ref, "parse", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
