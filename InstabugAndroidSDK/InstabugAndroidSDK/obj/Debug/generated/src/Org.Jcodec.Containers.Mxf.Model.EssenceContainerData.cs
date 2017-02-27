using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='EssenceContainerData']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/EssenceContainerData", DoNotGenerateAcw=true)]
	public partial class EssenceContainerData : global::Org.Jcodec.Containers.Mxf.Model.MXFInterchangeObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/EssenceContainerData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EssenceContainerData); }
		}

		protected EssenceContainerData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='EssenceContainerData']/constructor[@name='EssenceContainerData' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe EssenceContainerData (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (EssenceContainerData)) {
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

		static Delegate cb_getBodySID;
#pragma warning disable 0169
		static Delegate GetGetBodySIDHandler ()
		{
			if (cb_getBodySID == null)
				cb_getBodySID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBodySID);
			return cb_getBodySID;
		}

		static int n_GetBodySID (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.EssenceContainerData __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.EssenceContainerData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BodySID;
		}
#pragma warning restore 0169

		static IntPtr id_getBodySID;
		public virtual unsafe int BodySID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='EssenceContainerData']/method[@name='getBodySID' and count(parameter)=0]"
			[Register ("getBodySID", "()I", "GetGetBodySIDHandler")]
			get {
				if (id_getBodySID == IntPtr.Zero)
					id_getBodySID = JNIEnv.GetMethodID (class_ref, "getBodySID", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBodySID);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBodySID", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getIndexSID;
#pragma warning disable 0169
		static Delegate GetGetIndexSIDHandler ()
		{
			if (cb_getIndexSID == null)
				cb_getIndexSID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndexSID);
			return cb_getIndexSID;
		}

		static int n_GetIndexSID (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.EssenceContainerData __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.EssenceContainerData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexSID;
		}
#pragma warning restore 0169

		static IntPtr id_getIndexSID;
		public virtual unsafe int IndexSID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='EssenceContainerData']/method[@name='getIndexSID' and count(parameter)=0]"
			[Register ("getIndexSID", "()I", "GetGetIndexSIDHandler")]
			get {
				if (id_getIndexSID == IntPtr.Zero)
					id_getIndexSID = JNIEnv.GetMethodID (class_ref, "getIndexSID", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndexSID);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexSID", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getLinkedPackageUID;
#pragma warning disable 0169
		static Delegate GetGetLinkedPackageUIDHandler ()
		{
			if (cb_getLinkedPackageUID == null)
				cb_getLinkedPackageUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLinkedPackageUID);
			return cb_getLinkedPackageUID;
		}

		static IntPtr n_GetLinkedPackageUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.EssenceContainerData __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.EssenceContainerData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LinkedPackageUID);
		}
#pragma warning restore 0169

		static IntPtr id_getLinkedPackageUID;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL LinkedPackageUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='EssenceContainerData']/method[@name='getLinkedPackageUID' and count(parameter)=0]"
			[Register ("getLinkedPackageUID", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetLinkedPackageUIDHandler")]
			get {
				if (id_getLinkedPackageUID == IntPtr.Zero)
					id_getLinkedPackageUID = JNIEnv.GetMethodID (class_ref, "getLinkedPackageUID", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLinkedPackageUID), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLinkedPackageUID", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static void n_Read_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mxf.Model.EssenceContainerData __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.EssenceContainerData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='EssenceContainerData']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.Integer, java.nio.ByteBuffer&gt;']]"
		[Register ("read", "(Ljava/util/Map;)V", "GetRead_Ljava_util_Map_Handler")]
		protected override unsafe void Read (global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer> p0)
		{
			if (id_read_Ljava_util_Map_ == IntPtr.Zero)
				id_read_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
