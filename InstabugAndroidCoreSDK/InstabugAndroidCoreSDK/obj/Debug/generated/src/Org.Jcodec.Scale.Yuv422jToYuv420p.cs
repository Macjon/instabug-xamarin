using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Scale {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.scale']/class[@name='Yuv422jToYuv420p']"
	[global::Android.Runtime.Register ("org/jcodec/scale/Yuv422jToYuv420p", DoNotGenerateAcw=true)]
	public partial class Yuv422jToYuv420p : global::Java.Lang.Object, global::Org.Jcodec.Scale.ITransform {


		static IntPtr Y_COEFF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.scale']/class[@name='Yuv422jToYuv420p']/field[@name='Y_COEFF']"
		[Register ("Y_COEFF")]
		public static int YCoeff {
			get {
				if (Y_COEFF_jfieldId == IntPtr.Zero)
					Y_COEFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Y_COEFF", "I");
				return JNIEnv.GetStaticIntField (class_ref, Y_COEFF_jfieldId);
			}
			set {
				if (Y_COEFF_jfieldId == IntPtr.Zero)
					Y_COEFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Y_COEFF", "I");
				try {
					JNIEnv.SetStaticField (class_ref, Y_COEFF_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/scale/Yuv422jToYuv420p", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Yuv422jToYuv420p); }
		}

		protected Yuv422jToYuv420p (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.scale']/class[@name='Yuv422jToYuv420p']/constructor[@name='Yuv422jToYuv420p' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Yuv422jToYuv420p ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Yuv422jToYuv420p)) {
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

		static Delegate cb_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_;
#pragma warning disable 0169
		static Delegate GetTransform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_Handler ()
		{
			if (cb_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ == null)
				cb_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_);
			return cb_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_;
		}

		static void n_Transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src, IntPtr native_dst)
		{
			global::Org.Jcodec.Scale.Yuv422jToYuv420p __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Scale.Yuv422jToYuv420p> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture src = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_src, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture dst = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_dst, JniHandleOwnership.DoNotTransfer);
			__this.Transform (src, dst);
		}
#pragma warning restore 0169

		static IntPtr id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='Yuv422jToYuv420p']/method[@name='transform' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='org.jcodec.common.model.Picture']]"
		[Register ("transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V", "GetTransform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_Handler")]
		public virtual unsafe void Transform (global::Org.Jcodec.Common.Model.Picture src, global::Org.Jcodec.Common.Model.Picture dst)
		{
			if (id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (src);
				__args [1] = new JValue (dst);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V"), __args);
			} finally {
			}
		}

	}
}
