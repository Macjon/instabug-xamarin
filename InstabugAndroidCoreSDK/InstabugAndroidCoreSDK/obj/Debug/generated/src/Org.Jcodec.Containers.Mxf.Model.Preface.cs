using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Preface']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/Preface", DoNotGenerateAcw=true)]
	public partial class Preface : global::Org.Jcodec.Containers.Mxf.Model.MXFInterchangeObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/Preface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Preface); }
		}

		protected Preface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Preface']/constructor[@name='Preface' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe Preface (global::Org.Jcodec.Containers.Mxf.Model.UL ul)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ul);
				if (((object) this).GetType () != typeof (Preface)) {
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

		static Delegate cb_getLastModifiedDate;
#pragma warning disable 0169
		static Delegate GetGetLastModifiedDateHandler ()
		{
			if (cb_getLastModifiedDate == null)
				cb_getLastModifiedDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastModifiedDate);
			return cb_getLastModifiedDate;
		}

		static IntPtr n_GetLastModifiedDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Preface __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Preface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastModifiedDate);
		}
#pragma warning restore 0169

		static IntPtr id_getLastModifiedDate;
		public virtual unsafe global::Java.Util.Date LastModifiedDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Preface']/method[@name='getLastModifiedDate' and count(parameter)=0]"
			[Register ("getLastModifiedDate", "()Ljava/util/Date;", "GetGetLastModifiedDateHandler")]
			get {
				if (id_getLastModifiedDate == IntPtr.Zero)
					id_getLastModifiedDate = JNIEnv.GetMethodID (class_ref, "getLastModifiedDate", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastModifiedDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastModifiedDate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getObjectModelVersion;
#pragma warning disable 0169
		static Delegate GetGetObjectModelVersionHandler ()
		{
			if (cb_getObjectModelVersion == null)
				cb_getObjectModelVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetObjectModelVersion);
			return cb_getObjectModelVersion;
		}

		static int n_GetObjectModelVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Preface __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Preface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectModelVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getObjectModelVersion;
		public virtual unsafe int ObjectModelVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Preface']/method[@name='getObjectModelVersion' and count(parameter)=0]"
			[Register ("getObjectModelVersion", "()I", "GetGetObjectModelVersionHandler")]
			get {
				if (id_getObjectModelVersion == IntPtr.Zero)
					id_getObjectModelVersion = JNIEnv.GetMethodID (class_ref, "getObjectModelVersion", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getObjectModelVersion);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjectModelVersion", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getOp;
#pragma warning disable 0169
		static Delegate GetGetOpHandler ()
		{
			if (cb_getOp == null)
				cb_getOp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOp);
			return cb_getOp;
		}

		static IntPtr n_GetOp (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Preface __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Preface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Op);
		}
#pragma warning restore 0169

		static IntPtr id_getOp;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL Op {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Preface']/method[@name='getOp' and count(parameter)=0]"
			[Register ("getOp", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetOpHandler")]
			get {
				if (id_getOp == IntPtr.Zero)
					id_getOp = JNIEnv.GetMethodID (class_ref, "getOp", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOp), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOp", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDmSchemes;
#pragma warning disable 0169
		static Delegate GetGetDmSchemesHandler ()
		{
			if (cb_getDmSchemes == null)
				cb_getDmSchemes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDmSchemes);
			return cb_getDmSchemes;
		}

		static IntPtr n_GetDmSchemes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Preface __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Preface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDmSchemes ());
		}
#pragma warning restore 0169

		static IntPtr id_getDmSchemes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Preface']/method[@name='getDmSchemes' and count(parameter)=0]"
		[Register ("getDmSchemes", "()[Lorg/jcodec/containers/mxf/model/UL;", "GetGetDmSchemesHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL[] GetDmSchemes ()
		{
			if (id_getDmSchemes == IntPtr.Zero)
				id_getDmSchemes = JNIEnv.GetMethodID (class_ref, "getDmSchemes", "()[Lorg/jcodec/containers/mxf/model/UL;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDmSchemes), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
				else
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDmSchemes", "()[Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
			} finally {
			}
		}

		static Delegate cb_getEssenceContainers;
#pragma warning disable 0169
		static Delegate GetGetEssenceContainersHandler ()
		{
			if (cb_getEssenceContainers == null)
				cb_getEssenceContainers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEssenceContainers);
			return cb_getEssenceContainers;
		}

		static IntPtr n_GetEssenceContainers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Preface __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Preface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEssenceContainers ());
		}
#pragma warning restore 0169

		static IntPtr id_getEssenceContainers;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Preface']/method[@name='getEssenceContainers' and count(parameter)=0]"
		[Register ("getEssenceContainers", "()[Lorg/jcodec/containers/mxf/model/UL;", "GetGetEssenceContainersHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL[] GetEssenceContainers ()
		{
			if (id_getEssenceContainers == IntPtr.Zero)
				id_getEssenceContainers = JNIEnv.GetMethodID (class_ref, "getEssenceContainers", "()[Lorg/jcodec/containers/mxf/model/UL;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEssenceContainers), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
				else
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEssenceContainers", "()[Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
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
			global::Org.Jcodec.Containers.Mxf.Model.Preface __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Preface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tags = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.FromJniHandle (native_tags, JniHandleOwnership.DoNotTransfer);
			__this.Read (tags);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Preface']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.Integer, java.nio.ByteBuffer&gt;']]"
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
