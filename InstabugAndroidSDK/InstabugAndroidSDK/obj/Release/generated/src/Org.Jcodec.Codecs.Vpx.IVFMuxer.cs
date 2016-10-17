using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vpx {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='IVFMuxer']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vpx/IVFMuxer", DoNotGenerateAcw=true)]
	public partial class IVFMuxer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vpx/IVFMuxer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVFMuxer); }
		}

		protected IVFMuxer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addFrame_Lorg_jcodec_common_model_Packet_;
#pragma warning disable 0169
		static Delegate GetAddFrame_Lorg_jcodec_common_model_Packet_Handler ()
		{
			if (cb_addFrame_Lorg_jcodec_common_model_Packet_ == null)
				cb_addFrame_Lorg_jcodec_common_model_Packet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFrame_Lorg_jcodec_common_model_Packet_);
			return cb_addFrame_Lorg_jcodec_common_model_Packet_;
		}

		static void n_AddFrame_Lorg_jcodec_common_model_Packet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Vpx.IVFMuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.IVFMuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Packet p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFrame (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addFrame_Lorg_jcodec_common_model_Packet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='IVFMuxer']/method[@name='addFrame' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Packet']]"
		[Register ("addFrame", "(Lorg/jcodec/common/model/Packet;)V", "GetAddFrame_Lorg_jcodec_common_model_Packet_Handler")]
		public virtual unsafe void AddFrame (global::Org.Jcodec.Common.Model.Packet p0)
		{
			if (id_addFrame_Lorg_jcodec_common_model_Packet_ == IntPtr.Zero)
				id_addFrame_Lorg_jcodec_common_model_Packet_ = JNIEnv.GetMethodID (class_ref, "addFrame", "(Lorg/jcodec/common/model/Packet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFrame_Lorg_jcodec_common_model_Packet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFrame", "(Lorg/jcodec/common/model/Packet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Vpx.IVFMuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vpx.IVFMuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='IVFMuxer']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

	}
}
