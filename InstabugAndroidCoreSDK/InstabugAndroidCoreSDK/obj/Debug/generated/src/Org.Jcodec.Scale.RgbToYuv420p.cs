using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Scale {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.scale']/class[@name='RgbToYuv420p']"
	[global::Android.Runtime.Register ("org/jcodec/scale/RgbToYuv420p", DoNotGenerateAcw=true)]
	public partial class RgbToYuv420p : global::Java.Lang.Object, global::Org.Jcodec.Scale.ITransform {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/scale/RgbToYuv420p", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RgbToYuv420p); }
		}

		protected RgbToYuv420p (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.scale']/class[@name='RgbToYuv420p']/constructor[@name='RgbToYuv420p' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe RgbToYuv420p (int upShift, int downShift)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (upShift);
				__args [1] = new JValue (downShift);
				if (((object) this).GetType () != typeof (RgbToYuv420p)) {
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

		static IntPtr id_rgb2yuv_IIIarrayIIarrayIIarrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='RgbToYuv420p']/method[@name='rgb2yuv' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int[]'] and parameter[7][@type='int'] and parameter[8][@type='int[]'] and parameter[9][@type='int']]"
		[Register ("rgb2yuv", "(III[II[II[II)V", "")]
		public static unsafe void Rgb2yuv (int r, int g, int b, int[] Y, int offY, int[] U, int offU, int[] V, int offV)
		{
			if (id_rgb2yuv_IIIarrayIIarrayIIarrayII == IntPtr.Zero)
				id_rgb2yuv_IIIarrayIIarrayIIarrayII = JNIEnv.GetStaticMethodID (class_ref, "rgb2yuv", "(III[II[II[II)V");
			IntPtr native_Y = JNIEnv.NewArray (Y);
			IntPtr native_U = JNIEnv.NewArray (U);
			IntPtr native_V = JNIEnv.NewArray (V);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (r);
				__args [1] = new JValue (g);
				__args [2] = new JValue (b);
				__args [3] = new JValue (native_Y);
				__args [4] = new JValue (offY);
				__args [5] = new JValue (native_U);
				__args [6] = new JValue (offU);
				__args [7] = new JValue (native_V);
				__args [8] = new JValue (offV);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_rgb2yuv_IIIarrayIIarrayIIarrayII, __args);
			} finally {
				if (Y != null) {
					JNIEnv.CopyArray (native_Y, Y);
					JNIEnv.DeleteLocalRef (native_Y);
				}
				if (U != null) {
					JNIEnv.CopyArray (native_U, U);
					JNIEnv.DeleteLocalRef (native_U);
				}
				if (V != null) {
					JNIEnv.CopyArray (native_V, V);
					JNIEnv.DeleteLocalRef (native_V);
				}
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

		static void n_Transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_img, IntPtr native_dst)
		{
			global::Org.Jcodec.Scale.RgbToYuv420p __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Scale.RgbToYuv420p> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture img = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_img, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture dst = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_dst, JniHandleOwnership.DoNotTransfer);
			__this.Transform (img, dst);
		}
#pragma warning restore 0169

		static IntPtr id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.scale']/class[@name='RgbToYuv420p']/method[@name='transform' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='org.jcodec.common.model.Picture']]"
		[Register ("transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V", "GetTransform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_Handler")]
		public virtual unsafe void Transform (global::Org.Jcodec.Common.Model.Picture img, global::Org.Jcodec.Common.Model.Picture dst)
		{
			if (id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_transform_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "transform", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (img);
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
