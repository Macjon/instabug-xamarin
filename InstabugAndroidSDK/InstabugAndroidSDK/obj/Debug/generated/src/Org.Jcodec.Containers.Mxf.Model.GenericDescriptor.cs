using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/GenericDescriptor", DoNotGenerateAcw=true)]
	public partial class GenericDescriptor : global::Org.Jcodec.Containers.Mxf.Model.MXFInterchangeObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/GenericDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericDescriptor); }
		}

		protected GenericDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericDescriptor']/constructor[@name='GenericDescriptor' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe GenericDescriptor (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (GenericDescriptor)) {
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

		static Delegate cb_getLocators;
#pragma warning disable 0169
		static Delegate GetGetLocatorsHandler ()
		{
			if (cb_getLocators == null)
				cb_getLocators = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocators);
			return cb_getLocators;
		}

		static IntPtr n_GetLocators (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLocators ());
		}
#pragma warning restore 0169

		static IntPtr id_getLocators;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericDescriptor']/method[@name='getLocators' and count(parameter)=0]"
		[Register ("getLocators", "()[Lorg/jcodec/containers/mxf/model/UL;", "GetGetLocatorsHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL[] GetLocators ()
		{
			if (id_getLocators == IntPtr.Zero)
				id_getLocators = JNIEnv.GetMethodID (class_ref, "getLocators", "()[Lorg/jcodec/containers/mxf/model/UL;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocators), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
				else
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocators", "()[Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
			} finally {
			}
		}

		static Delegate cb_getSubDescriptors;
#pragma warning disable 0169
		static Delegate GetGetSubDescriptorsHandler ()
		{
			if (cb_getSubDescriptors == null)
				cb_getSubDescriptors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubDescriptors);
			return cb_getSubDescriptors;
		}

		static IntPtr n_GetSubDescriptors (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSubDescriptors ());
		}
#pragma warning restore 0169

		static IntPtr id_getSubDescriptors;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericDescriptor']/method[@name='getSubDescriptors' and count(parameter)=0]"
		[Register ("getSubDescriptors", "()[Lorg/jcodec/containers/mxf/model/UL;", "GetGetSubDescriptorsHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL[] GetSubDescriptors ()
		{
			if (id_getSubDescriptors == IntPtr.Zero)
				id_getSubDescriptors = JNIEnv.GetMethodID (class_ref, "getSubDescriptors", "()[Lorg/jcodec/containers/mxf/model/UL;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubDescriptors), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
				else
					return (global::Org.Jcodec.Containers.Mxf.Model.UL[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubDescriptors", "()[Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.UL));
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

		static void n_Read_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericDescriptor']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.Integer, java.nio.ByteBuffer&gt;']]"
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
