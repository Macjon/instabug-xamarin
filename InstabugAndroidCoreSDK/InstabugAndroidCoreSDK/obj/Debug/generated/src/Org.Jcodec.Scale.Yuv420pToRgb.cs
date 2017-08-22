using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Scale {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.scale']/class[@name='Yuv420pToRgb']"
	[global::Android.Runtime.Register ("org/jcodec/scale/Yuv420pToRgb", DoNotGenerateAcw=true)]
	public partial class Yuv420pToRgb : global::Java.Lang.Object, global::Org.Jcodec.Scale.ITransform {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/scale/Yuv420pToRgb", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Yuv420pToRgb); }
		}

		protected Yuv420pToRgb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.scale']/class[@name='Yuv420pToRgb']/constructor[@name='Yuv420pToRgb' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Yuv420pToRgb (int upShift, int downShift)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (upShift);
				__args [1] = new JValue (downShift);
				if (((object) this).GetType () != typeof (Yuv420pToRgb)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='Yuv420pToRgb']/method[@name='transform' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='org.jcodec.common.model.Picture']]"
		[Register ("transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V", "")]
		public unsafe void Transform (global::Org.Jcodec.Common.Model.Picture src, global::Org.Jcodec.Common.Model.Picture dst)
		{
			if (id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (src);
				__args [1] = new JValue (dst);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_, __args);
			} finally {
			}
		}

	}
}
