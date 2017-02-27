using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Jpeg2AVCTrack']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/Jpeg2AVCTrack", DoNotGenerateAcw=true)]
	public partial class Jpeg2AVCTrack : global::Org.Jcodec.Movtool.Streaming.Tracks.Transcode2AVCTrack {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/Jpeg2AVCTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Jpeg2AVCTrack); }
		}

		protected Jpeg2AVCTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_selectScaleFactor_Lorg_jcodec_common_model_Size_;
#pragma warning disable 0169
		static Delegate GetSelectScaleFactor_Lorg_jcodec_common_model_Size_Handler ()
		{
			if (cb_selectScaleFactor_Lorg_jcodec_common_model_Size_ == null)
				cb_selectScaleFactor_Lorg_jcodec_common_model_Size_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SelectScaleFactor_Lorg_jcodec_common_model_Size_);
			return cb_selectScaleFactor_Lorg_jcodec_common_model_Size_;
		}

		static int n_SelectScaleFactor_Lorg_jcodec_common_model_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.Jpeg2AVCTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.Jpeg2AVCTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Size p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SelectScaleFactor (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_selectScaleFactor_Lorg_jcodec_common_model_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Jpeg2AVCTrack']/method[@name='selectScaleFactor' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Size']]"
		[Register ("selectScaleFactor", "(Lorg/jcodec/common/model/Size;)I", "GetSelectScaleFactor_Lorg_jcodec_common_model_Size_Handler")]
		protected override unsafe int SelectScaleFactor (global::Org.Jcodec.Common.Model.Size p0)
		{
			if (id_selectScaleFactor_Lorg_jcodec_common_model_Size_ == IntPtr.Zero)
				id_selectScaleFactor_Lorg_jcodec_common_model_Size_ = JNIEnv.GetMethodID (class_ref, "selectScaleFactor", "(Lorg/jcodec/common/model/Size;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_selectScaleFactor_Lorg_jcodec_common_model_Size_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectScaleFactor", "(Lorg/jcodec/common/model/Size;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
