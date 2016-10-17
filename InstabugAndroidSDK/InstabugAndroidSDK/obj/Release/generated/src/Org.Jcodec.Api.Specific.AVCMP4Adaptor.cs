using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Api.Specific {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.api.specific']/class[@name='AVCMP4Adaptor']"
	[global::Android.Runtime.Register ("org/jcodec/api/specific/AVCMP4Adaptor", DoNotGenerateAcw=true)]
	public partial class AVCMP4Adaptor : global::Java.Lang.Object, global::Org.Jcodec.Api.Specific.IContainerAdaptor {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/api/specific/AVCMP4Adaptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AVCMP4Adaptor); }
		}

		protected AVCMP4Adaptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getMediaInfo;
#pragma warning disable 0169
		static Delegate GetGetMediaInfoHandler ()
		{
			if (cb_getMediaInfo == null)
				cb_getMediaInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaInfo);
			return cb_getMediaInfo;
		}

		static IntPtr n_GetMediaInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Api.Specific.AVCMP4Adaptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.Specific.AVCMP4Adaptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaInfo;
		public virtual unsafe global::Org.Jcodec.Api.FrameGrab.MediaInfo MediaInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api.specific']/class[@name='AVCMP4Adaptor']/method[@name='getMediaInfo' and count(parameter)=0]"
			[Register ("getMediaInfo", "()Lorg/jcodec/api/FrameGrab$MediaInfo;", "GetGetMediaInfoHandler")]
			get {
				if (id_getMediaInfo == IntPtr.Zero)
					id_getMediaInfo = JNIEnv.GetMethodID (class_ref, "getMediaInfo", "()Lorg/jcodec/api/FrameGrab$MediaInfo;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab.MediaInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab.MediaInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaInfo", "()Lorg/jcodec/api/FrameGrab$MediaInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_allocatePicture;
#pragma warning disable 0169
		static Delegate GetAllocatePictureHandler ()
		{
			if (cb_allocatePicture == null)
				cb_allocatePicture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AllocatePicture);
			return cb_allocatePicture;
		}

		static IntPtr n_AllocatePicture (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Api.Specific.AVCMP4Adaptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.Specific.AVCMP4Adaptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.AllocatePicture ());
		}
#pragma warning restore 0169

		static IntPtr id_allocatePicture;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api.specific']/class[@name='AVCMP4Adaptor']/method[@name='allocatePicture' and count(parameter)=0]"
		[Register ("allocatePicture", "()[[I", "GetAllocatePictureHandler")]
		public virtual unsafe int[][] AllocatePicture ()
		{
			if (id_allocatePicture == IntPtr.Zero)
				id_allocatePicture = JNIEnv.GetMethodID (class_ref, "allocatePicture", "()[[I");
			try {

				if (GetType () == ThresholdType)
					return (int[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_allocatePicture), JniHandleOwnership.TransferLocalRef, typeof (int[]));
				else
					return (int[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "allocatePicture", "()[[I")), JniHandleOwnership.TransferLocalRef, typeof (int[]));
			} finally {
			}
		}

		static Delegate cb_canSeek_Lorg_jcodec_common_model_Packet_;
#pragma warning disable 0169
		static Delegate GetCanSeek_Lorg_jcodec_common_model_Packet_Handler ()
		{
			if (cb_canSeek_Lorg_jcodec_common_model_Packet_ == null)
				cb_canSeek_Lorg_jcodec_common_model_Packet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanSeek_Lorg_jcodec_common_model_Packet_);
			return cb_canSeek_Lorg_jcodec_common_model_Packet_;
		}

		static bool n_CanSeek_Lorg_jcodec_common_model_Packet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Api.Specific.AVCMP4Adaptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.Specific.AVCMP4Adaptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Packet p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanSeek (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_canSeek_Lorg_jcodec_common_model_Packet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api.specific']/class[@name='AVCMP4Adaptor']/method[@name='canSeek' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Packet']]"
		[Register ("canSeek", "(Lorg/jcodec/common/model/Packet;)Z", "GetCanSeek_Lorg_jcodec_common_model_Packet_Handler")]
		public virtual unsafe bool CanSeek (global::Org.Jcodec.Common.Model.Packet p0)
		{
			if (id_canSeek_Lorg_jcodec_common_model_Packet_ == IntPtr.Zero)
				id_canSeek_Lorg_jcodec_common_model_Packet_ = JNIEnv.GetMethodID (class_ref, "canSeek", "(Lorg/jcodec/common/model/Packet;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canSeek_Lorg_jcodec_common_model_Packet_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canSeek", "(Lorg/jcodec/common/model/Packet;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI;
#pragma warning disable 0169
		static Delegate GetDecodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayIHandler ()
		{
			if (cb_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI == null)
				cb_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI);
			return cb_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI;
		}

		static IntPtr n_DecodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Api.Specific.AVCMP4Adaptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.Specific.AVCMP4Adaptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Packet p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[][] p1 = (int[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeFrame (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api.specific']/class[@name='AVCMP4Adaptor']/method[@name='decodeFrame' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Packet'] and parameter[2][@type='int[][]']]"
		[Register ("decodeFrame", "(Lorg/jcodec/common/model/Packet;[[I)Lorg/jcodec/common/model/Picture;", "GetDecodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayIHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture DecodeFrame (global::Org.Jcodec.Common.Model.Packet p0, int[][] p1)
		{
			if (id_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI == IntPtr.Zero)
				id_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI = JNIEnv.GetMethodID (class_ref, "decodeFrame", "(Lorg/jcodec/common/model/Packet;[[I)Lorg/jcodec/common/model/Picture;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Org.Jcodec.Common.Model.Picture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeFrame", "(Lorg/jcodec/common/model/Packet;[[I)Lorg/jcodec/common/model/Picture;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
