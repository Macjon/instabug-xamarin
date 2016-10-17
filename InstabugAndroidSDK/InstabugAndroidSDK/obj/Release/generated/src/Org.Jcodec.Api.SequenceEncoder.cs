using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.api']/class[@name='SequenceEncoder']"
	[global::Android.Runtime.Register ("org/jcodec/api/SequenceEncoder", DoNotGenerateAcw=true)]
	public partial class SequenceEncoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/api/SequenceEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SequenceEncoder); }
		}

		protected SequenceEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.api']/class[@name='SequenceEncoder']/constructor[@name='SequenceEncoder' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe SequenceEncoder (global::Java.IO.File p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SequenceEncoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/File;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_ == IntPtr.Zero)
					id_ctor_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_File_, __args);
			} finally {
			}
		}

		static Delegate cb_encodeNativeFrame_Lorg_jcodec_common_model_Picture_;
#pragma warning disable 0169
		static Delegate GetEncodeNativeFrame_Lorg_jcodec_common_model_Picture_Handler ()
		{
			if (cb_encodeNativeFrame_Lorg_jcodec_common_model_Picture_ == null)
				cb_encodeNativeFrame_Lorg_jcodec_common_model_Picture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EncodeNativeFrame_Lorg_jcodec_common_model_Picture_);
			return cb_encodeNativeFrame_Lorg_jcodec_common_model_Picture_;
		}

		static void n_EncodeNativeFrame_Lorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Api.SequenceEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.SequenceEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncodeNativeFrame (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encodeNativeFrame_Lorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='SequenceEncoder']/method[@name='encodeNativeFrame' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Picture']]"
		[Register ("encodeNativeFrame", "(Lorg/jcodec/common/model/Picture;)V", "GetEncodeNativeFrame_Lorg_jcodec_common_model_Picture_Handler")]
		public virtual unsafe void EncodeNativeFrame (global::Org.Jcodec.Common.Model.Picture p0)
		{
			if (id_encodeNativeFrame_Lorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_encodeNativeFrame_Lorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "encodeNativeFrame", "(Lorg/jcodec/common/model/Picture;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeNativeFrame_Lorg_jcodec_common_model_Picture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeNativeFrame", "(Lorg/jcodec/common/model/Picture;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Api.SequenceEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.SequenceEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		static IntPtr id_finish;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='SequenceEncoder']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			if (id_finish == IntPtr.Zero)
				id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finish);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finish", "()V"));
			} finally {
			}
		}

	}
}
