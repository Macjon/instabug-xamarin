using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='FrameHeader']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mjpeg/FrameHeader", DoNotGenerateAcw=true)]
	public partial class FrameHeader : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='FrameHeader.Component']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/mjpeg/FrameHeader$Component", DoNotGenerateAcw=true)]
		public partial class Component : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/mjpeg/FrameHeader$Component", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='FrameHeader.Component']/constructor[@name='FrameHeader.Component' and count(parameter)=0]"
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mjpeg/FrameHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FrameHeader); }
		}

		protected FrameHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='FrameHeader']/constructor[@name='FrameHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FrameHeader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FrameHeader)) {
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

		static Delegate cb_getHmax;
#pragma warning disable 0169
		static Delegate GetGetHmaxHandler ()
		{
			if (cb_getHmax == null)
				cb_getHmax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHmax);
			return cb_getHmax;
		}

		static int n_GetHmax (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mjpeg.FrameHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mjpeg.FrameHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Hmax;
		}
#pragma warning restore 0169

		static IntPtr id_getHmax;
		public virtual unsafe int Hmax {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='FrameHeader']/method[@name='getHmax' and count(parameter)=0]"
			[Register ("getHmax", "()I", "GetGetHmaxHandler")]
			get {
				if (id_getHmax == IntPtr.Zero)
					id_getHmax = JNIEnv.GetMethodID (class_ref, "getHmax", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHmax);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHmax", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getVmax;
#pragma warning disable 0169
		static Delegate GetGetVmaxHandler ()
		{
			if (cb_getVmax == null)
				cb_getVmax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVmax);
			return cb_getVmax;
		}

		static int n_GetVmax (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mjpeg.FrameHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mjpeg.FrameHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Vmax;
		}
#pragma warning restore 0169

		static IntPtr id_getVmax;
		public virtual unsafe int Vmax {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='FrameHeader']/method[@name='getVmax' and count(parameter)=0]"
			[Register ("getVmax", "()I", "GetGetVmaxHandler")]
			get {
				if (id_getVmax == IntPtr.Zero)
					id_getVmax = JNIEnv.GetMethodID (class_ref, "getVmax", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVmax);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVmax", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='FrameHeader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mjpeg/FrameHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mjpeg.FrameHeader Read (global::Java.Nio.ByteBuffer p0)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mjpeg/FrameHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Codecs.Mjpeg.FrameHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mjpeg.FrameHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
