using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Identification']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/Identification", DoNotGenerateAcw=true)]
	public partial class Identification : global::Org.Jcodec.Containers.Mxf.Model.MXFInterchangeObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/Identification", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Identification); }
		}

		protected Identification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Identification']/constructor[@name='Identification' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe Identification (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Identification)) {
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

		static Delegate cb_getCompanyName;
#pragma warning disable 0169
		static Delegate GetGetCompanyNameHandler ()
		{
			if (cb_getCompanyName == null)
				cb_getCompanyName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCompanyName);
			return cb_getCompanyName;
		}

		static IntPtr n_GetCompanyName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Identification __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Identification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CompanyName);
		}
#pragma warning restore 0169

		static IntPtr id_getCompanyName;
		public virtual unsafe string CompanyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Identification']/method[@name='getCompanyName' and count(parameter)=0]"
			[Register ("getCompanyName", "()Ljava/lang/String;", "GetGetCompanyNameHandler")]
			get {
				if (id_getCompanyName == IntPtr.Zero)
					id_getCompanyName = JNIEnv.GetMethodID (class_ref, "getCompanyName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCompanyName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCompanyName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModificationDate;
#pragma warning disable 0169
		static Delegate GetGetModificationDateHandler ()
		{
			if (cb_getModificationDate == null)
				cb_getModificationDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModificationDate);
			return cb_getModificationDate;
		}

		static IntPtr n_GetModificationDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Identification __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Identification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ModificationDate);
		}
#pragma warning restore 0169

		static IntPtr id_getModificationDate;
		public virtual unsafe global::Java.Util.Date ModificationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Identification']/method[@name='getModificationDate' and count(parameter)=0]"
			[Register ("getModificationDate", "()Ljava/util/Date;", "GetGetModificationDateHandler")]
			get {
				if (id_getModificationDate == IntPtr.Zero)
					id_getModificationDate = JNIEnv.GetMethodID (class_ref, "getModificationDate", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModificationDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModificationDate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlatform;
#pragma warning disable 0169
		static Delegate GetGetPlatformHandler ()
		{
			if (cb_getPlatform == null)
				cb_getPlatform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlatform);
			return cb_getPlatform;
		}

		static IntPtr n_GetPlatform (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Identification __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Identification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Platform);
		}
#pragma warning restore 0169

		static IntPtr id_getPlatform;
		public virtual unsafe string Platform {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Identification']/method[@name='getPlatform' and count(parameter)=0]"
			[Register ("getPlatform", "()Ljava/lang/String;", "GetGetPlatformHandler")]
			get {
				if (id_getPlatform == IntPtr.Zero)
					id_getPlatform = JNIEnv.GetMethodID (class_ref, "getPlatform", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlatform), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlatform", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProductName;
#pragma warning disable 0169
		static Delegate GetGetProductNameHandler ()
		{
			if (cb_getProductName == null)
				cb_getProductName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductName);
			return cb_getProductName;
		}

		static IntPtr n_GetProductName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Identification __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Identification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductName);
		}
#pragma warning restore 0169

		static IntPtr id_getProductName;
		public virtual unsafe string ProductName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Identification']/method[@name='getProductName' and count(parameter)=0]"
			[Register ("getProductName", "()Ljava/lang/String;", "GetGetProductNameHandler")]
			get {
				if (id_getProductName == IntPtr.Zero)
					id_getProductName = JNIEnv.GetMethodID (class_ref, "getProductName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProductName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProductName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProductUID;
#pragma warning disable 0169
		static Delegate GetGetProductUIDHandler ()
		{
			if (cb_getProductUID == null)
				cb_getProductUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductUID);
			return cb_getProductUID;
		}

		static IntPtr n_GetProductUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Identification __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Identification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProductUID);
		}
#pragma warning restore 0169

		static IntPtr id_getProductUID;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL ProductUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Identification']/method[@name='getProductUID' and count(parameter)=0]"
			[Register ("getProductUID", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetProductUIDHandler")]
			get {
				if (id_getProductUID == IntPtr.Zero)
					id_getProductUID = JNIEnv.GetMethodID (class_ref, "getProductUID", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProductUID), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProductUID", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThisGenerationUID;
#pragma warning disable 0169
		static Delegate GetGetThisGenerationUIDHandler ()
		{
			if (cb_getThisGenerationUID == null)
				cb_getThisGenerationUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThisGenerationUID);
			return cb_getThisGenerationUID;
		}

		static IntPtr n_GetThisGenerationUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Identification __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Identification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThisGenerationUID);
		}
#pragma warning restore 0169

		static IntPtr id_getThisGenerationUID;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL ThisGenerationUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Identification']/method[@name='getThisGenerationUID' and count(parameter)=0]"
			[Register ("getThisGenerationUID", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetThisGenerationUIDHandler")]
			get {
				if (id_getThisGenerationUID == IntPtr.Zero)
					id_getThisGenerationUID = JNIEnv.GetMethodID (class_ref, "getThisGenerationUID", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThisGenerationUID), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThisGenerationUID", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersionString;
#pragma warning disable 0169
		static Delegate GetGetVersionStringHandler ()
		{
			if (cb_getVersionString == null)
				cb_getVersionString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetVersionString);
			return cb_getVersionString;
		}

		static short n_GetVersionString (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.Identification __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Identification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VersionString;
		}
#pragma warning restore 0169

		static IntPtr id_getVersionString;
		public virtual unsafe short VersionString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Identification']/method[@name='getVersionString' and count(parameter)=0]"
			[Register ("getVersionString", "()S", "GetGetVersionStringHandler")]
			get {
				if (id_getVersionString == IntPtr.Zero)
					id_getVersionString = JNIEnv.GetMethodID (class_ref, "getVersionString", "()S");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getVersionString);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersionString", "()S"));
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
			global::Org.Jcodec.Containers.Mxf.Model.Identification __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.Identification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='Identification']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.Integer, java.nio.ByteBuffer&gt;']]"
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
