using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFUtil']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/MXFUtil", DoNotGenerateAcw=true)]
	public partial class MXFUtil : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/MXFUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MXFUtil); }
		}

		protected MXFUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFUtil']/constructor[@name='MXFUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MXFUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MXFUtil)) {
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

		static IntPtr id_findAllMeta_Ljava_util_Collection_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFUtil']/method[@name='findAllMeta' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;org.jcodec.containers.mxf.model.MXFMetadata&gt;'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("findAllMeta", "(Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList FindAllMeta (global::System.Collections.Generic.ICollection<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata> metadata, global::Java.Lang.Class class1)
		{
			if (id_findAllMeta_Ljava_util_Collection_Ljava_lang_Class_ == IntPtr.Zero)
				id_findAllMeta_Ljava_util_Collection_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "findAllMeta", "(Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/List;");
			IntPtr native_metadata = global::Android.Runtime.JavaCollection<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata>.ToLocalJniHandle (metadata);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_metadata);
				__args [1] = new JValue (class1);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findAllMeta_Ljava_util_Collection_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_metadata);
			}
		}

		static IntPtr id_findMeta_Ljava_util_Collection_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFUtil']/method[@name='findMeta' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;org.jcodec.containers.mxf.model.MXFMetadata&gt;'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("findMeta", "(Ljava/util/Collection;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object FindMeta (global::System.Collections.Generic.ICollection<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata> metadata, global::Java.Lang.Class class1)
		{
			if (id_findMeta_Ljava_util_Collection_Ljava_lang_Class_ == IntPtr.Zero)
				id_findMeta_Ljava_util_Collection_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "findMeta", "(Ljava/util/Collection;Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_metadata = global::Android.Runtime.JavaCollection<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata>.ToLocalJniHandle (metadata);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_metadata);
				__args [1] = new JValue (class1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findMeta_Ljava_util_Collection_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_metadata);
			}
		}

		static IntPtr id_resolveRef_Ljava_util_List_Lorg_jcodec_containers_mxf_model_UL_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFUtil']/method[@name='resolveRef' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;org.jcodec.containers.mxf.model.MXFMetadata&gt;'] and parameter[2][@type='org.jcodec.containers.mxf.model.UL'] and parameter[3][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("resolveRef", "(Ljava/util/List;Lorg/jcodec/containers/mxf/model/UL;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object ResolveRef (global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata> metadata, global::Org.Jcodec.Containers.Mxf.Model.UL refs, global::Java.Lang.Class class1)
		{
			if (id_resolveRef_Ljava_util_List_Lorg_jcodec_containers_mxf_model_UL_Ljava_lang_Class_ == IntPtr.Zero)
				id_resolveRef_Ljava_util_List_Lorg_jcodec_containers_mxf_model_UL_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "resolveRef", "(Ljava/util/List;Lorg/jcodec/containers/mxf/model/UL;Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_metadata = global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata>.ToLocalJniHandle (metadata);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_metadata);
				__args [1] = new JValue (refs);
				__args [2] = new JValue (class1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_resolveRef_Ljava_util_List_Lorg_jcodec_containers_mxf_model_UL_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_metadata);
			}
		}

		static IntPtr id_resolveRefs_Ljava_util_List_arrayLorg_jcodec_containers_mxf_model_UL_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFUtil']/method[@name='resolveRefs' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;org.jcodec.containers.mxf.model.MXFMetadata&gt;'] and parameter[2][@type='org.jcodec.containers.mxf.model.UL[]'] and parameter[3][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("resolveRefs", "(Ljava/util/List;[Lorg/jcodec/containers/mxf/model/UL;Ljava/lang/Class;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList ResolveRefs (global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata> metadata, global::Org.Jcodec.Containers.Mxf.Model.UL[] refs, global::Java.Lang.Class class1)
		{
			if (id_resolveRefs_Ljava_util_List_arrayLorg_jcodec_containers_mxf_model_UL_Ljava_lang_Class_ == IntPtr.Zero)
				id_resolveRefs_Ljava_util_List_arrayLorg_jcodec_containers_mxf_model_UL_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "resolveRefs", "(Ljava/util/List;[Lorg/jcodec/containers/mxf/model/UL;Ljava/lang/Class;)Ljava/util/List;");
			IntPtr native_metadata = global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata>.ToLocalJniHandle (metadata);
			IntPtr native_refs = JNIEnv.NewArray (refs);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_metadata);
				__args [1] = new JValue (native_refs);
				__args [2] = new JValue (class1);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_resolveRefs_Ljava_util_List_arrayLorg_jcodec_containers_mxf_model_UL_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_metadata);
				if (refs != null) {
					JNIEnv.CopyArray (native_refs, refs);
					JNIEnv.DeleteLocalRef (native_refs);
				}
			}
		}

	}
}
