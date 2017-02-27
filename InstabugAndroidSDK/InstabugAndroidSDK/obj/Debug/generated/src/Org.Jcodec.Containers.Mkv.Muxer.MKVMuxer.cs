using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Muxer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxer']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/muxer/MKVMuxer", DoNotGenerateAcw=true)]
	public partial class MKVMuxer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/muxer/MKVMuxer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MKVMuxer); }
		}

		protected MKVMuxer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxer']/constructor[@name='MKVMuxer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MKVMuxer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MKVMuxer)) {
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

		static IntPtr id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxer']/method[@name='createChild' and count(parameter)=3 and parameter[1][@type='org.jcodec.containers.mkv.boxes.EbmlMaster'] and parameter[2][@type='org.jcodec.containers.mkv.MKVType'] and parameter[3][@type='double']]"
		[Register ("createChild", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;Lorg/jcodec/containers/mkv/MKVType;D)V", "")]
		public static unsafe void CreateChild (global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster p0, global::Org.Jcodec.Containers.Mkv.MKVType p1, double p2)
		{
			if (id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_D == IntPtr.Zero)
				id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_D = JNIEnv.GetStaticMethodID (class_ref, "createChild", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;Lorg/jcodec/containers/mkv/MKVType;D)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_D, __args);
			} finally {
			}
		}

		static IntPtr id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxer']/method[@name='createChild' and count(parameter)=3 and parameter[1][@type='org.jcodec.containers.mkv.boxes.EbmlMaster'] and parameter[2][@type='org.jcodec.containers.mkv.MKVType'] and parameter[3][@type='java.lang.String']]"
		[Register ("createChild", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;Lorg/jcodec/containers/mkv/MKVType;Ljava/lang/String;)V", "")]
		public static unsafe void CreateChild (global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster p0, global::Org.Jcodec.Containers.Mkv.MKVType p1, string p2)
		{
			if (id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_lang_String_ == IntPtr.Zero)
				id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createChild", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;Lorg/jcodec/containers/mkv/MKVType;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxer']/method[@name='createChild' and count(parameter)=3 and parameter[1][@type='org.jcodec.containers.mkv.boxes.EbmlMaster'] and parameter[2][@type='org.jcodec.containers.mkv.MKVType'] and parameter[3][@type='java.nio.ByteBuffer']]"
		[Register ("createChild", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;Lorg/jcodec/containers/mkv/MKVType;Ljava/nio/ByteBuffer;)V", "")]
		public static unsafe void CreateChild (global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster p0, global::Org.Jcodec.Containers.Mkv.MKVType p1, global::Java.Nio.ByteBuffer p2)
		{
			if (id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "createChild", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;Lorg/jcodec/containers/mkv/MKVType;Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxer']/method[@name='createChild' and count(parameter)=3 and parameter[1][@type='org.jcodec.containers.mkv.boxes.EbmlMaster'] and parameter[2][@type='org.jcodec.containers.mkv.MKVType'] and parameter[3][@type='java.util.Date']]"
		[Register ("createChild", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;Lorg/jcodec/containers/mkv/MKVType;Ljava/util/Date;)V", "")]
		public static unsafe void CreateChild (global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster p0, global::Org.Jcodec.Containers.Mkv.MKVType p1, global::Java.Util.Date p2)
		{
			if (id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_util_Date_ == IntPtr.Zero)
				id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "createChild", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;Lorg/jcodec/containers/mkv/MKVType;Ljava/util/Date;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_Ljava_util_Date_, __args);
			} finally {
			}
		}

		static IntPtr id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxer']/method[@name='createChild' and count(parameter)=3 and parameter[1][@type='org.jcodec.containers.mkv.boxes.EbmlMaster'] and parameter[2][@type='org.jcodec.containers.mkv.MKVType'] and parameter[3][@type='long']]"
		[Register ("createChild", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;Lorg/jcodec/containers/mkv/MKVType;J)V", "")]
		public static unsafe void CreateChild (global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster p0, global::Org.Jcodec.Containers.Mkv.MKVType p1, long p2)
		{
			if (id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_J == IntPtr.Zero)
				id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_J = JNIEnv.GetStaticMethodID (class_ref, "createChild", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;Lorg/jcodec/containers/mkv/MKVType;J)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_createChild_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_Lorg_jcodec_containers_mkv_MKVType_J, __args);
			} finally {
			}
		}

		static Delegate cb_createVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_Handler ()
		{
			if (cb_createVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_ == null)
				cb_createVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_);
			return cb_createVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_;
		}

		static IntPtr n_CreateVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Size p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateVideoTrack (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxer']/method[@name='createVideoTrack' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Size'] and parameter[2][@type='java.lang.String']]"
		[Register ("createVideoTrack", "(Lorg/jcodec/common/model/Size;Ljava/lang/String;)Lorg/jcodec/containers/mkv/muxer/MKVMuxerTrack;", "GetCreateVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack CreateVideoTrack (global::Org.Jcodec.Common.Model.Size p0, string p1)
		{
			if (id_createVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_ == IntPtr.Zero)
				id_createVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createVideoTrack", "(Lorg/jcodec/common/model/Size;Ljava/lang/String;)Lorg/jcodec/containers/mkv/muxer/MKVMuxerTrack;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createVideoTrack_Lorg_jcodec_common_model_Size_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createVideoTrack", "(Lorg/jcodec/common/model/Size;Ljava/lang/String;)Lorg/jcodec/containers/mkv/muxer/MKVMuxerTrack;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
