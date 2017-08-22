using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='ScanHeader']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mjpeg/ScanHeader", DoNotGenerateAcw=true)]
	public partial class ScanHeader : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='ScanHeader.Component']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/mjpeg/ScanHeader$Component", DoNotGenerateAcw=true)]
		public partial class Component : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/mjpeg/ScanHeader$Component", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Component); }
			}

			protected Component (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='ScanHeader.Component']/constructor[@name='ScanHeader.Component' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Component ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Component)) {
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mjpeg/ScanHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScanHeader); }
		}

		protected ScanHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='ScanHeader']/constructor[@name='ScanHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScanHeader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ScanHeader)) {
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

		static Delegate cb_isInterleaved;
#pragma warning disable 0169
		static Delegate GetIsInterleavedHandler ()
		{
			if (cb_isInterleaved == null)
				cb_isInterleaved = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInterleaved);
			return cb_isInterleaved;
		}

		static bool n_IsInterleaved (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mjpeg.ScanHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mjpeg.ScanHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInterleaved;
		}
#pragma warning restore 0169

		static IntPtr id_isInterleaved;
		public virtual unsafe bool IsInterleaved {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='ScanHeader']/method[@name='isInterleaved' and count(parameter)=0]"
			[Register ("isInterleaved", "()Z", "GetIsInterleavedHandler")]
			get {
				if (id_isInterleaved == IntPtr.Zero)
					id_isInterleaved = JNIEnv.GetMethodID (class_ref, "isInterleaved", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInterleaved);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInterleaved", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='ScanHeader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mjpeg/ScanHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mjpeg.ScanHeader Read (global::Java.Nio.ByteBuffer bb)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mjpeg/ScanHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bb);
				global::Org.Jcodec.Codecs.Mjpeg.ScanHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mjpeg.ScanHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
