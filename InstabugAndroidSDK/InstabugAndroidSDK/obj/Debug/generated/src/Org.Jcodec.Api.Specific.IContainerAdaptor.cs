using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Api.Specific {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.api.specific']/interface[@name='ContainerAdaptor']"
	[Register ("org/jcodec/api/specific/ContainerAdaptor", "", "Org.Jcodec.Api.Specific.IContainerAdaptorInvoker")]
	public partial interface IContainerAdaptor : IJavaObject {

		global::Org.Jcodec.Api.FrameGrab.MediaInfo MediaInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api.specific']/interface[@name='ContainerAdaptor']/method[@name='getMediaInfo' and count(parameter)=0]"
			[Register ("getMediaInfo", "()Lorg/jcodec/api/FrameGrab$MediaInfo;", "GetGetMediaInfoHandler:Org.Jcodec.Api.Specific.IContainerAdaptorInvoker, InstabugAndroidSDK")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api.specific']/interface[@name='ContainerAdaptor']/method[@name='allocatePicture' and count(parameter)=0]"
		[Register ("allocatePicture", "()[[I", "GetAllocatePictureHandler:Org.Jcodec.Api.Specific.IContainerAdaptorInvoker, InstabugAndroidSDK")]
		int[][] AllocatePicture ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api.specific']/interface[@name='ContainerAdaptor']/method[@name='canSeek' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Packet']]"
		[Register ("canSeek", "(Lorg/jcodec/common/model/Packet;)Z", "GetCanSeek_Lorg_jcodec_common_model_Packet_Handler:Org.Jcodec.Api.Specific.IContainerAdaptorInvoker, InstabugAndroidSDK")]
		bool CanSeek (global::Org.Jcodec.Common.Model.Packet p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api.specific']/interface[@name='ContainerAdaptor']/method[@name='decodeFrame' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Packet'] and parameter[2][@type='int[][]']]"
		[Register ("decodeFrame", "(Lorg/jcodec/common/model/Packet;[[I)Lorg/jcodec/common/model/Picture;", "GetDecodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayIHandler:Org.Jcodec.Api.Specific.IContainerAdaptorInvoker, InstabugAndroidSDK")]
		global::Org.Jcodec.Common.Model.Picture DecodeFrame (global::Org.Jcodec.Common.Model.Packet p0, int[][] p1);

	}

	[global::Android.Runtime.Register ("org/jcodec/api/specific/ContainerAdaptor", DoNotGenerateAcw=true)]
	internal class IContainerAdaptorInvoker : global::Java.Lang.Object, IContainerAdaptor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/api/specific/ContainerAdaptor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IContainerAdaptorInvoker); }
		}

		IntPtr class_ref;

		public static IContainerAdaptor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IContainerAdaptor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.api.specific.ContainerAdaptor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IContainerAdaptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Org.Jcodec.Api.Specific.IContainerAdaptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.Specific.IContainerAdaptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaInfo);
		}
#pragma warning restore 0169

		IntPtr id_getMediaInfo;
		public unsafe global::Org.Jcodec.Api.FrameGrab.MediaInfo MediaInfo {
			get {
				if (id_getMediaInfo == IntPtr.Zero)
					id_getMediaInfo = JNIEnv.GetMethodID (class_ref, "getMediaInfo", "()Lorg/jcodec/api/FrameGrab$MediaInfo;");
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab.MediaInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaInfo), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Api.Specific.IContainerAdaptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.Specific.IContainerAdaptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.AllocatePicture ());
		}
#pragma warning restore 0169

		IntPtr id_allocatePicture;
		public unsafe int[][] AllocatePicture ()
		{
			if (id_allocatePicture == IntPtr.Zero)
				id_allocatePicture = JNIEnv.GetMethodID (class_ref, "allocatePicture", "()[[I");
			return (int[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_allocatePicture), JniHandleOwnership.TransferLocalRef, typeof (int[]));
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
			global::Org.Jcodec.Api.Specific.IContainerAdaptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.Specific.IContainerAdaptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Packet p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanSeek (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_canSeek_Lorg_jcodec_common_model_Packet_;
		public unsafe bool CanSeek (global::Org.Jcodec.Common.Model.Packet p0)
		{
			if (id_canSeek_Lorg_jcodec_common_model_Packet_ == IntPtr.Zero)
				id_canSeek_Lorg_jcodec_common_model_Packet_ = JNIEnv.GetMethodID (class_ref, "canSeek", "(Lorg/jcodec/common/model/Packet;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canSeek_Lorg_jcodec_common_model_Packet_, __args);
			return __ret;
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
			global::Org.Jcodec.Api.Specific.IContainerAdaptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.Specific.IContainerAdaptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Packet p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[][] p1 = (int[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeFrame (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI;
		public unsafe global::Org.Jcodec.Common.Model.Picture DecodeFrame (global::Org.Jcodec.Common.Model.Packet p0, int[][] p1)
		{
			if (id_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI == IntPtr.Zero)
				id_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI = JNIEnv.GetMethodID (class_ref, "decodeFrame", "(Lorg/jcodec/common/model/Packet;[[I)Lorg/jcodec/common/model/Picture;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			global::Org.Jcodec.Common.Model.Picture __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeFrame_Lorg_jcodec_common_model_Packet_arrayarrayI, __args), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

	}

}
