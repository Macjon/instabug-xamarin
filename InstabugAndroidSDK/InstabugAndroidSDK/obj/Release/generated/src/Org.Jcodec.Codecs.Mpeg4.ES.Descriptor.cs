using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg4.ES {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='Descriptor']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg4/es/Descriptor", DoNotGenerateAcw=true)]
	public abstract partial class Descriptor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg4/es/Descriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Descriptor); }
		}

		protected Descriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='Descriptor']/constructor[@name='Descriptor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Descriptor (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Descriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='Descriptor']/constructor[@name='Descriptor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Descriptor (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Descriptor)) {
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
			global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoWrite (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='Descriptor']/method[@name='doWrite' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("doWrite", "(Ljava/nio/ByteBuffer;)V", "GetDoWrite_Ljava_nio_ByteBuffer_Handler")]
		protected abstract void DoWrite (global::Java.Nio.ByteBuffer p0);

		static IntPtr id_find_Lorg_jcodec_codecs_mpeg4_es_Descriptor_Ljava_lang_Class_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='Descriptor']/method[@name='find' and count(parameter)=3 and parameter[1][@type='org.jcodec.codecs.mpeg4.es.Descriptor'] and parameter[2][@type='java.lang.Class&lt;T&gt;'] and parameter[3][@type='int']]"
		[Register ("find", "(Lorg/jcodec/codecs/mpeg4/es/Descriptor;Ljava/lang/Class;I)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Find (global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor p0, global::Java.Lang.Class p1, int p2)
		{
			if (id_find_Lorg_jcodec_codecs_mpeg4_es_Descriptor_Ljava_lang_Class_I == IntPtr.Zero)
				id_find_Lorg_jcodec_codecs_mpeg4_es_Descriptor_Ljava_lang_Class_I = JNIEnv.GetStaticMethodID (class_ref, "find", "(Lorg/jcodec/codecs/mpeg4/es/Descriptor;Ljava/lang/Class;I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_find_Lorg_jcodec_codecs_mpeg4_es_Descriptor_Ljava_lang_Class_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parse (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='Descriptor']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parse", "(Ljava/nio/ByteBuffer;)V", "GetParse_Ljava_nio_ByteBuffer_Handler")]
		protected abstract void Parse (global::Java.Nio.ByteBuffer p0);

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='Descriptor']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mpeg4/es/Descriptor;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor Read (global::Java.Nio.ByteBuffer p0)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mpeg4/es/Descriptor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_write_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_write_Ljava_nio_ByteBuffer_ == null)
				cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_nio_ByteBuffer_);
			return cb_write_Ljava_nio_ByteBuffer_;
		}

		static void n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='Descriptor']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)V", "GetWrite_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Write (global::Java.Nio.ByteBuffer p0)
		{
			if (id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg4/es/Descriptor", DoNotGenerateAcw=true)]
	internal partial class DescriptorInvoker : Descriptor {

		public DescriptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DescriptorInvoker); }
		}

		static IntPtr id_doWrite_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='Descriptor']/method[@name='doWrite' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("doWrite", "(Ljava/nio/ByteBuffer;)V", "GetDoWrite_Ljava_nio_ByteBuffer_Handler")]
		protected override unsafe void DoWrite (global::Java.Nio.ByteBuffer p0)
		{
			if (id_doWrite_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_doWrite_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "doWrite", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doWrite_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='Descriptor']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parse", "(Ljava/nio/ByteBuffer;)V", "GetParse_Ljava_nio_ByteBuffer_Handler")]
		protected override unsafe void Parse (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parse_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parse_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

	}

}
