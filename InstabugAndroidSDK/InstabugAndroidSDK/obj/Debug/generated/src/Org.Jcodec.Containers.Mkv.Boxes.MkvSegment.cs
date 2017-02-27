using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Boxes {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvSegment']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/boxes/MkvSegment", DoNotGenerateAcw=true)]
	public partial class MkvSegment : global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/boxes/MkvSegment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MkvSegment); }
		}

		protected MkvSegment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvSegment']/constructor[@name='MkvSegment' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe MkvSegment (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (MkvSegment)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvSegment']/constructor[@name='MkvSegment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MkvSegment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MkvSegment)) {
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

		static Delegate cb_getHeader;
#pragma warning disable 0169
		static Delegate GetGetHeaderHandler ()
		{
			if (cb_getHeader == null)
				cb_getHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeader);
			return cb_getHeader;
		}

		static IntPtr n_GetHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.MkvSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.MkvSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Header);
		}
#pragma warning restore 0169

		static IntPtr id_getHeader;
		public virtual unsafe global::Java.Nio.ByteBuffer Header {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvSegment']/method[@name='getHeader' and count(parameter)=0]"
			[Register ("getHeader", "()Ljava/nio/ByteBuffer;", "GetGetHeaderHandler")]
			get {
				if (id_getHeader == IntPtr.Zero)
					id_getHeader = JNIEnv.GetMethodID (class_ref, "getHeader", "()Ljava/nio/ByteBuffer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeader", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderSize;
#pragma warning disable 0169
		static Delegate GetGetHeaderSizeHandler ()
		{
			if (cb_getHeaderSize == null)
				cb_getHeaderSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetHeaderSize);
			return cb_getHeaderSize;
		}

		static long n_GetHeaderSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.MkvSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.MkvSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderSize;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderSize;
		public virtual unsafe long HeaderSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvSegment']/method[@name='getHeaderSize' and count(parameter)=0]"
			[Register ("getHeaderSize", "()J", "GetGetHeaderSizeHandler")]
			get {
				if (id_getHeaderSize == IntPtr.Zero)
					id_getHeaderSize = JNIEnv.GetMethodID (class_ref, "getHeaderSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderSize", "()J"));
				} finally {
				}
			}
		}

	}
}
