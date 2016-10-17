using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Filters.Color {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.filters.color']/class[@name='CVTColorFilter']"
	[global::Android.Runtime.Register ("org/jcodec/filters/color/CVTColorFilter", DoNotGenerateAcw=true)]
	public partial class CVTColorFilter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/filters/color/CVTColorFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CVTColorFilter); }
		}

		protected CVTColorFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.filters.color']/class[@name='CVTColorFilter']/constructor[@name='CVTColorFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CVTColorFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CVTColorFilter)) {
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

		static Delegate cb_yuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetYuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_yuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_ == null)
				cb_yuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Yuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_);
			return cb_yuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_;
		}

		static void n_Yuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Filters.Color.CVTColorFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Filters.Color.CVTColorFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Yuv42210BitTObgr24 (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_yuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.filters.color']/class[@name='CVTColorFilter']/method[@name='yuv42210BitTObgr24' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("yuv42210BitTObgr24", "(Lorg/jcodec/common/model/Picture;Ljava/nio/ByteBuffer;)V", "GetYuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Yuv42210BitTObgr24 (global::Org.Jcodec.Common.Model.Picture p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_yuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_yuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "yuv42210BitTObgr24", "(Lorg/jcodec/common/model/Picture;Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_yuv42210BitTObgr24_Lorg_jcodec_common_model_Picture_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "yuv42210BitTObgr24", "(Lorg/jcodec/common/model/Picture;Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
