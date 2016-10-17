using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg4.ES {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='SL']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg4/es/SL", DoNotGenerateAcw=true)]
	public partial class SL : global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg4/es/SL", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SL); }
		}

		protected SL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='SL']/constructor[@name='SL' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe SL (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SL)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='SL']/constructor[@name='SL' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SL ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SL)) {
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

		static Delegate cb_doWrite_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetDoWrite_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_doWrite_Ljava_nio_ByteBuffer_ == null)
				cb_doWrite_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoWrite_Ljava_nio_ByteBuffer_);
			return cb_doWrite_Ljava_nio_ByteBuffer_;
		}

		static void n_DoWrite_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Mpeg4.ES.SL __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.SL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoWrite (p0);
		}
#pragma warning restore 0169

		static IntPtr id_doWrite_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='SL']/method[@name='doWrite' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("doWrite", "(Ljava/nio/ByteBuffer;)V", "GetDoWrite_Ljava_nio_ByteBuffer_Handler")]
		protected override unsafe void DoWrite (global::Java.Nio.ByteBuffer p0)
		{
			if (id_doWrite_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_doWrite_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "doWrite", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doWrite_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doWrite", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_parse_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_parse_Ljava_nio_ByteBuffer_ == null)
				cb_parse_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Parse_Ljava_nio_ByteBuffer_);
			return cb_parse_Ljava_nio_ByteBuffer_;
		}

		static void n_Parse_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Mpeg4.ES.SL __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.SL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_parse_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='SL']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parse", "(Ljava/nio/ByteBuffer;)V", "GetParse_Ljava_nio_ByteBuffer_Handler")]
		protected override unsafe void Parse (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parse_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parse_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_tag;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='SL']/method[@name='tag' and count(parameter)=0]"
		[Register ("tag", "()I", "")]
		public static unsafe int Tag ()
		{
			if (id_tag == IntPtr.Zero)
				id_tag = JNIEnv.GetStaticMethodID (class_ref, "tag", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_tag);
			} finally {
			}
		}

	}
}
