using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode.Deblock {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.deblock']/class[@name='DeblockingFilter']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/deblock/DeblockingFilter", DoNotGenerateAcw=true)]
	public partial class DeblockingFilter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/deblock/DeblockingFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeblockingFilter); }
		}

		protected DeblockingFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_deblockFrame_Lorg_jcodec_common_model_Picture_;
#pragma warning disable 0169
		static Delegate GetDeblockFrame_Lorg_jcodec_common_model_Picture_Handler ()
		{
			if (cb_deblockFrame_Lorg_jcodec_common_model_Picture_ == null)
				cb_deblockFrame_Lorg_jcodec_common_model_Picture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeblockFrame_Lorg_jcodec_common_model_Picture_);
			return cb_deblockFrame_Lorg_jcodec_common_model_Picture_;
		}

		static void n_DeblockFrame_Lorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Deblock.DeblockingFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Deblock.DeblockingFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeblockFrame (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deblockFrame_Lorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.deblock']/class[@name='DeblockingFilter']/method[@name='deblockFrame' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Picture']]"
		[Register ("deblockFrame", "(Lorg/jcodec/common/model/Picture;)V", "GetDeblockFrame_Lorg_jcodec_common_model_Picture_Handler")]
		public virtual unsafe void DeblockFrame (global::Org.Jcodec.Common.Model.Picture p0)
		{
			if (id_deblockFrame_Lorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_deblockFrame_Lorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "deblockFrame", "(Lorg/jcodec/common/model/Picture;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deblockFrame_Lorg_jcodec_common_model_Picture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deblockFrame", "(Lorg/jcodec/common/model/Picture;)V"), __args);
			} finally {
			}
		}

	}
}
