using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='ContentStorage']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/ContentStorage", DoNotGenerateAcw=true)]
	public partial class ContentStorage : global::Org.Jcodec.Containers.Mxf.Model.MXFInterchangeObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/ContentStorage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentStorage); }
		}

		protected ContentStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='ContentStorage']/constructor[@name='ContentStorage' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe ContentStorage (global::Org.Jcodec.Containers.Mxf.Model.UL ul)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ul);
				if (((object) this).GetType () != typeof (ContentStorage)) {
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

		static Delegate cb_getEssenceContainerData;
#pragma warning disable 0169
		static Delegate GetGetEssenceContainerDataHandler ()
		{
			if (cb_getEssenceContainerData == null)
				cb_getEssenceContainerData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEssenceContainerData);
			return cb_getEssenceContainerData;
		}

		static IntPtr n_GetEssenceContainerData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.ContentStorage __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.ContentStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEssenceContainerData ());
		}
#pragma warning restore 0169

		static IntPtr id_getEssenceContainerData;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='ContentStorage']/method[@name='getEssenceContainerData' and count(parameter)=0]"
		[Register ("getEssenceContainerData", "()[Lorg/jcodec/containers/mxf/model/UL;", "GetGetEssenceContainerDataHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL[] GetEssenceContainerData ()
		{
			if (id_getEssenceContainerData == IntPtr.Zero)
				id_getEssenceContainerData = JNIEnv.GetMethodID (class_ref, "getEssenceContainerData", "()[Lorg/jcodec/containers/mxf/model/UL;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEssenceContainerData), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
				else
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEssenceContainerData", "()[Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
			} finally {
			}
		}

		static Delegate cb_getPackageRefs;
#pragma warning disable 0169
		static Delegate GetGetPackageRefsHandler ()
		{
			if (cb_getPackageRefs == null)
				cb_getPackageRefs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageRefs);
			return cb_getPackageRefs;
		}

		static IntPtr n_GetPackageRefs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.ContentStorage __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.ContentStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPackageRefs ());
		}
#pragma warning restore 0169

		static IntPtr id_getPackageRefs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='ContentStorage']/method[@name='getPackageRefs' and count(parameter)=0]"
		[Register ("getPackageRefs", "()[Lorg/jcodec/containers/mxf/model/UL;", "GetGetPackageRefsHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL[] GetPackageRefs ()
		{
			if (id_getPackageRefs == IntPtr.Zero)
				id_getPackageRefs = JNIEnv.GetMethodID (class_ref, "getPackageRefs", "()[Lorg/jcodec/containers/mxf/model/UL;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackageRefs), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
				else
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPackageRefs", "()[Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
			} finally {
			}
		}

		static Delegate cb_read_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_util_Map_Handler ()
		{
			if (cb_read_Ljava_util_Map_ == null)
				cb_read_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_util_Map_);
			return cb_read_Ljava_util_Map_;
		}

		static void n_Read_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tags)
		{
			global::Org.Jcodec.Containers.Mxf.Model.ContentStorage __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.ContentStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tags = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.FromJniHandle (native_tags, JniHandleOwnership.DoNotTransfer);
			__this.Read (tags);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='ContentStorage']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.Integer, java.nio.ByteBuffer&gt;']]"
		[Register ("read", "(Ljava/util/Map;)V", "GetRead_Ljava_util_Map_Handler")]
		protected override unsafe void Read (global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer> tags)
		{
			if (id_read_Ljava_util_Map_ == IntPtr.Zero)
				id_read_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/util/Map;)V");
			IntPtr native_tags = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.ToLocalJniHandle (tags);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_tags);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tags);
			}
		}

	}
}
