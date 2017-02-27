using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Boxes {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlSint']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/boxes/EbmlSint", DoNotGenerateAcw=true)]
	public partial class EbmlSint : global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBin {


		static IntPtr signedComplement_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlSint']/field[@name='signedComplement']"
		[Register ("signedComplement")]
		public static IList<long> SignedComplement {
			get {
				if (signedComplement_jfieldId == IntPtr.Zero)
					signedComplement_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "signedComplement", "[J");
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, signedComplement_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/boxes/EbmlSint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EbmlSint); }
		}

		protected EbmlSint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlSint']/constructor[@name='EbmlSint' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe EbmlSint (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (EbmlSint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_convertToBytes_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlSint']/method[@name='convertToBytes' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("convertToBytes", "(J)[B", "")]
		public static unsafe byte[] ConvertToBytes (long p0)
		{
			if (id_convertToBytes_J == IntPtr.Zero)
				id_convertToBytes_J = JNIEnv.GetStaticMethodID (class_ref, "convertToBytes", "(J)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertToBytes_J, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_ebmlSignedLength_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlSint']/method[@name='ebmlSignedLength' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ebmlSignedLength", "(J)I", "")]
		public static unsafe int EbmlSignedLength (long p0)
		{
			if (id_ebmlSignedLength_J == IntPtr.Zero)
				id_ebmlSignedLength_J = JNIEnv.GetStaticMethodID (class_ref, "ebmlSignedLength", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_ebmlSignedLength_J, __args);
			} finally {
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get);
			return cb_get;
		}

		static long n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlSint __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlSint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get ();
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlSint']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()J", "GetGetHandler")]
		public virtual unsafe long Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_get);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()J"));
			} finally {
			}
		}

		static Delegate cb_set_J;
#pragma warning disable 0169
		static Delegate GetSet_JHandler ()
		{
			if (cb_set_J == null)
				cb_set_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Set_J);
			return cb_set_J;
		}

		static void n_Set_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlSint __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlSint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlSint']/method[@name='set' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("set", "(J)V", "GetSet_JHandler")]
		public virtual unsafe void Set (long p0)
		{
			if (id_set_J == IntPtr.Zero)
				id_set_J = JNIEnv.GetMethodID (class_ref, "set", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(J)V"), __args);
			} finally {
			}
		}

	}
}
