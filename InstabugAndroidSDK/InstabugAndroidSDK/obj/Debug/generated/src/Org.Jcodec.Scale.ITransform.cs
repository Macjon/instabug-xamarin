using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Scale {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.scale']/interface[@name='Transform']"
	[Register ("org/jcodec/scale/Transform", "", "Org.Jcodec.Scale.ITransformInvoker")]
	public partial interface ITransform : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/interface[@name='Transform']/method[@name='transform' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='org.jcodec.common.model.Picture']]"
		[Register ("transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V", "GetTransform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_Handler:Org.Jcodec.Scale.ITransformInvoker, InstabugAndroidSDK")]
		void Transform (global::Org.Jcodec.Common.Model.Picture p0, global::Org.Jcodec.Common.Model.Picture p1);

	}

	[global::Android.Runtime.Register ("org/jcodec/scale/Transform", DoNotGenerateAcw=true)]
	internal class ITransformInvoker : global::Java.Lang.Object, ITransform {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/scale/Transform");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITransformInvoker); }
		}

		IntPtr class_ref;

		public static ITransform GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITransform> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.scale.Transform"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITransformInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_;
#pragma warning disable 0169
		static Delegate GetTransform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_Handler ()
		{
			if (cb_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ == null)
				cb_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_);
			return cb_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_;
		}

		static void n_Transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Scale.ITransform __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Scale.ITransform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Transform (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_;
		public unsafe void Transform (global::Org.Jcodec.Common.Model.Picture p0, global::Org.Jcodec.Common.Model.Picture p1)
		{
			if (id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_, __args);
		}

	}

}
