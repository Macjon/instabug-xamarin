using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Remux']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/Remux", DoNotGenerateAcw=true)]
	public partial class Remux : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/Remux", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Remux); }
		}

		protected Remux (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Remux']/constructor[@name='Remux' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Remux ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Remux)) {
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

		static IntPtr id_hidFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Remux']/method[@name='hidFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("hidFile", "(Ljava/io/File;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File HidFile (global::Java.IO.File p0)
		{
			if (id_hidFile_Ljava_io_File_ == IntPtr.Zero)
				id_hidFile_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "hidFile", "(Ljava/io/File;)Ljava/io/File;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_hidFile_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_main1_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Remux']/method[@name='main1' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main1", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main1 (string[] p0)
		{
			if (id_main1_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main1_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main1", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main1_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_processFrame_Lorg_jcodec_containers_mp4_MP4Packet_;
#pragma warning disable 0169
		static Delegate GetProcessFrame_Lorg_jcodec_containers_mp4_MP4Packet_Handler ()
		{
			if (cb_processFrame_Lorg_jcodec_containers_mp4_MP4Packet_ == null)
				cb_processFrame_Lorg_jcodec_containers_mp4_MP4Packet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessFrame_Lorg_jcodec_containers_mp4_MP4Packet_);
			return cb_processFrame_Lorg_jcodec_containers_mp4_MP4Packet_;
		}

		static IntPtr n_ProcessFrame_Lorg_jcodec_containers_mp4_MP4Packet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Movtool.Remux __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Remux> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mp4.MP4Packet p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.MP4Packet> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProcessFrame (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_processFrame_Lorg_jcodec_containers_mp4_MP4Packet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Remux']/method[@name='processFrame' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mp4.MP4Packet']]"
		[Register ("processFrame", "(Lorg/jcodec/containers/mp4/MP4Packet;)Lorg/jcodec/containers/mp4/MP4Packet;", "GetProcessFrame_Lorg_jcodec_containers_mp4_MP4Packet_Handler")]
		protected virtual unsafe global::Org.Jcodec.Containers.Mp4.MP4Packet ProcessFrame (global::Org.Jcodec.Containers.Mp4.MP4Packet p0)
		{
			if (id_processFrame_Lorg_jcodec_containers_mp4_MP4Packet_ == IntPtr.Zero)
				id_processFrame_Lorg_jcodec_containers_mp4_MP4Packet_ = JNIEnv.GetMethodID (class_ref, "processFrame", "(Lorg/jcodec/containers/mp4/MP4Packet;)Lorg/jcodec/containers/mp4/MP4Packet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Containers.Mp4.MP4Packet __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.MP4Packet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_processFrame_Lorg_jcodec_containers_mp4_MP4Packet_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.MP4Packet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processFrame", "(Lorg/jcodec/containers/mp4/MP4Packet;)Lorg/jcodec/containers/mp4/MP4Packet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
