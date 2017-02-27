using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg4.ES {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='NodeDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg4/es/NodeDescriptor", DoNotGenerateAcw=true)]
	public partial class NodeDescriptor : global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg4/es/NodeDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NodeDescriptor); }
		}

		protected NodeDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='NodeDescriptor']/constructor[@name='NodeDescriptor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.jcodec.codecs.mpeg4.es.Descriptor[]']]"
		[Register (".ctor", "(I[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V", "")]
		public unsafe NodeDescriptor (int p0, global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (NodeDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V", __args);
					return;
				}

				if (id_ctor_IarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_ == IntPtr.Zero)
					id_ctor_IarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(I[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='NodeDescriptor']/constructor[@name='NodeDescriptor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe NodeDescriptor (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (NodeDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='NodeDescriptor']/constructor[@name='NodeDescriptor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe NodeDescriptor (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (NodeDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
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

		static Delegate cb_getChildren;
#pragma warning disable 0169
		static Delegate GetGetChildrenHandler ()
		{
			if (cb_getChildren == null)
				cb_getChildren = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChildren);
			return cb_getChildren;
		}

		static IntPtr n_GetChildren (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg4.ES.NodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.NodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor>.ToLocalJniHandle (__this.Children);
		}
#pragma warning restore 0169

		static IntPtr id_getChildren;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor> Children {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='NodeDescriptor']/method[@name='getChildren' and count(parameter)=0]"
			[Register ("getChildren", "()Ljava/util/Collection;", "GetGetChildrenHandler")]
			get {
				if (id_getChildren == IntPtr.Zero)
					id_getChildren = JNIEnv.GetMethodID (class_ref, "getChildren", "()Ljava/util/Collection;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChildren), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<global::Org.Jcodec.Codecs.Mpeg4.ES.Descriptor>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChildren", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Org.Jcodec.Codecs.Mpeg4.ES.NodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.NodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoWrite (p0);
		}
#pragma warning restore 0169

		static IntPtr id_doWrite_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='NodeDescriptor']/method[@name='doWrite' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("doWrite", "(Ljava/nio/ByteBuffer;)V", "GetDoWrite_Ljava_nio_ByteBuffer_Handler")]
		protected override unsafe void DoWrite (global::Java.Nio.ByteBuffer p0)
		{
			if (id_doWrite_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_doWrite_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "doWrite", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
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
			global::Org.Jcodec.Codecs.Mpeg4.ES.NodeDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.NodeDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_parse_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='NodeDescriptor']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parse", "(Ljava/nio/ByteBuffer;)V", "GetParse_Ljava_nio_ByteBuffer_Handler")]
		protected override unsafe void Parse (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parse_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parse_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
