using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='UL']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/UL", DoNotGenerateAcw=true)]
	public partial class UL : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/UL", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UL); }
		}

		protected UL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='UL']/constructor[@name='UL' and count(parameter)=1 and parameter[1][@type='byte...']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe UL (params  byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (UL)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_arrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='UL']/constructor[@name='UL' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register (".ctor", "([I)V", "")]
		public unsafe UL (params  int[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (UL)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([I)V", __args);
					return;
				}

				if (id_ctor_arrayI == IntPtr.Zero)
					id_ctor_arrayI = JNIEnv.GetMethodID (class_ref, "<init>", "([I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_equals_Lorg_jcodec_containers_mxf_model_UL_I;
#pragma warning disable 0169
		static Delegate GetEquals_Lorg_jcodec_containers_mxf_model_UL_IHandler ()
		{
			if (cb_equals_Lorg_jcodec_containers_mxf_model_UL_I == null)
				cb_equals_Lorg_jcodec_containers_mxf_model_UL_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_Equals_Lorg_jcodec_containers_mxf_model_UL_I);
			return cb_equals_Lorg_jcodec_containers_mxf_model_UL_I;
		}

		static bool n_Equals_Lorg_jcodec_containers_mxf_model_UL_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Jcodec.Containers.Mxf.Model.UL __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mxf.Model.UL p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Lorg_jcodec_containers_mxf_model_UL_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='UL']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='org.jcodec.containers.mxf.model.UL'] and parameter[2][@type='int']]"
		[Register ("equals", "(Lorg/jcodec/containers/mxf/model/UL;I)Z", "GetEquals_Lorg_jcodec_containers_mxf_model_UL_IHandler")]
		public virtual unsafe bool Equals (global::Org.Jcodec.Containers.Mxf.Model.UL p0, int p1)
		{
			if (id_equals_Lorg_jcodec_containers_mxf_model_UL_I == IntPtr.Zero)
				id_equals_Lorg_jcodec_containers_mxf_model_UL_I = JNIEnv.GetMethodID (class_ref, "equals", "(Lorg/jcodec/containers/mxf/model/UL;I)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Lorg_jcodec_containers_mxf_model_UL_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "equals", "(Lorg/jcodec/containers/mxf/model/UL;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Get_I);
			return cb_get_I;
		}

		static int n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Containers.Mxf.Model.UL __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get (p0);
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='UL']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)I", "GetGet_IHandler")]
		public virtual unsafe int Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)I"), __args);
			} finally {
			}
		}

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='UL']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mxf/model/UL;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mxf.Model.UL Read (global::Java.Nio.ByteBuffer p0)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mxf/model/UL;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Containers.Mxf.Model.UL __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
