using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Scale {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ColorUtil']"
	[global::Android.Runtime.Register ("org/jcodec/scale/ColorUtil", DoNotGenerateAcw=true)]
	public partial class ColorUtil : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ColorUtil.Idential']"
		[global::Android.Runtime.Register ("org/jcodec/scale/ColorUtil$Idential", DoNotGenerateAcw=true)]
		public partial class Idential : global::Java.Lang.Object, global::Org.Jcodec.Scale.ITransform {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/scale/ColorUtil$Idential", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Idential); }
			}

			protected Idential (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ColorUtil.Idential']/constructor[@name='ColorUtil.Idential' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Idential ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Idential)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

			static void n_Transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Jcodec.Scale.ColorUtil.Idential __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Scale.ColorUtil.Idential> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Common.Model.Picture p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Common.Model.Picture p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Transform (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ColorUtil.Idential']/method[@name='transform' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='org.jcodec.common.model.Picture']]"
			[Register ("transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V", "GetTransform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_Handler")]
			public virtual unsafe void Transform (global::Org.Jcodec.Common.Model.Picture p0, global::Org.Jcodec.Common.Model.Picture p1)
			{
				if (id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ == IntPtr.Zero)
					id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/scale/ColorUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorUtil); }
		}

		protected ColorUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ColorUtil']/constructor[@name='ColorUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColorUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ColorUtil)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		static IntPtr id_getTransform_Lorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_ColorSpace_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='ColorUtil']/method[@name='getTransform' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.ColorSpace'] and parameter[2][@type='org.jcodec.common.model.ColorSpace']]"
		[Register ("getTransform", "(Lorg/jcodec/common/model/ColorSpace;Lorg/jcodec/common/model/ColorSpace;)Lorg/jcodec/scale/Transform;", "")]
		public static unsafe global::Org.Jcodec.Scale.ITransform GetTransform (global::Org.Jcodec.Common.Model.ColorSpace p0, global::Org.Jcodec.Common.Model.ColorSpace p1)
		{
			if (id_getTransform_Lorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_ColorSpace_ == IntPtr.Zero)
				id_getTransform_Lorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_ColorSpace_ = JNIEnv.GetStaticMethodID (class_ref, "getTransform", "(Lorg/jcodec/common/model/ColorSpace;Lorg/jcodec/common/model/ColorSpace;)Lorg/jcodec/scale/Transform;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Jcodec.Scale.ITransform __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Scale.ITransform> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTransform_Lorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_ColorSpace_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
