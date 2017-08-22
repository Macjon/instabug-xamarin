using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFMetadata']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/MXFMetadata", DoNotGenerateAcw=true)]
	public abstract partial class MXFMetadata : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/MXFMetadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MXFMetadata); }
		}

		protected MXFMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFMetadata']/constructor[@name='MXFMetadata' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe MXFMetadata (global::Org.Jcodec.Containers.Mxf.Model.UL ul)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ul);
				if (((object) this).GetType () != typeof (MXFMetadata)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/containers/mxf/model/UL;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mxf/model/UL;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mxf_model_UL_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mxf_model_UL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mxf/model/UL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args);
			} finally {
			}
		}

		static Delegate cb_getUid;
#pragma warning disable 0169
		static Delegate GetGetUidHandler ()
		{
			if (cb_getUid == null)
				cb_getUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUid);
			return cb_getUid;
		}

		static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Uid);
		}
#pragma warning restore 0169

		static IntPtr id_getUid;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFMetadata']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetUidHandler")]
			get {
				if (id_getUid == IntPtr.Zero)
					id_getUid = JNIEnv.GetMethodID (class_ref, "getUid", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUid), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUid", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUl;
#pragma warning disable 0169
		static Delegate GetGetUlHandler ()
		{
			if (cb_getUl == null)
				cb_getUl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUl);
			return cb_getUl;
		}

		static IntPtr n_GetUl (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ul);
		}
#pragma warning restore 0169

		static IntPtr id_getUl;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL Ul {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFMetadata']/method[@name='getUl' and count(parameter)=0]"
			[Register ("getUl", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetUlHandler")]
			get {
				if (id_getUl == IntPtr.Zero)
					id_getUl = JNIEnv.GetMethodID (class_ref, "getUl", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUl), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUl", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_read_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_read_Ljava_nio_ByteBuffer_ == null)
				cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_nio_ByteBuffer_);
			return cb_read_Ljava_nio_ByteBuffer_;
		}

		static void n_Read_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFMetadata']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)V", "GetRead_Ljava_nio_ByteBuffer_Handler")]
		public abstract void Read (global::Java.Nio.ByteBuffer p0);

		static IntPtr id_readDate_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFMetadata']/method[@name='readDate' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readDate", "(Ljava/nio/ByteBuffer;)Ljava/util/Date;", "")]
		protected static unsafe global::Java.Util.Date ReadDate (global::Java.Nio.ByteBuffer _bb)
		{
			if (id_readDate_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readDate_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "readDate", "(Ljava/nio/ByteBuffer;)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (_bb);
				global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readDate_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readInt32Batch_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFMetadata']/method[@name='readInt32Batch' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readInt32Batch", "(Ljava/nio/ByteBuffer;)[I", "")]
		protected static unsafe int[] ReadInt32Batch (global::Java.Nio.ByteBuffer _bb)
		{
			if (id_readInt32Batch_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readInt32Batch_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "readInt32Batch", "(Ljava/nio/ByteBuffer;)[I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (_bb);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_readInt32Batch_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readULBatch_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFMetadata']/method[@name='readULBatch' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readULBatch", "(Ljava/nio/ByteBuffer;)[Lorg/jcodec/containers/mxf/model/UL;", "")]
		protected static unsafe global::Org.Jcodec.Containers.Mxf.Model.UL[] ReadULBatch (global::Java.Nio.ByteBuffer _bb)
		{
			if (id_readULBatch_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readULBatch_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "readULBatch", "(Ljava/nio/ByteBuffer;)[Lorg/jcodec/containers/mxf/model/UL;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (_bb);
				global::Org.Jcodec.Containers.Mxf.Model.UL[] __ret = (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_readULBatch_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_readUtf16String_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetReadUtf16String_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_readUtf16String_Ljava_nio_ByteBuffer_ == null)
				cb_readUtf16String_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadUtf16String_Ljava_nio_ByteBuffer_);
			return cb_readUtf16String_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_ReadUtf16String_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native__bb)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer _bb = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native__bb, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ReadUtf16String (_bb));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readUtf16String_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFMetadata']/method[@name='readUtf16String' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readUtf16String", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;", "GetReadUtf16String_Ljava_nio_ByteBuffer_Handler")]
		protected virtual unsafe string ReadUtf16String (global::Java.Nio.ByteBuffer _bb)
		{
			if (id_readUtf16String_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readUtf16String_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "readUtf16String", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (_bb);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readUtf16String_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readUtf16String", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/MXFMetadata", DoNotGenerateAcw=true)]
	internal partial class MXFMetadataInvoker : MXFMetadata {

		public MXFMetadataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MXFMetadataInvoker); }
		}

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFMetadata']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)V", "GetRead_Ljava_nio_ByteBuffer_Handler")]
		public override unsafe void Read (global::Java.Nio.ByteBuffer p0)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

	}

}
